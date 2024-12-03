using DTO;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            TK.UserName = "NV002";
            TK.DisplayName = "Nguyễn Văn Nam";
            TK.ChucVu = 0;
            InitializeComponent();
        }
        TaiKhoanDTO TK = new TaiKhoanDTO();

        public frmMain(TaiKhoanDTO nd) : this()
        {
            if (nd != null)
            {
                TK.UserName = nd.UserName;
                TK.DisplayName = nd.DisplayName;
                TK.ChucVu = nd.ChucVu;
            }
            else
            {
                TK.UserName = "NV002";
                TK.DisplayName = "Duong Trong Hoang";
                TK.ChucVu = 0;
            }
        }
        static bool checksibarMoRong = true; 
        private int targetWidth ;
        private int collapsedWidth ;
        int rongmax;


        private void Sibar_Tick(object sender, EventArgs e)
        {
            if (pnlShow.Width < targetWidth)
            {
                pnlShow.Width += 10;
                if (pnlShow.Width >= targetWidth)
                {
                    Sibar.Stop();
                }
                txtTenHienThi.Show();
            }
            else if (pnlShow.Width > targetWidth)
            {
                pnlShow.Width -= 10;
                if (pnlShow.Width <= targetWidth)
                {
                    Sibar.Stop();
                    txtTenHienThi.Show();
                    pctLogo.Show();
                }
                txtTenHienThi.Hide();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            targetWidth = (int)(screenWidth * 0.14);
            collapsedWidth = (int)(screenWidth * 0.045);
            rongmax = targetWidth;
            pnlShow.Width = checksibarMoRong ? targetWidth : collapsedWidth;
            OpenChild(new frmTrangChu());
            txtTenHienThi.Text = TK.DisplayName;
            if (TK.ChucVu == 2)
            {
                //btnQLVaccine.Enabled = false;
                //btnQLTiemChung.Enabled = false;
                //btnQLNhanVien.Enabled = false;
                //btnThongKe.Enabled = false;
            }
            pnlShow.Width = checksibarMoRong ? targetWidth : collapsedWidth;
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
        }
        private Form fromchild;
        private void OpenChild(Form childfr)
        {
            if (fromchild != null)
            {
                fromchild.Close();
            }
            fromchild = childfr;
            childfr.TopLevel = false;
            childfr.FormBorderStyle = FormBorderStyle.None;
            childfr.Dock = DockStyle.Fill;
            pnlHienThi.Controls.Add(childfr);
            pnlHienThi.Tag = childfr;
            childfr.BringToFront();
            childfr.Show();
        }

        private bool isExiting = false;

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!isExiting)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
        }

        private void btnTrangchus_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
        }

        private void btnQLVaccine_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
            OpenChild(new frmQLVaccine(TK));

        }

        private void btnQLVaccines_Click(object sender, EventArgs e)
        {
            OpenChild(new frmQLVaccine(TK));

        }

        private void btnFrmTrangChu_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
            OpenChild(new frmTrangChu());
        }

        private void btnfrmTrangchus_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start(); OpenChild(new frmTrangChu());
        }

        private void btnQLBenhNhan_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
            OpenChild(new frmBenhNhan(TK));
        }

        private void btnQLBenhNhans_Click(object sender, EventArgs e)
        {

            OpenChild(new frmBenhNhan(TK));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap tmp = new frmDangNhap();
            tmp.ShowDialog();
            this.Close();
        }

        private void txtTenHienThi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKes_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            else
            {
                targetWidth = rongmax;
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
            OpenChild(new frmThongKe());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChild(new frmThongKe());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChild(new frmHoaDon());
        }

        private void btnQLTiemChung_Click(object sender, EventArgs e)
        {

        }
    }
}
