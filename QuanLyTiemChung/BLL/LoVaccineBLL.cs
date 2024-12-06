using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LoVaccineBLL
    {
        public LoVaccineDAL tmp = new LoVaccineDAL();
        public DataTable GetData()
        {
            return tmp.GetData();
        }
        public string TaoMaLo()
        {
            return tmp.TaoMaLo();
        }
    }
}
