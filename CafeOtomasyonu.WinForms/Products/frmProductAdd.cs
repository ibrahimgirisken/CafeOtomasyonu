using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using System.IO;

namespace CafeOtomasyonu.WinForms.Products
{
    public partial class frmProductAdd : DevExpress.XtraEditors.XtraForm
    {
        private MenuDal _menuDal = new MenuDal();
        private ProductDal _productDal = new ProductDal();
        private Product _entity;
        private CafeContext _context = new CafeContext();
        public bool _saveStatus = false;
        public frmProductAdd(Product entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenu.Properties.DataSource = _menuDal.GetAll(_context);
            lookUpMenu.DataBindings.Add("EditValue", _entity, "MenuId");
            txtProductName.DataBindings.Add("Text", _entity, "ProductName");
            txtProductNumber.DataBindings.Add("Text", _entity, "ProductNumber");
            calcUnitPrice1.DataBindings.Add("Text", _entity, "UnitPrice1", true);
            calcUnitPrice2.DataBindings.Add("Text", _entity, "UnitPrice2", true);
            calcUnitPrice3.DataBindings.Add("Text", _entity, "UnitPrice3", true);
            memoDescription.DataBindings.Add("Text", _entity, "Description");
            dateEdit1.DataBindings.Add("Text", _entity, "Date", true);
            if (_entity.Id != 0)
            {
                if (_entity.Image != null)
                {
                    pictureEdit1.Image = Image.FromFile(_entity.Image);
                }
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != "")
            {
                string hrefPath = $"{Application.StartupPath}\\Image\\{txtProductName.Text}-{txtProductNumber.Text}.jpg";
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hrefPath);
                _entity.Image = $"Image\\{txtProductName.Text}-{txtProductNumber.Text}.jpg";
            }
            if (_productDal.AddOrUpdate(_context, _entity))
            {
                _productDal.Save(_context);
                _saveStatus = true;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}