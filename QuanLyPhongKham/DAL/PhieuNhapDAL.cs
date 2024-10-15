using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter();


        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        //string connectStr = "Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Integrated Security=True;";
        SqlConnection conn;

        public PhieuNhapDAL()
        {
            conn = new SqlConnection(connectStr);
            adap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        }

        public DataSet GetData()
        {
            conn.Open();
            string truyvansql = "select * from PhieuNhap";
            adap = new SqlDataAdapter(truyvansql, conn);
            adap.Fill(ds, "PhieuNhap");
            conn.Close();
            return ds;
        }
    }
}
