using BeboerWeb.Api.Domain.Models.Chat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Chat
{
    internal class EmployeeToTenantMessageEntityConfiguration : IEntityTypeConfiguration<EmployeeToTenantMessage>
    {
        public void Configure(EntityTypeBuilder<EmployeeToTenantMessage> builder)
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
