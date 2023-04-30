namespace CafeOtomasyonu.WinForms.Tables
{
    partial class frmTableMovements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableMovements));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTableMovements = new DevExpress.XtraGrid.GridControl();
            this.gridViewTableMovements = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTables = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTableMovements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTableMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(779, 22);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Masa Hareketleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 412);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(779, 74);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(690, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(12, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControlTableMovements
            // 
            this.gridControlTableMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTableMovements.Location = new System.Drawing.Point(0, 22);
            this.gridControlTableMovements.MainView = this.gridViewTableMovements;
            this.gridControlTableMovements.Name = "gridControlTableMovements";
            this.gridControlTableMovements.Size = new System.Drawing.Size(779, 390);
            this.gridControlTableMovements.TabIndex = 6;
            this.gridControlTableMovements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTableMovements});
            // 
            // gridViewTableMovements
            // 
            this.gridViewTableMovements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTableName,
            this.colMenuName,
            this.colProductName,
            this.colSalesCode,
            this.colTableId,
            this.colProductId,
            this.colQuantity,
            this.colUnitPrice,
            this.colDiscountTotal,
            this.colDescription,
            this.colDate,
            this.colTables,
            this.colProduct});
            this.gridViewTableMovements.GridControl = this.gridControlTableMovements;
            this.gridViewTableMovements.Name = "gridViewTableMovements";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "Masa Adı";
            this.colTableName.FieldName = "Tables.TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 2;
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "Menu Adı";
            this.colMenuName.FieldName = "Product.Menu.MenuName";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 1;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "Product.ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            // 
            // colSalesCode
            // 
            this.colSalesCode.Caption = "Satış Kodu";
            this.colSalesCode.FieldName = "SalesCode";
            this.colSalesCode.Name = "colSalesCode";
            this.colSalesCode.Visible = true;
            this.colSalesCode.VisibleIndex = 4;
            // 
            // colTableId
            // 
            this.colTableId.FieldName = "TableId";
            this.colTableId.Name = "colTableId";
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Miktar";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "SUM={0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Birim Fiyatı";
            this.colUnitPrice.DisplayFormat.FormatString = "C2";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // colDiscountTotal
            // 
            this.colDiscountTotal.Caption = "İndirim Tutarı";
            this.colDiscountTotal.DisplayFormat.FormatString = "C2";
            this.colDiscountTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountTotal.FieldName = "DiscountTotal";
            this.colDiscountTotal.Name = "colDiscountTotal";
            this.colDiscountTotal.Visible = true;
            this.colDiscountTotal.VisibleIndex = 7;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 9;
            // 
            // colTables
            // 
            this.colTables.FieldName = "Tables";
            this.colTables.Name = "colTables";
            // 
            // colProduct
            // 
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            // 
            // frmTableMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 486);
            this.Controls.Add(this.gridControlTableMovements);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTableMovements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTableMovements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTableMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControlTableMovements;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTableMovements;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTableId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTables;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
    }
}