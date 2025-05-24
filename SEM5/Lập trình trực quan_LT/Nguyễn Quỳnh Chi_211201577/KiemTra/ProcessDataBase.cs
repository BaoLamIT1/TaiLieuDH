using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
	internal class ProcessDataBase
	{
		string stringCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LapTrinhTrucQuan\KiemTra\TacPham.mdf;Integrated Security=True";
		SqlConnection con;

		public void KetNoi()
		{
			con = new SqlConnection(stringCon);
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
			DataTable tb = new DataTable();
			KetNoi();
			SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
			adapter.Fill(tb);
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
			DongKetNoi();
		}
	}
}
