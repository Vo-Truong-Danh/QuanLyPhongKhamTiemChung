using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmQLVaccine : Form
    {
        public frmQLVaccine()
        {
            InitializeComponent();
        }

        public void LoadVaccine()
        {
            VaccineBLL vaccineBLL = new VaccineBLL();
            DataSet ds = vaccineBLL.LayTTVC();
            dgvVaccine.DataSource = ds.Tables[0];
            dgvVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaccine.AutoResizeColumns();

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

        }

        private void btnLoadTTVC_Click(object sender, EventArgs e)
        {
            LoadVaccine();
            LoadLoaiVaccineChoCBO();
            bingdingVC();
            grbLoaiVC.Enabled = false;
            grbTTVC.Enabled = true;
        }

        private void btnLoadTTLoaiVaccine_Click(object sender, EventArgs e)
        {
            LoadLoaiVaccine();
            bingdungLVC();
            grbLoaiVC.Enabled = true;
            grbTTVC.Enabled = false;
        }
    }
}
