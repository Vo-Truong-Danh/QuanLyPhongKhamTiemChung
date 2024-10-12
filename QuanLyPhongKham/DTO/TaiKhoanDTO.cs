using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        string displayName, userName, pass;
        int? chucVu;

        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public int? ChucVu { get => chucVu; set => chucVu = value; }
        public TaiKhoanDTO(string displayName, string userName, string pass, int chucVu)
        {
            this.displayName = displayName;
            this.userName = userName;
            this.pass = pass;
            this.chucVu = chucVu;
        }
        public TaiKhoanDTO() { }
    }
}
