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
        DataSet ds;
        SqlDataAdapter adap;
        SqlConnection conn = new SqlConnection();
        string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True";
        public TaiKhoanDAL()
        {
            conn.ConnectionString = connectStr;
            ds = new DataSet();
            string selectStr = "select * from TAIKHOAN";
            adap = new SqlDataAdapter(selectStr, conn);
            adap.Fill(ds, "TAIKHOAN");
        }
        public bool IsExistsUserName(string userName)
        {
            foreach (DataRow row in ds.Tables["TAIKHOAN"].Rows)
            {
                if (userName.Equals(row["UserName"].ToString()))
                    return true;
            }
            return false;
        }
        public bool Insert(TaiKhoanDTO nv)
        {
            try
            {
                DataRow newRow = ds.Tables["TAIKHOAN"].NewRow();
                newRow["DisplayName"] = nv.DisplayName;
                newRow["UserName"] = nv.UserName;
                newRow["Pass"] = nv.Pass;
                newRow["ChucVu"] = nv.ChucVu;
                // Them dong du lieu vao DataSet
                ds.Tables["TAIKHOAN"].Rows.Add(newRow);
                // Cap nhat CSDL
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adap);
                adap.Update(ds, "TAIKHOAN");
                return true;
            }
            catch {  return false; }
        }
    }
}
