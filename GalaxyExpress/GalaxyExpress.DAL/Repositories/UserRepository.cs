using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GalaxyExpressContext_SQLServer dbContext;
        private readonly UserManager<User> _userManager;

        private readonly IQueryable<User> entities;


        public UserRepository(
            GalaxyExpressContext_SQLServer dbContext, 
            UserManager<User> userManager)
        {
            this.dbContext = dbContext;
            _userManager = userManager;

            entities = _userManager.Users;
        }


        public async Task<Guid> CreateAsync(User entity)
        {
            var result = await _userManager.CreateAsync(entity);

            if (result.Succeeded) return entity.Id;

            var errorMessage = string.Join("\n", result.Errors.Select(er => er.Description));
            throw new Exception($"Adding user to database failed. \n Errors: {errorMessage}");
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await entities
                .AsNoTracking()
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .ToListAsync();
        }

        public async Task<User?> GetByIdAsync(Guid key)
        {
            return await entities
                .AsNoTracking()
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .FirstOrDefaultAsync(u => u.Id == key);
        }

        public async Task UpdateAsync(User entity)
        {
            var existingEntity = await GetByIdAsync(entity.Id);

            if (existingEntity == null)
                throw new Exception($"{typeof(User).Name} with id: [{entity.Id}] was not found");
            if (existingEntity.DateDeleted != null)
                throw new Exception($"{typeof(User).Name} with id: [{entity.Id}] already deleted");

            entity.DateUpdated = DateTime.UtcNow;

            var result = await _userManager.UpdateAsync(entity);
            if (!result.Succeeded)
            {
                var errorMessage = string.Join("\n", result.Errors.Select(er => er.Description));
                throw new Exception($"Adding user to database failed. \n Errors: {errorMessage}");
            }
        }

        public async Task DeleteAsync(Guid key)
        {
            var entity = await GetByIdAsync(key);

            if (entity == null)
                throw new Exception($"{typeof(User).Name} with id: [{key}] was not found");
            if (entity.DateDeleted != null)
                throw new Exception($"{typeof(User).Name} with id: [{key}] already deleted");

            dbContext.Entry(entity).State = EntityState.Modified;
            entity.DateDeleted = DateTime.UtcNow;
            await UpdateAsync(entity);
        }


        public async Task<int> GetCountOfUsersAsync()
        {
            var count = await entities.AsNoTracking().CountAsync();
            
            return count;
        }

        public async Task<int> GetCountOfUsersNotDeletedAsync()
        {
            var count = await entities
                .AsNoTracking()
                .Where(u => u.DateDeleted == null)
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .CountAsync();

            return count;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            Guid? userId = await dbContext.Emails
                .AsNoTracking()
                .Where(e => e.EmailAddress == email)
                .Select(e => e.UserId)
                .FirstOrDefaultAsync();

            if (userId == null) return null;

            var user = await GetByIdAsync((Guid)userId);

            return user;
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await entities
                .AsNoTracking()
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .FirstOrDefaultAsync(u => u.UserName == username);
        }
        
        public async Task<User?> GetByLoginAsync(string login)
        {
            return await entities
                .AsNoTracking()
                .Include(u => u.Emails)
                .Include(u => u.PhoneNumbers)
                .FirstOrDefaultAsync(u => u.Login == login);
        }
    }
}
