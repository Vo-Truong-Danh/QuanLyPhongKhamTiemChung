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
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL ct = new ChiTietPhieuNhapDAL();

        public DataSet GetData()
        {
            return ct.GetData();
        }
    }
}
