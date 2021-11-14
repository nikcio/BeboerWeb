using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class LessePeriodRepository : CrudRepositoryBase<LessePeriod>, ILessePeriodRepository
    {
        public LessePeriodRepository(DbContext dbContext, ILogger<CrudRepositoryBase<LessePeriod>> logger) : base(dbContext, logger)
        {
        }
    }
}
