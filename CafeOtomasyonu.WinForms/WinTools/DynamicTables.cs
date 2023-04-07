using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using DevExpress.XtraBars.Customization.Helpers;

namespace CafeOtomasyonu.WinForms.WinTools
{
    public class DynamicTables
    {
        public static void getTables(CafeContext context,FlowLayoutPanel flowLayoutPanel)
        {
            var model = context.Tables.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].TableName;
                btn.Name = model[i].Id.ToString();
                btn.Width = 80;
                btn.Height = 100;
                flowLayoutPanel.Controls.Add(btn);
                if (model[i].Rezerv && !model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Yellow;
                }else if (model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Red;
                }else if (!model[i].Status)
                {
                    btn.Appearance.BackColor = Color.Green;
                }
                btn.Click += Btn_Click;
            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
