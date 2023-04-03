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
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private UsersDal usersDal = new UsersDal();
        private Entities.Models.Users _entity;
        public bool saveStatus = false;

        public Entities.Models.Users Users { get; }

        public frmRegister(Entities.Models.Users entity)
        {
            InitializeComponent();
            _entity = entity;

            tglStatus.DataBindings.Add("EditValue", _entity, "Status");
            txtFullName.DataBindings.Add("Text", _entity, "FullName");
            txtTelephone.DataBindings.Add("Text", _entity, "Telephone");
            memAddress.DataBindings.Add("Text", _entity, "Address");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtMission.DataBindings.Add("Text", _entity, "Mission");
            txtPassword.DataBindings.Add("Text", _entity, "Password");
            txtQuestion.DataBindings.Add("Text", _entity, "ReminderQuestion");
            txtReply.DataBindings.Add("Text", _entity, "Reply");
            txtUserName.DataBindings.Add("Text", _entity, "UserName");
            memDescription.DataBindings.Add("Text", _entity, "Description");
        }


        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordRepeat.Text)
            {
                _entity.SavedDate = DateTime.Now;
                if (usersDal.AddOrUpdate(context, _entity))
                {
                    usersDal.Save(context);
                    saveStatus = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(("Şifreler uyuşmadı"));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}