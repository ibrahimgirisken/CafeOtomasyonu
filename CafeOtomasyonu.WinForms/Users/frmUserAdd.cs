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
using DevExpress.XtraBars;
using CafeOtomasyonu.WinForms.MainMenu;

namespace CafeOtomasyonu.WinForms.Users
{
    public partial class frmUserAdd : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private Entities.Models.Users _users;
        private UserMovements _userMovements=new UserMovements();
        private UsersDal usersDal=new UsersDal();
        private UserMovementsDal _userMovementsDal=new UserMovementsDal();

        public frmUserAdd(Entities.Models.Users users)
        {
            InitializeComponent();
            this._users = users;
            tglStatus.DataBindings.Add("EditValue", _users, "Status", true);
            txtFullName.DataBindings.Add("Text", _users, "FullName", true);
            txtTelephone.DataBindings.Add("Text", _users, "Telephone", true);
            memAddress.DataBindings.Add("Text", _users, "Address", true);
            txtEmail.DataBindings.Add("Text", _users, "Email", true);
            txtMission.DataBindings.Add("Text", _users, "Mission", true);
            txtUserName.DataBindings.Add("Text", _users, "UserName", true);
            txtPassword.DataBindings.Add("Text", _users, "Password", true);
            txtQuestion.DataBindings.Add("Text", _users, "ReminderQuestion", true);
            txtReply.DataBindings.Add("Text", _users, "Reply", true);
            memDescription.DataBindings.Add("Text", _users, "Description", true);
            if (_users.Id==0)
            {
                lblTitle.Text = "Yeni Kullanıcı Ekleme Sayfası";
            }
            else if (_users.Id != 0)
            {
                lblTitle.Text =_users.UserName+" Bilgileri Sayfası";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text== "Yeni Kullanıcı Ekleme Sayfası")
            {
                _users.SavedDate = DateTime.Now;
                if (usersDal.AddOrUpdate(context, _users))
                {
                    usersDal.Save(context);
                    var userIdMax = context.Users.Max(u => u.Id);
                    _userMovements.UserId = userIdMax;
                    string description = "Yönetici Tarafından Yeni kullanıcı eklendi!";
                    _userMovementsDal.UserMovementsDalAdd(context, _userMovements, description);
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
                                    UserId = context.Users.Max(u => u.Id),
                                    FormName = "frmMainMenu",
                                    ControlCaption = btn.Caption,
                                    ControlName = btn.Name,
                                    Visible = false
                                };
                                context.Rollers.Add(rol);
                                context.SaveChanges();
                            }
                        }
                    }

                    this.Close();
                }
            }
            else
            {
                if (usersDal.AddOrUpdate(context,_users))
                {
                    usersDal.Save(context);
                    var id = _users.Id;
                    _userMovements.UserId = id;
                    string description = "Yönetici tarafından "+_users.UserName+" kullanıcısının bilgileri güncellendi.";
                    _userMovementsDal.UserMovementsDalAdd(context, _userMovements, description);
                    this.Close();
                }
            }
            context.SaveChanges();
        }
    }
}