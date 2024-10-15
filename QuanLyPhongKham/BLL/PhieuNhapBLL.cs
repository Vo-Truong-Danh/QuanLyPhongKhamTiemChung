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
    public class PhieuNhapBLL
    {
        PhieuNhapDAL pn = new PhieuNhapDAL();

        public DataSet GetData()
        {
            return pn.GetData();
        }
    }
}
