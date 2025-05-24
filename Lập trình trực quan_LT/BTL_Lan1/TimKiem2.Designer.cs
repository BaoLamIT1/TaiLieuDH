namespace BTL_Lan1
{
    partial class TimKiem2
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
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHocVan = new System.Windows.Forms.TextBox();
			this.txtNgoaiNgu = new System.Windows.Forms.TextBox();
			this.txtChucVu = new System.Windows.Forms.TextBox();
			this.txtPhongBan = new System.Windows.Forms.TextBox();
			this.txtTenNhanVien = new System.Windows.Forms.TextBox();
			this.dgvTimKiemHSNV = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHSNV)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::BTL_Lan1.Properties.Resources.timkiem;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(867, 99);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(151, 43);
			this.btnTimKiem.TabIndex = 0;
			this.btnTimKiem.Text = "     Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtHocVan);
			this.groupBox1.Controls.Add(this.txtNgoaiNgu);
			this.groupBox1.Controls.Add(this.txtChucVu);
			this.groupBox1.Controls.Add(this.txtPhongBan);
			this.groupBox1.Controls.Add(this.txtTenNhanVien);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(94, 54);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1071, 151);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BTL_Lan1.Properties.Resources.tkhsnv;
			this.pictureBox1.Location = new System.Drawing.Point(29, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 127);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(196, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên nhân viên :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(196, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Phòng ban :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(196, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Chức vụ :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(670, 64);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Học vấn :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(670, 26);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ngoại ngữ :";
			// 
			// txtHocVan
			// 
			this.txtHocVan.Location = new System.Drawing.Point(786, 61);
			this.txtHocVan.Margin = new System.Windows.Forms.Padding(4);
			this.txtHocVan.Name = "txtHocVan";
			this.txtHocVan.Size = new System.Drawing.Size(232, 30);
			this.txtHocVan.TabIndex = 1;
			// 
			// txtNgoaiNgu
			// 
			this.txtNgoaiNgu.Location = new System.Drawing.Point(786, 23);
			this.txtNgoaiNgu.Margin = new System.Windows.Forms.Padding(4);
			this.txtNgoaiNgu.Name = "txtNgoaiNgu";
			this.txtNgoaiNgu.Size = new System.Drawing.Size(232, 30);
			this.txtNgoaiNgu.TabIndex = 1;
			// 
			// txtChucVu
			// 
			this.txtChucVu.Location = new System.Drawing.Point(342, 103);
			this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
			this.txtChucVu.Name = "txtChucVu";
			this.txtChucVu.Size = new System.Drawing.Size(234, 30);
			this.txtChucVu.TabIndex = 1;
			// 
			// txtPhongBan
			// 
			this.txtPhongBan.Location = new System.Drawing.Point(342, 65);
			this.txtPhongBan.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhongBan.Name = "txtPhongBan";
			this.txtPhongBan.Size = new System.Drawing.Size(234, 30);
			this.txtPhongBan.TabIndex = 1;
			// 
			// txtTenNhanVien
			// 
			this.txtTenNhanVien.Location = new System.Drawing.Point(342, 27);
			this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenNhanVien.Name = "txtTenNhanVien";
			this.txtTenNhanVien.Size = new System.Drawing.Size(234, 30);
			this.txtTenNhanVien.TabIndex = 1;
			// 
			// dgvTimKiemHSNV
			// 
			this.dgvTimKiemHSNV.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dgvTimKiemHSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimKiemHSNV.Location = new System.Drawing.Point(94, 227);
			this.dgvTimKiemHSNV.Margin = new System.Windows.Forms.Padding(4);
			this.dgvTimKiemHSNV.Name = "dgvTimKiemHSNV";
			this.dgvTimKiemHSNV.RowHeadersWidth = 51;
			this.dgvTimKiemHSNV.Size = new System.Drawing.Size(1071, 266);
			this.dgvTimKiemHSNV.TabIndex = 6;
			// 
			// TimKiem2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1233, 535);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvTimKiemHSNV);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TimKiem2";
			this.Text = "Tìm Kiếm Hồ Sơ Nhân Viên";
			this.Load += new System.EventHandler(this.TimKiem2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHSNV)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTenNhanVien;
		private System.Windows.Forms.DataGridView dgvTimKiemHSNV;
		private System.Windows.Forms.TextBox txtHocVan;
		private System.Windows.Forms.TextBox txtNgoaiNgu;
		private System.Windows.Forms.TextBox txtChucVu;
		private System.Windows.Forms.TextBox txtPhongBan;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}