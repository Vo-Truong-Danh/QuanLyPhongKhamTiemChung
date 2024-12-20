﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonDAL
    {
        DatabaseHelper dbHelper;
        SqlDataAdapter adap;
        SqlConnection conn;
        DataTable dt = new DataTable();
        // Thêm hóa đơn
        public HoaDonDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string selectStr = "select * from HOADON";
            adap = new SqlDataAdapter(selectStr, conn);
            if (dt.Rows.Count == 0)
                adap.Fill(dt);
            dbHelper = new DatabaseHelper(GeneralDAL.connectStrg);
        }
        public bool AddInvoice(HoaDonDTO hoaDonDTO)
        {
            string query = "INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV, TongTien) VALUES (@MaHD, @NgayLap, @MaBN, @MaNV, @TongTien)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", hoaDonDTO.MaHD),
            new SqlParameter("@NgayLap", hoaDonDTO.NgayLap),
            new SqlParameter("@MaBN", hoaDonDTO.MaBN),
            new SqlParameter("@MaNV", hoaDonDTO.MaNV),
            new SqlParameter("@TongTien", hoaDonDTO.TongTien)
        };
            
            
                dbHelper.ExecuteNonQuery(query, parameters);
            
            return true;
        }

        // Lấy danh sách hóa đơn
        public DataTable GetInvoices()
        {
            string query = "SELECT * FROM HOADON";
            return dbHelper.ExecuteQuery(query);
        }

        // Cập nhật hóa đơn
        public void UpdateInvoice(HoaDonDTO hoaDonDTO)
        {
            string query = "UPDATE HOADON SET NgayLap = @NgayLap, MaBN = @MaBN, MaNV = @MaNV, TongTien = @TongTien WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", hoaDonDTO.MaHD),
            new SqlParameter("@NgayLap", hoaDonDTO.NgayLap),
            new SqlParameter("@MaBN", hoaDonDTO.MaBN),
            new SqlParameter("@MaNV", hoaDonDTO.MaNV),
            new SqlParameter("@TongTien", hoaDonDTO.TongTien)
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa hóa đơn
        public void DeleteInvoice(string maHD)
        {
            string query = "DELETE FROM HOADON WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD)
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Thêm chi tiết hóa đơn
        public void AddInvoiceDetail(ChiTietHoaDonDTO chitTietHoaDonDTO)
        {
            string query = "INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG, DONGIA) VALUES (@MaHD, @MaVC, @SoLuong, @DonGia)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", chitTietHoaDonDTO.MaHD),
            new SqlParameter("@MaVC", chitTietHoaDonDTO.MaVC),
            new SqlParameter("@SoLuong", chitTietHoaDonDTO.SoLuong),
            new SqlParameter("@DonGia", chitTietHoaDonDTO.DonGia)
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Lấy danh sách chi tiết hóa đơn theo mã hóa đơn
        public DataTable GetInvoiceDetails(string maHD)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD)
        };
            return dbHelper.ExecuteQuery(query, parameters);
        }

        // Cập nhật chi tiết hóa đơn
        public void UpdateInvoiceDetail(ChiTietHoaDonDTO chitTietHoaDonDTO)
        {
            string query = "UPDATE CHITIETHOADON SET SOLUONG = @SoLuong, DONGIA = @DonGia WHERE MaHD = @MaHD AND MaVC = @MaVC";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", chitTietHoaDonDTO.MaHD),
            new SqlParameter("@MaVC", chitTietHoaDonDTO.MaVC),
            new SqlParameter("@SoLuong", chitTietHoaDonDTO.SoLuong),
            new SqlParameter("@DonGia", chitTietHoaDonDTO.DonGia)
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        // Xóa chi tiết hóa đơn
        public void DeleteInvoiceDetail(string maHD)
        {
            string query = "DELETE FROM CHITIETHOADON WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD)
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        public DataRowCollection GetFullDataRows()
        {
            return GetInvoices().Rows;
        }

        public void UpdateHoaDon(HoaDonDTO hdDTONew)
        {
            throw new NotImplementedException();
        }

        public void DeleteNhanVien(string maBN)
        {
            throw new NotImplementedException();
        }

        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            throw new NotImplementedException();
        }

        public void ClearDataSet()
        {
            throw new NotImplementedException();
        }

        public string NewIDHD()
        {
            int lastMaHD = 0;
            string query = "SELECT TOP 1 MaHD FROM HOADON ORDER BY MaHD DESC";
            string maHD = "HD000";
            SqlConnection conn = new SqlConnection(GeneralDAL.connectStrg);
            try
            {
                conn.Open();
                query = "SELECT TOP 1 MaHD FROM HOADON ORDER BY MaHD DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    maHD = result.ToString();
                    Console.WriteLine("Mã hóa đơn cuối cùng: " + maHD);
                    lastMaHD = int.Parse(maHD.Substring(2));
                    lastMaHD++;
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
            return "HD" + lastMaHD.ToString("D3");
        }

        public int GetContainVC(string maHD, string maVC)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MaHD = @MaHD and MaVC = @MaVC";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD),
            new SqlParameter("#MaVC", maVC)
        };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["Soluong"].ToString());
            }
            return 0;
        }

        public void AddAmount(int v)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrNewCTHD(ChiTietHoaDonDTO chitTietHoaDonDTO)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MaHD = @MaHD and MaVC = @MaVC";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", chitTietHoaDonDTO.MaHD),
            new SqlParameter("#MaVC", chitTietHoaDonDTO.MaVC)
        };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                int newAmount =  int.Parse(dt.Rows[0]["Soluong"].ToString()) + chitTietHoaDonDTO.SoLuong;
                ChiTietHoaDonDTO newCthd = new ChiTietHoaDonDTO(chitTietHoaDonDTO.MaHD, chitTietHoaDonDTO.MaVC, newAmount, chitTietHoaDonDTO.DonGia);
                UpdateInvoiceDetail(newCthd);
            }
            else
            {
                AddInvoiceDetail(chitTietHoaDonDTO);
            }
        }

        public string LoadPriceVC(string idVC)
        {
            string query = "SELECT * FROM VACCINE WHERE MaVC = @MaVC";
            SqlParameter[] parameters = {
            new SqlParameter("@MaVC", idVC)
        };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            return dt.Rows[0]["Gia"].ToString();
            
        }

        public void UpdateHoaDonByNV(string maNV)
        {
            string query = "UPDATE HOADON SET MaNV = 'NV000' WHERE MaNV = @MaNV";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", maNV),
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        public DataRowCollection GetHDByMaBN(string maBN)
        {
            string query = "SELECT * FROM HOADON WHERE MaBN = @MaBN";
            SqlParameter[] parameters = {
            new SqlParameter("@MaBN", maBN)
        };
            return dbHelper.ExecuteQuery(query, parameters).Rows;
        }

        public DataRowCollection GetHDByMaNV(string maNV)
        {
            string query = "SELECT * FROM HOADON WHERE MaNV = @MaNV";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", maNV)
        };
            return dbHelper.ExecuteQuery(query, parameters).Rows;
        }

        public void DeleteHoaDon(string maHD)
        {
            string query = "DELETE FROM HOADON WHERE MaHD = @MaHD";
            SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD),
        };
            dbHelper.ExecuteNonQuery(query, parameters);
        }
        public bool DeleteHoaDonByMaBN(string maBN)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM HOADON WHERE MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa HOADON: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
                return false;
            }
        }


    }
}
