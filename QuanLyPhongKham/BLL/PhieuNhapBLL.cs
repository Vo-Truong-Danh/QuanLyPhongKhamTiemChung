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

        public DataTable GetData()
        {
            return pn.GetData();
        }
        public bool Insert(PhieuNhapDTO tmp)
        {
            return pn.Insert(tmp);
        }
        public bool Delete(string tmp)
        {
            return pn.Delete(tmp);
        }
        public bool Update(PhieuNhapDTO tmp)
        {
            return pn.Update(tmp);
        }

    }
}
