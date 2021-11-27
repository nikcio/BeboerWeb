using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Bookings
{
    public interface IBookingWindowRepository : IRepository, ICrudRepository<BookingWindow>
    {
        Task<IEnumerable<BookingWindow>> GetAllBookingWindowsForBookingItem(int bookingItemId);
    }
}
