using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;
        public NhanVienDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from NhanVien";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(dt = new DataTable());
            conn.Close();
        }
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
    }
}
