using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Chat
{
    public interface ITenantToEmployeeMessageRepository : IRepository, ICrudRepository<TenantToEmployeeMessage>
    {
        Task<IEnumerable<TenantToEmployeeMessage>> GetAllAsync(int receiverId);
        Task<IEnumerable<TenantToEmployeeMessage>> GetAllSentAsync(int senderId);
    }
}
