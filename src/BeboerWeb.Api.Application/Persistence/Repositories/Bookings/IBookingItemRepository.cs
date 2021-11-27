using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Persistence.Repositories;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Bookings
{
    public interface IBookingItemRepository : IRepository, ICrudRepository<BookingItem>
    {
        Task<BookingItem> GetAllBookings(int bookingItemId);
    }
}
