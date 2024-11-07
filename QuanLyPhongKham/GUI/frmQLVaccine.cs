using BLL;
using DAL;
using DTO;
using Microsoft.VisualBasic;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLVaccine : Form
    {
        public frmQLVaccine()
        {
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
        bool TrangThaiBang_1 = true;
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
        VaccineBLL vaccineBLL = new VaccineBLL();
        LoaiVaccineBLL loaivcbll = new LoaiVaccineBLL();
        private void CreateDTGV(DataTable dttb)
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
            DataGridViewTextBoxColumn nsx = new DataGridViewTextBoxColumn
            {
                Name = "NgaySX",
                HeaderText = "Ngày Sản Xuất"
            };
            DataGridViewTextBoxColumn hsd = new DataGridViewTextBoxColumn
            {
                Name = "HanSuDung",
                HeaderText = "Hạn Sử Dụng"
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
            dgvVaccine.Columns.Add(nsx);
            dgvVaccine.Columns.Add(hsd);
            dgvVaccine.Columns.Add(soluongton);
            dgvVaccine.Columns.Add(gia);
            dgvVaccine.Columns.Add(xuatxu);
            dgvVaccine.Columns.Add(loai);
            int tmp = 1;
            DataTable gan = loaivcbll.GetData();
            foreach (DataRow row in dttb.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    DataRow[] dr = gan.Select("MaLoai = '" + row["MaLoai"] + "'");
                    // Lấy giá trị từ DataRow
                    string tenLoai = dr[0]["TenLoai"].ToString();
                    string maLoai = row["MaLoai"].ToString();
                    string ngaysx = Convert.ToDateTime(row["NgaySX"]).ToString("dd/MM/yyyy");

                    dgvVaccine.Rows.Add(tmp++, row["MaVC"], row["TenVC"], ngaysx, Convert.ToDateTime(row["HanSuDung"]).ToString("dd/MM/yyyy"), row["SoLuongTon"], row["Gia"], row["XuatXu"], tenLoai);

                }
            }
            CustomSizeCol();
        }
        private void CustomSizeCol()
        {

            dgvVaccine.Columns[0].Width = 60;
            dgvVaccine.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[1].Width = 150;
            dgvVaccine.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[2].Width = 220;

            dgvVaccine.Columns[3].Width = 175;
            dgvVaccine.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[4].Width = 175;
            dgvVaccine.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[5].Width = 180;
            dgvVaccine.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVaccine.Columns[6].Width = 160;
            dgvVaccine.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVaccine.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvVaccine.Columns[7].Width = 150;

            dgvVaccine.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }


        NhaCungCapBLL nccbll = new NhaCungCapBLL();

        //LOAD
        private void frmQLVaccine_Load(object sender, EventArgs e)
        {
            dgvVaccine.ColumnHeadersHeight = 60;
            dgvNhapVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaccine.RowTemplate.Height = 60;
            dgvNhapVaccine.AutoResizeColumns();
            //dgvVaccine.AutoResizeColumns();
            cboLoaiVC.DataSource = loaivcbll.GetData();
            cboLoaiVC.DisplayMember = "TenLoai";
            cboLoaiVC.ValueMember = "MaLoai";

            cboXuatXu.DataSource = vaccineBLL.LoadDSXuatXu();

            pnlTimKiem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlTimKiem.Width, pnlTimKiem.Height, 50, 50));
            BoGoc(pnlLoc, 50);
            BoGoc(pnlLocXuatXu, 50);
            CreateDTGV(vaccineBLL.LayTTVC());

            pnl_2_TaoPhieuNhap.Enabled = false;
            BoGoc(pnl2dongia, 20);
            BoGoc(pnl2_maphieu, 20);
            BoGoc(pnl2_ncc, 20);
            BoGoc(pnl2_ngaynhap, 20);
            BoGoc(pnl2tenvaccine, 20);
            BoGoc(pnl2soluong, 20);

            LoadNCC();
        }

        private void LoadNCC()
        {
            cboNCC.DataSource = nccbll.GetData();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        private void btnLoadTTVC_Click(object sender, EventArgs e)
        {
            //grbTimKiem.Enabled = true;
            //LoadVaccine();
            //LoadLoaiVaccineChoCBO();
            //bingdingVC();
            //grbLoaiVC.Enabled = false;
            //grbTTVC.Enabled = true;
            //TrangThaiBang_1 = true;
        }

        private void btnThemTTVC_Click(object sender, EventArgs e)
        {
            //string maloai = cboLoaiVaccine.SelectedValue.ToString();
            //string tenvc = txtTenVaccine.Text;
            //string ngaysx = dtpNSX.Value.Date.ToString("yyyy/MM/dd");
            //string hsd = dtpHSD.Value.Date.ToString("yyyy/MM/dd");
            //int gia = int.Parse(txtGia.Text);
            //VaccineDTO vc = new VaccineDTO(maloai, tenvc, ngaysx, hsd, gia);
            //VaccineBLL vaccineBLL = new VaccineBLL();
            //bool kt = vaccineBLL.Insert(vc);
            //if (kt)
            //    MessageBox.Show("Thêm thành công Vaccine mới");
            //else
            //    MessageBox.Show("Thêm Vaccine mới thất bại");
            //LoadVaccine();
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
            //string ndtimkiem = txtSearch.Text;
            //if (TrangThaiBang_1)
            //{
            //    VaccineBLL vcbll = new VaccineBLL();
            //    DataSet ds = vcbll.Search(ndtimkiem);
            //    if (ds != null && ds.Tables["Vaccine"].Rows.Count > 0)
            //    {
            //        dgvVaccine.DataSource = ds.Tables["Vaccine"];
            //    }
            //    else
            //        MessageBox.Show("Không tìm thấy nội dung : " + ndtimkiem + ".");
            //}
            //else
            //{
            //    LoaiVaccineBLL lvcbll = new LoaiVaccineBLL();
            //    DataTable ds = lvcbll.Search(ndtimkiem);
            //    if (ds.Rows.Count > 0)
            //    {
            //        dgvVaccine.DataSource = ds;
            //    }
            //    else
            //        MessageBox.Show("Không tìm thấy nội dung : " + ndtimkiem + ".");

            //}
        }

        private void btnThemLVC_Click(object sender, EventArgs e)
        {
            //string tenlvc = txtTenLoaiVC.Text;
            //LoaiVaccineBLL lvaccineBLL = new LoaiVaccineBLL();
            //bool kt = lvaccineBLL.Insert(tenlvc);
            //if (kt)
            //    MessageBox.Show("Thêm thành công Loại Vaccine mới " + tenlvc + "");
            //else
            //    MessageBox.Show("Thêm Loại " + tenlvc + " mới thất bại");
            //LoadLoaiVaccine();
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

        private void LoadPhieuNhap()
        {
            PhieuNhapBLL ncc = new PhieuNhapBLL();
            dgvNhapVaccine.DataSource = ncc.GetData();
        }
        public void LoadLoaiNCCChoCBO()
        {
            NhaCungCapBLL ncc = new NhaCungCapBLL();
            cboNhaCungCap.DataSource = ncc.GetData();
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
            //VaccineBLL ncc = new VaccineBLL();
            //cboVaccineNhapCTHD.DataSource = ncc.LayTTVC().Tables["Vaccine"];
            //cboVaccineNhapCTHD.DisplayMember = "TenVC";
            //cboVaccineNhapCTHD.ValueMember = "MaVC";
        }
        public void PhieuNhapChoCBO()
        {
            PhieuNhapBLL ncc = new PhieuNhapBLL();
            cboMaHoaDonNHap.DataSource = ncc.GetData();
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

                PhieuNhapDTO tmp = new PhieuNhapDTO(ma, ngay, mancc);


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

        private void btnThemCTHDN_Click(object sender, EventArgs e)
        {
            string mapn = cboMaHoaDonNHap.SelectedValue.ToString();

            string tenvc = cboVaccineNhapCTHD.Text;
            string mavc = cboVaccineNhapCTHD.SelectedValue.ToString();
            string soluong = txtSoLuongNhap.Text;
            string dongia = txtDonGiaNhap.Text;
            ChiTietPhieuNhapDTO dto = new ChiTietPhieuNhapDTO(mapn, mavc, soluong, dongia);
            ChiTietPhieuNhapBLL tmp = new ChiTietPhieuNhapBLL();
            bool kt = tmp.Insert(dto);
            if (kt)
                MessageBox.Show("Thêm thành công " + tenvc + " vào hoá đơn nhập " + mapn + " .");
            else
                MessageBox.Show("Thêm " + tenvc + " vào hoá đơn nhập " + mapn + " thất bại");
            LoadChiTietPhieuNhap();
            LoadVaccine();
        }

        private void btnXoaHDH_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string mapn = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
                string mavc = dgvNhapVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
                string tenvc = cboVaccineNhapCTHD.Text;

                DialogResult t = MessageBox.Show("Bạn có chắc chắn muốn xóa " + tenvc + " này trong Hoá đơn nhập " + mapn + " không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (t == DialogResult.Yes)
                {
                    ChiTietPhieuNhapBLL tmp = new ChiTietPhieuNhapBLL();
                    bool kt = tmp.Delete(mapn, mavc);

                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công " + tenvc + " trong hoá đơn nhập " + mapn + "");
                        LoadChiTietPhieuNhap();
                        LoadVaccine();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa " + tenvc + " trong hoá đơn nhập " + mapn + " do mã hoá đơn nhập này đang được tham chiếu.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Vaccine trong Hoá Đơn nhập để xóa.");
            }
        }

        private void btnUpdateHDN_Click(object sender, EventArgs e)
        {
            if (dgvNhapVaccine.SelectedRows.Count > 0)
            {
                string mapn = dgvNhapVaccine.SelectedRows[0].Cells["MaPN"].Value.ToString();
                string mavc = dgvNhapVaccine.SelectedRows[0].Cells["MaVC"].Value.ToString();
                string tenvc = cboVaccineNhapCTHD.Text;
                string soluong = txtSoLuongNhap.Text;
                string dongia = txtDonGiaNhap.Text;

                ChiTietPhieuNhapDTO tmp = new ChiTietPhieuNhapDTO(mapn, mavc, soluong, dongia);

                var t = MessageBox.Show("Bạn có chắc chắn muốn sửa " + tenvc + " trong hoá đơn nhập " + mapn + " này không?",
                                                     "Xác nhận sửa",
                                                     MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    ChiTietPhieuNhapBLL tmpdto = new ChiTietPhieuNhapBLL();
                    bool kt = tmpdto.Update(tmp);

                    if (kt)
                    {
                        MessageBox.Show("Sửa thành công  " + tenvc + " trong hoá đơn nhập " + mapn + " .");
                        LoadChiTietPhieuNhap();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa " + tenvc + " trong hoá đơn nhập " + mapn + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một Vaccine trong Hoá đơn để sửa.");
            }
        }

        private void btnThemVC_Click(object sender, EventArgs e)
        {
            frm_overlay frm = new frm_overlay(0);
            frm.ShowDialog();
            ReLoadFRM();
            if (VaccineDTO.CheckTB)
                ThongBao("Thêm thành công Vaccine vào danh sách ", 1);
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

        private void CapNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            startY = 860; pnlThongBao.Location = new Point(1640, 902);
            targetY = startY;
            timerHieuUng.Interval = 20;
            timerHieuUng.Tick += SlidePanel;
            timerHieuUng.Start();
        }
        private int startY;
        private int targetY;
        private const int ANIMATION_SPEED = 1;
        private void SlidePanel(object sender, EventArgs e)
        {
            if (pnlThongBao.Location.Y > targetY)
            {
                int newY = Math.Max(pnlThongBao.Location.Y - ANIMATION_SPEED, targetY);
                pnlThongBao.Location = new Point(pnlThongBao.Location.X, newY);
            }
            else
            {
                timerHieuUng.Stop();
            }
        }
        private void XoaVaccineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvVaccine.SelectedRows[0].Cells[1].Value.ToString();
            string ten = dgvVaccine.SelectedRows[0].Cells[2].Value.ToString();
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

        private void CapNhatToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            frm_overlay frm = new frm_overlay(2);
            frm.ShowDialog();
            if (VaccineDTO.CheckTB)
            {
                ThongBao("Thêm thành công Loại Vaccine vào danh sách ", 1);
                cboLoaiVC.DataSource = loaivcbll.GetData();
                cboLoaiVC.DisplayMember = "TenLoai";
                cboLoaiVC.ValueMember = "MaLoai";
            }
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            pnl_2_TaoPhieuNhap.Enabled = true;
        }
    }
}
