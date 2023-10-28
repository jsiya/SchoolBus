using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.Property(d => d.Username)
            .HasColumnType("nvarchar(50)");

        builder.Property(d => d.Password)
            .HasColumnType("nvarchar(30)");

        builder.Property(d => d.FirstName)
            .HasColumnType("nvarchar(50)");

        builder.Property(d => d.LastName)
            .HasColumnType("nvarchar(50)");

        builder.Property(d => d.Phone)
            .HasColumnType("nvarchar(13)");

        builder.Property(d => d.License)
            .HasColumnType("nvarchar(8)");
    }
}