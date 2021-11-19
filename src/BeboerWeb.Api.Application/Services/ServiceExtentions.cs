using BeboerWeb.Api.Application.Services.Bookings;
using BeboerWeb.Api.Application.Services.PropertyManagement;
using Microsoft.Extensions.DependencyInjection;

namespace BeboerWeb.Api.Application.Services
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            #region PropertyManagement
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ILeasePeriodService, LeasePeriodService>();
            services.AddScoped<ILeaseService, LeaseService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ITenantService, TenantService>();
            #endregion

            #region Bookings
            services.AddScoped<IBookingItemService, BookingItemService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IBookingWindowService, BookingWindowService>();
            services.AddScoped<ICalenderService, CalenderService>();
            #endregion

            return services;
        }
    }
}
