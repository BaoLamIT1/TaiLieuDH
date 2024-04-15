namespace Test02
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
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.rdbNam = new System.Windows.Forms.RadioButton();
			this.rdbNu = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.btnAnh = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbPB = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbPB);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.rdbNu);
			this.groupBox1.Controls.Add(this.rdbNam);
			this.groupBox1.Controls.Add(this.txtSoDT);
			this.groupBox1.Controls.Add(this.btnAnh);
			this.groupBox1.Controls.Add(this.txtLuong);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(59, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(581, 223);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(98, 492);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(252, 492);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(401, 492);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(541, 492);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 1;
			this.btnThoat.Text = "THoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(59, 317);
			this.dgv.Name = "dgv";
			this.dgv.Size = new System.Drawing.Size(581, 150);
			this.dgv.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã NV";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên NV";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số ĐT";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(83, 41);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(136, 20);
			this.txtMaNV.TabIndex = 1;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(83, 74);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(136, 20);
			this.txtTen.TabIndex = 1;
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(83, 107);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(136, 20);
			this.txtSoDT.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Giới tính";
			// 
			// rdbNam
			// 
			this.rdbNam.AutoSize = true;
			this.rdbNam.Location = new System.Drawing.Point(108, 154);
			this.rdbNam.Name = "rdbNam";
			this.rdbNam.Size = new System.Drawing.Size(47, 17);
			this.rdbNam.TabIndex = 2;
			this.rdbNam.TabStop = true;
			this.rdbNam.Text = "Nam";
			this.rdbNam.UseVisualStyleBackColor = true;
			// 
			// rdbNu
			// 
			this.rdbNu.AutoSize = true;
			this.rdbNu.Location = new System.Drawing.Point(108, 187);
			this.rdbNu.Name = "rdbNu";
			this.rdbNu.Size = new System.Drawing.Size(39, 17);
			this.rdbNu.TabIndex = 2;
			this.rdbNu.TabStop = true;
			this.rdbNu.Text = "Nữ";
			this.rdbNu.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(373, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Phòng ban";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(373, 187);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mức lương";
			// 
			// txtLuong
			// 
			this.txtLuong.Location = new System.Drawing.Point(427, 180);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(136, 20);
			this.txtLuong.TabIndex = 1;
			// 
			// btnAnh
			// 
			this.btnAnh.Location = new System.Drawing.Point(333, 19);
			this.btnAnh.Name = "btnAnh";
			this.btnAnh.Size = new System.Drawing.Size(75, 23);
			this.btnAnh.TabIndex = 1;
			this.btnAnh.Text = "Ảnh";
			this.btnAnh.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(427, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 107);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// cmbPB
			// 
			this.cmbPB.FormattingEnabled = true;
			this.cmbPB.Location = new System.Drawing.Point(439, 134);
			this.cmbPB.Name = "cmbPB";
			this.cmbPB.Size = new System.Drawing.Size(121, 21);
			this.cmbPB.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 541);
			this.Controls.Add(this.dgv);
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
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbNu;
		private System.Windows.Forms.RadioButton rdbNam;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.Button btnAnh;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cmbPB;
	}
}

