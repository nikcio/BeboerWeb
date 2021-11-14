using BeboerWeb.Shared.Application.Services;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Services.Bases
{
    public interface ICrudServiceBase<T, R> : IServiceBase<R>, ICrudService<T>
        where T : class
        where R : IRepository, ICrudRepository<T>
    {
    }
}