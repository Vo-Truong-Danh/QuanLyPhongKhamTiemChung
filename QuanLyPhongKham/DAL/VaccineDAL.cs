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
        SqlDataAdapter adap;

        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        SqlConnection conn;

        public VaccineDAL()
        {
            conn = new SqlConnection(connectStr);
        }

        public DataSet LayTTVC()
        {
            conn.Open();
            string truyvansql = "select * from Vaccine";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "Vaccine");
            conn.Close();
            return ds;
        }
    }
}
