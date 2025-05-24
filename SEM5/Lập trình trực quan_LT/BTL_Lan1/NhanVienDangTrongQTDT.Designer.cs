namespace BTL_Lan1
{
	partial class NhanVienDangTrongQTDT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaQTDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNVtheoQTDT = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnHienThiAll = new System.Windows.Forms.Button();
            this.btnHienMaQTDT = new System.Windows.Forms.Button();
            this.btnMaNV = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVtheoQTDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnHienMaQTDT);
            this.groupBox2.Controls.Add(this.txtMaQTDT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(613, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 148);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo theo mã QTDT";
            // 
            // txtMaQTDT
            // 
            this.txtMaQTDT.Location = new System.Drawing.Point(169, 40);
            this.txtMaQTDT.Name = "txtMaQTDT";
            this.txtMaQTDT.Size = new System.Drawing.Size(207, 30);
            this.txtMaQTDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã QTĐT :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnMaNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(222, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo theo nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(141, 37);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(226, 30);
            this.txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã NV :";
            // 
            // dgvNVtheoQTDT
            // 
            this.dgvNVtheoQTDT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvNVtheoQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVtheoQTDT.Location = new System.Drawing.Point(94, 248);
            this.dgvNVtheoQTDT.Name = "dgvNVtheoQTDT";
            this.dgvNVtheoQTDT.RowHeadersWidth = 51;
            this.dgvNVtheoQTDT.Size = new System.Drawing.Size(1034, 259);
            this.dgvNVtheoQTDT.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_Lan1.Properties.Resources.bcqtdt;
            this.pictureBox1.Location = new System.Drawing.Point(94, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::BTL_Lan1.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1001, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 39);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = global::BTL_Lan1.Properties.Resources.execl;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(1001, 148);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 39);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "    Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = global::BTL_Lan1.Properties.Resources.execl;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(1001, 96);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(132, 39);
            this.btnXuatExcel.TabIndex = 0;
            this.btnXuatExcel.Text = "    Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnHienThiAll
            // 
            this.btnHienThiAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiAll.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnHienThiAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiAll.Location = new System.Drawing.Point(1001, 50);
            this.btnHienThiAll.Name = "btnHienThiAll";
            this.btnHienThiAll.Size = new System.Drawing.Size(132, 39);
            this.btnHienThiAll.TabIndex = 0;
            this.btnHienThiAll.Text = "     Hiển thị";
            this.btnHienThiAll.UseVisualStyleBackColor = true;
            this.btnHienThiAll.Click += new System.EventHandler(this.btnHienThiAll_Click);
            // 
            // btnHienMaQTDT
            // 
            this.btnHienMaQTDT.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnHienMaQTDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienMaQTDT.Location = new System.Drawing.Point(244, 86);
            this.btnHienMaQTDT.Name = "btnHienMaQTDT";
            this.btnHienMaQTDT.Size = new System.Drawing.Size(132, 39);
            this.btnHienMaQTDT.TabIndex = 2;
            this.btnHienMaQTDT.Text = "       Hiển thị";
            this.btnHienMaQTDT.UseVisualStyleBackColor = true;
            this.btnHienMaQTDT.Click += new System.EventHandler(this.btnHienMaQTDT_Click);
            // 
            // btnMaNV
            // 
            this.btnMaNV.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnMaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaNV.Location = new System.Drawing.Point(235, 86);
            this.btnMaNV.Name = "btnMaNV";
            this.btnMaNV.Size = new System.Drawing.Size(132, 39);
            this.btnMaNV.TabIndex = 2;
            this.btnMaNV.Text = "      Hiển thị";
            this.btnMaNV.UseVisualStyleBackColor = true;
            this.btnMaNV.Click += new System.EventHandler(this.btnMaNV_Click);
            // 
            // NhanVienDangTrongQTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.dgvNVtheoQTDT);
            this.Controls.Add(this.btnHienThiAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVienDangTrongQTDT";
            this.Text = "Báo cáo nhân viên đang trong quá trình đào tạo";
            this.Load += new System.EventHandler(this.NhanVienDangTrongQTDT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVtheoQTDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnHienMaQTDT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnMaNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvNVtheoQTDT;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXuatExcel;
		private System.Windows.Forms.Button btnHienThiAll;
		private System.Windows.Forms.TextBox txtMaQTDT;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReport;
    }
}