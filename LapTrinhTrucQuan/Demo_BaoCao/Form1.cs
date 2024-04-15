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

namespace Demo_BaoCao
{
	public partial class Form1 : Form
	{
		ProcessDatabase pd  = new ProcessDatabase();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
            
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			//reportViewer1.LocalReport.ReportEmbeddedResource = "Demo_BaoCao.Report1.rdlc";
			//ReportDataSource rpd = new ReportDataSource();
			//rpd.Name = "DataSet1";
			//rpd.Value = pd.DocBang("select * from HoSoNhanVien");
			//reportViewer1.LocalReport.DataSources.Add(rpd);
			//this.reportViewer1.RefreshReport();
		}
	}
}
