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


        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        SqlConnection conn;

        public NhaCungCapDAL()
        {
            conn = new SqlConnection(connectStr);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        }

        public DataSet GetData()
        {
            conn.Open();
            string truyvansql = "select * from NhaCungCap";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "NhaCungCap");
            conn.Close();
            return ds;
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
                DataRow[] rowsToDelete = ds.Tables["NhaCungCap"].Select($"MaNCC = '{tmp}'");
                foreach (DataRow row in rowsToDelete)
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
    }
}
