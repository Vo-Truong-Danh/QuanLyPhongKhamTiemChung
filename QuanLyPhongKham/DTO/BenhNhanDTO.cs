using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhanDTO
    {
        string maBN, hoTen,gioiTinh,diaChi,soDienThoai;
        string ngaySinh;

        public BenhNhanDTO( string maBN,string hoTen, string gioiTinh, string diaChi, string soDienThoai, string ngaySinh)
        {
            this.maBN = maBN;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
        }
        public BenhNhanDTO( string hoTen, string gioiTinh, string diaChi, string soDienThoai, string ngaySinh)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngaySinh = ngaySinh;
        }
        public BenhNhanDTO() { }  

        public string MaBN { get => maBN; set => maBN = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
