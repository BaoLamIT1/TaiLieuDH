using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace BaiThongKeBTL
{
    public partial class FormTKNVtheoNNvaCM : Form
    {

        ProcessDatabase dtBase = new ProcessDatabase();
        string sql;
        
        

        public FormTKNVtheoNNvaCM()
        {
            InitializeComponent();
        }
        internal class ProcessDatabase
        {
            string stringcon = "Data Source=(local);Initial Catalog=BTL_QuanLyNS_Test;Integrated Security=True";
            SqlConnection con;
            public void Ketnoi()
            {
                con = new SqlConnection(stringcon);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            public void DongKetNoi()
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
                con.Dispose();
            }
            public DataTable DocBang(string sql)
            {
                DataTable tb = new DataTable();
                Ketnoi();
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(tb);
                DongKetNoi();
                return tb;
            }
            public void CapNhat(string sql)
            {
                SqlCommand cmm = new SqlCommand();
                Ketnoi();
                cmm.CommandText = sql;
                cmm.Connection = con;
                cmm.ExecuteNonQuery();
                DongKetNoi();
            }
        }

        private void FormTKNVtheoNNvaCM_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                            FormBCQuaTrinhDT form = new FormBCQuaTrinhDT();
                form.Show();
        }

        private void cbChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChuyenMon_Click(object sender, EventArgs e)
        {

        }
        private void cbNgoaiNgu_MouseClick(object sender, MouseEventArgs e)
        {
            cbNgoaiNgu.DataSource = dtBase.DocBang("Select * from NgoaiNgu");
            cbNgoaiNgu.ValueMember = "MaNgoaiNgu";
            cbNgoaiNgu.DisplayMember = "TenNgoaiNgu";
        }

        private void cbChuyenMon_MouseClick(object sender, MouseEventArgs e)
        {
            cbChuyenMon.DataSource = dtBase.DocBang("Select * from ChuyenMon");
            cbChuyenMon.ValueMember = "MaChuyenMon";
            cbChuyenMon.DisplayMember = "TenChuyenMon";
        }
        private void btnHien_Click(object sender, EventArgs e)
        {
            if (cbChuyenMon.SelectedItem == null || cbNgoaiNgu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ");
            }
            else
            {
                sql = "select NV.MaNhanVien , NV.HoTen , NV.DiaChi, NV.NgaySinh,TNN.TenNgoaiNgu,CM.TenChuyenMon from HoSoNhanVien NV inner join ChuyenMon CM on NV.MaChuyenMon = CM.MaChuyenMon inner join NV_NgoaiNgu NN on NN.MaNhanVien = NV.MaNhanVien inner join NgoaiNgu TNN on TNN.MaNgoaiNgu = NN.MaNgoaiNgu where TNN.MaNgoaiNgu = N'" + cbNgoaiNgu.SelectedValue+ "' and CM.MaChuyenMon = N'"+ cbChuyenMon.SelectedValue+ "'";
                dgvNVTheoNNvaCM.DataSource = dtBase.DocBang(sql);
            }
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
                tenCuaHang.Value = "THỐNG KÊ CÁC NHÂN VIÊN THEO NGOẠI NGỮ VÀ CHUYÊN MÔN";

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
    }
}
