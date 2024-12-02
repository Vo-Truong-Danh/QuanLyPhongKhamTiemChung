using BLL;
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
    public partial class HoaDon : Form
    {
        VaccineBLL vcBLL;
        HoaDonBLL hdBLL;
        LoaiVaccineBLL loaiVCBLL;
        public HoaDon()
        {
            InitializeComponent();
        }
        // Tạo Hóa Đơn
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = hdBLL.NewIDHD();
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTongTien.Text = 0.ToString();
            btnThemMuiTiem.Enabled = true;
            btnDieuChinhSoLuong.Enabled = true;
           /* if (true)
            {
                HoaDonDTO hd = new HoaDonDTO(txtMaHD.Text, DateTime.Now, mabenhnhan, "NV001", float.Parse(txtTongTien.Text));
                kq = hdBLL.Insert(hd);
            }
            if (kq)
            {
                ketqua = ketqua + " Hóa đơn";
            }*/
            // Them chi tiet hoa don
            if (txtMaHD.Text != null)
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if (row.Cells[0].Value == null)
                    { break; }
                    string mavc = row.Cells[0].Value.ToString();
                    int soluong = int.Parse(row.Cells[3].Value.ToString());
                    float dongia = float.Parse(row.Cells[4].Value.ToString());
                    ChiTietHoaDonDTO hd = new ChiTietHoaDonDTO(txtMaHD.Text, mavc, soluong, dongia);
                    hdBLL.AddCTHD(hd);
                }
                
            }
        }

        private void cboVaccine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboVaccine.SelectedValue == null || cboVaccine.SelectedValue.ToString() == "")
            {
                txtDonGia.Text = string.Empty;
                return;
            }

            string mavaccine = cboVaccine.SelectedValue.ToString();
            VaccineDTO vaccine = vcBLL.SearchChiTiet(mavaccine);

            if (vaccine != null)
            {
                txtDonGia.Text = vaccine.Gia.ToString();
                txtSoLuong.Text = 1.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy vaccine!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemMuiTiem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == null || txtDonGia.Text == "")
            {
                MessageBox.Show("Không thể thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ThanhTien = 0;
            string mavc = cboVaccine.SelectedValue.ToString();
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.Cells[0].Value == mavc)
                {
                    DialogResult r = MessageBox.Show("Mũi tiêm đã tồn tại. Bạn có muốn thêm vào không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        row.Cells[3].Value = int.Parse(txtSoLuong.Text.Trim()) + int.Parse(row.Cells[3].Value.ToString());
                        row.Cells[5].Value = int.Parse(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[4].Value.ToString());
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            ThanhTien = int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text);
            dgvChiTietHoaDon.Rows.Add(mavc, cboVaccine.Text, cboLoaiVaccine.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text), ThanhTien);
        }

        private void btnDieuChinhSoLuong_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.CurrentRow != null && txtSoLuong.Text.Trim() != null)
            {
                dgvChiTietHoaDon.CurrentRow.Cells[3].Value = txtSoLuong.Text;
                dgvChiTietHoaDon.CurrentRow.Cells[5].Value = int.Parse(dgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString()) * int.Parse(dgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString());
            }
            else
                MessageBox.Show("Không thể điều chỉnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public int TongThanhTienHoaDon()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
            {
                if (row.IsNewRow || row.Cells[5].Value == null)
                    continue;
                if (int.TryParse(row.Cells[5].Value.ToString(), out int value))
                {
                    tong += value;
                }
            }
            return tong;
        }

        private void cboLoaiVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvChiTietHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiTietHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvChiTietHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
        private void cboLoaiVaccine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maLoai = cboLoaiVaccine.SelectedValue.ToString();
            DataTable dr = vcBLL.LayTTVC().Select("MaLoai='" + maLoai + "'").CopyToDataTable();
            cboVaccine.DataSource = dr;
            cboVaccine.DisplayMember = "TenVC";
            cboVaccine.ValueMember = "MaVC";
        }
        public void LoadComboBoxVaccine()
        {
            cboLoaiVaccine.DataSource = loaiVCBLL.GetData();
            cboLoaiVaccine.DisplayMember = "TenLoai";
            cboLoaiVaccine.ValueMember = "MaLoai";
        }
    }
}
