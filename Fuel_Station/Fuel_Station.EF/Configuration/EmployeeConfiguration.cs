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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.Surname).HasMaxLength(20).IsRequired();
            builder.Property(employee =>employee.SalaryPerMonth).HasMaxLength(20).IsRequired();
            builder.Property(employee => employee.EmployeeType).IsRequired();
            builder.Property(employee => employee.HireDateStart).IsRequired();
            builder.Property(employee => employee.HireDateEnd);

            builder.HasOne(employee => employee.Transaction)
                   .WithOne(transaction => transaction.Employee)
                   .HasForeignKey<Transaction>(transaction => transaction.ID);

        }
    }
}
