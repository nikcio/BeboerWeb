using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class CalenderRepository : CrudRepositoryBase<ICalender>, ICalenderRepository
    {
        public CalenderRepository(DbContext dbContext, ILogger<CrudRepositoryBase<ICalender>> logger) : base(dbContext, logger)
        {
        }
    }
}
