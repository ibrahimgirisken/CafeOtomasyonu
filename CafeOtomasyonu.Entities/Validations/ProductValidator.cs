using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductNumber).NotEmpty().WithMessage("Ürün Kodu alanı boş geçilemez!");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı alanı boş geçilemez!");
            RuleFor(p => p.UnitPrice1).NotEmpty().WithMessage("Birim Fiyatı1 alanı boş geçilemez!");
            RuleFor(p => p.UnitPrice2).NotEmpty().WithMessage("Birim Fiyatı2 alanı boş geçilemez!");
            RuleFor(p => p.UnitPrice3).NotEmpty().WithMessage("Birim Fiyatı3 alanı boş geçilemez!");
        }
    }
}
