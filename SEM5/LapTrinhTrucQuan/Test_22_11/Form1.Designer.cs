namespace Test_22_11
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenTG = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaTP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenTP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnXuat = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cmbLoai = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.txtTKTenSP = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(198, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên tác giả";
			// 
			// txtTenTG
			// 
			this.txtTenTG.Location = new System.Drawing.Point(318, 69);
			this.txtTenTG.Name = "txtTenTG";
			this.txtTenTG.Size = new System.Drawing.Size(142, 22);
			this.txtTenTG.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(198, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã tác phẩm";
			// 
			// txtMaTP
			// 
			this.txtMaTP.Location = new System.Drawing.Point(318, 119);
			this.txtMaTP.Name = "txtMaTP";
			this.txtMaTP.Size = new System.Drawing.Size(142, 22);
			this.txtMaTP.TabIndex = 1;
			this.txtMaTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaTP_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(198, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên tác phẩm";
			// 
			// txtTenTP
			// 
			this.txtTenTP.Location = new System.Drawing.Point(318, 179);
			this.txtTenTP.Name = "txtTenTP";
			this.txtTenTP.Size = new System.Drawing.Size(142, 22);
			this.txtTenTP.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(198, 234);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Loại tác phẩm";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(814, 37);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(126, 48);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(814, 106);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(126, 48);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(814, 191);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(126, 48);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnXuat
			// 
			this.btnXuat.Location = new System.Drawing.Point(814, 277);
			this.btnXuat.Name = "btnXuat";
			this.btnXuat.Size = new System.Drawing.Size(126, 48);
			this.btnXuat.TabIndex = 2;
			this.btnXuat.Text = "Xuất file Excel";
			this.btnXuat.UseVisualStyleBackColor = true;
			this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(814, 370);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(126, 48);
			this.btnLamMoi.TabIndex = 2;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(591, 21);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(126, 48);
			this.btnTim.TabIndex = 2;
			this.btnTim.Text = "Tìm tên tác phẩm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(37, 295);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(707, 244);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// cmbLoai
			// 
			this.cmbLoai.FormattingEnabled = true;
			this.cmbLoai.Items.AddRange(new object[] {
            "Âm nhạc",
            "Truyện ngắn",
            "Kí sự",
            "Truyện tranh",
            "Truyện dài tập",
            "Phóng sự"});
			this.cmbLoai.Location = new System.Drawing.Point(318, 234);
			this.cmbLoai.Name = "cmbLoai";
			this.cmbLoai.Size = new System.Drawing.Size(142, 24);
			this.cmbLoai.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(513, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Theo Mã tác phẩm";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(513, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Theo Tên tác phẩm";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(633, 119);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(142, 22);
			this.txtTimKiem.TabIndex = 1;
			this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaTP_KeyPress);
			// 
			// txtTKTenSP
			// 
			this.txtTKTenSP.Location = new System.Drawing.Point(633, 179);
			this.txtTKTenSP.Name = "txtTKTenSP";
			this.txtTKTenSP.Size = new System.Drawing.Size(142, 22);
			this.txtTKTenSP.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 626);
			this.Controls.Add(this.cmbLoai);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnXuat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtTKTenSP);
			this.Controls.Add(this.txtTenTP);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.txtMaTP);
			this.Controls.Add(this.txtTenTG);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenTG;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaTP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenTP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnXuat;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cmbLoai;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.TextBox txtTKTenSP;
	}
}

