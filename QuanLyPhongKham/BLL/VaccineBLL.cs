using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class VaccineBLL
    {
        public DataSet LayTTVC()
        {
            VaccineDAL vaccineDAL = new VaccineDAL();
            return vaccineDAL.LayTTVC();
        }
    }
}
