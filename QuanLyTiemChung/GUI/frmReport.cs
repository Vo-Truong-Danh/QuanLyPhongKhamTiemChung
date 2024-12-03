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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        private int YeuCau;
        private string Ma;
        public frmReport(int yc , string ma)
        {
            InitializeComponent();
            YeuCau = yc;
            Ma = ma;
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            if(YeuCau == 1)//Yeu cau 1 in phiêu nhap
            {
                ReportPhieuNhap rp = new ReportPhieuNhap();
                rp.SetDatabaseLogon("sa", "123");
                rp.SetParameterValue("MaPN", Ma);
                crystalReportViewer1.ReportSource = rp;
            }
            if (YeuCau == 2)//Yeu cau 2 in lich su tiem chung
            {
                Rp_LichSuTiemChung rp = new Rp_LichSuTiemChung();
                rp.SetDatabaseLogon("sa", "123");
                rp.SetParameterValue("MaBN", Ma);
                crystalReportViewer1.ReportSource = rp;
            }
            if (YeuCau == 3)//Yeu cau 3 in hoa don
            {
                Rp_HoaDon rp = new Rp_HoaDon();
                rp.SetDatabaseLogon("sa", "123");
                rp.SetParameterValue("MaHD", Ma);
                crystalReportViewer1.ReportSource = rp;
            }
        }
    }
}
