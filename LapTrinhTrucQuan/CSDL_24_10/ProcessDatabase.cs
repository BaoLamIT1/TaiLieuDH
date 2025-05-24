using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CSDL_24_10
{
    internal class ProcessDatabase
    {
        SqlConnection con;
        DataTable tbDiem;
        public void Ketnoi()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Lập trình trực quan\CSDL_24_10\Database1.mdf; 
                                    Integrated Security = True";
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void DongKetNoi()
        {
            if(con.State != ConnectionState.Open)
            con.Close();
            con.Dispose();

        }
        public DataTable DocBang(string sql)
        {
            Ketnoi();
            DataTable tb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(tb);
            DongKetNoi();
            return tb;

        }
        public void CapNhat(string sql) 
        {
            SqlCommand cmm = new SqlCommand();
            Ketnoi() ;
            cmm.CommandText = sql;
            cmm.Connection = con;
            cmm.ExecuteNonQuery();
            DongKetNoi();
            cmm.Dispose();
        }
    }
}
