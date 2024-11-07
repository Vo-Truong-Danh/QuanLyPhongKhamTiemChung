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
        private static DataTable dt = new DataTable();

        public LoaiVaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            string truyvansql = "select * from LoaiVaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            if (dt.Rows.Count == 0)
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
        public bool Insert(LoaiVaccineDTO lvcDTO)
        {
            try
            {
                DataRow newrow = dt.NewRow();
                newrow["MaLoai"] = lvcDTO.Maloai;
                newrow["TenLoai"] = lvcDTO.Tenloai;
                newrow["SoMui"] = lvcDTO.Somui;

                dt.Rows.Add(newrow);

                return true;
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

