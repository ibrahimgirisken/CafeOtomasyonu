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
using Microsoft.SqlServer.Management.Smo;
using System.IO;
using Microsoft.SqlServer.Management.Common;

namespace CafeOtomasyonu.WinForms.Settings
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context=new CafeContext();
        public frmBackup()
        {
            InitializeComponent();
            Server server = new Server();
            var model = context.Database.SqlQuery<Database>("SELECT * FROM sys.databases").ToList();
            foreach (var item in model)
            {
                cbDatabase.Properties.Items.Add(item.Name);
            }

            cbDatabase.EditValue = "Cafe";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.Filter = "Backup(Yedekleme) Dosyaları (*.bak)|*.bak";
            xtraSaveFileDialog1.Title = "Yedeklenecek Dosyalar";
            if (xtraSaveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = xtraSaveFileDialog1.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBarControl1.EditValue = 0;
            try
            {
                if (System.IO.File.Exists(txtPath.Text))
                {
                    File.Delete(txtPath.Text);
                }

                Server dbServer = new Server(new ServerConnection(txtAnchor.Text));
                Backup dbBackup = new Backup();
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database=cbDatabase.Text;
                dbBackup.Devices.AddDevice(txtPath.Text,DeviceType.File);
                dbBackup.Initialize = false;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackup(dbServer);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata\n" + exception.Message);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Yedekleme işlemi başarı ile gerçekleşti");
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBarControl1.EditValue = e.Percent;
            progressBarControl1.Update();
            lblPercent.Text = $"{e.Percent} %";
            lblStatus.Text = "İşlem başarı ile gerçekleşti";
        }
    }
}