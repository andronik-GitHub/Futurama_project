using GalaxyExpress.BLL.Mapping;
using GalaxyExpress.BLL.DTOs.UserDTOs;
using GalaxyExpress.BLL.Services.Interfaces;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;

        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<Guid> CreateAsync(InsertDTO_User entity)
        {
            User user = MappingFunctions.MapSourceToDestination<InsertDTO_User, User>(entity); // Mapping with Mapster

            var id = await _uow.Users.CreateAsync(user);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<GetDTO_User>> GetAllAsync()
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<User, GetDTO_User>
                (await _uow.Users.GetAllAsync());
        }
        public async Task<GetDTO_User?> GetAsync(Guid key)
        {
            User? user = await _uow.Users.GetByIdAsync(key);

            GetDTO_User? userDTO = MappingFunctions
                .MapSourceToDestination<User?, GetDTO_User?>(user); // Mapping with Mapster

            return userDTO;
        }
        public async Task UpdateAsync(UpdateDTO_User entity)
        {
            var checkUser = await _uow.Users.GetByIdAsync(entity.UserId);
            if (checkUser == null) throw new Exception($"{nameof(User)} with id: [{entity.UserId}] was not found");

            _uow._dbContext.Entry(checkUser).State = EntityState.Detached;
            User user = (User)checkUser.Clone();

            foreach (var keyValuePair in entity.Values)
                if (keyValuePair.Key != "DateCreated" && keyValuePair.Key != "DateUpdated" && keyValuePair.Key != "DateDeleted")
                {
                    var property = user.GetType().GetProperty(keyValuePair.Key);

                    if (property != null && property.CanWrite)
                    {
                        if (property.Name == "PasswordHash")
                            property.SetValue(user, new PasswordHasher<User>().HashPassword(null!, keyValuePair.Value));
                        else
                            property.SetValue(user, keyValuePair.Value);

                        if (property.Name is "PasswordHash" or "UserName")
                            user.GetType().GetProperty("SecurityStamp")?.SetValue(user, Guid.NewGuid().ToString("N").ToUpper());
                    }
                }

            _uow._dbContext.Entry(user).State = EntityState.Modified;

            await _uow.Users.UpdateAsync(user);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid key)
        {
            await _uow.Users.DeleteAsync(key);
            await _uow.SaveChangesAsync();
        }


        public async Task<int> GetCountOfUsersAsync()
        {
            var count = await _uow.Users.GetCountOfUsersAsync();

            return count;
        }

        public async Task<int> GetCountOfUsersNotDeletedAsync()
        {
            var count = await _uow.Users.GetCountOfUsersNotDeletedAsync();

            return count;
        }
    }
}
