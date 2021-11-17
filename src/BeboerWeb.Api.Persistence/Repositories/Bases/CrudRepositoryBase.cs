using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Bases
{
    public abstract class CrudRepositoryBase<T> : RepositoryBase, ICrudRepository<T> where T : class
    {
        private readonly ILogger<CrudRepositoryBase<T>> logger;

        private readonly DbSet<T> dbSet;

        public CrudRepositoryBase(IApiDbContext dbContext, ILogger<CrudRepositoryBase<T>> logger) : base(dbContext)
        {
            dbSet = dbContext.DbContext.Set<T>();
            this.logger = logger;
        }

        /// <summary>
        /// Adds entity to database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="TaskCanceledException"></exception>
        public virtual async Task AddAsync(T entity)
        {
            try
            {
                await dbSet.AddAsync(entity);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed while adding {typeof(T)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="TaskCanceledException"></exception>
        public virtual async Task DeleteByIdAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id).ConfigureAwait(false);
                dbSet.Remove(entity);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on Delete with {typeof(T)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <summary>
        /// Gets all entities
        /// </summary>
        /// <returns></returns>
        /// <exception cref="TaskCanceledException"></exception>
        public virtual async Task<List<T>> GetAllAsync()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed getting all {typeof(T)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <summary>
        /// Gets an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="TaskCanceledException"></exception>
        public virtual async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await dbSet.FindAsync(id);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on GetById with {typeof(T)} with id {id}");
                throw new TaskCanceledException("Task failed");
            }
        }

        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="ArgumentException"></exception>
        public virtual void Update(T entity)
        {
            try
            {
                dbSet.Update(entity);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on Update with {typeof(T)}");
                throw new ArgumentException("Failed updating entity");
            }
        }
    }
}
