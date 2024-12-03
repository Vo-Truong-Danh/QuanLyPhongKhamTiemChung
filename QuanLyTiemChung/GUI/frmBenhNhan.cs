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
        HoaDonBLL hdBLL = new HoaDonBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        LichTiemBLL ltBLL = new LichTiemBLL();
        public string maBN { get; set; }
        public frmBenhNhan()
        {
            InitializeComponent();
            bnBLL = new BenhNhanBLL();
        }
        NhanVienDTO NV;
        public frmBenhNhan(NhanVienDTO nv)
        {
            NV= nv;
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
            if (rdoNam.Checked || rdoNaminTTBN.Checked)
                return "Nam";
            if (rdoNu.Checked || rdoNuinTTBN.Checked)
                return "Nữ";
            return string.Empty;
        }
        public void ClearTextBox()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtMaHD.Clear();
            txtNgayLap.Clear();
            txtTongTien.Clear();
            dgvChiTietHoaDon.DataSource = null;
        }
        public void ClearErrorProvider()
        {
            errHoTen.Clear();
            errDiaChi.Clear();
            errSoDienThoai.Clear();
        }
        public bool KTDataGridView(DataGridView dtp)
        {
            if (dtp.Rows.Count == 0 || (dtp.Rows.Count == 1 && dtp.Rows[0].IsNewRow))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool KTDuLieuBN()
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
            btnThemBenhNhan.Text = "Thêm mới bệnh nhân";
            pnlThemBN.Visible = true;
            btnXoaBN.Enabled = false;
        }


        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(1, 40); 
            lstvDSBN.SmallImageList = imageList;
            txtSoLuong.Enabled = false;
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
                DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa tất cả thông tin bệnh nhân này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
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
            ClearTextBox();
            ClearErrorProvider();
            txtHoTeninTTBN.Clear();
            txtDiaChiinTTBN.Clear();
            txtSoDTinTTBN.Clear();
            btnThemBenhNhan.Text = "";
            MaBenhNhan = "";
            rdoNuinTTBN.Checked = false;
            rdoNaminTTBN.Checked = false;
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
            if (dgvChiTietHoaDon.DataSource == null)
            {
                btnTaoHD.Enabled = true;
                bool kq = false;
                string ketqua = "";
                string mahdtmp = txtMaHD.Text;
                // Them benh nhan
                if (!KTDuLieuBN())
                    return;
                if (!bnBLL.KTMaBNCoTonTai(MaBenhNhan))
                {
                    MaBenhNhan = bnBLL.TaoMaBNMoi();
                }
                string selectedDateString = dteNgaySinh.Value.ToString("yyyy-MM-dd");
                BenhNhanDTO bnDTO = new BenhNhanDTO(MaBenhNhan, txtHoTen.Text.Trim(), GetGioiTinh(), txtDiaChi.Text.Trim(), txtSoDT.Text.Trim(), selectedDateString);
                kq = bnBLL.Insert(bnDTO);
                if (kq)
                {
                    LoadListViewDSBN();
                    ketqua = "Bệnh nhân";
                    kq = false;
                }
                // Them hoa don
                if (txtMaHD.Text.Trim() != null && txtMaHD.Text.Trim() != "" && KTDataGridView(dgvChiTietHoaDon))
                {
                    HoaDonDTO hd = new HoaDonDTO(txtMaHD.Text, DateTime.Now, MaBenhNhan, NV.MaNV, float.Parse(txtTongTien.Text));
                    kq = hdBLL.Insert(hd);
                }
                if (kq)
                {
                    ketqua = ketqua + " Hóa đơn";
                }
                // Them chi tiet hoa don
                if (txtMaHD.Text.Trim() != null && txtMaHD.Text.Trim() != "" && kq)
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
                    ketqua = ketqua + " Chi tiết hóa đơn";
                }
                // Them lich tiem
                if (KTDataGridView(dgvChiTietHoaDon))
                {
                    foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                    {
                        if (row.Cells[0].Value == null)
                        { break; }
                        string mahd = txtMaHD.Text;
                        string mabn = MaBenhNhan;
                        string mavc = row.Cells[0].Value.ToString();
                        string[] date = row.Cells[6].Value.ToString().Split('/');
                        string ngayhentiem = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])).ToString("yyyy-MM-dd");
                        LichTiemDTO lt = new LichTiemDTO() { MaHD = mahd, MaBN = mabn, MaVC = mavc, NgayHenTiem = ngayhentiem };
                        bool check = ltBLL.ThemLichTiemChoHoaDon(lt);
                        if (check)
                        {
                            ketqua = null;
                        }
                    }
                    ketqua = ketqua + " Lịch tiêm";
                }

                if (ketqua != null)
                {
                    MessageBox.Show($"Thêm thành công {ketqua}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmReport rp = new frmReport(3, mahdtmp);
                rp.ShowDialog();
                ClearTextBox();
                ClearErrorProvider();
                dgvChiTietHoaDon.DataSource = null;
                ketqua = string.Empty;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 VACCINE");
            }
        }
        private void btnThemMuiTemChoBN_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {

                btnThemBenhNhan.Text = "Thêm mũi tiêm";
                pnlThemBN.Visible = true;
                btnXoaBN.Enabled = false;
                ListViewItem item = lstvDSBN.SelectedItems[0];
                MaBenhNhan = item.SubItems[0].Text;
                string HoTen = item.SubItems[1].Text;
                string NgaySinh = item.SubItems[2].Text;
                string GioiTinh = item.SubItems[3].Text;
                string DiaChi = item.SubItems[4].Text;
                string SoDT = item.SubItems[5].Text;

                txtHoTen.Text = HoTen;
                string[] date = NgaySinh.Split('/');
                if (GioiTinh == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                dteNgaySinh.Value = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                txtDiaChi.Text = DiaChi;
                txtSoDT.Text = SoDT;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnKQTiemChung_Click(object sender, EventArgs e)
        {
            if (lstvDSBN.Items.Count > 0)
            {
                string maBN = lstvDSBN.SelectedItems[0].SubItems[0].Text;
                frmReport rp = new frmReport(2, maBN);
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
                dtpNgaySinhinTTBN.Value = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                txtDiaChiinTTBN.Text = DiaChi;
                txtSoDTinTTBN.Text = SoDT;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool KTSoMuiTiemChoPhepTiem(LoaiVaccineDTO loaiVC)
        {
            int soLuongHienTai = 0;
             if (dgvChiTietHoaDon.Rows.Count > 0 && loaiVC.Tenloai!=null&&loaiVC.Tenloai!="")
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if(row.Cells[2].Value.ToString() ==loaiVC.Tenloai)
                        soLuongHienTai += int.Parse(row.Cells[3].Value.ToString());
                }
            }
            int? soMuiDuocTiem = loaiVCBLL.Search(loaiVC.Maloai).Somui;
            if (soLuongHienTai >= soMuiDuocTiem)
            {
                MessageBox.Show($"Vượt quá số lượng mũi được tiêm! Số mũi nhiều nhất ở loại này là {soMuiDuocTiem}");
                return false;
            }
            return true;
        }

        private void cboLoaiVaccine_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string maLoai = cboLoaiVaccine.SelectedValue.ToString();
                LoaiVaccineDTO loaiVC = loaiVCBLL.Search(maLoai);
                if (!KTSoMuiTiemChoPhepTiem(loaiVC))
                {
                    cboVaccine.DataSource = null;
                    return;
                }
                DataTable dr = vcBLL.LayTTVC().Select("MaLoai='" + maLoai + "' and SoLuongTon > 0 ").CopyToDataTable();
                cboVaccine.DataSource = dr;
                cboVaccine.DisplayMember = "TenVC";
                cboVaccine.ValueMember = "MaVC";
                btnThemMuiTiem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vaccine thuộc loại này không còn !");
                cboVaccine.DataSource = null;
            }
        }

        private void btnKQTiemChung_Click_1(object sender, EventArgs e)
        {
            if (lstvDSBN.SelectedItems.Count > 0)
            {
                string MaBenhNhan = lstvDSBN.SelectedItems[0].SubItems[0].Text;
                frmReport fm = new frmReport(2, MaBenhNhan);
                fm.ShowDialog();
            }
        }
        // Tạo Hóa Đơn
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            LoadComboBoxVaccine();
            txtMaHD.Text = hdBLL.NewIDHD();
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTongTien.Text = 0.ToString();
            btnDieuChinhSoLuong.Enabled = true;
            btnTaoHD.Enabled = false;
        }

        private void cboVaccine_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnThemMuiTiem_Click(object sender, EventArgs e)
        {
            string maLoai = cboLoaiVaccine.SelectedValue.ToString();
            LoaiVaccineDTO loaiVC = loaiVCBLL.Search(maLoai);
            if (!KTSoMuiTiemChoPhepTiem(loaiVC))
            {
                cboVaccine.DataSource = null;
                return;
            }
            btnThemBenhNhan.Enabled = true;
            string ma = cboVaccine.SelectedValue.ToString();
            DataRow[] dr = vcBLL.LayTTVC().Select("MaVC = '" + ma + "' ");
            if (txtSoLuong.Text != null && txtSoLuong.Text != "")
            {
                int sl = int.Parse(txtSoLuong.Text);
                if (dr.Length > 0 && int.Parse(dr[0]["SoLuongTon"].ToString()) > sl)
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
                        if (row.Cells[0].Value == mavc && row.Cells[6].Value.ToString() == dtpNgayHenTiem.Value.ToString("dd/MM/yyyy"))
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
                    dgvChiTietHoaDon.Rows.Add(mavc, cboVaccine.Text, cboLoaiVaccine.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text), ThanhTien, dtpNgayHenTiem.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Số lượng còn lại của VACCINE không đủ");
                }
            }
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
        private void dgvChiTietHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHoaDon.Rows.Count == 0) return;
            txtTongTien.Text = TongThanhTienHoaDon().ToString();
        }

        private void dgvChiTietHoaDon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvChiTietHoaDon.Rows.Count == 0) return;
            txtTongTien.Text = TongThanhTienHoaDon().ToString();
        }

        private void dgvChiTietHoaDon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvChiTietHoaDon.Rows.Count == 0) return;
            txtTongTien.Text = TongThanhTienHoaDon().ToString();
        }

        private void xóaMũiTiêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvChiTietHoaDon.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboLoaiVaccine_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboVaccine_SelectedValueChanged(object sender, EventArgs e)
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
        }

        private void cboLoaiVaccine_Click(object sender, EventArgs e)
        {
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            Regex pattern = new Regex(@"^\d+$"); 
            if (!string.IsNullOrEmpty(txtDonGia.Text))
            {
                txtSoLuong.Enabled = true;
            }
            else
            {
                txtSoLuong.Enabled = false;
                return; 
            }
            if (cboLoaiVaccine.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại vaccine.");
                return;
            }

            string maLoai = cboLoaiVaccine.SelectedValue.ToString();
            LoaiVaccineDTO loaiVC = loaiVCBLL.Search(maLoai);

            if (loaiVC == null)
            {
                MessageBox.Show("Thông tin loại vaccine không hợp lệ.");
                return;
            }

            int soLuongHienTai = 0;

            if (dgvChiTietHoaDon.Rows.Count > 0 && !string.IsNullOrEmpty(loaiVC.Tenloai))
            {
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == loaiVC.Tenloai)
                    {
                        soLuongHienTai += int.Parse(row.Cells[3].Value.ToString());
                    }
                }
            }

            if (!string.IsNullOrEmpty(ctr.Text) && pattern.IsMatch(ctr.Text))
            {
                soLuongHienTai += int.Parse(ctr.Text);
            }
            else
            {

                btnThemMuiTiem.Enabled = false;
                errSoLuong.SetError(ctr, "Chỉ chứa ký tự số.");
                return;
            }

            int? soMuiDuocTiem = loaiVC.Somui;

            if (soLuongHienTai > soMuiDuocTiem)
            {
                btnThemMuiTiem.Enabled = false;
                errSoLuong.SetError(ctr, $"Số lượng vượt mức cho phép (Tối đa: {soMuiDuocTiem}).");
            }
            else
            {
                btnThemMuiTiem.Enabled = true;
                errSoLuong.Clear(); 
            }
        }

    }
}
