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
        public DataTable GetData()
        {
            return bnDAL.GetData();
        }
        public bool Insert(BenhNhanDTO bnDTO)
        {
            try
            {
                bnDAL.Insert(bnDTO);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public DataTable GetFullData()
        {
            return bnDAL.GetFullData();
        }
        public bool Edit(string MaBNCanSua, BenhNhanDTO bnDTONew)
        {
            return bnDAL.Edit(MaBNCanSua, bnDTONew);
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
        public int SoLuong()
        {
            return bnDAL.SoLuong();
        }
        public List<string> DSMaBenhNhan()
        {
            return bnDAL.DSMaBenhNhan();
        }
        public bool KTMaBNCoTonTai(string mabn)
        {
            return bnDAL.KTMaBNCoTonTai(mabn);
        }
       

    }
}

