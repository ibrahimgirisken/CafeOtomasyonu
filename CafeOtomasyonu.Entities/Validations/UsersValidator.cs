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
            RuleFor(p => p.UserName).MinimumLength(5).WithMessage("Kullanıcı Adı en az 5 karakter olmalı!");
            RuleFor(p => p.UserName).MaximumLength(20).WithMessage("Kullanıcı Adı en fazla 20 karakter olmalı!");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(p => p.Password).MinimumLength(6).WithMessage("Şifre alanı en az 6 karakter olmalı!");
            RuleFor(p => p.Password).MaximumLength(20).WithMessage("Şifre alanı en fazla 20 karakter olmalı!");
            RuleFor(p => p.Telephone).NotEmpty().WithMessage("Telefon alanı boş geçilemez!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez!");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış E-mail Adres formatı!");
        }
    }
}
