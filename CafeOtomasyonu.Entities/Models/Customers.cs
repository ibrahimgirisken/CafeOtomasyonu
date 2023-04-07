using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Customers:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
