using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingRepository : CrudRepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Booking>> logger) : base(dbContext, logger)
        {
        }
    }
}
