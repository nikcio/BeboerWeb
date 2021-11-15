using AutoMapper;
using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Application.Services.PropertyManagement;
using BeboerWeb.Api.Controllers.Bases;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;
using Microsoft.AspNetCore.Mvc;

namespace BeboerWeb.Api.Controllers.PropertyManagement
{
    [Route("api/propertymanagement/country")]
    [ApiController]
    public class CountryController : CrudControllerBase<CountryDto, Country, ICountryRepository, ICountryService>
    {
        public CountryController(ICountryService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
