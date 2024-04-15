namespace BTL_Lan1
{
	partial class TimKiem1
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
			this.txtma = new System.Windows.Forms.TextBox();
			this.btntk = new System.Windows.Forms.Button();
			this.nv1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nv1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(184, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Nhân Viên :";
			// 
			// txtma
			// 
			this.txtma.Location = new System.Drawing.Point(361, 44);
			this.txtma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtma.Name = "txtma";
			this.txtma.Size = new System.Drawing.Size(528, 30);
			this.txtma.TabIndex = 1;
			// 
			// btntk
			// 
			this.btntk.Image = global::BTL_Lan1.Properties.Resources.timkiem;
			this.btntk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btntk.Location = new System.Drawing.Point(909, 38);
			this.btntk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btntk.Name = "btntk";
			this.btntk.Size = new System.Drawing.Size(143, 40);
			this.btntk.TabIndex = 2;
			this.btntk.Text = "       Tìm kiếm";
			this.btntk.UseVisualStyleBackColor = true;
			this.btntk.Click += new System.EventHandler(this.btntk_Click);
			// 
			// nv1
			// 
			this.nv1.BackgroundColor = System.Drawing.Color.LightBlue;
			this.nv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nv1.Location = new System.Drawing.Point(93, 195);
			this.nv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nv1.Name = "nv1";
			this.nv1.RowHeadersWidth = 51;
			this.nv1.RowTemplate.Height = 24;
			this.nv1.Size = new System.Drawing.Size(1108, 297);
			this.nv1.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtma);
			this.groupBox2.Controls.Add(this.btntk);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(93, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1108, 115);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BTL_Lan1.Properties.Resources.tk1;
			this.pictureBox1.Location = new System.Drawing.Point(25, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// TimKiem1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1260, 530);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.nv1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "TimKiem1";
			this.Text = "Tìm kiếm QTDT QTCT theo mã nhân viên";
			((System.ComponentModel.ISupportInitialize)(this.nv1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtma;
		private System.Windows.Forms.Button btntk;
		private System.Windows.Forms.DataGridView nv1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}