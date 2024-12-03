using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.NetworkInformation;

namespace DAL
{
    public class LichTiemDAL
    {
        private DatabaseHelper dataHelper;
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        private static DataTable dt = new DataTable();

        public LichTiemDAL()
        {
            dataHelper = new DatabaseHelper(GeneralDAL.connectStrg);

            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(adap);
            conn.Open();
            string truyvansql = "select * from LICHTIEM";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
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

        public bool ThemLichTiemChoHoaDon(LichTiemDTO lt)
        {
            Load();
            try
            {
                DataRow[] rowDeUPD = dt.Select("MaVC = '" + lt.MaVC + "' and MaHD = '"+lt.MaHD+"' ");

                if (rowDeUPD.Length > 0)    
                {
                    DataRow row = rowDeUPD[0];
                    row["NgayHenTiem"] = lt.NgayHenTiem;

                    Load();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool AddLichTiem(LichTiemDTO lichTiemDTO)
        {
            string query = "INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai) VALUES (@MaLT, @MaHD, @MaBN, @MaVC, @NgayHenTiem, 'Chưa tiêm')";
            SqlParameter[] parameters = new SqlParameter[]
            {   
                new SqlParameter("MaLT", lichTiemDTO.MaLT),
                new SqlParameter("@MaHD", lichTiemDTO.MaHD),
                new SqlParameter("@MaBN", lichTiemDTO.MaBN),
                new SqlParameter("@MaVC", lichTiemDTO.MaVC),
                new SqlParameter ("@NgayHenTiem", lichTiemDTO.NgayHenTiem)
            };
            try
            {
                dataHelper.ExecuteNonQuery(query, parameters);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void UpdateLichTiem(LichTiemDTO lichTiemDTO)
        {
            string query = "UPDATE LICHTIEM SET NgayHenTiem = @NgayHenTiem, TrangThai = @TrangThai WHERE MaLT = @MaLT";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLT", lichTiemDTO.MaLT),
                new SqlParameter("@NgayHenTiem", lichTiemDTO.NgayHenTiem),
                new SqlParameter("@TrangThai", lichTiemDTO.TrangThai)
            };
            dataHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetLichTiem()
        {
            string query = "SELECT * FROM LICHTIEM";
            return dataHelper.ExecuteQuery(query);
        }

        public DataRowCollection GetFullDataRows()
        {
            return GetLichTiem().Rows;
        }

        public string NewIDLT()
        {
            int lastMaLT = 0;
            string query = "SELECT TOP 1 MaLT FROM LICHTIEM ORDER BY maLT DESC";
            string maLT = "LT000"; // Giá trị mặc định 
            SqlConnection conn = new SqlConnection(GeneralDAL.connectStrg);
            try
            {
                conn.Open();
                query = "SELECT TOP 1 maLT FROM LICHTIEM ORDER BY maLT DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maLT = result.ToString();
                    Console.WriteLine("Mã hóa đơn cuối cùng: " + maLT);
                    lastMaLT = int.Parse(maLT.Substring(2));
                    lastMaLT++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                // Hủy đối tượng kết nối (giải phóng bộ nhớ)
                conn.Dispose();
            }
            return "LT" + lastMaLT.ToString("D3");
        }

        public string GetNgayTiem(string maHD)
        {
            foreach (DataRow row in GetFullDataRows()) {

                if (row["MaHD"].ToString() == maHD)
                {
                    return row["NgayHenTiem"].ToString();
                }
            }
            return null;
        }

        public void DeleteLTByMaBN(string maBN)
        {
            string query = "DELETE FROM LICHTIEM WHERE MaBN = @MaBN";
            SqlParameter[] parameters = {
            new SqlParameter("@MaBN", maBN)
        };
            dataHelper.ExecuteNonQuery(query, parameters);
        }

        public void DeleteLTByMaHD(string maHD)
        {
            string query = "DELETE FROM LICHTIEM WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD)
        };
            dataHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
