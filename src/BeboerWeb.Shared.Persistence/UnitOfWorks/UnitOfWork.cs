using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace BeboerWeb.Shared.Persistence.UnitOfWorks
{
    public class UnitOfWork<R> : IUnitOfWork<R> where R : IRepository
    {
        private readonly DbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(R repository)
        {
            _context = repository.GetDBContext();
        }

        public async Task BeginUnitOfWork()
        {
            await BeginUnitOfWork(IsolationLevel.Serializable);
        }

        public async Task BeginUnitOfWork(IsolationLevel IsolationLevel)
        {
            _transaction = await _context.Database.BeginTransactionAsync(IsolationLevel);
        }

        public async Task CommitUnitOfWork()
        {
            if (_transaction != null)
            {
                try
                {
                    await _context.SaveChangesAsync();
                    await _transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await _transaction.RollbackAsync();
                    throw;
                }
            }
            else
            {
                throw new ArgumentNullException("_transtaction", "_transtaction cannot be null");
            }
        }
    }
}
