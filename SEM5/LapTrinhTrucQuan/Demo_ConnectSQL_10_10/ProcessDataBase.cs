using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Demo_ConnectSQL_10_10
{
    internal class ProcessDataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Lập trình trực quan\Demo_ConnectSQL_10_10\QLHangHoa.mdf"";Integrated Security=True");
        public void KetNoi()
        {
            if (con.State != ConnectionState.Open) 
                con.Open();
        }
        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Closed)
            con.Close(); 
            con.Dispose();
        }
        public DataTable DocBang(string sql)
        {
            KetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void CapNhatDL(string sql)
        {
            SqlCommand cm = new SqlCommand();
            KetNoi();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            DongKetNoi();
            cm.Dispose();
        }

    }
}
