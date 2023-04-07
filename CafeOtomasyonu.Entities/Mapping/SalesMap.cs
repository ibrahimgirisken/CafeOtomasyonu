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
    public class SalesMap:EntityTypeConfiguration<Sales>
    {
        public SalesMap()
        {
            this.ToTable("Sales");
            this.HasKey(p=>p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SalesNumber).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
            this.HasOptional(p => p.Customers).WithMany(p=>p.Sales).HasForeignKey(p => p.CustomerId);
        }
    }
}
