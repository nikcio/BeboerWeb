using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Chat
{
    public class TenantToTenantMessageRepository : CrudRepositoryBase<TenantToTenantMessage>, ITenantToTenantMessageRepository
    {
        public TenantToTenantMessageRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<TenantToTenantMessage>> logger) : base(dbContext, logger)
        {
        }
    }
}
