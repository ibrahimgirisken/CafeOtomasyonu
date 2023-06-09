﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Payments
{
    public partial class frmPayment : DevExpress.XtraEditors.XtraForm
    {
        private string _salesCode;
        private string _salesType;
        public PaymentTransactions _paymentTransactions;
        public bool _saved;
        public decimal _remainder;
        public frmPayment(string orderCode, string orderType, decimal remainder)
        {
            InitializeComponent();
            _salesCode = orderCode;
            _salesType = orderType;
            _remainder = remainder;
            if (_salesType == "Nakit Ödeme")
            {
                lblTitle.Text = "Nakit Ödeme";
            }
            else if (_salesType == "Kredi Kartı")

            {
                lblTitle.Text = "Kredi Kartı İle Ödeme";
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dateDate.EditValue == null)
            {
                dateDate.EditValue = DateTime.Now;
            }
            _paymentTransactions = new PaymentTransactions
            {
                SalesCode = _salesCode,
                SalesType = _salesType,
                Description = txtDescription.Text,

                Date = Convert.ToDateTime(dateDate.EditValue),
                Paid = calcAmount.Value
            };
            _saved = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            calcAmount.Value = _remainder;
        }
    }
}