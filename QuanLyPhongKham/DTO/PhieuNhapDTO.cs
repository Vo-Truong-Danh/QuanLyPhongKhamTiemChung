using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        string mapn, ngaynhap, mancc;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Mancc { get => mancc; set => mancc = value; }

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
