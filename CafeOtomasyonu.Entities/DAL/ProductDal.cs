using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Repository;
using CafeOtomasyonu.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.DAL
{
    public class ProductDal:EntityRepositoryBase<CafeContext,Product,ProductValidator>
    {
        public object ProductList(CafeContext context)
        {
            var list=(from u in context.Product select new
            {
                u.Id,
                u.MenuId,
                Menu=u.Menu.MenuName,
                u.ProductNumber,
                u.ProductName,
                u.UnitPrice1,
                u.UnitPrice2,
                u.UnitPrice3,
                u.Description,
                u.Image,
                u.Date
            }).ToList();
            return list;
        }
    }
}
