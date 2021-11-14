using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Persistence.Repositories.Bases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Persistence.Repositories.PropertyManagement
{
    public class AddressRepository : CrudRepositoryBase<IAddress>, IAddressRepository
    {
        public AddressRepository(DbContext dbContext, ILogger<CrudRepositoryBase<IAddress>> logger) : base(dbContext, logger)
        {
        }
    }
}
