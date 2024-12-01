using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichTiemDTO
    {

        public string MaLT { get; set; }
        public string MaHD { get; set; }
        public string MaBN { get; set; }
        public string MaVC { get; set; }
        public DateTime NgayHenTiem { get; set; }
        public string TrangThai { get; set; }

        public LichTiemDTO(string maLT, string maHD, string maBN, string maVC, DateTime ngayHenTiem, string trangThai)
        {
            MaLT = maLT;
            MaHD = maHD;
            MaBN = maBN;
            MaVC = maVC;
            NgayHenTiem = ngayHenTiem;
            TrangThai = trangThai;
        }
    }
}
