using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingItemService : CrudServiceBase<BookingItem, IBookingItemRepository>, IBookingItemService
    {
        public BookingItemService(IBookingItemRepository repository, ILogger<ServiceBase<IBookingItemRepository>> logger) : base(repository, logger)
        {
        }
    }
}
