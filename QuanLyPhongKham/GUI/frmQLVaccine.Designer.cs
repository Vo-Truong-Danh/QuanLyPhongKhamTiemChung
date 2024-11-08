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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVaccine));
            tctChinh = new TabControl();
            tabKhoVaccine = new TabPage();
            panel1 = new Panel();
            pnlThongBao = new Panel();
            pnlTb = new Panel();
            pictureBox1 = new PictureBox();
            lblndtb = new Label();
            dgvVaccine = new DataGridView();
            cntXoaSua = new ContextMenuStrip(components);
            XoaVaccineToolStripMenuItem = new ToolStripMenuItem();
            CapNhatToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            btnThemLoai = new Button();
            btnLuu = new Button();
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
            tabNhapVC = new TabPage();
            pnl2_VungThemNVC = new Panel();
            pnl_2_TaoPhieuNhap = new Panel();
            pnl2_PN = new GroupBox();
            pnlTongTien = new Panel();
            label3 = new Label();
            txtTongTien = new TextBox();
            label2 = new Label();
            pnl2_ngaynhap = new Panel();
            dteNgayNhap = new DateTimePicker();
            label5 = new Label();
            pnl2_ncc = new Panel();
            cboNCC = new ComboBox();
            label4 = new Label();
            pnl2_maphieu = new Panel();
            txtMaPhieuN = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnLuuPhieuNhap = new Button();
            btnTaoPhieuNhap = new Button();
            grb2_ChiTietPhieuNhap = new GroupBox();
            pnlSoLuong = new Panel();
            txtSolUong = new TextBox();
            txtSoLuongCTPN = new Label();
            pnlThanhTien = new Panel();
            label6 = new Label();
            txtThanhTien = new TextBox();
            dsd = new Label();
            btnCapNhatCTPN = new Button();
            btnXoaCTPN = new Button();
            btnThemCTPN = new Button();
            pnl2dongia = new Panel();
            txtDonGiaCTPN = new TextBox();
            label7 = new Label();
            pnl2tenvaccine = new Panel();
            txtTenVCCTPN = new TextBox();
            label16 = new Label();
            grb2_ShowVCDuocChon = new GroupBox();
            dtgDanhSachVCduocChon = new DataGridView();
            grbDSVC = new GroupBox();
            pnlThongBaoTab2 = new Panel();
            pnlThongBaotab2s = new Panel();
            txtndthongbaotab2 = new Label();
            pictureBox3 = new PictureBox();
            dtgCTPN = new DataGridView();
            imageList1 = new ImageList(components);
            timerTB = new System.Windows.Forms.Timer(components);
            timerHieuUng = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolTip = new ToolTip(components);
            timerTB_Tab2 = new System.Windows.Forms.Timer(components);
            tctChinh.SuspendLayout();
            tabKhoVaccine.SuspendLayout();
            panel1.SuspendLayout();
            pnlThongBao.SuspendLayout();
            pnlTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            cntXoaSua.SuspendLayout();
            panel2.SuspendLayout();
            pnlLocXuatXu.SuspendLayout();
            pnlLoc.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabNhapVC.SuspendLayout();
            pnl2_VungThemNVC.SuspendLayout();
            pnl_2_TaoPhieuNhap.SuspendLayout();
            pnl2_PN.SuspendLayout();
            pnlTongTien.SuspendLayout();
            pnl2_ngaynhap.SuspendLayout();
            pnl2_ncc.SuspendLayout();
            pnl2_maphieu.SuspendLayout();
            panel3.SuspendLayout();
            grb2_ChiTietPhieuNhap.SuspendLayout();
            pnlSoLuong.SuspendLayout();
            pnlThanhTien.SuspendLayout();
            pnl2dongia.SuspendLayout();
            pnl2tenvaccine.SuspendLayout();
            grb2_ShowVCDuocChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachVCduocChon).BeginInit();
            grbDSVC.SuspendLayout();
            pnlThongBaoTab2.SuspendLayout();
            pnlThongBaotab2s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgCTPN).BeginInit();
            SuspendLayout();
            // 
            // tctChinh
            // 
            tctChinh.Controls.Add(tabKhoVaccine);
            tctChinh.Controls.Add(tabNhapVC);
            tctChinh.Dock = DockStyle.Fill;
            tctChinh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctChinh.ImageList = imageList1;
            tctChinh.ItemSize = new Size(135, 50);
            tctChinh.Location = new Point(0, 0);
            tctChinh.Margin = new Padding(0);
            tctChinh.Name = "tctChinh";
            tctChinh.Padding = new Point(25, 5);
            tctChinh.SelectedIndex = 0;
            tctChinh.Size = new Size(1898, 1055);
            tctChinh.SizeMode = TabSizeMode.FillToRight;
            tctChinh.TabIndex = 1;
            // 
            // tabKhoVaccine
            // 
            tabKhoVaccine.BackColor = Color.Transparent;
            tabKhoVaccine.Controls.Add(panel1);
            tabKhoVaccine.Controls.Add(panel2);
            tabKhoVaccine.ImageKey = "khovc.png";
            tabKhoVaccine.ImeMode = ImeMode.NoControl;
            tabKhoVaccine.Location = new Point(4, 54);
            tabKhoVaccine.Name = "tabKhoVaccine";
            tabKhoVaccine.Padding = new Padding(3);
            tabKhoVaccine.Size = new Size(1890, 997);
            tabKhoVaccine.TabIndex = 0;
            tabKhoVaccine.Text = "Kho Vaccine";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlThongBao);
            panel1.Controls.Add(dgvVaccine);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1884, 921);
            panel1.TabIndex = 6;
            // 
            // pnlThongBao
            // 
            pnlThongBao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlThongBao.BackColor = Color.DimGray;
            pnlThongBao.Controls.Add(pnlTb);
            pnlThongBao.Location = new Point(1315, 835);
            pnlThongBao.Name = "pnlThongBao";
            pnlThongBao.Size = new Size(555, 72);
            pnlThongBao.TabIndex = 2;
            pnlThongBao.Visible = false;
            // 
            // pnlTb
            // 
            pnlTb.BackColor = Color.White;
            pnlTb.Controls.Add(pictureBox1);
            pnlTb.Controls.Add(lblndtb);
            pnlTb.Location = new Point(2, 2);
            pnlTb.Margin = new Padding(4, 3, 4, 3);
            pnlTb.Name = "pnlTb";
            pnlTb.Size = new Size(550, 68);
            pnlTb.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.notification_16903647;
            pictureBox1.Location = new Point(14, 6);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblndtb
            // 
            lblndtb.AutoSize = true;
            lblndtb.Location = new Point(91, 22);
            lblndtb.Margin = new Padding(4, 0, 4, 0);
            lblndtb.Name = "lblndtb";
            lblndtb.Size = new Size(107, 25);
            lblndtb.TabIndex = 0;
            lblndtb.Text = "Thông báo";
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaccine.ColumnHeadersHeight = 29;
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVaccine.ContextMenuStrip = cntXoaSua;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVaccine.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVaccine.Dock = DockStyle.Fill;
            dgvVaccine.Location = new Point(0, 0);
            dgvVaccine.Margin = new Padding(0);
            dgvVaccine.MultiSelect = false;
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.RowHeadersVisible = false;
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaccine.Size = new Size(1884, 921);
            dgvVaccine.TabIndex = 0;
            // 
            // cntXoaSua
            // 
            cntXoaSua.ImageScalingSize = new Size(20, 20);
            cntXoaSua.Items.AddRange(new ToolStripItem[] { XoaVaccineToolStripMenuItem, CapNhatToolStripMenuItem });
            cntXoaSua.Name = "contextMenuStrip1";
            cntXoaSua.Size = new Size(159, 52);
            // 
            // XoaVaccineToolStripMenuItem
            // 
            XoaVaccineToolStripMenuItem.Name = "XoaVaccineToolStripMenuItem";
            XoaVaccineToolStripMenuItem.Size = new Size(158, 24);
            XoaVaccineToolStripMenuItem.Text = "Xoá Vaccine";
            XoaVaccineToolStripMenuItem.Click += XoaVaccineToolStripMenuItem_Click;
            // 
            // CapNhatToolStripMenuItem
            // 
            CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            CapNhatToolStripMenuItem.Size = new Size(158, 24);
            CapNhatToolStripMenuItem.Text = "Cập nhật";
            CapNhatToolStripMenuItem.Click += CapNhatToolStripMenuItem_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnThemLoai);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(pnlLocXuatXu);
            panel2.Controls.Add(pnlLoc);
            panel2.Controls.Add(pnlTimKiem);
            panel2.Controls.Add(btnThemVC);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1884, 70);
            panel2.TabIndex = 5;
            // 
            // btnThemLoai
            // 
            btnThemLoai.BackColor = Color.FromArgb(93, 245, 199);
            btnThemLoai.Image = Properties.Resources.load;
            btnThemLoai.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemLoai.Location = new Point(1077, 8);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Padding = new Padding(14, 5, 14, 5);
            btnThemLoai.Size = new Size(231, 54);
            btnThemLoai.TabIndex = 30;
            btnThemLoai.Text = "Loại Vaccine mới";
            btnThemLoai.TextAlign = ContentAlignment.MiddleRight;
            btnThemLoai.UseVisualStyleBackColor = false;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 215, 102);
            btnLuu.Image = Properties.Resources.save;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(1315, 8);
            btnLuu.Name = "btnLuu";
            btnLuu.Padding = new Padding(14, 5, 14, 5);
            btnLuu.Size = new Size(118, 54);
            btnLuu.TabIndex = 29;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // pnlLocXuatXu
            // 
            pnlLocXuatXu.BackColor = Color.White;
            pnlLocXuatXu.Controls.Add(lblXuatXu);
            pnlLocXuatXu.Controls.Add(cboXuatXu);
            pnlLocXuatXu.Location = new Point(291, 8);
            pnlLocXuatXu.Name = "pnlLocXuatXu";
            pnlLocXuatXu.Size = new Size(227, 54);
            pnlLocXuatXu.TabIndex = 28;
            // 
            // lblXuatXu
            // 
            lblXuatXu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXuatXu.Location = new Point(25, 14);
            lblXuatXu.Name = "lblXuatXu";
            lblXuatXu.Size = new Size(155, 32);
            lblXuatXu.TabIndex = 1;
            lblXuatXu.Text = "Xuất xứ Vaccine   ";
            // 
            // cboXuatXu
            // 
            cboXuatXu.BackColor = Color.White;
            cboXuatXu.FlatStyle = FlatStyle.Popup;
            cboXuatXu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboXuatXu.FormattingEnabled = true;
            cboXuatXu.Items.AddRange(new object[] { "Nhóm Vaccine" });
            cboXuatXu.Location = new Point(24, 12);
            cboXuatXu.Name = "cboXuatXu";
            cboXuatXu.Size = new Size(183, 33);
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
            pnlLoc.Size = new Size(257, 54);
            pnlLoc.TabIndex = 27;
            // 
            // lblMaloaivctmp
            // 
            lblMaloaivctmp.AutoSize = true;
            lblMaloaivctmp.Font = new Font("Microsoft Sans Serif", 12F);
            lblMaloaivctmp.Location = new Point(23, 4);
            lblMaloaivctmp.Name = "lblMaloaivctmp";
            lblMaloaivctmp.Padding = new Padding(10);
            lblMaloaivctmp.Size = new Size(193, 45);
            lblMaloaivctmp.TabIndex = 1;
            lblMaloaivctmp.Text = "Mã Loại Vaccine   ";
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.BackColor = Color.White;
            cboLoaiVC.FlatStyle = FlatStyle.Popup;
            cboLoaiVC.Font = new Font("Microsoft Sans Serif", 12F);
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Items.AddRange(new object[] { "Nhóm Vaccine" });
            cboLoaiVC.Location = new Point(23, 9);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(218, 33);
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
            pnlTimKiem.Size = new Size(344, 54);
            pnlTimKiem.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(26, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 25);
            txtSearch.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 10);
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
            btnThemVC.Image = Properties.Resources.vaccine_3021063;
            btnThemVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemVC.Location = new Point(888, 8);
            btnThemVC.Name = "btnThemVC";
            btnThemVC.Padding = new Padding(14, 5, 14, 5);
            btnThemVC.Size = new Size(183, 54);
            btnThemVC.TabIndex = 25;
            btnThemVC.Text = "Vaccine mới";
            btnThemVC.TextAlign = ContentAlignment.MiddleRight;
            btnThemVC.UseVisualStyleBackColor = false;
            btnThemVC.Click += btnThemVC_Click;
            // 
            // tabNhapVC
            // 
            tabNhapVC.Controls.Add(pnl2_VungThemNVC);
            tabNhapVC.Controls.Add(grbDSVC);
            tabNhapVC.ImageIndex = 0;
            tabNhapVC.Location = new Point(4, 54);
            tabNhapVC.Name = "tabNhapVC";
            tabNhapVC.Padding = new Padding(3);
            tabNhapVC.Size = new Size(1890, 997);
            tabNhapVC.TabIndex = 2;
            tabNhapVC.Text = "Nhập Vaccine";
            tabNhapVC.UseVisualStyleBackColor = true;
            // 
            // pnl2_VungThemNVC
            // 
            pnl2_VungThemNVC.Controls.Add(pnl_2_TaoPhieuNhap);
            pnl2_VungThemNVC.Controls.Add(grb2_ShowVCDuocChon);
            pnl2_VungThemNVC.Dock = DockStyle.Fill;
            pnl2_VungThemNVC.Location = new Point(3, 3);
            pnl2_VungThemNVC.Name = "pnl2_VungThemNVC";
            pnl2_VungThemNVC.Size = new Size(1301, 991);
            pnl2_VungThemNVC.TabIndex = 1;
            // 
            // pnl_2_TaoPhieuNhap
            // 
            pnl_2_TaoPhieuNhap.Controls.Add(pnl2_PN);
            pnl_2_TaoPhieuNhap.Controls.Add(panel3);
            pnl_2_TaoPhieuNhap.Controls.Add(grb2_ChiTietPhieuNhap);
            pnl_2_TaoPhieuNhap.Dock = DockStyle.Fill;
            pnl_2_TaoPhieuNhap.Location = new Point(0, 0);
            pnl_2_TaoPhieuNhap.Name = "pnl_2_TaoPhieuNhap";
            pnl_2_TaoPhieuNhap.Size = new Size(1301, 454);
            pnl_2_TaoPhieuNhap.TabIndex = 4;
            // 
            // pnl2_PN
            // 
            pnl2_PN.Controls.Add(pnlTongTien);
            pnl2_PN.Controls.Add(pnl2_ngaynhap);
            pnl2_PN.Controls.Add(pnl2_ncc);
            pnl2_PN.Controls.Add(pnl2_maphieu);
            pnl2_PN.Dock = DockStyle.Fill;
            pnl2_PN.Location = new Point(0, 96);
            pnl2_PN.Name = "pnl2_PN";
            pnl2_PN.Padding = new Padding(3, 13, 3, 3);
            pnl2_PN.Size = new Size(650, 358);
            pnl2_PN.TabIndex = 10;
            pnl2_PN.TabStop = false;
            pnl2_PN.Text = "Phiếu Nhập";
            // 
            // pnlTongTien
            // 
            pnlTongTien.BackColor = Color.White;
            pnlTongTien.Controls.Add(label3);
            pnlTongTien.Controls.Add(txtTongTien);
            pnlTongTien.Controls.Add(label2);
            pnlTongTien.Location = new Point(28, 278);
            pnlTongTien.Name = "pnlTongTien";
            pnlTongTien.Size = new Size(530, 62);
            pnlTongTien.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 20);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.BorderStyle = BorderStyle.None;
            txtTongTien.Location = new Point(154, 20);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(295, 39);
            txtTongTien.TabIndex = 1;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Tổng tiền";
            // 
            // pnl2_ngaynhap
            // 
            pnl2_ngaynhap.BackColor = Color.White;
            pnl2_ngaynhap.Controls.Add(dteNgayNhap);
            pnl2_ngaynhap.Controls.Add(label5);
            pnl2_ngaynhap.Location = new Point(28, 202);
            pnl2_ngaynhap.Name = "pnl2_ngaynhap";
            pnl2_ngaynhap.Size = new Size(530, 62);
            pnl2_ngaynhap.TabIndex = 3;
            // 
            // dteNgayNhap
            // 
            dteNgayNhap.Location = new Point(144, 17);
            dteNgayNhap.Margin = new Padding(0);
            dteNgayNhap.Name = "dteNgayNhap";
            dteNgayNhap.Size = new Size(363, 30);
            dteNgayNhap.TabIndex = 2;
            dteNgayNhap.Value = new DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 18);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 0;
            label5.Text = "Ngày Nhập";
            // 
            // pnl2_ncc
            // 
            pnl2_ncc.BackColor = Color.White;
            pnl2_ncc.Controls.Add(cboNCC);
            pnl2_ncc.Controls.Add(label4);
            pnl2_ncc.Location = new Point(28, 126);
            pnl2_ncc.Name = "pnl2_ncc";
            pnl2_ncc.Size = new Size(530, 62);
            pnl2_ncc.TabIndex = 2;
            // 
            // cboNCC
            // 
            cboNCC.BackColor = SystemColors.Window;
            cboNCC.FlatStyle = FlatStyle.Flat;
            cboNCC.FormattingEnabled = true;
            cboNCC.Location = new Point(163, 14);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(344, 33);
            cboNCC.TabIndex = 1;
            cboNCC.SelectedIndexChanged += cboNCC_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 18);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhà Cung Cấp";
            // 
            // pnl2_maphieu
            // 
            pnl2_maphieu.BackColor = Color.White;
            pnl2_maphieu.Controls.Add(txtMaPhieuN);
            pnl2_maphieu.Controls.Add(label1);
            pnl2_maphieu.Location = new Point(28, 50);
            pnl2_maphieu.Name = "pnl2_maphieu";
            pnl2_maphieu.Size = new Size(530, 62);
            pnl2_maphieu.TabIndex = 0;
            // 
            // txtMaPhieuN
            // 
            txtMaPhieuN.BackColor = Color.White;
            txtMaPhieuN.BorderStyle = BorderStyle.None;
            txtMaPhieuN.Location = new Point(144, 20);
            txtMaPhieuN.Multiline = true;
            txtMaPhieuN.Name = "txtMaPhieuN";
            txtMaPhieuN.ReadOnly = true;
            txtMaPhieuN.Size = new Size(363, 39);
            txtMaPhieuN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Phiếu";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLuuPhieuNhap);
            panel3.Controls.Add(btnTaoPhieuNhap);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 96);
            panel3.TabIndex = 9;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.BackColor = Color.FromArgb(255, 255, 128);
            btnLuuPhieuNhap.Location = new Point(322, 26);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(208, 46);
            btnLuuPhieuNhap.TabIndex = 4;
            btnLuuPhieuNhap.Text = "Lưu Phiếu Nhập";
            toolTip.SetToolTip(btnLuuPhieuNhap, "Nhấn vào để lưu phiếu nhập vào cơ sở dử liệu");
            btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            btnLuuPhieuNhap.Visible = false;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // btnTaoPhieuNhap
            // 
            btnTaoPhieuNhap.BackColor = Color.FromArgb(212, 246, 255);
            btnTaoPhieuNhap.Location = new Point(77, 26);
            btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            btnTaoPhieuNhap.Size = new Size(208, 46);
            btnTaoPhieuNhap.TabIndex = 1;
            btnTaoPhieuNhap.Text = "Tạo Phiếu Nhập";
            toolTip.SetToolTip(btnTaoPhieuNhap, "Nhấn vào để tạo phiếu nhập kho Vacine");
            btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            btnTaoPhieuNhap.Click += btnTaoPhieuNhap_Click;
            // 
            // grb2_ChiTietPhieuNhap
            // 
            grb2_ChiTietPhieuNhap.BackColor = Color.WhiteSmoke;
            grb2_ChiTietPhieuNhap.Controls.Add(pnlSoLuong);
            grb2_ChiTietPhieuNhap.Controls.Add(pnlThanhTien);
            grb2_ChiTietPhieuNhap.Controls.Add(btnCapNhatCTPN);
            grb2_ChiTietPhieuNhap.Controls.Add(btnXoaCTPN);
            grb2_ChiTietPhieuNhap.Controls.Add(btnThemCTPN);
            grb2_ChiTietPhieuNhap.Controls.Add(pnl2dongia);
            grb2_ChiTietPhieuNhap.Controls.Add(pnl2tenvaccine);
            grb2_ChiTietPhieuNhap.Dock = DockStyle.Right;
            grb2_ChiTietPhieuNhap.Location = new Point(650, 0);
            grb2_ChiTietPhieuNhap.Name = "grb2_ChiTietPhieuNhap";
            grb2_ChiTietPhieuNhap.Size = new Size(651, 454);
            grb2_ChiTietPhieuNhap.TabIndex = 2;
            grb2_ChiTietPhieuNhap.TabStop = false;
            grb2_ChiTietPhieuNhap.Text = "Chi tiết Vaccine";
            grb2_ChiTietPhieuNhap.Leave += grb2_ChiTietPhieuNhap_Leave;
            // 
            // pnlSoLuong
            // 
            pnlSoLuong.BackColor = Color.White;
            pnlSoLuong.Controls.Add(txtSolUong);
            pnlSoLuong.Controls.Add(txtSoLuongCTPN);
            pnlSoLuong.Location = new Point(47, 122);
            pnlSoLuong.Name = "pnlSoLuong";
            pnlSoLuong.Size = new Size(554, 62);
            pnlSoLuong.TabIndex = 5;
            // 
            // txtSolUong
            // 
            txtSolUong.BackColor = Color.White;
            txtSolUong.BorderStyle = BorderStyle.None;
            txtSolUong.Location = new Point(144, 18);
            txtSolUong.Multiline = true;
            txtSolUong.Name = "txtSolUong";
            txtSolUong.PlaceholderText = "Nhập vào số lượng Vaccine cần nhập";
            txtSolUong.Size = new Size(387, 39);
            txtSolUong.TabIndex = 1;
            txtSolUong.TextChanged += txtSolUong_TextChanged;
            txtSolUong.KeyPress += txtSolUong_KeyPress;
            // 
            // txtSoLuongCTPN
            // 
            txtSoLuongCTPN.AutoSize = true;
            txtSoLuongCTPN.Location = new Point(14, 18);
            txtSoLuongCTPN.Name = "txtSoLuongCTPN";
            txtSoLuongCTPN.Size = new Size(97, 25);
            txtSoLuongCTPN.TabIndex = 0;
            txtSoLuongCTPN.Text = "Số Lượng";
            // 
            // pnlThanhTien
            // 
            pnlThanhTien.BackColor = Color.White;
            pnlThanhTien.Controls.Add(label6);
            pnlThanhTien.Controls.Add(txtThanhTien);
            pnlThanhTien.Controls.Add(dsd);
            pnlThanhTien.Location = new Point(47, 288);
            pnlThanhTien.Name = "pnlThanhTien";
            pnlThanhTien.Size = new Size(554, 62);
            pnlThanhTien.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 18);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 3;
            label6.Text = "VNĐ";
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.White;
            txtThanhTien.BorderStyle = BorderStyle.None;
            txtThanhTien.Location = new Point(141, 18);
            txtThanhTien.Multiline = true;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.PlaceholderText = "Nhập số lượng thì thành tiền sẽ được tính";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(334, 39);
            txtThanhTien.TabIndex = 2;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // dsd
            // 
            dsd.AutoSize = true;
            dsd.Location = new Point(14, 18);
            dsd.Name = "dsd";
            dsd.Size = new Size(105, 25);
            dsd.TabIndex = 0;
            dsd.Text = "Thành tiền";
            // 
            // btnCapNhatCTPN
            // 
            btnCapNhatCTPN.BackColor = Color.LightSkyBlue;
            btnCapNhatCTPN.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhatCTPN.Image = (Image)resources.GetObject("btnCapNhatCTPN.Image");
            btnCapNhatCTPN.Location = new Point(434, 375);
            btnCapNhatCTPN.Margin = new Padding(0);
            btnCapNhatCTPN.Name = "btnCapNhatCTPN";
            btnCapNhatCTPN.Size = new Size(74, 67);
            btnCapNhatCTPN.TabIndex = 8;
            btnCapNhatCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip.SetToolTip(btnCapNhatCTPN, "Sửa lại thông tin trong danh sách đơn hàng");
            btnCapNhatCTPN.UseVisualStyleBackColor = false;
            btnCapNhatCTPN.Click += btnCapNhatCTPN_Click;
            // 
            // btnXoaCTPN
            // 
            btnXoaCTPN.BackColor = Color.FromArgb(255, 128, 128);
            btnXoaCTPN.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaCTPN.Image = (Image)resources.GetObject("btnXoaCTPN.Image");
            btnXoaCTPN.Location = new Point(285, 375);
            btnXoaCTPN.Margin = new Padding(0);
            btnXoaCTPN.Name = "btnXoaCTPN";
            btnXoaCTPN.Size = new Size(74, 67);
            btnXoaCTPN.TabIndex = 7;
            btnXoaCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip.SetToolTip(btnXoaCTPN, "Cập nhật vào danh sách đơn hàng");
            btnXoaCTPN.UseVisualStyleBackColor = false;
            btnXoaCTPN.Click += btnXoaCTPN_Click;
            // 
            // btnThemCTPN
            // 
            btnThemCTPN.BackColor = Color.FromArgb(82, 255, 181);
            btnThemCTPN.Enabled = false;
            btnThemCTPN.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemCTPN.Image = (Image)resources.GetObject("btnThemCTPN.Image");
            btnThemCTPN.Location = new Point(136, 375);
            btnThemCTPN.Margin = new Padding(0);
            btnThemCTPN.Name = "btnThemCTPN";
            btnThemCTPN.Size = new Size(74, 67);
            btnThemCTPN.TabIndex = 4;
            btnThemCTPN.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip.SetToolTip(btnThemCTPN, "Thêm vào danh sách đơn hàng");
            btnThemCTPN.UseVisualStyleBackColor = false;
            btnThemCTPN.Click += btnThemCTPN_Click;
            // 
            // pnl2dongia
            // 
            pnl2dongia.BackColor = Color.White;
            pnl2dongia.Controls.Add(txtDonGiaCTPN);
            pnl2dongia.Controls.Add(label7);
            pnl2dongia.Location = new Point(47, 205);
            pnl2dongia.Name = "pnl2dongia";
            pnl2dongia.Size = new Size(554, 62);
            pnl2dongia.TabIndex = 6;
            // 
            // txtDonGiaCTPN
            // 
            txtDonGiaCTPN.BackColor = Color.White;
            txtDonGiaCTPN.BorderStyle = BorderStyle.None;
            txtDonGiaCTPN.Location = new Point(144, 19);
            txtDonGiaCTPN.Multiline = true;
            txtDonGiaCTPN.Name = "txtDonGiaCTPN";
            txtDonGiaCTPN.Size = new Size(387, 39);
            txtDonGiaCTPN.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 18);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 0;
            label7.Text = "Đơn giá";
            // 
            // pnl2tenvaccine
            // 
            pnl2tenvaccine.BackColor = Color.White;
            pnl2tenvaccine.Controls.Add(txtTenVCCTPN);
            pnl2tenvaccine.Controls.Add(label16);
            pnl2tenvaccine.Location = new Point(47, 39);
            pnl2tenvaccine.Name = "pnl2tenvaccine";
            pnl2tenvaccine.Size = new Size(554, 62);
            pnl2tenvaccine.TabIndex = 4;
            // 
            // txtTenVCCTPN
            // 
            txtTenVCCTPN.BackColor = Color.White;
            txtTenVCCTPN.BorderStyle = BorderStyle.None;
            txtTenVCCTPN.Location = new Point(144, 18);
            txtTenVCCTPN.Multiline = true;
            txtTenVCCTPN.Name = "txtTenVCCTPN";
            txtTenVCCTPN.PlaceholderText = "Nhập vào tên Vaccine cần nhập";
            txtTenVCCTPN.Size = new Size(387, 39);
            txtTenVCCTPN.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(14, 18);
            label16.Name = "label16";
            label16.Size = new Size(123, 25);
            label16.TabIndex = 0;
            label16.Text = "Tên Vaccine";
            // 
            // grb2_ShowVCDuocChon
            // 
            grb2_ShowVCDuocChon.Controls.Add(dtgDanhSachVCduocChon);
            grb2_ShowVCDuocChon.Dock = DockStyle.Bottom;
            grb2_ShowVCDuocChon.Location = new Point(0, 454);
            grb2_ShowVCDuocChon.Name = "grb2_ShowVCDuocChon";
            grb2_ShowVCDuocChon.Padding = new Padding(3, 13, 3, 3);
            grb2_ShowVCDuocChon.Size = new Size(1301, 537);
            grb2_ShowVCDuocChon.TabIndex = 0;
            grb2_ShowVCDuocChon.TabStop = false;
            grb2_ShowVCDuocChon.Text = "Danh sách sản phẩm muốn nhập";
            // 
            // dtgDanhSachVCduocChon
            // 
            dtgDanhSachVCduocChon.AllowUserToAddRows = false;
            dtgDanhSachVCduocChon.AllowUserToDeleteRows = false;
            dtgDanhSachVCduocChon.AllowUserToResizeColumns = false;
            dtgDanhSachVCduocChon.AllowUserToResizeRows = false;
            dtgDanhSachVCduocChon.BackgroundColor = Color.White;
            dtgDanhSachVCduocChon.BorderStyle = BorderStyle.None;
            dtgDanhSachVCduocChon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgDanhSachVCduocChon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgDanhSachVCduocChon.ColumnHeadersHeight = 29;
            dtgDanhSachVCduocChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgDanhSachVCduocChon.Dock = DockStyle.Fill;
            dtgDanhSachVCduocChon.Location = new Point(3, 36);
            dtgDanhSachVCduocChon.MultiSelect = false;
            dtgDanhSachVCduocChon.Name = "dtgDanhSachVCduocChon";
            dtgDanhSachVCduocChon.RowHeadersVisible = false;
            dtgDanhSachVCduocChon.RowHeadersWidth = 51;
            dtgDanhSachVCduocChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachVCduocChon.Size = new Size(1295, 498);
            dtgDanhSachVCduocChon.TabIndex = 0;
            dtgDanhSachVCduocChon.DataSourceChanged += dtgDanhSachVCduocChon_DataSourceChanged;
            dtgDanhSachVCduocChon.CellClick += dtgDanhSachVCduocChon_CellClick;
            dtgDanhSachVCduocChon.CellValueChanged += dtgDanhSachVCduocChon_CellValueChanged;
            // 
            // grbDSVC
            // 
            grbDSVC.Controls.Add(pnlThongBaoTab2);
            grbDSVC.Controls.Add(dtgCTPN);
            grbDSVC.Dock = DockStyle.Right;
            grbDSVC.Location = new Point(1304, 3);
            grbDSVC.Name = "grbDSVC";
            grbDSVC.Padding = new Padding(3, 13, 3, 3);
            grbDSVC.Size = new Size(583, 991);
            grbDSVC.TabIndex = 0;
            grbDSVC.TabStop = false;
            grbDSVC.Text = "Danh sách các loại Vaccine";
            // 
            // pnlThongBaoTab2
            // 
            pnlThongBaoTab2.BackColor = Color.Black;
            pnlThongBaoTab2.Controls.Add(pnlThongBaotab2s);
            pnlThongBaoTab2.Location = new Point(3, 892);
            pnlThongBaoTab2.Name = "pnlThongBaoTab2";
            pnlThongBaoTab2.Size = new Size(555, 72);
            pnlThongBaoTab2.TabIndex = 1;
            pnlThongBaoTab2.Visible = false;
            // 
            // pnlThongBaotab2s
            // 
            pnlThongBaotab2s.BackColor = Color.White;
            pnlThongBaotab2s.Controls.Add(txtndthongbaotab2);
            pnlThongBaotab2s.Controls.Add(pictureBox3);
            pnlThongBaotab2s.Location = new Point(2, 2);
            pnlThongBaotab2s.Name = "pnlThongBaotab2s";
            pnlThongBaotab2s.Size = new Size(550, 68);
            pnlThongBaotab2s.TabIndex = 2;
            // 
            // txtndthongbaotab2
            // 
            txtndthongbaotab2.AutoSize = true;
            txtndthongbaotab2.Location = new Point(98, 22);
            txtndthongbaotab2.Name = "txtndthongbaotab2";
            txtndthongbaotab2.Size = new Size(107, 25);
            txtndthongbaotab2.TabIndex = 1;
            txtndthongbaotab2.Text = "Thông báo";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.notification_16903647;
            pictureBox3.Location = new Point(26, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // dtgCTPN
            // 
            dtgCTPN.AllowUserToAddRows = false;
            dtgCTPN.AllowUserToDeleteRows = false;
            dtgCTPN.AllowUserToResizeColumns = false;
            dtgCTPN.AllowUserToResizeRows = false;
            dtgCTPN.BackgroundColor = Color.White;
            dtgCTPN.BorderStyle = BorderStyle.None;
            dtgCTPN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgCTPN.ColumnHeadersHeight = 60;
            dtgCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgCTPN.Dock = DockStyle.Fill;
            dtgCTPN.Location = new Point(3, 36);
            dtgCTPN.MultiSelect = false;
            dtgCTPN.Name = "dtgCTPN";
            dtgCTPN.ReadOnly = true;
            dtgCTPN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgCTPN.RowHeadersVisible = false;
            dtgCTPN.RowHeadersWidth = 60;
            dtgCTPN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCTPN.Size = new Size(577, 952);
            dtgCTPN.TabIndex = 0;
            dtgCTPN.CellClick += dtgCTPN_CellClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "purchase_3310182.png");
            imageList1.Images.SetKeyName(1, "khovc.png");
            // 
            // timerTB
            // 
            timerTB.Interval = 4000;
            timerTB.Tick += timerTB_Tick;
            // 
            // timerHieuUng
            // 
            timerHieuUng.Interval = 20;
            timerHieuUng.Tick += timerHieuUng_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // timerTB_Tab2
            // 
            timerTB_Tab2.Interval = 4000;
            timerTB_Tab2.Tick += timerTB_Tab2_Tick;
            // 
            // frmQLVaccine
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1055);
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
            tabKhoVaccine.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlThongBao.ResumeLayout(false);
            pnlTb.ResumeLayout(false);
            pnlTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).EndInit();
            cntXoaSua.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlLocXuatXu.ResumeLayout(false);
            pnlLoc.ResumeLayout(false);
            pnlLoc.PerformLayout();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabNhapVC.ResumeLayout(false);
            pnl2_VungThemNVC.ResumeLayout(false);
            pnl_2_TaoPhieuNhap.ResumeLayout(false);
            pnl2_PN.ResumeLayout(false);
            pnlTongTien.ResumeLayout(false);
            pnlTongTien.PerformLayout();
            pnl2_ngaynhap.ResumeLayout(false);
            pnl2_ngaynhap.PerformLayout();
            pnl2_ncc.ResumeLayout(false);
            pnl2_ncc.PerformLayout();
            pnl2_maphieu.ResumeLayout(false);
            pnl2_maphieu.PerformLayout();
            panel3.ResumeLayout(false);
            grb2_ChiTietPhieuNhap.ResumeLayout(false);
            pnlSoLuong.ResumeLayout(false);
            pnlSoLuong.PerformLayout();
            pnlThanhTien.ResumeLayout(false);
            pnlThanhTien.PerformLayout();
            pnl2dongia.ResumeLayout(false);
            pnl2dongia.PerformLayout();
            pnl2tenvaccine.ResumeLayout(false);
            pnl2tenvaccine.PerformLayout();
            grb2_ShowVCDuocChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachVCduocChon).EndInit();
            grbDSVC.ResumeLayout(false);
            pnlThongBaoTab2.ResumeLayout(false);
            pnlThongBaotab2s.ResumeLayout(false);
            pnlThongBaotab2s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgCTPN).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tctChinh;
        private TabPage tabKhoVaccine;
        private ImageList imageList1;
        private Button btnSearch;
        private Button btnThemVC;
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
        private ContextMenuStrip cntXoaSua;
        private ToolStripMenuItem CapNhatToolStripMenuItem;
        private ToolStripMenuItem XoaVaccineToolStripMenuItem;
        private Panel pnlThongBao;
        private Panel pnlTb;
        private PictureBox pictureBox1;
        private Label lblndtb;
        private System.Windows.Forms.Timer timerTB;
        private System.Windows.Forms.Timer timerHieuUng;
        private Button btnThemLoai;
        private TabPage tabNhapVC;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnl2_VungThemNVC;
        private GroupBox grbDSVC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grb2_ChiTietPhieuNhap;
        private GroupBox grb2_ShowVCDuocChon;
        private DataGridView dtgDanhSachVCduocChon;
        private DataGridView dtgCTPN;
        private Panel pnl_2_TaoPhieuNhap;
        private Panel pnl2_ncc;
        private ComboBox cboNCC;
        private Label label4;
        private Panel pnl2_ngaynhap;
        private DateTimePicker dteNgayNhap;
        private Label label5;
        private Button btnTaoPhieuNhap;
        private Button btnThemCTPN;
        private ToolTip toolTip;
        private Panel pnl2dongia;
        private Label label7;
        private Panel pnl2tenvaccine;
        private TextBox txtTenVCCTPN;
        private Label label16;
        private TextBox txtDonGiaCTPN;
        private Button btnCapNhatCTPN;
        private Button btnXoaCTPN;
        private Button btnLuuPhieuNhap;
        private Panel panel3;
        private GroupBox pnl2_PN;
        private Panel pnl2_maphieu;
        private TextBox txtMaPhieuN;
        private Label label1;
        private Panel pnlThanhTien;
        private TextBox txtThanhTien;
        private Label dsd;
        private Panel pnlSoLuong;
        private TextBox txtSolUong;
        private Label txtSoLuongCTPN;
        private Panel pnlTongTien;
        private TextBox txtTongTien;
        private Label label2;
        private Label label3;
        private Panel pnlThongBaotab2s;
        private Panel pnlThongBaoTab2;
        private PictureBox pictureBox3;
        private Label txtndthongbaotab2;
        private System.Windows.Forms.Timer timerTB_Tab2;
        private Label label6;
    }
}