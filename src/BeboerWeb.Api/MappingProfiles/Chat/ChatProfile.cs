using AutoMapper;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;

namespace BeboerWeb.Api.MappingProfiles.Chat
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<TenantToTenantMessage, TenantToTenantMessageDto>();
            CreateMap<TenantToTenantMessageDto, TenantToTenantMessage>();

            CreateMap<TenantToEmployeeMessage, TenantToEmployeeMessageDto>();   
            CreateMap<TenantToEmployeeMessageDto, TenantToEmployeeMessage>();

            CreateMap<EmployeeToTenantMessage, EmployeeToTenantMessageDto>();
            CreateMap<EmployeeToTenantMessageDto, EmployeeToTenantMessage>();
        }
    }
}
