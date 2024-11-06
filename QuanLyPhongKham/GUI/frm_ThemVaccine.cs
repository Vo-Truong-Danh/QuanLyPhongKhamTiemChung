using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemVaccine : Form
    {
        public frm_ThemVaccine()
        {
            InitializeComponent();
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeft,
           int nTop,
           int nRight,
           int rBottom,
           int nWidthEllipse,
           int nHeightEllipse
           );

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void BoGoc(Control tmp)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, 50, 50));
        }
        VaccineBLL vcbll = new VaccineBLL();
        LoaiVaccineBLL loaivcbLL = new LoaiVaccineBLL();
        private void frm_ThemVaccine_Load(object sender, EventArgs e)
        {
            BoGoc(pnlGia);
            BoGoc(pnlXuatXu);
            BoGoc(pnlNSX);
            BoGoc(pnlHSD);
            BoGoc(pnlTenVc);
            BoGoc(this);
            BoGoc(btnLuu);

            BoGoc(pnlLoai);
            cboLoaiVC.DataSource = loaivcbLL.GetData();
            cboLoaiVC.DisplayMember = "TenLoai";
            cboLoaiVC.ValueMember = "MaLoai";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {

                int sl = vcbll.LayTTVC().Rows.Count + 1;
                VaccineDTO vcdto = new VaccineDTO()
                {
                    Mavc = "VC"+sl.ToString()+"",
                    Maloai = cboLoaiVC.SelectedValue.ToString(),
                    Tenvc = txtTenVC.Text,
                    Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                    Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                    Gia = int.Parse(txtGia.Text),
                    Xuatxu = txtXuatXu.Text,
                };
                vcbll.Insert(vcdto);
                //vcbll.Luu();
                this.Close();
            }
        }
    }
}
