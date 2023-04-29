using CafeOtomasyonu.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("name=connection")
        {

        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PaymentTransactions> PaymentTransactions { get; set; }
        public DbSet<Rollers> Rollers { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<TableMovements> TableMovements { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<UserMovements> UserMovements { get; set; }
        public DbSet<Users> Users { get; set; }
        public  DbSet<Customers> Customers { get; set; }
        public  DbSet<OrderCode> OrderCodes { get; set; }
        public DbSet<Settings> Settings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new PaymentTransactionsMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RollersMap());
            modelBuilder.Configurations.Add(new SalesMap());
            modelBuilder.Configurations.Add(new TableMovementsMap());
            modelBuilder.Configurations.Add(new TablesMap());
            modelBuilder.Configurations.Add(new UserMovementsMap());
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new CustomersMap());
        }
    }
}
