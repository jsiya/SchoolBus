using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

internal class RideConfiguration : IEntityTypeConfiguration<Ride>
{
    public void Configure(EntityTypeBuilder<Ride> builder)
    {
        builder.Property(r => r.Rotate)
            .HasColumnType("bit");

        builder.HasOne(r => r.Driver)
            .WithMany(d => d.Rides)
            .HasForeignKey(r => r.DriverId);

        builder.HasOne<Car>(r => r.Car)
            .WithMany(c => c.Rides)
            .HasForeignKey(r => r.CarId);

        //builder.HasMany(r => r.Students)
        //    .WithMany(s => s.Rides)
        //    .UsingEntity("StudentRide");
    }
}
