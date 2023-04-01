using CafeOtomasyonu.Entities.DAL;
using CafeOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu.WinForms
{
    public partial class Form1 : Form
    {
        CafeContext _context = new CafeContext();
        MenuDal _menuDal = new MenuDal();
        Entities.Models.Menu _entity;
        public Form1()
        {
            InitializeComponent();
            _entity = new Entities.Models.Menu();
            txtMenuName.DataBindings.Add("Text", _entity, "MenuName");
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            if (_menuDal.AddOrUpdate(_context, _entity));
            {
                _menuDal.Save(_context);
            }
        }
    }
}
