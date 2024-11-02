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

        public ChiTietPhieuNhapDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
        }

        public DataSet GetData()
        {
            conn.Open();
            string truyvansql = "select * from CHITIETPHIEUNHAP";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "ChiTietPhieuNhap");
            conn.Close();
            return ds;
        }
        public bool Insert(ChiTietPhieuNhapDTO tmp)
        {
            try
            {
                if (ds.Tables["ChiTietPhieuNhap"] == null)
                {
                    GetData();
                }

                DataRow newRow = ds.Tables["ChiTietPhieuNhap"].NewRow();
                newRow["MaPN"] = tmp.Mapn;
                newRow["MaVC"] = tmp.Mavc;
                newRow["SoLuong"] = tmp.Soluong;
                newRow["DonGia"] = tmp.Dongia;


                ds.Tables["ChiTietPhieuNhap"].Rows.Add(newRow);

                // Cập nhật csdl
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "ChiTietPhieuNhap");
                GetData();

                return true;
            }
            catch
            { return false; }
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
