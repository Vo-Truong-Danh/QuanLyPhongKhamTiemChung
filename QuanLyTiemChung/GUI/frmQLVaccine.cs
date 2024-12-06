using BLL;
using DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace GUI
{
    public partial class frmQLVaccine : Form
    {
        public frmQLVaccine()
        {
            InitializeComponent();
        }
        private NhanVienDTO TK = new NhanVienDTO();
        public frmQLVaccine(NhanVienDTO tk)
        {
            TK = tk;
            InitializeComponent();
        }
        static VaccineBLL vaccineBLL = new VaccineBLL();
        LoaiVaccineBLL loaivcbll = new LoaiVaccineBLL();
        PhieuNhapBLL pnbll = new PhieuNhapBLL();
        static ChiTietPhieuNhapBLL ctpnbll = new ChiTietPhieuNhapBLL();
        static DataTable dt = new DataTable();
        static DataTable dtvc = vaccineBLL.LayTTVC();
        static DataTable luuctpntmp = ctpnbll.GetData().Clone();

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
        public void LoadVaccine()
        {
            //VaccineBLL vaccineBLL = new VaccineBLL();
            //DataSet ds = vaccineBLL.LayTTVC();
            //dgvVaccine.DataSource = ds.Tables["Vaccine"];

        }

        public void LoadLoaiVaccineChoCBO()
        {
            //LoaiVaccineBLL loaiVaccineBLL = new LoaiVaccineBLL();
            //cboLoaiVaccine.DataSource = loaiVaccineBLL.GetData().Tables["LoaiVaccine"];
            //cboLoaiVaccine.DisplayMember = "TenLoai";
            //cboLoaiVaccine.ValueMember = "MaLoai";
        }

        public void LoadLoaiVaccine()
        {
            //LoaiVaccineBLL loaiVaccineBLL = new LoaiVaccineBLL();
            //dgvVaccine.DataSource = loaiVaccineBLL.GetData().Tables["LoaiVaccine"];
        }
        private void bingdingVC()
        {
            //cboLoaiVaccine.DataBindings.Clear();
            //cboLoaiVaccine.DataBindings.Add("SelectedValue", dgvVaccine.DataSource, "MaLoai");

            //txtTenVaccine.DataBindings.Clear();
            //txtTenVaccine.DataBindings.Add("Text", dgvVaccine.DataSource, "TenVC");

            //dtpNSX.DataBindings.Clear();
            //dtpNSX.DataBindings.Add("Value", dgvVaccine.DataSource, "NgaySX");

            //dtpHSD.DataBindings.Clear();
            //dtpHSD.DataBindings.Add("Value", dgvVaccine.DataSource, "HanSuDung");

            //txtGia.DataBindings.Clear();
            //txtGia.DataBindings.Add("Text", dgvVaccine.DataSource, "Gia");
        }
        private void bingdungLVC()
        {
            //txtTenLoaiVC.DataBindings.Clear();
            //txtTenLoaiVC.DataBindings.Add("Text", dgvVaccine.DataSource, "TenLoai");
        }
        private void CreateDTGV(DataTable dttb)
        {
            dgvVaccine.Columns.Clear();  // Xóa tất cả các cột
            dgvVaccine.Rows.Clear();     // Xóa tất cả các hàng
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn mavc = new DataGridViewTextBoxColumn
            {
                Name = "MaVC",
                HeaderText = "Mã Vaccine"
            };
            DataGridViewTextBoxColumn tenvc = new DataGridViewTextBoxColumn
            {
                Name = "TenVC",
                HeaderText = "Tên Vaccine"
            };
            DataGridViewTextBoxColumn soluongton = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongTon",
                HeaderText = "Số Lượng Tồn"
            };
            DataGridViewTextBoxColumn gia = new DataGridViewTextBoxColumn
            {
                Name = "Gia",
                HeaderText = "Giá"
            };
            DataGridViewTextBoxColumn xuatxu = new DataGridViewTextBoxColumn
            {
                Name = "XuatXu",
                HeaderText = "Xuất Xứ"
            };
            DataGridViewTextBoxColumn loai = new DataGridViewTextBoxColumn
            {
                Name = "Loai",
                HeaderText = "Loại Vaccine"
            };

            //Thêm vào dtg
            dgvVaccine.Columns.Add(stt);
            dgvVaccine.Columns.Add(mavc);
            dgvVaccine.Columns.Add(tenvc);
            dgvVaccine.Columns.Add(soluongton);
            dgvVaccine.Columns.Add(gia);
            dgvVaccine.Columns.Add(xuatxu);
            dgvVaccine.Columns.Add(loai);
            int tmp = 1;
            DataTable gan = loaivcbll.GetData();
            if (dttb != null)
            {
                foreach (DataRow row in dttb.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        DataRow[] dr = gan.Select("MaLoai = '" + row["MaLoai"] + "'");
                        // Lấy giá trị từ DataRow
                        string tenLoai = dr[0]["TenLoai"].ToString();
                        string maLoai = row["MaLoai"].ToString();

                        dgvVaccine.Rows.Add(tmp++, row["MaVC"], row["TenVC"], row["SoLuongTon"], row["Gia"], row["XuatXu"], tenLoai);

                    }
                }
            }
            CustomSizeCol();
            foreach (DataGridViewRow row in dgvVaccine.Rows)
            {
                if (row.Cells["SoLuongTon"].Value != null)
                {
                    int soLuongTon;
                    if (int.TryParse(row.Cells["SoLuongTon"].Value.ToString(), out soLuongTon))
                    {
                        if (soLuongTon < 10)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                        if (soLuongTon < 2)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                        }
                    }
                }
            }
        }
        private void CustomSizeCol()
        {

            dgvVaccine.Columns[0].Width = 60;
            dgvVaccine.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[1].Width = 200;

            dgvVaccine.Columns[2].Width = 280;

            dgvVaccine.Columns[3].Width = 200;
            dgvVaccine.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[4].Width = 200;
            dgvVaccine.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvVaccine.Columns[5].Width = 150;

            dgvVaccine.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }


        NhaCungCapBLL nccbll = new NhaCungCapBLL();

        //LOAD
        private void frmQLVaccine_Load(object sender, EventArgs e)
        {
            dt = ctpnbll.GetData();
            luuctpntmp = dt.Clone();

            dgvVaccine.ColumnHeadersHeight = 60;
            dgvVaccine.RowTemplate.Height = 60;
            dtgCTPN.ColumnHeadersHeight = 60;
            dtgCTPN.RowTemplate.Height = 60;
            dgvLoaiVC.ColumnHeadersHeight = 60;
            dgvLoaiVC.RowTemplate.Height = 60;
            dtgDanhSachVCduocChon.ColumnHeadersHeight = 60;
            dtgDanhSachVCduocChon.RowTemplate.Height = 60;
            dgvNCC.ColumnHeadersHeight = 60;
            dgvNCC.RowTemplate.Height = 60;

            txtSolUong.Text = "1";

            cboLoaiVC.DataSource = loaivcbll.GetData();
            cboLoaiVC.DisplayMember = "TenLoai";
            cboLoaiVC.ValueMember = "MaLoai";

            cboXuatXu.DataSource = vaccineBLL.LoadDSXuatXu();

            pnlTimKiem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlTimKiem.Width, pnlTimKiem.Height, 50, 50));
            BoGoc(pnlLoc, 50);
            BoGoc(pnlLocXuatXu, 50);
            CreateDTGV(vaccineBLL.LayTTVC());

            BoGoc(pnl2dongia, 20);
            BoGoc(pnl2_maphieu, 20);
            BoGoc(pnl2_ncc, 20);
            BoGoc(pnl2_ngaynhap, 20);
            BoGoc(pnl2tenvaccine, 20);
            BoGoc(pnlSoLuong, 20);
            BoGoc(pnlTongTien, 20);
            BoGoc(pnlThanhTien, 20);

            //Tab 2
            LoadNCC();
            pnl2_PN.Enabled = false;
            btnCapNhatCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            CreateDTGVVaccineLuaChon();

            //tab 3
            CreateDgvLoaiVaccine(loaivcbll.GetData());
            CreateDgvNCC(nccbll.GetData());
        }

        private void LoadNCC()
        {
            cboNCC.DataSource = nccbll.GetData();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
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
            //    if (dgvVaccine.SelectedRows.Count > 0)
            //    {
            //        string maVC = dgvVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
            //        string maLoai = cboLoaiVaccine.SelectedValue.ToString();
            //        string tenVC = txtTenVaccine.Text;
            //        string ngaySX = dtpNSX.Value.Date.ToString("yyyy/MM/dd");
            //        string hanSuDung = dtpHSD.Value.Date.ToString("yyyy/MM/dd");
            //        int gia = int.Parse(txtGia.Text);

            //        VaccineDTO vcDTO = new VaccineDTO(maVC, maLoai, tenVC, ngaySX, hanSuDung, gia);


            //        var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenVC + " này không?",
            //                                             "Xác nhận sửa",
            //                                             MessageBoxButtons.YesNo);
            //        if (t == DialogResult.Yes)
            //        {
            //            VaccineBLL vaccineBLL = new VaccineBLL();
            //            bool kt = vaccineBLL.Update(vcDTO);

            //            if (kt)
            //            {
            //                MessageBox.Show("Sửa thành công.");
            //                LoadVaccine();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Lỗi khi sửa " + tenVC + ".");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng chọn một Vaccine để sửa.");
            //    }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ndtimkiem = txtSearch.Text;
            DataTable DTTMP = vaccineBLL.SearchTen(ndtimkiem);
            if (DTTMP.Rows.Count > 0)
            {
                CreateDTGV(DTTMP);
                ThongBao("Nội dung đã được tìm thấy ", 1);
                return;
            }
            else
                CreateDTGV(DTTMP = null);
            ThongBao("Không tìm thấy nội dung nào phù hợp", 2);
        }

        private void btnThemLVC_Click(object sender, EventArgs e)
        {
            //    string tenlvc = txtTenLoaiVC.Text;
            //LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
            //bool kt = lvaccineBLL.Insert(tenlvc);
            //if (kt)
            //    MessageBox.Show("Thêm thành công Loại Vaccine mới " + tenlvc + "");
            //else
            //    MessageBox.Show("Thêm Loại " + tenlvc + " mới thất bại");
            //LoadLoaiVaccine();
        }

        //private void btnXoaLoaiVC_Click(object sender, EventArgs e)
        //{
        //    if (dgvVaccine.SelectedRows.Count > 0)
        //    {
        //        string maVC = dgvVaccine.SelectedRows[0].Cells["MaLoai"].Value.ToString();
        //        string TenVc = dgvVaccine.SelectedRows[0].Cells["TenLoai"].Value.ToString();

        //        DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa Loại " + TenVc + " này không?",
        //                                             "Xác nhận xóa",
        //                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (t == DialogResult.Yes)
        //        {
        //            LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
        //            bool kt = lvaccineBLL.Delete(maVC);

        //            if (kt)
        //            {
        //                MessageBox.Show("Xóa thành công " + TenVc + " .");
        //                LoadLoaiVaccine();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi xóa " + TenVc + " do thông tin Loại Vaccine đang được tham chiếu.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Loại Vaccine để xóa.");
        //    }
        //}

        private void btnSuaLVC_Click(object sender, EventArgs e)
        {
            //if (dgvVaccine.SelectedRows.Count > 0)
            //{
            //    string malVC = dgvVaccine.SelectedRows[0].Cells["MaLoai"].Value.ToString();
            //    string tenlVC = txtTenLoaiVC.Text;

            //    LoaiVaccineDTO lvcDTO = new LoaiVaccineDTO(malVC, tenlVC);


            //    var t = MessageBox.Show("Bạn có chắc chắn muốn sửa Loại " + tenlVC + " này không?",
            //                                         "Xác nhận sửa",
            //                                         MessageBoxButtons.YesNo);
            //    if (t == DialogResult.Yes)
            //    {
            //        LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
            //        bool kt = lvaccineBLL.Update(lvcDTO);

            //        if (kt)
            //        {
            //            MessageBox.Show("Sửa thành công.");
            //            LoadLoaiVaccine();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Lỗi khi sửa Loại " + tenlVC + ".");
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn một Loại Vaccine để sửa.");
            //}
        }

        private void LoadNhaCungCap()
        {
            //    NhaCungCapBLL ncc = new NhaCungCapBLL();
            //    dgvNhapVaccine.DataSource = ncc.GetData().Tables["NhaCungCap"];
        }
        private void bindingNCC()
        {
            //txtTenNCCVC.DataBindings.Clear();
            //txtTenNCCVC.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "TenNCC");
            //txtDiaChi.DataBindings.Clear();
            //txtDiaChi.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "DiaChi");
            //txtSoDienThoai.DataBindings.Clear();
            //txtSoDienThoai.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "SoDienThoai");

        }

        private void btnLoadNCC_Click(object sender, EventArgs e)
        {
            //grbChiTietNhapVC.Enabled = false;
            //grbHDN.Enabled = false;
            //LoadNhaCungCap();
            //grbNhaCC.Enabled = true;
            //bindingNCC();
        }

        //private void LoadPhieuNhap()
        //{
        //    PhieuNhapBLL ncc = new PhieuNhapBLL();
        //    dgvNhapVaccine.DataSource = ncc.GetData();
        //}
        //public void LoadLoaiNCCChoCBO()
        //{
        //    NhaCungCapBLL ncc = new NhaCungCapBLL();
        //    cboNhaCungCap.DataSource = ncc.GetData();
        //    cboNhaCungCap.DisplayMember = "TenNCC";
        //    cboNhaCungCap.ValueMember = "MaNCC";
        //}
        //private void bindingPN()
        //{
        //    cboNhaCungCap.DataBindings.Clear();
        //    cboNhaCungCap.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaNCC");

        //    dtpNgayNhapHang.DataBindings.Clear();
        //    dtpNgayNhapHang.DataBindings.Add("Value", dgvNhapVaccine.DataSource, "NgayNhap");
        //}

        //private void btnHoaDonNhap_Click(object sender, EventArgs e)
        //{
        //    LoadLoaiNCCChoCBO();
        //    grbChiTietNhapVC.Enabled = false;
        //    grbNhaCC.Enabled = false;
        //    grbHDN.Enabled = true;
        //    LoadPhieuNhap();
        //    bindingPN();
        //}

        //private void LoadChiTietPhieuNhap()
        //{
        //    ChiTietPhieuNhapBLL ncc = new ChiTietPhieuNhapBLL();
        //    dgvNhapVaccine.DataSource = ncc.GetData().Tables["ChiTietPhieuNhap"];
        //}
        //public void VaccineNhapChoCBO()
        //{
        //    //VaccineBLL ncc = new VaccineBLL();
        //    //cboVaccineNhapCTHD.DataSource = ncc.LayTTVC().Tables["Vaccine"];
        //    //cboVaccineNhapCTHD.DisplayMember = "TenVC";
        //    //cboVaccineNhapCTHD.ValueMember = "MaVC";
        //}
        //public void PhieuNhapChoCBO()
        //{
        //    PhieuNhapBLL ncc = new PhieuNhapBLL();
        //    cboMaHoaDonNHap.DataSource = ncc.GetData();
        //    cboMaHoaDonNHap.DisplayMember = "MaPN";
        //    cboMaHoaDonNHap.ValueMember = "MaPN";

        //}
        //private void bindingCTPN()
        //{
        //    cboMaHoaDonNHap.DataBindings.Clear();
        //    cboMaHoaDonNHap.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaPN");

        //    cboVaccineNhapCTHD.DataBindings.Clear();
        //    cboVaccineNhapCTHD.DataBindings.Add("SelectedValue", dgvNhapVaccine.DataSource, "MaVC");

        //    txtSoLuongNhap.DataBindings.Clear();
        //    txtSoLuongNhap.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "SoLuong");

        //    txtDonGiaNhap.DataBindings.Clear();
        //    txtDonGiaNhap.DataBindings.Add("Text", dgvNhapVaccine.DataSource, "DonGia");

        //}

        //private void btnChiTietNhap_Click(object sender, EventArgs e)
        //{
        //    PhieuNhapChoCBO();
        //    VaccineNhapChoCBO();
        //    grbChiTietNhapVC.Enabled = true;
        //    grbNhaCC.Enabled = false;
        //    grbHDN.Enabled = false;
        //    LoadChiTietPhieuNhap();
        //    bindingCTPN();
        //}

        //private void btnThemNCC_Click(object sender, EventArgs e)
        //{
        //    string tenncc = txtTenNCCVC.Text;
        //    string diachi = txtDiaChi.Text;
        //    string sdt = txtSoDienThoai.Text;
        //    NhaCungCapDTO dto = new NhaCungCapDTO(tenncc, diachi, sdt);
        //    NhaCungCapBLL tmp = new NhaCungCapBLL();
        //    bool kt = tmp.Insert(dto);
        //    if (kt)
        //        MessageBox.Show("Thêm thành công nhà cung cấp mới " + tenncc + "");
        //    else
        //        MessageBox.Show("Thêm nhà cung cấp  mới " + tenncc + " thất bại");
        //    LoadNhaCungCap();
        //}

        //private void btnXoaNCC_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaNCC"].Value.ToString();
        //        string ten = dgvNhapVaccine.SelectedRows[0].Cells["TenNCC"].Value.ToString();

        //        DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa " + ten + " này không?",
        //                                         "Xác nhận xóa",
        //                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (t == DialogResult.Yes)
        //        {
        //            NhaCungCapBLL tmp = new NhaCungCapBLL();
        //            bool kt = tmp.Delete(ma);

        //            if (kt)
        //            {
        //                MessageBox.Show("Xóa thành công " + ten + " .");
        //                LoadNhaCungCap();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi xóa " + ten + " do thông tin nhà cung cấp này đang được tham chiếu.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Nhà Cung Cấp để xóa.");
        //    }
        //}

        //private void btnCapNhatNCC_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string mamcc = dgvNhapVaccine.SelectedRows[0].Cells["MaNCC"].Value.ToString();
        //        string tenncC = txtTenNCCVC.Text;
        //        string diachi = txtDiaChi.Text;
        //        string sodienthoai = txtSoDienThoai.Text;

        //        NhaCungCapDTO tmp = new NhaCungCapDTO(mamcc, tenncC, diachi, sodienthoai);


        //        var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenncC + " này không?",
        //                                             "Xác nhận sửa",
        //                                             MessageBoxButtons.YesNo);
        //        if (t == DialogResult.Yes)
        //        {
        //            NhaCungCapBLL vaccineBLL = new NhaCungCapBLL();
        //            bool kt = vaccineBLL.Update(tmp);

        //            if (kt)
        //            {
        //                MessageBox.Show("Sửa thành công.");
        //                LoadNhaCungCap();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi sửa " + tenncC + ".");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một nhà cung cấp để sửa.");
        //    }
        //}

        //private void btnThemHoaDonNhapHangf_Click(object sender, EventArgs e)
        //{
        //    string ma = cboNhaCungCap.SelectedValue.ToString();
        //    string ngay = dtpNgayNhapHang.Value.Date.ToString("yyyy/MM/dd");
        //    PhieuNhapDTO dto = new PhieuNhapDTO(ma, ngay);
        //    PhieuNhapBLL tmp = new PhieuNhapBLL();
        //    bool kt = tmp.Insert(dto);
        //    if (kt)
        //        MessageBox.Show("Thêm thành công hoá đơn nhập mới ");
        //    else
        //        MessageBox.Show("Thêm nhà cung cấp mới hoá đơn thất bại");
        //    LoadPhieuNhap();
        //}

        //private void btnXoaHDNhap_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();

        //        DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa mã hoá đơn " + ma + " này không?",
        //                                         "Xác nhận xóa",
        //                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (t == DialogResult.Yes)
        //        {
        //            PhieuNhapBLL tmp = new PhieuNhapBLL();
        //            bool kt = tmp.Delete(ma);

        //            if (kt)
        //            {
        //                MessageBox.Show("Xóa thành công hoá đơn có mã " + ma + " .");
        //                LoadPhieuNhap();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi xóa hoá đơn có mã " + ma + " do mã hoá đơn nhập này đang được tham chiếu.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Hoá đơn nhập để xóa.");
        //    }
        //}

        //private void btnUpdateHDNhap_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string ma = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
        //        string ngay = dtpNgayNhapHang.Value.Date.ToString("yyyy/MM/dd");
        //        string mancc = cboNhaCungCap.SelectedValue.ToString();

        //        PhieuNhapDTO tmp = new PhieuNhapDTO(ma, ngay, mancc);


        //        var t = MessageBox.Show("Bạn có chắc chắn muốn sửa hoá đơn " + ma + " này không?",
        //                                             "Xác nhận sửa",
        //                                             MessageBoxButtons.YesNo);
        //        if (t == DialogResult.Yes)
        //        {
        //            PhieuNhapBLL tmpdto = new PhieuNhapBLL();
        //            bool kt = tmpdto.Update(tmp);

        //            if (kt)
        //            {
        //                MessageBox.Show("Sửa thành công.");
        //                LoadPhieuNhap();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi sửa hoá đơn có mã " + ma + ".");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Hoá đơn để sửa.");
        //    }
        //}

        //private void btnThemCTHDN_Click(object sender, EventArgs e)
        //{
        //    string mapn = cboMaHoaDonNHap.SelectedValue.ToString();

        //    string tenvc = cboVaccineNhapCTHD.Text;
        //    string mavc = cboVaccineNhapCTHD.SelectedValue.ToString();
        //    string soluong = txtSoLuongNhap.Text;
        //    string dongia = txtDonGiaNhap.Text;
        //    ChiTietPhieuNhapDTO dto = new ChiTietPhieuNhapDTO(mapn, mavc, soluong, dongia);
        //    ChiTietPhieuNhapBLL tmp = new ChiTietPhieuNhapBLL();
        //    bool kt = tmp.Insert(dto);
        //    if (kt)
        //        MessageBox.Show("Thêm thành công " + tenvc + " vào hoá đơn nhập " + mapn + " .");
        //    else
        //        MessageBox.Show("Thêm " + tenvc + " vào hoá đơn nhập " + mapn + " thất bại");
        //    LoadChiTietPhieuNhap();
        //    LoadVaccine();
        //}

        //private void btnXoaHDH_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string mapn = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
        //        string mavc = dgvNhapVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
        //        string tenvc = cboVaccineNhapCTHD.Text;

        //        DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa " + tenvc + " này trong Hoá đơn nhập " + mapn + " không?",
        //                                         "Xác nhận xóa",
        //                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (t == DialogResult.Yes)
        //        {
        //            ChiTietPhieuNhapBLL tmp = new ChiTietPhieuNhapBLL();
        //            bool kt = tmp.Delete(mapn, mavc);

        //            if (kt)
        //            {
        //                MessageBox.Show("Xóa thành công " + tenvc + " trong hoá đơn nhập " + mapn + "");
        //                LoadChiTietPhieuNhap();
        //                LoadVaccine();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi xóa " + tenvc + " trong hoá đơn nhập " + mapn + " do mã hoá đơn nhập này đang được tham chiếu.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Vaccine trong Hoá Đơn nhập để xóa.");
        //    }
        //}

        //private void btnUpdateHDN_Click(object sender, EventArgs e)
        //{
        //    if (dgvNhapVaccine.SelectedRows.Count > 0)
        //    {
        //        string mapn = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
        //        string mavc = dgvNhapVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
        //        string tenvc = cboVaccineNhapCTHD.Text;
        //        string soluong = txtSoLuongNhap.Text;
        //        string dongia = txtDonGiaNhap.Text;

        //        ChiTietPhieuNhapDTO tmp = new ChiTietPhieuNhapDTO(mapn, mavc, soluong, dongia);

        //        var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenvc + " trong hoá đơn nhập " + mapn + " này không?",
        //                                             "Xác nhận sửa",
        //                                             MessageBoxButtons.YesNo);
        //        if (t == DialogResult.Yes)
        //        {
        //            ChiTietPhieuNhapBLL tmpdto = new ChiTietPhieuNhapBLL();
        //            bool kt = tmpdto.Update(tmp);

        //            if (kt)
        //            {
        //                MessageBox.Show("Sửa thành công  " + tenvc + " trong hoá đơn nhập " + mapn + " .");
        //                LoadChiTietPhieuNhap();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Lỗi khi sửa " + tenvc + " trong hoá đơn nhập " + mapn + ".");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một Vaccine trong Hoá đơn để sửa.");
        //    }
        //}

        private void btnThemVC_Click(object sender, EventArgs e)
        {
            frm_overlay frm = new frm_overlay(0);
            frm.ShowDialog();
            ReLoadFRM();
            if (VaccineDTO.CheckTB)
            {
                ThongBao("Thêm thành công Vaccine vào danh sách ", 1);
            }           
        }

        private void cboLoaiVC_Click(object sender, EventArgs e)
        {
            lblMaloaivctmp.Hide();
            lblXuatXu.Show();
        }

        private void cboLoaiVC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maloai = cboLoaiVC.SelectedValue.ToString();
            dgvVaccine.Columns.Clear();  // Xóa tất cả các cột
            dgvVaccine.Rows.Clear();     // Xóa tất cả các hàng
            CreateDTGV(vaccineBLL.Search(maloai));

        }

        private void cboXuatXu_Click(object sender, EventArgs e)
        {
            lblMaloaivctmp.Show();
            lblXuatXu.Hide();
        }
        private void ReLoadFRM()
        {
            dgvVaccine.Columns.Clear();
            dgvVaccine.Rows.Clear();
            CreateDTGV(vaccineBLL.LayTTVC());
        }

        private void cboXuatXu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string maloai = cboXuatXu.SelectedValue.ToString();
            dgvVaccine.Columns.Clear();  // Xóa tất cả các cột
            dgvVaccine.Rows.Clear();     // Xóa tất cả các hàng
            CreateDTGV(vaccineBLL.Search(maloai));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi sẽ được lưu vào Cơ Sở Dử Liệu",
                                 "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                vaccineBLL.Luu();
                loaivcbll.Luu();
            }
        }

        private void ThongBao(string nd, int colortext)
        {
            // 0 là đen _ 1 là xanh _ 2 là đỏ
            if (colortext == 0)
                lblndtb.ForeColor = Color.Black;
            if (colortext == 1)
                lblndtb.ForeColor = Color.Green;
            if (colortext == 2)
                lblndtb.ForeColor = Color.Red;

            lblndtb.Text = nd;
            pnlThongBao.Visible = true;
            BoGoc(pnlTb, 20);
            BoGoc(pnlThongBao, 20);
            timerTB.Start();
        }
        private void ThongBaoTab3(string nd, int colortext)
        {
            // 0 là đen _ 1 là xanh _ 2 là đỏ   
            if (colortext == 0)
                lblndTab3.ForeColor = Color.Black;
            if (colortext == 1)
                lblndTab3.ForeColor = Color.Green;
            if (colortext == 2)
                lblndTab3.ForeColor = Color.Red;

            lblndTab3.Text = nd;
            pnlTb3.Visible = true;
            BoGoc(pnlTb3, 20);
            BoGoc(pnlTb3s, 20);
            TimeTab3.Start();
        }
        private void XoaVaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvVaccine.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dgvVaccine.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] drcheckctpn = ctpnbll.GetData().Select("MaVC = '" + ma + "'");
            if (drcheckctpn.Length == 0)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa Vaccine '" + ten + "' này không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (t == DialogResult.Yes)
                {
                    bool ck = vaccineBLL.Delete(ma);
                    if (ck)
                    {
                        ThongBao("Xoá thành công Vaccine " + ten + "", 1);
                        ReLoadFRM();
                    }
                    else
                    {
                        ThongBao("Xoá thất lại Vaccine " + ten + "", 2);
                        ReLoadFRM();
                    }
                }
            }
            else
            {
                ThongBao("Vaccine " + ten + " đã được sử dụng không thể xoá thông tin!", 2);
            }
        }

        private void CapNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvVaccine.SelectedRows[0].Cells[1].Value.ToString();
            frm_overlay frm = new frm_overlay(1, ma);
            frm.ShowDialog();
            ReLoadFRM();
            ThongBao("Cập nhật thành công Vaccine vào danh sách ", 1);
        }

        private void timerTB_Tick(object sender, EventArgs e)
        {
            pnlThongBao.Visible = false;
            pnlThongBao.Location = new Point((this.ClientSize.Width - pnlThongBao.Width) / 2, this.ClientSize.Height);
            timerTB.Stop();

        }

        private void timerHieuUng_Tick(object sender, EventArgs e)
        {

        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {


        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            btnThemCTPN.Enabled = true;
            ThongBaoTab2("Tạo thành công phiếu nhập kho mới ", 1);
            int sl = pnbll.GetData().Rows.Count + 1;
            txtMaPhieuN.Text = "PN" + sl.ToString("D3") + "";
            pnl2_PN.Enabled = true;
            grb2_ChiTietPhieuNhap.Enabled = true;

            btnLuuPhieuNhap.Visible = true;
            btnTaoPhieuNhap.Enabled = false;
            btnLuuPhieuNhap.Enabled = true;
            btnThemCTPN.Enabled = true;
            btnInPhieuNhap.Visible = false;

        }

        private void txtSoLuongCTPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSolUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || e.KeyChar == '0')
            {
                e.Handled = true;
                ThongBaoTab2("Vui lòng chỉ được nhập số vào ô số lượng!", 2);

            }
            else
            {
                if (txtSolUong.Text.Length > 0 && txtDonGiaCTPN.Text.Length > 0)
                {
                    txtThanhTien.Text = (double.Parse(txtSolUong.Text) * double.Parse(txtDonGiaCTPN.Text)).ToString();
                }
            }
        }

        private void txtSolUong_TextChanged(object sender, EventArgs e)
        {
            if (txtSolUong.Text.Length > 0 && txtDonGiaCTPN.Text.Length > 0)
            {
                txtThanhTien.Text = (double.Parse(txtSolUong.Text) * double.Parse(txtDonGiaCTPN.Text)).ToString();
            }
        }
        private void CreateDTGVVaccineLuaChon()
        {
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn mavc = new DataGridViewTextBoxColumn
            {
                Name = "MaVC",
                HeaderText = "Mã Vaccine"
            };
            DataGridViewTextBoxColumn tenvc = new DataGridViewTextBoxColumn
            {
                Name = "TenVC",
                HeaderText = "Tên Vaccine"
            };

            DataGridViewTextBoxColumn loai = new DataGridViewTextBoxColumn
            {
                Name = "Loai",
                HeaderText = "Loại Vaccine"
            };

            //Thêm vào dtg
            dtgCTPN.Columns.Add(stt);
            dtgCTPN.Columns.Add(mavc);
            dtgCTPN.Columns.Add(tenvc);
            int tmp = 1;
            DataTable gan = loaivcbll.GetData();
            foreach (DataRow row in vaccineBLL.LayTTVC().Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {

                    dtgCTPN.Rows.Add(tmp++, row["MaVC"], row["TenVC"]);
                }
            }
            CustomSizeColCTPN();
        }
        private void CustomSizeColCTPN()
        {

            dtgCTPN.Columns[0].Width = 60;
            dtgCTPN.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCTPN.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgCTPN.Columns[1].Width = 170;
            dtgCTPN.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCTPN.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgCTPN.Columns[2].Width = 220;

            dtgCTPN.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtgCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dtgCTPN.SelectedRows[0].Cells[1].Value.ToString();
            VaccineDTO vctmp = vaccineBLL.SearchChiTiet(ma);
            if (vctmp != null)
            {
                txtTenVCCTPN.Tag = vctmp.Mavc1;
                txtTenVCCTPN.Text = vctmp.Tenvc;
                txtDonGiaCTPN.Text = vctmp.Gia.ToString();
            }
            if (txtSolUong.Text.Length > 0 && txtDonGiaCTPN.Text.Length > 0)
            {
                txtThanhTien.Text = (double.Parse(txtSolUong.Text) * double.Parse(txtDonGiaCTPN.Text)).ToString();
            }
            btnCapNhatCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnThemCTPN.Enabled = true;
        }

        private bool CheckCTPN()
        {
            if (txtSolUong.Text.Length == 0 || txtThanhTien.Text.Length == 0)
            {
                ThongBaoTab2("Vui lòng nhập đầy đủ giá trị !", 2);
                return false;
            }
            return true;
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            if (btnTaoPhieuNhap.Enabled == false)
            {
                if (CheckCTPN())
                {
                    if (luuctpntmp == null)
                    {
                        luuctpntmp = ctpnbll.GetData().Clone();
                    }
                    DataRow[] checktb = luuctpntmp.Select("MaVC = '" + txtTenVCCTPN.Tag.ToString() + "'");
                    if (checktb.Length > 0)
                    {
                        DialogResult t = MessageBox.Show("Bạn đã chọn Vaccine " + txtTenVCCTPN.Text + " này rồi bạn có muốn cộng dồn số lượng không ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (t == DialogResult.Yes)
                        {
                            checktb[0]["SoLuong"] = int.Parse(checktb[0]["SoLuong"].ToString()) + int.Parse(txtSolUong.Text);
                            LoadCTDSPN(luuctpntmp);
                        }
                    }
                    else
                    {
                        DataRow drnew = luuctpntmp.NewRow();
                        {
                            drnew[0] = txtMaPhieuN.Text;
                            drnew[1] = txtTenVCCTPN.Tag.ToString();
                            drnew[2] = txtSolUong.Text;
                            drnew[3] = txtDonGiaCTPN.Text;
                        }
                        luuctpntmp.Rows.Add(drnew);
                        LoadCTDSPN(luuctpntmp);
                    }
                }
            }
            else
                ThongBao("Vui lòng tạo hóa phiếu nhập kho trước khi thêm ", 0);
        }
        private void TinhTongTien()
        {
            double sum = 0;
            foreach (DataRow row in luuctpntmp.Rows)
            {
                sum += double.Parse(row["DonGia"].ToString()) * double.Parse(row["SoLuong"].ToString());
            }
            txtTongTien.Text = sum.ToString();
        }

        private void LoadCTDSPN(DataTable tmp)
        {
            dtgDanhSachVCduocChon.Columns.Clear();
            dtgDanhSachVCduocChon.Rows.Clear();
            CreateDTGV_ThemVC(tmp);
            TinhTongTien();
        }

        private void CreateDTGV_ThemVC(DataTable data)
        {

            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn mavc = new DataGridViewTextBoxColumn
            {
                Name = "MaVC",
                HeaderText = "Mã Vaccine"
            };
            DataGridViewTextBoxColumn tenvc = new DataGridViewTextBoxColumn
            {
                Name = "TenVC",
                HeaderText = "Tên Vaccine"
            };

            DataGridViewTextBoxColumn SoLuong = new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số Lượng "
            };
            DataGridViewTextBoxColumn dongia = new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn Giá "
            };
            DataGridViewTextBoxColumn thanhtien = new DataGridViewTextBoxColumn
            {
                Name = "ThanhTien",
                HeaderText = "Thành Tiền "
            };

            //Thêm vào dtg
            dtgDanhSachVCduocChon.Columns.Add(stt);
            dtgDanhSachVCduocChon.Columns.Add(mavc);
            dtgDanhSachVCduocChon.Columns.Add(tenvc);
            dtgDanhSachVCduocChon.Columns.Add(SoLuong);
            dtgDanhSachVCduocChon.Columns.Add(dongia);
            dtgDanhSachVCduocChon.Columns.Add(thanhtien);
            int tmp = 1;

            foreach (DataRow row in data.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    DataRow[] dr = vaccineBLL.LayTTVC().Select("MaVC = '" + row["MaVC"] + "' ");
                    if (dr.Length > 0)
                    {
                        string tenvctmp = dr[0]["TenVC"].ToString();
                        double thanht = double.Parse(row["SoLuong"].ToString()) * double.Parse(row["DonGia"].ToString());
                        dtgDanhSachVCduocChon.Rows.Add(tmp++, row["MaVC"], tenvctmp, row["SoLuong"], row["DonGia"], thanht);
                    }
                }
            }
            CustomSizeColThemVC();
        }
        private void CustomSizeColThemVC()
        {

            dtgDanhSachVCduocChon.Columns[0].Width = 60;
            dtgDanhSachVCduocChon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgDanhSachVCduocChon.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgDanhSachVCduocChon.Columns[1].Width = 170;
            dtgDanhSachVCduocChon.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgDanhSachVCduocChon.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgDanhSachVCduocChon.Columns[2].Width = 220;


            dtgDanhSachVCduocChon.Columns[3].Width = 130;
            dtgDanhSachVCduocChon.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgDanhSachVCduocChon.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dtgDanhSachVCduocChon.Columns[4].Width = 130;
            dtgDanhSachVCduocChon.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgDanhSachVCduocChon.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgDanhSachVCduocChon.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtgDanhSachVCduocChon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongBaoTab2(string ndtb, int coloroder)
        {
            if (coloroder == 1)
                txtndthongbaotab2.ForeColor = Color.Green;
            if (coloroder == 2)
                txtndthongbaotab2.ForeColor = Color.Red;

            BoGoc(pnlThongBaoTab2, 20);
            BoGoc(pnlThongBaotab2s, 20);

            txtndthongbaotab2.Text = ndtb;
            pnlThongBaoTab2.Visible = true;
            timerTB_Tab2.Start();
        }
        private void timerTB_Tab2_Tick(object sender, EventArgs e)
        {
            pnlThongBaoTab2.Visible = false;
            timerTB_Tab2.Stop();
        }

        private void dtgDanhSachVCduocChon_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn lưu những thay đổi sẽ được lưu vào Cơ Sở Dử Liệu",
                     "Xác nhận",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (t == DialogResult.Yes)
                {
                    PhieuNhapDTO pndto = new PhieuNhapDTO()
                    {
                        Mapn = txtMaPhieuN.Text,
                        MaNV1 = TK.MaNV,
                        Ngaynhap = dteNgayNhap.Value.ToString("yyyy-MM-dd"),
                        Mancc = cboNCC.SelectedValue.ToString(),
                        Tongtien = txtTongTien.Text,
                    };

                    pnbll.Insert(pndto);
                    pnbll.Luu();
                    ctpnbll.Luu(luuctpntmp);
                    ThongBaoTab2("Lưu thành công phiếu nhập kho vào cơ sở dử liệu", 1);

                    dtgDanhSachVCduocChon.Columns.Clear();  // Xóa tất cả các cột
                    dtgDanhSachVCduocChon.Rows.Clear();     // Xóa tất cả các hàng
                    luuctpntmp = null;

                    CreateDTGV(vaccineBLL.Load());


                    btnTaoPhieuNhap.Enabled = true;
                    btnLuuPhieuNhap.Enabled = false;
                    btnThemCTPN.Enabled = false;
                    mapnvuatao = txtMaPhieuN.Text;
                    txtMaPhieuN.Text = string.Empty;
                    txtThanhTien.Text = string.Empty;
                }
                btnInPhieuNhap.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi hãy thử lại hoặc khởi động lại ứng dụng ");
            }
        }
        private string mapnvuatao;
        private void dtgDanhSachVCduocChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaCTPN.Enabled = true;
            btnCapNhatCTPN.Enabled = true;
            string ma = dtgDanhSachVCduocChon.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dtgDanhSachVCduocChon.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] dr = luuctpntmp.Select("MaVC = '" + ma + "'");

            if (dr != null)
            {
                txtTenVCCTPN.Tag = dr[0]["MaVC"].ToString();
                txtTenVCCTPN.Text = ten;
                txtSolUong.Text = dr[0]["SoLuong"].ToString();
                txtDonGiaCTPN.Text = dr[0]["DonGia"].ToString();
            }
            btnThemCTPN.Enabled = false;
        }

        private void grb2_ChiTietPhieuNhap_Leave(object sender, EventArgs e)
        {
            btnCapNhatCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            txtSolUong.Focus();
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            if (CheckCTPN())
            {
                btnXoaCTPN.Enabled = false;
                DataRow[] dr = luuctpntmp.Select("MaVC = '" + txtTenVCCTPN.Tag.ToString() + "'");
                if (dr != null)
                {
                    luuctpntmp.Rows.Remove(dr[0]);
                }
                LoadCTDSPN(luuctpntmp);
                btnThemCTPN.Enabled = true;
            }
        }

        private void btnCapNhatCTPN_Click(object sender, EventArgs e)
        {
            if (CheckCTPN())
            {
                btnThemCTPN.Enabled = true;
                btnXoaCTPN.Enabled = false;
                DataRow[] dr = luuctpntmp.Select("MaVC = '" + txtTenVCCTPN.Tag.ToString() + "'");
                if (dr != null)
                {
                    dr[0]["SoLuong"] = txtSolUong.Text;
                    dr[0]["DonGia"] = txtDonGiaCTPN.Text;
                }
                LoadCTDSPN(luuctpntmp);
            }
        }

        private void cboLoaiVC_Leave(object sender, EventArgs e)
        {
            lblMaloaivctmp.Visible = true;

        }

        private void cboXuatXu_Leave(object sender, EventArgs e)
        {
            lblXuatXu.Visible = true;
        }

        private void pnlLoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgCTPN_Click(object sender, EventArgs e)
        {
            txtSolUong.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
                ThongBao("Vui lòng chỉ được nhập chử và số không được nhập ký tự đặc biệt", 0);
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        private void CreateDgvLoaiVaccine(DataTable dttb)
        {
            dgvLoaiVC.Columns.Clear();  // Xóa tất cả các cột
            dgvLoaiVC.Rows.Clear();     // Xóa tất cả các hàng
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn maloai = new DataGridViewTextBoxColumn
            {
                Name = "MaLoai",
                HeaderText = "Mã Loại"
            };
            DataGridViewTextBoxColumn tenloai = new DataGridViewTextBoxColumn
            {
                Name = "TenLoai",
                HeaderText = "Tên Loại Vaccine"
            };
            DataGridViewTextBoxColumn somui = new DataGridViewTextBoxColumn
            {
                Name = "SoMui",
                HeaderText = "Số Mũi"
            };
            DataGridViewTextBoxColumn soluong = new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số Lượng"
            };

            //Thêm vào dtg
            dgvLoaiVC.Columns.Add(stt);
            dgvLoaiVC.Columns.Add(maloai);
            dgvLoaiVC.Columns.Add(tenloai);
            dgvLoaiVC.Columns.Add(somui);
            dgvLoaiVC.Columns.Add(soluong);
            int tmp = 1;
            DataTable dttmp = vaccineBLL.LayTTVC();
            if (dttb != null)
            {
                foreach (DataRow row in dttb.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        string maloaivc = row["MaLoai"].ToString();

                        DataRow[] sltmp = dttmp.Select("MaLoai = '" + maloaivc + "'");
                        dgvLoaiVC.Rows.Add(tmp++, row["MaLoai"], row["TenLoai"], row["SoMui"], sltmp.Count());

                    }
                }
            }
            CustomSizeColLoaiVacine();
        }
        private void CustomSizeColLoaiVacine()
        {

            dgvLoaiVC.Columns[0].Width = 60;
            dgvLoaiVC.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiVC.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLoaiVC.Columns[1].Width = 90;

            dgvLoaiVC.Columns[2].Width = 260;

            dgvLoaiVC.Columns[3].Width = 90;
            dgvLoaiVC.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiVC.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLoaiVC.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoaiVC.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiVC.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvLoaiVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaLoaiVC_Click(object sender, EventArgs e)
        {
            string ma = dgvLoaiVC.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dgvLoaiVC.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] drcheckctpn = vaccineBLL.LayTTVC().Select("MaLoai = '" + ma + "'");
            if (drcheckctpn.Length == 0)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa loại Vaccine '" + ten + "' này không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (t == DialogResult.Yes)
                {
                    bool ck = loaivcbll.Delete(ma);
                    if (ck)
                    {
                        ThongBaoTab3("Xoá thành công loại Vaccine " + ten + "", 1);
                        CreateDgvLoaiVaccine(loaivcbll.GetData());
                    }
                    else
                    {
                        ThongBaoTab3("Xoá thất lại loại Vaccine " + ten + "", 2);
                        ReLoadFRM();
                    }
                }
            }
            else
            {
                ThongBaoTab3("Loại Vaccine " + ten + " đã được sử dụng không thể xoá thông tin!", 2);
            }
        }

        private void btnThemLoaiVC_Click(object sender, EventArgs e)
        {
            frm_overlay frm = new frm_overlay(2);
            frm.ShowDialog();
            if (VaccineDTO.CheckTB)
            {
                ThongBaoTab3("Thêm thành công Loại Vaccine vào danh sách ", 1);
                CreateDgvLoaiVaccine(loaivcbll.GetData());
            }

        }

        private void btnCapNhatLoaiVaccine_Click(object sender, EventArgs e)
        {
            string ma = dgvLoaiVC.SelectedRows[0].Cells[1].Value.ToString();
            frm_overlay frm = new frm_overlay(3, ma);
            frm.ShowDialog();
            ReLoadFRM();
            ThongBaoTab3("Cập nhật thành công Loai Vaccine vào danh sách ", 1);
            CreateDgvLoaiVaccine(loaivcbll.GetData());
        }
        private void CreateDgvNCC(DataTable dttb)
        {
            dgvNCC.Columns.Clear();  // Xóa tất cả các cột
            dgvNCC.Rows.Clear();     // Xóa tất cả các hàng
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn mancc = new DataGridViewTextBoxColumn
            {
                Name = "MaNCC",
                HeaderText = "Mã"
            };
            DataGridViewTextBoxColumn tenncc = new DataGridViewTextBoxColumn
            {
                Name = "TenNCC",
                HeaderText = "Tên Nhà Cung Cấp"
            };
            DataGridViewTextBoxColumn diachi = new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                HeaderText = "Địa Chỉ"
            };
            DataGridViewTextBoxColumn sdt = new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                HeaderText = "Số Điện Thoại"
            };

            //Thêm vào dtg
            dgvNCC.Columns.Add(stt);
            dgvNCC.Columns.Add(mancc);
            dgvNCC.Columns.Add(tenncc);
            dgvNCC.Columns.Add(diachi);
            dgvNCC.Columns.Add(sdt);
            int tmp = 1;
            if (dttb != null)
            {
                foreach (DataRow row in dttb.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        dgvNCC.Rows.Add(tmp++, row["MaNCC"], row["TenNCC"], row["DiaChi"], row["SoDienThoai"]);
                    }
                }
            }
            CustomSizeColNCC();
        }
        private void CustomSizeColNCC()
        {

            dgvNCC.Columns[0].Width = 60;
            dgvNCC.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNCC.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNCC.Columns[1].Width = 100;

            dgvNCC.Columns[2].Width = 320;

            dgvNCC.Columns[3].Width = 290;
            dgvNCC.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNCC.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNCC.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNCC.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frm_overlay frm = new frm_overlay(4);
            frm.ShowDialog();
            if (VaccineDTO.CheckTB)
            {
                ThongBaoTab3("Thêm thành công Nhà Cung Cấp mới vào danh sách ", 1);
                CreateDgvNCC(nccbll.GetData());
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            string ma = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] drcheck = pnbll.GetData().Select("MaNCC = '" + ma + "'");
            if (drcheck.Length == 0)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp Vaccine '" + ten + "' này không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (t == DialogResult.Yes)
                {
                    bool ck = nccbll.Delete(ma);
                    if (ck)
                    {
                        ThongBaoTab3("Xoá thành công nhà cung cấp Vaccine " + ten + "", 1);
                        CreateDgvNCC(nccbll.GetData());
                    }
                    else
                    {
                        ThongBaoTab3("Xoá thất lại nhà cung cấp Vaccine " + ten + "", 2);
                        ReLoadFRM();
                    }
                }
            }
            else
            {
                ThongBaoTab3("Nhà cung cấp Vaccine " + ten + " đã được sử dụng không thể xoá thông tin!", 2);
            }
        }

        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            string ma = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
            frm_overlay frm = new frm_overlay(5, ma);
            frm.ShowDialog();
            ThongBaoTab3("Cập nhật thành công nhà cung cấp Vaccine vào danh sách ", 1);
            CreateDgvNCC(nccbll.GetData());
        }

        private void LuuLoaiVaccine_Click(object sender, EventArgs e)
        {
            loaivcbll.Luu();
        }

        private void btnSaveNCC_Click(object sender, EventArgs e)
        {
            nccbll.Luu();
        }

        private void TimeTab3_Tick(object sender, EventArgs e)
        {
            pnlTb3.Visible = false;
            TimeTab3.Stop();
        }


        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            frmReport rp = new frmReport(1,mapnvuatao);
            this.Close();
            rp.ShowDialog();
        }

        private void cboLoaiVC_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaloaivctmp.Hide();
            lblXuatXu.Show();
        }

        private void cboXuatXu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaloaivctmp.Show();
            lblXuatXu.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = dgvVaccine.SelectedRows[0].Cells[1].Value.ToString();
            frm_overlay frm = new frm_overlay(1, ma);
            frm.ShowDialog();
            ReLoadFRM();
            ThongBao("Cập nhật thành công Vaccine vào danh sách ", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma = dgvVaccine.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dgvVaccine.SelectedRows[0].Cells[2].Value.ToString();
            DataRow[] drcheckctpn = ctpnbll.GetData().Select("MaVC = '" + ma + "'");
            if (drcheckctpn.Length == 0)
            {
                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa Vaccine '" + ten + "' này không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (t == DialogResult.Yes)
                {
                    bool ck = vaccineBLL.Delete(ma);
                    if (ck)
                    {
                        ThongBao("Xoá thành công Vaccine " + ten + "", 1);
                        MessageBox.Show("Vaccine đã được xoá");
                        ReLoadFRM();
                    }
                    else
                    {
                        ThongBao("Xoá thất lại Vaccine " + ten + "", 2);
                        MessageBox.Show("Vaccine đã được sử dung thông tin không thể xoá");
                        ReLoadFRM();
                    }
                }
            }
            else
            {
                ThongBao("Vaccine " + ten + " đã được sử dụng không thể xoá thông tin!", 2);
                MessageBox.Show("Vaccine đã được sử dung thông tin không thể xoá");
            }
        }
    }
}
