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
using CafeOtomasyonu.WinForms.MainMenu;
using DevExpress.XtraBars;

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context = new CafeContext();
        private UsersDal _usersDal = new UsersDal();
        private Entities.Models.Users _entity;
        private UserMovements _userMovements = new UserMovements();
        private UserMovementsDal _userMovementsDal = new UserMovementsDal();

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
                if (_usersDal.AddOrUpdate(_context, _entity))
                {
                    _usersDal.Save(_context);
                    var userIdMax = _context.Users.Max(u => u.Id);
                    _userMovements.UserId = userIdMax;
                    string description = "Yeni kullanıcı eklendi!";
                    _userMovementsDal.UserMovementsDalAdd(_context, _userMovements, description);
                    frmMainMenu frm = new frmMainMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                Rollers rol = new Rollers
                                {
                                    UserId = _context.Users.Max(u => u.Id),
                                    FormName = "frmMainMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    Visible = false
                                };
                                _context.Rollers.Add(rol);
                                _context.SaveChanges();
                            }
                        }
                    }

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