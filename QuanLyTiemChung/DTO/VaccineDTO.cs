using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineDTO
    {
        public static bool CheckTB = false;
        string mavc, maloai, tenvc,xuatxu;
        int soluongton, gia;
        public string Mavc { get => Mavc1; set => Mavc1 = value; }
        public string Maloai { get => Maloai1; set => Maloai1 = value; }
        public string Tenvc { get => Tenvc1; set => Tenvc1 = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Mavc1 { get => mavc; set => mavc = value; }
        public string Maloai1 { get => maloai; set => maloai = value; }
        public string Tenvc1 { get => tenvc; set => tenvc = value; }
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }

        public VaccineDTO() { }

        public VaccineDTO(string mavc, string Maloai, string tenvc, string ngaysx, string hansudung, int soluongton, int gia)
        {
            Mavc = mavc;
            Maloai = Maloai;
            Tenvc = tenvc;
            Soluongton = soluongton;
            Gia = gia;
        }
        public VaccineDTO( string maloai, string tenvc, string ngaysx, string hansudung, int gia)
        {
            Maloai = maloai;
            Tenvc = tenvc;
            Gia = gia;
        }
        public VaccineDTO ( string mavc, string maloai, string tenvc, string ngaysx, string hansudung, int gia)
        {
            Mavc = mavc;
            Maloai = maloai;
            Tenvc = tenvc;
            Gia = gia;
        }
    }
}
