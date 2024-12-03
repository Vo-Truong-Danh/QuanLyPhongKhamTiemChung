using BLL;
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
    public partial class frmQuanLyLichTiem : Form
    {
        public frmQuanLyLichTiem()
        {
            InitializeComponent();
        }

        LichTiemBLL ltbll = new LichTiemBLL();
        VaccineBLL vcbll = new VaccineBLL();
        BenhNhanBLL bnbll = new BenhNhanBLL();

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
        private void frmQuanLyLichTiem_Load(object sender, EventArgs e)
        {
            dgvLichTiem.ColumnHeadersHeight = 60;
            dgvLichTiem.RowTemplate.Height = 60;
            BoGoc(pnlLoc, 50);
            BoGoc(pnlTimKiem, 50);  

            CreateDTGVLichTiem(ltbll.Load());
        }
        private void CreateDTGVLichTiem(DataTable dttb)
        {
            dgvLichTiem.Columns.Clear();  // Xóa tất cả các cột
            dgvLichTiem.Rows.Clear();     // Xóa tất cả các hàng
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn
            {
                Name = "STT",
                HeaderText = "STT"
            };
            DataGridViewTextBoxColumn malt = new DataGridViewTextBoxColumn
            {
                Name = "MaLT",
                HeaderText = "Mã Lịch Tiêm"
            };
            DataGridViewTextBoxColumn tenbn = new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                HeaderText = "Tên Bệnh Nhân"
            };
            DataGridViewTextBoxColumn mahd = new DataGridViewTextBoxColumn
            {
                Name = "MaHD",
                HeaderText = "Mã Hoá Đơn"
            };
            DataGridViewTextBoxColumn tenvc = new DataGridViewTextBoxColumn
            {
                Name = "TenVC",
                HeaderText = "Tên VACCINE"
            };
            DataGridViewTextBoxColumn ngaytiem = new DataGridViewTextBoxColumn
            {
                Name = "NgayHenTiem",
                HeaderText = "Ngày hẹn tiêm"
            };
            DataGridViewTextBoxColumn trangthai = new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                HeaderText = "Trạng Thái"
            };

            //Thêm vào dtg
            dgvLichTiem.Columns.Add(stt);
            dgvLichTiem.Columns.Add(malt);
            dgvLichTiem.Columns.Add(mahd);
            dgvLichTiem.Columns.Add(tenbn);
            dgvLichTiem.Columns.Add(tenvc);
            dgvLichTiem.Columns.Add(ngaytiem);
            dgvLichTiem.Columns.Add(trangthai);
            int tmp = 1;
            DataTable gan = vcbll.LayTTVC();
            DataTable dbbn = bnbll.GetData();
            if (dttb != null)
            {
                foreach (DataRow row in dttb.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        DataRow[] drvc = gan.Select("MaVC = '" + row["MaVC"] + "'");
                        DataRow[] drbn = dbbn.Select("MaBN = '" + row["MaBN"] + "'");
                        string TenBn = drbn[0]["HoTen"].ToString();
                        string TenVC = drvc[0]["TenVC"].ToString(); 
                        string ngayhen = "";
                        if (DateTime.TryParse(row["NgayHenTiem"]?.ToString(), out DateTime parsedDate))
                        {
                            ngayhen = parsedDate.ToString("dd-MM-yyyy");
                        }

                        dgvLichTiem.Rows.Add(tmp++, row["MaLT"], row["MaHD"], TenBn, TenVC, ngayhen, row["TrangThai"] );

                    }
                }
            }
            CustomSizeColLT();
        }
        private void CustomSizeColLT()
        {

            dgvLichTiem.Columns[0].Width = 60;
            dgvLichTiem.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichTiem.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLichTiem.Columns[1].Width = 170;

            dgvLichTiem.Columns[2].Width = 170;

            dgvLichTiem.Columns[3].Width = 315;

            dgvLichTiem.Columns[4].Width = 315;

            dgvLichTiem.Columns[5].Width = 175;

            dgvLichTiem.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvLichTiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        GhiNhanTiemChungBLL gntcbll = new GhiNhanTiemChungBLL();
        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            string ma = dgvLichTiem.SelectedRows[0].Cells[1].Value.ToString();
            DataRow[] dr = ltbll.GetData().Select("MaLT = '"+ma+"'");
            LichTiemDTO lt = new LichTiemDTO()
            {
                MaLT = ma,
                MaHD = dr[0]["MaHD"].ToString(),
                MaBN = dr[0]["MaBN"].ToString(),
                MaVC = dr[0]["MaVC"].ToString(),
                NgayHenTiem = DateTime.Now.ToString("yyyy-MM-dd"),
            };
            if (gntcbll.XacNhanTiem(lt))
            {
                MessageBox.Show("Đã xác nhận tiêm cho bênh nhân thành công ");
                CreateDTGVLichTiem(ltbll.Load());
            }
            else
            {
                MessageBox.Show("Lỗi khi xác nhận tiêm cho bênh nhân ");
            }

        }

        private void btnXacNhanTiem_Click(object sender, EventArgs e)
        {

            string ma = dgvLichTiem.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void cboTrangThai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] dr = ltbll.Load().Select();
            if (cboTrangThai.SelectedIndex == 1)
            {
                 dr = ltbll.Load().Select("TrangThai = 'Đã tiêm' ");
            }
            if (cboTrangThai.SelectedIndex == 2)
            {
                dr = ltbll.Load().Select("TrangThai = 'Chưa tiêm' ");
            }
            CreateDTGVLichTiem(dr.CopyToDataTable());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ndtimkiem = txtSearch.Text;
            DataRow[] drbn = bnbll.GetData().Select($"HoTen LIKE '%{ndtimkiem}%'");
            if(drbn.Length > 0)
                ndtimkiem = drbn[0]["MaBN"].ToString();
            DataRow[] dr = ltbll.Load().Select($"MaLT LIKE '%{txtSearch.Text}%' OR MaBN LIKE '%{ndtimkiem}%' OR MaHD LIKE '%{txtSearch.Text}%'");
            CreateDTGVLichTiem(dr.CopyToDataTable());
        }
    }
}
