using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public abstract class CrudServiceBase<T, R> : ServiceBase<R>, ICrudServiceBase<T, R>
        where T : class
        where R : IRepository, ICrudRepository<T>
    {
        private readonly R repository;

        public CrudServiceBase(R repository, ILogger<ServiceBase<R>> logger) : base(repository, logger)
        {
            this.repository = repository;
        }

        public virtual async Task<IServiceResponse<T>> Add(T entity)
        {
            return await ExceuteServiceTask<T>(async () =>
            {
                await repository.AddAsync(entity);
            });
        }

        public virtual async Task<IServiceResponse<T>> DeleteById(int id)
        {
            return await ExceuteServiceTask<T>(async () =>
            {
                await repository.DeleteByIdAsync(id);
            });
        }

        public virtual async Task<IServiceResponse<List<T>>> GetAll()
        {
            return await ExceuteServiceTask(async () =>
            {
                return await repository.GetAllAsync();
            });
        }

        public virtual async Task<IServiceResponse<T>> GetById(int id)
        {
            return await ExceuteServiceTask(async () =>
            {
                return await repository.GetByIdAsync(id);
            });
        }

        public virtual async Task<IServiceResponse<T>> Update(T entity)
        {
            return await ExceuteServiceTask<T>(() =>
            {
                repository.Update(entity);
            });
        }
    }
}
