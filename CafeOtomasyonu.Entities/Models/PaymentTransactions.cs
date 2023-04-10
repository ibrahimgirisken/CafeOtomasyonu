using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class PaymentTransactions:IEntity
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public string SalesType { get; set; }
        public decimal Paid { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
