using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_5_9
{
    public partial class Form1 : Form
    {
        List<MatHang> ds = new List<MatHang>();
        public Form1()
        {
            InitializeComponent();
            ds = new List<MatHang>();
            ds.Add(new MatHang("Ma 1", "Giày", 1000));
            ds.Add(new MatHang("Ma 2", "áo", 100));
            ds.Add(new MatHang("Ma 3", "quần", 400));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kt() == true)
            {
                MatHang x = new MatHang(txtMa.Text, txtTen.Text, int.Parse(txtSL.Text));
                if (ktrtrung(txtMa.Text) == false)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = txtMa.Text;
                    item.SubItems.Add(txtTen.Text);
                    item.SubItems.Add(txtSL.Text);
                    listView1.Items.Add(item);
                    ds.Add(x);
                }
                else MessageBox.Show("mã trùng");
            }
            else
            {
                MessageBox.Show("bạn cần nhập đủ thông tin");
            }
        }
        private bool ktrtrung(string ma)
        {
            foreach (MatHang x in ds)
            {
                if (x.Contains(ma) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private bool kt()
        {
            if (txtMa.Text.Trim().Length == 0 ||
               txtTen.Text.Trim().Length == 0 ||
               txtSL.Text.Trim().Length == 0)
                return false;
            return true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("ban co muon xoa ", "tb", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                }
            }
        }
        //Nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = txtMa.Text;
                listView1.Items[i].SubItems[1].Text = txtTen.Text;
                listView1.Items[i].SubItems[2].Text = txtSL.Text;
            }

        }
        //Hiển thị thay đổi lựa chon listview item lên textbox
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem ls = new ListViewItem();
            if (listView1.SelectedItems.Count > 0)
            {
                ls = listView1.SelectedItems[0];
                txtMa.Text = ls.Text;
                txtTen.Text = ls.SubItems[1].Text;
                txtSL.Text = ls.SubItems[2].Text;
            }
            else MessageBox.Show("hay chon dong");
        }

    }
}

