using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        string mapn, mavc, soluong, dongia,malo;

        public string Mapn { get => Mapn1; set => Mapn1 = value; }
        public string Mavc { get => Mavc1; set => Mavc1 = value; }
        public string Soluong { get => Soluong1; set => Soluong1 = value; }
        public string Dongia { get => Dongia1; set => Dongia1 = value; }
        public string Mapn1 { get => mapn; set => mapn = value; }
        public string Mavc1 { get => mavc; set => mavc = value; }
        public string Soluong1 { get => soluong; set => soluong = value; }
        public string Dongia1 { get => dongia; set => dongia = value; }
        public string Malo { get => malo; set => malo = value; }

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
