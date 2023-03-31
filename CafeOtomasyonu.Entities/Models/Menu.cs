using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}
