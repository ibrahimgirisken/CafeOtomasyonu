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

namespace CafeOtomasyonu.WinForms.Tables
{
    public partial class frmTableMovements : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private TablesMovementsDal _tablesMovementsDal = new TablesMovementsDal();
        private int? _tableId;
        private int? _menuId;
        private int? _productId;
        public frmTableMovements(int? tableId=null,int? menuId=null,int? productId=null)
        {
            InitializeComponent();
            _tableId    = tableId;
            _menuId     =  menuId;
            _productId  = productId;
            if (_tableId!=null)
            {
                gridControlTableMovements.DataSource = _tablesMovementsDal.GetAll(context,t=>t.TableId==_tableId);
                return;
            }
            else if(_menuId!=null)
            {
                gridControlTableMovements.DataSource = _tablesMovementsDal.GetAll(context, m => m.Product.MenuId == _menuId);
                return;
            }
            else if (_productId != null)
            {
                gridControlTableMovements.DataSource = _tablesMovementsDal.GetAll(context, p => p.ProductId == _productId);
                return;
            }

            gridControlTableMovements.DataSource = _tablesMovementsDal.GetAll(context);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}