﻿using System.Drawing;
using System.Windows.Forms;
namespace GUI
{
    partial class frmBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuuBN = new System.Windows.Forms.Button();
            this.errMaSo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKQTiemChung = new System.Windows.Forms.Button();
            this.btnThemMuiTemChoBN = new System.Windows.Forms.Button();
            this.btnThongTinChiTietBenhNhan = new System.Windows.Forms.Button();
            this.pnlThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.dtpNgaySinhinTTBN = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rdoNaminTTBN = new System.Windows.Forms.RadioButton();
            this.rdoNuinTTBN = new System.Windows.Forms.RadioButton();
            this.txtDiaChiinTTBN = new System.Windows.Forms.TextBox();
            this.txtSoDTinTTBN = new System.Windows.Forms.TextBox();
            this.txtHoTeninTTBN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlThemBN = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLoaiVaccine = new System.Windows.Forms.ComboBox();
            this.cboVaccine = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnThemMuiTiem = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpNgayHenTiem = new System.Windows.Forms.DateTimePicker();
            this.btnDieuChinhSoLuong = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaMũiTiêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemBenhNhan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dteNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvDSBN = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errMaSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoDienThoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlThongTinBenhNhan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlThemBN.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnXoaBN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaBN.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBN.Location = new System.Drawing.Point(379, 16);
            this.btnXoaBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(169, 39);
            this.btnXoaBN.TabIndex = 15;
            this.btnXoaBN.Text = "Xóa bệnh nhân";
            this.btnXoaBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBN.UseVisualStyleBackColor = false;
            this.btnXoaBN.Click += new System.EventHandler(this.btnXoaBN_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.Navy;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(890, 473);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(236, 48);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuuBN
            // 
            this.btnLuuBN.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLuuBN.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnLuuBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLuuBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuuBN.Image = global::GUI.Properties.Resources.add2;
            this.btnLuuBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuBN.Location = new System.Drawing.Point(20, 16);
            this.btnLuuBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuBN.Name = "btnLuuBN";
            this.btnLuuBN.Size = new System.Drawing.Size(155, 39);
            this.btnLuuBN.TabIndex = 13;
            this.btnLuuBN.Text = "Đăng kí tiêm";
            this.btnLuuBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuBN.UseVisualStyleBackColor = false;
            this.btnLuuBN.Click += new System.EventHandler(this.btnLuuBN_Click);
            // 
            // errMaSo
            // 
            this.errMaSo.ContainerControl = this;
            // 
            // errHoTen
            // 
            this.errHoTen.ContainerControl = this;
            // 
            // errDiaChi
            // 
            this.errDiaChi.ContainerControl = this;
            // 
            // errSoDienThoai
            // 
            this.errSoDienThoai.ContainerControl = this;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(1151, 15);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(356, 37);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.Text = "Tên bệnh nhân";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Gold;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.timkiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(994, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 39);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKQTiemChung);
            this.panel1.Controls.Add(this.btnThemMuiTemChoBN);
            this.panel1.Controls.Add(this.btnLuuBN);
            this.panel1.Controls.Add(this.btnXoaBN);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnThongTinChiTietBenhNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1886, 75);
            this.panel1.TabIndex = 18;
            // 
            // btnKQTiemChung
            // 
            this.btnKQTiemChung.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKQTiemChung.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnKQTiemChung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKQTiemChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnKQTiemChung.ForeColor = System.Drawing.Color.Azure;
            this.btnKQTiemChung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKQTiemChung.Location = new System.Drawing.Point(786, 16);
            this.btnKQTiemChung.Margin = new System.Windows.Forms.Padding(2);
            this.btnKQTiemChung.Name = "btnKQTiemChung";
            this.btnKQTiemChung.Size = new System.Drawing.Size(189, 39);
            this.btnKQTiemChung.TabIndex = 18;
            this.btnKQTiemChung.Text = "In kết quả tiêm chủng";
            this.btnKQTiemChung.UseVisualStyleBackColor = false;
            this.btnKQTiemChung.Click += new System.EventHandler(this.btnKQTiemChung_Click_1);
            // 
            // btnThemMuiTemChoBN
            // 
            this.btnThemMuiTemChoBN.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThemMuiTemChoBN.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnThemMuiTemChoBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMuiTemChoBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnThemMuiTemChoBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemMuiTemChoBN.Image = global::GUI.Properties.Resources.add2;
            this.btnThemMuiTemChoBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMuiTemChoBN.Location = new System.Drawing.Point(195, 16);
            this.btnThemMuiTemChoBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMuiTemChoBN.Name = "btnThemMuiTemChoBN";
            this.btnThemMuiTemChoBN.Size = new System.Drawing.Size(165, 39);
            this.btnThemMuiTemChoBN.TabIndex = 13;
            this.btnThemMuiTemChoBN.Text = "Thêm mũi tiêm";
            this.btnThemMuiTemChoBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMuiTemChoBN.UseVisualStyleBackColor = false;
            this.btnThemMuiTemChoBN.Click += new System.EventHandler(this.btnThemMuiTemChoBN_Click);
            // 
            // btnThongTinChiTietBenhNhan
            // 
            this.btnThongTinChiTietBenhNhan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThongTinChiTietBenhNhan.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnThongTinChiTietBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChiTietBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnThongTinChiTietBenhNhan.ForeColor = System.Drawing.Color.Azure;
            this.btnThongTinChiTietBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinChiTietBenhNhan.Location = new System.Drawing.Point(567, 16);
            this.btnThongTinChiTietBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinChiTietBenhNhan.Name = "btnThongTinChiTietBenhNhan";
            this.btnThongTinChiTietBenhNhan.Size = new System.Drawing.Size(200, 39);
            this.btnThongTinChiTietBenhNhan.TabIndex = 14;
            this.btnThongTinChiTietBenhNhan.Text = "Thông tin chi tiết";
            this.btnThongTinChiTietBenhNhan.UseVisualStyleBackColor = false;
            this.btnThongTinChiTietBenhNhan.Click += new System.EventHandler(this.btnThongTinChiTietBenhNhan_Click);
            // 
            // pnlThongTinBenhNhan
            // 
            this.pnlThongTinBenhNhan.Controls.Add(this.dtpNgaySinhinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.label8);
            this.pnlThongTinBenhNhan.Controls.Add(this.button1);
            this.pnlThongTinBenhNhan.Controls.Add(this.label9);
            this.pnlThongTinBenhNhan.Controls.Add(this.label11);
            this.pnlThongTinBenhNhan.Controls.Add(this.btnCapNhat);
            this.pnlThongTinBenhNhan.Controls.Add(this.rdoNaminTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.rdoNuinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtDiaChiinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtSoDTinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtHoTeninTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.label12);
            this.pnlThongTinBenhNhan.Controls.Add(this.label13);
            this.pnlThongTinBenhNhan.Controls.Add(this.label14);
            this.pnlThongTinBenhNhan.Controls.Add(this.label15);
            this.pnlThongTinBenhNhan.Controls.Add(this.label16);
            this.pnlThongTinBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlThongTinBenhNhan.Name = "pnlThongTinBenhNhan";
            this.pnlThongTinBenhNhan.Size = new System.Drawing.Size(1886, 648);
            this.pnlThongTinBenhNhan.TabIndex = 64;
            // 
            // dtpNgaySinhinTTBN
            // 
            this.dtpNgaySinhinTTBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhinTTBN.Location = new System.Drawing.Point(890, 218);
            this.dtpNgaySinhinTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinhinTTBN.Name = "dtpNgaySinhinTTBN";
            this.dtpNgaySinhinTTBN.Size = new System.Drawing.Size(242, 42);
            this.dtpNgaySinhinTTBN.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(583, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 54);
            this.label8.TabIndex = 79;
            this.label8.Text = "Thông tin bệnh nhân";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 78;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(258, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 36);
            this.label9.TabIndex = 76;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(258, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 36);
            this.label11.TabIndex = 75;
            this.label11.Text = "*";
            // 
            // rdoNaminTTBN
            // 
            this.rdoNaminTTBN.AutoSize = true;
            this.rdoNaminTTBN.Location = new System.Drawing.Point(968, 308);
            this.rdoNaminTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNaminTTBN.Name = "rdoNaminTTBN";
            this.rdoNaminTTBN.Size = new System.Drawing.Size(94, 40);
            this.rdoNaminTTBN.TabIndex = 74;
            this.rdoNaminTTBN.TabStop = true;
            this.rdoNaminTTBN.Text = "Nam";
            this.rdoNaminTTBN.UseVisualStyleBackColor = true;
            // 
            // rdoNuinTTBN
            // 
            this.rdoNuinTTBN.AutoSize = true;
            this.rdoNuinTTBN.Location = new System.Drawing.Point(1058, 308);
            this.rdoNuinTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNuinTTBN.Name = "rdoNuinTTBN";
            this.rdoNuinTTBN.Size = new System.Drawing.Size(74, 40);
            this.rdoNuinTTBN.TabIndex = 73;
            this.rdoNuinTTBN.TabStop = true;
            this.rdoNuinTTBN.Text = "Nữ";
            this.rdoNuinTTBN.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiinTTBN
            // 
            this.txtDiaChiinTTBN.Location = new System.Drawing.Point(378, 402);
            this.txtDiaChiinTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiinTTBN.Multiline = true;
            this.txtDiaChiinTTBN.Name = "txtDiaChiinTTBN";
            this.txtDiaChiinTTBN.Size = new System.Drawing.Size(754, 38);
            this.txtDiaChiinTTBN.TabIndex = 72;
            this.txtDiaChiinTTBN.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSoDTinTTBN
            // 
            this.txtSoDTinTTBN.Location = new System.Drawing.Point(472, 309);
            this.txtSoDTinTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDTinTTBN.Name = "txtSoDTinTTBN";
            this.txtSoDTinTTBN.Size = new System.Drawing.Size(332, 42);
            this.txtSoDTinTTBN.TabIndex = 71;
            this.txtSoDTinTTBN.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtHoTeninTTBN
            // 
            this.txtHoTeninTTBN.Location = new System.Drawing.Point(394, 218);
            this.txtHoTeninTTBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTeninTTBN.Name = "txtHoTeninTTBN";
            this.txtHoTeninTTBN.Size = new System.Drawing.Size(316, 42);
            this.txtHoTeninTTBN.TabIndex = 70;
            this.txtHoTeninTTBN.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(731, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 36);
            this.label12.TabIndex = 69;
            this.label12.Text = "Ngày sinh :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 312);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 36);
            this.label13.TabIndex = 68;
            this.label13.Text = "Số điện thoại :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 220);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 36);
            this.label14.TabIndex = 67;
            this.label14.Text = "Họ tên :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(848, 309);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 36);
            this.label15.TabIndex = 66;
            this.label15.Text = "Giới tính :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(276, 404);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 36);
            this.label16.TabIndex = 65;
            this.label16.Text = "Địa chỉ :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlThemBN);
            this.panel2.Controls.Add(this.lstvDSBN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1886, 896);
            this.panel2.TabIndex = 19;
            // 
            // pnlThemBN
            // 
            this.pnlThemBN.Controls.Add(this.pnlThongTinBenhNhan);
            this.pnlThemBN.Controls.Add(this.panel3);
            this.pnlThemBN.Controls.Add(this.dgvChiTietHoaDon);
            this.pnlThemBN.Controls.Add(this.label7);
            this.pnlThemBN.Controls.Add(this.btnDong);
            this.pnlThemBN.Controls.Add(this.btnThemBenhNhan);
            this.pnlThemBN.Controls.Add(this.label10);
            this.pnlThemBN.Controls.Add(this.label6);
            this.pnlThemBN.Controls.Add(this.dteNgaySinh);
            this.pnlThemBN.Controls.Add(this.rdoNam);
            this.pnlThemBN.Controls.Add(this.rdoNu);
            this.pnlThemBN.Controls.Add(this.txtDiaChi);
            this.pnlThemBN.Controls.Add(this.txtSoDT);
            this.pnlThemBN.Controls.Add(this.txtHoTen);
            this.pnlThemBN.Controls.Add(this.label5);
            this.pnlThemBN.Controls.Add(this.label4);
            this.pnlThemBN.Controls.Add(this.label3);
            this.pnlThemBN.Controls.Add(this.label2);
            this.pnlThemBN.Controls.Add(this.label1);
            this.pnlThemBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThemBN.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.pnlThemBN.Location = new System.Drawing.Point(0, 0);
            this.pnlThemBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlThemBN.Name = "pnlThemBN";
            this.pnlThemBN.Size = new System.Drawing.Size(1886, 896);
            this.pnlThemBN.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 648);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1886, 248);
            this.panel3.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.btnTaoHD);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(990, 244);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(199, 52);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(178, 42);
            this.txtMaHD.TabIndex = 67;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(199, 168);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(178, 42);
            this.txtTongTien.TabIndex = 67;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BackColor = System.Drawing.Color.White;
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(199, 110);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(178, 42);
            this.txtNgayLap.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 36);
            this.label19.TabIndex = 49;
            this.label19.Text = "Tổng tiền :";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTaoHD.FlatAppearance.BorderSize = 0;
            this.btnTaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnTaoHD.ForeColor = System.Drawing.Color.OldLace;
            this.btnTaoHD.Location = new System.Drawing.Point(400, 95);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(180, 70);
            this.btnTaoHD.TabIndex = 61;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 36);
            this.label18.TabIndex = 49;
            this.label18.Text = "Ngày lập :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 52);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 36);
            this.label17.TabIndex = 49;
            this.label17.Text = "Mã hóa đơn :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLoaiVaccine);
            this.groupBox2.Controls.Add(this.cboVaccine);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.btnThemMuiTiem);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.dtpNgayHenTiem);
            this.groupBox2.Controls.Add(this.btnDieuChinhSoLuong);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1008, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(878, 248);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn mũi tiêm";
            // 
            // cboLoaiVaccine
            // 
            this.cboLoaiVaccine.FormattingEnabled = true;
            this.cboLoaiVaccine.Location = new System.Drawing.Point(232, 48);
            this.cboLoaiVaccine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiVaccine.Name = "cboLoaiVaccine";
            this.cboLoaiVaccine.Size = new System.Drawing.Size(217, 44);
            this.cboLoaiVaccine.TabIndex = 65;
            this.cboLoaiVaccine.SelectionChangeCommitted += new System.EventHandler(this.cboLoaiVaccine_SelectionChangeCommitted);
            this.cboLoaiVaccine.SelectedValueChanged += new System.EventHandler(this.cboLoaiVaccine_SelectedValueChanged);
            // 
            // cboVaccine
            // 
            this.cboVaccine.FormattingEnabled = true;
            this.cboVaccine.Location = new System.Drawing.Point(232, 114);
            this.cboVaccine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboVaccine.Name = "cboVaccine";
            this.cboVaccine.Size = new System.Drawing.Size(217, 44);
            this.cboVaccine.TabIndex = 64;
            this.cboVaccine.SelectionChangeCommitted += new System.EventHandler(this.cboVaccine_SelectionChangeCommitted);
            this.cboVaccine.SelectedValueChanged += new System.EventHandler(this.cboVaccine_SelectedValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(456, 118);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(139, 36);
            this.label24.TabIndex = 49;
            this.label24.Text = "Ngày hẹn :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 188);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 36);
            this.label23.TabIndex = 49;
            this.label23.Text = "Đơn giá :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(489, 48);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 36);
            this.label22.TabIndex = 49;
            this.label22.Text = "Số lượng :";
            // 
            // btnThemMuiTiem
            // 
            this.btnThemMuiTiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemMuiTiem.Enabled = false;
            this.btnThemMuiTiem.FlatAppearance.BorderSize = 0;
            this.btnThemMuiTiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMuiTiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnThemMuiTiem.ForeColor = System.Drawing.Color.OldLace;
            this.btnThemMuiTiem.Location = new System.Drawing.Point(486, 184);
            this.btnThemMuiTiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemMuiTiem.Name = "btnThemMuiTiem";
            this.btnThemMuiTiem.Size = new System.Drawing.Size(335, 48);
            this.btnThemMuiTiem.TabIndex = 61;
            this.btnThemMuiTiem.Text = "Thêm";
            this.btnThemMuiTiem.UseVisualStyleBackColor = false;
            this.btnThemMuiTiem.Click += new System.EventHandler(this.btnThemMuiTiem_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 118);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 36);
            this.label21.TabIndex = 49;
            this.label21.Text = "Chọn vaccine";
            // 
            // dtpNgayHenTiem
            // 
            this.dtpNgayHenTiem.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHenTiem.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayHenTiem.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayHenTiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHenTiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHenTiem.Location = new System.Drawing.Point(596, 118);
            this.dtpNgayHenTiem.Margin = new System.Windows.Forms.Padding(117, 10, 117, 10);
            this.dtpNgayHenTiem.Name = "dtpNgayHenTiem";
            this.dtpNgayHenTiem.Size = new System.Drawing.Size(224, 39);
            this.dtpNgayHenTiem.TabIndex = 48;
            // 
            // btnDieuChinhSoLuong
            // 
            this.btnDieuChinhSoLuong.Enabled = false;
            this.btnDieuChinhSoLuong.Location = new System.Drawing.Point(704, 44);
            this.btnDieuChinhSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDieuChinhSoLuong.Name = "btnDieuChinhSoLuong";
            this.btnDieuChinhSoLuong.Size = new System.Drawing.Size(68, 48);
            this.btnDieuChinhSoLuong.TabIndex = 62;
            this.btnDieuChinhSoLuong.Text = "Sửa";
            this.btnDieuChinhSoLuong.UseVisualStyleBackColor = true;
            this.btnDieuChinhSoLuong.Click += new System.EventHandler(this.btnDieuChinhSoLuong_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(214, 36);
            this.label20.TabIndex = 49;
            this.label20.Text = "Chọn loại vaccine";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.White;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(232, 184);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(217, 42);
            this.txtDonGia.TabIndex = 55;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(627, 48);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(50, 42);
            this.txtSoLuong.TabIndex = 55;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.dgvChiTietHoaDon.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(472, 14);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersVisible = false;
            this.dgvChiTietHoaDon.RowHeadersWidth = 62;
            this.dgvChiTietHoaDon.RowTemplate.Height = 28;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1036, 630);
            this.dgvChiTietHoaDon.TabIndex = 66;
            this.dgvChiTietHoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellValueChanged);
            this.dgvChiTietHoaDon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvChiTietHoaDon_RowsAdded);
            this.dgvChiTietHoaDon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvChiTietHoaDon_RowsRemoved);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã Vaccine";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Vaccine";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loại";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày hẹn tiêm";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaMũiTiêmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 36);
            // 
            // xóaMũiTiêmToolStripMenuItem
            // 
            this.xóaMũiTiêmToolStripMenuItem.Name = "xóaMũiTiêmToolStripMenuItem";
            this.xóaMũiTiêmToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.xóaMũiTiêmToolStripMenuItem.Text = "Xóa mũi tiêm";
            this.xóaMũiTiêmToolStripMenuItem.Click += new System.EventHandler(this.xóaMũiTiêmToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(104, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 54);
            this.label7.TabIndex = 63;
            this.label7.Text = "Đăng ký tiêm";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(43, 500);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(93, 48);
            this.btnDong.TabIndex = 62;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnThemBenhNhan
            // 
            this.btnThemBenhNhan.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnThemBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnThemBenhNhan.ForeColor = System.Drawing.Color.OldLace;
            this.btnThemBenhNhan.Location = new System.Drawing.Point(151, 499);
            this.btnThemBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemBenhNhan.Name = "btnThemBenhNhan";
            this.btnThemBenhNhan.Size = new System.Drawing.Size(289, 48);
            this.btnThemBenhNhan.TabIndex = 61;
            this.btnThemBenhNhan.Text = "Thanh Toán Hoá Đơn";
            this.btnThemBenhNhan.UseVisualStyleBackColor = false;
            this.btnThemBenhNhan.Click += new System.EventHandler(this.btnThemBenhNhan_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 36);
            this.label10.TabIndex = 60;
            this.label10.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(18, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 36);
            this.label6.TabIndex = 59;
            this.label6.Text = "*";
            // 
            // dteNgaySinh
            // 
            this.dteNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteNgaySinh.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteNgaySinh.Location = new System.Drawing.Point(188, 431);
            this.dteNgaySinh.Margin = new System.Windows.Forms.Padding(132, 12, 132, 12);
            this.dteNgaySinh.Name = "dteNgaySinh";
            this.dteNgaySinh.Size = new System.Drawing.Size(252, 39);
            this.dteNgaySinh.TabIndex = 48;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(158, 362);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(94, 40);
            this.rdoNam.TabIndex = 58;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(248, 362);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(74, 40);
            this.rdoNu.TabIndex = 57;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(140, 289);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(300, 38);
            this.txtDiaChi.TabIndex = 56;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(216, 200);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(223, 42);
            this.txtSoDT.TabIndex = 55;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(154, 122);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(285, 42);
            this.txtHoTen.TabIndex = 54;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 50;
            this.label2.Text = "Giới tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "Địa chỉ :";
            // 
            // lstvDSBN
            // 
            this.lstvDSBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvDSBN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvDSBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDSBN.FullRowSelect = true;
            this.lstvDSBN.HideSelection = false;
            this.lstvDSBN.Location = new System.Drawing.Point(0, 0);
            this.lstvDSBN.Margin = new System.Windows.Forms.Padding(2);
            this.lstvDSBN.Name = "lstvDSBN";
            this.lstvDSBN.Size = new System.Drawing.Size(1885, 896);
            this.lstvDSBN.TabIndex = 17;
            this.lstvDSBN.UseCompatibleStateImageBehavior = false;
            this.lstvDSBN.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 420;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 350;
            // 
            // errSoLuong
            // 
            this.errSoLuong.ContainerControl = this;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1886, 971);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bệnh nhân";
            this.Load += new System.EventHandler(this.frmBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMaSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoDienThoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThongTinBenhNhan.ResumeLayout(false);
            this.pnlThongTinBenhNhan.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlThemBN.ResumeLayout(false);
            this.pnlThemBN.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnXoaBN;
        private Button btnCapNhat;
        private Button btnLuuBN;
        private ErrorProvider errMaSo;
        private ErrorProvider errHoTen;
        private ErrorProvider errDiaChi;
        private ErrorProvider errSoDienThoai;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Panel panel1;
        private Panel panel2;
        private ListView lstvDSBN;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnThongTinChiTietBenhNhan;
        private Panel pnlThemBN;
        private Label label7;
        private Button btnDong;
        private Button btnThemBenhNhan;
        private Label label10;
        private Label label6;
        private DateTimePicker dteNgaySinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private TextBox txtDiaChi;
        private TextBox txtSoDT;
        private TextBox txtHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlThongTinBenhNhan;
        private Label label8;
        private Button button1;
        private Label label9;
        private Label label11;
        private RadioButton rdoNaminTTBN;
        private RadioButton rdoNuinTTBN;
        private TextBox txtDiaChiinTTBN;
        private TextBox txtSoDTinTTBN;
        private TextBox txtHoTeninTTBN;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnKQTiemChung;
        private DateTimePicker dtpNgaySinhinTTBN;
        private ComboBox cboLoaiVaccine;
        private ComboBox cboVaccine;
        private DataGridView dgvChiTietHoaDon;
        private TextBox txtMaHD;
        private Button btnTaoHD;
        private TextBox txtNgayLap;
        private GroupBox groupBox1;
        private TextBox txtTongTien;
        private Label label19;
        private Label label18;
        private Label label17;
        private GroupBox groupBox2;
        private Label label22;
        private Label label21;
        private Button btnDieuChinhSoLuong;
        private Label label20;
        private TextBox txtSoLuong;
        private Label label23;
        private TextBox txtDonGia;
        private Panel panel3;
        private Button btnThemMuiTiem;
        private Button btnThemMuiTemChoBN;
        private Label label24;
        private DateTimePicker dtpNgayHenTiem;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaMũiTiêmToolStripMenuItem;
        private ErrorProvider errSoLuong;
        private ErrorProvider error;
    }
}