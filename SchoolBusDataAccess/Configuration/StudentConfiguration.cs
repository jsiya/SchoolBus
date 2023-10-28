using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.FirstName)
            .HasColumnType("nvarchar(50)");

        builder.Property(s => s.LastName)
            .HasColumnType("nvarchar(50)");

        builder.HasOne(s => s.Class)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.ClassId);
    }
}

