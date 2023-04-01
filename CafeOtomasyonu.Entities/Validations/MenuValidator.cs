using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class MenuValidator:AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p=>p.MenuName).NotEmpty().WithMessage("Menu Adı alanı boş geçilemez!");
            RuleFor(p => p.MenuName).MinimumLength(3).WithMessage("Menu Adı alanı en az 3 karakterden az olamaz!");
            RuleFor(p => p.MenuName).MaximumLength(12).WithMessage("Menu Adı alanı en fazla 12 karakterden olmalıdır!");

        }
    }
}
