using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Repository;
using CafeOtomasyonu.Entities.Validations;

namespace CafeOtomasyonu.Entities.DAL
{
    public class CustomersDal:EntityRepositoryBase<CafeContext,Customers,CustomersValidator>
    {
    }
}
