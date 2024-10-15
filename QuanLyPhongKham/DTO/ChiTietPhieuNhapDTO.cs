using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        string mapn, mavc, soluong, dongia;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Mavc { get => mavc; set => mavc = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Dongia { get => dongia; set => dongia = value; }

        public ChiTietPhieuNhapDTO() { }

        public ChiTietPhieuNhapDTO( string mapn, string mavc, string soluong, string dongia)
        {
            Mapn = mapn;
            Mavc = mavc;
            Soluong = soluong;
            Dongia = dongia;
        }
    }
}
