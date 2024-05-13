using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class WorkoutItemConfiguration : IEntityTypeConfiguration<WorkoutItem>
{
    public void Configure(EntityTypeBuilder<WorkoutItem> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne<Workout>()
            .WithMany()
            .HasForeignKey(wi => wi.WorkoutId)
            .IsRequired();

        builder.HasOne(wi => wi.Exercise)
            .WithMany()
            .HasForeignKey(wi => wi.Exercise.Id);

        builder.HasMany(wi => wi.Series)
            .WithOne()
            .HasForeignKey(s => s.WorkoutItemId);
    }
}
