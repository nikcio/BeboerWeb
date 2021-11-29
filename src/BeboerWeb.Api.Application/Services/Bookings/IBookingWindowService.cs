using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public interface IBookingWindowService : ICrudServiceBase<BookingWindow, IBookingWindowRepository>
    {
        Task<IServiceResponse<IEnumerable<BookingWindow>>> GetAllBookingWindowsForBookingItem(int bookingItemId);
    }
}