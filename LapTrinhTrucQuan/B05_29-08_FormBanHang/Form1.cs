using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B05_29_08_FormBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addData()
        {
            lstDanhSachMatHang.Items.Add("Kỹ thuật lập trình c#");
            lstDanhSachMatHang.Items.Add("Tự học Visual C# trong 21 ngày");
            lstDanhSachMatHang.Items.Add("Bài tập C#");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 1");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 2");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 3");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 4");
            lstDanhSachMatHang.Items.Add("Tin học cơ bản");
            lstDanhSachMatHang.Items.Add("SQL server");
            lstDanhSachMatHang.Items.Add("Cơ bản về XML");
            lstDanhSachMatHang.Items.Add("Phân tích và thiết kế hệ thống");
            lstDanhSachMatHang.Items.Add("Sử dụng Word");
            lstDanhSachMatHang.Items.Add("Đến với Word 2003");

        }

        

        private void lstDanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDanhSachMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = lstDanhSachMatHang.SelectedItem.ToString();
            //tìm kiếm xem có mặt hàng nào cần mua
            int index = lstHangDatMua.FindString(curItem);
            //nếu mà không có thì in thông báo và thêm hàng đã đặt mua ngược lại thì báo đã có
            if (index == -1)
            {
                lstHangDatMua.Items.Add(curItem);
            }
            else
            {
                MessageBox.Show("Hàng đặt mua đã có rồi");
            }
        }

        private void lstHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string index = lstHangDatMua.SelectedItem.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                lstHangDatMua.Items.Remove(index);
            }
        }
        private string HinhThucLL()
        {
            string a = "";
            if (chbDienThoai.Checked == true)
            {
                a += "   " + chbDienThoai.Text;
            }
            if (chbFax.Checked == true)
            {
                a += "   " + chbFax.Text;
            }
            if (chbMail.Checked == true)
            {
                a += "   " + chbMail.Text;
            }
            return a;
        }
        private string ThanhToan()
        {
            string s = "";
            if (rdbTienMat.Checked == true)
            {
                s += rdbTienMat.Text;
            }
            else if (rdbTheTinDung.Checked == true)
            {
                s += rdbTheTinDung.Text;
            }
            else if (rdbSec.Checked == true)
            {
                s += rdbSec.Text;
            };
            return s;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Equals("") || txtDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông Báo");
                txtHoTen.Focus();
            }
            else
            {
                string sb = "";
                foreach (object item in lstHangDatMua.Items)
                {
                    sb += item.ToString();
                    sb += "\n";
                }
                sb += "Phương thức thanh toán: " + ThanhToan()
                    + "\nHình thức liên lạc: " + HinhThucLL();
                MessageBox.Show(sb);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
        }
    }
}
        
