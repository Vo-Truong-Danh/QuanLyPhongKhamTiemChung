using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GhiNhanTiemChungBLL
    {
        private DatabaseHelper dataHelper;
        GhiNhanTiemChungDAL dal = new GhiNhanTiemChungDAL();

        public bool XacNhanTiem(LichTiemDTO loaiVaccineDTO)
        {
            return dal.XacNhanTiem(loaiVaccineDTO);
        }
        public void DeleteByMaHD(string maHD)
        {
            try
            {
                string query = "DELETE FROM GHINHANTIEMCHUNG WHERE MaHD = @MaHD";
                SqlParameter[] parameters = {
            new SqlParameter("@MaHD", maHD)
            };
                dataHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa trong GHINHANTIEMCHUNG: " + ex.Message);
                throw;
            }
        }
    }
}
