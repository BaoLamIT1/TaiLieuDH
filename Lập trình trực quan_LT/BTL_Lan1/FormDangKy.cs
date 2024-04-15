using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lan1
{
    public partial class FormDangKy : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        string sql;
        public FormDangKy()
        {
            InitializeComponent();
        }

        public bool checkAccount(String ac)// check mk va tk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)// check email
        {
            return Regex.IsMatch(em, @"^[\w_.]{3,20}@gmail.com(.vn|)$");
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            string mk = txtMK.Text;
            string xnmk = txtXNMK.Text;
            string email = txtEmail.Text;

            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản có độ từ 6-24 ký tự , với các ký tự chữ và số "); return; }
            if (!checkAccount(mk)) { MessageBox.Show("Vui lòng nhập mật khẩu có độ từ 6-24 ký tự , với các ký tự chữ và số "); return; }
            if (mk != xnmk) { MessageBox.Show("Nhập mật khẩu xác nhận và mật khẩu không trùng!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng form email!"); return; }
            DataTable dt = new DataTable();
            sql = "select * from TaiKhoan where Email = '" + email + "'";
            dt = db.DocBang(sql);
            if (dt.Rows.Count != 0) { MessageBox.Show("Email đã tồn tại ,Yêu cầu nhập email khác"); return; }
            try
            {
                sql = "insert into TaiKhoan values ('" + tentk + "','" + mk + "','" + email + "')";
                db.CapNhat(sql);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
;

            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, Vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
