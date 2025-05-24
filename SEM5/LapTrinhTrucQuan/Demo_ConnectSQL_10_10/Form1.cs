using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ConnectSQL_10_10
{
    public partial class Form1 : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvChatLieu.DataSource = pd.DocBang("select * from tbChatLieu");
        }
    }
}
