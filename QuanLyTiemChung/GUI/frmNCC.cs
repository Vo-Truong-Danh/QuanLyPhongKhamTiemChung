using BLL;
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
using System.Web;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
        }
        public frmNCC(string tmp)
        {
            ma = tmp;
            InitializeComponent();
        }

        string ma;

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
        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }
        private void frmNCC_Load(object sender, EventArgs e)
        {

            BoGoc(this, 30);
            BoGoc(pnlGia, 20);
            BoGoc(pnlTenVc, 20);
            BoGoc(panel1, 20);
            BoGoc(btnLuu, 20);

            if (ma != null)
            {
                NhaCungCapDTO tmp = nccbll.Search(ma);
                txtTenNCC.Text = tmp.Tenncc.ToString();
                txtDiaChi.Text = tmp.Diachi.ToString();
                txtSoDienThoai.Text = tmp.Sodienthoai.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                this.Close();
                VaccineDTO.CheckTB = false;
            }
        }
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                if (ma == null)
                {
                    int sl = nccbll.GetData().Rows.Count + 1;
                    NhaCungCapDTO tmp = new NhaCungCapDTO()
                    {
                        Mancc = "NCC" + sl.ToString("D3") + "",
                        Tenncc = txtTenNCC.Text,
                        Diachi = txtDiaChi.Text,
                       Sodienthoai = txtSoDienThoai.Text,
                    };
                    if (nccbll.Insert(tmp))
                        MessageBox.Show("Thêm thành công Nhà Cung Cấp mới");
                    else
                    {
                        MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dữ liệu !");
                        return;
                    }
                }
                else
                {
                    NhaCungCapDTO tmp = new NhaCungCapDTO()
                    {
                        Mancc = ma,
                        Tenncc = txtTenNCC.Text,
                        Diachi = txtDiaChi.Text,
                        Sodienthoai = txtSoDienThoai.Text,
                    };
                    nccbll.Update(tmp);
                }
                VaccineDTO.CheckTB = true;
            }
            this.Close();
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
                error.SetError(txtTenNCC, "Không được nhập số vui lòng chỉ nhập chữ");
            }
            else
                error.Clear();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                error.SetError(txtDiaChi, "Nhập sai");
            }
            else
                error.Clear();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b'&& e.KeyChar !=' ')
            {
                e.Handled = true;
                error.SetError(txtSoDienThoai, "Không được nhập chữ vui lòng chỉ nhập số");
            }
            if(txtSoDienThoai.Text.Length > 10)
            {
                e.Handled = true;
                error.SetError(txtSoDienThoai, "Số điện thoại ít hơn 10 số");
            }
            else
                error.Clear();
        }

    }
}
