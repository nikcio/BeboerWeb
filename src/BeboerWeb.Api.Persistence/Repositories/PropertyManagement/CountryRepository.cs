using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class CountryRepository : CrudRepositoryBase<ICountry>, ICountryRepository
    {
        public CountryRepository(DbContext dbContext, ILogger<CrudRepositoryBase<ICountry>> logger) : base(dbContext, logger)
        {
        }
    }
}
