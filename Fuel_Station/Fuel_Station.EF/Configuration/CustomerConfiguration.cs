using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fuel_Station.EF.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID);
        
            builder.Property(customer => customer.Name).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(20).IsRequired();
            builder.Property(customer => customer.CardNumber).HasMaxLength(200).IsRequired();

            
        }
    }
}