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
    public class VaccineDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();


        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        SqlConnection conn;

        public VaccineDAL()
        {
            conn = new SqlConnection(connectStr);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        }

        public DataSet LayTTVC()
        {
            conn.Open();
            string truyvansql = "select * from Vaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "Vaccine");
            conn.Close();
            return ds;
        }
        public bool Insert(VaccineDTO vcDTO)
        {
            try
            {
                if (ds.Tables["Vaccine"] == null)
                {
                    LayTTVC();
                }

                DataRow newRow = ds.Tables["Vaccine"].NewRow();
                newRow["MaLoai"] = vcDTO.Maloai;
                newRow["TenVC"] = vcDTO.Tenvc;
                newRow["NgaySX"] = vcDTO.Ngaysx;
                newRow["HanSuDung"] = vcDTO.Hansudung;
                newRow["SoLuongTon"] = 0;
                newRow["Gia"] = vcDTO.Gia;


                ds.Tables["Vaccine"].Rows.Add(newRow);

                // Cập nhật csdl
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "Vaccine");
                LayTTVC(); 

                return true;
            }
            catch 
                { return false; }
        }

        public bool Delete(string maVC)
        {
            try
            {
                if (ds.Tables["Vaccine"] == null)
                {
                    LayTTVC(); 
                }
                DataRow[] rowsToDelete = ds.Tables["Vaccine"].Select($"MaVC = '{maVC}'");
                foreach (DataRow row in rowsToDelete)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "Vaccine");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa bản ghi: " + ex.Message);
                return false;
            }
        }

        public bool Update(VaccineDTO vcDTO)
        {
            try
            {
                if (ds.Tables["Vaccine"] == null)
                {
                    LayTTVC(); 
                }

                DataRow[] rowsToUpdate = ds.Tables["Vaccine"].Select("MaVC = '" + vcDTO.Mavc + "'");

                if (rowsToUpdate.Length > 0)
                {
                    DataRow row = rowsToUpdate[0];
                    row["MaLoai"] = vcDTO.Maloai;
                    row["TenVC"] = vcDTO.Tenvc;
                    row["NgaySX"] = vcDTO.Ngaysx;
                    row["HanSuDung"] = vcDTO.Hansudung;
                    row["Gia"] = vcDTO.Gia;

                    // Cập nhật csdl
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                    adap.Update(ds, "Vaccine");

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
