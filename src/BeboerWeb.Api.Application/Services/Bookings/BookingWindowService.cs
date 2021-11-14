using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingWindowService : CrudServiceBase<BookingWindow, IBookingWindowRepository>, IBookingWindowService
    {
        public BookingWindowService(IBookingWindowRepository repository, ILogger<ServiceBase<IBookingWindowRepository>> logger) : base(repository, logger)
        {
        }
    }
}
