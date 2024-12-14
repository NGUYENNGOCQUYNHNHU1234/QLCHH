using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLCHH
{
    class Ketnoi
    {
        SqlConnection cn = new SqlConnection(@"Data Source=QuynhChuong\SQLEXPRESS;Initial Catalog=QUANLYCUAHANGBANHOA;Integrated Security=True");
        //thay đổi tên máy trước khi chạy 
        public DataTable laydl(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
            return dt;
        }
        public void thucthi(string sql)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
