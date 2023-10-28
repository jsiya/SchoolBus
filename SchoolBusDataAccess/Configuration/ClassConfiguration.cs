using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBusModels.Concretes;

namespace SchoolBusDataAccess.Configuration;

public class ClassConfiguration : IEntityTypeConfiguration<Class_>
{
    public void Configure(EntityTypeBuilder<Class_> builder)
    {
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar(20)");
    }
}
