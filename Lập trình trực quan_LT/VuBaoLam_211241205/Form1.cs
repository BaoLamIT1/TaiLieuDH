using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuBaoLam_211241205
{
	public partial class Form1 : Form
	{
		ProcessDatabase pd = new ProcessDatabase();
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = pd.DocBang("select * from ");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("ban co muon xoa khong", "thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				pd.CapNhat("delete  where  ='" + int.Parse(.Text) + "'");

			}
			dataGridView1.DataSource = pd.DocBang("select * from ");
		}
	}
}
