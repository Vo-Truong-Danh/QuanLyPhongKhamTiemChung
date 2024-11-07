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
        string mavc, maloai, tenvc, ngaysx, hansudung,xuatxu;
        int soluongton, gia;
        public string Mavc { get => Mavc1; set => Mavc1 = value; }
        public string Maloai { get => Maloai1; set => Maloai1 = value; }
        public string Tenvc { get => Tenvc1; set => Tenvc1 = value; }
        public string Ngaysx { get => Ngaysx1; set => Ngaysx1 = value; }
        public string Hansudung { get => Hansudung1; set => Hansudung1 = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Mavc1 { get => mavc; set => mavc = value; }
        public string Maloai1 { get => maloai; set => maloai = value; }
        public string Tenvc1 { get => tenvc; set => tenvc = value; }
        public string Ngaysx1 { get => ngaysx; set => ngaysx = value; }
        public string Hansudung1 { get => hansudung; set => hansudung = value; }
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }

        public VaccineDTO() { }

        public VaccineDTO(string mavc, string Maloai, string tenvc, string ngaysx, string hansudung, int soluongton, int gia)
        {
            Mavc = mavc;
            Maloai = Maloai;
            Tenvc = tenvc;
            Ngaysx = ngaysx;
            Hansudung = hansudung;
            Soluongton = soluongton;
            Gia = gia;
        }
        public VaccineDTO( string maloai, string tenvc, string ngaysx, string hansudung, int gia)
        {
            Maloai = maloai;
            Tenvc = tenvc;
            Ngaysx = ngaysx;
            Hansudung = hansudung;
            Gia = gia;
        }
        public VaccineDTO ( string mavc, string maloai, string tenvc, string ngaysx, string hansudung, int gia)
        {
            Mavc = mavc;
            Maloai = maloai;
            Tenvc = tenvc;
            Ngaysx = ngaysx;
            Hansudung = hansudung;
            Gia = gia;
        }
    }
}
