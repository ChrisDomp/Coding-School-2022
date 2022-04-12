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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {

        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID);

            builder.Property(transaction => transaction.CostumerID);
            builder.Property(transaction => transaction.EmployeeID);
            builder.Property(transaction => transaction.TotalValue);
            builder.Property(transaction => transaction.PaymentMethod);
            builder.Property(transaction => transaction.Date);
           

        }
    }

}