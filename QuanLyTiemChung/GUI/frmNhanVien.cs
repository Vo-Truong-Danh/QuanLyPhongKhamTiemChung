using BLL;
using CrystalDecisions.Shared.Json;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        TaiKhoanDTO TK;
        public frmNhanVien(TaiKhoanDTO tk)
        {
            TK = tk;
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
        private void BoGoc(Control tmp, int goc)
        {
            tmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tmp.Width, tmp.Height, goc, goc));
        }
        NhanVienBLL nvbll = new NhanVienBLL();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.ColumnHeadersHeight = 60;
            dgvNhanVien.RowTemplate.Height = 60;
            CreateDTGVLichTiem(nvbll.Load());
        }
        private void CreateDTGVLichTiem(DataTable dttb)
        {
            dgvNhanVien.Columns.Clear();  // Xóa tất cả các cột
            dgvNhanVien.Rows.Clear();     // Xóa tất cả các hàng
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            }; 
            DataGridViewTextBoxColumn malt1 = new DataGridViewTextBoxColumn
            {
                Name = "MaNV",
                HeaderText = "Mã NV"
            };
            DataGridViewTextBoxColumn malt = new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                HeaderText = "Họ Tên"
            };
            DataGridViewTextBoxColumn tenbn = new DataGridViewTextBoxColumn
            {
                Name = "GioiTinh",
                HeaderText = "Giới Tính"
            };
            DataGridViewTextBoxColumn mahd = new DataGridViewTextBoxColumn
            {
                Name = "ChucVu",
                HeaderText = "Chức Vụ"
            };
            DataGridViewTextBoxColumn tenvc = new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                HeaderText = "Địa Chỉ"
            };
            DataGridViewTextBoxColumn ngaytiem = new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                HeaderText = "Số Điện Thoại"
            };

            //Thêm vào dtg
            dgvNhanVien.Columns.Add(stt);
            dgvNhanVien.Columns.Add(malt1);
            dgvNhanVien.Columns.Add(malt);
            dgvNhanVien.Columns.Add(mahd);
            dgvNhanVien.Columns.Add(tenbn);
            dgvNhanVien.Columns.Add(tenvc);
            dgvNhanVien.Columns.Add(ngaytiem);
            int tmp = 1;
            if (dttb != null)
            {
                foreach (DataRow row in dttb.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        dgvNhanVien.Rows.Add(tmp++, row["MaNV"], row["HoTen"],  row["ChucVu"], row["GioiTinh"], row["DiaChi"], row["SoDienThoai"]);
                    }
                }
            }
            CustomSizeColLT();
        }
        private void CustomSizeColLT()
        {

            dgvNhanVien.Columns[0].Width = 60;
            dgvNhanVien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNhanVien.Columns[1].Width =100;

            dgvNhanVien.Columns[2].Width = 270;

            dgvNhanVien.Columns[3].Width = 160;

            dgvNhanVien.Columns[4].Width = 120;

            dgvNhanVien.Columns[5].Width = 475;

            dgvNhanVien.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ndtimkiem = txtSearch.Text;

            DataRow[] dr = nvbll.Load().Select(
                $"MaNV LIKE '%{ndtimkiem}%' OR " +
                $"HoTen LIKE '%{ndtimkiem}%' OR " +
                $"GioiTinh LIKE '%{ndtimkiem}%' OR " +
                $"ChucVu LIKE '%{ndtimkiem}%' OR " +
                $"DiaChi LIKE '%{ndtimkiem}%' OR " +
                $"SoDienThoai LIKE '%{ndtimkiem}%'"
            );
            if (dr.Length > 0)
            {
                CreateDTGVLichTiem(dr.CopyToDataTable());
            }
            else {
                MessageBox.Show("Không có nội dung tìm kiếm khớp !");
                CreateDTGVLichTiem(nvbll.Load());
            }
        }
    }
}
