using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class TableMovementsValidator:AbstractValidator<TableMovements>
    {
        public TableMovementsValidator()
        {
            RuleFor(p => p.SalesCode).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez!");
            //RuleFor(p => p.SalesCode).Length(12).WithMessage("Satış Kodu 12 karakter olmalıdır!");
            RuleFor(p => p.Quantity).NotEmpty().WithMessage("Miktar alanı boş geçilemez");
            RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Miktar alanı boş geçilemez!");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyatı alanı boş geçilemez!");
        }
    }
}
