﻿using System;
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

        // 0  frm thêm vaccine
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
        }

    }
}