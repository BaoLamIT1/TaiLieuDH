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
    public partial class FormQuenMK : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        string sql;
        public FormQuenMK()
        {
            InitializeComponent();
            label2.Text = "";

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đã đăng ký tài khoản!"); }
            else
            {
                sql = "SELECT * from TaiKhoan where Email = '" + email + "'";
                DataTable dt = new DataTable();
                dt = db.DocBang(sql);
                if (dt.Rows.Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    sql = "SELECT MatKhau from TaiKhoan where Email = '" + email + "'";
                    dt = db.DocBang(sql);

                    label2.Text = "Mật khẩu:" + dt.Rows[0].Field<string>(columnName: "MatKhau");

                }
                else
                {
                    label2.ForeColor = Color.Red;
                    MessageBox.Show("Email này chưa đăng ký tài khoản!");
                }
            }
        }
    }
}
