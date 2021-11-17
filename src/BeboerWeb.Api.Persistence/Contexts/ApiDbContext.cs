using BeboerWeb.Api.Domain.Models.Bookings;
using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BeboerWeb.Api.Persistence.Contexts
{
    public class ApiDbContext : DbContext, IApiDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Lesse> Lesses { get; set; }
        public DbSet<LessePeriod> LessePeriods { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingItem> BookingItems { get; set; }
        public DbSet<BookingWindow> BookingWindows { get; set; }
        public DbSet<Calender> Calenders { get; set; }

        public DbContext DbContext => this;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
