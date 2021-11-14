using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public abstract class ServiceBase<R> : UnitOfWork<R>, IServiceBase<R>
        where R : IRepository
    {
        protected ILogger<ServiceBase<R>> Logger { get; }

        public ServiceBase(R repository, ILogger<ServiceBase<R>> logger) : base(repository)
        {
            Logger = logger;
        }

        protected virtual async Task<IServiceResponse<T>> ExceuteServiceTask<T>(Action action) where T : class
        {
            return await ExceuteServiceTask<T>(() =>
            {
                action.Invoke();
                return null;
            }).ConfigureAwait(false);
        }

        protected virtual async Task<IServiceResponse<T>> ExceuteServiceTask<T>(Func<Task<T>> func) where T : class
        {
            try
            {
                await BeginUnitOfWorkAsync();
                var response = await func.Invoke().ConfigureAwait(false);
                await CommitUnitOfWorkAsync();
                return new ServiceResponse<T>(StatusCode.Created, response);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, $"Task failed with {typeof(T)}");
                return new ServiceResponse<T>(StatusCode.Error, null);
            }
        }
    }
}