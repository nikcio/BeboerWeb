using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bookings;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.Bookings
{
    [Route("api/bookings/bookingwindow")]
    [ApiController]
    public class BookingWindowController : CrudControllerBase<BookingWindowDto, BookingWindow, IBookingWindowRepository, IBookingWindowService>
    {
        public BookingWindowController(IBookingWindowService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
