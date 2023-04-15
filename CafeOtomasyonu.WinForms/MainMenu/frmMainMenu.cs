using DevExpress.XtraBars;
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
using CafeOtomasyonu.WinForms.Menus;
using CafeOtomasyonu.WinForms.Payments;
using DevExpress.XtraEditors;
using CafeOtomasyonu.WinForms.Products;
using CafeOtomasyonu.WinForms.Sales;
using CafeOtomasyonu.WinForms.Tables;
using CafeOtomasyonu.WinForms.Users;

namespace CafeOtomasyonu.WinForms.MainMenu
{
    public partial class frmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainMenu()
        {
            InitializeComponent();
            XtraForm frm = new frmUserLogin();
            frm.ShowDialog();
        }

        void FormGet(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmProducts();
            FormGet(frm);
        }

        private void btnMenus_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenus();
            frm.ShowDialog();
        }

        private void btnTables_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmTables();
            FormGet(frm);

        }

        private void btnTableOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmTablesStatus();
            FormGet(frm);
        }

        private void btnSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSales();
            FormGet(frm);
        }

        private void btnPaymentTransactions_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmPaymentTransactions();
            FormGet(frm);
        }

        private void btnPackageOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                using (CafeContext context = new CafeContext())
                {
                    var model = context.OrderCodes.First();
                    string salesCode = model.OrderDefinition + model.Number;
                    model.Number++;
                    context.SaveChanges();
                    XtraForm frm = new frmTableOrders(salesCode: salesCode,packageOrder:true);
                    frm.ShowDialog();
                } 
            }

        }
    }
}