﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim().Length > 0 && txtMatKhau.Text.Trim().Length > 0)
            {
                if (!tkBLL.CheckUserNameAndPassword(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()))
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                frmBenhNhan frmBenhNhan = new frmBenhNhan();
                frmBenhNhan.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
        }
    }
}