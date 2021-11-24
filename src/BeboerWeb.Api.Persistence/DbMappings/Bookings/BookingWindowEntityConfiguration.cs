using BeboerWeb.Api.Domain.Models.Bookings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Bookings
{
    internal class BookingWindowEntityConfiguration : IEntityTypeConfiguration<BookingWindow>
    {
        public void Configure(EntityTypeBuilder<BookingWindow> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
        }
    }
}
