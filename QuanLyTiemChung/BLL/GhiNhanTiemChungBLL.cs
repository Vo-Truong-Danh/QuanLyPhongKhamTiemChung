using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GhiNhanTiemChungBLL
    {
        GhiNhanTiemChungDAL dal = new GhiNhanTiemChungDAL();

        public bool XacNhanTiem(LichTiemDTO loaiVaccineDTO)
        {
            return dal.XacNhanTiem(loaiVaccineDTO);
        }
    }
}
