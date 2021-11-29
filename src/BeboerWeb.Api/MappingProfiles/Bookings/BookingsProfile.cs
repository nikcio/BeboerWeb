using AutoMapper;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using System.Linq;

namespace BeboerWeb.Api.MappingProfiles.Bookings
{
    public class BookingsProfile : Profile
    {
        public BookingsProfile()
        {
            CreateMap<Booking, BookingDto>()
                .ForMember(dest => dest.BookingItemIds, opt => opt.MapFrom(src => src.BookingItems.Select(item => item.Id)));
            CreateMap<BookingDto, Booking>()
                .ForMember(dest => dest.BookingItems, opt => opt.MapFrom(src => src.BookingItemIds.Select(id => new BookingItemDto { Id = id })));

            CreateMap<BookingItem, BookingItemDto>();
            CreateMap<BookingItemDto, BookingItem>();


            CreateMap<BookingItem, BookingItemBookingsDto>();
            CreateMap<BookingItemBookingsDto, BookingItem>();

            CreateMap<BookingWindow, BookingWindowDto>();
            CreateMap<BookingWindowDto, BookingWindow>();
        }
    }
}
