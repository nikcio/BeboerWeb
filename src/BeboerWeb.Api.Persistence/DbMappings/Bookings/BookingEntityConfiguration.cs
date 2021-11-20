using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Bookings
{
    internal class BookingEntityConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
