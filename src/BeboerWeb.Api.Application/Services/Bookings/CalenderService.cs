using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class CalenderService : CrudServiceBase<Calender, ICalenderRepository>, ICalenderService
    {
        public CalenderService(ICalenderRepository repository, ILogger<ServiceBase<ICalenderRepository>> logger) : base(repository, logger)
        {
        }
    }
}
