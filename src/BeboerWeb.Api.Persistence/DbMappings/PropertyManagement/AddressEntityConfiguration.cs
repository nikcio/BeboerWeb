using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Street)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.Number)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
