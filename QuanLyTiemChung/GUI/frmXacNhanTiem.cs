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
    public partial class frmXacNhanTiem : Form
    {
        public frmXacNhanTiem()
        {
            InitializeComponent();
        }
        LichTiemDTO LT;
        string MANV;
        public frmXacNhanTiem(LichTiemDTO lt, string manv)
        {
            LT = lt;
            MANV = manv;
            InitializeComponent();
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

        private void BoGoc(Control tmp)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, 15, 15));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void frmXacNhanTiem_Load(object sender, EventArgs e)
        {
            txtTinhTrang.Text = "Khoẻ mạnh";
            txtTinhTrang.Focus();
            BoGoc(this);
            BoGoc(btnLuu);
            if (LT != null)
            {
                lblmalt.Text = LT.MaLT;
                lblmahd.Text = LT.MaHD;
                lblmabn.Text = LT.MaBN;
                BenhNhanBLL  tmp = new BenhNhanBLL();
                DataRow[] dr = tmp.GetData().Select("MaBN = '"+LT.MaBN+"' ");
                lblhoten.Text = dr[0]["HoTen"].ToString();
                lblMavc.Text = LT.MaVC;
                VaccineBLL vcbll = new VaccineBLL();
                DataRow[] dr1 = vcbll.LayTTVC().Select("MaVC = '"+LT.MaVC+"' ");
                lbltenvc.Text = dr1[0]["TenVC"].ToString() ;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text.Length > 0)
            {
                if (LT != null)
                {
                    LT.TrangThai = txtTinhTrang.Text;
                    GhiNhanTiemChungBLL gnbll = new GhiNhanTiemChungBLL();
                    gnbll.XacNhanTiem(LT,MANV);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền trạng thái sau tiêm ");
            }
        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTinhTrang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar !=' ')
            {
                e.Handled = true;
                error.SetError(txtTinhTrang, "Không được nhập chữ vui lòng chỉ nhập chử");
            }
            else
                error.Clear();
        }
    }
}
