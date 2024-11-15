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
    public partial class frm_overlay : Form
    {
        public frm_overlay()
        {
            InitializeComponent();
        }

        int? yeucaumo = null;
        public frm_overlay(int yeucua)
        {
            InitializeComponent();
            yeucaumo = yeucua;
        }
        string mavcsua;
        public frm_overlay(int yeucua,string ma)
        {
            InitializeComponent();
            yeucaumo = yeucua;
            mavcsua = ma;
        }
        // 0  frm thêm vaccine
        // 1 cap nhat vaccine
        // 2 frm them loai
        //3 capnhat mavc
        // 4 mo frmNCC
        //5 cap nhapNCC
        private void frm_overlay_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
            if (yeucaumo == 0)
            {
                frm_ThemVaccine  tmp = new frm_ThemVaccine();
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
            if (yeucaumo == 1)
            {
                frm_ThemVaccine tmp = new frm_ThemVaccine(mavcsua);
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
            if (yeucaumo == 2)
            {
                frmThemLoaiVaccine tmp = new frmThemLoaiVaccine();
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
            if (yeucaumo == 3)
            {
                frmThemLoaiVaccine tmp = new frmThemLoaiVaccine(mavcsua);
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
            if (yeucaumo == 4)
            {
                frmNCC tmp = new frmNCC();
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
            if (yeucaumo == 5)
            {
                frmNCC tmp = new frmNCC(mavcsua);
                tmp.TopMost = true;
                tmp.ShowDialog();
                this.Close();
            }
        }

    }
}
