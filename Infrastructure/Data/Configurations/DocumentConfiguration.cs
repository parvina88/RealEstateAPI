using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(d => d.Id); 

            builder.Property(d => d.Number)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(d => d.Description)
                .HasMaxLength(300); // Adjust the maximum length as needed

            builder.Property(d => d.Date)
                .IsRequired();

            builder.Property(d => d.Type)
                .IsRequired()
                .HasConversion<string>(); 

        }
    }
}
