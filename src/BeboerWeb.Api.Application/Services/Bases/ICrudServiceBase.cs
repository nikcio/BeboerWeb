using BeboerWeb.Shared.Application.Services;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public interface ICrudServiceBase<TDomain, TRepository> : IServiceBase<TRepository>, ICrudService<TDomain>
        where TDomain : class
        where TRepository : IRepository, ICrudRepository<TDomain>
    {
    }
}