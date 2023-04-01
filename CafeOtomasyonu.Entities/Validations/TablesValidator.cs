using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class TablesValidator:AbstractValidator<Tables>
    {
        public TablesValidator()
        {
            RuleFor(p => p.TableName).NotEmpty().WithMessage("Masa Adı alanı boş geçilemez'");
        }
    }
}
