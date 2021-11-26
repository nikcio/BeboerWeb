using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Chat
{
    internal class TenantToTenantMessageEntityConfiguration : IEntityTypeConfiguration<TenantToTenantMessage>
    {
        public void Configure(EntityTypeBuilder<TenantToTenantMessage> builder)
        {
            builder.Property(p => p.Id)
                .UseIdentityColumn();

            builder.Property(p => p.MessageText)
                .HasMaxLength(1200);

            builder.HasOne(p => p.Sender)
                .WithMany(p => p.SentInternalMessages);

            builder.HasMany(p => p.Receivers)
                .WithMany(p => p.ReceivedInternalMessages);

            builder.Property(p => p.RowVersion)
                .IsRowVersion();
        }
    }
}
