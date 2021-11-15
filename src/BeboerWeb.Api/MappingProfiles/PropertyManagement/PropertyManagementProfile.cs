﻿using AutoMapper;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using BeboerWeb.Api.Models.DTOs.PropertyManagement;

namespace BeboerWeb.Api.MappingProfiles.PropertyManagement
{
    public class PropertyManagementProfile : Profile
    {
        public PropertyManagementProfile()
        {
            CreateMap<Address, AddressDto>();
            CreateMap<AddressDto, Address>();

            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();

            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();

            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();

            CreateMap<Lesse, LesseDto>();
            CreateMap<LesseDto, Lesse>();

            CreateMap<LessePeriod, LessePeriodDto>();
            CreateMap<LessePeriodDto, LessePeriod>();

            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();

            CreateMap<Property, PropertyDto>();
            CreateMap<PropertyDto, Property>();

            CreateMap<Tenant, TenantDto>();
            CreateMap<TenantDto, Tenant>();
        }
    }
}
