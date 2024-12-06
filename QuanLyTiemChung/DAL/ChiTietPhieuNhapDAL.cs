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
    public class ChiTietPhieuNhapDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap;

        SqlConnection conn;
        DataTable dt;

        public ChiTietPhieuNhapDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg); conn.Open();
            string truyvansql = "select * from CHITIETPHIEUNHAP";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(dt = new DataTable());
            conn.Close();
        }

        public DataTable GetData()
        {
            return SqlCMDLayBang("select * from CHITIETPHIEUNHAP");
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

        public bool Insert(ChiTietPhieuNhapDTO tmp)
        {
            return SqlCMD("EXEC pro_them_chitietphieunhap '" + tmp.Mapn + "' , '" + tmp.Mavc + "', '" + tmp.Malo + "', '" + tmp.Soluong + "', '" + tmp.Dongia + "' ");
        }
        public DataTable SearchMaPN(string ma)
        {
            DataRow[] dr = dt.Select("MaPN = '"+ma+"'");
            //DataTable tmp = dt.Clone();
            //if(dr.Length>0)
            //{
            //    foreach (DataRow dr2 in dr)
            //    {
            //        tmp.Rows.Add(dr2);
            //    }
            //}
            return dr.CopyToDataTable();
        }

        public bool Luu( DataTable dttb)
        {
            try
            {
                dt = dttb;
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(dt);
                return true;
            }
            catch { return false; }
        }
        public bool Delete(string mapn , string mavc)
        {
            try
            {
                if (ds.Tables["ChiTietPhieuNhap"] == null)
                {
                    GetData();
                }
                DataRow[] rowDeXoa = ds.Tables["ChiTietPhieuNhap"].Select($"MaPN = '{mapn}' AND MaVC = '{mavc}'");

                foreach (DataRow row in rowDeXoa)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "ChiTietPhieuNhap");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(ChiTietPhieuNhapDTO tmp)
        {
            try
            {
                if (ds.Tables["ChiTietPhieuNhap"] == null)
                {
                    GetData();
                }

                DataRow[] rowDeUPD = ds.Tables["ChiTietPhieuNhap"].Select($"MaPN = '{tmp.Mapn}' AND MaVC = '{tmp.Mavc}'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["SoLuong"] = tmp.Soluong;
                    row["DonGia"] = tmp.Dongia;

                    // Cập nhật csdl
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                    adap.Update(ds, "ChiTietPhieuNhap");

                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
