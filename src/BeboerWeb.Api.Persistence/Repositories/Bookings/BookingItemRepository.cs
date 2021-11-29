using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingItemRepository : CrudRepositoryBase<BookingItem>, IBookingItemRepository
    {
        public BookingItemRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<BookingItem>> logger) : base(dbContext, logger)
        {
        }

        public virtual async Task<BookingItem> GetAllBookings(int bookingItemId)
        {
            try
            {
                return await dbSet.Include(item => item.Bookings).Include(item => item.BookingWindows).FirstOrDefaultAsync(item => item.Id == bookingItemId);
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed GetAllBookingWindowsForBookingItem {typeof(BookingItem)}");
                throw new TaskCanceledException("Task failed");
            }
        }
    }
}
