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
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemLoaiVaccine : Form
    {
        public frmThemLoaiVaccine()
        {
            InitializeComponent();
        }
        string malvc;
        public frmThemLoaiVaccine(string ma)
        {
            InitializeComponent();
            malvc = ma;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            VaccineDTO.CheckTB = false;
            this.Close();
        }
        LoaiVaccineBLL lvcbll = new LoaiVaccineBLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                if (malvc == null)
                {
                    int sl = lvcbll.GetData().Rows.Count + 1;
                    LoaiVaccineDTO lvcdto = new LoaiVaccineDTO()
                    {
                        Maloai = "LV" + sl.ToString("D3") + "",
                        Tenloai = txtTenLoaiVC.Text,
                        Somui = int.Parse(txtSoMui.Text),
                    };
                    if(lvcbll.Insert(lvcdto))
                        { MessageBox.Show("Thêm thành công Loại Vaccine");
                        VaccineDTO.CheckTB = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dử liệu ");
                        return;
                    }
                }
                else
                {
                    LoaiVaccineDTO tmp = new LoaiVaccineDTO()
                    {
                        Maloai = malvc.ToString(),
                        Tenloai = txtTenLoaiVC.Text,
                        Somui = int.Parse(txtSoMui.Text),
                    };
                    if (lvcbll.Update(tmp))
                    {
                        MessageBox.Show("Cập nhật thành công Loại Vaccine");
                        VaccineDTO.CheckTB = true;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công vui lòng kiểm tra lại dử liệu ");
                        return;
                    }
                }
            }
            this.Close();

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
        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }

        private void frmThemLoaiVaccine_Load(object sender, EventArgs e)
        {
            BoGoc(this, 30);
            BoGoc(pnlTenVc,20);
            BoGoc(pnlGia,20);
            BoGoc(btnLuu,20);
            if (malvc != null)
            {
                LoaiVaccineDTO tmp = lvcbll.Search(malvc);
                txtTenLoaiVC.Text = tmp.Tenloai.ToString();
                txtSoMui.Text = tmp .Somui.ToString();
            }
        }

        private void txtTenLoaiVC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
                error.SetError(txtTenLoaiVC, "Không được nhập số vui lòng chỉ nhập chữ");
            }
            else
                error.Clear();
        }

        private void txtSoMui_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                error.SetError(txtSoMui, "Không được nhập chữ vui lòng chỉ nhập số");
            }
            else
                error.Clear();
        }

    }
}
