using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    [Table("OrderCode")]
    public class OrderCode
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Column(TypeName="varchar")]
        public string OrderDefinition { get; set; }
        public int Number { get; set; }
    }
}
