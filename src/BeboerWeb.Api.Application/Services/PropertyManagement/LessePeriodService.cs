using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class LessePeriodService : CrudServiceBase<LessePeriod, ILessePeriodRepository>, ILessePeriodService
    {
        public LessePeriodService(ILessePeriodRepository repository, ILogger<ServiceBase<ILessePeriodRepository>> logger) : base(repository, logger)
        {
        }
    }
}
