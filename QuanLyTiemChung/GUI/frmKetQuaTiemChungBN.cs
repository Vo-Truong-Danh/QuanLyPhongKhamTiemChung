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
    public partial class frmKetQuaTiemChungBN : Form
    {
        public string maBN { get; set; }
        public frmKetQuaTiemChungBN()
        {
            InitializeComponent();
        }

        private void frmKetQuaTiemChungBN_Load(object sender, EventArgs e)
        {
            Rp_LichSuTiemChung rp = new Rp_LichSuTiemChung();
            rpViewerKetQuaTiemChungBN.ReportSource = rp;
        }
    }
}
