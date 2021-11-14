using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class TenantService : CrudServiceBase<Tenant, ITenantRepository>, ITenantService
    {
        public TenantService(ITenantRepository repository, ILogger<ServiceBase<ITenantRepository>> logger) : base(repository, logger)
        {
        }
    }
}
