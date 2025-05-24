namespace WindowsFormsApp6
{
	partial class Form1
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
			this.cbbPhongBan = new System.Windows.Forms.ComboBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.btnAnh = new System.Windows.Forms.Button();
			this.rbtnNu = new System.Windows.Forms.RadioButton();
			this.rbtnNam = new System.Windows.Forms.RadioButton();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMucLuong = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbbPhongBan);
			this.groupBox1.Controls.Add(this.pictureBox);
			this.groupBox1.Controls.Add(this.btnAnh);
			this.groupBox1.Controls.Add(this.rbtnNu);
			this.groupBox1.Controls.Add(this.rbtnNam);
			this.groupBox1.Controls.Add(this.txtSoDT);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMucLuong);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(35, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(913, 260);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin";
			// 
			// cbbPhongBan
			// 
			this.cbbPhongBan.FormattingEnabled = true;
			this.cbbPhongBan.Items.AddRange(new object[] {
            "Kế toán",
            "Thu ngân",
            "Bảo vệ"});
			this.cbbPhongBan.Location = new System.Drawing.Point(613, 178);
			this.cbbPhongBan.Name = "cbbPhongBan";
			this.cbbPhongBan.Size = new System.Drawing.Size(228, 24);
			this.cbbPhongBan.TabIndex = 5;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(612, 18);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(173, 140);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 4;
			this.pictureBox.TabStop = false;
			// 
			// btnAnh
			// 
			this.btnAnh.Location = new System.Drawing.Point(481, 21);
			this.btnAnh.Name = "btnAnh";
			this.btnAnh.Size = new System.Drawing.Size(104, 36);
			this.btnAnh.TabIndex = 3;
			this.btnAnh.Text = "Ảnh";
			this.btnAnh.UseVisualStyleBackColor = true;
			this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
			// 
			// rbtnNu
			// 
			this.rbtnNu.AutoSize = true;
			this.rbtnNu.Location = new System.Drawing.Point(284, 162);
			this.rbtnNu.Name = "rbtnNu";
			this.rbtnNu.Size = new System.Drawing.Size(45, 20);
			this.rbtnNu.TabIndex = 2;
			this.rbtnNu.TabStop = true;
			this.rbtnNu.Text = "Nữ";
			this.rbtnNu.UseVisualStyleBackColor = true;
			// 
			// rbtnNam
			// 
			this.rbtnNam.AutoSize = true;
			this.rbtnNam.Location = new System.Drawing.Point(138, 162);
			this.rbtnNam.Name = "rbtnNam";
			this.rbtnNam.Size = new System.Drawing.Size(57, 20);
			this.rbtnNam.TabIndex = 2;
			this.rbtnNam.TabStop = true;
			this.rbtnNam.Text = "Nam";
			this.rbtnNam.UseVisualStyleBackColor = true;
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(138, 115);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(249, 22);
			this.txtSoDT.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 164);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giới tính:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số ĐT:";
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(138, 74);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(249, 22);
			this.txtTenNV.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên NV:";
			// 
			// txtMucLuong
			// 
			this.txtMucLuong.Location = new System.Drawing.Point(612, 221);
			this.txtMucLuong.Name = "txtMucLuong";
			this.txtMucLuong.Size = new System.Drawing.Size(249, 22);
			this.txtMucLuong.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(483, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 16);
			this.label7.TabIndex = 0;
			this.label7.Text = "Mức lương:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(483, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Phòng ban:";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(138, 33);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(249, 22);
			this.txtMaNV.TabIndex = 1;
			this.txtMaNV.Click += new System.EventHandler(this.txtMaNV_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã NV:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(357, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "DANH SÁCH NHÂN VIÊN";
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(55, 346);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(869, 175);
			this.dgv.TabIndex = 2;
			this.dgv.Click += new System.EventHandler(this.dgv_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(126, 545);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(104, 36);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "&Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(308, 545);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(104, 36);
			this.btnSua.TabIndex = 3;
			this.btnSua.Text = "&Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(494, 545);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(104, 36);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "&Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(676, 545);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(104, 36);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1003, 593);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button btnAnh;
		private System.Windows.Forms.RadioButton rbtnNu;
		private System.Windows.Forms.RadioButton rbtnNam;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMucLuong;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbbPhongBan;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
	}
}

