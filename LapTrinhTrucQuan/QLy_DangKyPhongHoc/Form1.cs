using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLy_DangKyPhongHoc
{
    public partial class Form1 : Form
    {
        List<Room> roomList = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if (dtbNgaySD.Value.ToString() == " " || cmbCaSD.Text == " " ||
               cmbMD.Text == " " || txtNguoiDK.Text.Trim() == " " ||
               txtMa.Text.Trim() == " " || txtSDT.Text.Trim() == " ")
                return false;
            return true;

            /*long ma;
            long sdt;
            if (long.TryParse(txtMa.Text, out ma))
            {
                return true;
            }
            return false;

            if (long.TryParse(txtMa.Text, out sdt))
            {
                return true;
            }
            return false;*/

        }
    

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check()==true)
            {
                Room room = new Room(dtbNgaySD.Value, cmbCaSD.SelectedItem.ToString(), cmbMD.SelectedItem.ToString(),
                    txtNguoiDK.Text, long.Parse(txtMa.Text), long.Parse(txtSDT.Text));
               
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(dtbNgaySD.Text);
                    item.Text = cmbCaSD.SelectedItem.ToString();
                    item.SubItems.Add(cmbMD.Text);
                    item.SubItems.Add(txtNguoiDK.Text);
                    item.SubItems.Add(txtMa.Text);
                    item.SubItems.Add(txtSDT.Text);

                    listView1.Items.Add(item);
                    roomList.Add(room);
               
            }
            else
            {
                MessageBox.Show("Ban can nhap dung va du thong tin");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong ?", "Thong bao ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cmbCaSD.Items.Clear();
            cmbMD.Items.Clear();
            txtNguoiDK.Clear();
            txtMa.Clear();
            txtSDT.Clear();
            List<string> newItems1 = new List<string>
            {
                "Ca 1 ", "Ca 2", "Ca 3","Ca 4","Ca 5"
            };
            cmbCaSD.Items.AddRange(newItems1.ToArray());
            List<string> newItems2 = new List<string>
            {
                "Dạy bù", "Sinh hoạt lớp","Hướng dẫn sinh viên NCKH"
            };
            cmbMD.Items.AddRange(newItems2.ToArray());

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = dtbNgaySD.Value.ToString();
                listView1.Items[i].SubItems[1].Text = cmbCaSD.SelectedItem.ToString();
                listView1.Items[i].SubItems[2].Text = cmbMD.SelectedItem.ToString();
                listView1.Items[i].SubItems[3].Text = txtNguoiDK.Text;
                listView1.Items[i].SubItems[4].Text = txtNguoiDK.Text;
                listView1.Items[i].SubItems[5].Text = txtMa.Text;
                listView1.Items[i].SubItems[6].Text = txtSDT.Text;

            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >0 )
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
