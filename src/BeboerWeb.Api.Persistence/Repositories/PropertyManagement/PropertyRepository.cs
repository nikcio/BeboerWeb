﻿using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class PropertyRepository : CrudRepositoryBase<IProperty>, IPropertyRepository
    {
        public PropertyRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IProperty>> logger) : base(dbContext, logger)
        {
        }
    }
}
