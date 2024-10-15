using BLL;
using DAL;
using DTO;
using System.Data;
using System.DirectoryServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLVaccine : Form
    {
        public frmQLVaccine()
        {
            InitializeComponent();
        }
        bool TrangThaiBang_1 = true;
        public void LoadVaccine()
        {
            VaccineBLL vaccineBLL = new VaccineBLL();
            DataSet ds = vaccineBLL.LayTTVC();
            dgvVaccine.DataSource = ds.Tables["Vaccine"];

        }

        public void LoadLoaiVaccineChoCBO()
        {
            LoaiVaccineBLL loaiVaccineBLL = new LoaiVaccineBLL();
            cboLoaiVaccine.DataSource = loaiVaccineBLL.GetData().Tables["LoaiVaccine"];
            cboLoaiVaccine.DisplayMember = "TenLoai";
            cboLoaiVaccine.ValueMember = "MaLoai";
        }

        public void LoadLoaiVaccine()
        {
            LoaiVaccineBLL loaiVaccineBLL = new LoaiVaccineBLL();
            dgvVaccine.DataSource = loaiVaccineBLL.GetData().Tables["LoaiVaccine"];
        }
        private void bingdingVC()
        {
            cboLoaiVaccine.DataBindings.Clear();
            cboLoaiVaccine.DataBindings.Add("SelectedValue", dgvVaccine.DataSource, "MaLoai");

            txtTenVaccine.DataBindings.Clear();
            txtTenVaccine.DataBindings.Add("Text", dgvVaccine.DataSource, "TenVC");

            dtpNSX.DataBindings.Clear();
            dtpNSX.DataBindings.Add("Value", dgvVaccine.DataSource, "NgaySX");

            dtpHSD.DataBindings.Clear();
            dtpHSD.DataBindings.Add("Value", dgvVaccine.DataSource, "HanSuDung");

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvVaccine.DataSource, "Gia");
        }
        private void bingdungLVC()
        {
            txtTenLoaiVC.DataBindings.Clear();
            txtTenLoaiVC.DataBindings.Add("Text", dgvVaccine.DataSource, "TenLoai");
        }
        private void frmQLVaccine_Load(object sender, EventArgs e)
        {
            dgvNhapVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhapVaccine.AutoResizeColumns();
            dgvVaccine.AutoResizeColumns();
        }

        private void btnLoadTTVC_Click(object sender, EventArgs e)
        {
            grbTimKiem.Enabled = true;
            LoadVaccine();
            LoadLoaiVaccineChoCBO();
            bingdingVC();
            grbLoaiVC.Enabled = false;
            grbTTVC.Enabled = true;
            TrangThaiBang_1 = true;
        }

        private void btnLoadTTLoaiVaccine_Click(object sender, EventArgs e)
        {
            grbTimKiem.Enabled = true;
            LoadLoaiVaccine();
            bingdungLVC();
            grbLoaiVC.Enabled = true;
            grbTTVC.Enabled = false;
            TrangThaiBang_1 = false;
        }

        private void btnThemTTVC_Click(object sender, EventArgs e)
        {
            string maloai = cboLoaiVaccine.SelectedValue.ToString();
            string tenvc = txtTenVaccine.Text;
            string ngaysx = dtpNSX.Value.Date.ToString("yyyy/MM/dd");
            string hsd = dtpHSD.Value.Date.ToString("yyyy/MM/dd");
            int gia = int.Parse(txtGia.Text);
            VaccineDTO vc = new VaccineDTO(maloai, tenvc, ngaysx, hsd, gia);
            VaccineBLL vaccineBLL = new VaccineBLL();
            bool kt = vaccineBLL.Insert(vc);
            if (kt)
                MessageBox.Show("Thêm thành công Vaccine mới");
            else
                MessageBox.Show("Thêm Vaccine mới thất bại");
            LoadVaccine();
        }

        private void btnXoaTTVC_Click(object sender, EventArgs e)
        {
            if (dgvVaccine.SelectedRows.Count > 0)
            {
                string maVC = dgvVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
                string TenVc = dgvVaccine.SelectedRows[0].Cells["TenVC"].Value.ToString();

                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa " + TenVc + " này không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                {
                    VaccineBLL vaccineBLL = new VaccineBLL();
                    bool kt = vaccineBLL.Delete(maVC);

                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công " + TenVc + " .");
                        LoadVaccine();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa " + TenVc + " do thông tin Vaccine đang được tham chiếu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Vaccine để xóa.");
            }
        }

        private void btnSuaTTVC_Click(object sender, EventArgs e)
        {
            if (dgvVaccine.SelectedRows.Count > 0)
            {
                string maVC = dgvVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
                string maLoai = cboLoaiVaccine.SelectedValue.ToString();
                string tenVC = txtTenVaccine.Text;
                string ngaySX = dtpNSX.Value.Date.ToString("yyyy/MM/dd");
                string hanSuDung = dtpHSD.Value.Date.ToString("yyyy/MM/dd");
                int gia = int.Parse(txtGia.Text);

                VaccineDTO vcDTO = new VaccineDTO(maVC, maLoai, tenVC, ngaySX, hanSuDung, gia);


                var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenVC + " này không?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    VaccineBLL vaccineBLL = new VaccineBLL();
                    bool kt = vaccineBLL.Update(vcDTO);

                    if (kt)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LoadVaccine();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa " + tenVC + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Vaccine để sửa.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ndtimkiem = txtSearch.Text;
            if (TrangThaiBang_1)
            {
                VaccineBLL vcbll = new VaccineBLL();
                DataSet ds = vcbll.Search(ndtimkiem);
                if (ds != null && ds.Tables["Vaccine"].Rows.Count > 0)
                {
                    dgvVaccine.DataSource = ds.Tables["Vaccine"];
                }
                else
                    MessageBox.Show("Không tìm thấy nội dung : " + ndtimkiem + ".");
            }
            else
            {
                LoaiVaccineBLL lvcbll = new LoaiVaccineBLL();
                DataTable ds = lvcbll.Search(ndtimkiem);
                if (ds.Rows.Count > 0)
                {
                    dgvVaccine.DataSource = ds;
                }
                else
                    MessageBox.Show("Không tìm thấy nội dung : " + ndtimkiem + ".");

            }
        }

        private void btnThemLVC_Click(object sender, EventArgs e)
        {
            string tenlvc = txtTenLoaiVC.Text;
            LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
            bool kt = lvaccineBLL.Insert(tenlvc);
            if (kt)
                MessageBox.Show("Thêm thành công Loại Vaccine mới " + tenlvc + "");
            else
                MessageBox.Show("Thêm Loại " + tenlvc + " mới thất bại");
            LoadLoaiVaccine();
        }

        private void btnXoaLoaiVC_Click(object sender, EventArgs e)
        {
            if (dgvVaccine.SelectedRows.Count > 0)
            {
                string maVC = dgvVaccine.SelectedRows[0].Cells["MaLoai"].Value.ToString();
                string TenVc = dgvVaccine.SelectedRows[0].Cells["TenLoai"].Value.ToString();

                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa Loại " + TenVc + " này không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                {
                    LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
                    bool kt = lvaccineBLL.Delete(maVC);

                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công " + TenVc + " .");
                        LoadLoaiVaccine();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa " + TenVc + " do thông tin Loại Vaccine đang được tham chiếu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Loại Vaccine để xóa.");
            }
        }

        private void btnSuaLVC_Click(object sender, EventArgs e)
        {
            if (dgvVaccine.SelectedRows.Count > 0)
            {
                string malVC = dgvVaccine.SelectedRows[0].Cells["MaLoai"].Value.ToString();
                string tenlVC = txtTenLoaiVC.Text;

                LoaiVaccineDTO lvcDTO = new LoaiVaccineDTO(malVC, tenlVC);


                var t = MessageBox.Show("Bạn có chắc chắn muốn sửa Loại " + tenlVC + " này không?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
                    bool kt = lvaccineBLL.Update(lvcDTO);

                    if (kt)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LoadLoaiVaccine();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa Loại " + tenlVC + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Loại Vaccine để sửa.");
            }
        }

        private void LoadNhaCungCap()
        {
            NhaCungCapBLL ncc = new NhaCungCapBLL();
            dgvNhapVaccine.DataSource = ncc.GetData().Tables["NhaCungCap"];
        }
        private void bindingNCC()
        {
            txtTenNCCVC.DataBindings.Clear();
            txtTenNCCVC.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "DiaChi");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "SoDienThoai");

        }

        private void btnLoadNCC_Click(object sender, EventArgs e)
        {
            grbChiTietNhapVC.Enabled = false;
            grbHDN.Enabled = false;
            LoadNhaCungCap();
            grbNhaCC.Enabled = true;
            bindingNCC();
        }

        private void LoadPhieuNhap()
        {
            PhieuNhapBLL ncc = new PhieuNhapBLL();
            dgvNhapVaccine.DataSource = ncc.GetData().Tables["PhieuNhap"];
        }
        public void LoadLoaiNCCChoCBO()
        {
            NhaCungCapBLL ncc = new NhaCungCapBLL();
            cboNhaCungCap.DataSource = ncc.GetData().Tables["NhaCungCap"];
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
        }
        private void bindingPN()
        {
            cboNhaCungCap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaNCC");

            dtpNgayNhapHang.DataBindings.Clear();
            dtpNgayNhapHang.DataBindings.Add("Value", dgvNhapVaccine.DataSource, "NgayNhap");
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            LoadLoaiNCCChoCBO();
            grbChiTietNhapVC.Enabled = false;
            grbNhaCC.Enabled = false;
            grbHDN.Enabled = true;
            LoadPhieuNhap();
            bindingPN();
        }

        private void LoadChiTietPhieuNhap()
        {
            ChiTietPhieuNhapBLL ncc = new ChiTietPhieuNhapBLL();
            dgvNhapVaccine.DataSource = ncc.GetData().Tables["ChiTietPhieuNhap"];
        }
        public void VaccineNhapChoCBO()
        {
            VaccineBLL ncc = new VaccineBLL();
            cboVaccineNhapCTHD.DataSource = ncc.LayTTVC().Tables["Vaccine"];
            cboVaccineNhapCTHD.DisplayMember = "TenVC";
            cboVaccineNhapCTHD.ValueMember = "MaVC";
        }
        public void PhieuNhapChoCBO()
        {
            PhieuNhapBLL ncc = new PhieuNhapBLL();
            cboMaHoaDonNHap.DataSource = ncc.GetData().Tables["PhieuNhap"];
            cboMaHoaDonNHap.DisplayMember = "MaPN";
            cboMaHoaDonNHap.ValueMember = "MaPN";

        }
        private void bindingCTPN()
        {
            cboMaHoaDonNHap.DataBindings.Clear();
            cboMaHoaDonNHap.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaPN");

            cboVaccineNhapCTHD.DataBindings.Clear();
            cboVaccineNhapCTHD.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaVC");

            txtSoLuongNhap.DataBindings.Clear();
            txtSoLuongNhap.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "SoLuong");

            txtDonGiaNhap.DataBindings.Clear();
            txtDonGiaNhap.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "DonGia");

        }

        private void btnChiTietNhap_Click(object sender, EventArgs e)
        {
            PhieuNhapChoCBO();
            VaccineNhapChoCBO();
            grbChiTietNhapVC.Enabled = true;
            grbNhaCC.Enabled = false;
            grbHDN.Enabled = false;
            LoadChiTietPhieuNhap();
            bindingCTPN();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenncc = txtTenNCCVC.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSoDienThoai.Text;
            NhaCungCapDTO dto = new NhaCungCapDTO(tenncc, diachi, sdt);
            NhaCungCapBLL tmp = new NhaCungCapBLL();
            bool kt = tmp.Insert(dto);
            if (kt)
                MessageBox.Show("Thêm thành công nhà cung cấp mới " + tenncc + "");
            else
                MessageBox.Show("Thêm nhà cung cấp  mới " + tenncc + " thất bại");
            LoadNhaCungCap();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaNCC"].Value.ToString();
                string ten = dgvNhapVaccine.SelectedRows[0].Cells["TenNCC"].Value.ToString();

                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa " + ten + " này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                {
                    NhaCungCapBLL tmp = new NhaCungCapBLL();
                    bool kt = tmp.Delete(ma);

                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công " + ten + " .");
                        LoadNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa " + ten + " do thông tin nhà cung cấp này đang được tham chiếu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Nhà Cung Cấp để xóa.");
            }
        }

        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string mamcc = dgvNhapVaccine.SelectedRows[0].Cells["MaNCC"].Value.ToString();
                string tenncC = txtTenNCCVC.Text;
                string diachi = txtDiaChi.Text;
                string sodienthoai = txtSoDienThoai.Text;

                NhaCungCapDTO tmp = new NhaCungCapDTO(mamcc, tenncC, diachi, sodienthoai);


                var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenncC + " này không?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    NhaCungCapBLL vaccineBLL = new NhaCungCapBLL();
                    bool kt = vaccineBLL.Update(tmp);

                    if (kt)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LoadNhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa " + tenncC + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhà cung cấp để sửa.");
            }
        }

        private void btnThemHoaDonNhapHangf_Click(object sender, EventArgs e)
        {
            string ma = cboNhaCungCap.SelectedValue.ToString();
            string ngay = dtpNgayNhapHang.Value.Date.ToString("yyyy/MM/dd");
            PhieuNhapDTO dto = new PhieuNhapDTO(ma, ngay);
            PhieuNhapBLL tmp = new PhieuNhapBLL();
            bool kt = tmp.Insert(dto);
            if (kt)
                MessageBox.Show("Thêm thành công hoá đơn nhập mới ");
            else
                MessageBox.Show("Thêm nhà cung cấp mới hoá đơn thất bại");
            LoadPhieuNhap();
        }

        private void btnXoaHDNhap_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();

                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa mã hoá đơn " + ma + " này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                {
                    PhieuNhapBLL tmp = new PhieuNhapBLL();
                    bool kt = tmp.Delete(ma);

                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công hoá đơn có mã " + ma + " .");
                        LoadPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa hoá đơn có mã " + ma + " do mã hoá đơn nhập này đang được tham chiếu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Hoá đơn nhập để xóa.");
            }
        }

        private void btnUpdateHDNhap_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
                string ngay = dtpNgayNhapHang.Value.Date.ToString("yyyy/MM/dd");
                string mancc = cboNhaCungCap.SelectedValue.ToString();

                PhieuNhapDTO tmp = new PhieuNhapDTO(ma,ngay,mancc);


                var t = MessageBox.Show("Bạn có chắc chắn muốn sửa hoá đơn " + ma + " này không?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    PhieuNhapBLL tmpdto = new PhieuNhapBLL();
                    bool kt = tmpdto.Update(tmp);

                    if (kt)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LoadPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa hoá đơn có mã " + ma + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Hoá đơn để sửa.");
            }
        }
    }
}
