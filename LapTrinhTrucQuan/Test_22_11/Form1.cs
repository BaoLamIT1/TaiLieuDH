using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Test_22_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ProcessDataBase pd = new ProcessDataBase();
		bool kiemtradl()
		{
			bool k = true;
			if (txtMaTP.Text.Trim().Equals("") || txtTenTP.Text.Trim() == ""
			|| txtTenTG.Text.Trim() == "" || cmbLoai.Text.Trim() == "")
			{ MessageBox.Show("Hay nhap du dl "); k = false; }
			else
			{
				DataTable tb = pd.DocBang("Select * from tblSach where MaTP = '" + int.Parse(txtMaTP.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("ma tp nay da ton tai "); k = false;
				}
			}
			return k;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (kiemtradl() == true)
			{
				string sql = "insert into tblSach(MaTP, TenTP, TenTG, Loai) values (N'" + int.Parse(txtMaTP.Text) + "', N'" + txtTenTP.Text + "', N'"
							   + txtTenTG.Text + "', N'" + cmbLoai.Text + "')";
				pd.CapNhat(sql);
				dataGridView1.DataSource = pd.DocBang("select * from tblSach");
			}
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = pd.DocBang("select * from tblSach");
			dataGridView1.Columns[0].HeaderText = "MaTP";
			dataGridView1.Columns[1].HeaderText = "Tên tác phẩm: ";
			dataGridView1.Columns[2].HeaderText = "Tên tác giả: ";
			dataGridView1.Columns[3].HeaderText = "Loại ";
			dataGridView1.Columns[1].Width = 200;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql = "Update tblSach SET ";
			sql += "TenTG = N'" + txtTenTG.Text + "',";
			sql += "TenTP = N'" + txtTenTP.Text + "',";
			sql += "Loai = N'" + cmbLoai.Text + "'";
			sql += "Where MaTP = '" + txtMaTP.Text + "'";
			pd.CapNhat(sql);
			dataGridView1.DataSource = pd.DocBang("select * from tblSach");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("ban co muon xoa khong", "thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				pd.CapNhat("delete tblSach where MaTP ='" + int.Parse(txtMaTP.Text) + "'");

			}
			dataGridView1.DataSource = pd.DocBang("select * from tblSach");
		}
		// click vào data grid 
		private void dataGridView1_Click(object sender, EventArgs e)
		{
			txtMaTP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtTenTP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtTenTG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			cmbLoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
		}

		// btn Xuất file excel
		private void btnXuat_Click(object sender, EventArgs e)
		{
			// Tạo đối tượng SaveFileDialog để chọn đường dẫn lưu file Excel
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "BaoCaoKiemTra.xls";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				// Tạo đối tượng Worksheet để chứa dữ liệu từ datagridView
				Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet ws = (Excel.Worksheet)exBook.Worksheets[1];

				Excel.Range tenCuaHang = (Excel.Range)ws.Cells[1, 2];
				tenCuaHang.Font.Size = 12;
				ws.get_Range("B1:E1").Merge(true);
				tenCuaHang.Font.Bold = true; tenCuaHang.Font.Color = Color.Red;
				tenCuaHang.Value = "BÁO CÁO TÁC PHẨM";

				// Lấy tiêu đề của các cột từ datagridView
				string[] headers = new string[dataGridView1.Columns.Count];
				for (int i = 0; i < headers.Length; i++)
				{
					headers[i] = dataGridView1.Columns[i].HeaderText;
				}

				// Chèn tiêu đề vào sheet
				ws.Cells[3, 1] = headers[0];
				ws.Cells[3, 1].Font.Bold = true;
				for (int i = 1; i < headers.Length; i++)
				{
					ws.Cells[3, i + 1] = headers[i];
					ws.Cells[3, i + 1].Font.Bold = true;
				}

				// Chèn dữ liệu từ datagridView vào sheet
				for (int i = 0; i < dataGridView1.RowCount; i++)
				{
					for (int j = 0; j < headers.Length; j++)
					{
						if (dataGridView1.Rows[i].Cells[j].Value != null)
						{
							ws.Cells[i + 4, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
						}
					}
				}
				// Lưu file Excel
				ws.SaveAs(sfd.FileName);
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string sql = "Select * from tblSach";
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
			txtMaTP.Clear();
			txtTenTG.Clear();
			txtTenTP.Clear();
			cmbLoai.SelectedItem = null;
		}

		private void txtMaTP_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
