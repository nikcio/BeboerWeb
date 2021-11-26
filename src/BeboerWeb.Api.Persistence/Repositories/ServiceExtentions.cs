using BeboerWeb.Api.Application.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Application.Persistence.Repositories.Chat;
using BeboerWeb.Api.Application.Persistence.Repositories.Documents;
using BeboerWeb.Api.Application.Persistence.Repositories.PropertyManagement;
using BeboerWeb.Api.Persistence.Repositories.Bookings;
using BeboerWeb.Api.Persistence.Repositories.Chat;
using BeboerWeb.Api.Persistence.Repositories.Documents;
using BeboerWeb.Api.Persistence.Repositories.PropertyManagement;
using Microsoft.Extensions.DependencyInjection;

namespace BeboerWeb.Api.Persistence.Repositories
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddApiRepositories(this IServiceCollection services)
        {
            #region PropertyManagement
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ILeasePeriodRepository, LeasePeriodRepository>();
            services.AddScoped<ILeaseRepository, LeaseRepositroy>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<ITenantRepository, TenantRepository>();
            #endregion

            #region Documents
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            #endregion

            #region Bookings
            services.AddScoped<IBookingItemRepository, BookingItemRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingWindowRepository, BookingWindowRepository>();
            #endregion

            #region chat
            services.AddScoped<IEmployeeToTenantMessageRepository, EmployeeToTenantMessageRepository>();
            services.AddScoped<ITenantToEmployeeMessageRepository, TenantToEmployeeMessageRepository>();
            services.AddScoped<ITenantToTenantMessageRepository, TenantToTenantMessageRepository>();
            #endregion

            return services;
        }
    }
}
