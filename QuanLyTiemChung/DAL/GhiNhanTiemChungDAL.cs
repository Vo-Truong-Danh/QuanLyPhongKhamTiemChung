using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GhiNhanTiemChungDAL
    {
        SqlDataAdapter adap;
        SqlConnection conn;
        private static DataTable dt = new DataTable();

        public GhiNhanTiemChungDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string truyvansql = "select * from GHINHANTIEMCHUNG";
            adap = new SqlDataAdapter(truyvansql, conn);
            if (dt.Rows.Count == 0)
                adap.Fill(dt);
        }
        public DataTable Load()
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adap);
                adap.Update(dt);

                dt.AcceptChanges();
                dt.Clear();
                adap.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong Load: " + ex.Message);
                throw;
            }
        }
        public DataTable GetData()
        {
            Load();
            return dt;
        }
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        public bool XacNhanTiem(LichTiemDTO xn,string manv)
        {
            try
            {

                DataRow newrow = dt.NewRow();
                newrow["MaBN"] = xn.MaBN;
                newrow["MaVC"] = xn.MaVC;
                newrow["MaNV"] = manv;
                newrow["MaLT"] = xn.MaLT;
                newrow["MaHD"] = xn.MaHD;
                newrow["NgayTiem"] = xn.NgayHenTiem;
                newrow["TinhTrangSucKhoe"] = xn.TrangThai;

                dt.Rows.Add(newrow);
                Load();
                return true;
            }
            catch
            {
                return false;
            }            
        }
        public bool DeleteGhiNhanTiemChungByMaBN(string maBN)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM GHINHANTIEMCHUNG WHERE MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa GHINHANTIEMCHUNG: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
                return false;
            }
        }

    }
}
