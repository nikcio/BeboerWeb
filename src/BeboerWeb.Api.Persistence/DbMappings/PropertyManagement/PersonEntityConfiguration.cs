using BeboerWeb.Api.Domain.Models.PropertyManangement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.PropertyManagement
{
    internal class PersonEntityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Name)
                .HasMaxLength(100);
        }
    }
}
