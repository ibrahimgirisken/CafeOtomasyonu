using CafeOtomasyonu.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Users : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mission { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ReminderQuestion { get; set; }
        public string Reply { get; set; }
        public string Description { get; set; }
        public DateTime SavedDate { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<UserMovements> UserMovements { get; set; }
        public virtual ICollection<Tables> Tables { get; set; }
    }
}
