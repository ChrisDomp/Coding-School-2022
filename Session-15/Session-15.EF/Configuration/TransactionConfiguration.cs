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


            //builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction).HasForeignKey<TransactionLine>(transactionLine => transactionLine.TransactionID);
            //builder.HasOne(tr => tr.Car).WithOne(c => c.Transaction).HasForeignKey<Car>(car => car.TransactionID);
            //builder.HasOne(tr => tr.Customer).WithOne(c => c.Transaction).HasForeignKey<Customer>(customer => customer.TransactionID);
        }


    }
    
}
