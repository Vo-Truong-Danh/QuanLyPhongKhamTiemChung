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
        SqlConnection conn;
        DataTable dt;
        public VaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from Vaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "Vaccine");
            adap.Fill(dt = new DataTable());
            conn.Close();
        }

        public DataTable LayTTVC()
        {
            return dt;
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
        public DataTable Search(string ndtimkiem)
        {
            DataRow[] dr = dt.Select("MaLoai = '"+ndtimkiem+"' OR XuatXu =  '"+ndtimkiem+"' ");
            DataTable tmp = dt.Clone();
            foreach (DataRow item in dr)
            {
                tmp.ImportRow(item);
            }
            return tmp;
        }

        public List<string> LoadDSXuatXu()
        {
            DataRow[] dr = dt.Select("");
            List<string> xuatXuList = dr
                .Select(row => row["XuatXu"].ToString())
                .Distinct()
                .ToList();

            return xuatXuList;
        }


    }
}
