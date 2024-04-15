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
	public partial class BaoCaoQTCT : Form
	{
		ProcessDataBase dtBase = new ProcessDataBase();
		string sql;
		public BaoCaoQTCT()
		{
			InitializeComponent();
		}
		// ComboBox cho Phòng Ban
		private void cboPhongBan_MouseClick(object sender, MouseEventArgs e)
		{
			cboPhongBan.DataSource = dtBase.DocBang("Select * from PhongBan");
			cboPhongBan.ValueMember = "MaPhongBan";
			cboPhongBan.DisplayMember = "TenPhongBan";
		}
		private void btnMaNVQTCT_Click(object sender, EventArgs e)
		{
			if (txtMaNVQTCT.Text.Length == 0)
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên.");
			}
			else
			{
				sql = "SELECT    hs.HoTen,    qtc.MaQuaTrinhCongTac,    qtc.TuNgay,    qtc.DenNgay,    pb.TenPhongBan,    cv.TenChucVu  FROM    HoSoNhanVien hs  INNER JOIN QuaTrinhCongTac qtc ON hs.MaNhanVien = qtc.MaNhanVien  INNER JOIN PhongBan pb ON qtc.MaPhongBan = pb.MaPhongBan  INNER JOIN ChucVu cv ON qtc.MaChucVu=cv.MaChucVu  WHERE    hs.MaNhanVien = N'" + txtMaNVQTCT.Text + "'";
				dgvBCQTCT.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnPhongBan_Click(object sender, EventArgs e)
		{
			if (cboPhongBan.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn phòng ban.");
			}
			else
			{
				sql = "SELECT   hs.HoTen,   qtc.MaQuaTrinhCongTac,   qtc.TuNgay,   qtc.DenNgay,   qtc.MaChucVu,   cv.TenChucVu FROM   HoSoNhanVien hs INNER JOIN QuaTrinhCongTac qtc ON hs.MaNhanVien = qtc.MaNhanVien INNER JOIN PhongBan pb ON qtc.MaPhongBan = pb.MaPhongBan INNER JOIN ChucVu cv ON qtc.MaChucVu = cv.MaChucVu WHERE   qtc.MaPhongBan = N'" + cboPhongBan.SelectedValue + "'";
				dgvBCQTCT.DataSource = dtBase.DocBang(sql);
			}
		}

		private void btnXuatExcel_Click(object sender, EventArgs e)
		{
			// Tạo đối tượng SaveFileDialog để chọn đường dẫn lưu file Excel
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "BaoCaoQTCT.xls";
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
				tenCuaHang.Value = "BÁO CÁO QUÁ TRÌNH CÔNG TÁC";

				// Lấy tiêu đề của các cột từ datagridView
				string[] headers = new string[dgvBCQTCT.Columns.Count];
				for (int i = 0; i < headers.Length; i++)
				{
					headers[i] = dgvBCQTCT.Columns[i].HeaderText;
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
				for (int i = 0; i < dgvBCQTCT.RowCount; i++)
				{
					for (int j = 0; j < headers.Length; j++)
					{
						if (dgvBCQTCT.Rows[i].Cells[j].Value != null)
						{
							ws.Cells[i + 4, j + 1] = dgvBCQTCT.Rows[i].Cells[j].Value.ToString();
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

        private void BaoCaoQTCT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] headers = new string[dgvBCQTCT.Columns.Count];
            for (int i = 0; i < (dgvBCQTCT.RowCount) - 1; i++)
            {
                if (dgvBCQTCT.Rows[i].Cells[0].Value.ToString() != null)
                {
                    string sql1 = "insert into Report_QTCT (HoTen,MaQTCT,TuNgay,DenNgay,MaChucVu,TenChucVu) values (N'" + dgvBCQTCT.Rows[i].Cells[0].Value.ToString() + "','" + dgvBCQTCT.Rows[i].Cells[1].Value.ToString() + "','" + dgvBCQTCT.Rows[i].Cells[2].Value.ToString() + "',N'" + dgvBCQTCT.Rows[i].Cells[3].Value.ToString() + "',N'" + dgvBCQTCT.Rows[i].Cells[4].Value.ToString() + "',N'" + dgvBCQTCT.Rows[i].Cells[5].Value.ToString() + "')";
                    dtBase.CapNhat(sql1);
                }
            }
            if (dgvBCQTCT.DataSource != null)
            {
                FormRP_QTCT formReport = new FormRP_QTCT();
                formReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu không thể xuất báo cáo ");
            }

            DialogResult dr = MessageBox.Show("Ok", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                string sql2 = "delete Report_QTCT";
                dtBase.CapNhat(sql2);
            }
        }
    }
}
