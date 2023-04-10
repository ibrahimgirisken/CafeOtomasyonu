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
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.Products;

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTableOrders : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private CustomersDal _customersDal = new CustomersDal();
        private TablesMovementsDal _tablesMovementsDal = new TablesMovementsDal();
        private int? _tableId = null;
        private string _salesCode = null;

        public frmTableOrders(int? tableId = null, string tableName = null, string salesCode = null)
        {
            InitializeComponent();
            _tableId = tableId;
            _salesCode = salesCode;
            _context.TableMovements.Where(t => t.SalesCode == _salesCode).Load();
            _context.PaymentTransactions.Where(p => p.SalesCode == _salesCode).Load();
            _context.Product.Load();
            gridControlOrders.DataSource = _context.TableMovements.Local.ToBindingList();
            gridControlPayments.DataSource = _context.PaymentTransactions.Local.ToBindingList();
            lookUpCustomer.Properties.DataSource = _customersDal.GetAll(_context);
            if (_tableId != null)
            {
                lblTitle.Text = tableName + " Siparişleri";
            }
        }


        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            lookUpCustomer.EditValue = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void Calculate()
        {
            calcDiscountTotal.Value = Convert.ToDecimal(colDiscountTotal.SummaryItem.SummaryValue);
            calcDiscountedTotal.Value = Convert.ToDecimal(colAmount.SummaryItem.SummaryValue);
            calcPaid.Value = Convert.ToDecimal(colPaid.SummaryItem.SummaryValue);
            calcTotal.Value = calcDiscountTotal.Value + calcDiscountedTotal.Value;
            calcRemainder.Value = calcDiscountedTotal.Value - calcPaid.Value;
            //
            //İndirim Oranı
            if (calcTotal.Value != 0)
            {
                calcDiscountRate.Value = 100 * Convert.ToDecimal(colDiscountTotal.SummaryItem.SummaryValue) /
                                         (Convert.ToDecimal(colAmount.SummaryItem.SummaryValue) +
                                          Convert.ToDecimal(colDiscountTotal.SummaryItem.SummaryValue));
            }

            else if (calcTotal.Value == 0)

            {
                calcDiscountRate.Value = 0;
            }
        }

        private void gridViewOrders_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryPaymentDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryOrderDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            frmProductSelect frm = new frmProductSelect();
            frm.ShowDialog();
            if (frm._selected)
            {
                TableMovements _entity = new TableMovements
                {
                    SalesCode = _salesCode,
                    TableId = Convert.ToInt32(_tableId),
                    ProductId = frm._product.Id,
                    Quantity = 1,
                    UnitPrice = frm._product.UnitPrice1,
                    DiscountTotal = 0,
                    Description = "",
                    Date = DateTime.Now
                };

                _tablesMovementsDal.AddOrUpdate(_context, _entity);
            }
        }

        private void gridViewOrders_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }
    }
}