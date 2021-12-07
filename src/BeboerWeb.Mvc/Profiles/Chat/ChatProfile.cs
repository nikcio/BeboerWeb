using AutoMapper;
using BeboerWeb.Mvc.Integrations;
using BeboerWeb.Mvc.Models;
using BeboerWeb.Mvc.Models.ExtraDtos;
using System;
using System.Linq;

namespace BeboerWeb.Mvc.Profiles.Chat
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<TenantToEmployeeMessageDto, MessageDto>()
                .ForMember(dest => dest.SenderId, opt => opt.MapFrom(src => src.Sender.Id))
                .ForMember(dest => dest.SenderName, opt => opt.MapFrom(src => src.Sender.Name))
                .ForMember(dest => dest.ReceiverIds, opt => opt.MapFrom(src => src.Receivers.Select(item => item.Id)))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetType().Name));

            CreateMap<MessageDto, TenantToEmployeeMessageDto>()
                .ForMember(dest => dest.Sender, opt => opt.MapFrom(src => new TenantDto { Id = src.SenderId, Name = src.SenderName }))
                .ForMember(dest => dest.Receivers, opt => opt.MapFrom(src => src.ReceiverIds.Select(item => new EmployeeDto { Id = item })));

            CreateMap<EmployeeToTenantMessageDto, MessageDto>()
                .ForMember(dest => dest.SenderId, opt => opt.MapFrom(src => src.Sender.Id))
                .ForMember(dest => dest.SenderName, opt => opt.MapFrom(src => "Employee"))
                .ForMember(dest => dest.ReceiverIds, opt => opt.MapFrom(src => src.Receivers.Select(item => item.Id)))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.GetType().Name));

            CreateMap<MessageDto, EmployeeToTenantMessageDto>()
                .ForMember(dest => dest.Sender, opt => opt.MapFrom(src => new EmployeeDto { Id = src.SenderId }))
                .ForMember(dest => dest.Receivers, opt => opt.MapFrom(src => src.ReceiverIds.Select(item => new TenantDto { Id = item })));

        }
    }
}
