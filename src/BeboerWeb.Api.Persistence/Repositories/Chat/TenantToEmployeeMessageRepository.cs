using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Chat
{
    public class TenantToEmployeeMessageRepository : CrudRepositoryBase<TenantToEmployeeMessage>, ITenantToEmployeeMessageRepository
    {
        public TenantToEmployeeMessageRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<TenantToEmployeeMessage>> logger) : base(dbContext, logger)
        {
        }
    }
}
