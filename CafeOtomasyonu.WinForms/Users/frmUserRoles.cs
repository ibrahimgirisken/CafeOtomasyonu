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

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmUserRoles : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext(); 
        RollersDal rollersDal=new RollersDal();
        private int _userId;
        public frmUserRoles(int userId)
        {
            InitializeComponent();
            _userId = userId;
            gridControlUserRoles.DataSource = rollersDal.GetAll(context,r=>r.UserId== _userId);
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            rollersDal.Save(context);
            gridViewUserRoles.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}