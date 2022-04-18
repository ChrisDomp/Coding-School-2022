﻿using Fuel_Station.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Station.EF.Configuration
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ItemID);
            builder.Property(transactionLine => transactionLine.ItemPrice);
            builder.Property(transactionLine => transactionLine.NetValue);
            builder.Property(transactionLine => transactionLine.DiscountPercent);
            builder.Property(transactionLine => transactionLine.DiscountValue);
            builder.Property(transactionLine => transactionLine.TotalValue);
            builder.Property(transactionLine => transactionLine.Quantity);


            //builder.HasOne(transactionLine => transactionLine.Transaction)
            //       .WithMany(transaction => transaction.TransactionLines)
            //       .HasForeignKey(transactionLine => transactionLine.TransactionID);


        }
    }
}
