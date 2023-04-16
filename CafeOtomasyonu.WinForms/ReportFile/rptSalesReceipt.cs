using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;

namespace CafeOtomasyonu.WinForms.ReportFile
{
    public partial class rptSalesReceipt : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private TablesMovementsDal tablesMovementsDal = new TablesMovementsDal();
        public rptSalesReceipt(string salesCode,string info,Entities.Models.Sales sales=null)
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            xrLabelInfo.Text = info;
            source.DataSource = tablesMovementsDal.GetAll(context, t => t.SalesCode == salesCode);
            this.DataSource = source;
            xrTableProductName.DataBindings.Add("Text", DataSource, "Product.ProductName");
            xrTableQuantity.DataBindings.Add("Text", DataSource, "Quantity");
            xrTableUnitPrice.DataBindings.Add("Text", DataSource, "UnitPrice");
            xrTableDiscount.DataBindings.Add("Text", DataSource, "DiscountTotal");
            xrLabelPaid.Text = sales.Paid.ToString(format:"C2");
            xrLabelRemainder.Text = sales.Remainder.ToString(format:"C2");
        }

    }
}
