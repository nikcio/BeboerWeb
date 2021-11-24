using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class TenantToTenantMessageService : CrudServiceBase<TenantToTenantMessage, ITenantToTenantMessageRepository>, ITenantToTenantMessageService
    {
        public TenantToTenantMessageService(ITenantToTenantMessageRepository repository, ILogger<ServiceBase<ITenantToTenantMessageRepository>> logger) : base(repository, logger)
        {
        }
    }
}
