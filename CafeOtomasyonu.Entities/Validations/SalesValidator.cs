using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class SalesValidator:AbstractValidator<Sales>
    {
        public SalesValidator()
        {
            RuleFor(p => p.SalesNumber).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez!");
        }
    }
}
