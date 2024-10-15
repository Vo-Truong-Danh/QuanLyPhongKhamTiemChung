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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            groupBox5 = new GroupBox();
            button10 = new Button();
            textBox7 = new TextBox();
            groupBox3 = new GroupBox();
            label15 = new Label();
            button7 = new Button();
            button8 = new Button();
            comboBox2 = new ComboBox();
            textBox6 = new TextBox();
            button9 = new Button();
            textBox5 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel5 = new Panel();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label11 = new Label();
            button5 = new Button();
            button6 = new Button();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
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
            groupBox3.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvVaccine
            // 
            dgvVaccine.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle7.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            tabPage2.Controls.Add(dataGridView1);
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
            panel6.Controls.Add(groupBox3);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1161, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(596, 574);
            panel6.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button13);
            groupBox6.Controls.Add(button12);
            groupBox6.Controls.Add(button11);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(0, 451);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(596, 123);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Load";
            // 
            // button13
            // 
            button13.BackColor = Color.Aquamarine;
            button13.Image = Properties.Resources.load;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(404, 45);
            button13.Name = "button13";
            button13.Padding = new Padding(5, 0, 5, 2);
            button13.Size = new Size(180, 49);
            button13.TabIndex = 20;
            button13.Text = "Chi Tiết Nhập";
            button13.TextAlign = ContentAlignment.MiddleRight;
            button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Aquamarine;
            button12.Image = Properties.Resources.load;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(218, 45);
            button12.Name = "button12";
            button12.Padding = new Padding(5, 0, 5, 2);
            button12.Size = new Size(185, 49);
            button12.TabIndex = 19;
            button12.Text = "Hoá Đơn Nhập";
            button12.TextAlign = ContentAlignment.MiddleRight;
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Aquamarine;
            button11.Image = Properties.Resources.load;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(34, 45);
            button11.Name = "button11";
            button11.Padding = new Padding(5, 0, 5, 2);
            button11.Size = new Size(183, 49);
            button11.TabIndex = 18;
            button11.Text = "Nhà Cung Cấp";
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button10);
            groupBox5.Controls.Add(textBox7);
            groupBox5.Dock = DockStyle.Top;
            groupBox5.Location = new Point(0, 356);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(596, 95);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm Kiếm";
            // 
            // button10
            // 
            button10.ForeColor = Color.MintCream;
            button10.Image = Properties.Resources.timkiem;
            button10.Location = new Point(473, 27);
            button10.Name = "button10";
            button10.Size = new Size(55, 55);
            button10.TabIndex = 19;
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LemonChiffon;
            textBox7.Location = new Point(78, 39);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(379, 31);
            textBox7.TabIndex = 18;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 356);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết nhập hoá đơn";
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
            // button7
            // 
            button7.BackColor = Color.Blue;
            button7.ForeColor = Color.LightCyan;
            button7.Image = Properties.Resources.sync_8468966;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(343, 275);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 0, 5, 0);
            button7.Size = new Size(210, 49);
            button7.TabIndex = 17;
            button7.Text = "Cập Nhật TT NCC";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.MistyRose;
            button8.Image = Properties.Resources.xoa;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(187, 275);
            button8.Name = "button8";
            button8.Padding = new Padding(5, 0, 5, 2);
            button8.Size = new Size(139, 49);
            button8.TabIndex = 16;
            button8.Text = "Xoá NCC";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(228, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(283, 33);
            comboBox2.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(228, 108);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 31);
            textBox6.TabIndex = 9;
            // 
            // button9
            // 
            button9.BackColor = Color.Aquamarine;
            button9.Image = Properties.Resources.add2;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(31, 275);
            button9.Name = "button9";
            button9.Padding = new Padding(5, 0, 5, 2);
            button9.Size = new Size(139, 49);
            button9.TabIndex = 15;
            button9.Text = "Tạo NCC";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(228, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 31);
            textBox5.TabIndex = 10;
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
            // textBox4
            // 
            textBox4.Location = new Point(228, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 31);
            textBox4.TabIndex = 11;
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
            panel5.Controls.Add(groupBox2);
            panel5.Controls.Add(groupBox1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(570, 574);
            panel5.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(570, 313);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập Vaccine";
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.ForeColor = Color.LightCyan;
            button4.Image = Properties.Resources.sync_8468966;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(155, 211);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 5, 0);
            button4.Size = new Size(235, 59);
            button4.TabIndex = 11;
            button4.Text = "Cập Nhật Hoá Đơn";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 98);
            label11.Name = "label11";
            label11.Size = new Size(159, 25);
            label11.TabIndex = 3;
            label11.Text = "Ngày Nhập Hàng";
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Image = Properties.Resources.xoa;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(280, 141);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 5, 2);
            button5.Size = new Size(180, 59);
            button5.TabIndex = 10;
            button5.Text = "Xoá Hoá Đơn";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.Image = Properties.Resources.add2;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(86, 141);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 5, 2);
            button6.Size = new Size(180, 59);
            button6.TabIndex = 9;
            button6.Text = "Tạo Hoá Đơn";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 45);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 2;
            label10.Text = "Nhà Cung Cấp";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(327, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 33);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà Cung Cấp Vaccine";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.ForeColor = Color.LightCyan;
            button3.Image = Properties.Resources.sync_8468966;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(335, 193);
            button3.Name = "button3";
            button3.Padding = new Padding(5, 0, 5, 0);
            button3.Size = new Size(210, 49);
            button3.TabIndex = 8;
            button3.Text = "Cập Nhật TT NCC";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Image = Properties.Resources.xoa;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(179, 193);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 5, 2);
            button2.Size = new Size(139, 49);
            button2.TabIndex = 7;
            button2.Text = "Xoá NCC";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Image = Properties.Resources.add2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(23, 193);
            button1.Name = "button1";
            button1.Padding = new Padding(5, 0, 5, 2);
            button1.Size = new Size(139, 49);
            button1.TabIndex = 6;
            button1.Text = "Tạo NCC";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
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
            // textBox3
            // 
            textBox3.Location = new Point(220, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 31);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HotTrack;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.WhiteSmoke;
            dataGridView1.Location = new Point(3, 577);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1757, 437);
            dataGridView1.TabIndex = 0;
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label9;
        private Label label6;
        private Label label2;
        private Button button2;
        private Button button3;
        private GroupBox groupBox5;
        private Label label11;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox6;
        private Button button9;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
        private Label label14;
        private GroupBox groupBox6;
        private Label label15;
        private ComboBox comboBox2;
        private TextBox textBox7;
        private Button button10;
        private Button button13;
        private Button button12;
        private Button button11;
    }
}