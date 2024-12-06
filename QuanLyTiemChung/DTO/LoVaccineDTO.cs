using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoVaccineDTO
    {
        string mapn, mavc, malo, soluong, dongia;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Mavc { get => mavc; set => mavc = value; }
        public string Malo { get => malo; set => malo = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Dongia { get => dongia; set => dongia = value; }

        public LoVaccineDTO() { }
    }
}
