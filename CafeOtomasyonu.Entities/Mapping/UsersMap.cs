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
    public class UsersMap:EntityTypeConfiguration<Users>
    {
        public UsersMap()
        {
            this.ToTable("Users");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Address).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.FullName).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.Telephone).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Mission).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.UserName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Password).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.ReminderQuestion).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Reply).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
