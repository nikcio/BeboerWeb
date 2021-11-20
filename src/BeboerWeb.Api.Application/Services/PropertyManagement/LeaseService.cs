using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class LeaseService : CrudServiceBase<Lease, ILeaseRepository>, ILeaseService
    {
        public LeaseService(ILeaseRepository repository, ILogger<ServiceBase<ILeaseRepository>> logger) : base(repository, logger)
        {
        }
    }
}
