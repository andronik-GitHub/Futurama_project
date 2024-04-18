using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using GalaxyExpress.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyExpress.DAL.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity, Guid> where TEntity : BaseEntity
    {
        protected readonly GalaxyExpressContext_SQLServer dbContext;
        protected readonly DbSet<TEntity> entities;

        protected GenericRepository(
            GalaxyExpressContext_SQLServer dbContext)
        {
            this.dbContext = dbContext;
            this.entities = dbContext.Set<TEntity>();
        }


        public virtual async Task<Guid> CreateAsync (TEntity entity)
        {
            await entities.AddAsync(entity);
            return entity.Id;
        }
        
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await entities.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await entities.FindAsync(id);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            var existingEntity = await GetByIdAsync(entity.Id);

            if (existingEntity == null)
                throw new Exception($"{typeof(TEntity).Name} with id: [{entity.Id}] was not found");
            if (existingEntity.DateDeleted != null)
                throw new Exception($"{typeof(TEntity).Name} with id: [{entity.Id}] already deleted");


            dbContext.Entry(existingEntity).State = EntityState.Detached;

            entity.DateUpdated = DateTime.UtcNow;
            entity.DateCreated = existingEntity.DateCreated;
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);

            if (entity == null)
                throw new Exception($"{typeof(TEntity).Name} with id: [{id}] was not found");
            if (entity.DateDeleted != null)
                throw new Exception($"{typeof(TEntity).Name} with id: [{id}] already deleted");

            dbContext.Entry(entity).State = EntityState.Detached;
            entity.DateDeleted = DateTime.UtcNow;
            await UpdateAsync(entity);
        }
    }
}
