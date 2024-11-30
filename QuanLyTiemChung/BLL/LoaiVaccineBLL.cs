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
    public class LoaiVaccineBLL
    {
        LoaiVaccineDAL loaiVaccineDAL = new LoaiVaccineDAL();
        public DataTable GetData()
        {
            return loaiVaccineDAL.GetData();
        }
        public LoaiVaccineDTO Search(string ndtimkiem)
        {
            return loaiVaccineDAL.Search(ndtimkiem);
        }

        public bool Insert(LoaiVaccineDTO tmp)
        {
            return loaiVaccineDAL.Insert(tmp);
        }
        public void Luu()
        {
            loaiVaccineDAL.Luu();
        }
        
        public bool Delete(string ndxoa)
        {
            return loaiVaccineDAL.Delete(ndxoa);
        }
        public bool Update(LoaiVaccineDTO loaiVaccineDTO)
        {
            return loaiVaccineDAL.Update(loaiVaccineDTO);
        }
    }
}
