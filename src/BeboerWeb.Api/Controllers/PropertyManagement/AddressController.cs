using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.PropertyManagement;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.PropertyManagement
{
    [Route("api/propertymanagement/address")]
    [ApiController]
    public class AddressController : CrudControllerBase<AddressDto, Address, IAddressRepository, IAddressService>
    {
        public AddressController(IAddressService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
