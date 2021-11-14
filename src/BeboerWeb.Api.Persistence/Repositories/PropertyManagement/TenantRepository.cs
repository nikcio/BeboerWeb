using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class TenantRepository : CrudRepositoryBase<ITenant>, ITenantRepository
    {
        public TenantRepository(DbContext dbContext, ILogger<CrudRepositoryBase<ITenant>> logger) : base(dbContext, logger)
        {
        }
    }
}
