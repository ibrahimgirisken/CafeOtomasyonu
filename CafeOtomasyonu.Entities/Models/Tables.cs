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
        public bool Status { get; set; }
        public bool Rezerv { get; set; }
        public DateTime SavedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Process { get; set; }
        public string OrderCode { get; set; }
        public int? UserId { get; set; }
        public virtual ICollection<TableMovements> TableMovements { get; set; }
        public virtual Users Users { get; set; }
    }
}
