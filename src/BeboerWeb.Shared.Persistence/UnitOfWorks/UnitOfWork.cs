using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace BeboerWeb.Shared.Persistence.UnitOfWorks
{
    public class UnitOfWork<TRepository> : IUnitOfWork<TRepository>
        where TRepository : IRepository
    {
        private readonly DbContext _context;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(TRepository repository)
        {
            _context = repository.GetDBContext();
        }

        /// <inheritdoc/>
        public async Task BeginUnitOfWorkAsync(IsolationLevel IsolationLevel)
        {
            _transaction = await _context.Database.BeginTransactionAsync(IsolationLevel);
        }

        /// <inheritdoc/>
        public Task BeginUnitOfWorkAsync()
        {
            return BeginUnitOfWorkAsync(IsolationLevel.Serializable);
        }

        /// <inheritdoc/>
        public async Task CommitUnitOfWorkAsync()
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
