using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class TableMovements : IEntity
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public int TableId { get; set; }
        //public int MenuId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountTotal { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual Tables Tables { get; set; }
        public virtual  Product Product { get; set; }
    }
}
