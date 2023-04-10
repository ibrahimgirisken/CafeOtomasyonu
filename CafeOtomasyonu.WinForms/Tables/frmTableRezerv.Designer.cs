namespace CafeOtomasyonu.WinForms.Tables
{
    partial class frmTableRezerv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableRezerv));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.txtProcess = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(422, 22);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Masa Rezerv";
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl25.Appearance.Options.UseBorderColor = true;
            this.labelControl25.Appearance.Options.UseTextOptions = true;
            this.labelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl25.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl25.Location = new System.Drawing.Point(12, 47);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(124, 20);
            this.labelControl25.TabIndex = 23;
            this.labelControl25.Text = "Tarih:";
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(143, 76);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(264, 105);
            this.txtProcess.TabIndex = 28;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl23.Appearance.Options.UseBorderColor = true;
            this.labelControl23.Appearance.Options.UseTextOptions = true;
            this.labelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl23.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl23.Location = new System.Drawing.Point(13, 75);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(124, 106);
            this.labelControl23.TabIndex = 27;
            this.labelControl23.Text = "İşlem:";
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = null;
            this.dateEditDate.Location = new System.Drawing.Point(143, 48);
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Size = new System.Drawing.Size(264, 22);
            this.dateEditDate.TabIndex = 29;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnApprove);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 188);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(422, 75);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(319, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.ImageOptions.Image")));
            this.btnApprove.Location = new System.Drawing.Point(5, 31);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(95, 38);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Onayla";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // frmTableRezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 263);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dateEditDate);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.labelControl25);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTableRezerv";
            this.Text = "frmTableRezerv";
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.MemoEdit txtProcess;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.DateEdit dateEditDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
    }
}