using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id); 

            builder.Property(p => p.FullName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Age)
                .IsRequired();

            builder.Property(p => p.Address)
                .HasMaxLength(200); 

            builder.Property(p => p.Phone)
                .HasMaxLength(20); 

            builder.Property(p => p.Email)
                .HasMaxLength(100); 

            builder.Property(p => p.DocumentId)
                .IsRequired();

        }
    }
}
