using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class CityService : CrudServiceBase<City, ICityRepository>, ICityService
    {
        public CityService(ICityRepository repository, ILogger<ServiceBase<ICityRepository>> logger) : base(repository, logger)
        {
        }
    }
}
