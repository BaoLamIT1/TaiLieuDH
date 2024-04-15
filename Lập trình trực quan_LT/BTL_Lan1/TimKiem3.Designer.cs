namespace BTL_Lan1
{
	partial class TimKiem3
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
			this.dgvTimKiemQTDT = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtHinhThuc = new System.Windows.Forms.TextBox();
			this.txtTruong = new System.Windows.Forms.TextBox();
			this.txtMaNhanVien = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemQTDT)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTimKiemQTDT
			// 
			this.dgvTimKiemQTDT.AllowUserToOrderColumns = true;
			this.dgvTimKiemQTDT.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dgvTimKiemQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimKiemQTDT.Location = new System.Drawing.Point(91, 228);
			this.dgvTimKiemQTDT.Name = "dgvTimKiemQTDT";
			this.dgvTimKiemQTDT.RowHeadersWidth = 51;
			this.dgvTimKiemQTDT.Size = new System.Drawing.Size(1097, 289);
			this.dgvTimKiemQTDT.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtHinhThuc);
			this.groupBox1.Controls.Add(this.txtTruong);
			this.groupBox1.Controls.Add(this.txtMaNhanVien);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(91, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1097, 144);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tìn cần tìm ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BTL_Lan1.Properties.Resources.mqtdt;
			this.pictureBox1.Location = new System.Drawing.Point(65, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 97);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::BTL_Lan1.Properties.Resources.timkiem;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(912, 91);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(141, 42);
			this.btnTimKiem.TabIndex = 3;
			this.btnTimKiem.Text = "      Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtHinhThuc
			// 
			this.txtHinhThuc.Location = new System.Drawing.Point(883, 36);
			this.txtHinhThuc.Name = "txtHinhThuc";
			this.txtHinhThuc.Size = new System.Drawing.Size(170, 30);
			this.txtHinhThuc.TabIndex = 1;
			// 
			// txtTruong
			// 
			this.txtTruong.Location = new System.Drawing.Point(476, 98);
			this.txtTruong.Name = "txtTruong";
			this.txtTruong.Size = new System.Drawing.Size(176, 30);
			this.txtTruong.TabIndex = 1;
			// 
			// txtMaNhanVien
			// 
			this.txtMaNhanVien.Location = new System.Drawing.Point(478, 39);
			this.txtMaNhanVien.Name = "txtMaNhanVien";
			this.txtMaNhanVien.Size = new System.Drawing.Size(174, 30);
			this.txtMaNhanVien.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(704, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Hình thức đào tạo :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(292, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Trường đào tạo :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(292, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên :";
			// 
			// TimKiem3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1248, 540);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvTimKiemQTDT);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TimKiem3";
			this.Text = "Tìm kiếm quá trình đào tạo";
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemQTDT)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTimKiemQTDT;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtHinhThuc;
		private System.Windows.Forms.TextBox txtTruong;
		private System.Windows.Forms.TextBox txtMaNhanVien;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}