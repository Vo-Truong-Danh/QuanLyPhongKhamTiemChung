using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        string maNV,hoTen,gioiTinh, chucVu,diaChi,soDienThoai, pass;
        int? quyen;
        public static bool CheckTB = false;
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Pass { get => pass; set => pass = value; }
        public int? Quyen { get => quyen; set => quyen = value; }

        public NhanVienDTO(string ten, string manv, string pass, int? quyen)
        {
            this.HoTen = ten;
            this.MaNV = manv;
            this.Pass = pass;
            this.Quyen = quyen;
        }
        public NhanVienDTO() { }

        public NhanVienDTO(string ten , int? quyen)
        {
            HoTen = ten;
            ChucVu = chucVu;
        }

        public NhanVienDTO(string maNV, string hoTen, string gioiTinh, string chucVu, string diaChi, string soDienThoai, string pass, int? quyen)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.pass = pass;
            this.quyen = quyen;
        }
    }
}
