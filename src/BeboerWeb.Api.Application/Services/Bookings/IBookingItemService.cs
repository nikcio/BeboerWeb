using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Services.Models;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public interface IBookingItemService : ICrudServiceBase<BookingItem, IBookingItemRepository>
    {
        Task<IServiceResponse<BookingItem>> GetAllBookings(int bookingItemId);
    }
}