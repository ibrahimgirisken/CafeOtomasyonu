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
    public class UserMovementsDal:EntityRepositoryBase<CafeContext,UserMovements,UserMovementsValidator>
    {
        public void UserMovementsDalAdd(CafeContext context,UserMovements _userMovements,string description)
        {
            UserMovementsDal _userMovementsDal = new UserMovementsDal();

            _userMovements.Date = DateTime.Now;
            _userMovements.Description = description;
            if (_userMovementsDal.AddOrUpdate(context, _userMovements))
            {
                _userMovementsDal.Save(context);
            }
        }
    }
}
