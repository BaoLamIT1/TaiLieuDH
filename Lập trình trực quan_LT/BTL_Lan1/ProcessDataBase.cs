using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Lan1
{
    internal class ProcessDataBase
    {
        SqlConnection con;
       // DataTable tbDiem;
        public void Ketnoi()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(local);Initial Catalog=BTL_QuanLyNS_2;Integrated Security=True";
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Open)
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
			Ketnoi();
			SqlCommand cmm = new SqlCommand();
			cmm.Connection = con;
			cmm.CommandText = sql;
            cmm.ExecuteNonQuery();
            DongKetNoi();

        }
    }
}
