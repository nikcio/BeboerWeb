using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingWindowRepository : CrudRepositoryBase<BookingWindow>, IBookingWindowRepository
    {
        public BookingWindowRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<BookingWindow>> logger) : base(dbContext, logger)
        {
        }

        public virtual async Task<IEnumerable<BookingWindow>> GetAllBookingWindowsForBookingItem(int bookingItemId)
        {
            try
            {
                return await dbSet.Where(item => item.BookingItemId == bookingItemId).ToListAsync();
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Failed GetAllBookingWindowsForBookingItem {typeof(BookingWindow)}");
                throw new TaskCanceledException("Task failed");
            }
        }
    }
}
