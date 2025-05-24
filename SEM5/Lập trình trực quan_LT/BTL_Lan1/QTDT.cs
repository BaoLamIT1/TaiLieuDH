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
    public partial class QTDT : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
       
        public QTDT()
        {
            InitializeComponent();
        }
		private void QTDT_Load(object sender, EventArgs e)
		{
			dgvQTDT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhDaoTao");
		}
		bool kiemtradl()
		{
			bool k = true;
			if (txtMaQTDT.Text.Trim() == "" || txtMaNV.Text.Trim()=="" || 
				dtpNgayBD.Value.Date.ToString() =="" || dtpNgayKT.Value.Date.ToString() == "" ||
				cmbMaTruongDT.Text.Trim() == "" || cmbMaHinhThuc.Text.Trim() == "" || 
				cmbMaNganhDT.Text.Trim() == "" ||cmbMaXepLoai.Text.Trim() == "")
			{ MessageBox.Show("Hãy nhập đủ dữ liệu ", "Thông báo !"); k = false; }
			else
			{
				DataTable tb = pd.DocBang("SELECT * FROM QuaTrinhDaoTao where MaNhanVien = '" + int.Parse(txtMaNV.Text) + "'");
				if (tb.Rows.Count > 0)
				{
					MessageBox.Show("Mã nhân viên này đã tồn tại "); k = false;
				}
			}
			return k;
		}
		private void btnThemMoi_Click(object sender, EventArgs e)
        {
			try
			{
                string sql = "INSERT INTO QuaTrinhDaoTao(MaQuaTrinhDaoTao, MaNhanVien, TuNgay, DenNgay, MaTruongDaoTao, MaHinhThuc, MaNganhDT, MaXepLoai) " +
							"values (N'" + txtMaQTDT.Text + "', N'" + txtMaNV.Text.ToString() + "', N'"
							+ dtpNgayBD.Value.Date + "', N'" + dtpNgayKT.Value.Date + "',N'" + cmbMaTruongDT.Text + "', N'" + cmbMaHinhThuc.Text + "', N'"
							+ cmbMaNganhDT.Text + "', N'" + cmbMaXepLoai.Text + "')";
							pd.CapNhat(sql);
                dgvQTDT.DataSource = pd.DocBang("select * from QuaTrinhDaoTao");
				MessageBox.Show("Thêm Thành Công");
            }
			catch(Exception ex) {
                MessageBox.Show("Lỗi!!!"+ex.Message);
            }
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				pd.CapNhat("DELETE QuaTrinhDaoTao WHERE MaNhanVien ='" + txtMaNV.Text.ToString() + "'");
				MessageBox.Show("Xoá thành công");
			}
			dgvQTDT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhDaoTao");
		}

		private void dgvQTDT_Click(object sender, EventArgs e)
		{
			txtMaQTDT.Text = dgvQTDT.CurrentRow.Cells[0].Value.ToString();
			txtMaNV.Text = dgvQTDT.CurrentRow.Cells[1].Value.ToString();

			//txtMaNV.Enabled = false;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
            try
            {
                pd.CapNhat("UPDATE QuaTrinhDaoTao SET MaNhanVien='" + txtMaNV.Text.ToString() + "',TuNgay='" + dtpNgayBD.Value.Date
            + "',DenNgay='" + dtpNgayKT.Value.Date + "',MaTruongDaoTao='" + cmbMaTruongDT.Text + "',MaHinhThuc='" + cmbMaHinhThuc.Text
            + "',MaNganhDT='" + cmbMaNganhDT.Text + "',MaXepLoai='" + cmbMaXepLoai.Text
            + "'WHERE MaQuaTrinhDaoTao ='" + txtMaQTDT.Text + "'");
                dgvQTDT.DataSource = pd.DocBang("SELECT * FROM QuaTrinhDaoTao");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!! Trùng mã Quá trình đào tạo. Vui lòng nhập mã khác" + ex.Message);
            }
		}

		private void cmbMaTruongDT_MouseClick(object sender, MouseEventArgs e)
		{
			cmbMaTruongDT.DataSource = pd.DocBang("SELECT * FROM TruongDaoTao" );
			cmbMaTruongDT.ValueMember = "MaTruongDaoTao";
			cmbMaTruongDT.DisplayMember = "MaTruongDaoTao";
		}

		private void cmbMaHinhThuc_MouseClick(object sender, MouseEventArgs e)
		{
			cmbMaHinhThuc.DataSource = pd.DocBang("SELECT * FROM HinhThuc");
			cmbMaHinhThuc.ValueMember = "MaHinhThuc";
			cmbMaHinhThuc.DisplayMember = "MaHinhThuc";
		}

		private void cmbMaNganhDT_MouseClick(object sender, MouseEventArgs e)
		{
			cmbMaNganhDT.DataSource = pd.DocBang("SELECT * FROM NganhDaoTao");
			cmbMaNganhDT.ValueMember = "MaNganhDT";
			cmbMaNganhDT.DisplayMember = "MaNganhDT";
		}

		private void cmbMaXepLoai_MouseClick(object sender, MouseEventArgs e)
		{
			cmbMaXepLoai.DataSource = pd.DocBang("SELECT * FROM XepLoai");
			cmbMaXepLoai.ValueMember = "MaXepLoai";
			cmbMaXepLoai.DisplayMember = "MaXepLoai";
		}

		
	}
}
