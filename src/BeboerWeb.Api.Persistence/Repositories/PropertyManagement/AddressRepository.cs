using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class AddressRepository : CrudRepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(IApiDbContext dbContext, ILogger<CrudRepositoryBase<Address>> logger) : base(dbContext, logger)
        {
        }
    }
}
