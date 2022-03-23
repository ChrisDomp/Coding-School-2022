using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_15.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.TotalPrice);
            //builder.HasOne(transaction =>transaction.CarID).WithOne(transactionCar => transactionCar.TransactionID).HasForeignKey<TransactionCar>(transactionCar => transactionCar.CarId);
            //builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionTransactionLine => transactionTransactionLine.Transaction).HasForeignKey(transactionTransactionLine => transactionTransactionLine.transactionID);


        }
    }
}
