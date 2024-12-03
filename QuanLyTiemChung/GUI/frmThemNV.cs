using BLL;
using CrystalDecisions.Shared.Json;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemNV : Form
    {
        NhanVienBLL nvBLL =new NhanVienBLL();
        public frmThemNV()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>() { "Bác sĩ", "Y tá", "Dược sĩ", "Điều dưỡng" };
        private void frmThemNV_Load(object sender, EventArgs e)
        {
            cboChuVu.DataSource = list;
        }
        public bool KTDuLieuNV()
        {
            if (txtHoTenNV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên bệnh nhân");
                return false;
            }
            if (txtDiaChi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return false;
            }
            if (txtSoDT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                return false;
            }
            if (cboChuVu.Text== string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                return false;
            }
            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return false;
            }
            if (txtXacNhanMK.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                return false;
            }
            return true;
        }
        public string GetGioiTinh()
        {
            if (rdoNam.Checked)
                return "Nam";
            if (rdoNu.Checked)
                return "Nữ";
            return string.Empty;
        }
        public void ClearTextBox()
        {
            txtHoTenNV.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();   
            txtMatKhau.Clear();
            txtXacNhanMK.Clear();
        }
        public void ClearErrorProvider()
        {
            errHoTen.Clear();
            errDiaChi.Clear();
            errSoDT.Clear();
        }
  
       

        private void txtHoTenNV_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^[\\p{L}\\s]+$");

            if (!pattern.IsMatch(control.Text))
            {
                errHoTen.SetError(control, "Sai định dạng");
            }
            else
            {
                errHoTen.Clear();
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^[0-9\\p{L}\\s,/.]+$");
            if (!pattern.IsMatch(control.Text))
            {
                errDiaChi.SetError(control, "Sai định dạng");
            }
            else
            {
                errDiaChi.Clear();
            }
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex(@"^0\d{9}$");
            if (!pattern.IsMatch(control.Text))
            {
                errSoDT.SetError(control, "Sai định dạng");
            }
            else
            {
                errSoDT.Clear();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!KTDuLieuNV())
                return;
            if (txtMatKhau.Text == txtXacNhanMK.Text)
            {
                string Manv = nvBLL.TaoMaNVMoi();
                NhanVienDTO nv = new NhanVienDTO(Manv, txtHoTenNV.Text, GetGioiTinh(), cboChuVu.Text, txtDiaChi.Text, txtSoDT.Text, txtMatKhau.Text, 1);
                nvBLL.Insert(nv);
                MessageBox.Show("Thêm thành công.");
                NhanVienDTO.CheckTB = true;
    }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
    }
}
