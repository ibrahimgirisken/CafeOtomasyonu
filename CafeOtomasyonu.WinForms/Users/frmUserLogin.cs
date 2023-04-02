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
using CafeOtomasyonu.Entities.Models;
using DevExpress.Internal;

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmUserLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool inputStatus;
        private CafeContext _context = new CafeContext();
        public frmUserLogin()
        {
            InitializeComponent();
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
            if (_context.Users.Any(u=>u.UserName==txtUserName.Text && u.Password==txtUserPass.Text))
            {
                inputStatus = true;
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
    }
}