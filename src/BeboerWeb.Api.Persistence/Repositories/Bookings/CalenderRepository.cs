﻿using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.Bookings
{
    public class CalenderRepository : CrudRepositoryBase<Calender>, ICalenderRepository
    {
        public CalenderRepository(DbContext dbContext, ILogger<CrudRepositoryBase<Calender>> logger) : base(dbContext, logger)
        {
        }
    }
}
