using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class PropertyService : CrudServiceBase<Property, IPropertyRepository>, IPropertyService
    {
        public PropertyService(IPropertyRepository repository, ILogger<ServiceBase<IPropertyRepository>> logger) : base(repository, logger)
        {
        }
    }
}
