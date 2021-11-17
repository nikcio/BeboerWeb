using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class LeaseRepositroy : CrudRepositoryBase<Lease>, ILeaseRepository
    {
        public LeaseRepositroy(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Lease>> logger) : base(dbContext, logger)
        {
        }
    }
}
