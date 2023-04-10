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
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.Internal;

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmUserLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool inputStatus;
        private CafeContext _context = new CafeContext();
        private UserMovementsDal _userMovementsDal = new UserMovementsDal();
        private UserMovements _userMovements=new UserMovements();
        void getData()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtUserPass.Text = Properties.Settings.Default.Password;
                chkRememberMe.Checked=true;
            }
            else
            {
                txtUserName.Text = null;
                txtUserPass.Text = null;
                chkRememberMe.Checked = false;
            }
        }

        void saveData()
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtUserPass.Text;
                Properties.Settings.Default.RememberMe=true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.RememberMe = false;
                   Properties.Settings.Default.Save();
            }
        }
        public frmUserLogin()
        {
            InitializeComponent();
            getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!inputStatus)
            {
                Application.Exit();
            }
        }

        private void frmUserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            var _user =_context.Users.FirstOrDefault(u => u.UserName == txtUserName.Text && u.Password == txtUserPass.Text);
            if (_user != null)
            {
                inputStatus = true;
                saveData();
                UserSettings.userId=_user.Id;
                _userMovements.UserId = _user.Id;
                string description = _user.UserName + " adlı kullanıcı giriş sisteme yaptı";
                _userMovementsDal.UserMovementsDalAdd(_context, _userMovements, description);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void frmUserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!inputStatus)
            {
                Application.Exit();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm=new frmRegister(new Entities.Models.Users());
            frm.ShowDialog();
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            frmForgetPassword frm=new frmForgetPassword();
            frm.ShowDialog();
        }
    }
}