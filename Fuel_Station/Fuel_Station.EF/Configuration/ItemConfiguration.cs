using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.EF.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");

            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID);

            builder.Property(item => item.Code).HasMaxLength(100);
            builder.Property(item => item.Description).HasMaxLength(20);
            builder.Property(item => item.ItemType);
            builder.Property(item => item.Cost);
            builder.Property(item => item.Price);

        }
    }
}
