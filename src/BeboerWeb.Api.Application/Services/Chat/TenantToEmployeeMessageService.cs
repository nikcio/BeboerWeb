using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using BeboerWeb.Shared.Application.Enums;
using System.Collections.Generic;

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

        public async Task<IServiceResponse<IEnumerable<TenantToEmployeeMessage>>> GetAll(int receiverId)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetAllAsync(receiverId);
            }, StatusCode.Success);
        }

        public async Task<IServiceResponse<IEnumerable<TenantToEmployeeMessage>>> GetAllSent(int senderId)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetAllSentAsync(senderId);
            }, StatusCode.Success);
        }
    }
}
