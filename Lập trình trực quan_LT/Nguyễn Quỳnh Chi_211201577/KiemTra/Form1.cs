using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace KiemTra
{
	public partial class Form1 : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		DataTable dtTP = new DataTable();

		DataTable dtLoai = new DataTable();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dtTP = pd.DocBang("Select * from tblTacPham");

			dataGridView1.DataSource = dtTP;
			dataGridView1.Columns[0].HeaderText = "Mã TP";
			dataGridView1.Columns[1].HeaderText = "Tên TP";
			dataGridView1.Columns[2].HeaderText = "Tên TG";
			dataGridView1.Columns[3].HeaderText = "Loại";
			dataGridView1.Columns[1].Width = 200;

			dtLoai = pd.DocBang("Select Loai from tblLoai");

			/*List<string> list = new List<string>();
			foreach (DataRow item in dtLoai.Rows)
			{
				list.Add(item.ToString());
			}*/
			cbLoai.DataSource = dtLoai;
			cbLoai.DisplayMember = "Loai";
		}
		bool KTDL()
		{
			bool k = true;
			if (txtMa.Text.Trim().Equals("") || txtTenTG.Text.Trim() == "" || txtTenTP.Text.Trim() == "")
			{
				MessageBox.Show("Hãy nhập đủ dữ liệu");
				k = false;
			}
			else
			{
				DataTable tb = pd.DocBang("select * from tblTacPham where MaTP = '" + txtMa.Text + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("Tác phẩm này đã tồn tại");
					k = false;
				}
			}
			return k;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (KTDL() == true)
			{
				string sql = "insert into tblTacPham(MaTP,TenTP,TenTG,Loai) values ('"
					+ txtMa.Text + "',N'" + txtTenTP.Text + "',N'"
					+ txtTenTG.Text + "',N'" + cbLoai.Text + "' )";
				pd.CapNhat(sql);
				dataGridView1.DataSource = pd.DocBang("select * from tblTacPham");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql = "Update tblTacPham SET ";
			sql += "TenTG = N'" + txtTenTG.Text + "',";
			sql += "TenTP = N'" + txtTenTP.Text + "',";
			sql += "Loai = N'" + cbLoai.Text + "'";
			sql += "Where MaTP = '" + txtMa.Text + "'";
			pd.CapNhat(sql);
			dataGridView1.DataSource = pd.DocBang("select * from tblTacPham");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				txtMa.Text = dataGridView1[0, e.RowIndex].Value.ToString();
				txtTenTP.Text = dataGridView1[1, e.RowIndex].Value.ToString();
				txtTenTG.Text = dataGridView1[2, e.RowIndex].Value.ToString();
				cbLoai.Text = dataGridView1[3, e.RowIndex].Value.ToString();
			}
			catch (Exception ex)
			{

			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xoá?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				pd.CapNhat("delete tblTacPham where MaTP='" + txtMa.Text + "'");
				dataGridView1.DataSource = pd.DocBang("select * from tblTacPham");
			}
		}

		private void btnTK_Click(object sender, EventArgs e)
		{
			string sql = "Select * from tblTacPham";
			string dk = "";
			if (txtTimKiem.Text.Trim() != "")
			{
				dk += " MaTP like '%" + txtTimKiem.Text + "%'";
			}

			if (txtTKTenSP.Text.Trim() != "" && dk != "")
			{
				dk += " and TenTP like N'%" + txtTKTenSP.Text + "%'";
			}

			if (txtTKTenSP.Text.Trim() != "" && dk == "")
			{
				dk += " TenTP like N'%" + txtTKTenSP.Text + "%'";
			}
			if (dk != "")
			{
				sql += " WHERE" + dk;
			}
			dataGridView1.DataSource = pd.DocBang(sql);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtMa.Clear();
			txtTenTG.Clear();
			txtTenTP.Clear();
			cbLoai.SelectedItem = null;
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			if (dtTP.Rows.Count > 0) //TH có dữ liệu để ghi 
			{
				Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];


				Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
				exSheet.get_Range("B5:G5").Merge(true);
				header.Font.Size = 13;
				header.Font.Bold = true;
				header.Font.Color = Color.Red;
				header.Value = "DANH SÁCH CÁC TÁC PHẨM";


				exSheet.get_Range("A7:G7").Font.Bold = true;
				exSheet.get_Range("A7:G7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				exSheet.get_Range("A7").Value = "STT";
				exSheet.get_Range("B7").Value = "Mã TP";
				exSheet.get_Range("C7").Value = "Tên TP";
				exSheet.get_Range("C7").ColumnWidth = 20;
				exSheet.get_Range("D7").Value = "Tên TG";
				exSheet.get_Range("D7").ColumnWidth = 20;
				exSheet.get_Range("E7").Value = "Loại";

				for (int i = 0; i < dtTP.Rows.Count; i++)
				{
					exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
					exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
					exSheet.get_Range("B" + (i + 8).ToString()).Value = dtTP.Rows[i]["MaTP"].ToString();
					exSheet.get_Range("C" + (i + 8).ToString()).Value = dtTP.Rows[i]["TenTP"].ToString();
					exSheet.get_Range("D" + (i + 8).ToString()).Value = dtTP.Rows[i]["TenTG"].ToString();
					exSheet.get_Range("E" + (i + 8).ToString()).Value = dtTP.Rows[i]["Loai"].ToString();
				}

				exSheet.Name = "Hang";
				exBook.Activate(); 
				dlgSave.Filter = "Excel Document(*.xls)|*.xls  |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";

				dlgSave.FilterIndex = 1;
				dlgSave.AddExtension = true;
				dlgSave.DefaultExt = ".xls";
				if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel 
				exApp.Quit();
			}
			else
				MessageBox.Show("Không có danh sách hàng để in");
		}

		private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
