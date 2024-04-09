using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class DealConfiguration : IEntityTypeConfiguration<Deal>
    {
        public void Configure(EntityTypeBuilder<Deal> builder)
        {
            builder.ToTable(nameof(Deal));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Number)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(d => d.Date)
                .IsRequired();

            builder.HasOne(d => d.Customer)
                .WithMany()
                .HasForeignKey(d => d.CustomerId);

            builder.HasOne(d => d.Apartment)
                .WithMany()
                .HasForeignKey(d => d.ApartmentId);

            builder.HasOne(d => d.Employee)
                .WithMany()
                .HasForeignKey(d => d.EmployeeId);

            builder.HasOne(d => d.Document)
                .WithMany()
                .HasForeignKey(d => d.DocumentId);
        }
    }
}
