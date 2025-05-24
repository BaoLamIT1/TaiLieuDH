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
	public partial class NhanVienDangTrongQTDT : Form
	{
		ProcessDataBase dtBase = new ProcessDataBase();
		string sql;
		public NhanVienDangTrongQTDT()
		{
			InitializeComponent();
		}

		private void cboMaQTDT_MouseClick(object sender, MouseEventArgs e)
		{

		}

        private void btnMaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
            }
            else
            {
                sql = "select * from HoSoNhanVien where MaNhanVien = '" + txtMaNV.Text.ToString() + "'";
                if (dtBase.DocBang(sql).Rows.Count == 0)
                {
                    MessageBox.Show("Mã nhân viên :" + txtMaNV.Text + " này không tồn tại");
                }

                sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0 and NV.MaNhanVien= '" + txtMaNV.Text + "'";
                dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);
            }
        }

		private void btnHienMaQTDT_Click(object sender, EventArgs e)
		{
            if (txtMaQTDT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã QTDT.");
            }
            else
            {
                sql = "select * from QuaTrinhDaoTao where MaQuaTrinhDaoTao = '" + txtMaQTDT.Text.ToString() + "'";
                if (dtBase.DocBang(sql).Rows.Count == 0)
                {
                    MessageBox.Show("Mã QTDT :" + txtMaQTDT.Text + " này không tồn tại");
                }
                sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0 and QTDT.MaQuaTrinhDaoTao='" + txtMaQTDT.Text + "'";
                dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);
            }
        }

		private void btnHienThiAll_Click(object sender, EventArgs e)
		{

			sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0";
			dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);
		}

		private void btnXuatExcel_Click(object sender, EventArgs e)
		{
            if (dgvNVtheoQTDT.DataSource != null)
            {
                // Tạo đối tượng SaveFileDialog để chọn đường dẫn lưu file Excel
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "BaoCaoNhanVienDangTrongQTDT.xls";
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
                    tenCuaHang.Value = "BÁO CÁO THÔNG TIN CÁC NHÂN VIÊN ĐANG TRONG QUÁ TRÌNH ĐÀO TẠO";


                    // Lấy tiêu đề của các cột từ datagridView
                    string[] headers = new string[dgvNVtheoQTDT.Columns.Count];
                    for (int i = 0; i < headers.Length; i++)
                    {
                        headers[i] = dgvNVtheoQTDT.Columns[i].HeaderText;
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
                    for (int i = 0; i < dgvNVtheoQTDT.RowCount; i++)
                    {
                        for (int j = 0; j < headers.Length; j++)
                        {
                            if (dgvNVtheoQTDT.Rows[i].Cells[j].Value != null)
                            {
                                ws.Cells[i + 4, j + 1] = dgvNVtheoQTDT.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    // Lưu file Excel
                    ws.SaveAs(sfd.FileName);
                }
                else
                    MessageBox.Show("Không có dữ liệu không thể xuất báo cáo ");
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

        private void NhanVienDangTrongQTDT_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string[] headers = new string[dgvNVtheoQTDT.Columns.Count];
            for (int i = 0; i < (dgvNVtheoQTDT.RowCount) - 1; i++)
            {
                if (dgvNVtheoQTDT.Rows[i].Cells[0].Value.ToString() != null)
                {
                    string sql1 = "insert into ReportNVtrongQTDT (MaNhanVien,HoTen,MaQuaTrinhDaoTao,TuNgay,DenNgay,TenTruongDaoTao,TenNganhDT,TenHinhThuc) values ('" + dgvNVtheoQTDT.Rows[i].Cells[0].Value.ToString() + "',N'" + dgvNVtheoQTDT.Rows[i].Cells[1].Value.ToString() + "','" + dgvNVtheoQTDT.Rows[i].Cells[2].Value.ToString() + "','" + dgvNVtheoQTDT.Rows[i].Cells[3].Value.ToString() + "','" + dgvNVtheoQTDT.Rows[i].Cells[4].Value.ToString() + "',N'" + dgvNVtheoQTDT.Rows[i].Cells[5].Value.ToString() + "',N'" + dgvNVtheoQTDT.Rows[i].Cells[6].Value.ToString() + "',N'" + dgvNVtheoQTDT.Rows[i].Cells[7].Value.ToString() + "')";
                    dtBase.CapNhat(sql1);
                }
            }
            if (dgvNVtheoQTDT.DataSource != null)
            {

                FormReportNVtrongQTDT formReport = new FormReportNVtrongQTDT();
                formReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu không thể xuất báo cáo ");
            }
            DialogResult dr = MessageBox.Show("Ok", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                string sql2 = "delete ReportNVtrongQTDT";
                dtBase.CapNhat(sql2);
            }
        }
    }
}
