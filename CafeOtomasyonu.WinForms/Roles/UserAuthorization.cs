using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.WinForms.Roles
{
    public class UserAuthorization
    {
        public static void GetAuthorization(CafeContext context, RibbonControl ribbonControl)
        {
            foreach (var item in ribbonControl.Items)
            {
                foreach (var roller in context.Rollers.Where(r => r.UserId == UserSettings.userId).ToList())
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Name== roller.ControlName&& roller.Visible)
                        {
                            btn.Enabled =true;
                        }
                        if (btn.Name == roller.ControlName && !roller.Visible)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }

        public static void AdminStatus(CafeContext context,params dynamic[] obj)
        {
            var admin = context.Users.FirstOrDefault(u => u.Id == UserSettings.userId);
            if (admin.Admin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = true;
                }
            }
            else if (!admin.Admin)
            {
                for (int i = 0; i < obj.Length; i++)
                {
                    obj[i].Enabled = false;
                }
            }
        }
    }
}
