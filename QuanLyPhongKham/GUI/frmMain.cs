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

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isExiting = false;
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị form đăng nhập
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog(); // Sử dụng Show() để không chặn UI

            // Đặt biến để xác định rằng bạn đang thoát
            isExiting = true;

            // Đóng form hiện tại
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.No)
                    Application.Exit();
            }
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChild(new frmBenhNhan());
        }
    }
}
