using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Migrations;
using CafeOtomasyonu.Entities.Models;
using Menu = CafeOtomasyonu.Entities.Models.Menu;

namespace CafeOtomasyonu.Entities.Tools
{
    public class ConnectionTools
    {
        public static string conn()
        {
            string readStr;
            string path = @"ConnectionStr\conn.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader=new StreamReader(fileStream))
            {
                string row = reader.ReadLine();
                readStr = row;
                reader.Close();
            }
            fileStream.Close();
            return readStr;
        }
        public static void ConnectionControl()
        {
            using (var context=new CafeContext())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show("Veritabanınız oluşturulacak. Daha sonra ayrı bir forma yönlendirileceksiniz!");
                    context.Database.CreateIfNotExists();
                }
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<CafeContext,Configuration>());
            }
        }
        public static void FillData(CafeContext context)
        {
            if (!context.Tables.Any())
            {
                List<Tables> tables = new List<Tables>
                {
                    new Tables()
                    {
                        TableName = "Masa-1",
                        Description = "A Grubu 1.Sıra",
                        Process = "Masa-1 Oluşturuldu"
                    },
                    new Tables()
                    {
                        TableName = "Masa-2",
                        Description = "A Grubu 2.Sıra",
                        Process = "Masa-2 Oluşturuldu"
                    },
                    new Tables()
                    {
                        TableName = "Masa-3",
                        Description = "A Grubu 3.Sıra",
                        Process = "Masa-3 Oluşturuldu"
                    }
                };
                context.Tables.AddRange(tables);
                context.SaveChanges();
            }

            if (!context.Menu.Any())
            {
                List<Menu> menus = new List<Menu>
                {
                    new Menu()
                    {
                        MenuName = "Sıcak İçecekler",
                        Description = "Sıçak İçecek Grubu"
                    },
                    new Menu()
                    {
                        MenuName = "Soğuk İçecekler",
                        Description = "Soğuk İçecek Grubu"
                    },
                    new Menu()
                    {
                        MenuName = "Tatlılar",
                        Description = "Tatlılar Grubu"
                    }
                };
                context.Menu.AddRange(menus);
                context.SaveChanges();
            }

            if (!context.OrderCodes.Any())
            {
                List<OrderCode> orderCodes = new List<OrderCode>()
                {
                    new OrderCode()
                    {
                        Number = 1,
                        OrderDefinition = "Satış"
                    }
                };
                context.OrderCodes.AddRange(orderCodes);
                context.SaveChanges();
            }
        }
    }
}
