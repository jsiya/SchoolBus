using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

public class ParentConfiguration : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.Property(p => p.FirstName)
            .HasColumnType("nvarchar(50)");

        builder.Property(p => p.LastName)
            .HasColumnType("nvarchar(50)");

        builder.Property(p => p.Phone)
            .HasColumnType("nvarchar(13)");

        builder.HasMany(p => p.Students)
            .WithMany(s => s.Parents)
            .UsingEntity("ParentStudent");
    }
}
