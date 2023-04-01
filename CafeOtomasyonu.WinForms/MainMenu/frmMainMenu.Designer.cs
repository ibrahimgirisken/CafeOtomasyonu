namespace CafeOtomasyonu.WinForms.MainMenu
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTables = new DevExpress.XtraBars.BarButtonItem();
            this.btnTableMovements = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenus = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuMovements = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductMovements = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserMovements = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoles = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoviz = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnTables,
            this.btnTableMovements,
            this.btnMenus,
            this.btnMenuMovements,
            this.btnProducts,
            this.btnProductMovements,
            this.btnUsers,
            this.btnUserMovements,
            this.btnRoles,
            this.btnDoviz,
            this.btnHelp,
            this.btnAbout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(871, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTables
            // 
            this.btnTables.Caption = "Masalar";
            this.btnTables.Id = 2;
            this.btnTables.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTables.ImageOptions.Image")));
            this.btnTables.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTables.ImageOptions.LargeImage")));
            this.btnTables.Name = "btnTables";
            // 
            // btnTableMovements
            // 
            this.btnTableMovements.Caption = "Masa Hareketleri";
            this.btnTableMovements.Id = 3;
            this.btnTableMovements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTableMovements.ImageOptions.Image")));
            this.btnTableMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTableMovements.ImageOptions.LargeImage")));
            this.btnTableMovements.Name = "btnTableMovements";
            // 
            // btnMenus
            // 
            this.btnMenus.Caption = "Menuler";
            this.btnMenus.Id = 4;
            this.btnMenus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMenus.ImageOptions.Image")));
            this.btnMenus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMenus.ImageOptions.LargeImage")));
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenus_ItemClick);
            // 
            // btnMenuMovements
            // 
            this.btnMenuMovements.Caption = "Menu Hareketleri";
            this.btnMenuMovements.Id = 5;
            this.btnMenuMovements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMovements.ImageOptions.Image")));
            this.btnMenuMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMenuMovements.ImageOptions.LargeImage")));
            this.btnMenuMovements.Name = "btnMenuMovements";
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Ürünler";
            this.btnProducts.Id = 6;
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.LargeImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducts_ItemClick);
            // 
            // btnProductMovements
            // 
            this.btnProductMovements.Caption = "Ürün Hareketleri";
            this.btnProductMovements.Id = 7;
            this.btnProductMovements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductMovements.ImageOptions.Image")));
            this.btnProductMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductMovements.ImageOptions.LargeImage")));
            this.btnProductMovements.Name = "btnProductMovements";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Kullanıcılar";
            this.btnUsers.Id = 8;
            this.btnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.Image")));
            this.btnUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.LargeImage")));
            this.btnUsers.Name = "btnUsers";
            // 
            // btnUserMovements
            // 
            this.btnUserMovements.Caption = "barButtonItem2";
            this.btnUserMovements.Id = 9;
            this.btnUserMovements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserMovements.ImageOptions.Image")));
            this.btnUserMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUserMovements.ImageOptions.LargeImage")));
            this.btnUserMovements.Name = "btnUserMovements";
            // 
            // btnRoles
            // 
            this.btnRoles.Caption = "Role Tanımlama";
            this.btnRoles.Id = 10;
            this.btnRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.Image")));
            this.btnRoles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.LargeImage")));
            this.btnRoles.Name = "btnRoles";
            // 
            // btnDoviz
            // 
            this.btnDoviz.Caption = "Döviz";
            this.btnDoviz.Id = 11;
            this.btnDoviz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoviz.ImageOptions.Image")));
            this.btnDoviz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoviz.ImageOptions.LargeImage")));
            this.btnDoviz.Name = "btnDoviz";
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Yardım";
            this.btnHelp.Id = 12;
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.LargeImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "Hakkımızda";
            this.btnAbout.Id = 13;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.LargeImage")));
            this.btnAbout.Name = "btnAbout";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTables);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTableMovements);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Masalar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenus);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuMovements);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Menuler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProducts);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductMovements);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ürünler";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUserMovements);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRoles);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kullanıcılar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoviz);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHelp);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(871, 24);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cafe Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnTables;
        private DevExpress.XtraBars.BarButtonItem btnTableMovements;
        private DevExpress.XtraBars.BarButtonItem btnMenus;
        private DevExpress.XtraBars.BarButtonItem btnMenuMovements;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnProductMovements;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnUserMovements;
        private DevExpress.XtraBars.BarButtonItem btnRoles;
        private DevExpress.XtraBars.BarButtonItem btnDoviz;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}