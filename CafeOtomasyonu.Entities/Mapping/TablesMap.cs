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
    public class TablesMap:EntityTypeConfiguration<Tables>
    {
        public TablesMap()
        {
            this.ToTable("Tables");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.TableName).HasColumnType("varchar").HasMaxLength(20);
            this.Property(p => p.Description).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.SavedDate).HasColumnType("Date");
        }
    }
}
