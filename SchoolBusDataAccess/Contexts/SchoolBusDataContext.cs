using Microsoft.EntityFrameworkCore;
using SchoolBusDataAccess.Configuration;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Contexts;

public class SchoolBusDataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-UCO0K2D;Initial Catalog=SchoolBus;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        optionsBuilder.UseLazyLoadingProxies();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new RideConfiguration());
        modelBuilder.ApplyConfiguration(new ParentConfiguration());
        modelBuilder.ApplyConfiguration(new ClassConfiguration());
        modelBuilder.ApplyConfiguration(new DriverConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new AdminConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Car>? Cars { get; set; }
    public DbSet<Driver>? Drivers { get; set; }
    public DbSet<Class_>? Classes { get; set; }
    public DbSet<Parent>? Parents { get; set; }
    public DbSet<Ride>? Rides { get; set; }
    public DbSet<Student>? Students { get; set; }
    public DbSet<Admin>? Admins { get; set; }
    public DbSet<Holiday>? Holidays { get; set; }
}

