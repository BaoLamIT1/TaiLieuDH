﻿namespace Winforms_Bai1
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbThongTinTImKiem = new System.Windows.Forms.Label();
			this.btnTim = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbThongTinTImKiem);
			this.groupBox1.Location = new System.Drawing.Point(115, 143);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(374, 76);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kết quả tìm kiếm";
			// 
			// lbThongTinTImKiem
			// 
			this.lbThongTinTImKiem.AutoSize = true;
			this.lbThongTinTImKiem.Location = new System.Drawing.Point(51, 32);
			this.lbThongTinTImKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbThongTinTImKiem.Name = "lbThongTinTImKiem";
			this.lbThongTinTImKiem.Size = new System.Drawing.Size(0, 13);
			this.lbThongTinTImKiem.TabIndex = 3;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(111, 105);
			this.btnTim.Margin = new System.Windows.Forms.Padding(2);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(71, 24);
			this.btnTim.TabIndex = 7;
			this.btnTim.Text = "Tìm Kiếm ";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(111, 74);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(380, 20);
			this.txtTimKiem.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nhập mã khách hàng bạn muốn tìm kiếm";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbThongTinTImKiem;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label1;
	}
}