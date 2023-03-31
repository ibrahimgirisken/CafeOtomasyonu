using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class TableMovements
    {
        public int Id { get; set; }
        public string SalesNumber { get; set; }
        public int TableId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
