using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class RoutineConfiguration : IEntityTypeConfiguration<Routine>
{
    public void Configure(EntityTypeBuilder<Routine> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(w => w.Name)
            .IsRequired();

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(w => w.UserId)
            .IsRequired();

        builder.HasMany(w => w.Workouts)
            .WithOne()
            .HasForeignKey(s => s.RoutineId);
    }
}
