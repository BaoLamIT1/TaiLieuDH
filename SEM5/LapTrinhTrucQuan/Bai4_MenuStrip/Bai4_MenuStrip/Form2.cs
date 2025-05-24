using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai4_MenuStrip
{
    public partial class Form2 : Form
    {
        BaiTapDienTu baitap = new BaiTapDienTu();
        public Form2()
        {
            InitializeComponent();
            //baitap = StaticData.btdt;
            //rtBDeBai.Text = baitap.Debai;
            rtBDeBai.Text = StaticData.btdt.Debai;
        }
 
        private void btnOk_Click(object sender, EventArgs e)
        {
            int dem = 0;            
            List<TextBox> textbox = new List<TextBox>();
            if (txt1.Text == StaticData.btdt.Dapantungcau[0])
            {
                dem++;
                txt1.BackColor = Color.Green;
            }
            else txt1.BackColor = Color.Red;
            if (txt2.Text == StaticData.btdt.Dapantungcau[1])
            {
                dem++;
                txt2.BackColor = Color.Green;
            }
            else txt2.BackColor = Color.Red;
            if (txt3.Text == StaticData.btdt.Dapantungcau[2])
            {
                dem++;
                txt3.BackColor = Color.Green;
            }else txt3.BackColor = Color.Red;

            if (txt4.Text == StaticData.btdt.Dapantungcau[3])
            {
                dem++;
                txt4.BackColor = Color.Green;

            }else txt4.BackColor = Color.Red;
            if (txt5.Text == StaticData.btdt.Dapantungcau[4])
            {
                dem++;
                txt5.BackColor = Color.Green;
            }else txt5.BackColor = Color.Red;
            if (txt6.Text == StaticData.btdt.Dapantungcau[5])
            {
                dem++;
                txt6.BackColor = Color.Green;
            }
            else txt6.BackColor = Color.Red;
            if (txt7.Text == StaticData.btdt.Dapantungcau[6])
            {
                dem++;
                txt7.BackColor = Color.Green;
            }
            else txt7.BackColor = Color.Red;
            if (txt8.Text == StaticData.btdt.Dapantungcau[7])
            {
                dem++;
                txt8.BackColor = Color.Green;
            }
            else txt8.BackColor = Color.Red;
            if (txt9.Text == StaticData.btdt.Dapantungcau[8])
            {
                dem++;
                txt9.BackColor = Color.Green;
            }
            else txt9.BackColor = Color.Red;
            if (txt10.Text == StaticData.btdt.Dapantungcau[9])
            {
                dem++;
                txt10.BackColor = Color.Green;
            }
            else txt10.BackColor = Color.Red;
            MessageBox.Show("Điểm của bạn là: "+ dem);
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            rtBDeBai.Text = StaticData.btdt.Dapan;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            rtBDeBai.Text = StaticData.btdt.Debai;
            txt1.Text  = "";
            txt1.BackColor = Color.White;
            txt2.Text  = "";
            txt2.BackColor = Color.White;
            txt3.Text  = "";
            txt3.BackColor = Color.White;
            txt4.Text  = "";
            txt4.BackColor = Color.White;
            txt5.Text  = "";
            txt5.BackColor = Color.White;
            txt6.Text  = "";
            txt6.BackColor = Color.White;
            txt7.Text  = "";
            txt7.BackColor = Color.White;
            txt8.Text  = "";
            txt8.BackColor = Color.White;
            txt9.Text  = "";
            txt9.BackColor = Color.White;
            txt10.Text = "";
            txt10.BackColor = Color.White;
            txt1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
