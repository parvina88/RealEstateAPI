using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class BuildingConfiguration : IEntityTypeConfiguration<Building>
{
    public void Configure(EntityTypeBuilder<Building> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(b => b.Address)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(b => b.EntrancesCount)
            .IsRequired();

        builder.Property(b => b.HasLift)
            .IsRequired();
    }
}