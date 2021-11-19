using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public interface IServiceBase<TRepository> : IUnitOfWork<TRepository>
        where TRepository : IRepository
    {
    }
}