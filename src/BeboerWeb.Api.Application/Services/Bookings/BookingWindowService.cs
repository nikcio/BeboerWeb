using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class BookingWindowService : CrudServiceBase<BookingWindow, IBookingWindowRepository>, IBookingWindowService
    {
        public BookingWindowService(IBookingWindowRepository repository, ILogger<ServiceBase<IBookingWindowRepository>> logger) : base(repository, logger)
        {
        }

        public async Task<IServiceResponse<IEnumerable<BookingWindow>>> GetAllBookingWindowsForBookingItem(int bookingItemId)
        {
            return await ExecuteServiceTask(async () =>
            {
                return await repository.GetAllBookingWindowsForBookingItem(bookingItemId);
            }, StatusCode.Success);
        }
    }
}
