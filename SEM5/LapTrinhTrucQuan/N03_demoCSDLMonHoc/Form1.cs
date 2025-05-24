using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N03_demoCSDLMonHoc
{
    public partial class Form1 : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //them vào bảng điểm (datagridView
            if(kiemtradl()==true)
            {
                string sql= "insert into tblDiem(MaM,TenM,STC,Diem) values('" +int.Parse(txtMa.Text) + "',N'" + txtTen.Text + "','"+int.Parse(txtSTC.Text)+ "','" + float.Parse(txtDiemThi.Text) + "')";
                pd.CapNhat(sql);
               dgvBangDiem.DataSource= pd.DocBang("select * from tblDiem");
            }
        }
        bool kiemtradl()
        {
            bool k = true;
            if (txtMa.Text.Trim().Equals("") || txtTen.Text.Trim() == ""
                || txtSTC.Text.Trim() == "" ||
                txtDiemThi.Text.Trim() == "")
            { MessageBox.Show("hay nhap du dl"); k = false; }
            else
            {
                DataTable tb = pd.DocBang("select * from tblDiem where MaM='" + int.Parse(txtMa.Text) + "'");
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("mon nay da ton tai"); k = false;
                }
            }
            return k;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //xoa
           if( MessageBox.Show("ban co muon xoa","thong bao",
               MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                pd.CapNhat("delete tblDiem where MaM ='" + int.Parse(txtMa.Text) + "'");
                MessageBox.Show("theem thanh cong");
               dgvBangDiem.DataSource= pd.DocBang("select * from tblDiem");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float tdiem = 0;int tongtc = 0;
            for(int i=0;i<dgvBangDiem.Rows.Count-1;i++)
            {
                int tc =int.Parse( dgvBangDiem.Rows[i].Cells[2].Value.ToString());
                float d = float.Parse(dgvBangDiem.Rows[i].Cells[3].Value.ToString());
                tongtc += tc;
                tdiem += tc * d;
            }
            MessageBox.Show("diem binh quan" + (tdiem / tongtc).ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvBangDiem.DataSource= pd.DocBang
                ("select * from tblDiem");
            dgvBangDiem.Columns[0].HeaderText = "Mã môn";
            dgvBangDiem.Columns[1].HeaderText = "Tên môn";
            dgvBangDiem.Columns[2].HeaderText = "Số tín chỉ";
            dgvBangDiem.Columns[3].HeaderText = "Điểm thi";
            dgvBangDiem.Columns[1].Width = 200;
        }

        private void dgvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBangDiem_Click(object sender, EventArgs e)
        {
            txtMa.Text = dgvBangDiem.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvBangDiem.CurrentRow.Cells[1].Value.ToString();
            txtSTC.Text = dgvBangDiem.CurrentRow.Cells[2].Value.ToString();
            txtDiemThi.Text = dgvBangDiem.CurrentRow.Cells[3].Value.ToString(); 
        }
    }
}
