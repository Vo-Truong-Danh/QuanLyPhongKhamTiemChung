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
    public class BenhNhanDAL
    {
        DatabaseHelper dbHelper;
        SqlDataAdapter adap;
        SqlConnection conn;
        DataTable dt = new DataTable();
        public BenhNhanDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string selectStr = "select * from HOADON";
            adap = new SqlDataAdapter(selectStr, conn);
            if (dt.Rows.Count == 0)
                adap.Fill(dt);
            dbHelper = new DatabaseHelper(GeneralDAL.connectStrg);
        }

        public DataTable Load()
        {
            dt.Clear();
            string query = "SELECT * FROM BenhNhan";
            dt = dbHelper.ExecuteQuery(query);
            return dt;
        }

        public DataTable LayTTVC()
        {
            return SqlCMDLayBang("select * from Vaccine");
        }

        private DataTable SqlCMDLayBang(string truyxuat)
        {
            DataTable tmp = new DataTable();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tmp.Load(reader);
                    }
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch
            {
                return tmp = null;
            }
            return tmp;
        }
        private bool SqlCMD(string truyxuat)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        //==============================================================================
        public DataTable GetData()
        {
            return SqlCMDLayBang("select * from BenhNhan");
        }
        public DataTable GetFullData()
        {
            try
            {
                return dbHelper.ExecuteQuery("SELECT * FROM BENHNHAN");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string TaoMaBNTuDong()
        {
            try
            {
                string query = "SELECT dbo.FN_TaoMaBNMoi()";
                object result = dbHelper.ExecuteScalar(query);
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
        }
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            adap.Update(dt);
            dt.AcceptChanges();
        }
        public bool Insert(BenhNhanDTO bnDTO)
        {
            string query = "EXEC SP_ThemBenhNhan @MaBN, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai";

            SqlParameter[] parameters = {
                new SqlParameter("@MaBN", bnDTO.MaBN),
        new SqlParameter("@HoTen", bnDTO.HoTen),
        new SqlParameter("@NgaySinh", bnDTO.NgaySinh),
        new SqlParameter("@GioiTinh", bnDTO.GioiTinh),
        new SqlParameter("@DiaChi", bnDTO.DiaChi),
        new SqlParameter("@SoDienThoai", bnDTO.SoDienThoai)
    };

            dbHelper.ExecuteNonQuery(query, parameters);
            Load();

            return true;
        }

        public bool Edit(string MaBNCanSua, BenhNhanDTO bnDTONew)
        {
            string query = "EXEC SP_SuaBenhNhan @MaBN, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai";

            SqlParameter[] parameters = {
        new SqlParameter("@MaBN", bnDTONew.MaBN),
        new SqlParameter("@HoTen", bnDTONew.HoTen),
        new SqlParameter("@NgaySinh", bnDTONew.NgaySinh),
        new SqlParameter("@GioiTinh", bnDTONew.GioiTinh),
        new SqlParameter("@DiaChi", bnDTONew.DiaChi),
        new SqlParameter("@SoDienThoai", bnDTONew.SoDienThoai)
    };

            dbHelper.ExecuteNonQuery(query, parameters);
            Load();

            return true;
        }

        public bool Delete(string MaBN)
        {
            string query = "EXEC SP_XoaBenhNhan @MaBN";

            SqlParameter[] parameters = {
        new SqlParameter("@MaBN", MaBN)
    };

            dbHelper.ExecuteNonQuery(query, parameters);
            Load();

            return true;
        }


        public bool KTKhoaNgoai(string MaBN)
        {
            string queryCheckFK = @"
        SELECT count(*) FROM GHINHANTIEMCHUNG GN,HOADON HD,LICHTIEM LT WHERE GN.MaBN = @MaBN OR HD.MaBN=@MaBN OR LT.MaBN=@MaBN";

            using (SqlConnection conn = new SqlConnection(GeneralDAL.connectStrg))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryCheckFK, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBN", MaBN);
                    var result = cmd.ExecuteScalar();
                    int relatedCount = result != null ? Convert.ToInt32(result) : 0;
                    return relatedCount > 0;
                }
            }
        }
        LichTiemDAL LichTiemDAL = new LichTiemDAL();
        ChiTietHoaDonDAL cthdDAL = new ChiTietHoaDonDAL();
        HoaDonDAL HoaDonDAL = new HoaDonDAL();
        GhiNhanTiemChungDAL gnDAL = new GhiNhanTiemChungDAL();




        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            string query = "SELECT * FROM dbo.FN_TimKiemBN(@HoTen)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = searchStr }
            };

            DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

            return dataTable.DefaultView;
        }//HoTen LIKE N'%' + 'searchStr' + N'%';
        public List<string> DSMaBenhNhan()
        {
            List<string> list = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MaBN"] != null)
                {
                    if (dr["MaBN"].ToString() != "")
                    {
                        list.Add(dr["MaBN"].ToString());
                    }
                }
            }
            return list;
        }
        public bool KTMaBNCoTonTai(string mabn)
        {
            foreach (string ma in DSMaBenhNhan())
            {
                if (ma == mabn)
                    return true;
            }
            return false;
        }
    }
}
