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
    public partial class FormDangNhap : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        string sql;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            string mk = txtMK.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản ");
                return;
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu tài khoản ");
                return;
            }

            else
            {
                sql = "select * from TaiKhoan where TenTaiKhoan = '" + tentk + "'and MatKhau ='" + mk + "'";
                DataTable dt = new DataTable();
                dt = db.DocBang(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 form = new Form1();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không chính xác ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void linkLabel_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMK formQuenMK = new FormQuenMK();
            formQuenMK.ShowDialog();
        }

        private void linkLabel_DK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }
    }
}
