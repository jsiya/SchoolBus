using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar(50)");

        builder.Property(c => c.Number)
            .HasColumnType("nvarchar(13)");

        builder.HasMany(c => c.Rides)
            .WithOne(r => r.Car)
            .HasForeignKey(c => c.CarId);
    }
}

