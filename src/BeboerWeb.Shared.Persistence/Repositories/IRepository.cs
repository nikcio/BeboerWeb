using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Shared.Persistence.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// Gets the db context
        /// </summary>
        /// <returns></returns>
        DbContext GetDBContext();
    }
}
