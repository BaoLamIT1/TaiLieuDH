namespace CSDL_24_10
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtSoTC = new System.Windows.Forms.TextBox();
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên môn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số tín";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mã môn";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 257);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Điểm thi";
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(148, 100);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(181, 24);
			this.txtMa.TabIndex = 1;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(148, 140);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(181, 24);
			this.txtTen.TabIndex = 1;
			// 
			// txtSoTC
			// 
			this.txtSoTC.Location = new System.Drawing.Point(148, 198);
			this.txtSoTC.Name = "txtSoTC";
			this.txtSoTC.Size = new System.Drawing.Size(181, 24);
			this.txtSoTC.TabIndex = 1;
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(148, 251);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(181, 24);
			this.txtDiem.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(4, 340);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(97, 49);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm vào DS";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(148, 340);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 49);
			this.button2.TabIndex = 2;
			this.button2.Text = "Xoá";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnThongKe
			// 
			this.btnThongKe.Location = new System.Drawing.Point(307, 340);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(97, 49);
			this.btnThongKe.TabIndex = 2;
			this.btnThongKe.Text = "Thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Location = new System.Drawing.Point(467, 340);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(97, 49);
			this.btnLamMoi.TabIndex = 2;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(647, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 514);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách các môn";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(659, 59);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(512, 473);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSoTC);
			this.groupBox2.Controls.Add(this.btnLamMoi);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnThongKe);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtDiem);
			this.groupBox2.Controls.Add(this.txtMa);
			this.groupBox2.Controls.Add(this.txtTen);
			this.groupBox2.Location = new System.Drawing.Point(28, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(570, 525);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin điểm thi";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(1200, 623);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

