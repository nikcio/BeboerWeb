using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Bookings
{
    internal class CalenderEntityConfiguration : IEntityTypeConfiguration<Calender>
    {
        public void Configure(EntityTypeBuilder<Calender> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
