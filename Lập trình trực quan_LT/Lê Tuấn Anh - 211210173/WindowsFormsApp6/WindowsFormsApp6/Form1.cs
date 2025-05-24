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

namespace WindowsFormsApp6
{
	public partial class Form1 : Form
	{
		ProcessDatabase db = new ProcessDatabase();
		string imagePath;
		//SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\WindowsFormsApp6\WindowsFormsApp6\Database1.mdf;Integrated Security=True");

		public void check()
		{
			if (rbtnNam.Checked == true)
				rbtnNu.Checked = false;
			if (rbtnNu.Checked == true)
				rbtnNam.Checked = false;
		}

		public Form1()
		{
			InitializeComponent();
			check();
		}

		public void DocBang()
		{
			dgv.DataSource = db.DocBang("select * from NhanVien");
			dgv.Columns[0].HeaderText = "Mã NV";
			dgv.Columns[1].HeaderText = "Tên NV";
			dgv.Columns[2].HeaderText = "Số ĐT";
			dgv.Columns[3].HeaderText = "Giới tính";
			dgv.Columns[4].HeaderText = "Phòng ban";
			dgv.Columns[5].HeaderText = "Mức lương";
			dgv.Columns[6].HeaderText = "Ảnh";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			DocBang();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				this.Close();
		}

		private void dgv_Click(object sender, EventArgs e)
		{
			txtMaNV.Text = dgv.CurrentRow.Cells[0].Value.ToString();
			txtTenNV.Text = dgv.CurrentRow.Cells[1].Value.ToString();
			txtSoDT.Text = dgv.CurrentRow.Cells[2].Value.ToString();
			if (dgv.CurrentRow.Cells[3].Value.ToString() == "Nam")
				rbtnNam.Checked = true;
			else
				rbtnNu.Checked = true;
			cbbPhongBan.Text = dgv.CurrentRow.Cells[4].Value.ToString();
			txtMucLuong.Text = dgv.CurrentRow.Cells[5].Value.ToString();
			if (dgv.CurrentRow.Cells[6].Value.ToString() != "")
			{
				imagePath = dgv.CurrentRow.Cells[6].Value.ToString();
				Image image = Image.FromFile(imagePath);
				pictureBox.Image = image;
				btnSua.Enabled = true;
				btnXoa.Enabled = true;
				btnThem.Enabled = false;
			}
			else pictureBox.Image = null;
		}

		private void btnAnh_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				imagePath = openFileDialog.FileName;
				Image image = Image.FromFile(imagePath);
				pictureBox.Image = image;
			}
		}

		public bool ktraDL()
		{
			bool k = true;
			if (txtMaNV.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập mã nhân viên");
				k = false;
			}
			if (txtTenNV.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập tên nhân viên");
				k = false;
			}
			if (rbtnNam.Checked == false && rbtnNu.Checked == false)
			{
				MessageBox.Show("Hãy chọn giới tính");
				k = false;
			}
			if (txtMucLuong.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập mức lương");
				k = false;
			}
			return k;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (ktraDL())
			{
				string sql, GioiTinh;
				if (rbtnNam.Checked == true)
					GioiTinh = "Nam";
				else GioiTinh = "Nữ";
				sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txtMaNV.Text + "'";
				DataTable table = db.DocBang(sql);
				if (table.Rows.Count > 0)
				{
					MessageBox.Show("Mã nhân viên này đã tồn tại");
					txtMaNV.Focus();
					return;
				}
				sql = "INSERT INTO NhanVien VALUES ('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" +
				txtSoDT.Text + "',N'" + GioiTinh + "',N'" + cbbPhongBan.Text + "'," + txtMucLuong.Text +
				",'" + imagePath + "')";
				db.CapNhat(sql);
				DocBang();
			}	
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (ktraDL())
			{
				string sql, GioiTinh;
				if (rbtnNam.Checked == true)
					GioiTinh = "Nam";
				else GioiTinh = "Nữ";
				sql = "UPDATE NhanVien SET TenNV=N'" + txtTenNV.Text + "',SDT=N'" + txtSoDT.Text +
					"',GioiTinh=N'" + GioiTinh +
					"',PhongBan=N'" + cbbPhongBan.Text + "',MucLuong=" + int.Parse(txtMucLuong.Text) +
					",Anh='" + imagePath + "' WHERE MaNV='" + txtMaNV.Text + "'";
				db.CapNhat(sql);
				DocBang();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			string sql;
			if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				sql = "DELETE NhanVien WHERE MaNV='" + txtMaNV.Text + "'";
				db.CapNhat(sql);
				DocBang();
				pictureBox.Image = null;
			}
		}

		private void txtMaNV_Click(object sender, EventArgs e)
		{
			btnThem.Enabled = true;
		}
	}
}
