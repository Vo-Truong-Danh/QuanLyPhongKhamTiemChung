using BLL;
using CrystalDecisions.Shared;
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
        string mavcdto;
        public frm_ThemVaccine(string mavc)
        {
            InitializeComponent();
            mavcdto = mavc;
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
                VaccineDTO.CheckTB = false;
            }
        }
        private void BoGoc(Control tmp)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, 15, 15));
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            BoGoc(btnLuu);
            BoGoc(pnlLoai);
            cboLoaiVC.DataSource = loaivcbLL.GetData();
            cboLoaiVC.DisplayMember = "TenLoai";
            cboLoaiVC.ValueMember = "MaLoai";
            if (mavcdto != null)
            {
                btnThoat.Hide();
                VaccineDTO vcdto = vcbll.SearchChiTiet(mavcdto);
                txtTenVC.Text = vcdto.Tenvc;
                dteNSX.Value = DateTime.Parse(vcdto.Ngaysx);
                dteHSD.Value = DateTime.Parse(vcdto.Hansudung);
                txtGia.Text = vcdto.Gia.ToString();
                txtXuatXu.Text = vcdto.Xuatxu;
                cboLoaiVC.SelectedValue = vcdto.Maloai;
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            VaccineDTO.CheckTB = true;
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                if (mavcdto == null)
                {
                    int sl = vcbll.LayTTVC().Rows.Count + 1;
                    VaccineDTO vcdto = new VaccineDTO()
                    {
                        Mavc = "VC" + sl.ToString("D3") + "",
                        Maloai = cboLoaiVC.SelectedValue.ToString(),
                        Tenvc = txtTenVC.Text,
                        Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                        Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    vcbll.Insert(vcdto);
                }
                else
                {
                    VaccineDTO vcdto = new VaccineDTO()
                    {
                        Mavc = mavcdto,
                        Maloai = cboLoaiVC.SelectedValue.ToString(),
                        Tenvc = txtTenVC.Text,
                        Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                        Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    vcbll.Update(vcdto);
                }
            }
            this.Close();
        }

        private void txtTenVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
                error.SetError(txtTenVC, "Không được nhập ký tự đặc biệt");
            }
            else
                error.Clear();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                error.SetError(txtGia, "Không được nhập chữ vui lòng chỉ nhập số");
            }
            else
                error.Clear();
        }

        private void txtXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b' && e.KeyChar != '/')
            {
                e.Handled = true;
                error.SetError(txtXuatXu, "Vui lòng chỉ nhập chữ");
            }
            else
                error.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            VaccineDTO.CheckTB = true;
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                if (mavcdto == null)
                {
                    int sl = vcbll.LayTTVC().Rows.Count + 1;
                    VaccineDTO vcdto = new VaccineDTO()
                    {
                        Mavc = "VC" + sl.ToString("D3") + "",
                        Maloai = cboLoaiVC.SelectedValue.ToString(),
                        Tenvc = txtTenVC.Text,
                        Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                        Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    vcbll.Insert(vcdto);
                }
                else
                {
                    VaccineDTO vcdto = new VaccineDTO()
                    {
                        Mavc = mavcdto,
                        Maloai = cboLoaiVC.SelectedValue.ToString(),
                        Tenvc = txtTenVC.Text,
                        Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                        Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    vcbll.Update(vcdto);
                }
            }
            this.Close();
        }

        private void dteNSX_ValueChanged(object sender, EventArgs e)
        {
            if (dteNSX.Value > DateTime.Now)
            {
                dteNSX.Value = DateTime.Now.AddMonths(-1);
                dteNSX.Focus();
                error.SetError(dteNSX, "Ngày sản xuất không được sớm hơn thời gian hiện tại");
            }
            else
            {
                error.Clear();
            }
        }

        private void dteHSD_ValueChanged(object sender, EventArgs e)
        {
            if (dteHSD.Value < dteNSX.Value)
            {
                dteHSD.Value = dteNSX.Value.AddMonths(24);
                error.SetError(dteNSX, "Hạn sử dụng không được nhỏ hơn ngày sản xuất");
            }
            else
            {
                error.Clear();
            }
        }
    }
}
