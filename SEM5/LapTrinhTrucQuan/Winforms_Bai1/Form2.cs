﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Bai1
{
	public partial class Form2 : Form
	{
		List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
		public Form2()
		{
			InitializeComponent();
			listNguoiGuis = StaticData._NguoiGui;
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

	

		private void btnTim_Click_1(object sender, EventArgs e)
		{
			int timthay = 0;
			foreach (NguoiGui i in listNguoiGuis)
			{
				if (i.MaKH1 == Convert.ToInt32(txtTimKiem.Text))
				{
					timthay = 1;
					lbThongTinTImKiem.Text = "Khách hàng " + i.TenKH1 + " phải trả " + i.Tien1 + " nghìn đồng";

				}
			}
			if (timthay == 0)
			{
				lbThongTinTImKiem.Text = "Khách hàng " + txtTimKiem.Text + " không có trong danh sách";
			}
		}
	}
}
