﻿using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Tables : IEntity
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = false;
        public bool Rezerv { get; set; } = false;
        public DateTime SavedDate { get; set; }=DateTime.Now;
        public DateTime UpdateDate { get; set; }=DateTime.Now;
        public string Process { get; set; }
        public string OrderCode { get; set; }
        public int? UserId { get; set; }
        public virtual ICollection<TableMovements> TableMovements { get; set; }
        public virtual Users Users { get; set; }
    }
}
