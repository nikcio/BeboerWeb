using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.Repositories.Bases
{
    public abstract class RepositoryBase : IRepository
    {
        private readonly DbContext _context;

        public RepositoryBase(IApiDbContext context)
        {
            _context = context.DbContext;
        }

        /// <inheritdoc/>
        public virtual DbContext GetDBContext()
        {
            return _context;
        }
    }
}