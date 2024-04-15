namespace KiemTra
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
			this.txtMa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenTP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbLoai = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTK = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTKTenSP = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên TG";
			// 
			// txtTenTG
			// 
			this.txtTenTG.Location = new System.Drawing.Point(161, 26);
			this.txtTenTG.Name = "txtTenTG";
			this.txtTenTG.Size = new System.Drawing.Size(209, 22);
			this.txtTenTG.TabIndex = 1;
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(161, 67);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(209, 22);
			this.txtMa.TabIndex = 3;
			this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã TP";
			// 
			// txtTenTP
			// 
			this.txtTenTP.Location = new System.Drawing.Point(161, 118);
			this.txtTenTP.Name = "txtTenTP";
			this.txtTenTP.Size = new System.Drawing.Size(209, 22);
			this.txtTenTP.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tên TP";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(80, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Loai";
			// 
			// cbLoai
			// 
			this.cbLoai.FormattingEnabled = true;
			this.cbLoai.Items.AddRange(new object[] {
            "Âm nhạc",
            "truyện ngắn",
            "truyện tranh",
            "truyện dài tập",
            "kí sự",
            "phóng sự",
            "Phim",
            "Chèo"});
			this.cbLoai.Location = new System.Drawing.Point(161, 169);
			this.cbLoai.Name = "cbLoai";
			this.cbLoai.Size = new System.Drawing.Size(121, 24);
			this.cbLoai.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 208);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(574, 230);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(657, 44);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 9;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(657, 117);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 10;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(657, 174);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 11;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTK
			// 
			this.btnTK.Location = new System.Drawing.Point(479, 25);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(116, 23);
			this.btnTK.TabIndex = 12;
			this.btnTK.Text = "Tìm Kiếm";
			this.btnTK.UseVisualStyleBackColor = true;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(657, 258);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
			this.btnLamMoi.TabIndex = 13;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnExcel
			// 
			this.btnExcel.Location = new System.Drawing.Point(657, 317);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(114, 23);
			this.btnExcel.TabIndex = 14;
			this.btnExcel.Text = "In ra file excel";
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(419, 94);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(209, 22);
			this.txtTimKiem.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(416, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Theo mã";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(416, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 16);
			this.label6.TabIndex = 18;
			this.label6.Text = "Theo TênTP";
			// 
			// txtTKTenSP
			// 
			this.txtTKTenSP.Location = new System.Drawing.Point(419, 151);
			this.txtTKTenSP.Name = "txtTKTenSP";
			this.txtTKTenSP.Size = new System.Drawing.Size(209, 22);
			this.txtTKTenSP.TabIndex = 17;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTKTenSP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnTK);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbLoai);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTenTP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenTG);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.TextBox txtMa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTenTP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbLoai;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTK;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTKTenSP;
	}
}

