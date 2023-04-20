namespace CafeOtomasyonu.WinForms.Users
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserRoles = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReminderQuestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReply = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSavedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserMovements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTables = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(950, 22);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kullanıcılar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnUserSave);
            this.groupControl1.Controls.Add(this.btnUserRoles);
            this.groupControl1.Controls.Add(this.btnUserUpdate);
            this.groupControl1.Controls.Add(this.btnUserAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 440);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(950, 70);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(863, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSave.ImageOptions.Image")));
            this.btnUserSave.Location = new System.Drawing.Point(281, 26);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(86, 38);
            this.btnUserSave.TabIndex = 0;
            this.btnUserSave.Text = "Kaydet";
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserRoles
            // 
            this.btnUserRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRoles.ImageOptions.Image")));
            this.btnUserRoles.Location = new System.Drawing.Point(189, 27);
            this.btnUserRoles.Name = "btnUserRoles";
            this.btnUserRoles.Size = new System.Drawing.Size(86, 38);
            this.btnUserRoles.TabIndex = 0;
            this.btnUserRoles.Text = "Roller";
            this.btnUserRoles.Click += new System.EventHandler(this.btnUserRoles_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserUpdate.ImageOptions.Image")));
            this.btnUserUpdate.Location = new System.Drawing.Point(97, 26);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(86, 38);
            this.btnUserUpdate.TabIndex = 0;
            this.btnUserUpdate.Text = "Güncelle";
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAdd.ImageOptions.Image")));
            this.btnUserAdd.Location = new System.Drawing.Point(5, 26);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(86, 38);
            this.btnUserAdd.TabIndex = 0;
            this.btnUserAdd.Text = "Yeni\r\nKullanıcı";
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsers.Location = new System.Drawing.Point(0, 22);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(950, 418);
            this.gridControlUsers.TabIndex = 14;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullName,
            this.colTelephone,
            this.colAddress,
            this.colEmail,
            this.colMission,
            this.colUserName,
            this.colPassword,
            this.colReminderQuestion,
            this.colReply,
            this.colDescription,
            this.colSavedDate,
            this.colStatus,
            this.colAdmin,
            this.colUserMovements,
            this.colTables});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 28;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Adı Soyadı";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 2;
            this.colFullName.Width = 113;
            // 
            // colTelephone
            // 
            this.colTelephone.Caption = "Telefon";
            this.colTelephone.FieldName = "Telephone";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.OptionsColumn.AllowEdit = false;
            this.colTelephone.Visible = true;
            this.colTelephone.VisibleIndex = 3;
            this.colTelephone.Width = 105;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adres";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 153;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail Adresi";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 132;
            // 
            // colMission
            // 
            this.colMission.Caption = "Görevi";
            this.colMission.FieldName = "Mission";
            this.colMission.Name = "colMission";
            this.colMission.OptionsColumn.AllowEdit = false;
            this.colMission.Visible = true;
            this.colMission.VisibleIndex = 6;
            this.colMission.Width = 83;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Kullanıcı Adı";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            // 
            // colReminderQuestion
            // 
            this.colReminderQuestion.FieldName = "ReminderQuestion";
            this.colReminderQuestion.Name = "colReminderQuestion";
            this.colReminderQuestion.OptionsColumn.AllowEdit = false;
            // 
            // colReply
            // 
            this.colReply.FieldName = "Reply";
            this.colReply.Name = "colReply";
            this.colReply.OptionsColumn.AllowEdit = false;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            // 
            // colSavedDate
            // 
            this.colSavedDate.Caption = "Kayıt Tarihi";
            this.colSavedDate.FieldName = "SavedDate";
            this.colSavedDate.Name = "colSavedDate";
            this.colSavedDate.OptionsColumn.AllowEdit = false;
            this.colSavedDate.Visible = true;
            this.colSavedDate.VisibleIndex = 7;
            this.colSavedDate.Width = 90;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Durumu";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 8;
            this.colStatus.Width = 47;
            // 
            // colAdmin
            // 
            this.colAdmin.Caption = "Admin Mi";
            this.colAdmin.FieldName = "Admin";
            this.colAdmin.Name = "colAdmin";
            this.colAdmin.Visible = true;
            this.colAdmin.VisibleIndex = 9;
            this.colAdmin.Width = 80;
            // 
            // colUserMovements
            // 
            this.colUserMovements.FieldName = "UserMovements";
            this.colUserMovements.Name = "colUserMovements";
            // 
            // colTables
            // 
            this.colTables.FieldName = "Tables";
            this.colTables.Name = "colTables";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 510);
            this.Controls.Add(this.gridControlUsers);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnUserAdd;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colTelephone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMission;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colReminderQuestion;
        private DevExpress.XtraGrid.Columns.GridColumn colReply;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSavedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colUserMovements;
        private DevExpress.XtraGrid.Columns.GridColumn colTables;
        private DevExpress.XtraEditors.SimpleButton btnUserSave;
        private DevExpress.XtraEditors.SimpleButton btnUserRoles;
        private DevExpress.XtraEditors.SimpleButton btnUserUpdate;
    }
}