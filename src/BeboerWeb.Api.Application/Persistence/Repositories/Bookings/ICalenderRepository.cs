﻿using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Bookings
{
    public interface ICalenderRepository : IRepository, ICrudRepository<ICalender>
    {
    }
}
