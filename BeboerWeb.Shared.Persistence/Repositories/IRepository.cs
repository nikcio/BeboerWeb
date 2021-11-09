using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Shared.Persistence.Repositories
{
    public interface IRepository
    {
        DbContext GetDBContext();
    }
}
