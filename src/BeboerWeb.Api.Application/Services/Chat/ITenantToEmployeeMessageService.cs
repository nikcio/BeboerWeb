using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public interface ITenantToEmployeeMessageService : ICrudServiceBase<TenantToEmployeeMessage, ITenantToEmployeeMessageRepository>
    {
        Task<IServiceResponse<IEnumerable<TenantToEmployeeMessage>>> GetAll(int receiverId);
        Task<IServiceResponse<IEnumerable<TenantToEmployeeMessage>>> GetAllSent(int senderId);
    }
}
