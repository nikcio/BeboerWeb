using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class LeasePeriodRepository : CrudRepositoryBase<LeasePeriod>, ILeasePeriodRepository
    {
        public LeasePeriodRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<LeasePeriod>> logger) : base(dbContext, logger)
        {
        }
    }
}
