using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class EmployeeToTenantMessageService : CrudServiceBase<EmployeeToTenantMessage, IEmployeeToTenantMessageRepository>, IEmployeeToTenantMessageService
    {
        public EmployeeToTenantMessageService(IEmployeeToTenantMessageRepository repository, ILogger<ServiceBase<IEmployeeToTenantMessageRepository>> logger) : base(repository, logger)
        {
        }

        public override Task<IServiceResponse<EmployeeToTenantMessage>> Add(EmployeeToTenantMessage entity)
        {
            entity.TimeStamp = DateTime.Now;
            return base.Add(entity);
        }

        
    }

}
