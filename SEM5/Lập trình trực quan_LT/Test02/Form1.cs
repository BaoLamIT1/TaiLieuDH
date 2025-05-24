using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtMaNV.Text.Trim().Equals("") || txtTen.Text.Trim() == ""
			|| txtSoDT.Text.Trim() == "" || rdbNam.Checked == false && rdbNam.Checked == false || cmbPB.Text.Trim() ==""
			|| txtLuong.Text.Trim() =="")
			{ MessageBox.Show("Hay nhap du dl "); k = false; }
			else
			{
				DataTable tb = pd.DocBang("Select * from tblSach where MaTP = '" + int.Parse(txtMaNV.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("ma tp nay da ton tai "); k = false;
				}
			}
			return k;
		}
		ProcessDatabase pd = new ProcessDatabase();
		private void Form1_Load(object sender, EventArgs e)
		{

		}

	}
}
