using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class TenantRepository : CrudRepositoryBase<Tenant>, ITenantRepository
    {
        public TenantRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Tenant>> logger) : base(dbContext, logger)
        {
        }
    }
}
