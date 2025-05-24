using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace QLySinhVien_17_10
{
    internal class ProcessDatabase
    {
        SqlConnection con; //Đối tượng để kết nối
        DataTable tblSinhvien; //Đối tượng lưu bảng sinh viên
        public void Connect() //Kết nối
        {
            con = new SqlConnection(); //Khởi tạo đối tượng
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;
            AttachDbFilename = D:\Lập trình trực quan\QLySinhVien_17_10\LTTQ_QLySV.mdf ;Integrated Security=True";
            con.Open(); //Mở kết nối
        }
        public void Disconnect() //Ngắt kết nối
        {
            if (con.State == ConnectionState.Open) //nếu đang mở
            {
                con.Close(); //đóng
                con.Dispose(); //huỷ
            }
        }
        public DataTable DocBang(string sql)
        {
            Connect();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(tb);
            Disconnect();
            return tb;
        }
        public void RunSQL(string sql)
        {
            SqlCommand cm = new SqlCommand();
            Connect();
            cm.CommandText = sql;
            cm.Connection = con;
            cm.ExecuteNonQuery();
            Disconnect();
            cm.Dispose();
        }
    }
}

