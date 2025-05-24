namespace BTL_Lan1
{
	partial class BaoCaoQTDT
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
            this.btnMaNV = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTruong = new System.Windows.Forms.Button();
            this.cboTruongDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNganh = new System.Windows.Forms.Button();
            this.cboNganhDT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBCQTDT = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCQTDT)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnMaNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(335, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo theo nhân viên";
            // 
            // btnMaNV
            // 
            this.btnMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaNV.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnMaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaNV.Location = new System.Drawing.Point(191, 71);
            this.btnMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaNV.Name = "btnMaNV";
            this.btnMaNV.Size = new System.Drawing.Size(117, 48);
            this.btnMaNV.TabIndex = 2;
            this.btnMaNV.Text = "      Hiển thị";
            this.btnMaNV.UseVisualStyleBackColor = true;
            this.btnMaNV.Click += new System.EventHandler(this.btnMaNV_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(160, 28);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(149, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã NV :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnTruong);
            this.groupBox2.Controls.Add(this.cboTruongDT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(360, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(329, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo theo trường đào tạo";
            // 
            // btnTruong
            // 
            this.btnTruong.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnTruong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTruong.Location = new System.Drawing.Point(211, 71);
            this.btnTruong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTruong.Name = "btnTruong";
            this.btnTruong.Size = new System.Drawing.Size(109, 38);
            this.btnTruong.TabIndex = 2;
            this.btnTruong.Text = "        Hiển thị";
            this.btnTruong.UseVisualStyleBackColor = true;
            this.btnTruong.Click += new System.EventHandler(this.btnTruong_Click);
            // 
            // cboTruongDT
            // 
            this.cboTruongDT.FormattingEnabled = true;
            this.cboTruongDT.Location = new System.Drawing.Point(159, 28);
            this.cboTruongDT.Margin = new System.Windows.Forms.Padding(4);
            this.cboTruongDT.Name = "cboTruongDT";
            this.cboTruongDT.Size = new System.Drawing.Size(161, 27);
            this.cboTruongDT.TabIndex = 1;
            this.cboTruongDT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboTruongDT_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn trường ĐT :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.btnNganh);
            this.groupBox3.Controls.Add(this.cboNganhDT);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(697, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(332, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo cáo theo ngành đào tạo";
            // 
            // btnNganh
            // 
            this.btnNganh.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNganh.Location = new System.Drawing.Point(205, 71);
            this.btnNganh.Margin = new System.Windows.Forms.Padding(4);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Size = new System.Drawing.Size(119, 38);
            this.btnNganh.TabIndex = 2;
            this.btnNganh.Text = "       Hiển thị";
            this.btnNganh.UseVisualStyleBackColor = true;
            this.btnNganh.Click += new System.EventHandler(this.btnNganh_Click);
            // 
            // cboNganhDT
            // 
            this.cboNganhDT.FormattingEnabled = true;
            this.cboNganhDT.Location = new System.Drawing.Point(149, 25);
            this.cboNganhDT.Margin = new System.Windows.Forms.Padding(4);
            this.cboNganhDT.Name = "cboNganhDT";
            this.cboNganhDT.Size = new System.Drawing.Size(175, 27);
            this.cboNganhDT.TabIndex = 1;
            this.cboNganhDT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboNganhDT_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn ngành ĐT :";
            // 
            // dgvBCQTDT
            // 
            this.dgvBCQTDT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvBCQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCQTDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCQTDT.Location = new System.Drawing.Point(4, 19);
            this.dgvBCQTDT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBCQTDT.Name = "dgvBCQTDT";
            this.dgvBCQTDT.RowHeadersWidth = 51;
            this.dgvBCQTDT.Size = new System.Drawing.Size(1133, 342);
            this.dgvBCQTDT.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvBCQTDT);
            this.groupBox4.Location = new System.Drawing.Point(22, 203);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1141, 365);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::BTL_Lan1.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1058, 75);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 48);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = global::BTL_Lan1.Properties.Resources.execl;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(1058, 18);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(105, 49);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "       Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BTL_Lan1.Properties.Resources.execl;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1058, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "        Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaoCaoQTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaoCaoQTDT";
            this.Text = "Báo Cáo Quá Trình Đào Tạo";
            this.Load += new System.EventHandler(this.BaoCaoQTDT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCQTDT)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvBCQTDT;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnMaNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.ComboBox cboTruongDT;
		private System.Windows.Forms.ComboBox cboNganhDT;
		private System.Windows.Forms.Button btnTruong;
		private System.Windows.Forms.Button btnNganh;
		private System.Windows.Forms.Button btnXuatExcel;
		private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
    }
}