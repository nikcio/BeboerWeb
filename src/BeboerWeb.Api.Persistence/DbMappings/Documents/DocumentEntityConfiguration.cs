using BeboerWeb.Api.Domain.Models.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeboerWeb.Api.Persistence.DbMappings.Documents
{
    internal class DocumentEntityConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn();

            builder.Property(p => p.Type)
                .HasMaxLength(100);

            builder.Property(p => p.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
