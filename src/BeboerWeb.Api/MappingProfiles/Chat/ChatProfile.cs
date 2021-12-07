using AutoMapper;
using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Api.Models.DTOs.Chat;
using System;
using System.Globalization;

namespace BeboerWeb.Api.MappingProfiles.Chat
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<TenantToTenantMessage, TenantToTenantMessageDto>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => src.TimeStamp.ToString("F", new CultureInfo("da-DK"))));
            CreateMap<TenantToTenantMessageDto, TenantToTenantMessage>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => DateTime.Parse(src.TimeStamp, new CultureInfo("da-DK"))));

            CreateMap<TenantToEmployeeMessage, TenantToEmployeeMessageDto>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => src.TimeStamp.ToString("F", new CultureInfo("da-DK"))));
            CreateMap<TenantToEmployeeMessageDto, TenantToEmployeeMessage>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => DateTime.Parse(src.TimeStamp, new CultureInfo("da-DK"))));

            CreateMap<EmployeeToTenantMessage, EmployeeToTenantMessageDto>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => src.TimeStamp.ToString("F", new CultureInfo("da-DK"))));
            CreateMap<EmployeeToTenantMessageDto, EmployeeToTenantMessage>()
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(src => DateTime.Parse(src.TimeStamp, new CultureInfo("da-DK"))));
        }
    }
}
