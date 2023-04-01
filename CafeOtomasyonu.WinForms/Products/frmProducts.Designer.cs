namespace CafeOtomasyonu.WinForms.Products
{
    partial class frmProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.brnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colMenuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(718, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.brnDelete);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 385);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(718, 74);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(629, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            // 
            // brnDelete
            // 
            this.brnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brnDelete.ImageOptions.Image")));
            this.brnDelete.Location = new System.Drawing.Point(548, 31);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.Size = new System.Drawing.Size(75, 38);
            this.brnDelete.TabIndex = 0;
            this.brnDelete.Text = "Sil";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(167, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 38);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(86, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Düzenle";
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(5, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(718, 363);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colMenu,
            this.colMenuName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
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
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // colMenuName
            // 
            this.colMenuName.Caption = "Menu";
            this.colMenuName.FieldName = "Menu";
            this.colMenuName.Name = "colMenuName";
            this.colMenuName.Visible = true;
            this.colMenuName.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "UnitPrice1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "UnitPrice1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CafeOtomasyonu.Entities.Models.Product);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 459);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton brnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuName;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}