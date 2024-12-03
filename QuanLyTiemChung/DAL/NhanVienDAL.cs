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
    public class NhanVienDAL
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;
        public int lastMaBN = 0;
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
        public NhanVienDTO CheckUserNameAndPassword(string userName, string password)
        {
            DataRow[] dr = dt.Select("MaNV = '" + userName + "' AND Pass = '" + password + "' ");
            if (dr.Length > 0)
            {
                NhanVienDTO tk = new NhanVienDTO()
                {
                    MaNV = userName.ToString(),
                    HoTen= dr[0]["HoTen"].ToString(),
                    Quyen = int.Parse(dr[0]["Quyen"].ToString()),
                };
                return tk;
            }
            else
            {
                return null;
            }
        }
        private int LayMaNVCuoiCung()
        {
            string query = "SELECT TOP 1 MaNV FROM NHANVIEN ORDER BY MaNV DESC";
            string maBN = "BN000";
            if (conn.State != ConnectionState.Open || conn == null)
            {
                conn = new SqlConnection(GeneralDAL.connectStrg);
            }
            try
            {
                conn.Open();
                query = "SELECT TOP 1 MaNV FROM NHANVIEN ORDER BY MaNV DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maBN = result.ToString();
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

                conn.Dispose();
            }
            return int.Parse(maBN.Substring(2));
        }
        public string TaoMaNVMoi()
        {
            lastMaBN = LayMaNVCuoiCung();
            lastMaBN++;
            return "NV" + lastMaBN.ToString("D3");
        }
        public DataTable Load()
        {
            adap.Update(dt);

            dt.AcceptChanges();

            dt.Clear();
            adap.Fill(dt);
            return dt;
        }
        public DataTable GetData()
        {
            return dt;
        }
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
        public void Insert(NhanVienDTO nvDTO)
        {
            DataRow newrow = dt.NewRow();
            newrow["MaNV"] = nvDTO.MaNV;
            newrow["HoTen"] = nvDTO.HoTen;
            newrow["GioiTinh"] = nvDTO.GioiTinh;
            newrow["ChucVu"] = nvDTO.ChucVu;
            newrow["DiaChi"] = nvDTO.DiaChi;
            newrow["SoDienThoai"] = nvDTO.SoDienThoai;
            newrow["Pass"] = nvDTO.Pass;
            newrow["Quyen"] = nvDTO.Quyen;

            dt.Rows.Add(newrow);
            Luu();
        }

        public bool Delete(string maNV)
        {
            try
            {
                DataRow[] rowDeXoa = dt.Select("MaVC = '" + maNV + "'");
                if (rowDeXoa.Length > 0)
                {
                    rowDeXoa[0].Delete();
                    Luu();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(NhanVienDTO nvDTO)
        {
            try
            {
                DataRow[] rowDeUPD = dt.Select("MaVC = '" + nvDTO.MaNV + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["HoTen"] = nvDTO.HoTen;
                    row["GioiTinh"] = nvDTO.GioiTinh;
                    row["ChucVu"] = nvDTO.ChucVu;
                    row["DiaChi"] = nvDTO.DiaChi;
                    row["SoDienThoai"] = nvDTO.SoDienThoai;
                    row["Pass"] = nvDTO.Pass;
                    row["Quyen"] = nvDTO.Quyen;

                    dt.Rows.Add(row);
                    Luu();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            adap.Update(dt);
            dt.AcceptChanges();
        }
    }
}
