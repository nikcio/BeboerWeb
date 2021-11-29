using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class TenantToEmployeeMessageService : CrudServiceBase<TenantToEmployeeMessage, ITenantToEmployeeMessageRepository>, ITenantToEmployeeMessageService
    {
        public TenantToEmployeeMessageService(ITenantToEmployeeMessageRepository repository, ILogger<ServiceBase<ITenantToEmployeeMessageRepository>> logger) : base(repository, logger)
        {
        }

        public override Task<IServiceResponse<TenantToEmployeeMessage>> Add(TenantToEmployeeMessage entity)
        {
            entity.TimeStamp = DateTime.Now;
            return base.Add(entity);
        }
    }
}
