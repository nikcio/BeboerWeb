using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingRepository : CrudRepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(DbContext dbContext, ILogger<CrudRepositoryBase<Booking>> logger) : base(dbContext, logger)
        {
        }
    }
}
