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
    public partial class rptTableTransactionReport : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private TablesMovementsDal tablesMovementsDal = new TablesMovementsDal();
        public rptTableTransactionReport()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = tablesMovementsDal.GetAll(context);
            DataSource=source;
            xrTableId.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Id");
            xrTableSalesCode.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "SalesCode");
            xrTableTableName.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Tables.TableName");
            xrTableMenu.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Product.Menu.MenuName");
            xrTableProductName.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Product.ProductName");
            xrTableQuantity.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Quantity");
            xrTablePrice.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "UnitPrice");
            xrTableDiscountTotal.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "DiscountTotal");
            xrTableDate.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Date");
            xrTableDescription.DataBindings.Add(propertyName: "Text", DataSource, dataMember: "Description");
        }

    }
}
