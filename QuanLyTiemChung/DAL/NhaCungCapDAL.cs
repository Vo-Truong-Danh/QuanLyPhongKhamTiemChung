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
        public void Luu()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adap);
            // Cập nhật xuống database
            adap.Update(dt);

            // Sau khi lưu thành công, chấp nhận các thay đổi trong DataTable
            dt.AcceptChanges();
        }
        public DataTable GetData()
        {
            return dt;
        }
        public bool Insert(NhaCungCapDTO tmp)
        {
            try
            {
                DataRow newrow = dt.NewRow();
                newrow["MaNCC"] = tmp.Mancc;
                newrow["TenNCC"] = tmp.Tenncc;
                newrow["DiaChi"] = tmp.Diachi;
                newrow["SoDienThoai"] = tmp.Sodienthoai;

                dt.Rows.Add(newrow);

                return true;
            }
            catch
            { return false; }
        }
        public bool Delete(string tmp)
        {
            try
            {
                DataRow[] rowDeXoa = dt.Select("MaNCC = '" + tmp + "'");
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
        public bool Update(NhaCungCapDTO tmp)
        {
            try
            {

                DataRow[] rowDeUPD = dt.Select("MaNCC = '" + tmp.Mancc + "'");

                if (rowDeUPD.Length > 0)
                {
                    DataRow row = rowDeUPD[0];
                    row["TenNCC"] = tmp.Tenncc;
                    row["DiaChi"] = tmp.Diachi;
                    row["SoDienThoai"] = tmp.Sodienthoai;

                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
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
