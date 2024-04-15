using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_24_10
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.DocBang("select * from tbDiem");
            dataGridView1.Columns[0].HeaderText = "Mã môn: ";
            dataGridView1.Columns[1].HeaderText = "Tên môn: ";
            dataGridView1.Columns[2].HeaderText = "STC môn: ";
            dataGridView1.Columns[3].HeaderText = "Điểm thi: ";
            dataGridView1.Columns[1].Width = 200;
        }

        bool kiemtradl()
        {
            bool k = true;
            if (txtMa.Text.Trim().Equals("") || txtTen.Text.Trim() == ""
            || txtSoTC.Text.Trim() == "" || txtDiem.Text.Trim() == "")
            { MessageBox.Show("Hay nhap du dl "); k = false; }
            else
            {
                DataTable tb = pd.DocBang("Select * from tbDiem where MaM = '" + int.Parse(txtMa.Text) + "'");
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("mon nay da ton tai "); k = false;
                }
            }
                return k;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(kiemtradl()==true) 
            {
                string sql = "insert into tbDiem(MaM, TenM, STC, Diem) values (N'" + int.Parse(txtMa.Text) + "', N'" + txtTen.Text + "', N'" 
                            + int.Parse(txtSoTC.Text) + "', N'" + int.Parse(txtDiem.Text) + "')";
                pd.CapNhat(sql);
                dataGridView1.DataSource = pd.DocBang("select * from tbDiem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //xoa
            if (MessageBox.Show("ban co muon xoa khong", "thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                pd.CapNhat("delete tbDiem where MaM ='" + int.Parse(txtMa.Text) + "'");

            }
            dataGridView1.DataSource = pd.DocBang("select * from tbDiem");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            float tdiem = 0;
            int tongtc = 0;
            for(int i = 0;i<dataGridView1.Rows.Count-1;i++)
            {
                int tc = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                float d = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                tongtc += tc;
                tdiem += d;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoTC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDiem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

       
    }
}
