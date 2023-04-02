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

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTables : DevExpress.XtraEditors.XtraForm
    {
        CafeContext _context=new CafeContext();
        TablesDal _tablesDal=new TablesDal();
        public frmTables()
        {
            InitializeComponent();
            tableList();
        }

        private void tableList()
        {
            gridControl1.DataSource = _tablesDal.tablesList(_context);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tableList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var tables = _tablesDal.GetByFilter(_context,t=>t.Id==selectId);
            frmTableAdd frm = new frmTableAdd(tables);
            frm.ShowDialog();
            if (frm._saveStatus)
            {
                tableList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd(new Entities.Models.Tables());
            frm.ShowDialog();
            if (frm._saveStatus)
            {
                tableList();
            }
        }

        private void btnStatusReplace_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int selectId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var tables = _tablesDal.GetByFilter(_context, t => t.Id == selectId);
                if (tables.Status)
                {
                    tables.Status = false;
                }
                else if (!tables.Status)
                {
                    tables.Status = true;
                } 
                _tablesDal.Save(_context);
                tableList();
            }
        }

        private void btnRezervReplace_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int selectId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var tables = _tablesDal.GetByFilter(_context, t => t.Id == selectId);
                if (tables.Rezerv)
                {
                    tables.Rezerv = false;
                }
                else if (!tables.Rezerv)
                {
                    tables.Rezerv = true;
                }
                _tablesDal.Save(_context);
                tableList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _tablesDal.Delete(_context, p => p.Id == selectId);
                _tablesDal.Save(_context);
                tableList();
            }
        }
    }
}