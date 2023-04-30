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
using CafeOtomasyonu.WinForms.Payments;
using CafeOtomasyonu.WinForms.Products;
using CafeOtomasyonu.WinForms.ReportForm;
using DevExpress.Accessibility;
using CafeOtomasyonu.WinForms.ReportFile;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTableOrders : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private CustomersDal _customersDal = new CustomersDal();
        private TablesMovementsDal _tablesMovementsDal = new TablesMovementsDal();
        private PaymentTransactionsDal _paymentTransactionsDal;
        private int? _tableId = null;
        private string _salesCode = null;
        private Entities.Models.Sales _sales;
        private SalesDal _salesDal = new SalesDal();
        private Entities.Models.Tables _tables;
        private TablesDal _tablesDal = new TablesDal();
        ProductDal _productDal = new ProductDal();
        private bool _packageOrder = false;
        private bool _print;
        frmProductSelect frm = new frmProductSelect();
        private MenuDal menuDal = new MenuDal();

        public frmTableOrders(int? tableId = null, string tableName = null, string salesCode = null, bool packageOrder = false)
        {
            InitializeComponent();
            _tableId = tableId;
            _salesCode = salesCode;
            _packageOrder = packageOrder;
            _context.TableMovements.Where(t => t.SalesCode == _salesCode).Load();
            _context.PaymentTransactions.Where(p => p.SalesCode == _salesCode).Load();
            _context.Product.Load();
            gridControlOrders.DataSource = _context.TableMovements.Local.ToBindingList();
            gridControlPayments.DataSource = _context.PaymentTransactions.Local.ToBindingList();
            lookUpCustomer.Properties.DataSource = _customersDal.GetAll(_context);
            if (_tableId != null)
            {
                lblTitle.Text = tableName + " Siparişleri";
                _tables = _tablesDal.GetByFilter(_context, t => t.Id == _tableId);
            }
            else if (_tableId == null)
            {
                lblTitle.Text = "Paket Siparişi veya Veresiye İşlemleri";
            }
            _sales = _salesDal.GetByFilter(_context, p => p.SalesCode == _salesCode);
            if (_sales != null)
            {
                lookUpCustomer.EditValue = _sales.CustomerId;
                txtDescription.Text = _sales.Description;
                dateDate.Text = _sales.EndProcessDate.ToString();
            }
            FasterOrder();

        }

        public void FasterOrder()
        {
            var model = menuDal.GetAll(_context);
            foreach (var item in model)
            {
                var page = new XtraTabPage();
                page.Text = item.MenuName;
                page.Name = item.Id.ToString();
                xtraTabControl1.TabPages.Add(page);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);

                var modelFasterOrder = _productDal.GetAll(_context, p => p.MenuId == item.Id);
                foreach (var product in modelFasterOrder)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Text = product.ProductName;
                    btn.Name = product.Id.ToString();
                    btn.Size = new Size(100, 100);
                    btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
                    btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    var img = Image.FromFile(product.Image);
                    ımageListProductImage.Images.Add(img);
                    btn.ImageList = ımageListProductImage;
                    btn.Image = ımageListProductImage.Images[0];
                    ımageListProductImage.Images.RemoveAt(0);
                    btn.Appearance.BackColor = Control.DefaultBackColor;
                    btn.BorderStyle = BorderStyles.NoBorder;
                    panel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private bool UpdateGridViewRow(int id)
        {
            var result = _tablesMovementsDal.GetByFilter(_context, p => p.Product.Id == id);
            if (result != null)
            {
                return true;
            }

            return false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            var senderBtn = sender as SimpleButton;
            int productId = Convert.ToInt32(senderBtn.Name);
            var _product = _productDal.GetByFilter(_context, p => p.Id == productId);


            TableMovements tableMovements = new TableMovements
            {
                SalesCode = _salesCode,
                ProductId = productId,
                TableId = _tableId,
                Quantity = 1,
                DiscountTotal = 0,
                UnitPrice = getPrice(_product),
                Description = "",
                Date = DateTime.Now
            };
            _tablesMovementsDal.AddOrUpdate(_context, tableMovements);


        }

        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            lookUpCustomer.EditValue = null;
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


        private void repositoryOrderDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili ödeme silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOrders.DeleteSelectedRows();
                Calculate();
            }

        }

        private void repositoryPaymentDelete_ButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili sipariş silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewPayments.DeleteSelectedRows();
                Calculate();
            }
        }

        decimal getPrice(Product _product)
        {
            decimal unitPrice = _product.UnitPrice1;
            var model = _context.Settings.FirstOrDefault(p => p.SettingDefinition == "Unit Price");
            if (model != null)
            {
                switch (model.SettingName)
                {
                    case "UnitPrice1":
                        unitPrice = _product.UnitPrice1;
                        break;
                    case "UnitPrice2":
                        unitPrice = _product.UnitPrice2;
                        break;
                    case "UnitPrice3":
                        unitPrice = _product.UnitPrice3;
                        break;
                }
            }
            return unitPrice;
        }
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            frm.ShowDialog();
            if (frm._selected)
            {
                TableMovements _entity = new TableMovements
                {
                    SalesCode = _salesCode,
                    TableId = _tableId,
                    ProductId = frm._product.Id,
                    Quantity = 1,
                    UnitPrice = getPrice(frm._product),
                    DiscountTotal = 0,
                    Description = txtDescription.Text,
                    Date = DateTime.Now
                };

                _tablesMovementsDal.AddOrUpdate(_context, _entity);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridControlOrders.DataSource = _context.TableMovements.Local.ToBindingList();
            gridControlPayments.DataSource = _context.PaymentTransactions.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridViewOrders.RowCount > 0)
            {
                if (dateDate.EditValue != null)
                {
                    if (_sales == null)
                    {
                        _sales = new Entities.Models.Sales();
                        _sales.SalesCode = _salesCode;
                    }

                    _sales.CustomerId = (int?)lookUpCustomer.EditValue;
                    _sales.Description = txtDescription.Text;
                    _sales.EndProcessDate = Convert.ToDateTime(dateDate.EditValue);
                    _sales.Remainder = calcRemainder.Value;
                    _sales.Paid = calcPaid.Value;
                    _sales.Amount = calcTotal.Value;
                    _sales.DiscountTotal = calcDiscountTotal.Value;
                    _sales.PackageOrder = _packageOrder;
                    _salesDal.AddOrUpdate(_context, _sales);
                    _context.SaveChanges();
                    _print = true;
                }
                else
                {
                    MessageBox.Show("Tarih girilmesi gerekir!", "Uyarı");
                }
            }

            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı", "Uyarı");
            }
        }


        private void payment_Click(object sender, EventArgs e)
        {
            if (gridViewOrders.RowCount > 0)
            {
                var btn = sender as SimpleButton;
                frmPayment frm = new frmPayment(_salesCode, btn.Text, calcRemainder.Value);
                frm.ShowDialog();
                _paymentTransactionsDal = new PaymentTransactionsDal();
                if (frm._saved)
                {
                    if (_paymentTransactionsDal.AddOrUpdate(_context, frm._paymentTransactions))
                    {
                        gridViewOrders.RefreshData();
                        Calculate();
                    }
                }
            }
        }

        private void gridViewOrders_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }

        private void gridViewPayments_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Calculate();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (_tableId != null)
            {
                if (calcRemainder.Value > 0)
                {
                    if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye borç işlemi kayıt edilecektir!", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (_sales != null)
                        {
                            if (_sales.CustomerId == null)
                            {
                                MessageBox.Show("Önce müşteri seçimi yapınız!", "Uyarı");
                            }
                            else
                            {
                                ResultMethod();
                                this.Close();
                            }
                        }
                    }

                }
                else if (calcRemainder.Value == 0)
                {
                    ResultMethod();
                    this.Close();
                }
            }
        }

        private void ResultMethod()
        {
            _tables.OrderCode = null;
            _tables.Status = false;
            _tables.Process = null;
            _tables.UserId = null;
            _tablesDal.AddOrUpdate(_context, _tables);
            _tablesDal.Save(_context);
        }

        private void Prices(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewOrders.SetFocusedRowCellValue(colUnitPrice, e.Item.Caption);
        }

        private void btnReceiptPrint_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            if (_print == true)
                if (_tableId != null)
                {
                    rptSalesReceipt _rptSalesReceipt = new rptSalesReceipt(salesCode: _salesCode, info: _tables.TableName, _sales);
                    frmReportView frm = new frmReportView(_rptSalesReceipt);
                    frm.ShowDialog();
                }
                else if (_tableId == null)
                {
                    if (_sales.CustomerId == null)
                    {
                        rptSalesReceipt _rptSalesReceipt = new rptSalesReceipt(salesCode: _salesCode, info: _salesCode, _sales);
                        frmReportView frm = new frmReportView(_rptSalesReceipt);
                        frm.ShowDialog();

                    }
                    else if (_sales.CustomerId != null)

                    {
                        rptSalesReceipt _rptSalesReceipt = new rptSalesReceipt(salesCode: _salesCode, info: _salesCode + " " + _sales.Customers.FullName, _sales);
                        frmReportView frm = new frmReportView(_rptSalesReceipt);
                        frm.ShowDialog();
                    }

                }
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int productId = Convert.ToInt32(gridViewOrders.GetFocusedRowCellValue(colProductId));
            var model = _productDal.GetByFilter(_context, p => p.Id == productId);
            barFiyat1.Caption = model.UnitPrice1.ToString();
            barFiyat2.Caption = model.UnitPrice2.ToString();
            barFiyat3.Caption = model.UnitPrice3.ToString();
            radialMenu1.ShowPopup(MousePosition);
        }

    }
}
