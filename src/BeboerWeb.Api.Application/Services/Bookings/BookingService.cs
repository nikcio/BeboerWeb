using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingService : CrudServiceBase<Booking, IBookingRepository>, IBookingService
    {
        public BookingService(IBookingRepository repository, ILogger<ServiceBase<IBookingRepository>> logger) : base(repository, logger)
        {
        }
    }
}
