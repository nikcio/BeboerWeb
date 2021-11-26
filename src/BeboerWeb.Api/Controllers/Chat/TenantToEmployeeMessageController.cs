using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Chat;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Chat
{
    [Route("api/Chat/TenantToEmployeeMessage")]
    [ApiController]
    public class TenantToEmployeeMessageController : CrudControllerBase<TenantToEmployeeMessageDto, TenantToEmployeeMessage, ITenantToEmployeeMessageRepository, ITenantToEmployeeMessageService>
    {
        public TenantToEmployeeMessageController(ITenantToEmployeeMessageService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
