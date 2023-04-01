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
using CafeOtomasyonu.WinForms.Menus;
using DevExpress.XtraEditors;
using CafeOtomasyonu.WinForms.Products;

namespace CafeOtomasyonu.WinForms.MainMenu
{
    public partial class frmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FormGet(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProducts frm=new frmProducts();
            FormGet(frm);
        }

        private void btnMenus_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMenus frm=new frmMenus();
            frm.ShowDialog();
        }
    }
}