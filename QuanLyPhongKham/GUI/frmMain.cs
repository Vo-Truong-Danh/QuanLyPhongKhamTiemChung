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
        private void frmMain_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OpenChild(new frmTrangChu());
            txtTenHienThi.Text = tennguoidangnhap;
            if(chucvu == 2)
            {
                btnQLVaccine.Enabled = false;
                btnQLTiemChung.Enabled = false;
                btnQLNhanVien.Enabled = false;
                btnThongKe.Enabled = false;
            }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
