﻿using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class PaymentTransactionsValidator:AbstractValidator<PaymentTransactions>
    {
        public PaymentTransactionsValidator()
        {

        }
    }
}
