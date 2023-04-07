using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeOtomasyonu.Entities.Models;
using FluentValidation;

namespace CafeOtomasyonu.Entities.Validations
{
    public class CustomersValidator:AbstractValidator<Customers>
    {
        public CustomersValidator()
        {
            RuleFor(p => p.FullName).NotEmpty().WithMessage("Ad Soyad boş geçilemez!");
            RuleFor(p => p.FullName).MinimumLength(3).WithMessage("Ad Soyad alanı minimum 3 karakterden oluşmalıdır!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez!");
            RuleFor(p => p.Telephone).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");

        }
    }
}
