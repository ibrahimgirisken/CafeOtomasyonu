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
    public partial class frmTableAdd : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private TablesDal _tablesDal = new TablesDal();
        private Entities.Models.Tables _entity;
        public bool _saveStatus = false;
        public frmTableAdd(Entities.Models.Tables entity)
        {
            InitializeComponent();
            _entity = entity;
            txtTableName.DataBindings.Add("Text", _entity, "TableName");
            memoDescription.DataBindings.Add("Text", _entity, "Description");
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Status = false;
                _entity.Rezerv = false;
                _entity.SavedDate = DateTime.Now;
                _entity.UpdateDate = DateTime.Now;
                _entity.Process = "Yeni masa eklendi";
            }else if (_entity.Id!=0)
            {
                _entity.UpdateDate = DateTime.Now;
                _entity.Process = "Masa güncellendi";
            }
            if (_tablesDal.AddOrUpdate(_context, _entity))
            {
                _tablesDal.Save(_context);
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