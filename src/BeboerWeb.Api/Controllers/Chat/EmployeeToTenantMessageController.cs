using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Services.Chat;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Chat

{
    [Route("api/Chat/EmployeeToTenantMessage")]
    [ApiController]
    public class EmployeeToTenantMessageController : CrudControllerBase<EmployeeToTenantMessageDto, EmployeeToTenantMessage, IEmployeeToTenantMessageRepository, IEmployeeToTenantMessageService>
    {
        public EmployeeToTenantMessageController(IEmployeeToTenantMessageService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
