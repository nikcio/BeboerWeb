using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public class CrudServiceBase<T, R> : ServiceBase<R>, ICrudServiceBase<T, R>
        where T : class
        where R : IRepository, ICrudRepository<T>
    {
        private readonly R repository;

        public CrudServiceBase(R repository, ILogger<ServiceBase<R>> logger) : base(repository, logger)
        {
            this.repository = repository;
        }

        public async Task<IServiceResponse<T>> Add(T entity)
        {
            return await ExceuteServiceTask<T>(async () =>
            {
                await repository.AddAsync(entity);
            });
        }

        public async Task<IServiceResponse<T>> DeleteById(int id)
        {
            return await ExceuteServiceTask<T>(async () =>
            {
                await repository.DeleteByIdAsync(id);
            });
        }

        public async Task<IServiceResponse<List<T>>> GetAll()
        {
            return await ExceuteServiceTask(async () =>
            {
                return await repository.GetAllAsync();
            });
        }

        public async Task<IServiceResponse<T>> GetById(int id)
        {
            return await ExceuteServiceTask(async () =>
            {
                return await repository.GetByIdAsync(id);
            });
        }

        public async Task<IServiceResponse<T>> Update(T entity)
        {
            return await ExceuteServiceTask<T>(() =>
            {
                repository.Update(entity);
            });
        }
    }
}
