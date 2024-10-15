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
            dgvVaccine = new DataGridView();
            tctChinh = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnLoadTTLoaiVaccine = new Button();
            btnLoadTTVC = new Button();
            grbTimKiem = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            grbLoaiVC = new GroupBox();
            btnSuaLVC = new Button();
            btnXoaLoaiVC = new Button();
            btnThemLVC = new Button();
            label8 = new Label();
            txtTenLoaiVC = new TextBox();
            grbTTVC = new GroupBox();
            btnSuaTTVC = new Button();
            btnXoaTTVC = new Button();
            btnThemTTVC = new Button();
            panel2 = new Panel();
            dtpHSD = new DateTimePicker();
            panel1 = new Panel();
            dtpNSX = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtGia = new TextBox();
            txtTenVaccine = new TextBox();
            cboLoaiVaccine = new ComboBox();
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
            label15 = new Label();
            btnUpdateHDN = new Button();
            btnXoaHDH = new Button();
            cboMaHoaDonNHap = new ComboBox();
            txtVaccineNhapCTHD = new TextBox();
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
            txtNgayNhapHang = new DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbTimKiem.SuspendLayout();
            grbLoaiVC.SuspendLayout();
            grbTTVC.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaccine.Dock = DockStyle.Bottom;
            dgvVaccine.GridColor = Color.WhiteSmoke;
            dgvVaccine.Location = new Point(3, 544);
            dgvVaccine.MultiSelect = false;
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaccine.Size = new Size(1757, 470);
            dgvVaccine.TabIndex = 0;
            // 
            // tctChinh
            // 
            tctChinh.Controls.Add(tabPage1);
            tctChinh.Controls.Add(tabPage2);
            tctChinh.Dock = DockStyle.Fill;
            tctChinh.ImageList = imageList1;
            tctChinh.Location = new Point(0, 0);
            tctChinh.Name = "tctChinh";
            tctChinh.SelectedIndex = 0;
            tctChinh.Size = new Size(1771, 1055);
            tctChinh.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(grbTTVC);
            tabPage1.Controls.Add(dgvVaccine);
            tabPage1.ImageIndex = 1;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1763, 1017);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kho Vaccine";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.tim;
            pictureBox2.Location = new Point(806, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 362);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(grbTimKiem);
            panel3.Controls.Add(grbLoaiVC);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1256, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 541);
            panel3.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(btnLoadTTLoaiVaccine);
            groupBox4.Controls.Add(btnLoadTTVC);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 289);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(504, 252);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Load";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sach;
            pictureBox1.Location = new Point(361, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnLoadTTLoaiVaccine
            // 
            btnLoadTTLoaiVaccine.BackColor = Color.Aquamarine;
            btnLoadTTLoaiVaccine.Image = Properties.Resources.load;
            btnLoadTTLoaiVaccine.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadTTLoaiVaccine.Location = new Point(39, 137);
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
            btnLoadTTVC.Location = new Point(39, 48);
            btnLoadTTVC.Name = "btnLoadTTVC";
            btnLoadTTVC.Padding = new Padding(15, 5, 35, 5);
            btnLoadTTVC.Size = new Size(293, 59);
            btnLoadTTVC.TabIndex = 24;
            btnLoadTTVC.Text = "Thông Tin Vaccine";
            btnLoadTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnLoadTTVC.UseVisualStyleBackColor = false;
            btnLoadTTVC.Click += btnLoadTTVC_Click;
            // 
            // grbTimKiem
            // 
            grbTimKiem.BackColor = Color.Transparent;
            grbTimKiem.Controls.Add(btnSearch);
            grbTimKiem.Controls.Add(txtSearch);
            grbTimKiem.Dock = DockStyle.Top;
            grbTimKiem.Enabled = false;
            grbTimKiem.Location = new Point(0, 192);
            grbTimKiem.Name = "grbTimKiem";
            grbTimKiem.Size = new Size(504, 97);
            grbTimKiem.TabIndex = 3;
            grbTimKiem.TabStop = false;
            grbTimKiem.Text = "Tìm Kiếm";
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Image = Properties.Resources.timkiem;
            btnSearch.Location = new Point(419, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 43);
            btnSearch.TabIndex = 25;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.PapayaWhip;
            txtSearch.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtSearch.Location = new Point(66, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(347, 34);
            txtSearch.TabIndex = 24;
            // 
            // grbLoaiVC
            // 
            grbLoaiVC.Controls.Add(btnSuaLVC);
            grbLoaiVC.Controls.Add(btnXoaLoaiVC);
            grbLoaiVC.Controls.Add(btnThemLVC);
            grbLoaiVC.Controls.Add(label8);
            grbLoaiVC.Controls.Add(txtTenLoaiVC);
            grbLoaiVC.Dock = DockStyle.Top;
            grbLoaiVC.Location = new Point(0, 0);
            grbLoaiVC.Name = "grbLoaiVC";
            grbLoaiVC.Size = new Size(504, 192);
            grbLoaiVC.TabIndex = 2;
            grbLoaiVC.TabStop = false;
            grbLoaiVC.Text = "Loại Vaccine";
            // 
            // btnSuaLVC
            // 
            btnSuaLVC.BackColor = Color.PaleTurquoise;
            btnSuaLVC.ForeColor = Color.Navy;
            btnSuaLVC.Image = Properties.Resources.cut;
            btnSuaLVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaLVC.Location = new Point(333, 105);
            btnSuaLVC.Name = "btnSuaLVC";
            btnSuaLVC.Padding = new Padding(15, 5, 25, 5);
            btnSuaLVC.Size = new Size(147, 59);
            btnSuaLVC.TabIndex = 21;
            btnSuaLVC.Text = "Sửa";
            btnSuaLVC.TextAlign = ContentAlignment.MiddleRight;
            btnSuaLVC.UseVisualStyleBackColor = false;
            btnSuaLVC.Click += btnSuaLVC_Click;
            // 
            // btnXoaLoaiVC
            // 
            btnXoaLoaiVC.BackColor = Color.Salmon;
            btnXoaLoaiVC.ForeColor = Color.White;
            btnXoaLoaiVC.Image = Properties.Resources.xoa;
            btnXoaLoaiVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaLoaiVC.Location = new Point(176, 105);
            btnXoaLoaiVC.Name = "btnXoaLoaiVC";
            btnXoaLoaiVC.Padding = new Padding(15, 5, 25, 5);
            btnXoaLoaiVC.Size = new Size(147, 59);
            btnXoaLoaiVC.TabIndex = 21;
            btnXoaLoaiVC.Text = "Xoá";
            btnXoaLoaiVC.TextAlign = ContentAlignment.MiddleRight;
            btnXoaLoaiVC.UseVisualStyleBackColor = false;
            btnXoaLoaiVC.Click += btnXoaLoaiVC_Click;
            // 
            // btnThemLVC
            // 
            btnThemLVC.BackColor = Color.Aquamarine;
            btnThemLVC.Image = Properties.Resources.add2;
            btnThemLVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemLVC.Location = new Point(19, 105);
            btnThemLVC.Name = "btnThemLVC";
            btnThemLVC.Padding = new Padding(15, 5, 15, 5);
            btnThemLVC.Size = new Size(147, 59);
            btnThemLVC.TabIndex = 21;
            btnThemLVC.Text = "Thêm";
            btnThemLVC.TextAlign = ContentAlignment.MiddleRight;
            btnThemLVC.UseVisualStyleBackColor = false;
            btnThemLVC.Click += btnThemLVC_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 49);
            label8.Name = "label8";
            label8.Size = new Size(181, 27);
            label8.TabIndex = 22;
            label8.Text = "Tên Loại Vaccine";
            // 
            // txtTenLoaiVC
            // 
            txtTenLoaiVC.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtTenLoaiVC.Location = new Point(234, 44);
            txtTenLoaiVC.Name = "txtTenLoaiVC";
            txtTenLoaiVC.Size = new Size(246, 34);
            txtTenLoaiVC.TabIndex = 23;
            // 
            // grbTTVC
            // 
            grbTTVC.BackColor = Color.White;
            grbTTVC.Controls.Add(btnSuaTTVC);
            grbTTVC.Controls.Add(btnXoaTTVC);
            grbTTVC.Controls.Add(btnThemTTVC);
            grbTTVC.Controls.Add(panel2);
            grbTTVC.Controls.Add(panel1);
            grbTTVC.Controls.Add(label7);
            grbTTVC.Controls.Add(label5);
            grbTTVC.Controls.Add(label4);
            grbTTVC.Controls.Add(label3);
            grbTTVC.Controls.Add(label1);
            grbTTVC.Controls.Add(txtGia);
            grbTTVC.Controls.Add(txtTenVaccine);
            grbTTVC.Controls.Add(cboLoaiVaccine);
            grbTTVC.Dock = DockStyle.Left;
            grbTTVC.Location = new Point(3, 3);
            grbTTVC.Name = "grbTTVC";
            grbTTVC.Size = new Size(743, 541);
            grbTTVC.TabIndex = 1;
            grbTTVC.TabStop = false;
            grbTTVC.Text = "Thêm Thông Tin Vaccine";
            // 
            // btnSuaTTVC
            // 
            btnSuaTTVC.BackColor = Color.PaleTurquoise;
            btnSuaTTVC.ForeColor = Color.Navy;
            btnSuaTTVC.Image = Properties.Resources.cut;
            btnSuaTTVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaTTVC.Location = new Point(505, 426);
            btnSuaTTVC.Name = "btnSuaTTVC";
            btnSuaTTVC.Padding = new Padding(15, 5, 25, 5);
            btnSuaTTVC.Size = new Size(201, 59);
            btnSuaTTVC.TabIndex = 18;
            btnSuaTTVC.Text = "Sửa Vacine";
            btnSuaTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnSuaTTVC.UseVisualStyleBackColor = false;
            btnSuaTTVC.Click += btnSuaTTVC_Click;
            // 
            // btnXoaTTVC
            // 
            btnXoaTTVC.BackColor = Color.Salmon;
            btnXoaTTVC.ForeColor = Color.White;
            btnXoaTTVC.Image = Properties.Resources.xoa;
            btnXoaTTVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaTTVC.Location = new Point(270, 426);
            btnXoaTTVC.Name = "btnXoaTTVC";
            btnXoaTTVC.Padding = new Padding(15, 5, 25, 5);
            btnXoaTTVC.Size = new Size(213, 59);
            btnXoaTTVC.TabIndex = 17;
            btnXoaTTVC.Text = "Xoá Vaccine";
            btnXoaTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnXoaTTVC.UseVisualStyleBackColor = false;
            btnXoaTTVC.Click += btnXoaTTVC_Click;
            // 
            // btnThemTTVC
            // 
            btnThemTTVC.BackColor = Color.Aquamarine;
            btnThemTTVC.Image = Properties.Resources.add2;
            btnThemTTVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemTTVC.Location = new Point(35, 426);
            btnThemTTVC.Name = "btnThemTTVC";
            btnThemTTVC.Padding = new Padding(15, 5, 15, 5);
            btnThemTTVC.Size = new Size(213, 59);
            btnThemTTVC.TabIndex = 16;
            btnThemTTVC.Text = "Thêm Vaccine";
            btnThemTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnThemTTVC.UseVisualStyleBackColor = false;
            btnThemTTVC.Click += btnThemTTVC_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(dtpHSD);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(252, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 40);
            panel2.TabIndex = 15;
            // 
            // dtpHSD
            // 
            dtpHSD.CalendarForeColor = Color.MediumSpringGreen;
            dtpHSD.CalendarMonthBackground = Color.MediumSpringGreen;
            dtpHSD.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            dtpHSD.Location = new Point(3, 3);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(398, 34);
            dtpHSD.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSpringGreen;
            panel1.Controls.Add(dtpNSX);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(252, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 40);
            panel1.TabIndex = 14;
            // 
            // dtpNSX
            // 
            dtpNSX.CalendarForeColor = Color.MediumSpringGreen;
            dtpNSX.CalendarMonthBackground = Color.MediumSpringGreen;
            dtpNSX.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            dtpNSX.Location = new Point(3, 3);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(398, 34);
            dtpNSX.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label7.Location = new Point(45, 364);
            label7.Name = "label7";
            label7.Size = new Size(45, 27);
            label7.TabIndex = 13;
            label7.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label5.Location = new Point(45, 284);
            label5.Name = "label5";
            label5.Size = new Size(143, 27);
            label5.TabIndex = 11;
            label5.Text = "Hạn Sử Dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.Location = new Point(45, 204);
            label4.Name = "label4";
            label4.Size = new Size(161, 27);
            label4.TabIndex = 10;
            label4.Text = "Ngày Sản Xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 124);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 9;
            label3.Text = "Tên Vaccine";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 44);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 7;
            label1.Text = "Loại Vaccine";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtGia.Location = new Point(252, 361);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(404, 34);
            txtGia.TabIndex = 6;
            // 
            // txtTenVaccine
            // 
            txtTenVaccine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtTenVaccine.Location = new Point(252, 118);
            txtTenVaccine.Name = "txtTenVaccine";
            txtTenVaccine.Size = new Size(404, 34);
            txtTenVaccine.TabIndex = 2;
            // 
            // cboLoaiVaccine
            // 
            cboLoaiVaccine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            cboLoaiVaccine.FormattingEnabled = true;
            cboLoaiVaccine.Location = new Point(252, 40);
            cboLoaiVaccine.Name = "cboLoaiVaccine";
            cboLoaiVaccine.Size = new Size(404, 35);
            cboLoaiVaccine.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(dgvNhapVaccine);
            tabPage2.ImageIndex = 0;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1763, 1017);
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
            panel4.Size = new Size(1757, 574);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox6);
            panel6.Controls.Add(groupBox5);
            panel6.Controls.Add(grbChiTietNhapVC);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1161, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(596, 574);
            panel6.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnChiTietNhap);
            groupBox6.Controls.Add(btnHoaDonNhap);
            groupBox6.Controls.Add(btnLoadNCC);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(0, 439);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(596, 135);
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
            groupBox5.Location = new Point(0, 356);
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
            grbChiTietNhapVC.Controls.Add(label15);
            grbChiTietNhapVC.Controls.Add(btnUpdateHDN);
            grbChiTietNhapVC.Controls.Add(btnXoaHDH);
            grbChiTietNhapVC.Controls.Add(cboMaHoaDonNHap);
            grbChiTietNhapVC.Controls.Add(txtVaccineNhapCTHD);
            grbChiTietNhapVC.Controls.Add(btnThemCTHDN);
            grbChiTietNhapVC.Controls.Add(txtSoLuongNhap);
            grbChiTietNhapVC.Controls.Add(label12);
            grbChiTietNhapVC.Controls.Add(txtDonGiaNhap);
            grbChiTietNhapVC.Controls.Add(label13);
            grbChiTietNhapVC.Controls.Add(label14);
            grbChiTietNhapVC.Dock = DockStyle.Top;
            grbChiTietNhapVC.Location = new Point(0, 0);
            grbChiTietNhapVC.Name = "grbChiTietNhapVC";
            grbChiTietNhapVC.Size = new Size(596, 356);
            grbChiTietNhapVC.TabIndex = 0;
            grbChiTietNhapVC.TabStop = false;
            grbChiTietNhapVC.Text = "Chi tiết nhập hoá đơn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(51, 50);
            label15.Name = "label15";
            label15.Size = new Size(162, 25);
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
            // 
            // cboMaHoaDonNHap
            // 
            cboMaHoaDonNHap.FormattingEnabled = true;
            cboMaHoaDonNHap.Location = new Point(228, 46);
            cboMaHoaDonNHap.Name = "cboMaHoaDonNHap";
            cboMaHoaDonNHap.Size = new Size(283, 33);
            cboMaHoaDonNHap.TabIndex = 12;
            // 
            // txtVaccineNhapCTHD
            // 
            txtVaccineNhapCTHD.Location = new Point(228, 108);
            txtVaccineNhapCTHD.Name = "txtVaccineNhapCTHD";
            txtVaccineNhapCTHD.Size = new Size(283, 31);
            txtVaccineNhapCTHD.TabIndex = 9;
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
            label12.Size = new Size(78, 25);
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
            label13.Size = new Size(136, 25);
            label13.TabIndex = 13;
            label13.Text = "Số lượng nhập";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(51, 111);
            label14.Name = "label14";
            label14.Size = new Size(125, 25);
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
            panel5.Size = new Size(643, 574);
            panel5.TabIndex = 0;
            // 
            // grbHDN
            // 
            grbHDN.Controls.Add(btnUpdateHDNhap);
            grbHDN.Controls.Add(label11);
            grbHDN.Controls.Add(btnXoaHDNhap);
            grbHDN.Controls.Add(btnThemHoaDonNhapHangf);
            grbHDN.Controls.Add(label10);
            grbHDN.Controls.Add(txtNgayNhapHang);
            grbHDN.Controls.Add(cboNhaCungCap);
            grbHDN.Dock = DockStyle.Fill;
            grbHDN.Location = new Point(0, 261);
            grbHDN.Name = "grbHDN";
            grbHDN.Size = new Size(643, 313);
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
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(55, 126);
            label11.Name = "label11";
            label11.Size = new Size(159, 25);
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
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 63);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 2;
            label10.Text = "Nhà Cung Cấp";
            // 
            // txtNgayNhapHang
            // 
            txtNgayNhapHang.Location = new Point(220, 124);
            txtNgayNhapHang.Name = "txtNgayNhapHang";
            txtNgayNhapHang.Size = new Size(327, 31);
            txtNgayNhapHang.TabIndex = 1;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(220, 59);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(327, 33);
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
            grbNhaCC.Dock = DockStyle.Top;
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
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 151);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 5;
            label9.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 99);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 47);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhapVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhapVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapVaccine.Dock = DockStyle.Bottom;
            dgvNhapVaccine.GridColor = Color.WhiteSmoke;
            dgvNhapVaccine.Location = new Point(3, 577);
            dgvNhapVaccine.MultiSelect = false;
            dgvNhapVaccine.Name = "dgvNhapVaccine";
            dgvNhapVaccine.RowHeadersWidth = 51;
            dgvNhapVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapVaccine.Size = new Size(1757, 437);
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
            ClientSize = new Size(1771, 1055);
            Controls.Add(tctChinh);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(4);
            Name = "frmQLVaccine";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Quản Lý Vaccine";
            Load += frmQLVaccine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).EndInit();
            tctChinh.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbTimKiem.ResumeLayout(false);
            grbTimKiem.PerformLayout();
            grbLoaiVC.ResumeLayout(false);
            grbLoaiVC.PerformLayout();
            grbTTVC.ResumeLayout(false);
            grbTTVC.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private GroupBox grbTTVC;
        private ComboBox cboLoaiVaccine;
        private DateTimePicker dtpNSX;
        private TextBox txtTenVaccine;
        private TextBox txtGia;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpHSD;
        private Button btnThemTTVC;
        private Button btnSuaTTVC;
        private Button btnXoaTTVC;
        private GroupBox grbTimKiem;
        private Panel panel3;
        private GroupBox grbLoaiVC;
        private Label label8;
        private TextBox txtTenLoaiVC;
        private Button btnSuaLVC;
        private Button btnXoaLoaiVC;
        private Button btnThemLVC;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLoadTTVC;
        private Button btnLoadTTLoaiVaccine;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvNhapVaccine;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private GroupBox grbNhaCC;
        private GroupBox grbHDN;
        private GroupBox grbChiTietNhapVC;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenNCCVC;
        private Button btnThemNCC;
        private Label label9;
        private Label label6;
        private Label label2;
        private Button btnXoaNCC;
        private Button btnCapNhatNCC;
        private GroupBox groupBox5;
        private Label label11;
        private Label label10;
        private DateTimePicker txtNgayNhapHang;
        private ComboBox cboNhaCungCap;
        private Button btnUpdateHDNhap;
        private Button btnXoaHDNhap;
        private Button btnThemHoaDonNhapHangf;
        private Button btnUpdateHDN;
        private Button btnXoaHDH;
        private TextBox txtVaccineNhapCTHD;
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
    }
}