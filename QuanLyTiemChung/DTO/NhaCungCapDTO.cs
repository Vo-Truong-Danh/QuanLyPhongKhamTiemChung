using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        string mancc, tenncc, diachi, sodienthoai;

        public string Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }

        public NhaCungCapDTO() { }

        public NhaCungCapDTO(string mancc, string tenncc, string diachi, string sodienthoai)
        {
            Mancc = mancc;
            Tenncc = tenncc;
            Diachi = diachi;
            Sodienthoai = sodienthoai;
        }
        public NhaCungCapDTO(string tenncc, string diachi, string sodienthoai)
        {
            Tenncc = tenncc;
            Diachi = diachi;
            Sodienthoai = sodienthoai;
        }
    }
}
