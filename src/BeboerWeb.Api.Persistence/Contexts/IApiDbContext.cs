using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Domain.Models.Documents;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.Contexts
{
    public interface IApiDbContext : IDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<BookingItem> BookingItems { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<BookingWindow> BookingWindows { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<LeasePeriod> LeasePeriods { get; set; }
        DbSet<Lease> Leases { get; set; }
        DbSet<Property> Properties { get; set; }
        DbSet<Tenant> Tenants { get; set; }
        DbSet<Document> Documents { get; set; }
    }
}