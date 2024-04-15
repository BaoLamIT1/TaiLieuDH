using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Bai1
{
    public partial class Form1 : Form
    {
        List<PhongBan> ds = new List<PhongBan>();
        List<string> MaPhong = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ds.Add(new PhongBan("Mã phòng 1","Phòng kế hoạch"));
            ds.Add(new PhongBan("Mã phòng 2", "Phòng phát triển nhân lực"));
            ds.Add(new PhongBan("Mã phòng 3", "Phòng nhân sự"));
            ds.Add(new PhongBan("Mã phòng 4", "Phòng đối ngoại"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong ?", "Thong bao ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Ban co muon xoa ?", "Thong bao", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                }
            }
        }
        private bool check()
        {
            if (txtMa.Text.Trim().Length == 0 ||
                txtTen.Text.Trim().Length == 0)
                return false;
            return true;
        }
        private bool ktrtrung(string ma)
        {
            foreach (PhongBan x in ds)
            {
                if (x.Contains(ma) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                PhongBan pb = new PhongBan(txtMa.Text, txtTen.Text);
                if (ktrtrung(txtMa.Text) == false)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = txtMa.Text;
                    item.SubItems.Add(txtTen.Text);

                    listView1.Items.Add(item);
                    ds.Add(pb);
                }
                else MessageBox.Show("mã trùng");
            }
            else
            {
                MessageBox.Show("bạn cần nhập đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items[i].SubItems[0].Text = txtMa.Text;
                    listView1.Items[i].SubItems[1].Text = txtTen.Text;  
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem ls = new ListViewItem();
            if (listView1.SelectedItems.Count > 0)
            {
                ls = listView1.SelectedItems[0];
                txtMa.Text = ls.Text;
                txtTen.Text = ls.SubItems[1].Text;
            }
            else MessageBox.Show("hay chon dong");
        }
    }
}


