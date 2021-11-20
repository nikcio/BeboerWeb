using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class CompanyEnityConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder
                .HasMany(p => p.Employees)
                .WithMany(p => p.Companies);

            builder
                .HasMany(p => p.Owners)
                .WithMany(p => p.OwnedCompanies);

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
