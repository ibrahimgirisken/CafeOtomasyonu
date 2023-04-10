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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            gridViewMenu.RefreshData();
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(text:"Seçili olan menü silinsin mi?",caption:"Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridViewMenu.DeleteSelectedRows();
                _context.SaveChanges();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}