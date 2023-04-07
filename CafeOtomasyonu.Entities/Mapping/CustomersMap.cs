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
    public class CustomersMap: EntityTypeConfiguration<Customers>
    {
        public CustomersMap()
        {
            this.ToTable("Customers");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FullName).IsRequired();
            this.Property(p => p.FullName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Telephone).HasColumnType("varchar").HasMaxLength(25);
            this.Property(p => p.Address).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
