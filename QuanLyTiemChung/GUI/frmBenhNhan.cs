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
using System.Globalization;

namespace GUI
{
    public partial class frmBenhNhan : Form
    {
        BenhNhanBLL bnBLL;
        VaccineBLL vcBLL = new VaccineBLL();
        LoaiVaccineBLL loaiVCBLL = new LoaiVaccineBLL();
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
        public void LoadComboBoxVaccine()
        {
            cboLoaiVaccine.DataSource = loaiVCBLL.GetData();
            cboLoaiVaccine.DisplayMember = "TenLoai";
            cboLoaiVaccine.ValueMember = "MaLoai";
        }
        public string GetGioiTinh()
        {
            if (rdoNam.Checked||rdoNaminTTBN.Checked)
                return "Nam";
            if (rdoNu.Checked||rdoNuinTTBN.Checked)
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
        public bool KTDuLieuinTNBN()
        {
            if (txtHoTeninTTBN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên bệnh nhân");
                return false;
            }
            if (txtDiaChiinTTBN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return false;
            }
            if (txtSoDTinTTBN.Text.Trim() == string.Empty)
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
            pnlThemBN.Visible = true;
            btnXoaBN.Enabled = false;
        }


        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadListViewDSBN();
            LoadComboBoxVaccine();
            if (chucvu == 2)
            {
                btnXoaBN.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            pnlThongTinBenhNhan.Visible = false;
            pnlThemBN.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KTDuLieuinTNBN())
                return;
            string selectedDateString = dtpNgaySinhinTTBN.Value.ToString("yyyy-MM-dd");
            BenhNhanDTO bnDTONew = new BenhNhanDTO(txtHoTeninTTBN.Text.Trim(), GetGioiTinh(), txtDiaChiinTTBN.Text.Trim(), txtSoDTinTTBN.Text.Trim(), selectedDateString);
            bool kq = bnBLL.Edit(MaBenhNhan, bnDTONew);
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
            txtHoTeninTTBN.Clear();
            txtDiaChiinTTBN.Clear();
            txtSoDTinTTBN.Clear();
            rdoNuinTTBN.Checked=false;
            rdoNaminTTBN.Checked=false;
            pnlThemBN.Visible = false;
            pnlThongTinBenhNhan.Visible = false;
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
                string maBN = lstvDSBN.SelectedItems[0].SubItems[0].Text;
                frmReport rp = new frmReport(2,maBN);
                rp.ShowDialog();
            }
        }
        private string MaBenhNhan;
        private void btnThongTinChiTietBenhNhan_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                btnXoaBN.Enabled = false;
                pnlThemBN.Visible = true;
                pnlThongTinBenhNhan.Visible = true;
                pnlThongTinBenhNhan.BringToFront();

                // Lấy giá trị từ ListViewItem
                ListViewItem item = lstvDSBN.SelectedItems[0]; 
                MaBenhNhan = item.SubItems[0].Text;
                string HoTen = item.SubItems[1].Text;
                string NgaySinh = item.SubItems[2].Text; 
                string GioiTinh = item.SubItems[3].Text;
                string DiaChi = item.SubItems[4].Text;
                string SoDT = item.SubItems[5].Text;
              
                string[] date = NgaySinh.Split('/');

                txtHoTeninTTBN.Text = HoTen;
                if (GioiTinh == "Nam")
                    rdoNaminTTBN.Checked = true;
                else
                    rdoNuinTTBN.Checked = true;
                dtpNgaySinhinTTBN.Value =new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                txtDiaChiinTTBN.Text = DiaChi;
                txtSoDTinTTBN.Text = SoDT;
            }
        }


        private void btnXoaBNinTTBN_Click(object sender, EventArgs e)
        {
            bool xoaThanhCong = true;
            bool result = bnBLL.Delete(MaBenhNhan);
            if (!result)
            {
                xoaThanhCong = false;
            }
            if (xoaThanhCong)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDong_Click_1(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadListViewDSBN();
        }

        private void cboLoaiVaccine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maLoai = cboLoaiVaccine.SelectedValue.ToString();
            DataTable dr = vcBLL.Search(maLoai);
            cboVaccine.DataSource = dr;
            cboVaccine.DisplayMember = "TenVC";
            cboVaccine.ValueMember = "MaVC";
        }

        private void btnKQTiemChung_Click_1(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                string MaBenhNhan = lstvDSBN.SelectedItems[0].SubItems[0].Text;
                frmReport fm = new frmReport(2,MaBenhNhan);
                fm.ShowDialog();
            }
        }
    }
}
