using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bookings;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Models.DTOs.Bookings;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Controllers.Bookings
{
    [Route("api/bookings/booking")]
    [ApiController]
    public class BookingController : CrudControllerBase<BookingDto, Booking, IBookingRepository, IBookingService>
    {
        public BookingController(IBookingService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
