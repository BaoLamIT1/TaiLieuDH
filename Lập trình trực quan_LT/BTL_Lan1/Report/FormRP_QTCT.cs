using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lan1.Report
{
    public partial class FormRP_QTCT : Form
    {
        public FormRP_QTCT()
        {
            InitializeComponent();
        }

        private void FormRP_QTCT_Load(object sender, EventArgs e)
        {
            ProcessDataBase dtb = new ProcessDataBase();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "BTL_Lan1.Report.Report2.rdlc";
            ReportDataSource rpd = new ReportDataSource();
            rpd.Name = "DataSet1";
            rpd.Value = dtb.DocBang("select * from Report_QTCT");
            reportViewer1.LocalReport.DataSources.Add(rpd);
            this.reportViewer1.RefreshReport();
        }
    }
}
