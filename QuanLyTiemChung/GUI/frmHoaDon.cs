using BLL;
using CrystalDecisions.CrystalReports.ViewerObjectModel;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDSHD.SelectedItems.Count > 0)
                {
                    DialogResult r = MessageBox.Show("Bạn có chắc chắn xóa tất cả thông tin hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        bool xoaThanhCong = true;
                        foreach (ListViewItem item in lstvDSHD.SelectedItems)
                        {
                            string maHD = item.SubItems[0].Text; 
                            lstvDSHD.Items.Remove(item);

                         
                            bool result = hdBLL.Delete(maHD);

                            if (!result)
                            {
                                xoaThanhCong = false;
                                break;
                            }
                        }
                        if (xoaThanhCong)
                        {
                            MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadListHoaDon(); 
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một hóa đơn để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                using (SqlConnection conn = new SqlConnection("Data Source=LT-THINH\\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM_TIEMCHUNG;Persist Security Info=True;User ID=sa;Password=123"))
                {
                    conn.Open();

                    string folderPath = @"D:\BackupDatabase";
                    string filePath = Path.Combine(folderPath, "QUANLYPHONGKHAM_TIEMCHUNG.bak");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string backupQuery = $"BACKUP DATABASE QUANLYPHONGKHAM_TIEMCHUNG TO DISK = '{filePath}'";

                    using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Backup thành công! File được lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
