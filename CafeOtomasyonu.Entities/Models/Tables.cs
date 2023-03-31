using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Tables
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool Rezerv { get; set; }
        public DateTime SavedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
