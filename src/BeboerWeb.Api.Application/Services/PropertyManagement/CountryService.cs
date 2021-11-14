using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class CountryService : CrudServiceBase<Country, ICountryRepository>, ICountryService
    {
        public CountryService(ICountryRepository repository, ILogger<ServiceBase<ICountryRepository>> logger) : base(repository, logger)
        {
        }
    }
}
