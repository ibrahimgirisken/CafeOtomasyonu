using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Roles;
using CafeOtomasyonu.WinForms.Tables;
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Menus
{
    public partial class frmMenus : DevExpress.XtraEditors.XtraForm
    {
        CafeContext _context=new CafeContext();

        public frmMenus()
        {
            InitializeComponent();
            _context.Menu.Load();
            gridControlMenu.DataSource = _context.Menu.Local.ToBindingList();
            UserAuthorization.AdminStatus(_context,btnSave);  
            UserAuthorization.AdminStatus(_context,btnDelete);  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            gridViewMenu.RefreshData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTableMovements_Click(object sender, EventArgs e)
        {
            int _menuId = Convert.ToInt32(gridViewMenu.GetFocusedRowCellValue(colId));

            frmTableMovements frm_TableMovements = new frmTableMovements(menuId:_menuId);
            frm_TableMovements.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "Seçili olan menü silinsin mi?", caption: "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewMenu.DeleteSelectedRows();
                _context.SaveChanges();
            }
        }
    }
}