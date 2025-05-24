using BTL_Lan1.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace BTL_Lan1
{
	public partial class BaoCaoQTDT : Form
	{
		ProcessDataBase dtBase = new ProcessDataBase();
		string sql;
		public BaoCaoQTDT()
		{
			InitializeComponent();
		}

		private void BaoCaoQTDT_Load(object sender, EventArgs e)
		{
            //dgvBCQTDT.DataSource = dtBase.DocBang("SELECT * FROM TruongDaoTao");
            
        }

        private void cboTruongDT_MouseClick(object sender, MouseEventArgs e)
		{
			cboTruongDT.DataSource = dtBase.DocBang("Select * from TruongDaoTao");
			cboTruongDT.ValueMember = "MaTruongDaoTao";
			cboTruongDT.DisplayMember = "TenTruongDaoTao";
		}

		private void cboNganhDT_MouseClick(object sender, MouseEventArgs e)
		{
			cboNganhDT.DataSource = dtBase.DocBang("Select * from NganhDaoTao");
			cboNganhDT.ValueMember = "MaNganhDT";
			cboNganhDT.DisplayMember = "TenNganhDT";
		}
		private void btnMaNV_Click(object sender, EventArgs e)
		{
			if (txtMaNV.Text.Length == 0)
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên.");
			}
			else
			{
				sql = "SELECT hs.HoTen,qt.TuNgay,qt.DenNgay,tdt.TenTruongDaoTao,ndt.TenNganhDT,ht.TenHinhThuc,xl.TenXepLoai FROM HoSoNhanVien hs INNER JOIN QuaTrinhDaoTao qt ON hs.MaNhanVien = qt.MaNhanVien INNER JOIN TruongDaoTao tdt ON qt.MaTruongDaoTao = tdt.MaTruongDaoTao INNER JOIN NganhDaoTao ndt ON qt.MaNganhDT = ndt.MaNganhDT INNER JOIN XepLoai xl ON qt.MaXepLoai = xl.MaXepLoai INNER JOIN HinhThuc ht ON qt.MaHinhThuc = ht.MaHinhThuc WHERE  hs.MaNhanVien = N'" + txtMaNV.Text + "'";
				dgvBCQTDT.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnTruong_Click(object sender, EventArgs e)
		{
			if (cboTruongDT.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn trường.");
			}
			else
			{
				sql = "SELECT hs.HoTen, qt.TuNgay, qt.DenNgay,   ndt.TenNganhDT,   ht.TenHinhThuc,   xl.TenXepLoai FROM   HoSoNhanVien hs INNER JOIN QuaTrinhDaoTao qt ON hs.MaNhanVien = qt.MaNhanVien INNER JOIN TruongDaoTao tdt ON qt.MaTruongDaoTao = tdt.MaTruongDaoTao INNER JOIN NganhDaoTao ndt ON qt.MaNganhDT = ndt.MaNganhDT INNER JOIN XepLoai xl ON qt.MaXepLoai = xl.MaXepLoai INNER JOIN HinhThuc ht ON qt.MaHinhThuc = ht.MaHinhThuc WHERE   qt.MaTruongDaoTao = N'" + cboTruongDT.SelectedValue + "'";
				dgvBCQTDT.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnNganh_Click(object sender, EventArgs e)
		{
			if (cboNganhDT.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn ngành.");
			}
			else
			{
				sql = "SELECT   hs.HoTen,   qt.TuNgay,   qt.DenNgay,   tdt.TenTruongDaoTao,   ht.TenHinhThuc,   xl.TenXepLoai FROM   HoSoNhanVien hs INNER JOIN QuaTrinhDaoTao qt ON hs.MaNhanVien = qt.MaNhanVien INNER JOIN TruongDaoTao tdt ON qt.MaTruongDaoTao = tdt.MaTruongDaoTao INNER JOIN NganhDaoTao ndt ON qt.MaNganhDT = ndt.MaNganhDT INNER JOIN XepLoai xl ON qt.MaXepLoai = xl.MaXepLoai INNER JOIN HinhThuc ht ON qt.MaHinhThuc = ht.MaHinhThuc WHERE   ndt.MaNganhDT = N'" + cboNganhDT.SelectedValue + "'";
				dgvBCQTDT.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnXuatExcel_Click(object sender, EventArgs e)
		{
			// Tạo đối tượng SaveFileDialog để chọn đường dẫn lưu file Excel
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "BaoCaoQTDT.xls";
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
				tenCuaHang.Value = "BÁO CÁO QUÁ TRÌNH ĐÀO TẠO";

				// Lấy tiêu đề của các cột từ datagridView
				string[] headers = new string[dgvBCQTDT.Columns.Count];
				for (int i = 0; i < headers.Length; i++)
				{
					headers[i] = dgvBCQTDT.Columns[i].HeaderText;
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
				for (int i = 0; i < dgvBCQTDT.RowCount; i++)
				{
					for (int j = 0; j < headers.Length; j++)
					{
						if (dgvBCQTDT.Rows[i].Cells[j].Value != null)
						{
							ws.Cells[i + 4, j + 1] = dgvBCQTDT.Rows[i].Cells[j].Value.ToString();
						}
					}
				}
				// Lưu file Excel
				ws.SaveAs(sfd.FileName);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

			if (dr == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
        private void button1_Click(object sender, EventArgs e)
        {
            string[] headers = new string[dgvBCQTDT.Columns.Count];
            for (int i = 0; i < (dgvBCQTDT.RowCount)-1; i++)
            {
				if (dgvBCQTDT.Rows[i].Cells[0].Value.ToString() != null)
				{
                    string sql1 = "insert into Report_QTDT (HoTen,TuNgay,DenNgay,TenNganhDT,TenHinhThuc,XepLoai) values (N'" + dgvBCQTDT.Rows[i].Cells[0].Value.ToString() + "','" + dgvBCQTDT.Rows[i].Cells[1].Value.ToString() + "','" + dgvBCQTDT.Rows[i].Cells[2].Value.ToString() + "',N'" + dgvBCQTDT.Rows[i].Cells[3].Value.ToString() + "',N'" + dgvBCQTDT.Rows[i].Cells[4].Value.ToString() + "',N'" + dgvBCQTDT.Rows[i].Cells[5].Value.ToString() + "')";
                    dtBase.CapNhat(sql1);
                }
			}
            if (dgvBCQTDT.DataSource != null)
            {
                FormRP_QTDT formReport = new FormRP_QTDT();
                formReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu không thể xuất báo cáo ");
            }

            DialogResult dr = MessageBox.Show("Ok", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
				string sql2 = "delete Report_QTDT";
				dtBase.CapNhat(sql2);
            }
        }
    }
}
