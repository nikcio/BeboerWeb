using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Application.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public interface IEmployeeToTenantMessageService : ICrudServiceBase<EmployeeToTenantMessage, IEmployeeToTenantMessageRepository>
    {
        Task<IServiceResponse<IEnumerable<EmployeeToTenantMessage>>> GetAll(int receiverId);
        Task<IServiceResponse<IEnumerable<EmployeeToTenantMessage>>> GetAllSent(int sernderId);
    }
}
