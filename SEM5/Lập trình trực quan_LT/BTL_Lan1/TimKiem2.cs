using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lan1
{
    public partial class TimKiem2 : Form
    {
		ProcessDataBase dtBase = new ProcessDataBase();
		public TimKiem2()
        {
            InitializeComponent();
        }
        private void TimKiem2_Load(object sender, EventArgs e)
        {

        }
		bool kiemtradl()
		{
			bool k = true;
			if (txtTenNhanVien.Text.Trim().Equals("") && txtChucVu.Text.Trim() == "" && txtPhongBan.Text.Trim() == ""
				&& txtNgoaiNgu.Text.Trim() == "" && txtHocVan.Text.Trim() == "")

			{ MessageBox.Show("Hãy nhập đủ dữ liệu "); k = false; }


			return k;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (kiemtradl() == true)
			{
				string sql;

				sql = "select HoSoNhanVien.MaNhanVien, HoSoNhanVien.HoTen, HoSoNhanVien.MaGioiTinh, HoSoNhanVien.MaChucVu, HoSoNhanVien.MaDanToc, HoSoNhanVien.NgaySinh, HoSoNhanVien.QueQuan, HoSoNhanVien.MaNoiSinh, HoSoNhanVien.DiaChi, HoSoNhanVien.DienThoai, HoSoNhanVien.SoCMND, HoSoNhanVien.MaPhongBan, HoSoNhanVien.MaHocVan, HoSoNhanVien.MaChuyenMon, HoSoNhanVien.VoChong, HoSoNhanVien.Con from HoSoNhanVien join NV_NgoaiNgu on HoSoNhanVien.MaNhanVien=NV_NgoaiNgu.MaNhanVien";


				if (txtTenNhanVien.Text != "")
				{
					sql = sql + " where HoTen like  N'%" + txtTenNhanVien.Text + "%'";
					if (dtBase.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Ten nhan vien:" + txtTenNhanVien.Text + " nay khong ton tai trong danh sach");
					}
				}
				if (txtPhongBan.Text != "")
				{
					sql = sql + " and HoSoNhanVien.MaPhongBan = '" + txtPhongBan.Text + "'";
					if (dtBase.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Ma Phong Ban:" + txtPhongBan.Text + " nay khong ton tai trong danh sach");
					}
				}
				if (txtChucVu.Text != "")
				{
					sql = sql + " and HoSoNhanVien.MaChucVu = '" + txtChucVu.Text + "'";

					if (dtBase.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Ma Chuc Vu: " + txtChucVu.Text + " nay khong ton tai trong danh sach");
					}
				}
				if (txtHocVan.Text != "")
				{
					sql = sql + " and HoSoNhanVien.MaHocVan = '" + txtHocVan.Text + "'";

					if (dtBase.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Ma Hoc Van:" + txtHocVan.Text + " nay khong ton tai trong danh sach");
					}
				}

				if (txtNgoaiNgu.Text != "")
				{
					sql = sql + " and NV_NgoaiNgu.MaNgoaiNgu = '" + txtNgoaiNgu.Text + "'";

					if (dtBase.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Ma Ngoai Ngu:" + txtNgoaiNgu.Text + " nay khong ton tai trong danh sach");
					}
				}

				dgvTimKiemHSNV.DataSource = null;
				dgvTimKiemHSNV.DataSource = dtBase.DocBang(sql);


			}
		}
		
		// reset các giá trị trong textbox và combobox

	}
}
