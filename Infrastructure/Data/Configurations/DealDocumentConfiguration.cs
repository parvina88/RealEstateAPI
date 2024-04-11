using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DealDocumentConfiguration : IEntityTypeConfiguration<DealDocument>
    {
        public void Configure(EntityTypeBuilder<DealDocument> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.DocumentId)
                .IsRequired();

            builder.Property(d => d.DealId)
                .IsRequired();

            builder.HasOne(d => d.Document)
                .WithMany(dd => dd.DealDocuments)
                .HasForeignKey(d => d.DocumentId);

            builder.HasOne(d => d.Deal)
                .WithMany(dd => dd.DealDocuments)
                .HasForeignKey(d => d.DealId);
        }
    }
}
