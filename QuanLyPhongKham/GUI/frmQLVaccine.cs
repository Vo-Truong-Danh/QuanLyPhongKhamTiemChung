using BLL;
using DTO;
using System.Data;

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
            dgvVaccine.DataSource = ds.Tables["Vaccine"];
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

        private void btnThemTTVC_Click(object sender, EventArgs e)
        {
            string maloai = cboLoaiVaccine.SelectedValue.ToString();
            string tenvc = txtTenVaccine.Text;
            string ngaysx = dtpNSX.Value.Date.ToString("yyyy/MM/dd");
            string hsd = dtpHSD.Value.Date.ToString("yyyy/MM/dd");
            int gia = int.Parse(txtGia.Text);
            VaccineDTO vc = new VaccineDTO(maloai, tenvc, ngaysx, hsd, gia);
            VaccineBLL vaccineBLL = new VaccineBLL();
            bool kt = vaccineBLL.Insert(vc);
            if (kt)
                MessageBox.Show("Thêm thành công Vaccine mới");
            else
                MessageBox.Show("Thêm Vaccine mới thất bại");
            LoadVaccine();
        }
    }
}
