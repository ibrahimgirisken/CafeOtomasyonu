﻿using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Mapping
{
    public class UserMovementsMap:EntityTypeConfiguration<UserMovements>
    {
        public UserMovementsMap()
        {
            this.ToTable("UserMovements");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);

            this.HasRequired(x => x.Users).WithMany(x => x.UserMovements).HasForeignKey(x => x.UserId);
        }
    }
}
