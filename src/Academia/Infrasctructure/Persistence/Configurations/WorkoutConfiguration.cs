using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
{
    public void Configure(EntityTypeBuilder<Workout> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(w => w.Name)
            .IsRequired();

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(w => w.UserId)
            .IsRequired();

        builder.HasMany(w => w.Sessions)
            .WithOne()
            .HasForeignKey(s => s.WorkoutId);

        builder.HasMany(w => w.Items)
            .WithOne()
            .HasForeignKey(s => s.WorkoutId);
    }
}
