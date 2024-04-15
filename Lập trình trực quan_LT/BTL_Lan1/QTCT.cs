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
    public partial class QTCT : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public QTCT()
        {
            InitializeComponent();
        }

        private void QTCT_Load(object sender, EventArgs e)
        {
            dgvQTCT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhCongTac");
        }

		private void cmbMaPB_MouseClick(object sender, MouseEventArgs e)
		{
			cmbMaPB.DataSource = pd.DocBang("Select * from PhongBan");
			cmbMaPB.ValueMember = "MaPhongBan";
			cmbMaPB.DisplayMember = "MaPhongBan";

		}

		private void cmbMaChucVu_MouseClick(object sender, MouseEventArgs e)
		{
            cmbMaChucVu.DataSource = pd.DocBang("SELECT * FROM ChucVu");
            cmbMaChucVu.ValueMember = "MaChucVu";
			cmbMaPB.DisplayMember =  "MaChucVu";
		}
		bool checkdata()
		{
			bool k = true;
			if (txtMaNV.Text.Trim() == "" || txtMaQTCT.Text.Trim() == "" ||
				cmbMaPB.Text.Trim() == "" || cmbMaChucVu.Text.Trim() == "" |
				dtpNgayBD.Value.Date.ToString() == "" || dtpNgayKT.Value.Date.ToString() == "" )
			{ MessageBox.Show("Hãy nhập đủ dữ liệu ", "Thông báo !"); k = false; }
			else
			{
				DataTable tb = pd.DocBang("SELECT * FROM QuaTrinhCongTac where MaNhanVien = '" + int.Parse(txtMaNV.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					//MessageBox.Show("Mã nhân viên này đã tồn tại "); k = false;
					string sql = "INSERT INTO QuaTrinhCongTac(MaNhanVien, MaQuaTrinhCongTac, TuNgay, DenNgay, MaPhongBan, MaChucVu) " +
						"values (N'" + txtMaNV.Text.ToString() + "', N'" + txtMaQTCT.Text + "', N'"
						+ dtpNgayBD.Value.Date + "', N'" + dtpNgayKT.Value.Date + "',N'" + cmbMaPB.Text + "', N'" + cmbMaChucVu.Text + "')";
				}
			}
			return k;
		}
		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			try
			{
				if (checkdata() == true)
				{
					string sql = "INSERT INTO QuaTrinhCongTac(MaNhanVien, MaQuaTrinhCongTac, TuNgay, DenNgay, MaPhongBan, MaChucVu) " +
						"values (N'" + txtMaNV.Text.ToString() + "', N'" + txtMaQTCT.Text + "', N'"
						+ dtpNgayBD.Value.Date + "', N'" + dtpNgayKT.Value.Date + "',N'" + cmbMaPB.Text + "', N'" + cmbMaChucVu.Text + "')";
					pd.CapNhat(sql);
					dgvQTCT.DataSource = pd.DocBang("select * from QuaTrinhCongTac");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi!!!! Trùng mã Quá trình công tác. Vui lòng nhập mã khác"+ex.Message);
			}

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				pd.CapNhat("DELETE QuaTrinhCongTac WHERE MaNhanVien ='" + txtMaNV.Text.ToString() + "'");
				MessageBox.Show("Xoá thành công");
			}
			dgvQTCT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhCongTac");
		}

		private void dgvQTCT_Click(object sender, EventArgs e)
		{
			txtMaNV.Text = dgvQTCT.CurrentRow.Cells[0].Value.ToString();
			txtMaQTCT.Text = dgvQTCT.CurrentRow.Cells[1].Value.ToString();
			//txtMaNV.Enabled = false;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			pd.CapNhat("UPDATE QuaTrinhCongTac SET MaNhanVien='" + txtMaNV.Text.ToString() + "',TuNgay='" + dtpNgayBD.Value.Date
			+"',DenNgay='" + dtpNgayKT.Value.Date + "',MaPhongBan='" + cmbMaPB.Text + "',MaChucVu='" + cmbMaChucVu.Text 
			+ "' WHERE MaQuaTrinhCongTac ='" + txtMaQTCT.Text.ToString() + "'");
			dgvQTCT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhCongTac");
			btnSua.Enabled = true;
		}
	}
}
