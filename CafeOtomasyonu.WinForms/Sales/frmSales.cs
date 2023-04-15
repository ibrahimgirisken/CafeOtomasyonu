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
using CafeOtomasyonu.WinForms.Tables;
using CafeOtomasyonu.WinForms.Payments;

namespace CafeOtomasyonu.WinForms.Sales
{
    public partial class frmSales : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private SalesDal salesDal = new SalesDal();
        public frmSales()
        {
            InitializeComponent();
            gridControlSales.DataSource= salesDal.GetAll(context);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            string salesCode = gridViewSales.GetFocusedRowCellValue(colSalesCode).ToString();
            bool packageOrder =Convert.ToBoolean(gridViewSales.GetFocusedRowCellValue(colPackageOrder));
            frmTableOrders frm = new frmTableOrders(salesCode:salesCode,packageOrder: packageOrder);
            frm.ShowDialog();
        }

        private void btnPaymentTransactions_Click(object sender, EventArgs e)
        {
            string salesCode = gridViewSales.GetFocusedRowCellValue(colSalesCode).ToString();
            frmPaymentTransactions frm = new frmPaymentTransactions(salesCode: salesCode);
            frm.ShowDialog();
        }
    }
}