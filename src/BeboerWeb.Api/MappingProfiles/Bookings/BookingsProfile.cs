using AutoMapper;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;
using System;
using System.Globalization;
using System.Linq;

namespace BeboerWeb.Api.MappingProfiles.Bookings
{
    public class BookingsProfile : Profile
    {
        public BookingsProfile()
        {
            CreateMap<Booking, BookingDto>()
                .ForMember(dest => dest.BookingItemId, opt => opt.MapFrom(src => src.BookingItem.Id))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.Tenant.Id))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime.ToString("F", new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.ToString("F", new CultureInfo("da-DK"))));
            CreateMap<BookingDto, Booking>()
                .ForMember(dest => dest.BookingItem, opt => opt.MapFrom(src => new BookingItemDto { Id = src.BookingItemId }))
                .ForMember(dest => dest.Tenant, opt => opt.MapFrom(src => new TenantDto { Id = src.TenantId }))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => DateTime.Parse(src.StartTime, new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => DateTime.Parse(src.EndTime, new CultureInfo("da-DK"))));

            CreateMap<BookingWithBookingWindowDto, Booking>()
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => DateTime.Parse(src.StartTime, new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => DateTime.Parse(src.EndTime, new CultureInfo("da-DK"))));
            CreateMap<Booking, BookingWithBookingWindowDto>()
                .ForMember(dest => dest.BookingWindowId, opt => opt.MapFrom(src =>
                    src.BookingItem.BookingWindows.Any(item => item.IsBookingInBookingWindow(src)) 
                    ? src.BookingItem.BookingWindows.First(item => item.IsBookingInBookingWindow(src)).Id as int? 
                    : null))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime.ToString("F", new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.ToString("F", new CultureInfo("da-DK"))));

            CreateMap<BookingItem, BookingItemDto>();
            CreateMap<BookingItemDto, BookingItem>();


            CreateMap<BookingItem, BookingItemBookingsDto>();
            CreateMap<BookingItemBookingsDto, BookingItem>();

            CreateMap<BookingWindow, BookingWindowDto>()
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime.ToString("F", new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.ToString("F", new CultureInfo("da-DK"))));
            CreateMap<BookingWindowDto, BookingWindow>()
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => DateTime.Parse(src.StartTime, new CultureInfo("da-DK"))))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => DateTime.Parse(src.EndTime, new CultureInfo("da-DK"))));
        }
    }
}
