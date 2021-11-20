using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.Contexts
{
    public interface IDbContext
    {
        DbContext DbContext { get; }
    }
}