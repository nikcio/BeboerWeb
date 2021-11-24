using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public abstract class ServiceBase<TRepository> : UnitOfWork<TRepository>, IServiceBase<TRepository>
        where TRepository : IRepository
    {
        protected ILogger<ServiceBase<TRepository>> Logger { get; }

        public ServiceBase(TRepository repository, ILogger<ServiceBase<TRepository>> logger) : base(repository)
        {
            Logger = logger;
        }

        /// <summary>
        /// Executes an func that returns a value within a unit of work
        /// </summary>
        /// <typeparam name="TDomain"></typeparam>
        /// <param name="func"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        protected virtual async Task<IServiceResponse<TDomain>> ExecuteServiceTask<TDomain>(Func<Task<TDomain>> func, StatusCode statusCode)
            where TDomain : class
        {
            try
            {
                await BeginUnitOfWorkAsync();
                var response = await func.Invoke().ConfigureAwait(false);
                await CommitUnitOfWorkAsync();
                return new ServiceResponse<TDomain>(statusCode, response);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, $"Task failed with {typeof(TDomain)}");
                return new ServiceResponse<TDomain>(StatusCode.Error, null);
            }
        }
    }
}