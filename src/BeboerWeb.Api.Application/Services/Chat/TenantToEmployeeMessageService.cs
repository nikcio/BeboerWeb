using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class TenantToEmployeeMessageService : CrudServiceBase<TenantToEmployeeMessage, ITenantToEmployeeMessageRepository>, ITenantToEmployeeMessageService
    {
        public TenantToEmployeeMessageService(ITenantToEmployeeMessageRepository repository, ILogger<ServiceBase<ITenantToEmployeeMessageRepository>> logger) : base(repository, logger)
        {
        }
    }
}
