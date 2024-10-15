using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineDTO
    {
        string mavc, maloai, tenvc, ngaysx, hansudung;
        int soluongton, gia;
        public string Mavc { get => mavc; set => mavc = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenvc { get => tenvc; set => tenvc = value; }
        public string Ngaysx { get => ngaysx; set => ngaysx = value; }
        public string Hansudung { get => hansudung; set => hansudung = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public int Gia { get => gia; set => gia = value; }

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
