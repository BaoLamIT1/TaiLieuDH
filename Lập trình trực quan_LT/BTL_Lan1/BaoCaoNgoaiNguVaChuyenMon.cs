using BTL_Lan1.Report;
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
namespace BTL_Lan1
{
	public partial class BaoCaoNgoaiNguVaChuyenMon : Form
	{
		ProcessDataBase dtBase = new ProcessDataBase();
		string sql;
		public BaoCaoNgoaiNguVaChuyenMon()
		{
			InitializeComponent();
		}

		private void cmbNgoaiNgu_MouseClick(object sender, MouseEventArgs e)
		{
			cmbNgoaiNgu.DataSource = dtBase.DocBang("Select * from NgoaiNgu");
			cmbNgoaiNgu.ValueMember = "MaNgoaiNgu";
			cmbNgoaiNgu.DisplayMember = "TenNgoaiNgu";
		}

		private void cmbChuyenMon_MouseClick(object sender, MouseEventArgs e)
		{
			cmbChuyenMon.DataSource = dtBase.DocBang("Select * from ChuyenMon");
			cmbChuyenMon.ValueMember = "MaChuyenMon";
			cmbChuyenMon.DisplayMember = "TenChuyenMon";
		}

		private void btnHienThi_Click(object sender, EventArgs e)
		{
			if (cmbChuyenMon.SelectedItem == null || cmbNgoaiNgu.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn đủ");
			}
			else
			{
				sql = "select NV.MaNhanVien , NV.HoTen , NV.DiaChi, NV.NgaySinh,TNN.TenNgoaiNgu,CM.TenChuyenMon from HoSoNhanVien NV inner join ChuyenMon CM on NV.MaChuyenMon = CM.MaChuyenMon inner join NV_NgoaiNgu NN on NN.MaNhanVien = NV.MaNhanVien inner join NgoaiNgu TNN on TNN.MaNgoaiNgu = NN.MaNgoaiNgu where TNN.MaNgoaiNgu = N'" + cmbNgoaiNgu.SelectedValue + "' and CM.MaChuyenMon = N'" + cmbChuyenMon.SelectedValue + "'";
				dgvNVTheoNNvaCM.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnXuatExcel_Click(object sender, EventArgs e)
		{
			// Tạo đối tượng SaveFileDialog để chọn đường dẫn lưu file Excel
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "BaoCaoNVcungNNvaCM.xls";
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
				tenCuaHang.Value = "BÁO CÁO CÁC NHÂN VIÊN THEO NGOẠI NGỮ VÀ CHUYÊN MÔN";

				// Lấy tiêu đề của các cột từ datagridView
				string[] headers = new string[dgvNVTheoNNvaCM.Columns.Count];
				for (int i = 0; i < headers.Length; i++)
				{
					headers[i] = dgvNVTheoNNvaCM.Columns[i].HeaderText;
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
				for (int i = 0; i < dgvNVTheoNNvaCM.RowCount; i++)
				{
					for (int j = 0; j < headers.Length; j++)
					{
						if (dgvNVTheoNNvaCM.Rows[i].Cells[j].Value != null)
						{
							ws.Cells[i + 4, j + 1] = dgvNVTheoNNvaCM.Rows[i].Cells[j].Value.ToString();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            string[] headers = new string[dgvNVTheoNNvaCM.Columns.Count];
            for (int i = 0; i < (dgvNVTheoNNvaCM.RowCount) - 1; i++)
            {
                if (dgvNVTheoNNvaCM.Rows[i].Cells[0].Value.ToString() != null)
                {
                    string sql1 = "insert into ReportNVcungNNvaCM values ('" + dgvNVTheoNNvaCM.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvNVTheoNNvaCM.Rows[i].Cells[1].Value.ToString() + "',N'" + dgvNVTheoNNvaCM.Rows[i].Cells[2].Value.ToString() + "','" + dgvNVTheoNNvaCM.Rows[i].Cells[3].Value.ToString() + "',N'" + dgvNVTheoNNvaCM.Rows[i].Cells[4].Value.ToString() + "',N'" + dgvNVTheoNNvaCM.Rows[i].Cells[5].Value.ToString() + "')";
                    dtBase.CapNhat(sql1);
                }
            }
            if (dgvNVTheoNNvaCM.DataSource != null)
            {

                FormReportNVcungNNvaCM formReport = new FormReportNVcungNNvaCM();
                formReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu không thể xuất báo cáo ");
            }
            DialogResult dr = MessageBox.Show("Ok", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                string sql2 = "delete ReportNVcungNNvaCM";
                dtBase.CapNhat(sql2);
            }
        }
    }
}
