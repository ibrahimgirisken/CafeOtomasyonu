namespace CafeOtomasyonu.WinForms.Tables
{
    partial class frmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTables));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnRezervReplace = new DevExpress.XtraEditors.SimpleButton();
            this.btnStatusReplace = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnTableMovements = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlTables = new DevExpress.XtraGrid.GridControl();
            this.gridViewTables = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezerv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSavedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableMovements = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(1189, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Masalar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnRezervReplace);
            this.groupControl1.Controls.Add(this.btnStatusReplace);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnTableMovements);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 442);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1189, 74);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1100, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRezervReplace
            // 
            this.btnRezervReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezervReplace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervReplace.ImageOptions.Image")));
            this.btnRezervReplace.Location = new System.Drawing.Point(938, 31);
            this.btnRezervReplace.Name = "btnRezervReplace";
            this.btnRezervReplace.Size = new System.Drawing.Size(75, 38);
            this.btnRezervReplace.TabIndex = 3;
            this.btnRezervReplace.Text = "Rezerv\r\nDeğiştir";
            this.btnRezervReplace.Click += new System.EventHandler(this.btnRezervReplace_Click);
            // 
            // btnStatusReplace
            // 
            this.btnStatusReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatusReplace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusReplace.ImageOptions.Image")));
            this.btnStatusReplace.Location = new System.Drawing.Point(857, 31);
            this.btnStatusReplace.Name = "btnStatusReplace";
            this.btnStatusReplace.Size = new System.Drawing.Size(75, 38);
            this.btnStatusReplace.TabIndex = 3;
            this.btnStatusReplace.Text = "Durum\r\nDeğiştir";
            this.btnStatusReplace.Click += new System.EventHandler(this.btnStatusReplace_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1019, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTableMovements
            // 
            this.btnTableMovements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableMovements.ImageOptions.Image")));
            this.btnTableMovements.Location = new System.Drawing.Point(248, 31);
            this.btnTableMovements.Name = "btnTableMovements";
            this.btnTableMovements.Size = new System.Drawing.Size(123, 38);
            this.btnTableMovements.TabIndex = 2;
            this.btnTableMovements.Text = "Masa Hareketleri";
            this.btnTableMovements.Click += new System.EventHandler(this.btnTableMovements_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(167, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(86, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(5, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Yeni";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gridControlTables
            // 
            this.gridControlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTables.Location = new System.Drawing.Point(0, 22);
            this.gridControlTables.MainView = this.gridViewTables;
            this.gridControlTables.Name = "gridControlTables";
            this.gridControlTables.Size = new System.Drawing.Size(1189, 420);
            this.gridControlTables.TabIndex = 4;
            this.gridControlTables.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTables});
            // 
            // gridViewTables
            // 
            this.gridViewTables.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTableName,
            this.colDescription,
            this.colStatus,
            this.colRezerv,
            this.colSavedDate,
            this.colUpdateDate,
            this.colProcess,
            this.colUserId,
            this.colTableMovements});
            this.gridViewTables.CustomizationFormBounds = new System.Drawing.Rectangle(973, 383, 264, 272);
            this.gridViewTables.GridControl = this.gridControlTables;
            this.gridViewTables.Name = "gridViewTables";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 53;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "Masa";
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 1;
            this.colTableName.Width = 113;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 245;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Durum";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 77;
            // 
            // colRezerv
            // 
            this.colRezerv.Caption = "Rezerve";
            this.colRezerv.FieldName = "Rezerv";
            this.colRezerv.Name = "colRezerv";
            this.colRezerv.Visible = true;
            this.colRezerv.VisibleIndex = 4;
            this.colRezerv.Width = 71;
            // 
            // colSavedDate
            // 
            this.colSavedDate.Caption = "Kayıt Tarihi";
            this.colSavedDate.FieldName = "SavedDate";
            this.colSavedDate.Name = "colSavedDate";
            this.colSavedDate.Visible = true;
            this.colSavedDate.VisibleIndex = 5;
            this.colSavedDate.Width = 97;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Son Güncellenme Tarihi";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.Visible = true;
            this.colUpdateDate.VisibleIndex = 6;
            this.colUpdateDate.Width = 133;
            // 
            // colProcess
            // 
            this.colProcess.Caption = "İşlem";
            this.colProcess.FieldName = "Process";
            this.colProcess.Name = "colProcess";
            this.colProcess.Visible = true;
            this.colProcess.VisibleIndex = 8;
            this.colProcess.Width = 191;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "Kullanıcı";
            this.colUserId.FieldName = "UserName";
            this.colUserId.Name = "colUserId";
            this.colUserId.Visible = true;
            this.colUserId.VisibleIndex = 7;
            this.colUserId.Width = 184;
            // 
            // colTableMovements
            // 
            this.colTableMovements.FieldName = "TableMovements";
            this.colTableMovements.Name = "colTableMovements";
            this.colTableMovements.Width = 104;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 516);
            this.Controls.Add(this.gridControlTables);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.GridControl gridControlTables;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTables;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRezerv;
        private DevExpress.XtraGrid.Columns.GridColumn colSavedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colTableMovements;
        private DevExpress.XtraEditors.SimpleButton btnRezervReplace;
        private DevExpress.XtraEditors.SimpleButton btnStatusReplace;
        private DevExpress.XtraEditors.SimpleButton btnTableMovements;
    }
}