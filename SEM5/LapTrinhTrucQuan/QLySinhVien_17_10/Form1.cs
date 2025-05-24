using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace QLySinhVien_17_10
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select *from tblSinhvien");
           
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = string.Empty;
            txtHoten.Text = string.Empty;
            txtNgaysinh.Text = string.Empty;
            txtKhoa.Text = string.Empty;    
            txtLop.Text = string.Empty;
            txtDiachi.Text = string.Empty;
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblSinhVien WHERE MaSV='" + txtMaSV.Text + "'";
                pd.RunSQL(sql);
                pd.DocBang(sql) ;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "UPDATE tblSinhVien SET Hoten='" + txtHoten.Text +
            "',Ngaysinh='" + txtNgaysinh.Text +
            "',Khoa='" + txtKhoa.Text + "',Lop='" + txtLop.Text +
            "',Diachi='" + txtDiachi.Text + "' WHERE MaSV='" + txtMaSV.Text + "'";
            pd.RunSQL(sql); //thực hiện lệnh sql
            pd.DocBang(sql); //hiển thị lại thông tin lên DataGridView
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtMaSV.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnMoi.Enabled = false;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
