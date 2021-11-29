using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Bases
{
    public abstract class CrudRepositoryBase<TDomain> : RepositoryBase, ICrudRepository<TDomain>
        where TDomain : class
    {
        protected readonly ILogger<CrudRepositoryBase<TDomain>> logger;

        protected readonly DbSet<TDomain> dbSet;

        protected CrudRepositoryBase(IApiDbContext dbContext, ILogger<CrudRepositoryBase<TDomain>> logger) : base(dbContext)
        {
            dbSet = dbContext.DbContext.Set<TDomain>();
            this.logger = logger;
        }

        /// <inheritdoc/>
        public virtual async Task<TDomain> AddAsync(TDomain entity)
        {
            try
            {
                dbSet.Attach(entity);
                var createdEntity = await dbSet.AddAsync(entity);
                return createdEntity.Entity;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed while adding {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task DeleteByIdAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id).ConfigureAwait(false);
                if (entity != null)
                {
                    dbSet.Remove(entity);
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on Delete with {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task<IEnumerable<TDomain>> GetAllAsync()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed getting all {typeof(TDomain)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual async Task<TDomain> GetByIdAsync(int id)
        {
            try
            {
                return await dbSet.FindAsync(id);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on GetById with {typeof(TDomain)} with id {id}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <inheritdoc/>
        public virtual TDomain Update(TDomain entity)
        {
            try
            {
                dbSet.Attach(entity);
                var updatedEntity = dbSet.Update(entity);
                return updatedEntity.Entity;
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on Update with {typeof(TDomain)}");
                throw new ArgumentException("Failed updating entity");
            }
        }
    }
}
