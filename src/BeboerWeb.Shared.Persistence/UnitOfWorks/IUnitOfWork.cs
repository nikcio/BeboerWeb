using BeboerWeb.Shared.Persistence.Repositories;
using System.Data;

namespace BeboerWeb.Shared.Persistence.UnitOfWorks
{
    public interface IUnitOfWork<R> where R : IRepository
    {
        Task BeginUnitOfWorkAsync();
        Task BeginUnitOfWork(IsolationLevel IsolationLevel);
        Task CommitUnitOfWorkAsync();
    }
}
