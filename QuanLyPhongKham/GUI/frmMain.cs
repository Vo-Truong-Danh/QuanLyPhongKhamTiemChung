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
            InitializeComponent();
        }
        private string tennguoidangnhap;
        private int? chucvu;

        public frmMain(TaiKhoanDTO nd) : this()
        {
            tennguoidangnhap = nd.DisplayName;
            chucvu = nd.ChucVu;
        }
        static bool checksibarMoRong = true; 
        private int targetWidth = 1842;
        private int collapsedWidth = 1690;
        private void frmMain_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OpenChild(new frmTrangChu());
            txtTenHienThi.Text = ""+ tennguoidangnhap + "";
            if (chucvu == 2)
            {
                btnQLVaccine.Enabled = false;
                btnQLTiemChung.Enabled = false;
                btnQLNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }
            pctLogo.Hide();
            txtTenHienThi.Hide();
            pnlShow.Width = checksibarMoRong ? targetWidth : collapsedWidth;

            frmThongBao tb = new frmThongBao("Xin chào : "+tennguoidangnhap+"",4000,0);
            tb.ShowDialog();

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
            pnlShow.Controls.Add(childfr);
            pnlShow.Tag = childfr;
            childfr.BringToFront();
            childfr.Show();
        }

        private bool isExiting = false;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            isExiting = true;
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnQLBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChild(new frmBenhNhan(chucvu));
        }

        private void btnQLVaccine_Click(object sender, EventArgs e)
        {
            OpenChild(new frmQLVaccine());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChild(new frmTrangChu());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnThuMo_Click(object sender, EventArgs e)
        {
            if (checksibarMoRong)
            {
                targetWidth = collapsedWidth;
            }
            else
            {
                targetWidth = 1842;

                txtTenHienThi.Hide();
                pctLogo.Hide();
            }
            checksibarMoRong = !checksibarMoRong;
            Sibar.Start();
        }


        private void Sibar_Tick(object sender, EventArgs e)
        {
            if (pnlShow.Width < targetWidth)
            {
                pnlShow.Width += 10;
                if (pnlShow.Width >= targetWidth)
                {
                    Sibar.Stop();
                }
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
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
