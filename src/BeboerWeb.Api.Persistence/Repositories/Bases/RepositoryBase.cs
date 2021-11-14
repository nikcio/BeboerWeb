using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.Repositories.Bases
{
    public abstract class RepositoryBase : IRepository
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public DbContext GetDBContext()
        {
            return _context;
        }
    }
}