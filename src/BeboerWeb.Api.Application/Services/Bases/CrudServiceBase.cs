using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public abstract class CrudServiceBase<TDomain, TRepository> : ServiceBase<TRepository>, ICrudServiceBase<TDomain, TRepository>
        where TDomain : class
        where TRepository : IRepository, ICrudRepository<TDomain>
    {
        private readonly TRepository repository;

        public CrudServiceBase(TRepository repository, ILogger<ServiceBase<TRepository>> logger) : base(repository, logger)
        {
            this.repository = repository;
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> Add(TDomain entity)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.AddAsync(entity);
            }, StatusCode.Created);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> DeleteById(int id)
        {
            return await ExecuteServiceTask<TDomain>(async () =>
            {
                await repository.DeleteByIdAsync(id);
                return null;
            }, StatusCode.Success);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<IEnumerable<TDomain>>> GetAll()
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetAllAsync();
            }, StatusCode.Success);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> GetById(int id)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetByIdAsync(id);
            }, StatusCode.Success);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<TDomain>> Update(TDomain entity)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await Task.Run(() => repository.Update(entity));
            }, StatusCode.Success);
        }
    }
}
