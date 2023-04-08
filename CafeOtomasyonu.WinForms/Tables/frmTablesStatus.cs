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

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTablesStatus : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private CheckButton btnSender;
        private OrderCode modelOrderCode;
        private object _orderCode;
        private int _tableId;
        public frmTablesStatus()
        {
            InitializeComponent();
            modelOrderCode = _context.OrderCodes.First();
            getTables();
        }
        public void getTables()
        {
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
            btnOrders.Enabled = false;
            btnTableOpen.Enabled = false;
            btnRezerv.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            btnSender = sender as CheckButton;
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
                btnOrders.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            _tableId = Convert.ToInt32(btnSender.Name);
            frmTableOrders frm = new frmTableOrders(tableId:_tableId,tableName:btnSender.Text);
            frm.ShowDialog();
        }
    }
}