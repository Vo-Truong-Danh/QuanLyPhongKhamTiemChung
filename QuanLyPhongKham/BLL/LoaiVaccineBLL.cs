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
        public DataSet GetData()
        {
            return loaiVaccineDAL.GetData();
        }
        public DataTable Search(string ndtimkiem)
        {
            return loaiVaccineDAL.Search(ndtimkiem);
        }

        public bool Insert(string tenLoai)
        {
            return loaiVaccineDAL.Insert(tenLoai);
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
