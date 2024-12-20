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
        SqlDataAdapter adap;
        SqlConnection conn;
        DataTable dt = new DataTable();
        private int lastMaBN = 0;
        public BenhNhanDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string selectStr = "select * from BENHNHAN";
            adap = new SqlDataAdapter(selectStr, conn);
            if (dt.Rows.Count == 0)
                adap.Fill(dt);
        }
        public DataTable GetData()
        {
            return dt;
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
        private int LayMaBNCuoiCung()
        {
            string query = "SELECT TOP 1 MaBN FROM BENHNHAN ORDER BY MaBN DESC";
            string maBN = "BN000"; 
            if (conn.State != ConnectionState.Open || conn == null)
            {
                conn = new SqlConnection(GeneralDAL.connectStrg);
            }
            try
            {
                conn.Open();
                query = "SELECT TOP 1 MaBN FROM BENHNHAN ORDER BY MaBN DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maBN = result.ToString();
                    Console.WriteLine("Mã bệnh nhân cuối cùng: " + maBN);
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
        public string TaoMaBNMoi()
        {
            lastMaBN = LayMaBNCuoiCung();
            lastMaBN++;
            return "BN" + lastMaBN.ToString("D3");
        }
        public bool Insert(BenhNhanDTO bnDTO)
        {
            try
            {
                DataRow newRow = dt.NewRow();
                newRow["MaBN"] = bnDTO.MaBN;
                newRow["HoTen"] = bnDTO.HoTen;
                newRow["NgaySinh"] = bnDTO.NgaySinh;
                newRow["GioiTinh"] = bnDTO.GioiTinh;
                newRow["DiaChi"] = bnDTO.DiaChi;
                newRow["SoDienThoai"] = bnDTO.SoDienThoai;

                dt.Rows.Add(newRow);

                Luu();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm vào CSDL: " + ex.Message);
                return false;
            }
        }

        public DataTable GetFullData()
        {
            return dt;
        }
        public bool Edit(string MaBNCanSua, BenhNhanDTO bnDTONew)
        {
            try
            {
                DataRow dr = dt.Select("MaBN = '" + MaBNCanSua + "'").FirstOrDefault();
                if (dr != null)
                {
                    dr["HoTen"] = bnDTONew.HoTen;
                    dr["NgaySinh"] = bnDTONew.NgaySinh;
                    dr["GioiTinh"] = bnDTONew.GioiTinh;
                    dr["DiaChi"] = bnDTONew.DiaChi;
                    dr["SoDienThoai"] = bnDTONew.SoDienThoai;
                }
                Luu();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string MaBN)
        {
            try
            {
                DataRow dr = dt.Select("MaBN = '" + MaBN + "'").FirstOrDefault();
                if (dr != null)
                {
                    dr.Delete();
                    Luu();
                    return true;
                }
                return false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa bệnh nhân: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
                return false;
            }
        }



        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            DataView dtView = new DataView(dt);
            dtView.RowFilter = "HoTen LIKE '%" + searchStr.Replace("'", "''") + "%'";
            return dtView;
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
                if(ma==mabn)
                    return true;
            }
            return false;
        }
    }
}
