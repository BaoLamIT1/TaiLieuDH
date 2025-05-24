namespace BaiThongKeBTL
{
    partial class FormBCQuaTrinhDT
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
            this.btnHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNVtheoQTDT = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaNVKT = new System.Windows.Forms.TextBox();
            this.btnHienMaNV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaQTDTKT = new System.Windows.Forms.TextBox();
            this.btnHienMaQTDT = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVtheoQTDT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHien);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Location = new System.Drawing.Point(544, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 270);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nút";
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(15, 42);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(95, 23);
            this.btnHien.TabIndex = 3;
            this.btnHien.Text = "Hiện tất cả";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(15, 148);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(15, 97);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(95, 23);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất ";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "BÁO CÁO QUÁ TRÌNH ĐÀO TẠO ĐANG DIỄN RA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã quá trình đào tạo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // dgvNVtheoQTDT
            // 
            this.dgvNVtheoQTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVtheoQTDT.Location = new System.Drawing.Point(12, 162);
            this.dgvNVtheoQTDT.Name = "dgvNVtheoQTDT";
            this.dgvNVtheoQTDT.RowHeadersWidth = 51;
            this.dgvNVtheoQTDT.RowTemplate.Height = 24;
            this.dgvNVtheoQTDT.Size = new System.Drawing.Size(526, 270);
            this.dgvNVtheoQTDT.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaNVKT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnHienMaNV);
            this.groupBox3.Location = new System.Drawing.Point(12, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theo mã NV";
            // 
            // txtMaNVKT
            // 
            this.txtMaNVKT.Location = new System.Drawing.Point(153, 29);
            this.txtMaNVKT.Name = "txtMaNVKT";
            this.txtMaNVKT.Size = new System.Drawing.Size(139, 22);
            this.txtMaNVKT.TabIndex = 1;
            // 
            // btnHienMaNV
            // 
            this.btnHienMaNV.Location = new System.Drawing.Point(153, 59);
            this.btnHienMaNV.Name = "btnHienMaNV";
            this.btnHienMaNV.Size = new System.Drawing.Size(75, 23);
            this.btnHienMaNV.TabIndex = 0;
            this.btnHienMaNV.Text = "Hiện";
            this.btnHienMaNV.UseVisualStyleBackColor = true;
            this.btnHienMaNV.Click += new System.EventHandler(this.btnHienMaNV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaQTDTKT);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnHienMaQTDT);
            this.groupBox4.Location = new System.Drawing.Point(411, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Theo mã QTDT";
            // 
            // txtMaQTDTKT
            // 
            this.txtMaQTDTKT.Location = new System.Drawing.Point(168, 25);
            this.txtMaQTDTKT.Name = "txtMaQTDTKT";
            this.txtMaQTDTKT.Size = new System.Drawing.Size(140, 22);
            this.txtMaQTDTKT.TabIndex = 2;
            // 
            // btnHienMaQTDT
            // 
            this.btnHienMaQTDT.Location = new System.Drawing.Point(168, 59);
            this.btnHienMaQTDT.Name = "btnHienMaQTDT";
            this.btnHienMaQTDT.Size = new System.Drawing.Size(75, 23);
            this.btnHienMaQTDT.TabIndex = 0;
            this.btnHienMaQTDT.Text = "Hiện";
            this.btnHienMaQTDT.UseVisualStyleBackColor = true;
            this.btnHienMaQTDT.Click += new System.EventHandler(this.btnHienMaQTDT_Click);
            // 
            // FormBCQuaTrinhDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNVtheoQTDT);
            this.Name = "FormBCQuaTrinhDT";
            this.Text = "FormBCQuaTrinhDT";
            this.Load += new System.EventHandler(this.FormBCQuaTrinhDT_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVtheoQTDT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNVtheoQTDT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaNVKT;
        private System.Windows.Forms.Button btnHienMaNV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaQTDTKT;
        private System.Windows.Forms.Button btnHienMaQTDT;
        private System.Windows.Forms.Button btnHien;
    }
}