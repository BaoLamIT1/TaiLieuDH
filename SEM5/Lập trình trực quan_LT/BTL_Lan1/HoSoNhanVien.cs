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

namespace BTL_Lan1
{
    public partial class HoSoNhanVien : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public HoSoNhanVien()
        {
            InitializeComponent();
        }
        bool kiemtradl()
        {
            bool k = true;
            if (txtMaNV.Text.Trim().Equals("") || txtHoTen.Text.Trim() == "" || cmbGioiTinh.Text.Trim() == "" || cmbMaChucVu.Text.Trim() == ""||
                txtMaTonGiao.Text.Trim()=="" || dtpNgaySinh.Value.Date.ToString() ==""|| txtMaDT.Text.Trim() == "" ||  txtQueQuan.Text.Trim() == ""||
                txtMaNoiSinh.Text.Trim() == ""|| txtDiaChi.Text.Trim() == ""|| txtSoDT.Text.Trim() == "" || txtCCCD.Text.Trim() == ""|| 
                cmbMaPB.Text.Trim() == ""|| cmbMaHocVan.Text.Trim() == ""|| cmbMaChuyenMon.Text.Trim() == "" || txtVkCK.Text.Trim() == "" ||txtConCai.Text.Trim() == "")
             
            { MessageBox.Show("Hãy nhập đủ dữ liệu ","Thông báo !"); k = false; }
            else
            {
                DataTable tb = pd.DocBang("SELECT * FROM HoSoNhanVien where MaNhanVien = '" + int.Parse(txtMaNV.Text) + "'");
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại "); k = false;
                }
            }
            return k;
        }
        private void HoSoNhanVien_Load(object sender, EventArgs e)
        {
            dgvHoSoNV.DataSource = pd.DocBang("SELECT * FROM HoSoNhanVien");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtradl() == true)
            {
                string sql = "INSERT INTO HoSoNhanVien(MaNhanVien, HoTen, MaGioiTinh, MaChucVu, MaTonGiao, NgaySinh, MaDanToc, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND ,MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con ) " +
                    "values (N'" + txtMaNV.Text.ToString() + "', N'" + txtHoTen.Text + "', N'" 
                    + int.Parse(cmbGioiTinh.Text) + "', N'" + cmbMaChucVu.Text + "',N'" + txtMaTonGiao.Text + "', N'"+ dtpNgaySinh.Value.Date + "', N'" 
                    + txtMaDT.Text + "', N'" + txtQueQuan.Text + "', N'" +txtMaNoiSinh.Text +"', N'" + txtDiaChi.Text + "',N'" + txtSoDT.Text + "',N'" 
                    + txtCCCD.Text + "', N'" + cmbMaPB.Text + "', N'" + cmbMaHocVan.Text + "', N'" + cmbMaChuyenMon.Text + "', N'" + txtVkCK.Text 
                    + "', N'" + txtConCai.Text + "')";
                pd.CapNhat(sql);
                dgvHoSoNV.DataSource = pd.DocBang("select * from HoSoNhanVien");
            }
        }
		void ResetValue()
		{
			txtMaNV.Text = "";
			txtHoTen.Text = "";
            cmbGioiTinh.ValueMember = "";
            cmbMaChucVu.Text = ""; txtMaTonGiao.Text = "";
            txtMaDT.Text = ""; txtQueQuan.Text = ""; txtQueQuan.Text = ""; txtMaNoiSinh.Text = ""; txtDiaChi.Text = "";
            txtSoDT.Text = ""; txtCCCD.Text = ""; cmbMaPB.Text = ""; cmbMaHocVan.Text = ""; cmbMaChuyenMon.Text = "";
            txtVkCK.Text = ""; txtConCai.Text = "";

		}

		private void btnSua_Click(object sender, EventArgs e)
        {
            //   string sql = "";
            //   sql = "UPDATE HoSoSinhVien SET HoTen ='" + txtHoTen.Text +
            //"',MaGioiTinh='" + int.Parse(cmbGioiTinh.Text) + "',MaChucVu='" + cmbMaChucVu.Text + "',MaTonGiao='" + txtMaTonGiao.Text
            //+ "',NgaySinh='" + dtpNgaySinh.Value.Date + "',MaDanToc='" + txtMaDT.Text + "',QueQuan='" + txtQueQuan.Text + "',MaNoiSinh='" + txtMaNoiSinh.Text
            //+ "',DiaChi='" + txtDiaChi.Text + "',DienThoai='" + txtSoDT.Text + "',SoCMND='" + txtCCCD.Text + "',MaPhongBan='" + cmbMaPB.Text
            //+ "',MaHocVan='" + cmbMaHocVan.Text + "',MaChuyenMon='" + cmbMaChuyenMon.Text + "',VoChong='" + txtVkCK.Text + "',Con='" + txtConCai.Text +
            //"' WHERE MaNhanVien='" + txtMaNV.Text + "'";
            //   pd.CapNhat(sql); //thực hiện lệnh sql
            //   pd.DocBang(sql); //hiển thị lại thông tin lên DataGridView

            pd.CapNhat("UPDATE HoSoNhanVien SET HoTen ='" + txtHoTen.Text +
         "',MaGioiTinh='" + int.Parse(cmbGioiTinh.Text) + "',MaChucVu='" + cmbMaChucVu.Text + "',MaTonGiao='" + txtMaTonGiao.Text
         + "',NgaySinh='" + dtpNgaySinh.Value.Date + "',MaDanToc='" + txtMaDT.Text + "',QueQuan='" + txtQueQuan.Text + "',MaNoiSinh='" + txtMaNoiSinh.Text
         + "',DiaChi='" + txtDiaChi.Text + "',DienThoai='" + txtSoDT.Text + "',SoCMND='" + txtCCCD.Text + "',MaPhongBan='" + cmbMaPB.Text
         + "',MaHocVan='" + cmbMaHocVan.Text + "',MaChuyenMon='" + cmbMaChuyenMon.Text + "',VoChong='" + txtVkCK.Text + "',Con='" + txtConCai.Text +
         "' WHERE MaNhanVien='" + txtMaNV.Text + "'");

            dgvHoSoNV.DataSource = pd.DocBang("Select * from HoSoNhanVien");
            btnSua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                pd.CapNhat("DELETE HoSoNhanVien WHERE MaNhanVien ='" + txtMaNV.Text.ToString() + "'");
                MessageBox.Show("Xoá thành công");
            }
            dgvHoSoNV.DataSource = pd.DocBang("SELECT * FROM HoSoNhanVien");
        }

        private void GridViewHoSoNV_Click(object sender, EventArgs e)
        {
			txtMaNV.Text = dgvHoSoNV.CurrentRow.Cells[0].Value.ToString();
			txtHoTen.Text = dgvHoSoNV.CurrentRow.Cells[1].Value.ToString();
			txtMaTonGiao.Text = dgvHoSoNV.CurrentRow.Cells[5].Value.ToString();
			txtMaDT.Text = dgvHoSoNV.CurrentRow.Cells[4].Value.ToString();
			txtQueQuan.Text = dgvHoSoNV.CurrentRow.Cells[7].Value.ToString();
			txtMaNoiSinh.Text = dgvHoSoNV.CurrentRow.Cells[8].Value.ToString();
			txtDiaChi.Text = dgvHoSoNV.CurrentRow.Cells[9].Value.ToString();
			txtSoDT.Text = dgvHoSoNV.CurrentRow.Cells[10].Value.ToString();
			txtCCCD.Text = dgvHoSoNV.CurrentRow.Cells[11].Value.ToString();
			txtVkCK.Text = dgvHoSoNV.CurrentRow.Cells[15].Value.ToString();
			txtConCai.Text = dgvHoSoNV.CurrentRow.Cells[16].Value.ToString();
			//txtMaNV.Enabled = false;
			//btnThem.Enabled = false;
			btnXoa.Enabled = true;
			btnSua.Enabled = true;

		}

        private void GridViewHoSoNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // kiểm tra giá trị e.Value có rỗng hoặc không tồn tại, e.Value = "NULL" hiện thị giá trị là null khi cell rỗng
            if (e.Value == DBNull.Value) { e.Value = "NULL"; e.FormattingApplied = true; }
		}

		private void cmbMaChuyenMon_MouseClick(object sender, MouseEventArgs e)
		{
            cmbMaChuyenMon.DataSource = pd.DocBang("SELECT * FROM ChuyenMon");
            cmbMaChuyenMon.ValueMember = "MaChuyenMon";
			cmbMaChuyenMon.DisplayMember = "MaChuyenMon";
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
			cmbMaPB.DisplayMember = "MaChucVu";
		}

		private void cmbMaHocVan_MouseClick(object sender, MouseEventArgs e)
		{
            cmbMaHocVan.DataSource = pd.DocBang("SELECT * FROM HocVan");
            cmbMaHocVan.ValueMember = "MaHocVan";
			cmbMaPB.DisplayMember = "MaHocVan";
		}

       
    }
}
