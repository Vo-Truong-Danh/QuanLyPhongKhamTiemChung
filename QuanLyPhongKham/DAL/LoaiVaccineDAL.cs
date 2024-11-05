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
    public class LoaiVaccineDAL
    {
        SqlDataAdapter adap;
        SqlConnection conn;
        DataTable dt = new DataTable();

        public LoaiVaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string truyvansql = "select * from LoaiVaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(dt);
        }

        public DataTable GetData()
        {
            return dt;
        }
        public DataTable Search(string searchTerm)
        {
            //GetData();
            //DataTable resultTable = ds.Tables["LoaiVaccine"].Clone();

            //foreach (DataRow row in ds.Tables["LoaiVaccine"].Rows)
            //{
            //    if (row["TenLoai"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            //        row["MaLoai"].ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
            //    {
            //        resultTable.ImportRow(row);
            //    }
            //}

            //return resultTable;
            return null;
        }
        public bool Insert(string lvcDTO)
        {
            //try
            //{
            //    if (ds.Tables["LoaiVaccine"] == null)
            //        GetData();

            //    DataRow newRow = ds.Tables["LoaiVaccine"].NewRow();
            //    newRow["TenLoai"] = lvcDTO;
            //    ds.Tables["LoaiVaccine"].Rows.Add(newRow);

            //    // Cập nhật csdl
            //    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
            //    adap.Update(ds, "LoaiVaccine");
            //    GetData();

            //    return true;
            //}
            //catch
            //{ return false; }
            return false;
        }
        public bool Delete(string maLoai)
        {
            //try
            //{
            //    if (ds.Tables["LoaiVaccine"] == null)
            //    {
            //        GetData();
            //    }
            //    DataRow[] tb = ds.Tables["LoaiVaccine"].Select($"MaLoai = '{maLoai}'");
            //    foreach (DataRow row in tb)
            //    {
            //        row.Delete();
            //    }

            //    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            //    adap.Update(ds, "LoaiVaccine");

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Lỗi khi xóa bản ghi: " + ex.Message);
            //    return false;
            //}
            return false ;
        }
        public bool Update(LoaiVaccineDTO loaiVaccineDTO)
        {
            //try
            //{
            //    if (ds.Tables["LoaiVaccine"] == null)
            //    {
            //        GetData();
            //    }

            //    DataRow[] tb = ds.Tables["LoaiVaccine"].Select("MaLoai = '" + loaiVaccineDTO.Maloai + "'");

            //    if (tb.Length > 0)
            //    {
            //        DataRow row = tb[0];
            //        row["TenLoai"] = loaiVaccineDTO.Tenloai;

            //        // Cập nhật csdl
            //        SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
            //        adap.Update(ds, "LoaiVaccine");

            //        return true;
            //    }
            //    else return false;
            //}
            //catch
            //{
            //    return false;
            //}
            return false;
        }

    }
}

