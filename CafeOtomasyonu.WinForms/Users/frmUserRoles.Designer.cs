namespace CafeOtomasyonu.WinForms.Users
{
    partial class frmUserRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRoles));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserSave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlUserRoles = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserRoles)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(769, 22);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Kullanıcı Rolleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnUserSave);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 271);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(769, 70);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(682, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSave.ImageOptions.Image")));
            this.btnUserSave.Location = new System.Drawing.Point(12, 27);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(86, 38);
            this.btnUserSave.TabIndex = 0;
            this.btnUserSave.Text = "Kaydet";
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // gridControlUserRoles
            // 
            this.gridControlUserRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUserRoles.Location = new System.Drawing.Point(0, 22);
            this.gridControlUserRoles.MainView = this.gridViewUserRoles;
            this.gridControlUserRoles.Name = "gridControlUserRoles";
            this.gridControlUserRoles.Size = new System.Drawing.Size(769, 249);
            this.gridControlUserRoles.TabIndex = 15;
            this.gridControlUserRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserRoles});
            // 
            // gridViewUserRoles
            // 
            this.gridViewUserRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserId,
            this.colFormName,
            this.colControlName,
            this.colControlCaption,
            this.colVisible});
            this.gridViewUserRoles.GridControl = this.gridControlUserRoles;
            this.gridViewUserRoles.Name = "gridViewUserRoles";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colUserId
            // 
            this.colUserId.Caption = "Kullanıcı Id";
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.AllowEdit = false;
            // 
            // colFormName
            // 
            this.colFormName.FieldName = "FormName";
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsColumn.AllowEdit = false;
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            // 
            // colControlName
            // 
            this.colControlName.FieldName = "ControlName";
            this.colControlName.Name = "colControlName";
            this.colControlName.OptionsColumn.AllowEdit = false;
            this.colControlName.Visible = true;
            this.colControlName.VisibleIndex = 2;
            // 
            // colControlCaption
            // 
            this.colControlCaption.FieldName = "ControlCaption";
            this.colControlCaption.Name = "colControlCaption";
            this.colControlCaption.OptionsColumn.AllowEdit = false;
            this.colControlCaption.Visible = true;
            this.colControlCaption.VisibleIndex = 3;
            // 
            // colVisible
            // 
            this.colVisible.Caption = "Yetkili mi?";
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            this.colVisible.Visible = true;
            this.colVisible.VisibleIndex = 4;
            // 
            // frmUserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 341);
            this.Controls.Add(this.gridControlUserRoles);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmUserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserRoles";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnUserSave;
        private DevExpress.XtraGrid.GridControl gridControlUserRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserRoles;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
    }
}