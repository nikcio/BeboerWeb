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

        /// <summary>
        /// Gets the db context
        /// </summary>
        /// <returns></returns>
        public virtual DbContext GetDBContext()
        {
            return _context;
        }
    }
}