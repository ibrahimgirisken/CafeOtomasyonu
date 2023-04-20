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
using CafeOtomasyonu.WinForms.Tables;

namespace CafeOtomasyonu.WinForms.Products
{
    public partial class frmProducts : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private ProductDal _productDal = new ProductDal();
        public frmProducts()
        {
            InitializeComponent();
            productList();
        }

        private void productList()
        {
            gridControlProducts.DataSource = _productDal.ProductList(_context);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd(new Product());
            frm.ShowDialog();
            if (frm._saveStatus)
            {
            productList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue(colId));
            frmProductAdd frm = new frmProductAdd(_productDal.GetByFilter(_context,p=>p.Id==selectId));
            frm.ShowDialog();
            if (frm._saveStatus)
            {
                productList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            productList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                _productDal.Delete(_context,p=>p.Id==selectId);
                _productDal.Save(_context);
                productList();
            }
        }

        private void btnTableMovements_Click(object sender, EventArgs e)
        {
            int _productId = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue(colId));

            frmTableMovements frm_TableMovements = new frmTableMovements(productId: _productId);
            frm_TableMovements.ShowDialog();
        }
    }
}