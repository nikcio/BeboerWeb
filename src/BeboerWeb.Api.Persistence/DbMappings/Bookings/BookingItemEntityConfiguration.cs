using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Bookings
{
    internal class BookingItemEntityConfiguration : IEntityTypeConfiguration<BookingItem>
    {
        public void Configure(EntityTypeBuilder<BookingItem> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
