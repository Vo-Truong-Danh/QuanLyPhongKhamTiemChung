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
        int tgtb = 3000;
        int clor = 0; //0 là tb _ 1 xanh _ 2 là đỏ
        public frmThongBao(string nd , int tg,int cl)
        {
            InitializeComponent();
            ndtb = nd;
            tgtb = tg;
            clor = cl;
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
            if (clor == 0)
            {
                this.StartPosition = FormStartPosition.Manual;
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                this.Location = new Point(screenWidth - this.Width - 10, 10);
                lblnd.ForeColor = Color.Black;
            }
            if (clor == 1)
            {
                this.StartPosition = FormStartPosition.Manual;
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                this.Location = new Point(screenWidth - this.Width - 10, screenHeight - this.Height - 10);
                lblnd.ForeColor= Color.Green;
            }
            if(clor == 2)
            {
                this.StartPosition = FormStartPosition.Manual;
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                this.Location = new Point(screenWidth - this.Width - 10, screenHeight - this.Height - 10);
                lblnd.ForeColor = Color.Red;
            }
        }
    }
}
