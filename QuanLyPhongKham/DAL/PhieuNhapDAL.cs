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
    public class PhieuNhapDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;

        public PhieuNhapDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey; conn.Open();
            string truyvansql = "select * from PhieuNhap";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "PhieuNhap");
            adap.Fill(dt = new DataTable());
            conn.Close();

        }

        public DataTable GetData()
        {
            return dt;
        }
        public bool Insert(PhieuNhapDTO tmp)
        {
            try
            {
                DataRow newRow = dt.NewRow();
                newRow["MaNV"] = tmp.MaNV1;
                newRow["MaPN"] = tmp.Mapn;
                newRow["NgayNhap"] = tmp.Ngaynhap;
                newRow["MaNCC"] = tmp.Mancc;
                newRow["TongTien"] = tmp.Tongtien;

                dt.Rows.Add(newRow);
                return true;
            }
            catch
            { return false; }
        }
        public bool Delete(string tmp)
        {
            try
            {
                if (ds.Tables["PhieuNhap"] == null)
                {
                    GetData();
                }
                DataRow[] rowDeXoa = ds.Tables["PhieuNhap"].Select($"MaPN = '{tmp}'");
                foreach (DataRow row in rowDeXoa)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "PhieuNhap");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(PhieuNhapDTO tmp)
        {
            try
            {
                if (ds.Tables["PhieuNhap"] == null)
                {
                    GetData();
                }

                DataRow[] rowDeUPD = ds.Tables["PhieuNhap"].Select("MaPN = '" + tmp.Mapn + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["NgayNhap"] = tmp.Ngaynhap;
                    row["MaNCC"] = tmp.Mancc;

                    // Cập nhật csdl
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                    adap.Update(ds, "PhieuNhap");

                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Luu()
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(dt);
                return true;
            }
            catch { return false; }
        }
    }
}
