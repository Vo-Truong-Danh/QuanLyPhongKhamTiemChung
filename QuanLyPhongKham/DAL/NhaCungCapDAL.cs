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
    public class NhaCungCapDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;

        public NhaCungCapDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey; conn.Open();
            string truyvansql = "select * from NhaCungCap";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "NhaCungCap");
            adap.Fill(dt = new DataTable());

        }

        public DataTable GetData()
        {
            return dt;
        }
        public bool Insert(NhaCungCapDTO tmp)
        {
            try
            {
                if (ds.Tables["NhaCungCap"] == null)
                {
                    GetData();
                }

                DataRow newRow = ds.Tables["NhaCungCap"].NewRow();
                newRow["TenNCC"] = tmp.Tenncc;
                newRow["DiaChi"] = tmp.Diachi;
                newRow["SoDienThoai"] = tmp.Sodienthoai;


                ds.Tables["NhaCungCap"].Rows.Add(newRow);

                // Cập nhật csdl
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "NhaCungCap");
                GetData();

                return true;
            }
            catch
            { return false; }
        }
        public bool Delete(string tmp)
        {
            try
            {
                if (ds.Tables["NhaCungCap"] == null)
                {
                    GetData();
                }
                DataRow[] rowDeXoa = ds.Tables["NhaCungCap"].Select($"MaNCC = '{tmp}'");
                foreach (DataRow row in rowDeXoa)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "NhaCungCap");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(NhaCungCapDTO tmp)
        {
            try
            {
                if (ds.Tables["NhaCungCap"] == null)
                {
                    GetData();
                }

                DataRow[] rowDeUPD = ds.Tables["NhaCungCap"].Select("MaNCC = '" + tmp.Mancc + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["TenNCC"] = tmp.Tenncc;
                    row["DiaChi"] = tmp.Diachi;
                    row["SoDienThoai"] = tmp.Sodienthoai;

                    // Cập nhật csdl
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                    adap.Update(ds, "NhaCungCap");

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
