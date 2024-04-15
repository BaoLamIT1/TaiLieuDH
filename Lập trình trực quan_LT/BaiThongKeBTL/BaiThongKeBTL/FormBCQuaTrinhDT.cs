using System;
using System.Drawing;
using System.Windows.Forms;
using static BaiThongKeBTL.FormTKNVtheoNNvaCM;
using Excel = Microsoft.Office.Interop.Excel;
namespace BaiThongKeBTL
{
    public partial class FormBCQuaTrinhDT : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        string sql;
        public FormBCQuaTrinhDT()
        {
            InitializeComponent();
        }

        private void FormBCQuaTrinhDT_Load(object sender, EventArgs e)
        {

        }

        private void btnHienMaNV_Click(object sender, EventArgs e)
        {

            if (txtMaNVKT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
            }
            else
            {
                sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0 and NV.MaNhanVien= '" + txtMaNVKT.Text + "'";
                dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);
            }
        }

        private void btnHienMaQTDT_Click(object sender, EventArgs e)
        {
            if (txtMaQTDTKT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã QTDT.");
            }
            else
            {
                sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0 and QTDT.MaQuaTrinhDaoTao='" + txtMaQTDTKT.Text + "'";
                dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);
            }
        }

        private void btnHien_Click(object sender, EventArgs e)
        {

            sql = "select  NV.MaNhanVien, NV.HoTen,QTDT.MaQuaTrinhDaoTao,QTDT.TuNgay,QTDT.DenNgay,TDT.TenTruongDaoTao,NDT.TenNganhDT,HT.TenHinhThuc from QuaTrinhDaoTao QTDT join HoSoNhanVien NV on NV.MaNhanVien= QTDT.MaNhanVien join HinhThuc HT on HT.MaHinhThuc= QTDT.MaHinhThuc join NganhDaoTao NDT on NDT.MaNganhDT = QTDT.MaNganhDT join TruongDaoTao TDT on TDT.MaTruongDaoTao = QTDT.MaTruongDaoTao where DATEDIFF(day, QTDT.DenNgay ,getdate())<0";
            dgvNVtheoQTDT.DataSource = dtBase.DocBang(sql);

        }

        private void btnXuat_Click(object sender, EventArgs e)
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
