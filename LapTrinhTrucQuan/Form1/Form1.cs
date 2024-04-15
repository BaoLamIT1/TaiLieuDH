using Demo1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Demo1.PTB2;
namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a =  double.Parse(textBox1.Text);   
            b = double.Parse(textBox2.Text); 
            c = double.Parse(textBox3.Text);

            PTB2 pt = new PTB2(a,b,c);
            textBox4.Text = pt.giaipt();

        }
        private void xoa()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text= " ";            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
