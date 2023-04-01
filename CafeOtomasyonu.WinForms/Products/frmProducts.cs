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

namespace CafeOtomasyonu.WinForms.Products
{
    public partial class frmProducts : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private ProductDal _productDal = new ProductDal();
        public frmProducts()
        {
            InitializeComponent();
            gridControl1.DataSource = _productDal.ProductList(_context);
        }
    }
}