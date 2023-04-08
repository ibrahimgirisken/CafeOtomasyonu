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
    public partial class frmTableOrders : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private CustomersDal _customersDal=new CustomersDal();
        private int? _tableId = null;

        public frmTableOrders(int? tableId=null,string tableName=null,string orderCode=null)
        {
            InitializeComponent();
            _tableId=tableId;
            lookUpCustomer.Properties.DataSource = _customersDal.GetAll(_context);
            if (_tableId!=null)
            {
                lblTitle.Text = tableName + " Siparişleri";
            }
        }


        private void repositoryOrderDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            lookUpCustomer.EditValue = null;
        }

        private void repositoryPaymentDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}