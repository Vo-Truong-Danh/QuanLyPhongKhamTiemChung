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
    public class NhanVienDAL
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        DataTable dt;
        public NhanVienDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            conn.Open();
            string truyvansql = "select * from NhanVien";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(dt = new DataTable());
            conn.Close();
        }
        public NhanVienDTO CheckUserNameAndPassword(string userName, string password)
        {
            DataRow[] dr = dt.Select("MaNV = '" + userName + "' AND Pass = '" + password + "' ");
            if (dr.Length > 0)
            {
                NhanVienDTO tk = new NhanVienDTO()
                {
                    MaNV = userName.ToString(),
                    HoTen= dr[0]["HoTen"].ToString(),
                    Quyen = int.Parse(dr[0]["Quyen"].ToString()),
                };
                return tk;
            }
            else
            {
                return null;
            }
        }
        public DataTable Load()
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adap);
                adap.Update(dt);

                dt.AcceptChanges();
                dt.Clear();
                adap.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public int SoLuong()
        {
            return dt.Rows.Count;
        }
    }
}
