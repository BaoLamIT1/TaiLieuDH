namespace demo_26_9
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
            this.hÌnhChữNhâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GiaiPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bac1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bac2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.HCNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hÌnhChữNhâtToolStripMenuItem,
            this.GiaiPTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1416, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hÌnhChữNhâtToolStripMenuItem
            // 
            this.hÌnhChữNhâtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HCNToolStripMenuItem,
            this.toolStripSeparator2,
            this.HTToolStripMenuItem});
            this.hÌnhChữNhâtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hÌnhChữNhâtToolStripMenuItem.Name = "hÌnhChữNhâtToolStripMenuItem";
            this.hÌnhChữNhâtToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.hÌnhChữNhâtToolStripMenuItem.Text = "Tính diện tích";
            // 
            // HTToolStripMenuItem
            // 
            this.HTToolStripMenuItem.Name = "HTToolStripMenuItem";
            this.HTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HTToolStripMenuItem.Text = "Hình tròn";
            // 
            // GiaiPTToolStripMenuItem
            // 
            this.GiaiPTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bac1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.Bac2ToolStripMenuItem});
            this.GiaiPTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaiPTToolStripMenuItem.Name = "GiaiPTToolStripMenuItem";
            this.GiaiPTToolStripMenuItem.Size = new System.Drawing.Size(123, 21);
            this.GiaiPTToolStripMenuItem.Text = "Giải Phương Trình";
            // 
            // Bac1ToolStripMenuItem
            // 
            this.Bac1ToolStripMenuItem.Name = "Bac1ToolStripMenuItem";
            this.Bac1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Bac1ToolStripMenuItem.Text = "Bậc nhất";
            this.Bac1ToolStripMenuItem.Click += new System.EventHandler(this.Bac1ToolStripMenuItem_Click);
            // 
            // Bac2ToolStripMenuItem
            // 
            this.Bac2ToolStripMenuItem.Name = "Bac2ToolStripMenuItem";
            this.Bac2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Bac2ToolStripMenuItem.Text = "Bậc hai";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // HCNToolStripMenuItem
            // 
            this.HCNToolStripMenuItem.Image = global::demo_26_9.Properties.Resources.一番くじ_____I_m_Ready____A;
            this.HCNToolStripMenuItem.Name = "HCNToolStripMenuItem";
            this.HCNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HCNToolStripMenuItem.Text = "Hình chữ nhật";
            this.HCNToolStripMenuItem.Click += new System.EventHandler(this.HCNToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hÌnhChữNhâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HCNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GiaiPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bac1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bac2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

