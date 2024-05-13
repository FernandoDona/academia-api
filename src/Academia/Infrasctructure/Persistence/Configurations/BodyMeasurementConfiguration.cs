using Academia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academia.Infrastructure.Persistence.Configurations;
internal class BodyMeasurementConfiguration : IEntityTypeConfiguration<BodyMeasurement>
{
    public void Configure(EntityTypeBuilder<BodyMeasurement> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever();
        builder.Property(bm => bm.Height)
            .IsRequired();
        builder.Property(bm => bm.Weight)
            .IsRequired();
        builder.Property(bm => bm.RegisterDate)
            .IsRequired();

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(bm => bm.UserId)
            .IsRequired();
    }
}
