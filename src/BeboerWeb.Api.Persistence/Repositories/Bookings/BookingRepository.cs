using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class BookingRepository : CrudRepositoryBase<IBooking>, IBookingRepository
    {
        public BookingRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IBooking>> logger) : base(dbContext, logger)
        {
        }
    }
}
