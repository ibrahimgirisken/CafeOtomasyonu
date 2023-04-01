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
            RuleFor(p => p.SalesNumber).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez!");
            RuleFor(p => p.SalesNumber).Length(12).WithMessage("Satış Kodu 12 karakter olmalıdır!");
            RuleFor(p => p.Amount).NotEmpty().WithMessage("Miktar alanı boş geçilemez");
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Miktar alanı boş geçilemez!");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyatı alanı boş geçilemez!");
        }
    }
}
