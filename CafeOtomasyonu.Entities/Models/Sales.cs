using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public string SalesNumber { get; set; }
        public int? CustomerId { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal Amount { get; set; }
        public decimal Paid { get; set; }
        public decimal Remainder { get; set; }
        public string Description { get; set; }
        public DateTime EndProcessDate { get; set; }
        public virtual Customers Customers { get; set; }

    }
}
