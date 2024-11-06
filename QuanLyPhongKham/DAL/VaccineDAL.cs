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
        private static DataTable dt = new DataTable();
        public VaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from Vaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "Vaccine");
            if(dt.Rows.Count == 0)
                adap.Fill(dt);
        }

        public DataTable LayTTVC()
        {
            return dt;
        }
        public void Insert(VaccineDTO vcDTO)
        {
            DataRow newrow = dt.NewRow();
            newrow["MaVC"] = vcDTO.Mavc;
            newrow["MaLoai"] = vcDTO.Maloai;
            newrow["TenVC"] = vcDTO.Tenvc;
            newrow["NgaySX"] = vcDTO.Ngaysx;
            newrow["HanSuDung"] = vcDTO.Hansudung;
            newrow["SoLuongTon"] = 0;
            newrow["Gia"] = vcDTO.Gia;
            newrow["XuatXu"] = vcDTO.Xuatxu;

            dt.Rows.Add(newrow);
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
        public void Luu()
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adap);
            adap.Update(dt);
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
