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
using CafeOtomasyonu.WinForms.Roles;

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UsersDal usersDal = new UsersDal();
        public frmUsers()
        {
            InitializeComponent();
            UserList();
            UserAuthorization.AdminStatus(context,btnUserAdd,btnUserRoles,btnUserUpdate,btnUserSave,gridControlUsers);
        }

        private void UserList()
        {
            gridControlUsers.DataSource = usersDal.GetAll(context);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            this.UserList();    
        }
        private void btnUserRoles_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridViewUsers.GetFocusedRowCellValue(colId));
            frmUserRoles frm_UserRoles = new frmUserRoles(id);
            frm_UserRoles.ShowDialog();
        }

        private frmUserAdd frm_UserAdd;
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (frm_UserAdd == null || frm_UserAdd.IsDisposed)
            {
                frm_UserAdd = new frmUserAdd(new Entities.Models.Users());
                frm_UserAdd.ShowDialog();
                UserList();
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridViewUsers.GetFocusedRowCellValue(colId));
            var model = usersDal.GetByFilter(context, u => u.Id == id);
            frmUserAdd frmUserAdd = new frmUserAdd(model);
            frmUserAdd.ShowDialog();
            UserList();
        }
    }
}