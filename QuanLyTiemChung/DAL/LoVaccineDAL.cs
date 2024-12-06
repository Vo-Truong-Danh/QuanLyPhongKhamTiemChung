using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoVaccineDAL
    {
        SqlConnection conn;
        public LoVaccineDAL()
        {
            conn = new SqlConnection(GeneralDAL.connectStrg);
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
        public DataTable GetData()
        {
            return SqlCMDLayBang("select * from LOVACCINE");
        }
        public string TaoMaLo()
        {
            DataTable tmp = SqlCMDLayBang("SELECT DISTINCT MaLo FROM LOVACCINE");
            int sl1 = tmp.Rows.Count + 1;
            return "ML" + sl1.ToString("D3");
        }

        public bool Insert(DataTable tmp)
        {
            try
            {
                foreach (DataRow row in tmp.Rows)
                {
                    string malo = row["MaLo"].ToString();
                    string mavc = row["MaVC"].ToString();
                    string nsx = DateTime.Parse(row["NgaySX"].ToString()).ToString("yyyy-MM-dd");
                    string hsd = DateTime.Parse(row["HanSuDung"].ToString()).ToString("yyyy-MM-dd");
                    string soluong = row["SoLuong"].ToString();

                    string truyxuat = "EXEC pro_them_lovacine '" + malo + "', '" + mavc + "', '" + nsx + "', '" + hsd + "', '" + soluong + "'";

                    bool result = SqlCMD(truyxuat);

                    if (!result)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
