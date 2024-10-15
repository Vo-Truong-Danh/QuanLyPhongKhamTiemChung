using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiVaccineDTO
    {
        string maloai,tenloai;

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }

        public LoaiVaccineDTO() { }
        public LoaiVaccineDTO(string maloai, string tenloai) { 
            Maloai = maloai;
            Tenloai = tenloai;
        }
    }
}
