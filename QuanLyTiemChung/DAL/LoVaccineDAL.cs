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
        public DataTable GetData()
        {
            return SqlCMDLayBang("select * from LOVACCINE");
        }
        public string TaoMaLo()
        {
            int sl = GetData().Rows.Count + 1;
            return "ML"+sl.ToString("D3") + "";
        }

    }
}
