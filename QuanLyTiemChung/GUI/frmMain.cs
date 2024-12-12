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
            nv.MaNV = "NV002";
            nv.HoTen= "Trần Tấn Tài";
            nv.Quyen = 0;
            InitializeComponent();
        }
        NhanVienDTO nv = new NhanVienDTO();

        public frmMain(NhanVienDTO nd) : this()
        {
            if (nd != null)
            {
                nv.MaNV = nd.MaNV;
                nv.HoTen = nd.HoTen;
                nv.Quyen= nd.Quyen;
            }
            else
            {
                nv.MaNV = "NV002";
                nv.HoTen= "Võ Trường Danh";
                nv.Quyen= 0;
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
            txtTenHienThi.Text = nv.HoTen;
            if (nv.Quyen != 1)
            {
                button11.Enabled = false;
                button12.Enabled = false;
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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (!isExiting)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                    this.Close();
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
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
            OpenChild(new frmQLVaccine(nv));

        }

        private void btnQLVaccines_Click(object sender, EventArgs e)
        {
            OpenChild(new frmQLVaccine(nv));

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
            OpenChild(new frmBenhNhan(nv));
        }

        private void btnQLBenhNhans_Click(object sender, EventArgs e)
        {

            OpenChild(new frmBenhNhan(nv));
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

            OpenChild(new frmThongKe());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {

            OpenChild(new frmHoaDon());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChild(new frmHoaDon());
        }

        private void btnQLTiemChung_Click(object sender, EventArgs e)
        {

            OpenChild(new frmQuanLyLichTiem(nv));
        }

        private void btnQLTiemChungS_Click(object sender, EventArgs e)
        {

            OpenChild(new frmQuanLyLichTiem(nv));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChild(new frmNhanVien(nv));
        }

        private void button12_Click(object sender, EventArgs e)
        {

            OpenChild(new frmNhanVien(nv));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChild(new frmHoaDon());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenChild(new frmHoaDon());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            OpenChild(new frmHoaDon());
        }
    }
}
