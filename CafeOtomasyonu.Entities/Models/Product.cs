using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int MenuUd { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice1 { get; set; }
        public decimal UnitPrice2 { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
