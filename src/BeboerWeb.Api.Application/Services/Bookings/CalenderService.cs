using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Application.Enums;
using BeboerWeb.Shared.Application.Services;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Application.Services.Bookings
{
    public class CalenderService : CrudServiceBase<Calender, ICalenderRepository>, ICalenderService
    {
        public CalenderService(ICalenderRepository repository, ILogger<ServiceBase<ICalenderRepository>> logger) : base(repository, logger)
        {
        }
    }
}
