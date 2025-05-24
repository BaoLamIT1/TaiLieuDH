using System.Xml.Schema;

namespace Bai4_MenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMDientu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMdt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMdt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMdt3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMdt4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMdt5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMBienDoiCau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMTracNghiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMDatCau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMDientu,
            this.tsMBienDoiCau,
            this.tsMTracNghiem,
            this.tsMDatCau,
            this.tsMThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMDientu
            // 
            this.tsMDientu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMdt1,
            this.tsMdt2,
            this.tsMdt3,
            this.tsMdt4,
            this.tsMdt5});
            this.tsMDientu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMDientu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsMDientu.Name = "tsMDientu";
            this.tsMDientu.Size = new System.Drawing.Size(99, 32);
            this.tsMDientu.Text = "&Điền từ";
            // 
            // tsMdt1
            // 
            this.tsMdt1.Name = "tsMdt1";
            this.tsMdt1.Size = new System.Drawing.Size(274, 36);
            this.tsMdt1.Text = "Bài tập điền từ &1";
            this.tsMdt1.Click += new System.EventHandler(this.tsMdt1_Click);
            // 
            // tsMdt2
            // 
            this.tsMdt2.Name = "tsMdt2";
            this.tsMdt2.Size = new System.Drawing.Size(274, 36);
            this.tsMdt2.Text = "Bài tập điền từ &2";
            // 
            // tsMdt3
            // 
            this.tsMdt3.Name = "tsMdt3";
            this.tsMdt3.Size = new System.Drawing.Size(274, 36);
            this.tsMdt3.Text = "Bài tập điền từ &3";
            // 
            // tsMdt4
            // 
            this.tsMdt4.Name = "tsMdt4";
            this.tsMdt4.Size = new System.Drawing.Size(274, 36);
            this.tsMdt4.Text = "Bài tập điền từ &4";
            // 
            // tsMdt5
            // 
            this.tsMdt5.Name = "tsMdt5";
            this.tsMdt5.Size = new System.Drawing.Size(274, 36);
            this.tsMdt5.Text = "Bài tập điền từ &5";
            // 
            // tsMBienDoiCau
            // 
            this.tsMBienDoiCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMBienDoiCau.Name = "tsMBienDoiCau";
            this.tsMBienDoiCau.Size = new System.Drawing.Size(146, 32);
            this.tsMBienDoiCau.Text = "&Biến đổi câu";
            // 
            // tsMTracNghiem
            // 
            this.tsMTracNghiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMTracNghiem.Name = "tsMTracNghiem";
            this.tsMTracNghiem.Size = new System.Drawing.Size(214, 32);
            this.tsMTracNghiem.Text = "&Trắc nghiệm giới từ";
            // 
            // tsMDatCau
            // 
            this.tsMDatCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMDatCau.Name = "tsMDatCau";
            this.tsMDatCau.Size = new System.Drawing.Size(101, 32);
            this.tsMDatCau.Text = "Đặt &câu";
            // 
            // tsMThoat
            // 
            this.tsMThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMThoat.Name = "tsMThoat";
            this.tsMThoat.Size = new System.Drawing.Size(83, 32);
            this.tsMThoat.Text = "T&hoát";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bai Tap Tieng anh";               
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMdt1;
        private System.Windows.Forms.ToolStripMenuItem tsMdt2;
        private System.Windows.Forms.ToolStripMenuItem tsMdt3;
        private System.Windows.Forms.ToolStripMenuItem tsMDientu;
        private System.Windows.Forms.ToolStripMenuItem tsMdt4;
        private System.Windows.Forms.ToolStripMenuItem tsMdt5;
        private System.Windows.Forms.ToolStripMenuItem tsMBienDoiCau;
        private System.Windows.Forms.ToolStripMenuItem tsMTracNghiem;
        private System.Windows.Forms.ToolStripMenuItem tsMDatCau;
        private System.Windows.Forms.ToolStripMenuItem tsMThoat;
        //private System.Windows.Forms.Label 
        private void AddLable()
        {
            System.Windows.Forms.Label[] labels = new System.Windows.Forms.Label[10];
            for (int i = 1; i <=labels.Length ; i++)
            {
                labels[i] = new System.Windows.Forms.Label();
                labels[i].Text = "Câu " + i.ToString();
                this.Controls.Add(labels[i]);
            }
        }
       
    }
}

