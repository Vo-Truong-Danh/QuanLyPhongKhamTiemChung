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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lstvDSHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlThemHoaDon = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBenhNhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.pnlThemHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemHoaDon);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 94);
            this.panel1.TabIndex = 72;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThemHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnThemHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemHoaDon.Image = global::GUI.Properties.Resources.add2;
            this.btnThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoaDon.Location = new System.Drawing.Point(27, 20);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(313, 49);
            this.btnThemHoaDon.TabIndex = 13;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
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
            // lstvDSHD
            // 
            this.lstvDSHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDSHD.FullRowSelect = true;
            this.lstvDSHD.HideSelection = false;
            this.lstvDSHD.Location = new System.Drawing.Point(0, 94);
            this.lstvDSHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvDSHD.Name = "lstvDSHD";
            this.lstvDSHD.Size = new System.Drawing.Size(1633, 1058);
            this.lstvDSHD.TabIndex = 73;
            this.lstvDSHD.UseCompatibleStateImageBehavior = false;
            this.lstvDSHD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã số";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã BN";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã NV";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày lập";
            this.columnHeader5.Width = 420;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng tiền";
            this.columnHeader6.Width = 350;
            // 
            // pnlThemHoaDon
            // 
            this.pnlThemHoaDon.Controls.Add(this.btnDong);
            this.pnlThemHoaDon.Controls.Add(this.dgvChiTietHoaDon);
            this.pnlThemHoaDon.Controls.Add(this.groupBox1);
            this.pnlThemHoaDon.Controls.Add(this.cboLoaiVaccine);
            this.pnlThemHoaDon.Controls.Add(this.cboVaccine);
            this.pnlThemHoaDon.Controls.Add(this.label23);
            this.pnlThemHoaDon.Controls.Add(this.label22);
            this.pnlThemHoaDon.Controls.Add(this.btnThemMuiTiem);
            this.pnlThemHoaDon.Controls.Add(this.label21);
            this.pnlThemHoaDon.Controls.Add(this.btnDieuChinhSoLuong);
            this.pnlThemHoaDon.Controls.Add(this.label20);
            this.pnlThemHoaDon.Controls.Add(this.txtDonGia);
            this.pnlThemHoaDon.Controls.Add(this.txtSoLuong);
            this.pnlThemHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThemHoaDon.Location = new System.Drawing.Point(0, 94);
            this.pnlThemHoaDon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlThemHoaDon.Name = "pnlThemHoaDon";
            this.pnlThemHoaDon.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlThemHoaDon.Size = new System.Drawing.Size(1633, 1058);
            this.pnlThemHoaDon.TabIndex = 74;
            this.pnlThemHoaDon.TabStop = false;
            this.pnlThemHoaDon.Text = "Chọn mũi tiêm";
            this.pnlThemHoaDon.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1436, 29);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 76);
            this.btnDong.TabIndex = 72;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
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
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1059, 417);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbBenhNhan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
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
            this.groupBox1.Size = new System.Drawing.Size(1065, 286);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbbBenhNhan
            // 
            this.cbbBenhNhan.FormattingEnabled = true;
            this.cbbBenhNhan.Location = new System.Drawing.Point(739, 111);
            this.cbbBenhNhan.Name = "cbbBenhNhan";
            this.cbbBenhNhan.Size = new System.Drawing.Size(266, 33);
            this.cbbBenhNhan.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Bệnh nhân:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(739, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 33);
            this.comboBox1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nhan viên:";
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
            this.btnTaoHD.Location = new System.Drawing.Point(765, 174);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(240, 88);
            this.btnTaoHD.TabIndex = 61;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
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
            // cboLoaiVaccine
            // 
            this.cboLoaiVaccine.FormattingEnabled = true;
            this.cboLoaiVaccine.Location = new System.Drawing.Point(309, 64);
            this.cboLoaiVaccine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboLoaiVaccine.Name = "cboLoaiVaccine";
            this.cboLoaiVaccine.Size = new System.Drawing.Size(288, 33);
            this.cboLoaiVaccine.TabIndex = 65;
            this.cboLoaiVaccine.SelectedIndexChanged += new System.EventHandler(this.cboLoaiVaccine_SelectedIndexChanged);
            // 
            // cboVaccine
            // 
            this.cboVaccine.FormattingEnabled = true;
            this.cboVaccine.Location = new System.Drawing.Point(309, 140);
            this.cboVaccine.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboVaccine.Name = "cboVaccine";
            this.cboVaccine.Size = new System.Drawing.Size(288, 33);
            this.cboVaccine.TabIndex = 64;
            this.cboVaccine.SelectedIndexChanged += new System.EventHandler(this.cboVaccine_SelectedIndexChanged);
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
            this.btnThemMuiTiem.Click += new System.EventHandler(this.btnThemMuiTiem_Click);
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
            this.btnDieuChinhSoLuong.Click += new System.EventHandler(this.btnDieuChinhSoLuong_Click);
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
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1152);
            this.Controls.Add(this.pnlThemHoaDon);
            this.Controls.Add(this.lstvDSHD);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThemHoaDon.ResumeLayout(false);
            this.pnlThemHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lstvDSHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox pnlThemHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.ComboBox cbbBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}