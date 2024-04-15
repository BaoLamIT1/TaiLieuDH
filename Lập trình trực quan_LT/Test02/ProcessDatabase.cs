using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
	internal class ProcessDatabase
	{
		SqlConnection con;

		public void KetNoi()
		{
			con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Kì 1_Năm 3\Lập trình trực quan_LT\Test02\Database1.mdf"";Integrated Security=True");
			//if (con.State != ConnectionState.Open)
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
			SqlDataAdapter da = new SqlDataAdapter(sql, con);
			da.Fill(tb);
			DongKetNoi();
			return tb;
		}

		public void CapNhat(string sql)
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
