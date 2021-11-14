using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingWindowRepository : CrudRepositoryBase<IBookingWindow>, IBookingWindowRepository
    {
        public BookingWindowRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IBookingWindow>> logger) : base(dbContext, logger)
        {
        }
    }
}
