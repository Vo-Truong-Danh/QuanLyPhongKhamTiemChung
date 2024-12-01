using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaBN { get; set; }
        public string MaNV { get; set; }
        public float TongTien { get; set; }

        public HoaDonDTO(string maHD, DateTime ngayLap, string maBN, string maNV, float tongTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaBN = maBN;
            MaNV = maNV;
            TongTien = tongTien;
        }
    }
}
