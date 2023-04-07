namespace CafeOtomasyonu.WinForms.Tables
{
    partial class frmTablesStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablesStatus));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrderAdd = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRezervTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnNullTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnFullTable = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupProcess = new DevExpress.XtraEditors.GroupControl();
            this.calcDiscountedTotal = new DevExpress.XtraEditors.CalcEdit();
            this.calcDiscountRate = new DevExpress.XtraEditors.CalcEdit();
            this.calcTotal = new DevExpress.XtraEditors.CalcEdit();
            this.calcDiscountedSum = new DevExpress.XtraEditors.CalcEdit();
            this.calcRemainder = new DevExpress.XtraEditors.CalcEdit();
            this.calcPaid = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProcess)).BeginInit();
            this.groupProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountedTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountedSum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcRemainder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcPaid.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(994, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnOrderSave);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnOrderAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 401);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 74);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(905, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderSave.ImageOptions.Image")));
            this.btnOrderSave.Location = new System.Drawing.Point(824, 31);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(75, 38);
            this.btnOrderSave.TabIndex = 3;
            this.btnOrderSave.Text = "Kaydet";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(116, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAdd.ImageOptions.Image")));
            this.btnOrderAdd.Location = new System.Drawing.Point(5, 31);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(95, 38);
            this.btnOrderAdd.TabIndex = 0;
            this.btnOrderAdd.Text = "Sipariş Ekle";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 22);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupProcess);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(994, 379);
            this.splitContainerControl1.SplitterPosition = 141;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRezervTable);
            this.panelControl1.Controls.Add(this.btnNullTable);
            this.panelControl1.Controls.Add(this.btnFullTable);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 106);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 35);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRezervTable
            // 
            this.btnRezervTable.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnRezervTable.Appearance.Options.UseBackColor = true;
            this.btnRezervTable.Location = new System.Drawing.Point(222, 5);
            this.btnRezervTable.Name = "btnRezervTable";
            this.btnRezervTable.Size = new System.Drawing.Size(100, 35);
            this.btnRezervTable.TabIndex = 2;
            this.btnRezervTable.Text = "Rezerv Masa";
            // 
            // btnNullTable
            // 
            this.btnNullTable.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnNullTable.Appearance.Options.UseBackColor = true;
            this.btnNullTable.Location = new System.Drawing.Point(111, 5);
            this.btnNullTable.Name = "btnNullTable";
            this.btnNullTable.Size = new System.Drawing.Size(100, 35);
            this.btnNullTable.TabIndex = 2;
            this.btnNullTable.Text = "Dolu Masa";
            // 
            // btnFullTable
            // 
            this.btnFullTable.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnFullTable.Appearance.Options.UseBackColor = true;
            this.btnFullTable.Location = new System.Drawing.Point(0, 5);
            this.btnFullTable.Name = "btnFullTable";
            this.btnFullTable.Size = new System.Drawing.Size(100, 35);
            this.btnFullTable.TabIndex = 2;
            this.btnFullTable.Text = "Dolu Masa";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(994, 132);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupProcess
            // 
            this.groupProcess.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupProcess.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupProcess.AppearanceCaption.Options.UseFont = true;
            this.groupProcess.AppearanceCaption.Options.UseForeColor = true;
            this.groupProcess.Controls.Add(this.calcDiscountedTotal);
            this.groupProcess.Controls.Add(this.calcDiscountRate);
            this.groupProcess.Controls.Add(this.calcTotal);
            this.groupProcess.Controls.Add(this.calcDiscountedSum);
            this.groupProcess.Controls.Add(this.calcRemainder);
            this.groupProcess.Controls.Add(this.calcPaid);
            this.groupProcess.Controls.Add(this.labelControl7);
            this.groupProcess.Controls.Add(this.labelControl5);
            this.groupProcess.Controls.Add(this.labelControl6);
            this.groupProcess.Controls.Add(this.labelControl4);
            this.groupProcess.Controls.Add(this.labelControl3);
            this.groupProcess.Controls.Add(this.labelControl2);
            this.groupProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupProcess.Location = new System.Drawing.Point(0, 150);
            this.groupProcess.Name = "groupProcess";
            this.groupProcess.Size = new System.Drawing.Size(994, 78);
            this.groupProcess.TabIndex = 0;
            this.groupProcess.Text = "Hesaplamalar";
            // 
            // calcDiscountedTotal
            // 
            this.calcDiscountedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcDiscountedTotal.Location = new System.Drawing.Point(853, 53);
            this.calcDiscountedTotal.Name = "calcDiscountedTotal";
            this.calcDiscountedTotal.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcDiscountedTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDiscountedTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcDiscountedTotal.Properties.Appearance.Options.UseBackColor = true;
            this.calcDiscountedTotal.Properties.Appearance.Options.UseFont = true;
            this.calcDiscountedTotal.Properties.Appearance.Options.UseForeColor = true;
            this.calcDiscountedTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.calcDiscountedTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcDiscountedTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcDiscountedTotal.Properties.MaskSettings.Set("mask", "c");
            this.calcDiscountedTotal.Properties.NullText = "₺0,00";
            this.calcDiscountedTotal.Properties.UseMaskAsDisplayFormat = true;
            this.calcDiscountedTotal.Size = new System.Drawing.Size(137, 22);
            this.calcDiscountedTotal.TabIndex = 5;
            // 
            // calcDiscountRate
            // 
            this.calcDiscountRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcDiscountRate.Location = new System.Drawing.Point(490, 50);
            this.calcDiscountRate.Name = "calcDiscountRate";
            this.calcDiscountRate.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcDiscountRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDiscountRate.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcDiscountRate.Properties.Appearance.Options.UseBackColor = true;
            this.calcDiscountRate.Properties.Appearance.Options.UseFont = true;
            this.calcDiscountRate.Properties.Appearance.Options.UseForeColor = true;
            this.calcDiscountRate.Properties.Appearance.Options.UseTextOptions = true;
            this.calcDiscountRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcDiscountRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcDiscountRate.Properties.MaskSettings.Set("mask", "P");
            this.calcDiscountRate.Properties.NullText = "%0,00";
            this.calcDiscountRate.Properties.UseMaskAsDisplayFormat = true;
            this.calcDiscountRate.Size = new System.Drawing.Size(137, 22);
            this.calcDiscountRate.TabIndex = 3;
            // 
            // calcTotal
            // 
            this.calcTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcTotal.Location = new System.Drawing.Point(853, 26);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcTotal.Properties.Appearance.Options.UseBackColor = true;
            this.calcTotal.Properties.Appearance.Options.UseFont = true;
            this.calcTotal.Properties.Appearance.Options.UseForeColor = true;
            this.calcTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.calcTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcTotal.Properties.MaskSettings.Set("mask", "c");
            this.calcTotal.Properties.NullText = "₺0,00";
            this.calcTotal.Properties.UseMaskAsDisplayFormat = true;
            this.calcTotal.Size = new System.Drawing.Size(137, 22);
            this.calcTotal.TabIndex = 4;
            // 
            // calcDiscountedSum
            // 
            this.calcDiscountedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcDiscountedSum.Location = new System.Drawing.Point(490, 25);
            this.calcDiscountedSum.Name = "calcDiscountedSum";
            this.calcDiscountedSum.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcDiscountedSum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDiscountedSum.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcDiscountedSum.Properties.Appearance.Options.UseBackColor = true;
            this.calcDiscountedSum.Properties.Appearance.Options.UseFont = true;
            this.calcDiscountedSum.Properties.Appearance.Options.UseForeColor = true;
            this.calcDiscountedSum.Properties.Appearance.Options.UseTextOptions = true;
            this.calcDiscountedSum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcDiscountedSum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcDiscountedSum.Properties.MaskSettings.Set("mask", "c");
            this.calcDiscountedSum.Properties.NullText = "₺0,00";
            this.calcDiscountedSum.Properties.UseMaskAsDisplayFormat = true;
            this.calcDiscountedSum.Size = new System.Drawing.Size(137, 22);
            this.calcDiscountedSum.TabIndex = 2;
            // 
            // calcRemainder
            // 
            this.calcRemainder.Location = new System.Drawing.Point(137, 51);
            this.calcRemainder.Name = "calcRemainder";
            this.calcRemainder.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcRemainder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcRemainder.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcRemainder.Properties.Appearance.Options.UseBackColor = true;
            this.calcRemainder.Properties.Appearance.Options.UseFont = true;
            this.calcRemainder.Properties.Appearance.Options.UseForeColor = true;
            this.calcRemainder.Properties.Appearance.Options.UseTextOptions = true;
            this.calcRemainder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcRemainder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcRemainder.Properties.MaskSettings.Set("mask", "c");
            this.calcRemainder.Properties.NullText = "₺0,00";
            this.calcRemainder.Properties.UseMaskAsDisplayFormat = true;
            this.calcRemainder.Size = new System.Drawing.Size(137, 22);
            this.calcRemainder.TabIndex = 1;
            // 
            // calcPaid
            // 
            this.calcPaid.Location = new System.Drawing.Point(137, 26);
            this.calcPaid.Name = "calcPaid";
            this.calcPaid.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcPaid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcPaid.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcPaid.Properties.Appearance.Options.UseBackColor = true;
            this.calcPaid.Properties.Appearance.Options.UseFont = true;
            this.calcPaid.Properties.Appearance.Options.UseForeColor = true;
            this.calcPaid.Properties.Appearance.Options.UseTextOptions = true;
            this.calcPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcPaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcPaid.Properties.MaskSettings.Set("mask", "c");
            this.calcPaid.Properties.NullText = "₺0,00";
            this.calcPaid.Properties.UseMaskAsDisplayFormat = true;
            this.calcPaid.Size = new System.Drawing.Size(137, 22);
            this.calcPaid.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(722, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(125, 22);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "İndirimli Toplam:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(359, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 22);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "İndirim Oranı(%):";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(722, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(125, 22);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Toplam:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(359, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 22);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İndirim Toplamı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(6, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(125, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Kalan:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(6, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ödenen:";
            // 
            // frmTablesStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 475);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmTablesStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Siparişleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProcess)).EndInit();
            this.groupProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountedTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcDiscountedSum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcRemainder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcPaid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnOrderSave;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnOrderAdd;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupProcess;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFullTable;
        private DevExpress.XtraEditors.SimpleButton btnNullTable;
        private DevExpress.XtraEditors.SimpleButton btnRezervTable;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcPaid;
        private DevExpress.XtraEditors.CalcEdit calcDiscountedTotal;
        private DevExpress.XtraEditors.CalcEdit calcDiscountRate;
        private DevExpress.XtraEditors.CalcEdit calcTotal;
        private DevExpress.XtraEditors.CalcEdit calcDiscountedSum;
        private DevExpress.XtraEditors.CalcEdit calcRemainder;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}