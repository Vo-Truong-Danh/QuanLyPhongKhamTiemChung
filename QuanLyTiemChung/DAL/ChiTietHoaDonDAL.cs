using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;
        public ChiTietHoaDonDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from CHITIETHOADON";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(dt = new DataTable());
            conn.Close();
        }
        
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
        public bool DeleteChiTietHoaDonByMaBN(string maBN)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM CHITIETHOADON WHERE MaHD IN (SELECT MaHD FROM HOADON WHERE MaBN = @MaBN)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa CHITIETHOADON: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
                return false;
            }
        }


    }
}
