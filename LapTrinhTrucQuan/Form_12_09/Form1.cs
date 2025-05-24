using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_12_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Thay doi mau chu cua richtextbox tu hop thoai color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //thay doi font chu cua richtextbox tu hop thoai font
            FontDialog fdl = new FontDialog();
            fdl.ShowColor = true;
            if (fdl.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fdl.Font;
                richTextBox1.BackColor = fdl.Color;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit", " Quit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                Application.Exit();
                
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "word|*.doc|Text|*.txt|all files|*.";
            ofd.FilterIndex = 2;
            ofd.Title = "select file to open";
            ofd.InitialDirectory = "D:\\Kì 1_Năm 3";
            ofd.ShowDialog();
            if( ofd.FileName.Trim() !="")
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                sr.Close();
                sr.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Word|*.rtf|Text|.txt|all file|*.";
            dlgSave.InitialDirectory = "D:\\Kì 1_Năm 3";
            dlgSave.FilterIndex = 2;
            dlgSave.Title = "Save File";
            dlgSave.DefaultExt = ".rft";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(dlgSave.FileName,
                        RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("Can not save file","Notification",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
