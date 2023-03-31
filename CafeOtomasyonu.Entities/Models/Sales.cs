using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    [Table("Sales")]
    public class Sales
    {
        public int Id { get; set; }
        public string SalesNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal Paid { get; set; }
        public decimal Remainder { get; set; }
        public string Description { get; set; }
        public DateTime EndProcessDate { get; set; }

    }
}
