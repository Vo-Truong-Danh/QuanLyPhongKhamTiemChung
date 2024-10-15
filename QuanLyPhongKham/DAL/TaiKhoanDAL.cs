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
        DataColumn[] key = new DataColumn[1];
        SqlConnection conn;
        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        public TaiKhoanDAL()
        {
            conn = new SqlConnection(connectStr);
            ds = new DataSet();
            string selectStr = "select * from TAIKHOAN";
            adap = new SqlDataAdapter(selectStr, conn);
            adap.Fill(ds, "TAIKHOAN");
            // Them khoa chinh
            key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            ds.Tables["TAIKHOAN"].PrimaryKey = key;
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
            catch { return false; }
        }
        public bool CheckUserNameAndPassword(string userName, string password)
        {
            DataRow userRow = ds.Tables["TAIKHOAN"].Rows.Find(userName);

            if (userRow == null)
            {
                return false;
            }
            string storedPassword = userRow["Pass"].ToString();
            return storedPassword == password;
        }

    }
}
