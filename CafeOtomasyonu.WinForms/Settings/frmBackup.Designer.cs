namespace CafeOtomasyonu.WinForms.Settings
{
    partial class frmBackup
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAnchor = new DevExpress.XtraEditors.TextEdit();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblPercent = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnchor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(447, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Veritabanı Dosya Yedekle";
            this.labelControl1.UseWaitCursor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 25);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Sunucu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 25);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Veritabanı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 25);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Yol:";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Location = new System.Drawing.Point(142, 79);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabase.Properties.Appearance.Options.UseFont = true;
            this.cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDatabase.Size = new System.Drawing.Size(231, 20);
            this.cbDatabase.TabIndex = 10;
            // 
            // txtAnchor
            // 
            this.txtAnchor.Location = new System.Drawing.Point(142, 48);
            this.txtAnchor.Name = "txtAnchor";
            this.txtAnchor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnchor.Properties.Appearance.Options.UseFont = true;
            this.txtAnchor.Size = new System.Drawing.Size(231, 20);
            this.txtAnchor.TabIndex = 11;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(142, 110);
            this.txtPath.Name = "txtPath";
            this.txtPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Properties.Appearance.Options.UseFont = true;
            this.txtPath.Size = new System.Drawing.Size(195, 20);
            this.txtPath.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(343, 110);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(30, 20);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "...";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(298, 136);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 13;
            this.btnBackup.Text = "Yedek Al";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(142, 136);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(150, 25);
            this.progressBarControl1.TabIndex = 14;
            // 
            // lblPercent
            // 
            this.lblPercent.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblPercent.Appearance.Options.UseBorderColor = true;
            this.lblPercent.Appearance.Options.UseTextOptions = true;
            this.lblPercent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblPercent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPercent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblPercent.Location = new System.Drawing.Point(240, 167);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(52, 17);
            this.lblPercent.TabIndex = 9;
            this.lblPercent.Text = "0 %";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(142, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 20);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Durumu:";
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblStatus.Appearance.Options.UseBorderColor = true;
            this.lblStatus.Appearance.Options.UseTextOptions = true;
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblStatus.Location = new System.Drawing.Point(198, 201);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Durumu:";
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 250);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtAnchor);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnchor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraEditors.TextEdit txtAnchor;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblPercent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
    }
}