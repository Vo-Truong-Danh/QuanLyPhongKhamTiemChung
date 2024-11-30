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
    public class NhaCungCapBLL
    {
        NhaCungCapDAL NhaCcDAL = new NhaCungCapDAL();
        public DataTable GetData()
        {
            return NhaCcDAL.GetData();
        }

        public bool Insert(NhaCungCapDTO tmp)
        {
            return NhaCcDAL.Insert(tmp);
        }
        public bool Delete(string tmp)
        {
            return NhaCcDAL.Delete(tmp);
        }
        public bool Update(NhaCungCapDTO tmp)
        {
            return NhaCcDAL.Update(tmp);
        }
        public NhaCungCapDTO Search(string ma)
        {
            return NhaCcDAL.Search(ma);
        }
        public void Luu()
        {
            NhaCcDAL.Luu();
        }
    }
}
