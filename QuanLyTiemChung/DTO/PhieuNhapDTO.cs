using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        string mapn, ngaynhap, mancc,tongtien;

        public string Mapn { get => mapn; set => mapn = value; }
        private string maNV;
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string MaNV { get => MaNV1; set => MaNV1 = value; }
        public string MaNV1 { get => maNV; set => maNV = value; }

        public PhieuNhapDTO() { }

        public PhieuNhapDTO(string mapn , string ngaynhap, string mancc )
        {
            Mapn = mapn;
            Ngaynhap = ngaynhap;
            Mancc = mancc;
        }
        public PhieuNhapDTO(string macc, string ngaynhap)
        {
            Ngaynhap = ngaynhap;
            Mancc = macc;
        }
    }
}
