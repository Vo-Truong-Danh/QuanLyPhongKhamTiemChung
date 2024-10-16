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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim().Length > 0 && txtMatKhau.Text.Trim().Length > 0)
            {
                string kt = tkBLL.CheckUserNameAndPassword(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                if (kt == null)
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmMain frmMain = new frmMain(kt);
                frmMain.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
        }
    }
}
