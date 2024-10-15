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
                DataRow[] rowDeXoa = ds.Tables["Vaccine"].Select($"MaVC = '{maVC}'");
                foreach (DataRow row in rowDeXoa)
                {
                    row.Delete();
                }

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
                adap.Update(ds, "Vaccine");

                return true;
            }
            catch
            {
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

                DataRow[] rowDeUPD = ds.Tables["Vaccine"].Select("MaVC = '" + vcDTO.Mavc + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
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
        public DataSet Search(string ndtimkiem)
        {
            try
            {
                DataSet ds = new DataSet();

                string searchQuery = "SELECT * FROM VACCINE WHERE TenVC LIKE @ndtimkiem OR MaVC LIKE @ndtimkiem OR Gia LIKE @ndtimkiem OR SoLuongTon LIKE @ndtimkiem";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ndtimkiem", "%" + ndtimkiem + "%");
                    SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                    searchAdapter.Fill(ds, "Vaccine");
                }
                conn.Close();

                return ds;
            }
            catch
            {
                return null;
            }
        }


    }
}
