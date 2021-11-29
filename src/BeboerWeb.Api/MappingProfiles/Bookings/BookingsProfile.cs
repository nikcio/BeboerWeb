using AutoMapper;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;
using System.Linq;

namespace BeboerWeb.Api.MappingProfiles.Bookings
{
    public class BookingsProfile : Profile
    {
        public BookingsProfile()
        {
            CreateMap<Booking, BookingDto>()
                .ForMember(dest => dest.BookingItemId, opt => opt.MapFrom(src => src.BookingItem.Id))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.Tenant.Id));
            CreateMap<BookingDto, Booking>()
                .ForMember(dest => dest.BookingItem, opt => opt.MapFrom(src => new BookingItemDto { Id = src.BookingItemId }))
                .ForMember(dest => dest.Tenant, opt => opt.MapFrom(src => new TenantDto { Id = src.TenantId }));

            CreateMap<BookingWithBookingWindowDto, Booking>();
            CreateMap<Booking, BookingWithBookingWindowDto>()
                .ForMember(dest => dest.BookingWindowId, opt => opt.MapFrom(src =>
                    src.BookingItem.BookingWindows.Any(item => item.IsBookingInBookingWindow(src)) 
                    ? src.BookingItem.BookingWindows.First(item => item.IsBookingInBookingWindow(src)).Id as int? 
                    : null));

            CreateMap<BookingItem, BookingItemDto>();
            CreateMap<BookingItemDto, BookingItem>();


            CreateMap<BookingItem, BookingItemBookingsDto>();
            CreateMap<BookingItemBookingsDto, BookingItem>();

            CreateMap<BookingWindow, BookingWindowDto>();
            CreateMap<BookingWindowDto, BookingWindow>();
        }
    }
}
