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
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTablesStatus : DevExpress.XtraEditors.XtraForm
    {
        CafeContext _context=new CafeContext();
        public frmTablesStatus()
        {
            InitializeComponent();
            DynamicTables.getTables(_context,flowLayoutPanel1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}