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
    public partial class frmForgetPassword : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        UsersDal _usersDal=new UsersDal();
        private UserMovementsDal _userMovementsDal = new UserMovementsDal();
        private UserMovements _userMovements = new UserMovements();
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            var entity = _usersDal.GetByFilter(_context,
                u => u.UserName == txtUserNameOrEmail.Text || u.Email == txtUserNameOrEmail.Text);
            if (entity!=null)
            {
                if (entity.ReminderQuestion==txtQuestion.Text && entity.Reply==txtReply.Text)
                {
                    if (txtPassword.Text==txtPasswordRepeat.Text)
                    {
                        entity.Password = txtPassword.Text;
                        if (_usersDal.AddOrUpdate(_context, entity)) ;
                        {
                            _usersDal.Save(_context);
                            _userMovements.UserId = entity.Id;
                            string description = entity.UserName + " adlı kullanıcı parolasını değiştirdi";
                            _userMovementsDal.UserMovementsDalAdd(_context,_userMovements,description);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola girişleri eşleşmedi!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Soru veya cevap hatalı girildi!");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
            }
        }
    }
}