using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Chat;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Controllers.Chat
{
    [Route("api/Chat/TenantToEmployeeMessage")]
    [ApiController]
    public class TenantToEmployeeMessageController : CrudControllerBase<TenantToEmployeeMessageDto, TenantToEmployeeMessage, ITenantToEmployeeMessageRepository, ITenantToEmployeeMessageService>
    {
        public TenantToEmployeeMessageController(ITenantToEmployeeMessageService service, IMapper mapper) : base(service, mapper)
        {
        }

        [HttpGet("GetAllForReceiver/{receiverId}")]
        public virtual async Task<ActionResult<IEnumerable<TenantToEmployeeMessageDto>>> GetAllForReceiver(int receiverId)
        {
            var serviceResponse = await service.GetAll(receiverId);
            return CreateResponse<IEnumerable<TenantToEmployeeMessage>, IEnumerable<TenantToEmployeeMessageDto>>(serviceResponse);
        }

        [HttpGet("GetAllForSender/{senderId}")]
        public virtual async Task<ActionResult<IEnumerable<TenantToEmployeeMessageDto>>> GetAllForSender(int senderId)
        {
            var serviceResponse = await service.GetAllSent(senderId);
            return CreateResponse<IEnumerable<TenantToEmployeeMessage>, IEnumerable<TenantToEmployeeMessageDto>>(serviceResponse);
        }
    }
}
