using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.Extensions.Logging;

namespace BeboerWeb.Api.Application.Services.PropertyManagement
{
    public class AddressService : CrudServiceBase<Address, IAddressRepository>, IAddressService
    {
        public AddressService(IAddressRepository repository, ILogger<ServiceBase<IAddressRepository>> logger) : base(repository, logger)
        {
        }
    }
}
