using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;

namespace CafeOtomasyonu.WinForms.Payments
{
    public partial class frmPaymentTransactions : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private PaymentTransactionsDal paymentTransactionsDal = new PaymentTransactionsDal();

        public frmPaymentTransactions(string salesCode=null)
        {
            InitializeComponent();
            if (salesCode==null)
            {
                gridControlPaymentTransactions.DataSource = paymentTransactionsDal.GetAll(context);
            }
            else if(salesCode!=null)

            {
                gridControlPaymentTransactions.DataSource = paymentTransactionsDal.GetAll(context,p=>p.SalesCode==salesCode);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}