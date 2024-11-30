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
        public LoaiVaccineDTO Search(string searchTerm)
        {
            DataRow[] dr = dt.Select("MaLoai = '"+searchTerm+"'");
            if (dr.Length > 0)
            {
                LoaiVaccineDTO loaiVaccineDTO = new LoaiVaccineDTO()
                {
                    Maloai = searchTerm,
                    Tenloai = dr[0]["TenLoai"].ToString(),
                    Somui = int.Parse(dr[0]["SoMui"].ToString()),
                };
                return loaiVaccineDTO;
            }
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
        //public void Luu()
        //{
        //    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
        //    adap.Update(dt);
        //}
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        public bool Delete(string maLoai)
        {
            try
            {
                DataRow[] rowDeXoa = dt.Select("MaLoai = '" + maLoai + "'");
                if (rowDeXoa.Length > 0)
                {
                    rowDeXoa[0].Delete();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(LoaiVaccineDTO loaiVaccineDTO)
        {
            try
            {
                DataRow[] dr = dt.Select("MaLoai = '"+loaiVaccineDTO.Maloai+"'");
                if (dr.Length > 0)
                {
                    dr[0]["TenLoai"] = loaiVaccineDTO.Tenloai;
                    dr[0]["SoMui"] = loaiVaccineDTO.Somui;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

    }
}

