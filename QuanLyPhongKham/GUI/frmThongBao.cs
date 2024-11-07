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
    public partial class frmThongBao : Form
    {
        public frmThongBao()
        {
            InitializeComponent();
        }
        string ndtb = "";
        int tgtb = 2000;
        public frmThongBao(string nd , int tg)
        {
            InitializeComponent();
            ndtb = nd;
            tgtb = tg;
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
        private void frmThongBao_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            if (tgtb > 0)
            {
                lblnd.Text = ndtb;
                timer.Interval = tgtb;
                timer.Tick += (s, e) => { this.Close(); };
                timer.Start();
            }

        }
    }
}
