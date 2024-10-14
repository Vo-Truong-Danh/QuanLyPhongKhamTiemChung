using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class VaccineDTO
    {
        string mavc, malaoi, tenvc, ngaysx, hansudung;
        int soluongton, gia;

        public string Mavc { get => mavc; set => mavc = value; }
        public string Malaoi { get => malaoi; set => malaoi = value; }
        public string Tenvc { get => tenvc; set => tenvc = value; }
        public string Ngaysx { get => ngaysx; set => ngaysx = value; }
        public string Hansudung { get => hansudung; set => hansudung = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public int Gia { get => gia; set => gia = value; }

        public VaccineDTO() { }

        public VaccineDTO(string mavc, string malaoi, string tenvc, string ngaysx, string hansudung, int soluongton, int gia)
        {
            Mavc = mavc;
            Malaoi = malaoi;
            Tenvc = tenvc;
            Ngaysx = ngaysx;
            Hansudung = hansudung;
            Soluongton = soluongton;
            Gia = gia;
        }
        public VaccineDTO( string malaoi, string tenvc, string ngaysx, string hansudung, int soluongton, int gia)
        {
            Malaoi = malaoi;
            Tenvc = tenvc;
            Ngaysx = ngaysx;
            Hansudung = hansudung;
            Soluongton = soluongton;
            Gia = gia;
        }
    }
}
