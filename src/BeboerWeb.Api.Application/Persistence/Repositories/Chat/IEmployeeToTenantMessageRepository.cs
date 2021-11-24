﻿using BeboerWeb.Api.Domain.Models.Chat;
using BeboerWeb.Shared.Persistence.Repositories;

namespace BeboerWeb.Api.Application.Persistence.Repositories.Chat
{
    public interface IEmployeeToTenantMessageRepository : IRepository, ICrudRepository<EmployeeToTenantMessage>
    {
    }
}
