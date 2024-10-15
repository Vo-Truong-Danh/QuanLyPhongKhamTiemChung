using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BenhNhanBLL
    {
        BenhNhanDAL bnDAL = new BenhNhanDAL();
        public bool Insert(BenhNhanDTO bnDTO)
        {
            bnDAL.Insert(bnDTO);
            return true;
        }
        public string TaoMaBNMoi()
        {
            return bnDAL.TaoMaBNMoi();
        }
        public DataRowCollection GetFullDataRows()
        {
            return bnDAL.GetFullDataRows();
        }
        public bool Edit(string MaBNCanSua, BenhNhanDTO bnDTONew)
        {
            if(bnDAL.Edit(MaBNCanSua, bnDTONew))
                return true;
            else return false;
        }
        public bool Delete(string maBN)
        {
            return bnDAL.Delete(maBN);
        }
        public DataView GetDataViewFromTimKiem(string searchStr)
        {
                DataView view = bnDAL.GetDataViewFromTimKiem(searchStr);
                return view;
        }
        public void ClearDataSet()
        {
            bnDAL.ClearDataSet();
        }
    }
}

