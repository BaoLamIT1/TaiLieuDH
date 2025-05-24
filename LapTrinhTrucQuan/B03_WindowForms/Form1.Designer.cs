namespace B03_WindowForms
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.showList = new System.Windows.Forms.ListBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btQR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaSach";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(445, 74);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(198, 20);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TenSach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TacGia";
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(445, 162);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(198, 20);
            this.txtTG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SoLuong";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(445, 221);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(198, 20);
            this.txtSL.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(445, 116);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(198, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "QRCode";
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(445, 274);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(198, 20);
            this.txtQR.TabIndex = 1;
            // 
            // showList
            // 
            this.showList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showList.FormattingEnabled = true;
            this.showList.Location = new System.Drawing.Point(3, 16);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(450, 136);
            this.showList.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(690, 60);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(92, 44);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm vào DS";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(690, 116);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(92, 20);
            this.btLamMoi.TabIndex = 4;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(687, 162);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(92, 30);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(690, 212);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(92, 29);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showList);
            this.groupBox1.Location = new System.Drawing.Point(326, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hiện có";
            // 
            // btQR
            // 
            this.btQR.Location = new System.Drawing.Point(690, 264);
            this.btQR.Name = "btQR";
            this.btQR.Size = new System.Drawing.Size(89, 31);
            this.btQR.TabIndex = 6;
            this.btQR.Text = "Tim theo QR";
            this.btQR.UseVisualStyleBackColor = true;
            this.btQR.Click += new System.EventHandler(this.btQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 583);
            this.Controls.Add(this.btQR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btQR;
    }
}

