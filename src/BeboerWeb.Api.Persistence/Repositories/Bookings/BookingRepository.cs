using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingRepository : CrudRepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Booking>> logger) : base(dbContext, logger)
        {
        }

        public async Task<bool> IsBookingVaild(Booking entity)
        {
            var bookingwindows = await GetBookingWindows(entity);
            var selectedWindow = bookingwindows.FirstOrDefault(window => window.BookingItemId == entity.BookingItem.Id);
            if (selectedWindow == null || !selectedWindow.IsBookingVaild(entity))
            {
                return false;
            }
            return true;
        }

        private async Task<IEnumerable<BookingWindow>> GetBookingWindows(Booking entity)
        {
            var bookingwindows = await GetDBContext().Set<BookingWindow>()
                .AsNoTracking()
                .Include(item => item.BookingItem)
                .ThenInclude(item => item.Bookings)
                .ToListAsync();
            
            return bookingwindows
                .Where(item =>
                    entity.BookingItem.Id == item.BookingItemId
                    && item.IsBookingInBookingWindow(entity));
        }

        public async override Task<IEnumerable<Booking>> GetAllAsync()
        {
            var output = await base.GetAllAsync();
            foreach (var item in output)
            {
                await GetDBContext().Entry(item).Reference(p => p.BookingItem).LoadAsync();
            }
            return output;
        }

        public async override Task<Booking> GetByIdAsync(int id)
        {
            var output = await base.GetByIdAsync(id);
            await GetDBContext().Entry(output).Reference(p => p.BookingItem).LoadAsync();
            return output;
        }
    }
}
