namespace BTL_Lan1
{
	partial class BaoCaoQTCT
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBCQTCT = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaNVQTCT = new System.Windows.Forms.Button();
            this.txtMaNVQTCT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCQTCT)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvBCQTCT);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(53, 182);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1065, 321);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // dgvBCQTCT
            // 
            this.dgvBCQTCT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvBCQTCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCQTCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBCQTCT.Location = new System.Drawing.Point(4, 24);
            this.dgvBCQTCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBCQTCT.Name = "dgvBCQTCT";
            this.dgvBCQTCT.RowHeadersWidth = 51;
            this.dgvBCQTCT.Size = new System.Drawing.Size(1057, 293);
            this.dgvBCQTCT.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.btnPhongBan);
            this.groupBox2.Controls.Add(this.cboPhongBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(352, 126);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo theo phòng ban";
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.Location = new System.Drawing.Point(213, 82);
            this.btnPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(113, 36);
            this.btnPhongBan.TabIndex = 2;
            this.btnPhongBan.Text = "       Hiển thị";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(153, 39);
            this.cboPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(173, 27);
            this.cboPhongBan.TabIndex = 1;
            this.cboPhongBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboPhongBan_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn phòng ban :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnMaNVQTCT);
            this.groupBox1.Controls.Add(this.txtMaNVQTCT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(209, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(383, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo theo nhân viên";
            // 
            // btnMaNVQTCT
            // 
            this.btnMaNVQTCT.Image = global::BTL_Lan1.Properties.Resources.hienthi;
            this.btnMaNVQTCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaNVQTCT.Location = new System.Drawing.Point(241, 82);
            this.btnMaNVQTCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaNVQTCT.Name = "btnMaNVQTCT";
            this.btnMaNVQTCT.Size = new System.Drawing.Size(115, 36);
            this.btnMaNVQTCT.TabIndex = 2;
            this.btnMaNVQTCT.Text = "        Hiển thị";
            this.btnMaNVQTCT.UseVisualStyleBackColor = true;
            this.btnMaNVQTCT.Click += new System.EventHandler(this.btnMaNVQTCT_Click);
            // 
            // txtMaNVQTCT
            // 
            this.txtMaNVQTCT.Location = new System.Drawing.Point(125, 43);
            this.txtMaNVQTCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNVQTCT.Name = "txtMaNVQTCT";
            this.txtMaNVQTCT.Size = new System.Drawing.Size(229, 27);
            this.txtMaNVQTCT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã NV :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_Lan1.Properties.Resources.bcqtct;
            this.pictureBox1.Location = new System.Drawing.Point(53, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::BTL_Lan1.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1016, 135);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 44);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXuatExcel.Image = global::BTL_Lan1.Properties.Resources.execl1;
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(1016, 26);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(116, 49);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "      Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::BTL_Lan1.Properties.Resources.execl1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1016, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "       Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaoCaoQTCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaoCaoQTCT";
            this.Text = "Báo cáo quá trình công tác";
            this.Load += new System.EventHandler(this.BaoCaoQTCT_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCQTCT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnXuatExcel;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgvBCQTCT;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnPhongBan;
		private System.Windows.Forms.ComboBox cboPhongBan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnMaNVQTCT;
		private System.Windows.Forms.TextBox txtMaNVQTCT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}