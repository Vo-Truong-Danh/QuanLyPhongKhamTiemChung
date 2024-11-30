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
        }
    }
}
