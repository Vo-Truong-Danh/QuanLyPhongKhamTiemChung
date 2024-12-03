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
            LoadListHoaDon();
        }
        private void LoadListHoaDon()
        {
            lstvDSHD.Items.Clear();
            foreach (DataRow r in hdBLL.GetFullDataRows())
            {
                ListViewItem listItem = new ListViewItem(r["MaHD"].ToString());
                listItem.SubItems.Add(r["MaBN"].ToString());
                listItem.SubItems.Add(r["MaBN"].ToString());
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
            if (txtTimKiem.Text != "Mã hóa đơn")
            {
                lstvDSHD.Items.Clear();
                foreach (DataRowView rowView in hdBLL.GetDataViewFromTimKiem(txtTimKiem.Text))
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
            else if (string.IsNullOrEmpty(txtTimKiem.Text) || txtTimKiem.Text == "Mã hóa đơn")
            {
                LoadListHoaDon();
            }
        }

        private void lstvDSHD_ItemActivate(object sender, EventArgs e)
        {

        }

        private void lstvDSHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lstvDSHD.SelectedItems.Count > 0)
            //{
            //    string maHD = lstvDSHD.SelectedItems[0].SubItems[0].Text;

            //    var hoaDonRows = hdBLL.GetHDByMaBN(maHD);  
            //    if (hoaDonRows.Count > 0)
            //    {
            //        DataRow hoaDonRow = hoaDonRows[0]; 
            //        HoaDonDTO hoaDon = new HoaDonDTO
            //        {
            //            MaHD = hoaDonRow["MaHD"].ToString(),
            //            MaBN = hoaDonRow["MaBN"].ToString(),
            //            MaNV = hoaDonRow["MaNV"].ToString(),

            //        };

            //        txtTTNV.Text = hoaDon.MaNV;  
            //        txtTTBN.Text = hoaDon.MaBN;  


            //        var vaccineList = vcBLL.LoadDSVaccine(); 
            //        lstvTTVC.Items.Clear();  

            //        foreach (var vaccine in vaccineList)
            //        {
            //            if (vaccine.MaBN == hoaDon.MaBN) 
            //            {
            //                ListViewItem item = new ListViewItem(vaccine.Mavc);
            //                item.SubItems.Add(vaccine.Maloai);
            //                item.SubItems.Add(vaccine.Tenvc);
            //                item.SubItems.Add(vaccine.Xuatxu);
            //                item.SubItems.Add(vaccine.Hansudung);
            //                lstvTTVC.Items.Add(item);
            //            }
            //        }

            //        pnlTTHD.Visible = true; 
            //    }
            //}

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            LoadListHoaDon();
        }
    }
}
