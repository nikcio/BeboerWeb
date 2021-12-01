using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Chat
{
    public class TenantToEmployeeMessageRepository : CrudRepositoryBase<TenantToEmployeeMessage>, ITenantToEmployeeMessageRepository
    {
        public TenantToEmployeeMessageRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<TenantToEmployeeMessage>> logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<TenantToEmployeeMessage>> GetAllAsync()
        {
            var output = await base.GetAllAsync();
            foreach (var item in output)
            {
                await GetDBContext().Entry(item).Collection(p => p.Receivers).LoadAsync();
                await GetDBContext().Entry(item).Reference(p => p.Sender).LoadAsync();
            }
            return output;
        }

        public async override Task<TenantToEmployeeMessage> GetByIdAsync(int id)
        {
            var output = await base.GetByIdAsync(id);
            await GetDBContext().Entry(output).Collection(p => p.Receivers).LoadAsync();
            await GetDBContext().Entry(output).Reference(p => p.Sender).LoadAsync();
            return output;
        }

        public async Task<IEnumerable<TenantToEmployeeMessage>> GetAllAsync(int receiverId)
        {
            var output = await base.GetAllAsync();
            foreach (var item in output)
            {
                await GetDBContext().Entry(item).Collection(p => p.Receivers).LoadAsync();
                await GetDBContext().Entry(item).Reference(p => p.Sender).LoadAsync();
            }
            output = output.Where(item => item.Receivers.Any(receiver => receiver.Id == receiverId));
            return output;
        }

        public async Task<IEnumerable<TenantToEmployeeMessage>> GetAllSentAsync(int senderId)
        {
            var output = await base.GetAllAsync();
            foreach (var item in output)
            {
                await GetDBContext().Entry(item).Collection(p => p.Receivers).LoadAsync();
                await GetDBContext().Entry(item).Reference(p => p.Sender).LoadAsync();
            }
            output = output.Where(item => item.Sender.Id == senderId);
            return output;
        }
    }
}
