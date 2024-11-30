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
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        SqlDataAdapter adap;
        SqlConnection conn;
        DataTable dt;
        private int lastMaBN = 0;
        public BenhNhanDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            ds = new DataSet();
            string selectStr = "select * from BENHNHAN";
            adap = new SqlDataAdapter(selectStr, conn);
            adap.Fill(ds, "BENHNHAN");
            // Them khoa chinh
            key[0] = ds.Tables["BENHNHAN"].Columns[0];
            ds.Tables["BENHNHAN"].PrimaryKey = key;
            lastMaBN = LayMaBNCuoiCung();
            adap.Fill(dt = new DataTable());
        }
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
        
        private int LayMaBNCuoiCung()
        {
            // nếu mã cuối cùng là "BN005" thì hàm này trả về 5
            string query = "SELECT TOP 1 MaBN FROM BENHNHAN ORDER BY MaBN DESC";
            string maBN = "BN000"; // Giá trị mặc định 
            if (conn.State != ConnectionState.Open||conn==null)
            {
              conn  = new SqlConnection(GeneralDAL.connectStrg);
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

                // Hủy đối tượng kết nối (giải phóng bộ nhớ)
                conn.Dispose();
            }
            return int.Parse(maBN.Substring(2));
        }
        public string TaoMaBNMoi()
        {
            lastMaBN++; // Tăng giá trị của mã BN
            return "BN" + lastMaBN.ToString("D3"); // Định dạng với 3 chữ số, ví dụ "BN001"
        }
        public bool Insert(BenhNhanDTO bnDTO)
        {
            try
            {
                DataRow newRow = ds.Tables["BENHNHAN"].NewRow();
                newRow["MaBN"]=bnDTO.MaBN;
                newRow["HoTen"] = bnDTO.HoTen;
                newRow["NgaySinh"] = bnDTO.NgaySinh;
                newRow["GioiTinh"] = bnDTO.GioiTinh;
                newRow["DiaChi"] = bnDTO.DiaChi;
                newRow["SoDienThoai"] = bnDTO.SoDienThoai;

                // Thêm dòng dữ liệu vào DataSet
                ds.Tables["BENHNHAN"].Rows.Add(newRow);

                // Cập nhật CSDL
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "BENHNHAN");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm vào CSDL: " + ex.Message);
                return false;
            }
        }

        public DataRowCollection GetFullDataRows()
        {
            return ds.Tables["BENHNHAN"].Rows;
        }
        public bool Edit(string MaBNCanSua, BenhNhanDTO bnDTONew)
        {
            try
            {
                // Tim dong du lieu can sua dua theo MaBN
                DataRow dr = ds.Tables["BENHNHAN"].Rows.Find(MaBNCanSua);
                // Edit
                if (dr != null)
                {
                    dr["HoTen"] = bnDTONew.HoTen;
                    dr["NgaySinh"] = bnDTONew.NgaySinh;
                    dr["GioiTinh"] = bnDTONew.GioiTinh;
                    dr["DiaChi"] = bnDTONew.DiaChi;
                    dr["SoDienThoai"] = bnDTONew.SoDienThoai;
                }
                // Cap nhat trong CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(adap);
                adap.Update(ds, "BENHNHAN");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string maBN)
        {
            try
            {
                // Tìm dòng dữ liệu cần xóa theo MaBN
                DataRow dr = ds.Tables["BENHNHAN"].Rows.Find(maBN);
                if (dr != null)
                {
                    dr.Delete();
                    // Cập nhật trong CSDL
                    SqlCommandBuilder cb = new SqlCommandBuilder(adap);
                    adap.Update(ds, "BENHNHAN");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa: " + ex.Message);
                return false;
            }
        }
        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            DataTable dt = ds.Tables["BENHNHAN"];
            DataView dtView = new DataView(dt);
            dtView.RowFilter = "HoTen LIKE '%" + searchStr.Replace("'", "''") + "%'";
            return dtView;
        }//HoTen LIKE N'%' + 'searchStr' + N'%';
        public void ClearDataSet()
        {
            ds.Tables["BENHNHAN"].Clear();
        }
    }
}
