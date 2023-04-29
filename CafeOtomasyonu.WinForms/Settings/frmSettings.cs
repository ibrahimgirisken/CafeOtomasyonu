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

namespace CafeOtomasyonu.WinForms.Settings
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        public frmSettings()
        {
            InitializeComponent();

            List<object> objs = new List<object>();
            int i = 0;
            foreach (var item in typeof(Product).GetProperties())
            {
                if (item.Name.Contains("UnitPrice"))
                {
                    objs.Insert(i, item.Name);
                    i++;
                }
            }

            lookUpUnitPrice.Properties.DataSource = objs;
            GetSetting();
        }

        private void GetSetting()
        {
            var model = context.Settings.FirstOrDefault(p => p.SettingDefinition == "Unit Price");
            if (model != null) {lookUpUnitPrice.EditValue = model.SettingName;}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnitPriceSave_Click(object sender, EventArgs e)
        {
            var modelData = context.Settings.FirstOrDefault(p => p.SettingDefinition == "Unit Price");
            if (modelData != null)
            {
                modelData.SettingName = lookUpUnitPrice.EditValue.ToString();
                context.SaveChanges();
            }
            else if (modelData == null)
            {
                Entities.Models.Settings settings = new Entities.Models.Settings
                {
                    SettingDefinition = "Unit Price",
                    SettingName = lookUpUnitPrice.EditValue.ToString()

                };
                context.Settings.Add(settings);
            }

            context.SaveChanges();
            GetSetting();
            MessageBox.Show("Ayarlar kayıt edildi");
        }
    }
}