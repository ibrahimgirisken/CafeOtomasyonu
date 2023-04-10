using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Mapping
{
    public class PaymentTransactionsMap:EntityTypeConfiguration<PaymentTransactions>
    {
        public PaymentTransactionsMap()
        {
            this.ToTable("PaymentTransactions");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SalesCode).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Paid).HasPrecision(28, 2);
            this.Property(p => p.SalesType).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
