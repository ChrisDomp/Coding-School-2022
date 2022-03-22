using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_15.Model;

namespace Session_15.EF
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(car => car.ID);
            builder.Property(car => car.Brand).HasMaxLength(100);
            builder.Property(car => car.Model).HasMaxLength(100);
            builder.Property(car => car.RegistrationNumber);

        }

    }
}