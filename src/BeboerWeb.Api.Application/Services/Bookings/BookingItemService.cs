using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingItemService : CrudServiceBase<BookingItem, IBookingItemRepository>, IBookingItemService
    {
        public BookingItemService(IBookingItemRepository repository, ILogger<ServiceBase<IBookingItemRepository>> logger) : base(repository, logger)
        {
        }

        public async Task<IServiceResponse<BookingItem>> GetAllBookings(int bookingItemId)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetAllBookings(bookingItemId);
            }, StatusCode.Success);
        }
    }
}
