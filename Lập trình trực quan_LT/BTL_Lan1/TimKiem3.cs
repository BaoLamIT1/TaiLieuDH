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
	public partial class TimKiem3 : Form
	{
		ProcessDataBase pd = new ProcessDataBase();
		public TimKiem3()
		{
			InitializeComponent();
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtMaNhanVien.Text.Trim().Equals("") && txtTruong.Text.Trim() == "" && txtHinhThuc.Text.Trim() == "")
			{ MessageBox.Show("Hãy nhập đủ dữ liệu "); k = false; }
			return k;
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (kiemtradl() == true)
			{
				string sql;

				sql = "select QuaTrinhDaoTao.MaQuaTrinhDaoTao, QuaTrinhDaoTao.MaNhanVien, QuaTrinhDaoTao.TuNgay, QuaTrinhDaoTao.DenNgay, QuaTrinhDaoTao.MaTruongDaoTao, QuaTrinhDaoTao.MaHinhThuc, QuaTrinhDaoTao.MaNganhDT, QuaTrinhDaoTao.MaXepLoai from QuaTrinhDaoTao join TruongDaoTao on QuaTrinhDaoTao.MaTruongDaoTao=TruongDaoTao.MaTruongDaoTao join HinhThuc on QuaTrinhDaoTao.MaHinhThuc=HinhThuc.MaHinhThuc";


				if (txtMaNhanVien.Text != "")
				{
					sql = sql + " where QuaTrinhDaoTao.MaNhanVien= '" + txtMaNhanVien.Text + "'";
					if (pd.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Mã nhân viên :" + txtMaNhanVien.Text + " này không tồn tại trong danh sách");
					}
				}
				if (txtTruong.Text != "")
				{
					sql = sql + " and TruongDaoTao.MaTruongDaoTao = '" + txtTruong.Text + "'";
					if (pd.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Trường đào tạo :" + txtTruong.Text + " này không tồn tại trong danh sách");
					}
				}
				if (txtHinhThuc.Text != "")
				{
					sql = sql + " and HinhThuc.MaHinhThuc = '" + txtHinhThuc.Text + "'";

					if (pd.DocBang(sql).Rows.Count == 0)
					{
						MessageBox.Show("Hình thức đào tạo : " + txtHinhThuc.Text + " này không tồn tại trong danh sách");
					}
				}

				dgvTimKiemQTDT.DataSource = null;
				dgvTimKiemQTDT.DataSource = pd.DocBang(sql);


			}
		}

	

		
	}
}
