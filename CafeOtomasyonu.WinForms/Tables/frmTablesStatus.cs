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
    public partial class frmTablesStatus : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private CheckButton btnSender;
        private OrderCode modelOrderCode;
        private string _orderCode;
        private int _tableId;
        private Entities.Models.Tables _tables;
        private TablesDal _tablaDal = new TablesDal();
        public frmTablesStatus()
        {
            InitializeComponent();
            modelOrderCode = _context.OrderCodes.First();
            getTables();
        }
        public void getTables()
        {
            flowLayoutPanel1.Controls.Clear();
            _context = new CafeContext();
            var model = _context.Tables.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].TableName;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].OrderCode;
                btn.Width = 80;
                btn.Height = 100;
                flowLayoutPanel1.Controls.Add(btn);
                if (model[i].Rezerv && !model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Yellow;
                }
                else if (model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                btn.Click += Btn_Click;
            }
        }

        public void StatusRefresh()
        {
            btnOrderAdd.Enabled = false;
            btnTableOpen.Enabled = false;
            btnRezerv.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            btnSender = sender as CheckButton;
            _tableId = Convert.ToInt32(btnSender.Name);
            StatusRefresh();
            if (btnSender.Appearance.BackColor == Color.Yellow)
            {
                btnTableOpen.Enabled = true;
            }
            else if (btnSender.Appearance.BackColor == Color.Green)
            {
                btnTableOpen.Enabled = true;
                btnRezerv.Enabled = true;

            }
            else if (btnSender.Appearance.BackColor == Color.Red)
            {
                btnOrderAdd.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTableOpen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSender.Text + " açılsın mı?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _tables = _tablaDal.GetByFilter(_context, t => t.Id == _tableId);
                _tables.OrderCode = modelOrderCode.OrderDefinition + modelOrderCode.Number;
                _tables.Status = true;
                modelOrderCode.Number++;
                _tablaDal.Save((_context));
                btnSender = null;
                StatusRefresh();
                getTables();
            }
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            frmTableRezerv frm = new frmTableRezerv(_tableId);
            frm.ShowDialog();
            StatusRefresh();
            if (frm._operationIsDone)
            {
                getTables();
            }
            btnSender = null;
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            _orderCode = btnSender.Tag.ToString();
            frmTableOrders frm = new frmTableOrders(tableId: _tableId, tableName: btnSender.Text, salesCode: _orderCode);
            frm.ShowDialog();
            btnSender = null;
            StatusRefresh();
            getTables();
        }
    }
}