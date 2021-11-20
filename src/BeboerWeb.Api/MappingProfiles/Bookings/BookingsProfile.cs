using AutoMapper;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;

namespace BeboerWeb.Api.MappingProfiles.Bookings
{
    public class BookingsProfile : Profile
    {
        public BookingsProfile()
        {
            CreateMap<Booking, BookingDto>();
            CreateMap<BookingDto, Booking>();

            CreateMap<BookingItem, BookingItemDto>();
            CreateMap<BookingItemDto, BookingItem>();

            CreateMap<BookingWindow, BookingWindowDto>();
            CreateMap<BookingWindowDto, BookingWindow>();
        }
    }
}
