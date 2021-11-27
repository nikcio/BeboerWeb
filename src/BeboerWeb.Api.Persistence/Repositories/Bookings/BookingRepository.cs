using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingRepository : CrudRepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Booking>> logger) : base(dbContext, logger)
        {
        }

        public async override Task<IEnumerable<Booking>> GetAllAsync()
        {
            var output = await base.GetAllAsync();
            foreach (var item in output)
            {
                await GetDBContext().Entry(item).Collection(p => p.BookingItems).LoadAsync();
            }
            return output;
        }

        public async override Task<Booking> GetByIdAsync(int id)
        {
            var output = await base.GetByIdAsync(id);
            await GetDBContext().Entry(output).Collection(p => p.BookingItems).LoadAsync();
            return output;
        }
    }
}
