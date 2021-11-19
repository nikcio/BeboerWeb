using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class LeasePeriodService : CrudServiceBase<LeasePeriod, ILeasePeriodRepository>, ILeasePeriodService
    {
        public LeasePeriodService(ILeasePeriodRepository repository, ILogger<ServiceBase<ILeasePeriodRepository>> logger) : base(repository, logger)
        {
        }
    }
}
