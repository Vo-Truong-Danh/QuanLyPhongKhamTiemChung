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

        VaccineDAL vcbll = new VaccineDAL();
        public DataSet LayTTVC()
        {
            return vcbll.LayTTVC();
        }
        public bool Insert(VaccineDTO vaccineDTO)
        {
            return vcbll.Insert(vaccineDTO);
        }
        public bool Delete(string mavc)
        {
            return vcbll.Delete(mavc);
        }
        public bool Update(VaccineDTO vaccineDTO)
        {
            return vcbll.Update(vaccineDTO);
        }
    }
}
