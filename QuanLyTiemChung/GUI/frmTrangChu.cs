using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        VaccineBLL vcbll = new VaccineBLL();
        BenhNhanBLL bnbll = new BenhNhanBLL();
        ChiTietHoaDonBLL cthdbll = new ChiTietHoaDonBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            int sl = vcbll.LayTTVC().Rows.Count;
            lblSLvaccine.Text = " "+sl+" Loại Vaccine ";
            lblSLvaccine.ForeColor = Color.Black;
            lblNhanVien.Text = " " + nvbll.SoLuong() + " Nhân viên giỏi";
            lblNhanVien.ForeColor = Color.Black;
            lblBenhNhan.Text = " " + bnbll.SoLuong() + " Khách hàng tin tưởng ";
            lblBenhNhan.ForeColor = Color.Black;
            lblMuiTiem.Text = " " + cthdbll.SoLuong() + " Mũi đã tiêm ";
            lblMuiTiem.ForeColor = Color.Black;
        }

    }
}
