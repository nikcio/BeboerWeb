using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.EntityFrameworkCore;

namespace BeboerWeb.Api.Persistence.DbMappings.Chat
{
    internal class TenantToEmployeeMessageEntityConfiguration : IEntityTypeConfiguration<TenantToEmployeeMessage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TenantToEmployeeMessage> builder)
        {
            builder.Property(p => p.Id)
                .UseIdentityColumn();

            builder.Property(p => p.MessageText)
                .HasMaxLength(1200);

            builder.Property(p => p.RowVersion)
                .IsRowVersion();
        }
    }
}
