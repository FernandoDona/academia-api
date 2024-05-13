using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class ExerciseRecordConfiguration : IEntityTypeConfiguration<ExerciseRecord>
{
    public void Configure(EntityTypeBuilder<ExerciseRecord> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(er => er.WeightAverage)
            .IsRequired();
        builder.Property(er => er.RepetitionsAverage)
            .IsRequired();
        builder.Property(er => er.CreatedAt)
            .IsRequired();

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(er => er.UserId)
            .IsRequired();

        builder.HasOne<Exercise>()
            .WithMany()
            .HasForeignKey(er => er.ExerciseId)
            .IsRequired();
    }
}
