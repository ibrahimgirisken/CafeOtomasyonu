using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Abstracts;

namespace CafeOtomasyonu.Entities.Models
{
    [Table(name:"Settings")]
    public class Settings:IEntity
    {
        public int Id { get; set; }
        public string SettingDefinition { get; set; }
        public string SettingName { get; set; }

    }
}
