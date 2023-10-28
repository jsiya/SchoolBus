using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.Property(a => a.Username)
            .HasColumnType("nvarchar(50)");

        builder.Property(a => a.Password)
            .HasColumnType("nvarchar(30)");
    }
}
