namespace CafeOtomasyonu.WinForms.Payments
{
    partial class frmPaymentTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentTransactions));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPaymentTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridViewPaymentTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaymentTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentTransactions)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(1170, 22);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Ödeme Hareketleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 412);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1170, 77);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1081, 31);
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
            this.btnRefresh.Size = new System.Drawing.Size(96, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile\r\nListele";
            // 
            // gridControlPaymentTransactions
            // 
            this.gridControlPaymentTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPaymentTransactions.Location = new System.Drawing.Point(0, 22);
            this.gridControlPaymentTransactions.MainView = this.gridViewPaymentTransactions;
            this.gridControlPaymentTransactions.Name = "gridControlPaymentTransactions";
            this.gridControlPaymentTransactions.Size = new System.Drawing.Size(1170, 390);
            this.gridControlPaymentTransactions.TabIndex = 9;
            this.gridControlPaymentTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPaymentTransactions});
            // 
            // gridViewPaymentTransactions
            // 
            this.gridViewPaymentTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSalesCode,
            this.colSalesType,
            this.colPaid,
            this.colDescription,
            this.colDate});
            this.gridViewPaymentTransactions.GridControl = this.gridControlPaymentTransactions;
            this.gridViewPaymentTransactions.Name = "gridViewPaymentTransactions";
            this.gridViewPaymentTransactions.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 40;
            // 
            // colSalesCode
            // 
            this.colSalesCode.Caption = "Satış Kodu";
            this.colSalesCode.FieldName = "SalesCode";
            this.colSalesCode.Name = "colSalesCode";
            this.colSalesCode.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SalesCode", "Kayıt Sayısı={0:0.##}")});
            this.colSalesCode.Visible = true;
            this.colSalesCode.VisibleIndex = 1;
            this.colSalesCode.Width = 76;
            // 
            // colSalesType
            // 
            this.colSalesType.Caption = "Satış Tipi";
            this.colSalesType.FieldName = "SalesType";
            this.colSalesType.Name = "colSalesType";
            this.colSalesType.Visible = true;
            this.colSalesType.VisibleIndex = 2;
            this.colSalesType.Width = 88;
            // 
            // colPaid
            // 
            this.colPaid.Caption = "Ödenen";
            this.colPaid.DisplayFormat.FormatString = "C2";
            this.colPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Paid", "{0:C2}")});
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 3;
            this.colPaid.Width = 88;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 304;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            this.colDate.Width = 137;
            // 
            // frmPaymentTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 489);
            this.Controls.Add(this.gridControlPaymentTransactions);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmPaymentTransactions";
            this.Text = "Ödeme Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaymentTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaymentTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControlPaymentTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPaymentTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesType;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}