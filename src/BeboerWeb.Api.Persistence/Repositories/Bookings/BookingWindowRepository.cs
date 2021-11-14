using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingWindowRepository : CrudRepositoryBase<BookingWindow>, IBookingWindowRepository
    {
        public BookingWindowRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<BookingWindow>> logger) : base(dbContext, logger)
        {
        }
    }
}
