using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Chat
{
    public interface IEmployeeToTenantMessageRepository : IRepository, ICrudRepository<EmployeeToTenantMessage>
    {
        Task<IEnumerable<EmployeeToTenantMessage>> GetAllAsync(int receiverId);
        Task<IEnumerable<EmployeeToTenantMessage>> GetAllSentAsync(int senderId);
    }
}
