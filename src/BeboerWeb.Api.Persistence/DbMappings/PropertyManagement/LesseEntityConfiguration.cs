using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class LesseEntityConfiguration : IEntityTypeConfiguration<Lesse>
    {
        public void Configure(EntityTypeBuilder<Lesse> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Apartment)
                .HasMaxLength(10);
        }
    }
}
