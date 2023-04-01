using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class UsersValidator:AbstractValidator<Users>
    {
        public UsersValidator()
        {
            RuleFor(p => p.FullName).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez!");
            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez!");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(p => p.Telephone).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez!");

            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış E-mail Adres formatı!");
        }
    }
}
