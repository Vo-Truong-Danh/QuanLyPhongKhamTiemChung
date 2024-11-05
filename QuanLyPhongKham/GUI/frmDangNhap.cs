using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void TimerAcctive()
        {
            timer.Start();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangNhap.Width, btnDangNhap.Height, 50, 50));
            pnlTaiKhoan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlTaiKhoan.Width, pnlTaiKhoan.Height, 50, 50));
            pnlMatkhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlMatkhau.Width, pnlMatkhau.Height, 50, 50));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 50, 50));
            pctHU.Hide();
            timer.Interval = 4000;
        }
        TaiKhoanDTO kt;
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim().Length > 0 && txtMatKhau.Text.Trim().Length > 0)
            {
                kt = tkBLL.CheckUserNameAndPassword(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                if (kt == null)
                {
                    lblsai.Text = "Tài khoản hoặc mật khẩu không khớp";
                    timerSaiTK.Start();
                    return;
                }
                pctmain.Hide();
                txtTaiKhoan.Hide();
                pictureBox3.Hide();
                pnlTaiKhoan.Hide();
                pnlMatkhau.Hide();
                btnDangNhap.Hide();
                label1.Hide();
                HU.Start();
                pctHU.Show();
            }
            if (txtTaiKhoan.Text.Trim().Length == 0)
            {
                labLoiTaiKhoan.Text = "Tài khoản không được để trống";
                TimerAcctive();
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống";

            }
        }

        private void btnAnpass_Click(object sender, EventArgs e)
        {
            btnAnpass.Hide();
            btnHienpass.Show();
            txtMatKhau.PasswordChar = '\0';
        }

        private void btnHienpass_Click(object sender, EventArgs e)
        {
            btnHienpass.Hide();
            btnAnpass.Show();
            txtMatKhau.PasswordChar = '*';
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labLoiTaiKhoan.Text = string.Empty;

            lblLoiMatKhau.Text = string.Empty;
        }

        private void timerSaiTK_Tick(object sender, EventArgs e)
        {
            lblsai.Text = string.Empty;
        }

        private void frmDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTaiKhoan.Focused)
                {
                    txtMatKhau.Focus();
                }
                else if (txtMatKhau.Focused)
                {
                    btnDangNhap.PerformClick();
                }
            }
        }

        private void HU_Tick(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(kt);
            frmMain.ShowDialog();
            this.Close();
        }
    }
}
