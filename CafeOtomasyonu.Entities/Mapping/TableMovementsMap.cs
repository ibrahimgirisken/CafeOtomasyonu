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
    public class TableMovementsMap:EntityTypeConfiguration<TableMovements>
    {
        public TableMovementsMap()
        {
            this.ToTable("TableMovements");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SalesNumber).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);

            this.HasRequired(x=>x.Tables).WithMany(x=>x.TableMovements).HasForeignKey(x=>x.TableId);
        }
    }
}
