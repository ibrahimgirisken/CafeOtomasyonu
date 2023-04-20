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
using CafeOtomasyonu.WinForms.ReportFile;
using CafeOtomasyonu.WinForms.ReportForm;
using CafeOtomasyonu.WinForms.Roles;
using CafeOtomasyonu.WinForms.Sales;
using CafeOtomasyonu.WinForms.Tables;
using CafeOtomasyonu.WinForms.Users;

namespace CafeOtomasyonu.WinForms.MainMenu
{
    public partial class frmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        public frmMainMenu()
        {
            InitializeComponent();
            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                Entities.Models.Users userAdminCreate = new Entities.Models.Users
                {
                    UserName = "Admin",
                    Address = "Admin Adres",
                    Description = "Admin Açıklama",
                    FullName = "Admin Admin",
                    Mission = "Admin",
                    Password = "123456",
                    Telephone = "1234567890",
                    Email = "test@test.com",
                    ReminderQuestion = "Admin",
                    Reply = "Admin",
                    Admin = true,
                    SavedDate = DateTime.Now
                };
                context.Users.Add(userAdminCreate);
                context.SaveChanges();
                foreach (var item in ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Caption != "")
                        {
                            Rollers rol = new Rollers
                            {
                                UserId = 1,
                                FormName = "frmMainMenu",
                                ControlCaption = btn.Caption,
                                ControlName = btn.Name,
                                Visible = true
                            };
                            context.Rollers.Add(rol);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        void FormGet(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private frmProducts frm_Product;
        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_Product == null || frm_Product.IsDisposed)
            {
                frm_Product = new frmProducts();
                FormGet(frm_Product);
            }
        }

        private frmMenus frm_Menus;
        private void btnMenus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_Menus == null || frm_Menus.IsDisposed)
            {
                frm_Menus = new frmMenus();
                FormGet(frm_Menus);
            }
        }

        private frmTables frm_Tables;
        private void btnTables_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_Tables == null || frm_Tables.IsDisposed)
            {
                frm_Tables = new frmTables();
                FormGet(frm_Tables);
            }

        }
        private frmTablesStatus frm_TablesStatus;
        private void btnTableOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_TablesStatus == null || frm_TablesStatus.IsDisposed)
            {
                frm_TablesStatus = new frmTablesStatus();
                FormGet(frm_TablesStatus);
            }
        }

        private frmSales frm_Sales;
        private void btnSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_Sales == null || frm_Sales.IsDisposed)
            {
                frm_Sales = new frmSales();
                FormGet(frm_Sales);
            }
        }
        frmPaymentTransactions frm_PaymentTransactions;
        private void btnPaymentTransactions_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_PaymentTransactions == null || frm_PaymentTransactions.IsDisposed)
            {
                frm_PaymentTransactions = new frmPaymentTransactions();
                FormGet(frm_PaymentTransactions);
            }
        }

        private frmTableOrders frm_TablesOrders;
        private void btnPackageOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (CafeContext context = new CafeContext())
                {
                    var model = context.OrderCodes.First();
                    string salesCode = model.OrderDefinition + model.Number;
                    model.Number++;
                    context.SaveChanges();
                    frm_TablesOrders = new frmTableOrders(salesCode: salesCode, packageOrder: true);
                    frm_TablesOrders.ShowDialog();
                }
            }

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private rptTableTransactionReport rpt_TableTransactionReport;
        frmReportView2 frm_ReportView2;
        private void barButtonTableTransactionsReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (rpt_TableTransactionReport == null || rpt_TableTransactionReport.IsDisposed)
            {
                rpt_TableTransactionReport = new rptTableTransactionReport();
                frm_ReportView2 = new frmReportView2(rpt_TableTransactionReport);
                frm_ReportView2.ShowDialog();
            }
        }

        private frmUsers frm_Users;
        private void btnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_Users==null||frm_Users.IsDisposed)
            {
                frm_Users = new frmUsers();
                FormGet(frm_Users);
            }
        }

        private void btnUserMovements_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRoles_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private frmTableMovements frm_TableMovements;
        private void btnTableMovements_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_TableMovements == null || frm_TableMovements.IsDisposed)
            {
                frm_TableMovements = new frmTableMovements();
                frm_TableMovements.ShowDialog();
            }
        }

        private frmSpecialReportCreate frm_SpecialReportCreate;
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm_SpecialReportCreate == null || frm_SpecialReportCreate.IsDisposed)
            {
                frm_SpecialReportCreate = new frmSpecialReportCreate();
                frm_SpecialReportCreate.ShowDialog();
            }

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            XtraForm frm = new frmUserLogin();
            frm.ShowDialog();
            UserAuthorization.GetAuthorization(context, ribbon);
        }
    }
}