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
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        private int LayMaBNCuoiCung()
        {
            // nếu mã cuối cùng là "BN005" thì hàm này trả về 5
            string query = "SELECT TOP 1 MaBN FROM BENHNHAN ORDER BY MaBN DESC";
            string maBN = "BN000"; // Giá trị mặc định 
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

                // Hủy đối tượng kết nối (giải phóng bộ nhớ)
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

                // Thêm dòng dữ liệu vào DataSet
                dt.Rows.Add(newRow);

                // Cập nhật CSDL
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
                // Tim dong du lieu can sua dua theo MaBN
                DataRow dr = dt.Select("MaBN = '" + MaBNCanSua + "'").FirstOrDefault();
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
                Luu();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KTKhoaNgoai(string MaBN)
        {
            string queryCheckFK = "SELECT COUNT(*) FROM GHINHANTIEMCHUNG WHERE MaBN = @MaBN";
            using (SqlConnection conn = new SqlConnection(GeneralDAL.connectStrg))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryCheckFK, conn);
                cmd.Parameters.AddWithValue("@MaBN", MaBN);

                int relatedCount = (int)cmd.ExecuteScalar();
                return relatedCount > 0;
            }
        }
        public bool Delete(string MaBN)
        {
            if (KTKhoaNgoai(MaBN))
            {
                return false;
            }

            DataRow dr = dt.Select("MaBN = '" + MaBN + "'").FirstOrDefault();
            if (dr != null)
            {
                dr.Delete();
                Luu();
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataView GetDataViewFromTimKiem(string searchStr)
        {
            DataView dtView = new DataView(dt);
            dtView.RowFilter = "HoTen LIKE '%" + searchStr.Replace("'", "''") + "%'";
            return dtView;
        }//HoTen LIKE N'%' + 'searchStr' + N'%';
    }
}