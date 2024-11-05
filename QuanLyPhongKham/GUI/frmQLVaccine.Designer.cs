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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVaccine));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvVaccine = new DataGridView();
            tctChinh = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlLoc = new Panel();
            cboLoaiVC = new ComboBox();
            pnlTimKiem = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            btnSearch = new Button();
            btnLoadTTLoaiVaccine = new Button();
            btnLoadTTVC = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            tctChinh.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // dgvVaccine
            // 
            dgvVaccine.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaccine.Dock = DockStyle.Fill;
            dgvVaccine.GridColor = Color.WhiteSmoke;
            dgvVaccine.Location = new Point(0, 0);
            dgvVaccine.MultiSelect = false;
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaccine.Size = new Size(1180, 934);
            dgvVaccine.TabIndex = 0;
            // 
            // tctChinh
            // 
            tctChinh.Controls.Add(tabPage1);
            tctChinh.Controls.Add(tabPage2);
            tctChinh.Dock = DockStyle.Fill;
            tctChinh.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tctChinh.ImageList = imageList1;
            tctChinh.Location = new Point(0, 0);
            tctChinh.Name = "tctChinh";
            tctChinh.SelectedIndex = 0;
            tctChinh.Size = new Size(1194, 1055);
            tctChinh.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.ImageIndex = 1;
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1186, 1018);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kho Vaccine";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvVaccine);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 934);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(pnlLoc);
            panel2.Controls.Add(pnlTimKiem);
            panel2.Controls.Add(btnLoadTTLoaiVaccine);
            panel2.Controls.Add(btnLoadTTVC);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 78);
            panel2.TabIndex = 5;
            // 
            // pnlLoc
            // 
            pnlLoc.BackColor = Color.White;
            pnlLoc.Controls.Add(cboLoaiVC);
            pnlLoc.Location = new Point(18, 9);
            pnlLoc.Name = "pnlLoc";
            pnlLoc.Size = new Size(296, 50);
            pnlLoc.TabIndex = 27;
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.BackColor = Color.White;
            cboLoaiVC.FlatStyle = FlatStyle.Popup;
            cboLoaiVC.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Location = new Point(20, 9);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(262, 30);
            cboLoaiVC.TabIndex = 0;
            cboLoaiVC.Text = "Nhóm Vaccine";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.Controls.Add(txtSearch);
            pnlTimKiem.Controls.Add(pictureBox2);
            pnlTimKiem.Controls.Add(btnSearch);
            pnlTimKiem.Location = new Point(339, 9);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(378, 50);
            pnlTimKiem.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(31, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(279, 24);
            txtSearch.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(316, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Location = new Point(316, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 37);
            btnSearch.TabIndex = 25;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoadTTLoaiVaccine
            // 
            btnLoadTTLoaiVaccine.BackColor = Color.Aquamarine;
            btnLoadTTLoaiVaccine.Image = Properties.Resources.load;
            btnLoadTTLoaiVaccine.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadTTLoaiVaccine.Location = new Point(1364, 13);
            btnLoadTTLoaiVaccine.Name = "btnLoadTTLoaiVaccine";
            btnLoadTTLoaiVaccine.Padding = new Padding(15, 5, 15, 5);
            btnLoadTTLoaiVaccine.Size = new Size(293, 59);
            btnLoadTTLoaiVaccine.TabIndex = 25;
            btnLoadTTLoaiVaccine.Text = "Thông Tin Loại Vaccine";
            btnLoadTTLoaiVaccine.TextAlign = ContentAlignment.MiddleRight;
            btnLoadTTLoaiVaccine.UseVisualStyleBackColor = false;
            btnLoadTTLoaiVaccine.Click += btnLoadTTLoaiVaccine_Click;
            // 
            // btnLoadTTVC
            // 
            btnLoadTTVC.BackColor = Color.Aquamarine;
            btnLoadTTVC.Image = Properties.Resources.load;
            btnLoadTTVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadTTVC.Location = new Point(982, 9);
            btnLoadTTVC.Name = "btnLoadTTVC";
            btnLoadTTVC.Padding = new Padding(15, 5, 35, 5);
            btnLoadTTVC.Size = new Size(293, 59);
            btnLoadTTVC.TabIndex = 24;
            btnLoadTTVC.Text = "Thông Tin Vaccine";
            btnLoadTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnLoadTTVC.UseVisualStyleBackColor = false;
            btnLoadTTVC.Click += btnLoadTTVC_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(dgvNhapVaccine);
            tabPage2.ImageIndex = 0;
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1186, 1018);
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
            panel4.Size = new Size(1180, 575);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox6);
            panel6.Controls.Add(groupBox5);
            panel6.Controls.Add(grbChiTietNhapVC);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(584, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(596, 575);
            panel6.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnChiTietNhap);
            groupBox6.Controls.Add(btnHoaDonNhap);
            groupBox6.Controls.Add(btnLoadNCC);
            groupBox6.Location = new Point(0, 439);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(596, 140);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Load";
            // 
            // btnChiTietNhap
            // 
            btnChiTietNhap.BackColor = Color.Aquamarine;
            btnChiTietNhap.Image = Properties.Resources.load;
            btnChiTietNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTietNhap.Location = new Point(404, 27);
            btnChiTietNhap.Name = "btnChiTietNhap";
            btnChiTietNhap.Padding = new Padding(5, 0, 5, 2);
            btnChiTietNhap.Size = new Size(180, 49);
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
            btnHoaDonNhap.Location = new Point(218, 27);
            btnHoaDonNhap.Name = "btnHoaDonNhap";
            btnHoaDonNhap.Padding = new Padding(5, 0, 5, 2);
            btnHoaDonNhap.Size = new Size(185, 49);
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
            btnLoadNCC.Location = new Point(34, 27);
            btnLoadNCC.Name = "btnLoadNCC";
            btnLoadNCC.Padding = new Padding(5, 0, 5, 2);
            btnLoadNCC.Size = new Size(183, 49);
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
            groupBox5.Size = new Size(596, 83);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.MintCream;
            btnTimKiem.Image = Properties.Resources.timkiem;
            btnTimKiem.Location = new Point(472, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(55, 55);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKỉem
            // 
            txtTimKỉem.BackColor = Color.LemonChiffon;
            txtTimKỉem.Location = new Point(77, 33);
            txtTimKỉem.Name = "txtTimKỉem";
            txtTimKỉem.Size = new Size(379, 31);
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
            grbChiTietNhapVC.Size = new Size(596, 356);
            grbChiTietNhapVC.TabIndex = 0;
            grbChiTietNhapVC.TabStop = false;
            grbChiTietNhapVC.Text = "Chi tiết nhập hoá đơn";
            // 
            // cboVaccineNhapCTHD
            // 
            cboVaccineNhapCTHD.FormattingEnabled = true;
            cboVaccineNhapCTHD.Location = new Point(228, 107);
            cboVaccineNhapCTHD.Name = "cboVaccineNhapCTHD";
            cboVaccineNhapCTHD.Size = new Size(283, 32);
            cboVaccineNhapCTHD.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(51, 50);
            label15.Name = "label15";
            label15.Size = new Size(166, 24);
            label15.TabIndex = 13;
            label15.Text = "Mã hoá đơn nhập";
            // 
            // btnUpdateHDN
            // 
            btnUpdateHDN.BackColor = Color.Blue;
            btnUpdateHDN.ForeColor = Color.LightCyan;
            btnUpdateHDN.Image = Properties.Resources.sync_8468966;
            btnUpdateHDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateHDN.Location = new Point(374, 275);
            btnUpdateHDN.Name = "btnUpdateHDN";
            btnUpdateHDN.Padding = new Padding(5, 0, 5, 0);
            btnUpdateHDN.Size = new Size(210, 49);
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
            btnXoaHDH.Location = new Point(231, 275);
            btnXoaHDH.Name = "btnXoaHDH";
            btnXoaHDH.Padding = new Padding(5, 0, 5, 2);
            btnXoaHDH.Size = new Size(139, 49);
            btnXoaHDH.TabIndex = 16;
            btnXoaHDH.Text = "Xoá HDN";
            btnXoaHDH.TextAlign = ContentAlignment.MiddleRight;
            btnXoaHDH.UseVisualStyleBackColor = false;
            btnXoaHDH.Click += btnXoaHDH_Click;
            // 
            // cboMaHoaDonNHap
            // 
            cboMaHoaDonNHap.FormattingEnabled = true;
            cboMaHoaDonNHap.Location = new Point(228, 46);
            cboMaHoaDonNHap.Name = "cboMaHoaDonNHap";
            cboMaHoaDonNHap.Size = new Size(283, 32);
            cboMaHoaDonNHap.TabIndex = 12;
            // 
            // btnThemCTHDN
            // 
            btnThemCTHDN.BackColor = Color.Aquamarine;
            btnThemCTHDN.Image = Properties.Resources.add2;
            btnThemCTHDN.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemCTHDN.Location = new Point(31, 275);
            btnThemCTHDN.Name = "btnThemCTHDN";
            btnThemCTHDN.Padding = new Padding(5, 0, 5, 2);
            btnThemCTHDN.Size = new Size(196, 49);
            btnThemCTHDN.TabIndex = 15;
            btnThemCTHDN.Text = "Thêm Vào HDN";
            btnThemCTHDN.TextAlign = ContentAlignment.MiddleRight;
            btnThemCTHDN.UseVisualStyleBackColor = false;
            btnThemCTHDN.Click += btnThemCTHDN_Click;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(228, 168);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(283, 31);
            txtSoLuongNhap.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 231);
            label12.Name = "label12";
            label12.Size = new Size(79, 24);
            label12.TabIndex = 14;
            label12.Text = "Đơn giá";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(228, 228);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(283, 31);
            txtDonGiaNhap.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(51, 171);
            label13.Name = "label13";
            label13.Size = new Size(139, 24);
            label13.TabIndex = 13;
            label13.Text = "Số lượng nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(51, 111);
            label14.Name = "label14";
            label14.Size = new Size(127, 24);
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
            panel5.Size = new Size(643, 575);
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
            grbHDN.Location = new Point(0, 261);
            grbHDN.Name = "grbHDN";
            grbHDN.Size = new Size(643, 318);
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
            btnUpdateHDNhap.Location = new Point(392, 191);
            btnUpdateHDNhap.Name = "btnUpdateHDNhap";
            btnUpdateHDNhap.Padding = new Padding(5, 0, 5, 0);
            btnUpdateHDNhap.Size = new Size(235, 59);
            btnUpdateHDNhap.TabIndex = 11;
            btnUpdateHDNhap.Text = "Cập Nhật Hoá Đơn";
            btnUpdateHDNhap.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateHDNhap.UseVisualStyleBackColor = false;
            btnUpdateHDNhap.Click += btnUpdateHDNhap_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 126);
            label11.Name = "label11";
            label11.Size = new Size(163, 24);
            label11.TabIndex = 3;
            label11.Text = "Ngày Nhập Hàng";
            // 
            // btnXoaHDNhap
            // 
            btnXoaHDNhap.BackColor = Color.MistyRose;
            btnXoaHDNhap.Image = Properties.Resources.xoa;
            btnXoaHDNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHDNhap.Location = new Point(200, 191);
            btnXoaHDNhap.Name = "btnXoaHDNhap";
            btnXoaHDNhap.Padding = new Padding(5, 0, 5, 2);
            btnXoaHDNhap.Size = new Size(180, 59);
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
            btnThemHoaDonNhapHangf.Location = new Point(8, 191);
            btnThemHoaDonNhapHangf.Name = "btnThemHoaDonNhapHangf";
            btnThemHoaDonNhapHangf.Padding = new Padding(5, 0, 5, 2);
            btnThemHoaDonNhapHangf.Size = new Size(180, 59);
            btnThemHoaDonNhapHangf.TabIndex = 9;
            btnThemHoaDonNhapHangf.Text = "Tạo Hoá Đơn";
            btnThemHoaDonNhapHangf.TextAlign = ContentAlignment.MiddleRight;
            btnThemHoaDonNhapHangf.UseVisualStyleBackColor = false;
            btnThemHoaDonNhapHangf.Click += btnThemHoaDonNhapHangf_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 63);
            label10.Name = "label10";
            label10.Size = new Size(138, 24);
            label10.TabIndex = 2;
            label10.Text = "Nhà Cung Cấp";
            // 
            // dtpNgayNhapHang
            // 
            dtpNgayNhapHang.Location = new Point(220, 124);
            dtpNgayNhapHang.Name = "dtpNgayNhapHang";
            dtpNgayNhapHang.Size = new Size(327, 31);
            dtpNgayNhapHang.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(220, 59);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(327, 32);
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
            grbNhaCC.Size = new Size(643, 261);
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
            btnCapNhatNCC.Location = new Point(377, 193);
            btnCapNhatNCC.Name = "btnCapNhatNCC";
            btnCapNhatNCC.Padding = new Padding(5, 0, 5, 0);
            btnCapNhatNCC.Size = new Size(210, 49);
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
            btnXoaNCC.Location = new Point(210, 193);
            btnXoaNCC.Name = "btnXoaNCC";
            btnXoaNCC.Padding = new Padding(5, 0, 5, 2);
            btnXoaNCC.Size = new Size(139, 49);
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
            btnThemNCC.Location = new Point(43, 193);
            btnThemNCC.Name = "btnThemNCC";
            btnThemNCC.Padding = new Padding(5, 0, 5, 2);
            btnThemNCC.Size = new Size(139, 49);
            btnThemNCC.TabIndex = 6;
            btnThemNCC.Text = "Tạo NCC";
            btnThemNCC.TextAlign = ContentAlignment.MiddleRight;
            btnThemNCC.UseVisualStyleBackColor = false;
            btnThemNCC.Click += btnThemNCC_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 151);
            label9.Name = "label9";
            label9.Size = new Size(128, 24);
            label9.TabIndex = 5;
            label9.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 99);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 47);
            label2.Name = "label2";
            label2.Size = new Size(166, 24);
            label2.TabIndex = 3;
            label2.Text = "Tên nhà cung cấp";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(220, 148);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(357, 31);
            txtSoDienThoai.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(220, 96);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(357, 31);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTenNCCVC
            // 
            txtTenNCCVC.Location = new Point(220, 44);
            txtTenNCCVC.Name = "txtTenNCCVC";
            txtTenNCCVC.Size = new Size(357, 31);
            txtTenNCCVC.TabIndex = 0;
            // 
            // dgvNhapVaccine
            // 
            dgvNhapVaccine.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvNhapVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvNhapVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapVaccine.Dock = DockStyle.Bottom;
            dgvNhapVaccine.GridColor = Color.WhiteSmoke;
            dgvNhapVaccine.Location = new Point(3, 578);
            dgvNhapVaccine.MultiSelect = false;
            dgvNhapVaccine.Name = "dgvNhapVaccine";
            dgvNhapVaccine.RowHeadersWidth = 51;
            dgvNhapVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapVaccine.Size = new Size(1180, 437);
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
            // frmQLVaccine
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 1055);
            Controls.Add(tctChinh);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(4);
            Name = "frmQLVaccine";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Quản Lý Vaccine";
            WindowState = FormWindowState.Maximized;
            Load += frmQLVaccine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).EndInit();
            tctChinh.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlLoc.ResumeLayout(false);
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

        private DataGridView dgvVaccine;
        private TabControl tctChinh;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private Button btnSearch;
        private Button btnLoadTTVC;
        private Button btnLoadTTLoaiVaccine;
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
        private Panel panel1;
        private TextBox txtSearch;
        private Panel pnlLoc;
    }
}