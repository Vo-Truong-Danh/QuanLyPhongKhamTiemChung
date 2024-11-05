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

        private void chbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowpass.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            int cornerRadius = 20; // Bán kính bo góc
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddArc(new Rectangle(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim().Length > 0 && txtMatKhau.Text.Trim().Length > 0)
            {
                TaiKhoanDTO kt = tkBLL.CheckUserNameAndPassword(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                if (kt == null)
                {
                    lblLoiMatKhau.Text = "Tài khoản hoặc mật khẩu không khớp";
                    return;
                }
                frmMain frmMain = new frmMain(kt);
                frmMain.ShowDialog();
                this.Close();
            }
                if (txtTaiKhoan.Text.Trim().Length == 0)
                {
                    labLoiTaiKhoan.Text = "Tài khoản không được để trống";
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                lblLoiMatKhau.Text = "Mật khẩu không được để trống";
            }
        }
    }
}
