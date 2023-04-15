namespace CafeOtomasyonu.WinForms.Sales
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnPaymentTransactions = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlSales = new DevExpress.XtraGrid.GridControl();
            this.gridViewSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountedTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndProcessDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1246, 22);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Satışlar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnOrderDetail);
            this.groupControl1.Controls.Add(this.btnPaymentTransactions);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 423);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1246, 77);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1157, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(216, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile\r\nListele";
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderDetail.ImageOptions.Image")));
            this.btnOrderDetail.Location = new System.Drawing.Point(12, 31);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(96, 38);
            this.btnOrderDetail.TabIndex = 0;
            this.btnOrderDetail.Text = "Sipariş\r\nDetayları";
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnPaymentTransactions
            // 
            this.btnPaymentTransactions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaymentTransactions.ImageOptions.SvgImage")));
            this.btnPaymentTransactions.Location = new System.Drawing.Point(114, 31);
            this.btnPaymentTransactions.Name = "btnPaymentTransactions";
            this.btnPaymentTransactions.Size = new System.Drawing.Size(96, 38);
            this.btnPaymentTransactions.TabIndex = 2;
            this.btnPaymentTransactions.Text = "Ödeme\r\nHareketleri";
            this.btnPaymentTransactions.Click += new System.EventHandler(this.btnPaymentTransactions_Click);
            // 
            // gridControlSales
            // 
            this.gridControlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSales.Location = new System.Drawing.Point(0, 22);
            this.gridControlSales.MainView = this.gridViewSales;
            this.gridControlSales.Name = "gridControlSales";
            this.gridControlSales.Size = new System.Drawing.Size(1246, 401);
            this.gridControlSales.TabIndex = 8;
            this.gridControlSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSales});
            // 
            // gridViewSales
            // 
            this.gridViewSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSalesCode,
            this.colCustomerFullName,
            this.colCustomerId,
            this.colDiscountTotal,
            this.colDiscountedTotal,
            this.colAmount,
            this.colPaid,
            this.colRemainder,
            this.colDescription,
            this.colEndProcessDate,
            this.colPackageOrder});
            this.gridViewSales.GridControl = this.gridControlSales;
            this.gridViewSales.Name = "gridViewSales";
            this.gridViewSales.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 29;
            // 
            // colSalesCode
            // 
            this.colSalesCode.Caption = "Satış Kodu";
            this.colSalesCode.FieldName = "SalesCode";
            this.colSalesCode.Name = "colSalesCode";
            this.colSalesCode.OptionsColumn.AllowEdit = false;
            this.colSalesCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SalesCode", "Kayıt:{0}")});
            this.colSalesCode.Visible = true;
            this.colSalesCode.VisibleIndex = 2;
            this.colSalesCode.Width = 66;
            // 
            // colCustomerFullName
            // 
            this.colCustomerFullName.Caption = "Müşteri Adı Soyadı";
            this.colCustomerFullName.FieldName = "Customers.FullName";
            this.colCustomerFullName.Name = "colCustomerFullName";
            this.colCustomerFullName.OptionsColumn.AllowEdit = false;
            this.colCustomerFullName.Visible = true;
            this.colCustomerFullName.VisibleIndex = 1;
            this.colCustomerFullName.Width = 119;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.OptionsColumn.AllowEdit = false;
            this.colCustomerId.Width = 94;
            // 
            // colDiscountTotal
            // 
            this.colDiscountTotal.Caption = "İndirim Tutarı";
            this.colDiscountTotal.FieldName = "DiscountTotal";
            this.colDiscountTotal.Name = "colDiscountTotal";
            this.colDiscountTotal.OptionsColumn.AllowEdit = false;
            this.colDiscountTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiscountTotal", "İndirim Toplamı={0:0.##}")});
            this.colDiscountTotal.Width = 55;
            // 
            // colDiscountedTotal
            // 
            this.colDiscountedTotal.Caption = "İndirim Toplamı";
            this.colDiscountedTotal.DisplayFormat.FormatString = "C2";
            this.colDiscountedTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountedTotal.FieldName = "DiscountedTotal";
            this.colDiscountedTotal.Name = "colDiscountedTotal";
            this.colDiscountedTotal.OptionsColumn.AllowEdit = false;
            this.colDiscountedTotal.Visible = true;
            this.colDiscountedTotal.VisibleIndex = 4;
            this.colDiscountedTotal.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tutar";
            this.colAmount.DisplayFormat.FormatString = "C2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Tutar={0:C2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 87;
            // 
            // colPaid
            // 
            this.colPaid.Caption = "Ödenen";
            this.colPaid.DisplayFormat.FormatString = "C2";
            this.colPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.OptionsColumn.AllowEdit = false;
            this.colPaid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Paid", "{0:C2}")});
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 5;
            this.colPaid.Width = 85;
            // 
            // colRemainder
            // 
            this.colRemainder.Caption = "Kalan";
            this.colRemainder.DisplayFormat.FormatString = "C2";
            this.colRemainder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRemainder.FieldName = "Remainder";
            this.colRemainder.Name = "colRemainder";
            this.colRemainder.OptionsColumn.AllowEdit = false;
            this.colRemainder.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Remainder", "{0:C2}")});
            this.colRemainder.Visible = true;
            this.colRemainder.VisibleIndex = 6;
            this.colRemainder.Width = 83;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 290;
            // 
            // colEndProcessDate
            // 
            this.colEndProcessDate.Caption = "Son Kayıt Tarihi";
            this.colEndProcessDate.FieldName = "EndProcessDate";
            this.colEndProcessDate.Name = "colEndProcessDate";
            this.colEndProcessDate.OptionsColumn.AllowEdit = false;
            this.colEndProcessDate.Visible = true;
            this.colEndProcessDate.VisibleIndex = 8;
            this.colEndProcessDate.Width = 127;
            // 
            // colPackageOrder
            // 
            this.colPackageOrder.Caption = "Paket Siparişi Mi";
            this.colPackageOrder.FieldName = "PackageOrder";
            this.colPackageOrder.Name = "colPackageOrder";
            this.colPackageOrder.OptionsColumn.AllowEdit = false;
            this.colPackageOrder.Visible = true;
            this.colPackageOrder.VisibleIndex = 9;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 500);
            this.Controls.Add(this.gridControlSales);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnPaymentTransactions;
        private DevExpress.XtraEditors.SimpleButton btnOrderDetail;
        private DevExpress.XtraGrid.GridControl gridControlSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSales;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountedTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainder;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEndProcessDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageOrder;
    }
}