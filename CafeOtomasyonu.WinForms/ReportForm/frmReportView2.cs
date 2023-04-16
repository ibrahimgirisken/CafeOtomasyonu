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
using DevExpress.XtraReports.UI;

namespace CafeOtomasyonu.WinForms.ReportForm
{
    public partial class frmReportView2 : DevExpress.XtraEditors.XtraForm
    {
        public frmReportView2(XtraReport report)
        {
            InitializeComponent();
            documentViewerReport2.DocumentSource = report;
        }
    }
}