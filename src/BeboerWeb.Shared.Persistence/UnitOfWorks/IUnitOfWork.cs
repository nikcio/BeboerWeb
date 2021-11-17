using BeboerWeb.Shared.Persistence.Repositories;
using System.Data;

namespace BeboerWeb.Shared.Persistence.UnitOfWorks
{
    public interface IUnitOfWork<TRepository> where TRepository : IRepository
    {
        /// <summary>
        /// Begins a unit of work opreation
        /// </summary>
        /// <param name="IsolationLevel"></param>
        /// <returns></returns>
        Task BeginUnitOfWorkAsync(IsolationLevel IsolationLevel = IsolationLevel.Serializable);

        /// <summary>
        /// Commits a unit of work opreation
        /// </summary>
        /// <returns></returns>
        Task CommitUnitOfWorkAsync();
    }
}
