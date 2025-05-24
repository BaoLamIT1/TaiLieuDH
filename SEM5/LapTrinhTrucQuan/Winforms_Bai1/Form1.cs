using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private bool Validate()
        {
            if (txtTen.Text.Trim() == " " || txtMa.Text.Trim() == " " || txtDC.Text.Trim() == " "
                || txtTiengui.Text.Trim().Length == 0 || dtpNgayGui.Value.ToString() == " "
                || (rdbPhatloc.Checked == false && rdbThuong.Checked == false)
                || cmbThang.Text == " ")
            {
                MessageBox.Show("Hay nhap du du lieu");
                return false;
            }
            else return true;
        }
        /*
        private void Form1_Load (object sender, EventArgs e)
        {
            cmbThang.Items.Add("1");
            cmbThang.Items.Add("3");
            cmbThang.Items.Add("6");
            cmbThang.Items.Add("12");
        }
        */
        private void txtTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chỉ cho phép nhập số và kí tự điều khiển ở textbox
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
			txtMa.Text = "";
			txtTen.Text = "";
			txtDC.Text = "";
			txtTiengui.Text = "";
			dtpNgayGui.Text = "";
			cmbThang.Text = "";
			cmbThang.SelectedIndex = -1;

			rdbPhatloc.Checked = false;
            rdbThuong.Checked = false;
            
            List<string> newItems = new List<string>
            {
             "1","3","6","12"
            };
            cmbThang.Items.AddRange(newItems.ToArray());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

		private void btnThemDS_Click(object sender, EventArgs e)
		{
			int kt = 1;
			if (txtMa.TextLength < 6)
			{
				MessageBox.Show("Nhập lại vì mã < 6");
				kt = 0;
			}
			if (txtDC.TextLength == 0 || txtTen.TextLength == 0)
			{
				MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
				kt = 0;
			}
			double tienlai = 0;
			if (kt == 1)
			{
				if (rdbThuong.Checked == true)
				{
					if (cmbThang.SelectedItem == "1")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.06;
					}
					if (cmbThang.SelectedItem == "3")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.07;
					}
					if (cmbThang.SelectedItem == "6")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.08;
					}
					if (cmbThang.SelectedItem == "12")
					{
						tienlai = Convert.ToDouble(txtTiengui.Text) * 0.09;
					}
				}
				else if (rdbPhatloc.Checked == true)
				{
					if (cmbThang.SelectedItem == "1")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.07;
					}
					if (cmbThang.SelectedItem == "3")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.08;
					}
					if (cmbThang.SelectedItem == "6")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.09;
					}
					if (cmbThang.SelectedItem == "12")
					{
						tienlai = Convert.ToInt32(txtTiengui.Text) * 0.1;
					}
				}
				lstDS.Items.Add(txtMa.Text + " | " + txtTen.Text + " | " +
				txtDC.Text
			   + " | " + dtpNgayGui.Text + " | " + txtTiengui.Text + " | "
				+ cmbThang.Text + " tháng | " + tienlai);
				List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
				listNguoiGuis.Add(new NguoiGui(Convert.ToInt32(txtMa.Text),
			   txtTen.Text, txtDC.Text, Convert.ToInt32(txtTiengui.Text),
				dtpNgayGui.Text, cmbThang.Text, tienlai
				));
				StaticData._NguoiGui = listNguoiGuis;
			}
		}

		private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}
	}
}

