using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Excel_31_10
{
	internal class ProcessDatabase
	{
		string stringcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Lập trình trực quan\Demo_Excel_31_10\dtBase.mdf"";Integrated Security=True";
		SqlConnection con;
		public void KetNoi()
		{
			con = new SqlConnection(stringcon);
			if (con.State != ConnectionState.Open)
			{
				con.Open();
			}
		}

		public void DongKetNoi()
		{
			if (con.State == ConnectionState.Closed)
			{
				con.Close();
				con.Dispose();
			}
		}

		public DataTable DocBang(string sql)
		{
			DataTable dataTable = new DataTable();
			KetNoi();
			SqlDataAdapter adap = new SqlDataAdapter(sql, con);
			adap.Fill(dataTable);
			DongKetNoi();
			return dataTable;
		}

		public void Capnhat(string sql)
		{
			SqlCommand cmd = new SqlCommand();
			KetNoi();
			cmd.CommandText = sql;
			cmd.Connection = con;
			cmd.ExecuteNonQuery();
			DongKetNoi();

		}
	}
}
