using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLCHH
{
    class Data
    {
        //fdtrs
        SqlConnection cn;
        public Data(string srvname, string dbname)
        {
            cn = new SqlConnection(@"Data Source=" + srvname + ";Initial Catalog=" + dbname + ";Integrated Security=True");
        }
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
            cmd.ExecuteNonQuery();//
            cn.Close();
        }
    }
}
