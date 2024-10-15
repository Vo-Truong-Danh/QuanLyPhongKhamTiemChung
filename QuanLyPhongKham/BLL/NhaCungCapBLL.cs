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
        public DataSet GetData()
        {
            return NhaCcDAL.GetData();
        }

        public bool Insert(NhaCungCapDTO tmp)
        {
            return NhaCcDAL.Insert(tmp);
        }
    }
}
