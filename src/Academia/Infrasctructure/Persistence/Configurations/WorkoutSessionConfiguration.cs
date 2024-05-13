using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class WorkoutSessionConfiguration : IEntityTypeConfiguration<WorkoutSession>
{
    public void Configure(EntityTypeBuilder<WorkoutSession> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(w => w.StartedIn)
            .IsRequired();

        builder.HasOne<Workout>()
            .WithMany()
            .HasForeignKey(w => w.WorkoutId)
            .IsRequired();
    }
}
