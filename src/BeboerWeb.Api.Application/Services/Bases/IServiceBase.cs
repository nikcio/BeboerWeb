using BeboerWeb.Shared.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public interface IServiceBase<R> : IUnitOfWork<R> 
        where R : IRepository
    {
    }
}