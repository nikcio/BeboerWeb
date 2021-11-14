using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingItemRepository : CrudRepositoryBase<IBookingItem>, IBookingItemRepository
    {
        public BookingItemRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IBookingItem>> logger) : base(dbContext, logger)
        {
        }
    }
}
