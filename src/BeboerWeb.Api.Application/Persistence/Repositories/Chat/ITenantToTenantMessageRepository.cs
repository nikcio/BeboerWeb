using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Chat
{
    public interface ITenantToTenantMessageRepository : IRepository, ICrudRepository<TenantToTenantMessage>
    {
        Task<IEnumerable<TenantToTenantMessage>> GetAllAsync(int receiverId);
        Task<IEnumerable<TenantToTenantMessage>> GetAllSentAsync(int senderId);
    }
}
