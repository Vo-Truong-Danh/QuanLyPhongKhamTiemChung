using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class TaiKhoanDAL
    {
        //DataSet ds;
        SqlDataAdapter adap;
        //DataColumn[] key = new DataColumn[1];
        SqlConnection conn;
        DataTable dt = new DataTable();
        public TaiKhoanDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            //ds = new DataSet();
            string selectStr = "select * from NHANVIEN";
            adap = new SqlDataAdapter(selectStr, conn);
            //adap.Fill(ds, "TAIKHOAN");
            adap.Fill(dt);
            // Them khoa chinh
            //key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            //ds.Tables["TAIKHOAN"].PrimaryKey = key;
            
        }
        //public bool IsExistsUserName(string userName)
        //{
        //    //foreach (DataRow row in ds.Tables["TAIKHOAN"].Rows)
        //    //{
        //    //    if (userName.Equals(row["UserName"].ToString()))
        //    //        return true;
        //    //}
        //    //return false;
        //}
        //public bool Insert(TaiKhoanDTO nv)
        //{
        //    //try
        //    //{
        //    //    DataRow newRow = ds.Tables["TAIKHOAN"].NewRow();
        //    //    newRow["DisplayName"] = nv.DisplayName;
        //    //    newRow["UserName"] = nv.UserName;
        //    //    newRow["Pass"] = nv.Pass;
        //    //    newRow["ChucVu"] = nv.ChucVu;
        //    //    // Them dong du lieu vao DataSet
        //    //    ds.Tables["TAIKHOAN"].Rows.Add(newRow);
        //    //    // Cap nhat CSDL
        //    //    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
        //    //    adap.Update(ds, "TAIKHOAN");
        //    //    return true;
        //    //}
        //    //catch { return false; }
        //}
        public TaiKhoanDTO CheckUserNameAndPassword(string userName, string password)
        {
            DataRow[] dr = dt.Select("MaNV = '" + userName + "' AND Pass = '" + password + "' ");
            if (dr.Length > 0)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO()
                {
                    UserName = userName.ToString(),
                    DisplayName = dr[0]["HoTen"].ToString(),
                    ChucVu = int.Parse(dr[0]["Quyen"].ToString()),
                };
                return tk;
            }
            else
            {
                return null;
            }
        }


    }
}
