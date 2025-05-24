using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Bai2
{
    public partial class Form1 : Form
    {
 
        List<MonHoc> listmh = new List<MonHoc>();
        List<String> tenmonhoc = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        // Nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat ? ","Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes) 
            { 
                this.Close(); 
            }  
        }
        // kiểm tra điểm là số
        private bool ktradiem()
        {
            double number;
            if (double.TryParse(txtDiem.Text, out number))
                return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MonHoc mon = new MonHoc(cmbTen.SelectedItem.ToString(), int.Parse(txtSoTC.Text), double.Parse(txtDiem.Text));
            if (!ktradiem())
                MessageBox.Show("Hãy nhập đúng thông tin");
            else
            {
                if (tenmonhoc.Contains(cmbTen.SelectedItem.ToString()) == false)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Text = cmbTen.SelectedItem.ToString();
                    listItem.SubItems.Add(txtSoTC.Text);
                    listItem.SubItems.Add(txtDiem.Text);
                    listView1.Items.Add(listItem);
                    listmh.Add(mon);
                    tenmonhoc.Add(cmbTen.SelectedItem.ToString());
                }
                else
                    MessageBox.Show("Tên môn học này đã có");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                
                if (tenmonhoc.Contains(cmbTen.SelectedItem.ToString()) == false)
                {
                    listView1.Items[i].SubItems[0].Text = cmbTen.SelectedItem.ToString();
                    listView1.Items[i].SubItems[1].Text = txtSoTC.Text;
                    listView1.Items[i].SubItems[2].Text = txtDiem.Text;
                    MonHoc m = new MonHoc(cmbTen.SelectedItem.ToString(), int.Parse(txtSoTC.Text), double.Parse(txtDiem.Text));
                    listmh[i] = m;
                    tenmonhoc[i] = cmbTen.SelectedItem.ToString();
                }
                else MessageBox.Show("Tên môn học này đã có!!!");
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tongtc = 0;
            double tongdiem = 0;
            double tb = 0;
            if (listmh.Count < 0)
            {
                MessageBox.Show("hãy thêm môn học");
            }
            else
            {

                foreach (MonHoc mon in listmh)
                {
                    tongtc += mon.SoTC;
                    tongdiem += mon.SoTC * mon.Diem;
                }
                tb = tongdiem / tongtc;
                txtTongTC.Text = tongtc.ToString();
                txtTongDiem.Text = tongdiem.ToString();
                txtDiemTB.Text = tb.ToString();
            }
        }
    }
}
