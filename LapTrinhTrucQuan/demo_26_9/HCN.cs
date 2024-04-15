using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_26_9
{
    public partial class HCN : Form
    {
        public HCN()
        {
            InitializeComponent();
        }

        private void HCN_Load(object sender, EventArgs e)
        {

        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k = float.TryParse(textBox1.Text, out a);
            bool k2 = float.TryParse(textBox2.Text, out b);
            if (k = true && k2 == true)
            {
                lblKQ.Text = "Dien tich la: " + (a * b).ToString();
            }
            else
                MessageBox.Show("du lieu nhap chua dung");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat ? ", "Thong bao", MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lblKQ.ForeColor = Color.Green;
            lblKQ.BackColor = Color.Green;
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lblKQ.ForeColor= Color.Red;
            lblKQ.BackColor = Color.Red;
        }

        private void YellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lblKQ.ForeColor = Color.Yellow;
            lblKQ.BackColor = Color.Yellow;
        }
    }
}
