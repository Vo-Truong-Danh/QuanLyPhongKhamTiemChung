using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GhiNhanTiemChungDTO
    {
        string mabn, mavc, manv, malt, mahd, ngaytiem, tinhtrang;

        public string Mabn { get => mabn; set => mabn = value; }
        public string Mavc { get => mavc; set => mavc = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Malt { get => malt; set => malt = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Ngaytiem { get => ngaytiem; set => ngaytiem = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public GhiNhanTiemChungDTO() { }
    }
}
