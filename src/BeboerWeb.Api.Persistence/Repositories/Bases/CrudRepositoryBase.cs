using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Bases
{
    public class CrudRepositoryBase<T> : RepositoryBase, ICrudRepository<T> where T : class
    {
        private readonly ILogger<CrudRepositoryBase<T>> logger;

        private readonly DbSet<T> dbSet;

        public CrudRepositoryBase(DbContext dbContext, ILogger<CrudRepositoryBase<T>> logger) : base(dbContext)
        {
            dbSet = dbContext.Set<T>();
            this.logger = logger;
        }

        public async Task Add(T entity)
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

        public async Task DeleteById(int id)
        {
            try
            {
                var entity = await GetById(id).ConfigureAwait(false);
                dbSet.Remove(entity);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed on Delete with {typeof(T)}");
                throw new TaskCanceledException("Task failed");
            }
        }

        public async Task<List<T>> GetAll()
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

        public async Task<T> GetById(int id)
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

        public void Update(T entity)
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
