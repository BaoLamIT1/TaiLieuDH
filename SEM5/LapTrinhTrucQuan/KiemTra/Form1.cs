using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        List<ChungCu> chungcu = new List<ChungCu> ();

        public Form1()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if (txtDiaChi.Text.Trim().Length == 0 ||
                txtSoPhong.Text.Trim().Length == 0 || txtSoWC.Text.Trim().Length==0||
                cmbHuong.Text.Trim().Length==0 || txtGia.Text.Trim().Length == 0|| 
                txtChietKhau.Text.Trim().Length == 0 ||cmbTinhTrang.Text.Trim().Length == 0)
                return false;
            return true;
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                ChungCu cc = new ChungCu(txtDiaChi.Text, int.Parse(txtSoPhong.Text), int.Parse(txtSoWC.Text),
                    cmbHuong.SelectedItem.ToString(), int.Parse(txtGia.Text), int.Parse(txtChietKhau.Text),
                    cmbTinhTrang.SelectedItem.ToString());

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(txtSoPhong.Text);
                item.SubItems.Add(txtSoWC.Text);
                item.Text = cmbHuong.SelectedItem.ToString();
                item.SubItems.Add(txtGia.Text);
                item.SubItems.Add(txtChietKhau.Text);
                item.SubItems.Add(cmbTinhTrang.Text);
                listView1.Items.Add(item);
                chungcu.Add(cc);
            }
            else
            {
                MessageBox.Show("Ban can nhap du thong tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = txtDiaChi.Text;
                listView1.Items[i].SubItems[1].Text = txtSoPhong.Text;
                listView1.Items[i].SubItems[2].Text = txtSoWC.Text;
                listView1.Items[i].SubItems[3].Text = cmbHuong.SelectedItem.ToString();
                listView1.Items[i].SubItems[4].Text = txtGia.Text;
                listView1.Items[i].SubItems[5].Text = txtChietKhau.Text;
                listView1.Items[i].SubItems[6].Text = cmbTinhTrang.SelectedItem.ToString();
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
