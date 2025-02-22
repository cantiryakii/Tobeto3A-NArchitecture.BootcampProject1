using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
{
    public void Configure(EntityTypeBuilder<Bootcamp> builder)
    {
        builder.ToTable("Bootcamps").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.Name).HasColumnName("Name");
        builder.Property(b => b.InstructorId).HasColumnName("InstructorId");
        builder.Property(b => b.StartDate).HasColumnName("StartDate");
        builder.Property(b => b.EndDate).HasColumnName("EndDate");
        builder.Property(b => b.BootcampStateId).HasColumnName("BootcampStateId");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        builder.HasOne(b => b.Instructor);
        builder.HasOne(p => p.BootcampState);
        builder.HasMany(p => p.ApplicationInformations);
    }
}
