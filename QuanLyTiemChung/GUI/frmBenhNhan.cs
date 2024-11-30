using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmBenhNhan : Form
    {
        BenhNhanBLL bnBLL;
        public string maBN {  get; set; }
        public frmBenhNhan()
        {
            InitializeComponent();
            bnBLL = new BenhNhanBLL();
        }
        int? chucvu;
        public frmBenhNhan(int? cv)
        {
            InitializeComponent();
            bnBLL = new BenhNhanBLL();
            chucvu = cv;
        }

        public string GetGioiTinh()
        {
            if (rdoNam.Checked)
                return "Nam";
            if (rdoNu.Checked)
                return "Nữ";
            return string.Empty;
        }
        public void ClearTextBox()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
        }
        public void ClearErrorProvider()
        {
            errHoTen.Clear();
            errDiaChi.Clear();
            errSoDienThoai.Clear();
        }
        public bool KTDuLieu()
        {
            if (txtHoTen.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên bệnh nhân");
                return false;
            }
            if (txtDiaChi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return false;
            }
            if (txtSoDT.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập lại số điện thoại");
                return false;
            }
            return true;
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

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^[0-9\\p{L}\\s,/.]+$");
            if (!pattern.IsMatch(control.Text))
            {
                errDiaChi.SetError(control, "Sai định dạng");
            }
            else
            {
                errDiaChi.Clear();
            }
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex(@"^0\d{9}$");
            if (!pattern.IsMatch(control.Text))
            {
                errSoDienThoai.SetError(control, "Sai định dạng");
            }
            else
            {
                errSoDienThoai.Clear();
            }
        }
        public void LoadListViewDSBN()
        {
            lstvDSBN.Items.Clear();
            foreach (DataRow row in bnBLL.GetFullData().Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    ListViewItem item1 = new ListViewItem(row["MaBN"].ToString());
                    item1.SubItems.Add(row["HoTen"].ToString());
                    item1.SubItems.Add(Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy"));
                    item1.SubItems.Add(row["GioiTinh"].ToString());
                    item1.SubItems.Add(row["DiaChi"].ToString());
                    item1.SubItems.Add(row["SoDienThoai"].ToString());
                    lstvDSBN.Items.Add(item1);
                }
            }
        }

        private void btnLuuBN_Click(object sender, EventArgs e)
        {
            pnlThongtinBN.Visible = true;
            btnXoaBN.Enabled = false;
        }


        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadListViewDSBN();
            if (chucvu == 2)
            {
                btnXoaBN.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            pnlThongTinBenhNhan.Visible = false;
            pnlThongtinBN.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //if (lstvDSBN.SelectedItems.Count > 0)
            //{
            //    if (!KTDuLieu())
            //        return;
            //    ListViewItem selectedItem = lstvDSBN.SelectedItems[0];
            //    string selectedDateString = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            //    BenhNhanDTO bnDTONew = new BenhNhanDTO(txtHoTen.Text.Trim(), GetGioiTinh(), txtDiaChi.Text.Trim(), txtSoDienThoai.Text.Trim(), selectedDateString);
            //    bool kq = bnBLL.Edit(selectedItem.SubItems[0].Text, bnDTONew);
            //    if (kq)
            //    {
            //        MessageBox.Show("Cập nhật thành công");
            //        lstvDSBN.Items.Clear();
            //        LoadListViewDSBN();
            //        ClearTextBox();
            //        ClearErrorProvider();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cập nhật thất bại");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không tồn tại bệnh nhân cần cập nhật thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                bool xoaThanhCong = true;
                foreach (ListViewItem item in lstvDSBN.SelectedItems)
                {
                    string maBN = item.SubItems[0].Text;
                    bool result = bnBLL.Delete(maBN);
                    if (!result)
                    {
                        xoaThanhCong = false;
                        break;
                    }
                }
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListViewDSBN();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một bệnh nhân để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "Tên bệnh nhân")
            {
                lstvDSBN.Items.Clear();
                foreach (DataRowView rowView in bnBLL.GetDataViewFromTimKiem(txtTimKiem.Text))
                {
                    DataRow row = rowView.Row;
                    ListViewItem item1 = new ListViewItem(new string[]
                    {
                    row["MaBN"].ToString(),
                    row["HoTen"].ToString(),
                    Convert.ToDateTime(row["NgaySinh"]).ToString("yyyy-MM-dd"),
                    row["GioiTinh"].ToString(),
                    row["DiaChi"].ToString(),
                    row["SoDienThoai"].ToString()
                    });
                    lstvDSBN.Items.Add(item1);
                }
            }
            else if (string.IsNullOrEmpty(txtTimKiem.Text) || txtTimKiem.Text == "Tên bệnh nhân")
            {
                LoadListViewDSBN();
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tên bệnh nhân")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tên bệnh nhân";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadListViewDSBN();
            }
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            pnlThongtinBN.Visible = false;
            btnXoaBN.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlThongTinBenhNhan.Visible = false;
            btnXoaBN.Enabled = true;
        }
        private void btnThemBenhNhan_Click_1(object sender, EventArgs e)
        {
            if (!KTDuLieu())
                return;
            string selectedDateString = dteNgaySinh.Value.ToString("yyyy-MM-dd");
            BenhNhanDTO bnDTO = new BenhNhanDTO(bnBLL.TaoMaBNMoi(), txtHoTen.Text.Trim(), GetGioiTinh(), txtDiaChi.Text.Trim(), txtSoDT.Text.Trim(), selectedDateString);
            bool kq = bnBLL.Insert(bnDTO);
            if (kq)
            {
                MessageBox.Show("Thêm thành công");
                LoadListViewDSBN();
                ClearTextBox();
                ClearErrorProvider();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }      

        private void btnKQTiemChung_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.Items.Count > 0)
            {
                ListViewItem item = lstvDSBN.Items[0];
                frmKetQuaTiemChungBN frm = new frmKetQuaTiemChungBN();
                frm.maBN = item.SubItems[0].Text;
                frm.ShowDialog();
            }
        }

        private void btnThongTinChiTietBenhNhan_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                btnXoaBN.Enabled = false;
                pnlThongtinBN.Visible = true;
                pnlThongTinBenhNhan.BringToFront();
            }
        }
    }
}
