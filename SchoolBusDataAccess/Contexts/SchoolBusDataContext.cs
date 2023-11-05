using Microsoft.EntityFrameworkCore;
using SchoolBusDataAccess.Configuration;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Contexts;

internal class SchoolBusDataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-UCO0K2D;Initial Catalog=SchoolBus;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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

    public virtual DbSet<Car>? Cars { get; set; }
    public virtual DbSet<Driver>? Drivers { get; set; }
    public virtual DbSet<Class_>? Classes { get; set; }
    public virtual DbSet<Parent>? Parents { get; set; }
    public virtual DbSet<Ride>? Rides { get; set; }
    public virtual DbSet<Student>? Students { get; set; }
    public virtual DbSet<Admin>? Admins { get; set; }
    public virtual DbSet<Holiday>? Holidays { get; set; }
}

