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
    public partial class frmReportView : DevExpress.XtraEditors.XtraForm
    {
        public frmReportView(XtraReport report)
        {
            InitializeComponent();
            documentViewerReport.DocumentSource = report;
        }
    }
}