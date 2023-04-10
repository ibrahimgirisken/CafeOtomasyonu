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
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTableRezerv : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private int _tableId;
        public bool _operationIsDone;
        private Entities.Models.Tables _tables;
        private TablesDal _tablesDal = new TablesDal();
        public frmTableRezerv(int tableId)
        {
            _tableId = tableId;
            InitializeComponent();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            _tables = _tablesDal.GetByFilter(_context, t => t.Id == _tableId);
            _tables.Process = txtProcess.Text;
            _tables.UpdateDate = Convert.ToDateTime(dateEditDate.EditValue);
            _tables.UserId = UserSettings.userId;
            _tables.Rezerv = true;
            _tablesDal.Save(_context);
            _operationIsDone=true;
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}