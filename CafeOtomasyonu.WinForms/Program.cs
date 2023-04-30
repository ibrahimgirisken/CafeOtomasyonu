using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyonu.Entities.Models;
using CafeOtomasyonu.Entities.Tools;
using CafeOtomasyonu.WinForms.MainMenu;

namespace CafeOtomasyonu.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionTools.ConnectionControl();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainMenu());
        }
    }
}
