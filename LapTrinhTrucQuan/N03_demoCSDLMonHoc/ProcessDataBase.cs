using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace N03_demoCSDLMonHoc
{
    class ProcessDataBase
    {
        string stringcon= @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Lập trình trực quan\CSDL_24_10\Database1.mdf; 
                                    Integrated Security = True";
        SqlConnection con;
        public void KetNoi()
        {
            con = new SqlConnection(stringcon);
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
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void CapNhat(string sql)
        {
            SqlCommand cmm = new SqlCommand();
            KetNoi();
            cmm.CommandText = sql;
            cmm.Connection = con;
            cmm.ExecuteNonQuery();
            cmm.Dispose();
            DongKetNoi();
        }
    }
}
