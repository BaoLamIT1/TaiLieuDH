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
    public partial class PTB1 : Form
    {
        public PTB1()
        {
            InitializeComponent();
        }

        private void PTB1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k = float.TryParse(textBox1.Text, out a);
            bool k2 = float.TryParse(textBox2.Text, out b);
            if (k = true && k2 == true)
            {
                if (a==0)
                {
                    if (b == 0)
                    {
                        lblKetQua.Text = "Phuong trinh co vo so nghiem";
                    }
                    else  lblKetQua.Text = "Phuong trinh vo nghiem";
                }
                else
                {
                   lblKetQua.Text = "Phuong trinh co nghiem: "+ (-b/a).ToString();
                }
            }
        }
    }
}
