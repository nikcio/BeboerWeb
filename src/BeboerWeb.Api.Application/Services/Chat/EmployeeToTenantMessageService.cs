using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class EmployeeToTenantMessageService : CrudServiceBase<EmployeeToTenantMessage, IEmployeeToTenantMessageRepository>, IEmployeeToTenantMessageService
    {
        public EmployeeToTenantMessageService(IEmployeeToTenantMessageRepository repository, ILogger<ServiceBase<IEmployeeToTenantMessageRepository>> logger) : base(repository, logger)
        {
        }
    }

}
