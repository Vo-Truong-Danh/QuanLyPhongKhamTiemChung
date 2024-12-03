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
    public partial class frmQuanLyLichTiem : Form
    {
        public frmQuanLyLichTiem()
        {
            InitializeComponent();
        }

        LichTiemBLL ltbll = new LichTiemBLL();
        VaccineBLL vcbll = new VaccineBLL();
        BenhNhanBLL bnbll = new BenhNhanBLL();  

        private void frmQuanLyLichTiem_Load(object sender, EventArgs e)
        {

            dgvLichTiem.ColumnHeadersHeight = 60;
            dgvLichTiem.RowTemplate.Height = 60;

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

                        dgvLichTiem.Rows.Add(tmp++, row["MaLT"], TenBn, TenVC, ngayhen, row["TrangThai"] );

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

            dgvLichTiem.Columns[1].Width = 150;
            dgvLichTiem.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichTiem.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLichTiem.Columns[2].Width = 320;

            dgvLichTiem.Columns[3].Width = 375;

            dgvLichTiem.Columns[4].Width = 375;
            dgvLichTiem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichTiem.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLichTiem.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
    }
}
