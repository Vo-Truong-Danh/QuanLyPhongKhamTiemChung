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
    public class LichTiemBLL
    {
        LichTiemDAL lichTiemDAL = new LichTiemDAL();
        public bool Insert(LichTiemDTO lichTiemDTO)
        {
            return lichTiemDAL.AddLichTiem(lichTiemDTO);
        }
        public DataRowCollection GetFullDataRows()
        {
            return lichTiemDAL.GetFullDataRows();
        }
        public void Edit(LichTiemDTO lichTiemDTO)
        {
            lichTiemDAL.UpdateLichTiem(lichTiemDTO);
        }
       
        public string GetLastLTID()
        {
            return lichTiemDAL.NewIDLT();
        }


        public string GetNgayTiem(string maHD)
        {
           return lichTiemDAL.GetNgayTiem(maHD);
        }

        public void UpdateLichTiem(LichTiemDTO lichTiemDTO)
        {
            lichTiemDAL.UpdateLichTiem(lichTiemDTO);
        }

        public void DeleteLByMaBN(string maBN)
        {
            lichTiemDAL.DeleteLTByMaBN(maBN);
        }

        public void DeleteLByMaHD(string maHD)
        {
            lichTiemDAL.DeleteLTByMaHD(maHD);
        }
    }
}
