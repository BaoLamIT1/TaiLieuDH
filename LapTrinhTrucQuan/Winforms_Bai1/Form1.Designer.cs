namespace Winforms_Bai1
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
			this.label8 = new System.Windows.Forms.Label();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.btnThemDS = new System.Windows.Forms.Button();
			this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
			this.cmbThang = new System.Windows.Forms.ComboBox();
			this.txtTiengui = new System.Windows.Forms.TextBox();
			this.txtDC = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdbPhatloc = new System.Windows.Forms.RadioButton();
			this.rdbThuong = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lstDS = new System.Windows.Forms.ListBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnThemMoi);
			this.groupBox1.Controls.Add(this.btnThemDS);
			this.groupBox1.Controls.Add(this.dtpNgayGui);
			this.groupBox1.Controls.Add(this.cmbThang);
			this.groupBox1.Controls.Add(this.txtTiengui);
			this.groupBox1.Controls.Add(this.txtDC);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Controls.Add(this.txtMa);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(44, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(358, 398);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin KH gửi tiết kiệm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(257, 207);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "tháng";
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Location = new System.Drawing.Point(216, 353);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
			this.btnThemMoi.TabIndex = 5;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// btnThemDS
			// 
			this.btnThemDS.Location = new System.Drawing.Point(22, 353);
			this.btnThemDS.Name = "btnThemDS";
			this.btnThemDS.Size = new System.Drawing.Size(90, 23);
			this.btnThemDS.TabIndex = 5;
			this.btnThemDS.Text = "Thêm vào DS";
			this.btnThemDS.UseVisualStyleBackColor = true;
			this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
			// 
			// dtpNgayGui
			// 
			this.dtpNgayGui.Location = new System.Drawing.Point(127, 170);
			this.dtpNgayGui.Name = "dtpNgayGui";
			this.dtpNgayGui.Size = new System.Drawing.Size(141, 20);
			this.dtpNgayGui.TabIndex = 4;
			// 
			// cmbThang
			// 
			this.cmbThang.FormattingEnabled = true;
			this.cmbThang.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
			this.cmbThang.Location = new System.Drawing.Point(127, 204);
			this.cmbThang.Name = "cmbThang";
			this.cmbThang.Size = new System.Drawing.Size(121, 21);
			this.cmbThang.TabIndex = 3;
			// 
			// txtTiengui
			// 
			this.txtTiengui.Location = new System.Drawing.Point(127, 133);
			this.txtTiengui.Name = "txtTiengui";
			this.txtTiengui.Size = new System.Drawing.Size(164, 20);
			this.txtTiengui.TabIndex = 2;
			this.txtTiengui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienGui_KeyPress);
			// 
			// txtDC
			// 
			this.txtDC.Location = new System.Drawing.Point(127, 96);
			this.txtDC.Name = "txtDC";
			this.txtDC.Size = new System.Drawing.Size(164, 20);
			this.txtDC.TabIndex = 2;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(127, 65);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(164, 20);
			this.txtTen.TabIndex = 2;
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(127, 30);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(164, 20);
			this.txtMa.TabIndex = 2;
			this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(302, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "VND";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 212);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Thời gian gửi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ngày gửi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Số tiền gửi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Địa chỉ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Họ và tên KH";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã KH";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdbPhatloc);
			this.groupBox2.Controls.Add(this.rdbThuong);
			this.groupBox2.Location = new System.Drawing.Point(22, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 78);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Loại tiết kiệm";
			// 
			// rdbPhatloc
			// 
			this.rdbPhatloc.AutoSize = true;
			this.rdbPhatloc.Location = new System.Drawing.Point(178, 37);
			this.rdbPhatloc.Name = "rdbPhatloc";
			this.rdbPhatloc.Size = new System.Drawing.Size(64, 17);
			this.rdbPhatloc.TabIndex = 0;
			this.rdbPhatloc.TabStop = true;
			this.rdbPhatloc.Text = "Phát lộc";
			this.rdbPhatloc.UseVisualStyleBackColor = true;
			// 
			// rdbThuong
			// 
			this.rdbThuong.AutoSize = true;
			this.rdbThuong.Location = new System.Drawing.Point(6, 37);
			this.rdbThuong.Name = "rdbThuong";
			this.rdbThuong.Size = new System.Drawing.Size(62, 17);
			this.rdbThuong.TabIndex = 0;
			this.rdbThuong.TabStop = true;
			this.rdbThuong.Text = "Thường";
			this.rdbThuong.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lstDS);
			this.groupBox3.Location = new System.Drawing.Point(408, 36);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(380, 261);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Danh sách KH";
			// 
			// lstDS
			// 
			this.lstDS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstDS.FormattingEnabled = true;
			this.lstDS.Location = new System.Drawing.Point(3, 16);
			this.lstDS.Name = "lstDS";
			this.lstDS.Size = new System.Drawing.Size(374, 242);
			this.lstDS.TabIndex = 0;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(506, 380);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(75, 23);
			this.btnTim.TabIndex = 5;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(670, 380);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Tinh Lai Suat Tien Gui Tiet Kiem";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTiengui;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.DateTimePicker dtpNgayGui;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbPhatloc;
        private System.Windows.Forms.RadioButton rdbThuong;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label8;
    }
}

