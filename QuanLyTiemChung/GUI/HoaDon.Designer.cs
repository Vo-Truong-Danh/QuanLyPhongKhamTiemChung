namespace GUI
{
    partial class HoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelThemHoaDon = new System.Windows.Forms.GroupBox();
            this.cboLoaiVaccine = new System.Windows.Forms.ComboBox();
            this.cboVaccine = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnThemMuiTiem = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
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
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKQTiemChung = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLuuBN = new System.Windows.Forms.Button();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThongTinChiTietBenhNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelThemHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(18, 754);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1069, 286);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(265, 65);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(236, 31);
            this.txtMaHD.TabIndex = 67;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(265, 210);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(236, 31);
            this.txtTongTien.TabIndex = 67;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Location = new System.Drawing.Point(265, 138);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(236, 31);
            this.txtNgayLap.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 211);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 25);
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
            this.btnTaoHD.Location = new System.Drawing.Point(802, 196);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(240, 88);
            this.btnTaoHD.TabIndex = 61;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 139);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 25);
            this.label18.TabIndex = 49;
            this.label18.Text = "Ngày lập :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 65);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 25);
            this.label17.TabIndex = 49;
            this.label17.Text = "Mã hóa đơn :";
            // 
            // panelThemHoaDon
            // 
            this.panelThemHoaDon.Controls.Add(this.btnDong);
            this.panelThemHoaDon.Controls.Add(this.dgvChiTietHoaDon);
            this.panelThemHoaDon.Controls.Add(this.groupBox1);
            this.panelThemHoaDon.Controls.Add(this.cboLoaiVaccine);
            this.panelThemHoaDon.Controls.Add(this.cboVaccine);
            this.panelThemHoaDon.Controls.Add(this.label23);
            this.panelThemHoaDon.Controls.Add(this.label22);
            this.panelThemHoaDon.Controls.Add(this.btnThemMuiTiem);
            this.panelThemHoaDon.Controls.Add(this.label21);
            this.panelThemHoaDon.Controls.Add(this.btnDieuChinhSoLuong);
            this.panelThemHoaDon.Controls.Add(this.label20);
            this.panelThemHoaDon.Controls.Add(this.txtDonGia);
            this.panelThemHoaDon.Controls.Add(this.txtSoLuong);
            this.panelThemHoaDon.Location = new System.Drawing.Point(-5, 524);
            this.panelThemHoaDon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelThemHoaDon.Name = "panelThemHoaDon";
            this.panelThemHoaDon.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelThemHoaDon.Size = new System.Drawing.Size(1637, 376);
            this.panelThemHoaDon.TabIndex = 71;
            this.panelThemHoaDon.TabStop = false;
            this.panelThemHoaDon.Text = "Chọn mũi tiêm";
            // 
            // cboLoaiVaccine
            // 
            this.cboLoaiVaccine.FormattingEnabled = true;
            this.cboLoaiVaccine.Location = new System.Drawing.Point(309, 60);
            this.cboLoaiVaccine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboLoaiVaccine.Name = "cboLoaiVaccine";
            this.cboLoaiVaccine.Size = new System.Drawing.Size(288, 33);
            this.cboLoaiVaccine.TabIndex = 65;
            // 
            // cboVaccine
            // 
            this.cboVaccine.FormattingEnabled = true;
            this.cboVaccine.Location = new System.Drawing.Point(309, 140);
            this.cboVaccine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboVaccine.Name = "cboVaccine";
            this.cboVaccine.Size = new System.Drawing.Size(288, 33);
            this.cboVaccine.TabIndex = 64;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 235);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 25);
            this.label23.TabIndex = 49;
            this.label23.Text = "Đơn giá :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(652, 60);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 25);
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
            this.btnThemMuiTiem.Location = new System.Drawing.Point(704, 220);
            this.btnThemMuiTiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemMuiTiem.Name = "btnThemMuiTiem";
            this.btnThemMuiTiem.Size = new System.Drawing.Size(356, 60);
            this.btnThemMuiTiem.TabIndex = 61;
            this.btnThemMuiTiem.Text = "Thêm mũi tiêm";
            this.btnThemMuiTiem.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 148);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 25);
            this.label21.TabIndex = 49;
            this.label21.Text = "Chọn vaccine";
            // 
            // btnDieuChinhSoLuong
            // 
            this.btnDieuChinhSoLuong.Enabled = false;
            this.btnDieuChinhSoLuong.Location = new System.Drawing.Point(704, 131);
            this.btnDieuChinhSoLuong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDieuChinhSoLuong.Name = "btnDieuChinhSoLuong";
            this.btnDieuChinhSoLuong.Size = new System.Drawing.Size(356, 60);
            this.btnDieuChinhSoLuong.TabIndex = 62;
            this.btnDieuChinhSoLuong.Text = "Điều chỉnh số lượng";
            this.btnDieuChinhSoLuong.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 64);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 25);
            this.label20.TabIndex = 49;
            this.label20.Text = "Chọn loại vaccine";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(309, 230);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(288, 31);
            this.txtDonGia.TabIndex = 55;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(836, 60);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(65, 31);
            this.txtSoLuong.TabIndex = 55;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(8, 323);
            this.dgvChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 62;
            this.dgvChiTietHoaDon.RowTemplate.Height = 28;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1078, 417);
            this.dgvChiTietHoaDon.TabIndex = 71;
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
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1466, 29);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 76);
            this.btnDong.TabIndex = 72;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKQTiemChung);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnLuuBN);
            this.panel1.Controls.Add(this.btnXoaBN);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnThongTinChiTietBenhNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 94);
            this.panel1.TabIndex = 72;
            // 
            // btnKQTiemChung
            // 
            this.btnKQTiemChung.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKQTiemChung.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnKQTiemChung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKQTiemChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnKQTiemChung.ForeColor = System.Drawing.Color.Azure;
            this.btnKQTiemChung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKQTiemChung.Location = new System.Drawing.Point(975, 20);
            this.btnKQTiemChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKQTiemChung.Name = "btnKQTiemChung";
            this.btnKQTiemChung.Size = new System.Drawing.Size(252, 49);
            this.btnKQTiemChung.TabIndex = 18;
            this.btnKQTiemChung.Text = "In kết quả tiêm chủng";
            this.btnKQTiemChung.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = global::GUI.Properties.Resources.add2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(280, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thêm mũi tiêm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnLuuBN.Location = new System.Drawing.Point(27, 20);
            this.btnLuuBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuBN.Name = "btnLuuBN";
            this.btnLuuBN.Size = new System.Drawing.Size(207, 49);
            this.btnLuuBN.TabIndex = 13;
            this.btnLuuBN.Text = "Đăng kí tiêm";
            this.btnLuuBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuBN.UseVisualStyleBackColor = false;
            // 
            // btnXoaBN
            // 
            this.btnXoaBN.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnXoaBN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaBN.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBN.Location = new System.Drawing.Point(505, 20);
            this.btnXoaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(225, 49);
            this.btnXoaBN.TabIndex = 15;
            this.btnXoaBN.Text = "Xóa bệnh nhân";
            this.btnXoaBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBN.UseVisualStyleBackColor = false;
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
            this.btnTimKiem.Location = new System.Drawing.Point(1248, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(183, 49);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimKiem.Location = new System.Drawing.Point(1436, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(473, 47);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.Text = "Tên bệnh nhân";
            // 
            // btnThongTinChiTietBenhNhan
            // 
            this.btnThongTinChiTietBenhNhan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThongTinChiTietBenhNhan.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnThongTinChiTietBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChiTietBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnThongTinChiTietBenhNhan.ForeColor = System.Drawing.Color.Azure;
            this.btnThongTinChiTietBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinChiTietBenhNhan.Location = new System.Drawing.Point(757, 20);
            this.btnThongTinChiTietBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTinChiTietBenhNhan.Name = "btnThongTinChiTietBenhNhan";
            this.btnThongTinChiTietBenhNhan.Size = new System.Drawing.Size(196, 49);
            this.btnThongTinChiTietBenhNhan.TabIndex = 14;
            this.btnThongTinChiTietBenhNhan.Text = "Thông tin chi tiết";
            this.btnThongTinChiTietBenhNhan.UseVisualStyleBackColor = false;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1051);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelThemHoaDon);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelThemHoaDon.ResumeLayout(false);
            this.panelThemHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox panelThemHoaDon;
        private System.Windows.Forms.ComboBox cboLoaiVaccine;
        private System.Windows.Forms.ComboBox cboVaccine;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnThemMuiTiem;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDieuChinhSoLuong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKQTiemChung;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLuuBN;
        private System.Windows.Forms.Button btnXoaBN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThongTinChiTietBenhNhan;
    }
}