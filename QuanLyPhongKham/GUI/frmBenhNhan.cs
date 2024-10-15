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

namespace GUI
{
    public partial class frmBenhNhan : Form
    {
        BenhNhanBLL bnBLL;
        public frmBenhNhan()
        {
            InitializeComponent();
            bnBLL = new BenhNhanBLL();
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Regex pattern = new Regex("^BN\\d{3}$");
            if (!pattern.IsMatch(control.Text))
            {
                errMaSo.SetError(control, "Sai định dạng");
            }
            else
            {
                errMaSo.Clear();
            }
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

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
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
            if (txtSoDienThoai.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập lại số điện thoại");
                return false;
            }
            return true;
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
            txtSoDienThoai.Clear();
        }
        public void ClearErrorProvider()
        {
            errHoTen.Clear();
            errDiaChi.Clear();
            errMaSo.Clear();
            errSoDienThoai.Clear();
        }
        private void btnLuuBN_Click(object sender, EventArgs e)
        {
            if (!KTDuLieu())
                return;
            string selectedDateString = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            BenhNhanDTO bnDTO = new BenhNhanDTO(bnBLL.TaoMaBNMoi(), txtHoTen.Text.Trim(), GetGioiTinh(), txtDiaChi.Text.Trim(), txtSoDienThoai.Text.Trim(), selectedDateString);
            bool kq = bnBLL.Insert(bnDTO);
            if (kq)
            {
                MessageBox.Show("Thêm thành công");
                lstvDSBN.Items.Clear();
                LoadListViewDSBN();
                ClearTextBox();
                ClearErrorProvider();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void LoadListViewDSBN()
        {
            foreach (DataRow row in bnBLL.GetFullDataRows())
            {
                ListViewItem item1 = new ListViewItem([row["MaBN"].ToString(), row["HoTen"].ToString(), Convert.ToDateTime(row["NgaySinh"]).ToString("yyyy-MM-dd"), row["GioiTinh"].ToString(), row["DiaChi"].ToString(), row["SoDienThoai"].ToString()]);
                lstvDSBN.Items.Add(item1);
            }
        }
        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadListViewDSBN();
        }

        private void lstvDSBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                btnLuuBN.Enabled = false;
                ListViewItem selectedItem = lstvDSBN.SelectedItems[0];
                string hoTen = selectedItem.SubItems[1].Text;
                string ngaySinh = selectedItem.SubItems[2].Text;
                string gioiTinh = selectedItem.SubItems[3].Text;
                string diaChi = selectedItem.SubItems[4].Text;
                string soDienThoai = selectedItem.SubItems[5].Text;

                txtHoTen.Text = hoTen;
                dtpNgaySinh.Text = ngaySinh;
                if (gioiTinh.Equals("Nam"))
                    rdoNam.Checked = true;
                else rdoNu.Checked = true;
                txtDiaChi.Text = diaChi;
                txtSoDienThoai.Text = soDienThoai;
            }
            else
            {
                btnLuuBN.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                if (!KTDuLieu())
                    return;
                ListViewItem selectedItem = lstvDSBN.SelectedItems[0];
                string selectedDateString = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                BenhNhanDTO bnDTONew = new BenhNhanDTO(txtHoTen.Text.Trim(), GetGioiTinh(), txtDiaChi.Text.Trim(), txtSoDienThoai.Text.Trim(), selectedDateString);
                bool kq = bnBLL.Edit(selectedItem.SubItems[0].Text, bnDTONew);
                if (kq)
                {
                    MessageBox.Show("Cập nhật thành công");
                    lstvDSBN.Items.Clear();
                    LoadListViewDSBN();
                    ClearTextBox();
                    ClearErrorProvider();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại bệnh nhân cần cập nhật thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lstvDSBN.SelectedItems)
                {
                    string maBN = item.SubItems[0].Text;
                    bool result = bnBLL.Delete(maBN);
                    if (!result)
                    {
                        MessageBox.Show("Lỗi khi xóa bệnh nhân: " + maBN);
                    }
                }
                MessageBox.Show("Xóa thành công");
                lstvDSBN.Items.Clear();
                LoadListViewDSBN();
                ClearTextBox();
                ClearErrorProvider();
            }
            else
            {
                MessageBox.Show("Không tồn tại bệnh nhân cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void frmBenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            bnBLL.ClearDataSet();
        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
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

    }
}
