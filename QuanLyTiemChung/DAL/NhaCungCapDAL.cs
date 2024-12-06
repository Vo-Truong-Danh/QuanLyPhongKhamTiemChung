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
        SqlDataAdapter adap = new SqlDataAdapter();
        SqlConnection conn;
        private static DataTable dt = new DataTable();

        public NhaCungCapDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
            //adap.MissingSchemaAction = MissingSchemaAction.AddWithKey; conn.Open();
            string truyvansql = "select * from NhaCungCap";
            adap = new SqlDataAdapter(truyvansql, conn);
            if(dt.Rows.Count == 0 )
            {
                adap.Fill(dt);
            }
        }
        public DataTable GetData()
        {
            return SqlCMDLayBang("select * from NhaCungCap");
        }

        private DataTable SqlCMDLayBang(string truyxuat)
        {
            DataTable tmp = new DataTable();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        tmp.Load(reader);
                    }
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch
            {
                return tmp = null;
            }
            return tmp;
        }
        private bool SqlCMD(string truyxuat)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand(truyxuat, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        public bool Insert(NhaCungCapDTO tmp)
        {
            return SqlCMD("EXEC pro_them_nhacungcap '"+tmp.Mancc+"',N'"+tmp.Tenncc+"',N'"+tmp.Diachi+"','"+tmp.Sodienthoai+"'");
        }
        public bool Delete(string tmp)
        {
            return SqlCMD("EXEC pro_xoa_nhacungcap '" + tmp+ "' ");
        }
        public bool Update(NhaCungCapDTO tmp)
        {
            return SqlCMD("EXEC pro_caonhat_nhacungcap '" + tmp.Mancc + "',N'" + tmp.Tenncc + "',N'" + tmp.Diachi + "','" + tmp.Sodienthoai + "'");

        }
        public NhaCungCapDTO Search(string ma)
        {
            DataRow[] dr = dt.Select("MaNCC = '" + ma + "'");
            if (dr.Length > 0)
            {
                NhaCungCapDTO tmp = new NhaCungCapDTO()
                {
                    Mancc = ma,
                    Tenncc = dr[0]["TenNCC"].ToString(),
                    Diachi = dr[0]["DiaChi"].ToString(),
                    Sodienthoai = dr[0]["SoDienThoai"].ToString(),
                   
                };
                return tmp;
            }
            return null;
        }
    }
}
