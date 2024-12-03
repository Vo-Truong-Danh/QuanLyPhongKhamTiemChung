using BLL;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
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
    public partial class frmHoaDon : Form
    {
        VaccineBLL vcBLL;
        HoaDonBLL hdBLL;
        LoaiVaccineBLL loaiVCBLL;
        NhanVienBLL nvBLL;
        BenhNhanBLL bnBLL;
        LichTiemBLL ltBLL;
        GhiNhanTiemChungBLL gntcBLL;
        public frmHoaDon()
        {
            InitializeComponent();
            vcBLL = new VaccineBLL();
            hdBLL = new HoaDonBLL();
            loaiVCBLL = new LoaiVaccineBLL();
            nvBLL = new NhanVienBLL();
            bnBLL = new BenhNhanBLL();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            lstvDSHD.LabelEdit = true; 
            lstvDSHD.FullRowSelect = true; 
            lstvDSHD.AfterLabelEdit += lstvDSHD_AfterLabelEdit; 
            LoadListHoaDon();
        }
        private void LoadListHoaDon()
        {
            lstvDSHD.Items.Clear();
            foreach (DataRow r in hdBLL.GetFullDataRows())
            {
                ListViewItem listItem = new ListViewItem(r["MaHD"].ToString());
                listItem.SubItems.Add(r["MaBN"].ToString());
                listItem.SubItems.Add(r["MaNV"].ToString());
                listItem.SubItems.Add(r["NgayLap"].ToString());
                listItem.SubItems.Add(r["TongTien"].ToString());
                lstvDSHD.Items.Add(listItem);
            }
        }
        
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDSHD.SelectedItems.Count > 0)
                {
                    string maHD = lstvDSHD.SelectedItems[0].SubItems[0].Text;

                    var confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn {maHD}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gntcBLL.DeleteByMaHD(maHD);
                        ltBLL.DeleteLByMaHD(maHD);
                        hdBLL.DeleteCTHD(maHD);
                        hdBLL.Delete(maHD);


                        MessageBox.Show("Hóa đơn đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchStr = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(searchStr) && searchStr != "Mã hóa đơn")
            {
                lstvDSHD.Items.Clear();
                foreach (DataRowView rowView in hdBLL.GetDataViewFromTimKiem(searchStr))
                {
                    DataRow row = rowView.Row;
                    ListViewItem item = new ListViewItem(new string[]
                    {
            row["MaHD"].ToString(),
            Convert.ToDateTime(row["NgayLap"]).ToString("yyyy-MM-dd"),
            row["MaBN"].ToString(),
            row["MaNV"].ToString(),
            row["TongTien"].ToString()
                    });
                    lstvDSHD.Items.Add(item);
                }
            }
            else
            {
                LoadListHoaDon();
            }

        }

        private void lstvDSHD_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void lstvDSHD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvDSHD.SelectedItems.Count > 0)
            {
                try
                {
                    string maHD = lstvDSHD.SelectedItems[0].SubItems[0].Text;

                    DataRow hoaDonRow = hdBLL.GetFullDataRows()
                                             .Cast<DataRow>()
                                             .FirstOrDefault(r => r["MaHD"].ToString() == maHD);

                    if (hoaDonRow != null)
                    {
                        lblMaHD.Text = $"Mã hóa đơn: {hoaDonRow["MaHD"]}";
                        lblNgayLap.Text = $"Ngày lập: {Convert.ToDateTime(hoaDonRow["NgayLap"]).ToString("dd/MM/yyyy")}";
                        txtTTBN.Text = hoaDonRow["MaBN"].ToString();
                        txtTTNV.Text = hoaDonRow["MaNV"].ToString();

                        lstvTTVC.Items.Clear();
                        foreach (DataRow cthdRow in hdBLL.GetAllCTHD(maHD))
                        {
                            ListViewItem item = new ListViewItem(new string[]
                            {
                        cthdRow["MaHD"].ToString(),
                        cthdRow["MaVC"].ToString(),
                        cthdRow["SoLuong"].ToString(),
                        cthdRow["DonGia"].ToString(),
                        Convert.ToDateTime(cthdRow["NgayTiem"]).ToString("dd/MM/yyyy")
                            });
                            lstvTTVC.Items.Add(item);
                        }
                        pnlTTHD.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pnlTTHD.Visible = false; 
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstvDSHD.Items.Clear();
            string maNV = ccbFilterNhanVien.SelectedItem?.ToString();
            DateTime ngayLap = dtpFilterNgayLap.Value;

            if (hdBLL.GetFullDataRows() != null)
            {
                IEnumerable<DataRow> filteredRows = hdBLL.GetFullDataRows().Cast<DataRow>();

                if (!string.IsNullOrEmpty(maNV))
                    filteredRows = filteredRows.Where(r => r["MaNV"].ToString() == maNV);

                if (ngayLap != null)
                    filteredRows = filteredRows.Where(r => Convert.ToDateTime(r["NgayLap"]).Date == ngayLap.Date);

                foreach (DataRow row in filteredRows)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
            row["MaHD"].ToString(),
            row["MaBN"].ToString(),
            row["MaNV"].ToString(),
            Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy"),
            row["TongTien"].ToString()
                    });
                    lstvDSHD.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            lstvDSHD.LabelEdit = true;
            MessageBox.Show("Bạn có thể chỉnh sửa trực tiếp trên ListView. Click vào ô để chỉnh sửa.");

        }

        private void lstvDSHD_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lstvDSHD_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label != null && e.Item >= 0)
            {
                ListViewItem editedItem = lstvDSHD.Items[e.Item];
                string maHD = editedItem.SubItems[0].Text;
                string columnName = ""; 
                object newValue = null;

                try
                {
                    switch (e.Item)
                    {
                        case 1: // Mã bệnh nhân
                            columnName = "MaBN";
                            newValue = e.Label;
                            break;
                        case 2: // Mã nhân viên
                            columnName = "MaNV";
                            newValue = e.Label;
                            break;
                        case 3: // Ngày lập
                            columnName = "NgayLap";
                            if (!DateTime.TryParse(e.Label, out DateTime ngayLap))
                                throw new Exception("Ngày lập không hợp lệ.");
                            newValue = ngayLap;
                            break;
                        case 4: // Tổng tiền
                            columnName = "TongTien";
                            if (!float.TryParse(e.Label, out float tongTien))
                                throw new Exception("Tổng tiền không hợp lệ.");
                            newValue = tongTien;
                            break;
                    }

                    HoaDonDTO hoaDonDTO = new HoaDonDTO(
                        maHD,
                        DateTime.Parse(editedItem.SubItems[3].Text),
                        editedItem.SubItems[1].Text,
                        editedItem.SubItems[2].Text,
                        float.Parse(editedItem.SubItems[4].Text)
                    );
                    hdBLL.Edit(hoaDonDTO);

                    MessageBox.Show("Hóa đơn đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
