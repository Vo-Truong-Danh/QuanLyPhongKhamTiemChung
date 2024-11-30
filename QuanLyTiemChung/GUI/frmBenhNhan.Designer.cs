using System.Drawing;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBenhNhan));
            btnXoaBN = new Button();
            btnCapNhat = new Button();
            btnLuuBN = new Button();
            errMaSo = new ErrorProvider(components);
            errHoTen = new ErrorProvider(components);
            errDiaChi = new ErrorProvider(components);
            errSoDienThoai = new ErrorProvider(components);
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnThongTinChiTietBenhNhan = new Button();
            panel2 = new Panel();
            pnlThongtinBN = new Panel();
            pnlThongTinBenhNhan = new Panel();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            label9 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label7 = new Label();
            btnDong = new Button();
            btnThemBenhNhan = new Button();
            label10 = new Label();
            label6 = new Label();
            dteNgaySinh = new DateTimePicker();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            txtDiaChi = new TextBox();
            txtSoDT = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstvDSBN = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)errMaSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDiaChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSoDienThoai).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlThongtinBN.SuspendLayout();
            pnlThongTinBenhNhan.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoaBN
            // 
            btnXoaBN.Anchor = AnchorStyles.None;
            btnXoaBN.BackColor = Color.Salmon;
            btnXoaBN.FlatStyle = FlatStyle.Flat;
            btnXoaBN.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoaBN.ForeColor = SystemColors.ControlLightLight;
            btnXoaBN.Image = Properties.Resources.xoa;
            btnXoaBN.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaBN.Location = new Point(431, 20);
            btnXoaBN.Margin = new Padding(2);
            btnXoaBN.Name = "btnXoaBN";
            btnXoaBN.Size = new Size(193, 49);
            btnXoaBN.TabIndex = 15;
            btnXoaBN.Text = "Xóa bệnh nhân";
            btnXoaBN.TextAlign = ContentAlignment.MiddleRight;
            btnXoaBN.UseVisualStyleBackColor = false;
            btnXoaBN.Click += btnXoaBN_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.None;
            btnCapNhat.BackColor = Color.PaleTurquoise;
            btnCapNhat.FlatAppearance.BorderColor = Color.PaleTurquoise;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 13F);
            btnCapNhat.ForeColor = Color.Navy;
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(896, 586);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(246, 59);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật thông tin";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLuuBN
            // 
            btnLuuBN.Anchor = AnchorStyles.None;
            btnLuuBN.BackColor = Color.Aquamarine;
            btnLuuBN.FlatAppearance.BorderColor = Color.Aquamarine;
            btnLuuBN.FlatStyle = FlatStyle.Flat;
            btnLuuBN.Font = new Font("Microsoft Sans Serif", 10F);
            btnLuuBN.ForeColor = SystemColors.ActiveCaptionText;
            btnLuuBN.Image = Properties.Resources.add2;
            btnLuuBN.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuBN.Location = new Point(109, 20);
            btnLuuBN.Margin = new Padding(2);
            btnLuuBN.Name = "btnLuuBN";
            btnLuuBN.Size = new Size(223, 49);
            btnLuuBN.TabIndex = 13;
            btnLuuBN.Text = "Đăng kí khám bệnh";
            btnLuuBN.TextAlign = ContentAlignment.MiddleRight;
            btnLuuBN.UseVisualStyleBackColor = false;
            btnLuuBN.Click += btnLuuBN_Click;
            // 
            // errMaSo
            // 
            errMaSo.ContainerControl = this;
            // 
            // errHoTen
            // 
            errHoTen.ContainerControl = this;
            // 
            // errDiaChi
            // 
            errDiaChi.ContainerControl = this;
            // 
            // errSoDienThoai
            // 
            errSoDienThoai.ContainerControl = this;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(1197, 26);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(395, 37);
            txtTimKiem.TabIndex = 6;
            txtTimKiem.Text = "Tên bệnh nhân";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.Gold;
            btnTimKiem.FlatAppearance.BorderColor = Color.Gold;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 11F);
            btnTimKiem.ForeColor = Color.MidnightBlue;
            btnTimKiem.Image = Properties.Resources.timkiem;
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(1018, 20);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(151, 49);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLuuBN);
            panel1.Controls.Add(btnXoaBN);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnThongTinChiTietBenhNhan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1640, 94);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnThongTinChiTietBenhNhan
            // 
            btnThongTinChiTietBenhNhan.Anchor = AnchorStyles.None;
            btnThongTinChiTietBenhNhan.BackColor = Color.LightSeaGreen;
            btnThongTinChiTietBenhNhan.FlatAppearance.BorderColor = Color.PaleTurquoise;
            btnThongTinChiTietBenhNhan.FlatStyle = FlatStyle.Flat;
            btnThongTinChiTietBenhNhan.Font = new Font("Microsoft Sans Serif", 10F);
            btnThongTinChiTietBenhNhan.ForeColor = Color.Azure;
            btnThongTinChiTietBenhNhan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinChiTietBenhNhan.Location = new Point(723, 20);
            btnThongTinChiTietBenhNhan.Margin = new Padding(2);
            btnThongTinChiTietBenhNhan.Name = "btnThongTinChiTietBenhNhan";
            btnThongTinChiTietBenhNhan.Size = new Size(196, 49);
            btnThongTinChiTietBenhNhan.TabIndex = 14;
            btnThongTinChiTietBenhNhan.Text = "Thông tin chi tiết";
            btnThongTinChiTietBenhNhan.TextAlign = ContentAlignment.MiddleRight;
            btnThongTinChiTietBenhNhan.UseVisualStyleBackColor = false;
            btnThongTinChiTietBenhNhan.Click += btnCapNhat_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlThongtinBN);
            panel2.Controls.Add(lstvDSBN);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(1640, 766);
            panel2.TabIndex = 19;
            // 
            // pnlThongtinBN
            // 
            pnlThongtinBN.Controls.Add(pnlThongTinBenhNhan);
            pnlThongtinBN.Controls.Add(label7);
            pnlThongtinBN.Controls.Add(btnDong);
            pnlThongtinBN.Controls.Add(btnThemBenhNhan);
            pnlThongtinBN.Controls.Add(label10);
            pnlThongtinBN.Controls.Add(label6);
            pnlThongtinBN.Controls.Add(dteNgaySinh);
            pnlThongtinBN.Controls.Add(rdoNam);
            pnlThongtinBN.Controls.Add(rdoNu);
            pnlThongtinBN.Controls.Add(txtDiaChi);
            pnlThongtinBN.Controls.Add(txtSoDT);
            pnlThongtinBN.Controls.Add(txtHoTen);
            pnlThongtinBN.Controls.Add(label5);
            pnlThongtinBN.Controls.Add(label4);
            pnlThongtinBN.Controls.Add(label3);
            pnlThongtinBN.Controls.Add(label2);
            pnlThongtinBN.Controls.Add(label1);
            pnlThongtinBN.Dock = DockStyle.Fill;
            pnlThongtinBN.Font = new Font("Segoe UI", 13F);
            pnlThongtinBN.Location = new Point(0, 0);
            pnlThongtinBN.Name = "pnlThongtinBN";
            pnlThongtinBN.Size = new Size(1640, 766);
            pnlThongtinBN.TabIndex = 49;
            // 
            // pnlThongTinBenhNhan
            // 
            pnlThongTinBenhNhan.Controls.Add(label8);
            pnlThongTinBenhNhan.Controls.Add(button1);
            pnlThongTinBenhNhan.Controls.Add(button2);
            pnlThongTinBenhNhan.Controls.Add(label9);
            pnlThongTinBenhNhan.Controls.Add(label11);
            pnlThongTinBenhNhan.Controls.Add(dateTimePicker1);
            pnlThongTinBenhNhan.Controls.Add(btnCapNhat);
            pnlThongTinBenhNhan.Controls.Add(radioButton1);
            pnlThongTinBenhNhan.Controls.Add(radioButton2);
            pnlThongTinBenhNhan.Controls.Add(textBox1);
            pnlThongTinBenhNhan.Controls.Add(textBox2);
            pnlThongTinBenhNhan.Controls.Add(textBox3);
            pnlThongTinBenhNhan.Controls.Add(label12);
            pnlThongTinBenhNhan.Controls.Add(label13);
            pnlThongTinBenhNhan.Controls.Add(label14);
            pnlThongTinBenhNhan.Controls.Add(label15);
            pnlThongTinBenhNhan.Controls.Add(label16);
            pnlThongTinBenhNhan.Dock = DockStyle.Fill;
            pnlThongTinBenhNhan.Location = new Point(0, 0);
            pnlThongTinBenhNhan.Name = "pnlThongTinBenhNhan";
            pnlThongTinBenhNhan.Size = new Size(1640, 766);
            pnlThongTinBenhNhan.TabIndex = 64;
            pnlThongTinBenhNhan.Paint += pnlThongTinBenhNhan_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.Location = new Point(606, 94);
            label8.Name = "label8";
            label8.Size = new Size(416, 54);
            label8.TabIndex = 79;
            label8.Text = "Thông tin bệnh nhân";
            // 
            // button1
            // 
            button1.Location = new Point(766, 586);
            button1.Name = "button1";
            button1.Size = new Size(112, 59);
            button1.TabIndex = 78;
            button1.Text = "Đóng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            button2.ForeColor = Color.OldLace;
            button2.Location = new Point(1160, 586);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(236, 59);
            button2.TabIndex = 77;
            button2.Text = "Xóa bệnh nhân";
            button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(244, 368);
            label9.Name = "label9";
            label9.Size = new Size(26, 36);
            label9.TabIndex = 76;
            label9.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(244, 255);
            label11.Name = "label11";
            label11.Size = new Size(26, 36);
            label11.TabIndex = 75;
            label11.Text = "*";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(936, 255);
            dateTimePicker1.Margin = new Padding(130, 13, 130, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(460, 39);
            dateTimePicker1.TabIndex = 64;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1033, 366);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 40);
            radioButton1.TabIndex = 74;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(1133, 366);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 40);
            radioButton2.TabIndex = 73;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 484);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1018, 46);
            textBox1.TabIndex = 72;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 368);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 42);
            textBox2.TabIndex = 71;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(395, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 42);
            textBox3.TabIndex = 70;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(770, 256);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(142, 36);
            label12.TabIndex = 69;
            label12.Text = "Ngày sinh :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(265, 371);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(179, 36);
            label13.TabIndex = 68;
            label13.Text = "Số điện thoại :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(265, 256);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(106, 36);
            label14.TabIndex = 67;
            label14.Text = "Họ tên :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(900, 368);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(126, 36);
            label15.TabIndex = 66;
            label15.Text = "Giới tính :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(265, 486);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(105, 36);
            label16.TabIndex = 65;
            label16.Text = "Địa chỉ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label7.Location = new Point(598, 81);
            label7.Name = "label7";
            label7.Size = new Size(424, 54);
            label7.TabIndex = 63;
            label7.Text = "Thêm bệnh nhân mới";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(1011, 532);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(112, 59);
            btnDong.TabIndex = 62;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click_1;
            // 
            // btnThemBenhNhan
            // 
            btnThemBenhNhan.BackColor = Color.DarkSlateGray;
            btnThemBenhNhan.FlatAppearance.BorderSize = 0;
            btnThemBenhNhan.FlatStyle = FlatStyle.Flat;
            btnThemBenhNhan.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnThemBenhNhan.ForeColor = Color.OldLace;
            btnThemBenhNhan.Location = new Point(1156, 532);
            btnThemBenhNhan.Margin = new Padding(0);
            btnThemBenhNhan.Name = "btnThemBenhNhan";
            btnThemBenhNhan.Size = new Size(236, 59);
            btnThemBenhNhan.TabIndex = 61;
            btnThemBenhNhan.Text = "Thêm bệnh nhân";
            btnThemBenhNhan.UseVisualStyleBackColor = false;
            btnThemBenhNhan.Click += btnThemBenhNhan_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(240, 321);
            label10.Name = "label10";
            label10.Size = new Size(26, 36);
            label10.TabIndex = 60;
            label10.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(240, 208);
            label6.Name = "label6";
            label6.Size = new Size(26, 36);
            label6.TabIndex = 59;
            label6.Text = "*";
            // 
            // dteNgaySinh
            // 
            dteNgaySinh.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteNgaySinh.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dteNgaySinh.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dteNgaySinh.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteNgaySinh.Location = new Point(932, 208);
            dteNgaySinh.Margin = new Padding(130, 13, 130, 13);
            dteNgaySinh.Name = "dteNgaySinh";
            dteNgaySinh.Size = new Size(460, 39);
            dteNgaySinh.TabIndex = 48;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(1029, 319);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(94, 40);
            rdoNam.TabIndex = 58;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(1129, 319);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(74, 40);
            rdoNu.TabIndex = 57;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(374, 437);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(1018, 46);
            txtDiaChi.TabIndex = 56;
            // 
            // txtSoDT
            // 
            txtSoDT.Location = new Point(450, 321);
            txtSoDT.Name = "txtSoDT";
            txtSoDT.Size = new Size(370, 42);
            txtSoDT.TabIndex = 55;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(391, 206);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(351, 42);
            txtHoTen.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(766, 209);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 36);
            label5.TabIndex = 53;
            label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 324);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 36);
            label4.TabIndex = 52;
            label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 36);
            label3.TabIndex = 51;
            label3.Text = "Họ tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(896, 321);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 36);
            label2.TabIndex = 50;
            label2.Text = "Giới tính :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 439);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 36);
            label1.TabIndex = 49;
            label1.Text = "Địa chỉ :";
            // 
            // lstvDSBN
            // 
            lstvDSBN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvDSBN.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstvDSBN.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstvDSBN.FullRowSelect = true;
            lstvDSBN.Location = new Point(0, 0);
            lstvDSBN.Margin = new Padding(2);
            lstvDSBN.Name = "lstvDSBN";
            lstvDSBN.Size = new Size(1640, 766);
            lstvDSBN.TabIndex = 17;
            lstvDSBN.UseCompatibleStateImageBehavior = false;
            lstvDSBN.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giới tính";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Địa chỉ";
            columnHeader5.Width = 750;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số điện thoại";
            columnHeader6.Width = 400;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1640, 860);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "frmBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách bệnh nhân";
            FormClosing += frmBenhNhan_FormClosing;
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)errMaSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDiaChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSoDienThoai).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pnlThongtinBN.ResumeLayout(false);
            pnlThongtinBN.PerformLayout();
            pnlThongTinBenhNhan.ResumeLayout(false);
            pnlThongTinBenhNhan.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Panel pnlThongtinBN;
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
        private Button button2;
        private Label label9;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}