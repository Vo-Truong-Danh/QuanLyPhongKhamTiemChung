﻿using BLL;
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
    public partial class frmThemLoaiVaccine : Form
    {
        public frmThemLoaiVaccine()
        {
            InitializeComponent();
        }
        string malvc;
        public frmThemLoaiVaccine(string ma)
        {
            InitializeComponent();
            malvc = ma;
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        LoaiVaccineBLL lvcbll = new LoaiVaccineBLL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có chắc muốn lưu thông tin này không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                if (malvc == null)
                {
                    int sl = lvcbll.GetData().Rows.Count+1;
                    LoaiVaccineDTO lvcdto = new LoaiVaccineDTO()
                    {
                        Maloai = "LV"+sl.ToString("D3")+"",
                        Tenloai = txtTenLoaiVC.Text,
                        Somui = int.Parse(txtSoMui.Text),
                    };
                    lvcbll.Insert(lvcdto);
                    VaccineDTO.CheckTB = true;
                }
                else
                {
                    //VaccineDTO vcdto = new VaccineDTO()
                    //{
                    //    Mavc = mavcdto,
                    //    Maloai = cboLoaiVC.SelectedValue.ToString(),
                    //    Tenvc = txtTenVC.Text,
                    //    Ngaysx = DateTime.Parse(dteNSX.Value.ToString("yyyy-MM-dd")).ToString(),
                    //    Hansudung = DateTime.Parse(dteHSD.Value.ToString("yyyy-MM-dd")).ToString(),
                    //    Gia = int.Parse(txtGia.Text),
                    //    Xuatxu = txtXuatXu.Text,
                    //};
                    //vcbll.Update(vcdto);
                }
            }
            this.Close();

        }
    }
}