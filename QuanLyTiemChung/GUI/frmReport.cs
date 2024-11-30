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
        public frmReport(int yc)
        {
            InitializeComponent();
            YeuCau = yc;

        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            if(YeuCau == 1)
            {
                crystalReportViewer1.ReportSource = crystalReportViewer1.ReportSource;
            }
        }
    }
}
