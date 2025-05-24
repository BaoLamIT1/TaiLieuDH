using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lan1
{
    public partial class TimKiem1 : Form
    {
        ProcessDataBase nhanvien = new ProcessDataBase();
        public TimKiem1()
        {
            InitializeComponent();
        }

        bool kiemtradl()
        {
			bool k = true; string sql;
			if (txtma.Text.Trim().Equals(""))
			{ MessageBox.Show("Hãy nhập đủ dữ liệu ", "Thông báo !"); k = false; }
			else
			{
				DataTable tb = nhanvien.DocBang("SELECT * FROM HoSoNhanVien where MaNhanVien = '" + int.Parse(txtma.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					sql = "SELECT QuaTrinhDaoTao.MaQuaTrinhDaoTao, QuaTrinhDaoTao.TuNgay, QuaTrinhDaoTao.DenNgay, QuaTrinhDaoTao.MaTruongDaoTao, QuaTrinhDaoTao.MaHinhThuc, QuaTrinhDaoTao.MaNganhDT, QuaTrinhDaoTao.MaXepLoai, QuaTrinhCongTac.MaQuaTrinhCongTac, QuaTrinhCongTac.TuNgay, QuaTrinhCongTac.DenNgay, QuaTrinhCongTac.MaPhongBan, QuaTrinhCongTac.MaChucVu " +
	 "FROM QuaTrinhDaoTao JOIN HoSoNhanVien ON QuaTrinhDaoTao.MaNhanVien = HoSoNhanVien.MaNhanVien JOIN QuaTrinhCongTac ON QuaTrinhCongTac.MaNhanVien = HoSoNhanVien.MaNhanVien where QuaTrinhDaoTao.MaNhanVien = N'" + txtma.Text + "'";
				}
			}
			return k;
		}
        private void btntk_Click(object sender, EventArgs e)
        {

            if (kiemtradl() == true)
            {
                string sql;

                sql = "SELECT QuaTrinhDaoTao.MaQuaTrinhDaoTao, QuaTrinhDaoTao.TuNgay, QuaTrinhDaoTao.DenNgay, QuaTrinhDaoTao.MaTruongDaoTao, QuaTrinhDaoTao.MaHinhThuc, QuaTrinhDaoTao.MaNganhDT, QuaTrinhDaoTao.MaXepLoai, QuaTrinhCongTac.MaQuaTrinhCongTac, QuaTrinhCongTac.TuNgay, QuaTrinhCongTac.DenNgay, QuaTrinhCongTac.MaPhongBan, QuaTrinhCongTac.MaChucVu " +
    "FROM QuaTrinhDaoTao JOIN HoSoNhanVien ON QuaTrinhDaoTao.MaNhanVien = HoSoNhanVien.MaNhanVien JOIN QuaTrinhCongTac ON QuaTrinhCongTac.MaNhanVien = HoSoNhanVien.MaNhanVien where QuaTrinhDaoTao.MaNhanVien = N'" + txtma.Text + "'";
                if (txtma.Text != "")
                {
                    if (nhanvien.DocBang(sql).Rows.Count == 0)
                    {
                        MessageBox.Show("Mã nhân viên :" + txtma.Text + " này không tồn tại");
                    }


                    nv1.DataSource = null;
                    nv1.DataSource = nhanvien.DocBang(sql);

                    nv1.Columns[0].HeaderText = "mã quá trình đào tạo";
                    nv1.Columns[1].HeaderText = "ngày bắt đầu đào tạo";
                    nv1.Columns[2].HeaderText = "ngày kết thúc đào tạo";
                    nv1.Columns[3].HeaderText = "mã trường đào tạo";
                    nv1.Columns[4].HeaderText = "mã hình thức";
                    nv1.Columns[5].HeaderText = "mã ngành đào tạo";
                    nv1.Columns[6].HeaderText = "mã xếp loại";
                    nv1.Columns[7].HeaderText = "Mã quá trình công tác ";
                    nv1.Columns[8].HeaderText = "ngày bắt đầu công tác";
                    nv1.Columns[9].HeaderText = "đến ngày";
                    nv1.Columns[10].HeaderText = "mã phòng ban";
                    nv1.Columns[11].HeaderText = "mã chức vụ";

                    nv1.Columns[0].DataPropertyName = "MaQuaTrinhDaoTao";
                    nv1.Columns[1].DataPropertyName = "TuNgay";
                    nv1.Columns[2].DataPropertyName = "DenNgay";
                    nv1.Columns[3].DataPropertyName = "MaTruongDaoTao";
                    nv1.Columns[4].DataPropertyName = "MaHinhThuc";
                    nv1.Columns[5].DataPropertyName = "MaNganhDT";
                    nv1.Columns[6].DataPropertyName = "MaXepLoai";
                    nv1.Columns[7].DataPropertyName = "MaQuaTrinhCongTac";
                    nv1.Columns[8].DataPropertyName = "TuNgay";
                    nv1.Columns[9].DataPropertyName = "DenNgay";
                    nv1.Columns[10].DataPropertyName = "MaPhongBan";
                    nv1.Columns[11].DataPropertyName = "MaChucVu";

                }
            }



        }
    }
}