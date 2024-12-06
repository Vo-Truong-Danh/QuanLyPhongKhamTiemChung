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
                DataRow[] vcdto = vcbll.LayTTVC().Select("MaVC = '"+mavcdto+"' ");
                if (vcdto.Length > 0)
                {
                    txtTenVC.Text = vcdto[0]["TenVC"].ToString();
                    txtGia.Text = vcdto[0]["Gia"].ToString();
                    txtXuatXu.Text = vcdto[0]["XuatXu"].ToString();
                    cboLoaiVC.SelectedValue = vcdto[0]["MaLoai"];
                }
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
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    bool check = vcbll.Insert(vcdto);
                    if (check)
                        MessageBox.Show("Thêm thành công");
                    else{
                        MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dử liệu ");
                        return;
                    }
                }
                else
                {
                    VaccineDTO vcdto = new VaccineDTO()
                    {
                        Mavc = mavcdto,
                        Maloai = cboLoaiVC.SelectedValue.ToString(),
                        Tenvc = txtTenVC.Text,
                        Gia = int.Parse(txtGia.Text),
                        Xuatxu = txtXuatXu.Text,
                    };
                    bool check = vcbll.Update(vcdto);
                    if (check)
                        MessageBox.Show("Cập nhật thành công");
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công vui lòng kiểm tra lại dử liệu ");
                        return;
                    }
                }
            }
            this.Close();
        }

    }
}
