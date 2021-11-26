using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Chat;

namespace BeboerWeb.Api.Application.Services.Chat
{
    public interface ITenantToTenantMessageService : ICrudServiceBase<TenantToTenantMessage, ITenantToTenantMessageRepository>
    {
    }
}
