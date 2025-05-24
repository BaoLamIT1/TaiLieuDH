namespace BaiThongKeBTL
{
    partial class FormTKNVtheoNNvaCM
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
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNVTheoNNvaCM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cbChuyenMon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTheoNNvaCM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXuat);
            this.groupBox2.Controls.Add(this.btnHien);
            this.groupBox2.Location = new System.Drawing.Point(544, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nút";
            // 
            // btnHien
            // 
            this.btnHien.Location = new System.Drawing.Point(15, 43);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(75, 23);
            this.btnHien.TabIndex = 0;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            this.btnHien.Click += new System.EventHandler(this.btnHien_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(15, 97);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất ";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(15, 148);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông kê nhân viên ";
            // 
            // dgvNVTheoNNvaCM
            // 
            this.dgvNVTheoNNvaCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVTheoNNvaCM.Location = new System.Drawing.Point(12, 168);
            this.dgvNVTheoNNvaCM.Name = "dgvNVTheoNNvaCM";
            this.dgvNVTheoNNvaCM.RowHeadersWidth = 51;
            this.dgvNVTheoNNvaCM.RowTemplate.Height = 24;
            this.dgvNVTheoNNvaCM.Size = new System.Drawing.Size(526, 270);
            this.dgvNVTheoNNvaCM.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngoại ngữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên môn";
            // 
            // cbNgoaiNgu
            // 
            this.cbNgoaiNgu.FormattingEnabled = true;
            this.cbNgoaiNgu.Location = new System.Drawing.Point(165, 41);
            this.cbNgoaiNgu.Name = "cbNgoaiNgu";
            this.cbNgoaiNgu.Size = new System.Drawing.Size(143, 24);
            this.cbNgoaiNgu.TabIndex = 2;
            this.cbNgoaiNgu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbNgoaiNgu_MouseClick);
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.Location = new System.Drawing.Point(471, 41);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(206, 24);
            this.cbChuyenMon.TabIndex = 3;
            this.cbChuyenMon.SelectedIndexChanged += new System.EventHandler(this.cbChuyenMon_SelectedIndexChanged);
            this.cbChuyenMon.Click += new System.EventHandler(this.cbChuyenMon_Click);
            this.cbChuyenMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbChuyenMon_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChuyenMon);
            this.groupBox1.Controls.Add(this.cbNgoaiNgu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // FormTKNVtheoNNvaCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNVTheoNNvaCM);
            this.Name = "FormTKNVtheoNNvaCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FormTKNVtheoNNvaCM_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVTheoNNvaCM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNVTheoNNvaCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNgoaiNgu;
        private System.Windows.Forms.ComboBox cbChuyenMon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

