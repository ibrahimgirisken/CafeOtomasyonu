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
    public partial class frmProductSelect : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private ProductDal _productDal = new ProductDal();
        public Product _product;
        public bool _selected;
        public frmProductSelect()
        {
            InitializeComponent();
            gridControlProductSelected.DataSource = _productDal.GetAll(_context);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridViewProductSelected.SelectedRowsCount>0)
            {
                int productId = Convert.ToInt32(gridViewProductSelected.GetFocusedRowCellValue((colId)));
                _product = _productDal.GetByFilter(_context, p => p.Id == productId);
                _selected = true;
                this.Close(); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}