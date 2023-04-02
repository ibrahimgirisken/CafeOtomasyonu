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
    public class TablesDal:EntityRepositoryBase<CafeContext,Tables,TablesValidator>
    {
        public object tablesList(CafeContext context)
        {
            var result = (from table in context.Tables join  t in 
                    context.Users on table.UserId equals t.Id into user from usertable in user.DefaultIfEmpty()
                select new
                {
                    table.Id,
                    table.Description,
                    table.Process,
                    table.Rezerv,
                    table.SavedDate,
                    table.Status,
                    table.TableName,
                    table.UpdateDate,
                    UserName=usertable.FullName
                }).ToList();
            return result;
        }
    }
}
