namespace B05_29_08_FormBanHang
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDanhSachMatHang = new System.Windows.Forms.ListBox();
            this.lstHangDatMua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.rdbTheTinDung = new System.Windows.Forms.RadioButton();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chbDienThoai = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbMail = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(184, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(491, 42);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 20);
            this.txtDienThoai.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hàng đặt mua";
            // 
            // lstDanhSachMatHang
            // 
            this.lstDanhSachMatHang.FormattingEnabled = true;
            this.lstDanhSachMatHang.Location = new System.Drawing.Point(69, 130);
            this.lstDanhSachMatHang.Name = "lstDanhSachMatHang";
            this.lstDanhSachMatHang.Size = new System.Drawing.Size(235, 147);
            this.lstDanhSachMatHang.TabIndex = 2;
            this.lstDanhSachMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDanhSachMatHang_MouseDoubleClick);
            // 
            // lstHangDatMua
            // 
            this.lstHangDatMua.FormattingEnabled = true;
            this.lstHangDatMua.Location = new System.Drawing.Point(425, 130);
            this.lstHangDatMua.Name = "lstHangDatMua";
            this.lstHangDatMua.Size = new System.Drawing.Size(247, 147);
            this.lstHangDatMua.TabIndex = 3;
            this.lstHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHangDatMua_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTheTinDung);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Location = new System.Drawing.Point(69, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbMail);
            this.groupBox2.Controls.Add(this.chbFax);
            this.groupBox2.Controls.Add(this.chbDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(425, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(29, 29);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(66, 17);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(29, 62);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(44, 17);
            this.rdbSec.TabIndex = 0;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Séc";
            this.rdbSec.UseVisualStyleBackColor = true;
            // 
            // rdbTheTinDung
            // 
            this.rdbTheTinDung.AutoSize = true;
            this.rdbTheTinDung.Location = new System.Drawing.Point(29, 95);
            this.rdbTheTinDung.Name = "rdbTheTinDung";
            this.rdbTheTinDung.Size = new System.Drawing.Size(87, 17);
            this.rdbTheTinDung.TabIndex = 0;
            this.rdbTheTinDung.TabStop = true;
            this.rdbTheTinDung.Text = "Thẻ tín dụng";
            this.rdbTheTinDung.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(178, 494);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(425, 494);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chbDienThoai
            // 
            this.chbDienThoai.AutoSize = true;
            this.chbDienThoai.Location = new System.Drawing.Point(37, 29);
            this.chbDienThoai.Name = "chbDienThoai";
            this.chbDienThoai.Size = new System.Drawing.Size(74, 17);
            this.chbDienThoai.TabIndex = 0;
            this.chbDienThoai.Text = "Điện thoại";
            this.chbDienThoai.UseVisualStyleBackColor = true;
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(37, 62);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(43, 17);
            this.chbFax.TabIndex = 0;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbMail
            // 
            this.chbMail.AutoSize = true;
            this.chbMail.Location = new System.Drawing.Point(37, 96);
            this.chbMail.Name = "chbMail";
            this.chbMail.Size = new System.Drawing.Size(51, 17);
            this.chbMail.TabIndex = 0;
            this.chbMail.Text = "Email";
            this.chbMail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHangDatMua);
            this.Controls.Add(this.lstDanhSachMatHang);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bán sách qua mạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDanhSachMatHang;
        private System.Windows.Forms.ListBox lstHangDatMua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTheTinDung;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chbMail;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoai;
    }
}

