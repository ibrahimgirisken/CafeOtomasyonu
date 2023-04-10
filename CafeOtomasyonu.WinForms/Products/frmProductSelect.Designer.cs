namespace CafeOtomasyonu.WinForms.Products
{
    partial class frmProductSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSelect));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlProductSelected = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductSelected = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSelected)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(981, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ürün Seçim Sayfası";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSelect);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 394);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(981, 75);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.Image")));
            this.btnSelect.Location = new System.Drawing.Point(779, 31);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 38);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Seç";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(880, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControlProductSelected
            // 
            this.gridControlProductSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductSelected.Location = new System.Drawing.Point(0, 22);
            this.gridControlProductSelected.MainView = this.gridViewProductSelected;
            this.gridControlProductSelected.Name = "gridControlProductSelected";
            this.gridControlProductSelected.Size = new System.Drawing.Size(981, 372);
            this.gridControlProductSelected.TabIndex = 3;
            this.gridControlProductSelected.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductSelected});
            // 
            // gridViewProductSelected
            // 
            this.gridViewProductSelected.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colProductNumber,
            this.colProductName,
            this.colUnitPrice1,
            this.colUnitPrice2,
            this.colUnitPrice3,
            this.colDescription,
            this.colImage,
            this.colDate,
            this.colMenu});
            this.gridViewProductSelected.GridControl = this.gridControlProductSelected;
            this.gridViewProductSelected.Name = "gridViewProductSelected";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 29;
            // 
            // colMenuId
            // 
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            // 
            // colProductNumber
            // 
            this.colProductNumber.Caption = "Ürün Numarası";
            this.colProductNumber.FieldName = "ProductNumber";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.Visible = true;
            this.colProductNumber.VisibleIndex = 2;
            this.colProductNumber.Width = 66;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Ürün Adı";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 3;
            this.colProductName.Width = 104;
            // 
            // colUnitPrice1
            // 
            this.colUnitPrice1.Caption = "Birim Fiyatı1";
            this.colUnitPrice1.FieldName = "UnitPrice1";
            this.colUnitPrice1.Name = "colUnitPrice1";
            this.colUnitPrice1.Visible = true;
            this.colUnitPrice1.VisibleIndex = 4;
            this.colUnitPrice1.Width = 66;
            // 
            // colUnitPrice2
            // 
            this.colUnitPrice2.Caption = "Birim Fiyatı2";
            this.colUnitPrice2.FieldName = "UnitPrice2";
            this.colUnitPrice2.Name = "colUnitPrice2";
            this.colUnitPrice2.Visible = true;
            this.colUnitPrice2.VisibleIndex = 5;
            this.colUnitPrice2.Width = 70;
            // 
            // colUnitPrice3
            // 
            this.colUnitPrice3.Caption = "Birim Fiyatı3";
            this.colUnitPrice3.FieldName = "UnitPrice3";
            this.colUnitPrice3.Name = "colUnitPrice3";
            this.colUnitPrice3.Visible = true;
            this.colUnitPrice3.VisibleIndex = 6;
            this.colUnitPrice3.Width = 69;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 151;
            // 
            // colImage
            // 
            this.colImage.Caption = "Resim";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 8;
            this.colImage.Width = 55;
            // 
            // colDate
            // 
            this.colDate.Caption = "Tarih";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 9;
            this.colDate.Width = 83;
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menu Adı";
            this.colMenu.FieldName = "Menu.MenuName";
            this.colMenu.Name = "colMenu";
            this.colMenu.Visible = true;
            this.colMenu.VisibleIndex = 0;
            // 
            // frmProductSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 469);
            this.Controls.Add(this.gridControlProductSelected);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmProductSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Seçim Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gridControlProductSelected;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice2;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
    }
}