using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B03_WindowForms
{
    public partial class Form1 : Form
    {
        List<Sach1> lst;

        public Form1()
        {
            lst = new List<Sach1>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string ma,ten,tg,qr;
            int sl;
            ma = txtMa.Text;
            ten = txtTen.Text;
            tg = txtTG.Text;
            qr = txtQR.Text;
            sl = int.Parse(txtSL.Text);

            Sach1 x = new Sach1(ma,ten,tg,sl,qr);
            lst.Add(x);
            showList.Items.Add(x.ToString());
            //listDS.Items.Add(ma + " " + ten +" ");

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //xoa pt
            int index= showList.SelectedIndex;
            if (index ==-1)
            {
                MessageBox.Show("Hay chon pt can xoa");
            }else
            if(MessageBox.Show("ban co muon xoa pt nay ko ? ","",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                showList.Items.RemoveAt(index);
                lst.RemoveAt(index);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty; 
            txtTG.Text = string.Empty;
            txtQR.Text = string.Empty;
            txtSL.Text = string.Empty;

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btQR_Click(object sender, EventArgs e)
        {
            bool k = false;
            //Tìm kiếm theo QR
            foreach (Sach1 x in lst)
            {
                //  if (string.CompareOrdinal (x.qrcode ) { }
                if (x.qrcode == btQR.Text)
                {
                    k = true;
                    MessageBox.Show ("So luong ton kho "+ x.Sl.ToString());
                }
            }
            if (k == false) MessageBox.Show("K tim thay");
           
        }
    }
}
