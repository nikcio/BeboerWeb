using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bookings;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Bookings
{
    [Route("api/bookings/bookingitem")]
    [ApiController]
    public class BookingItemController : CrudControllerBase<BookingItemDto, BookingItem, IBookingItemRepository, IBookingItemService>
    {
        public BookingItemController(IBookingItemService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
