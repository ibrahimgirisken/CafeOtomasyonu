using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice1 { get; set; }
        public decimal UnitPrice2 { get; set; }
        public decimal UnitPrice3 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<TableMovements> TableMovements{ get; set; }
    }
}
