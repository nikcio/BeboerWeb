using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class LessePeriodEntityConfiguration : IEntityTypeConfiguration<LessePeriod>
    {
        public void Configure(EntityTypeBuilder<LessePeriod> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();
        }
    }
}
