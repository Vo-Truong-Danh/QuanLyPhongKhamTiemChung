using BLL;
using DTO;
using System.Text.RegularExpressions;
namespace GUI
{
    public partial class frmDangKy : Form
    {
        TaiKhoanBLL nvBLL = new TaiKhoanBLL();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void chkbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbHienThiMK.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
                txtNhapLaiMK.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNhapLaiMK.PasswordChar = '*';
            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&]).{10,}$");

            if (!pattern.IsMatch(control.Text))
            {
                errMK.SetError(control, "Mật khẩu phải dài hơn 10 ký tự bao gồm:" + Environment.NewLine +
                                           "- Chữ cái hoa" + Environment.NewLine +
                                           "- Chữ cái thường" + Environment.NewLine +
                                           "- Ký tự đặc biệt" + Environment.NewLine +
                                           "- Số");
            }
            else
            {
                errMK.Clear();
            }
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text != txtMatKhau.Text || control.Text.Length <= 0)
            {
                errNhapLaiMK.SetError(control, "Mật khẩu không trùng khớp");
            }
            else
            {
                errNhapLaiMK.Clear();
            }
        }

        private void txtNhapLaiMK_Click(object sender, EventArgs e)
        {
            txtNhapLaiMK_TextChanged(sender, e);
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^[\\p{L}\\s]+$");

            if (!pattern.IsMatch(control.Text))
            {
                errHoTen.SetError(control, "Sai định dạng");
            }
            else
            {
                errHoTen.Clear();
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^[a-zA-Z0-9]+$");

            if (!pattern.IsMatch(control.Text))
            {
                errTaiKhoan.SetError(control, "Sai định dạng");
            }
            else
            {
                errTaiKhoan.Clear();
            }
        }
        public bool KTDuLieu()
        {
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                return false;
            }
            if (txtTaiKhoan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                return false;
            }
            if (txtMatKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return false;
            }
            if (txtNhapLaiMK.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                return false;
            }
            return true;
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (!KTDuLieu())
                return;
            TaiKhoanDTO nvDTO = new TaiKhoanDTO(txtHoTen.Text.Trim(),txtTaiKhoan.Text,txtMatKhau.Text.Trim(),0);
            bool kq= nvBLL.Insert(nvDTO);
            if (kq)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
