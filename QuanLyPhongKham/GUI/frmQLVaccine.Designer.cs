namespace GUI
{
    partial class frmQLVaccine
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVaccine));
            tctChinh = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            dgvVaccine = new DataGridView();
            panel2 = new Panel();
            pnlLocXuatXu = new Panel();
            lblXuatXu = new Label();
            cboXuatXu = new ComboBox();
            pnlLoc = new Panel();
            lblMaloaivctmp = new Label();
            cboLoaiVC = new ComboBox();
            pnlTimKiem = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            btnSearch = new Button();
            btnThemVC = new Button();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            panel6 = new Panel();
            groupBox6 = new GroupBox();
            btnChiTietNhap = new Button();
            btnHoaDonNhap = new Button();
            btnLoadNCC = new Button();
            groupBox5 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKỉem = new TextBox();
            grbChiTietNhapVC = new GroupBox();
            cboVaccineNhapCTHD = new ComboBox();
            label15 = new Label();
            btnUpdateHDN = new Button();
            btnXoaHDH = new Button();
            cboMaHoaDonNHap = new ComboBox();
            btnThemCTHDN = new Button();
            txtSoLuongNhap = new TextBox();
            label12 = new Label();
            txtDonGiaNhap = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            grbHDN = new GroupBox();
            btnUpdateHDNhap = new Button();
            label11 = new Label();
            btnXoaHDNhap = new Button();
            btnThemHoaDonNhapHangf = new Button();
            label10 = new Label();
            dtpNgayNhapHang = new DateTimePicker();
            cboNhaCungCap = new ComboBox();
            grbNhaCC = new GroupBox();
            btnCapNhatNCC = new Button();
            btnXoaNCC = new Button();
            btnThemNCC = new Button();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenNCCVC = new TextBox();
            dgvNhapVaccine = new DataGridView();
            imageList1 = new ImageList(components);
            btnLuu = new Button();
            tctChinh.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            panel2.SuspendLayout();
            pnlLocXuatXu.SuspendLayout();
            pnlLoc.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            grbChiTietNhapVC.SuspendLayout();
            panel5.SuspendLayout();
            grbHDN.SuspendLayout();
            grbNhaCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapVaccine).BeginInit();
            SuspendLayout();
            // 
            // tctChinh
            // 
            tctChinh.Controls.Add(tabPage1);
            tctChinh.Controls.Add(tabPage2);
            tctChinh.Dock = DockStyle.Fill;
            tctChinh.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctChinh.ImageList = imageList1;
            tctChinh.Location = new Point(0, 0);
            tctChinh.Name = "tctChinh";
            tctChinh.SelectedIndex = 0;
            tctChinh.Size = new Size(1396, 929);
            tctChinh.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.ImageIndex = 1;
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1388, 894);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kho Vaccine";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvVaccine);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 825);
            panel1.TabIndex = 6;
            // 
            // dgvVaccine
            // 
            dgvVaccine.AllowUserToAddRows = false;
            dgvVaccine.AllowUserToDeleteRows = false;
            dgvVaccine.AllowUserToResizeColumns = false;
            dgvVaccine.AllowUserToResizeRows = false;
            dgvVaccine.BackgroundColor = Color.White;
            dgvVaccine.BorderStyle = BorderStyle.None;
            dgvVaccine.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVaccine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaccine.ColumnHeadersHeight = 29;
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVaccine.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVaccine.Dock = DockStyle.Fill;
            dgvVaccine.Location = new Point(0, 0);
            dgvVaccine.Margin = new Padding(9, 3, 3, 3);
            dgvVaccine.MultiSelect = false;
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.RowHeadersVisible = false;
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaccine.Size = new Size(1382, 825);
            dgvVaccine.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(pnlLocXuatXu);
            panel2.Controls.Add(pnlLoc);
            panel2.Controls.Add(pnlTimKiem);
            panel2.Controls.Add(btnThemVC);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 63);
            panel2.TabIndex = 5;
            // 
            // pnlLocXuatXu
            // 
            pnlLocXuatXu.BackColor = Color.White;
            pnlLocXuatXu.Controls.Add(lblXuatXu);
            pnlLocXuatXu.Controls.Add(cboXuatXu);
            pnlLocXuatXu.Location = new Point(291, 8);
            pnlLocXuatXu.Name = "pnlLocXuatXu";
            pnlLocXuatXu.Size = new Size(227, 44);
            pnlLocXuatXu.TabIndex = 28;
            // 
            // lblXuatXu
            // 
            lblXuatXu.AutoSize = true;
            lblXuatXu.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXuatXu.Location = new Point(30, 11);
            lblXuatXu.Name = "lblXuatXu";
            lblXuatXu.Size = new Size(140, 22);
            lblXuatXu.TabIndex = 1;
            lblXuatXu.Text = "Xuất xứ Vaccine";
            // 
            // cboXuatXu
            // 
            cboXuatXu.BackColor = Color.White;
            cboXuatXu.FlatStyle = FlatStyle.Popup;
            cboXuatXu.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboXuatXu.FormattingEnabled = true;
            cboXuatXu.Items.AddRange(new object[] { "Nhóm Vaccine" });
            cboXuatXu.Location = new Point(26, 6);
            cboXuatXu.Name = "cboXuatXu";
            cboXuatXu.Size = new Size(183, 30);
            cboXuatXu.TabIndex = 0;
            cboXuatXu.Text = "Nhóm Vaccine";
            cboXuatXu.SelectionChangeCommitted += cboXuatXu_SelectionChangeCommitted;
            cboXuatXu.Click += cboXuatXu_Click;
            // 
            // pnlLoc
            // 
            pnlLoc.BackColor = Color.White;
            pnlLoc.Controls.Add(lblMaloaivctmp);
            pnlLoc.Controls.Add(cboLoaiVC);
            pnlLoc.Location = new Point(16, 8);
            pnlLoc.Name = "pnlLoc";
            pnlLoc.Size = new Size(269, 44);
            pnlLoc.TabIndex = 27;
            // 
            // lblMaloaivctmp
            // 
            lblMaloaivctmp.AutoSize = true;
            lblMaloaivctmp.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaloaivctmp.Location = new Point(28, 10);
            lblMaloaivctmp.Name = "lblMaloaivctmp";
            lblMaloaivctmp.Size = new Size(177, 22);
            lblMaloaivctmp.TabIndex = 1;
            lblMaloaivctmp.Text = "Mã Loại Vaccine       ";
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.BackColor = Color.White;
            cboLoaiVC.FlatStyle = FlatStyle.Popup;
            cboLoaiVC.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Items.AddRange(new object[] { "Nhóm Vaccine" });
            cboLoaiVC.Location = new Point(26, 6);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(218, 30);
            cboLoaiVC.TabIndex = 0;
            cboLoaiVC.Text = "Nhóm Vaccine";
            cboLoaiVC.SelectionChangeCommitted += cboLoaiVC_SelectionChangeCommitted;
            cboLoaiVC.Click += cboLoaiVC_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(txtSearch);
            pnlTimKiem.Controls.Add(pictureBox2);
            pnlTimKiem.Controls.Add(btnSearch);
            pnlTimKiem.Location = new Point(524, 8);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(344, 44);
            pnlTimKiem.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(27, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 21);
            txtSearch.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(287, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Location = new Point(287, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(36, 33);
            btnSearch.TabIndex = 25;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnThemVC
            // 
            btnThemVC.BackColor = Color.FromArgb(212, 246, 255);
            btnThemVC.Image = (Image)resources.GetObject("btnThemVC.Image");
            btnThemVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemVC.Location = new Point(888, 8);
            btnThemVC.Name = "btnThemVC";
            btnThemVC.Padding = new Padding(14, 5, 14, 5);
            btnThemVC.Size = new Size(237, 44);
            btnThemVC.TabIndex = 25;
            btnThemVC.Text = "Thêm Vaccine mới";
            btnThemVC.TextAlign = ContentAlignment.MiddleRight;
            btnThemVC.UseVisualStyleBackColor = false;
            btnThemVC.Click += btnThemVC_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(dgvNhapVaccine);
            tabPage2.ImageIndex = 0;
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1388, 894);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhập Vaccine";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1382, 503);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox6);
            panel6.Controls.Add(groupBox5);
            panel6.Controls.Add(grbChiTietNhapVC);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(840, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(542, 503);
            panel6.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnChiTietNhap);
            groupBox6.Controls.Add(btnHoaDonNhap);
            groupBox6.Controls.Add(btnLoadNCC);
            groupBox6.Location = new Point(0, 386);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(542, 123);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Load";
            // 
            // btnChiTietNhap
            // 
            btnChiTietNhap.BackColor = Color.Aquamarine;
            btnChiTietNhap.Image = Properties.Resources.load;
            btnChiTietNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTietNhap.Location = new Point(367, 24);
            btnChiTietNhap.Name = "btnChiTietNhap";
            btnChiTietNhap.Padding = new Padding(5, 0, 5, 2);
            btnChiTietNhap.Size = new Size(164, 43);
            btnChiTietNhap.TabIndex = 20;
            btnChiTietNhap.Text = "Chi Tiết Nhập";
            btnChiTietNhap.TextAlign = ContentAlignment.MiddleRight;
            btnChiTietNhap.UseVisualStyleBackColor = false;
            btnChiTietNhap.Click += btnChiTietNhap_Click;
            // 
            // btnHoaDonNhap
            // 
            btnHoaDonNhap.BackColor = Color.Aquamarine;
            btnHoaDonNhap.Image = Properties.Resources.load;
            btnHoaDonNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDonNhap.Location = new Point(198, 24);
            btnHoaDonNhap.Name = "btnHoaDonNhap";
            btnHoaDonNhap.Padding = new Padding(5, 0, 5, 2);
            btnHoaDonNhap.Size = new Size(168, 43);
            btnHoaDonNhap.TabIndex = 19;
            btnHoaDonNhap.Text = "Hoá Đơn Nhập";
            btnHoaDonNhap.TextAlign = ContentAlignment.MiddleRight;
            btnHoaDonNhap.UseVisualStyleBackColor = false;
            btnHoaDonNhap.Click += btnHoaDonNhap_Click;
            // 
            // btnLoadNCC
            // 
            btnLoadNCC.BackColor = Color.Aquamarine;
            btnLoadNCC.Image = Properties.Resources.load;
            btnLoadNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadNCC.Location = new Point(31, 24);
            btnLoadNCC.Name = "btnLoadNCC";
            btnLoadNCC.Padding = new Padding(5, 0, 5, 2);
            btnLoadNCC.Size = new Size(166, 43);
            btnLoadNCC.TabIndex = 18;
            btnLoadNCC.Text = "Nhà Cung Cấp";
            btnLoadNCC.TextAlign = ContentAlignment.MiddleRight;
            btnLoadNCC.UseVisualStyleBackColor = false;
            btnLoadNCC.Click += btnLoadNCC_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(txtTimKỉem);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(542, 73);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.MintCream;
            btnTimKiem.Image = Properties.Resources.timkiem;
            btnTimKiem.Location = new Point(429, 18);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(50, 49);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKỉem
            // 
            txtTimKỉem.BackColor = Color.LemonChiffon;
            txtTimKỉem.Location = new Point(70, 29);
            txtTimKỉem.Name = "txtTimKỉem";
            txtTimKỉem.Size = new Size(345, 28);
            txtTimKỉem.TabIndex = 18;
            // 
            // grbChiTietNhapVC
            // 
            grbChiTietNhapVC.Controls.Add(cboVaccineNhapCTHD);
            grbChiTietNhapVC.Controls.Add(label15);
            grbChiTietNhapVC.Controls.Add(btnUpdateHDN);
            grbChiTietNhapVC.Controls.Add(btnXoaHDH);
            grbChiTietNhapVC.Controls.Add(cboMaHoaDonNHap);
            grbChiTietNhapVC.Controls.Add(btnThemCTHDN);
            grbChiTietNhapVC.Controls.Add(txtSoLuongNhap);
            grbChiTietNhapVC.Controls.Add(label12);
            grbChiTietNhapVC.Controls.Add(txtDonGiaNhap);
            grbChiTietNhapVC.Controls.Add(label13);
            grbChiTietNhapVC.Controls.Add(label14);
            grbChiTietNhapVC.Location = new Point(0, 0);
            grbChiTietNhapVC.Name = "grbChiTietNhapVC";
            grbChiTietNhapVC.Size = new Size(542, 314);
            grbChiTietNhapVC.TabIndex = 0;
            grbChiTietNhapVC.TabStop = false;
            grbChiTietNhapVC.Text = "Chi tiết nhập hoá đơn";
            // 
            // cboVaccineNhapCTHD
            // 
            cboVaccineNhapCTHD.FormattingEnabled = true;
            cboVaccineNhapCTHD.Location = new Point(207, 94);
            cboVaccineNhapCTHD.Name = "cboVaccineNhapCTHD";
            cboVaccineNhapCTHD.Size = new Size(258, 30);
            cboVaccineNhapCTHD.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(46, 44);
            label15.Name = "label15";
            label15.Size = new Size(149, 22);
            label15.TabIndex = 13;
            label15.Text = "Mã hoá đơn nhập";
            // 
            // btnUpdateHDN
            // 
            btnUpdateHDN.BackColor = Color.Blue;
            btnUpdateHDN.ForeColor = Color.LightCyan;
            btnUpdateHDN.Image = Properties.Resources.sync_8468966;
            btnUpdateHDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateHDN.Location = new Point(340, 242);
            btnUpdateHDN.Name = "btnUpdateHDN";
            btnUpdateHDN.Padding = new Padding(5, 0, 5, 0);
            btnUpdateHDN.Size = new Size(191, 43);
            btnUpdateHDN.TabIndex = 17;
            btnUpdateHDN.Text = "Cập Nhật CTHD";
            btnUpdateHDN.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateHDN.UseVisualStyleBackColor = false;
            btnUpdateHDN.Click += btnUpdateHDN_Click;
            // 
            // btnXoaHDH
            // 
            btnXoaHDH.BackColor = Color.MistyRose;
            btnXoaHDH.Image = Properties.Resources.xoa;
            btnXoaHDH.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHDH.Location = new Point(210, 242);
            btnXoaHDH.Name = "btnXoaHDH";
            btnXoaHDH.Padding = new Padding(5, 0, 5, 2);
            btnXoaHDH.Size = new Size(126, 43);
            btnXoaHDH.TabIndex = 16;
            btnXoaHDH.Text = "Xoá HDN";
            btnXoaHDH.TextAlign = ContentAlignment.MiddleRight;
            btnXoaHDH.UseVisualStyleBackColor = false;
            btnXoaHDH.Click += btnXoaHDH_Click;
            // 
            // cboMaHoaDonNHap
            // 
            cboMaHoaDonNHap.FormattingEnabled = true;
            cboMaHoaDonNHap.Location = new Point(207, 40);
            cboMaHoaDonNHap.Name = "cboMaHoaDonNHap";
            cboMaHoaDonNHap.Size = new Size(258, 30);
            cboMaHoaDonNHap.TabIndex = 12;
            // 
            // btnThemCTHDN
            // 
            btnThemCTHDN.BackColor = Color.Aquamarine;
            btnThemCTHDN.Image = Properties.Resources.add2;
            btnThemCTHDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemCTHDN.Location = new Point(28, 242);
            btnThemCTHDN.Name = "btnThemCTHDN";
            btnThemCTHDN.Padding = new Padding(5, 0, 5, 2);
            btnThemCTHDN.Size = new Size(178, 43);
            btnThemCTHDN.TabIndex = 15;
            btnThemCTHDN.Text = "Thêm Vào HDN";
            btnThemCTHDN.TextAlign = ContentAlignment.MiddleRight;
            btnThemCTHDN.UseVisualStyleBackColor = false;
            btnThemCTHDN.Click += btnThemCTHDN_Click;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(207, 148);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(258, 28);
            txtSoLuongNhap.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 204);
            label12.Name = "label12";
            label12.Size = new Size(72, 22);
            label12.TabIndex = 14;
            label12.Text = "Đơn giá";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(207, 201);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(258, 28);
            txtDonGiaNhap.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 150);
            label13.Name = "label13";
            label13.Size = new Size(126, 22);
            label13.TabIndex = 13;
            label13.Text = "Số lượng nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 98);
            label14.Name = "label14";
            label14.Size = new Size(119, 22);
            label14.TabIndex = 12;
            label14.Text = "Vaccine nhập";
            // 
            // panel5
            // 
            panel5.Controls.Add(grbHDN);
            panel5.Controls.Add(grbNhaCC);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(585, 503);
            panel5.TabIndex = 0;
            // 
            // grbHDN
            // 
            grbHDN.Controls.Add(btnUpdateHDNhap);
            grbHDN.Controls.Add(label11);
            grbHDN.Controls.Add(btnXoaHDNhap);
            grbHDN.Controls.Add(btnThemHoaDonNhapHangf);
            grbHDN.Controls.Add(label10);
            grbHDN.Controls.Add(dtpNgayNhapHang);
            grbHDN.Controls.Add(cboNhaCungCap);
            grbHDN.Location = new Point(0, 230);
            grbHDN.Name = "grbHDN";
            grbHDN.Size = new Size(585, 280);
            grbHDN.TabIndex = 1;
            grbHDN.TabStop = false;
            grbHDN.Text = "Nhập Vaccine";
            // 
            // btnUpdateHDNhap
            // 
            btnUpdateHDNhap.BackColor = Color.Blue;
            btnUpdateHDNhap.ForeColor = Color.LightCyan;
            btnUpdateHDNhap.Image = Properties.Resources.sync_8468966;
            btnUpdateHDNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateHDNhap.Location = new Point(356, 168);
            btnUpdateHDNhap.Name = "btnUpdateHDNhap";
            btnUpdateHDNhap.Padding = new Padding(5, 0, 5, 0);
            btnUpdateHDNhap.Size = new Size(214, 52);
            btnUpdateHDNhap.TabIndex = 11;
            btnUpdateHDNhap.Text = "Cập Nhật Hoá Đơn";
            btnUpdateHDNhap.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateHDNhap.UseVisualStyleBackColor = false;
            btnUpdateHDNhap.Click += btnUpdateHDNhap_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 111);
            label11.Name = "label11";
            label11.Size = new Size(148, 22);
            label11.TabIndex = 3;
            label11.Text = "Ngày Nhập Hàng";
            // 
            // btnXoaHDNhap
            // 
            btnXoaHDNhap.BackColor = Color.MistyRose;
            btnXoaHDNhap.Image = Properties.Resources.xoa;
            btnXoaHDNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHDNhap.Location = new Point(182, 168);
            btnXoaHDNhap.Name = "btnXoaHDNhap";
            btnXoaHDNhap.Padding = new Padding(5, 0, 5, 2);
            btnXoaHDNhap.Size = new Size(164, 52);
            btnXoaHDNhap.TabIndex = 10;
            btnXoaHDNhap.Text = "Xoá Hoá Đơn";
            btnXoaHDNhap.TextAlign = ContentAlignment.MiddleRight;
            btnXoaHDNhap.UseVisualStyleBackColor = false;
            btnXoaHDNhap.Click += btnXoaHDNhap_Click;
            // 
            // btnThemHoaDonNhapHangf
            // 
            btnThemHoaDonNhapHangf.BackColor = Color.Aquamarine;
            btnThemHoaDonNhapHangf.Image = Properties.Resources.add2;
            btnThemHoaDonNhapHangf.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHoaDonNhapHangf.Location = new Point(7, 168);
            btnThemHoaDonNhapHangf.Name = "btnThemHoaDonNhapHangf";
            btnThemHoaDonNhapHangf.Padding = new Padding(5, 0, 5, 2);
            btnThemHoaDonNhapHangf.Size = new Size(164, 52);
            btnThemHoaDonNhapHangf.TabIndex = 9;
            btnThemHoaDonNhapHangf.Text = "Tạo Hoá Đơn";
            btnThemHoaDonNhapHangf.TextAlign = ContentAlignment.MiddleRight;
            btnThemHoaDonNhapHangf.UseVisualStyleBackColor = false;
            btnThemHoaDonNhapHangf.Click += btnThemHoaDonNhapHangf_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(50, 55);
            label10.Name = "label10";
            label10.Size = new Size(129, 22);
            label10.TabIndex = 2;
            label10.Text = "Nhà Cung Cấp";
            // 
            // dtpNgayNhapHang
            // 
            dtpNgayNhapHang.Location = new Point(200, 109);
            dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            dtpNgayNhapHang.Size = new Size(298, 28);
            dtpNgayNhapHang.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(200, 52);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(298, 30);
            cboNhaCungCap.TabIndex = 0;
            // 
            // grbNhaCC
            // 
            grbNhaCC.Controls.Add(btnCapNhatNCC);
            grbNhaCC.Controls.Add(btnXoaNCC);
            grbNhaCC.Controls.Add(btnThemNCC);
            grbNhaCC.Controls.Add(label9);
            grbNhaCC.Controls.Add(label6);
            grbNhaCC.Controls.Add(label2);
            grbNhaCC.Controls.Add(txtSoDienThoai);
            grbNhaCC.Controls.Add(txtDiaChi);
            grbNhaCC.Controls.Add(txtTenNCCVC);
            grbNhaCC.Location = new Point(0, 0);
            grbNhaCC.Name = "grbNhaCC";
            grbNhaCC.Size = new Size(585, 230);
            grbNhaCC.TabIndex = 0;
            grbNhaCC.TabStop = false;
            grbNhaCC.Text = "Nhà Cung Cấp Vaccine";
            // 
            // btnCapNhatNCC
            // 
            btnCapNhatNCC.BackColor = Color.Blue;
            btnCapNhatNCC.ForeColor = Color.LightCyan;
            btnCapNhatNCC.Image = Properties.Resources.sync_8468966;
            btnCapNhatNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhatNCC.Location = new Point(343, 170);
            btnCapNhatNCC.Name = "btnCapNhatNCC";
            btnCapNhatNCC.Padding = new Padding(5, 0, 5, 0);
            btnCapNhatNCC.Size = new Size(191, 43);
            btnCapNhatNCC.TabIndex = 8;
            btnCapNhatNCC.Text = "Cập Nhật TT NCC";
            btnCapNhatNCC.TextAlign = ContentAlignment.MiddleRight;
            btnCapNhatNCC.UseVisualStyleBackColor = false;
            btnCapNhatNCC.Click += btnCapNhatNCC_Click;
            // 
            // btnXoaNCC
            // 
            btnXoaNCC.BackColor = Color.MistyRose;
            btnXoaNCC.Image = Properties.Resources.xoa;
            btnXoaNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaNCC.Location = new Point(191, 170);
            btnXoaNCC.Name = "btnXoaNCC";
            btnXoaNCC.Padding = new Padding(5, 0, 5, 2);
            btnXoaNCC.Size = new Size(126, 43);
            btnXoaNCC.TabIndex = 7;
            btnXoaNCC.Text = "Xoá NCC";
            btnXoaNCC.TextAlign = ContentAlignment.MiddleRight;
            btnXoaNCC.UseVisualStyleBackColor = false;
            btnXoaNCC.Click += btnXoaNCC_Click;
            // 
            // btnThemNCC
            // 
            btnThemNCC.BackColor = Color.Aquamarine;
            btnThemNCC.Image = Properties.Resources.add2;
            btnThemNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemNCC.Location = new Point(39, 170);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Padding = new Padding(5, 0, 5, 2);
            btnThemNCC.Size = new Size(126, 43);
            btnThemNCC.TabIndex = 6;
            btnThemNCC.Text = "Tạo NCC";
            btnThemNCC.TextAlign = ContentAlignment.MiddleRight;
            btnThemNCC.UseVisualStyleBackColor = false;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 133);
            label9.Name = "label9";
            label9.Size = new Size(115, 22);
            label9.TabIndex = 5;
            label9.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 87);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 41);
            label2.Name = "label2";
            label2.Size = new Size(155, 22);
            label2.TabIndex = 3;
            label2.Text = "Tên nhà cung cấp";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(200, 130);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(325, 28);
            txtSoDienThoai.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(200, 84);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(325, 28);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTenNCCVC
            // 
            txtTenNCCVC.Location = new Point(200, 38);
            txtTenNCCVC.Name = "txtTenNCCVC";
            txtTenNCCVC.Size = new Size(325, 28);
            txtTenNCCVC.TabIndex = 0;
            // 
            // dgvNhapVaccine
            // 
            dgvNhapVaccine.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNhapVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNhapVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapVaccine.Dock = DockStyle.Bottom;
            dgvNhapVaccine.GridColor = Color.WhiteSmoke;
            dgvNhapVaccine.Location = new Point(3, 506);
            dgvNhapVaccine.MultiSelect = false;
            dgvNhapVaccine.Name = "dgvNhapVaccine";
            dgvNhapVaccine.RowHeadersWidth = 51;
            dgvNhapVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapVaccine.Size = new Size(1382, 385);
            dgvNhapVaccine.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "purchase_3310182.png");
            imageList1.Images.SetKeyName(1, "warehouse_7345857.png");
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(212, 246, 255);
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(1250, 8);
            btnLuu.Name = "btnLuu";
            btnLuu.Padding = new Padding(14, 5, 14, 5);
            btnLuu.Size = new Size(118, 44);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // frmQLVaccine
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 929);
            Controls.Add(tctChinh);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4);
            Name = "frmQLVaccine";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Quản Lý Vaccine";
            WindowState = FormWindowState.Maximized;
            Load += frmQLVaccine_Load;
            tctChinh.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).EndInit();
            panel2.ResumeLayout(false);
            pnlLocXuatXu.ResumeLayout(false);
            pnlLocXuatXu.PerformLayout();
            pnlLoc.ResumeLayout(false);
            pnlLoc.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            grbChiTietNhapVC.ResumeLayout(false);
            grbChiTietNhapVC.PerformLayout();
            panel5.ResumeLayout(false);
            grbHDN.ResumeLayout(false);
            grbHDN.PerformLayout();
            grbNhaCC.ResumeLayout(false);
            grbNhaCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhapVaccine).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tctChinh;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private Button btnSearch;
        private Button btnThemVC;
        private DataGridView dgvNhapVaccine;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private GroupBox grbHDN;
        private GroupBox grbChiTietNhapVC;
        private GroupBox groupBox5;
        private Label label11;
        private Label label10;
        private DateTimePicker dtpNgayNhapHang;
        private ComboBox cboNhaCungCap;
        private Button btnUpdateHDNhap;
        private Button btnXoaHDNhap;
        private Button btnThemHoaDonNhapHangf;
        private Button btnUpdateHDN;
        private Button btnXoaHDH;
        private Button btnThemCTHDN;
        private TextBox txtSoLuongNhap;
        private Label label12;
        private TextBox txtDonGiaNhap;
        private Label label13;
        private Label label14;
        private GroupBox groupBox6;
        private Label label15;
        private ComboBox cboMaHoaDonNHap;
        private TextBox txtTimKỉem;
        private Button btnTimKiem;
        private Button btnChiTietNhap;
        private Button btnHoaDonNhap;
        private Button btnLoadNCC;
        private ComboBox cboVaccineNhapCTHD;
        private GroupBox grbNhaCC;
        private Button btnCapNhatNCC;
        private Button btnXoaNCC;
        private Button btnThemNCC;
        private Label label9;
        private Label label6;
        private Label label2;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenNCCVC;
        private Panel pnlTimKiem;
        private ComboBox cboLoaiVC;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private Panel pnlLoc;
        private Panel panel1;
        private DataGridView dgvVaccine;
        private Label lblMaloaivctmp;
        private Label lblXuatXu;
        private Panel pnlLocXuatXu;
        private ComboBox cboXuatXu;
        private Button btnLuu;
    }
}