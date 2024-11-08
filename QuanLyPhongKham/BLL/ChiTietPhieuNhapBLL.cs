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

        public DataTable GetData()
        {
            return ct.GetData();
        }

        public DataTable SearchMaPN(string ma)
        {
            return ct.SearchMaPN(ma);
        }

        public bool Insert(ChiTietPhieuNhapDTO tmp)
        {
            return ct.Insert(tmp);
        }
        public bool Delete(string mapn,string mavc)
        {
            return ct.Delete(mapn,mavc);
        }
        public bool Update(ChiTietPhieuNhapDTO tmp)
        {
            return ct.Update(tmp);
        }

        public bool Luu()
        {
            return ct.Luu();
        }
    }
}
