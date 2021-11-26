using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Chat;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Chat
{
    [Route("api/Chat/TenantToTenantMessage")]
    [ApiController]
    public class TenantToTenantMessageController : CrudControllerBase<TenantToTenantMessageDto, TenantToTenantMessage, ITenantToTenantMessageRepository, ITenantToTenantMessageService>
    {
        public TenantToTenantMessageController(ITenantToTenantMessageService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
