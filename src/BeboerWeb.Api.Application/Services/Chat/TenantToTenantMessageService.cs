using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public class TenantToTenantMessageService : CrudServiceBase<TenantToTenantMessage, ITenantToTenantMessageRepository>, ITenantToTenantMessageService
    {
        public TenantToTenantMessageService(ITenantToTenantMessageRepository repository, ILogger<ServiceBase<ITenantToTenantMessageRepository>> logger) : base(repository, logger)
        {
        }

        public override Task<IServiceResponse<TenantToTenantMessage>> Add(TenantToTenantMessage entity)
        {
            entity.TimeStamp = DateTime.Now;
            return base.Add(entity);
        }
    }
}
