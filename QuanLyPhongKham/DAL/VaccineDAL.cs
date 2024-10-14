using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class VaccineDAL
    {
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        SqlDataAdapter adap;
        SqlConnection conn;
        string connectStr = "Data Source=PLS\\MSSQLSERVERVTD;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;User ID=sa;password=123";
        private int lastMaBN = 0;
        public VaccineDAL()
        {

        }

    }
}
