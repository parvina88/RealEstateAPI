using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class EntranceConfiguration : IEntityTypeConfiguration<Entrance>
    {
        public void Configure(EntityTypeBuilder<Entrance> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Number)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.NumberFloor)
                .IsRequired();

            builder.HasOne(e => e.Building)
                .WithMany(b => b.Entrances)
                .HasForeignKey(e => e.BuildingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
