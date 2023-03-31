using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class PaymentTransactions
    {
        public int Id { get; set; }
        public string SalesNumber { get; set; }
        public string SalesType { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
