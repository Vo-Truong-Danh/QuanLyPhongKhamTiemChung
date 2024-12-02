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
            this.components = new System.ComponentModel.Container();
            this.errMaSo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKQTiemChung = new System.Windows.Forms.Button();
            this.btnLuuBN = new System.Windows.Forms.Button();
            this.btnXoaBN = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThongTinChiTietBenhNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlThemBN = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHoTeninTTBN = new System.Windows.Forms.TextBox();
            this.txtSoDTinTTBN = new System.Windows.Forms.TextBox();
            this.txtDiaChiinTTBN = new System.Windows.Forms.TextBox();
            this.rdoNuinTTBN = new System.Windows.Forms.RadioButton();
            this.rdoNaminTTBN = new System.Windows.Forms.RadioButton();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNgaySinhinTTBN = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlThongTinBenhNhan = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errMaSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoDienThoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlThemBN.SuspendLayout();
            this.pnlThongTinBenhNhan.SuspendLayout();
            this.SuspendLayout();
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
            this.txtTimKiem.Location = new System.Drawing.Point(1436, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(473, 47);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.Text = "Tên bệnh nhân";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKQTiemChung);
            this.panel1.Controls.Add(this.btnLuuBN);
            this.panel1.Controls.Add(this.btnXoaBN);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnThongTinChiTietBenhNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2515, 94);
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
            this.btnKQTiemChung.Location = new System.Drawing.Point(975, 20);
            this.btnKQTiemChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKQTiemChung.Name = "btnKQTiemChung";
            this.btnKQTiemChung.Size = new System.Drawing.Size(252, 49);
            this.btnKQTiemChung.TabIndex = 18;
            this.btnKQTiemChung.Text = "In kết quả tiêm chủng";
            this.btnKQTiemChung.UseVisualStyleBackColor = false;
            this.btnKQTiemChung.Click += new System.EventHandler(this.btnKQTiemChung_Click_1);
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
            this.btnLuuBN.Click += new System.EventHandler(this.btnLuuBN_Click);
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
            this.btnXoaBN.Click += new System.EventHandler(this.btnXoaBN_Click);
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
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
            this.btnThongTinChiTietBenhNhan.Click += new System.EventHandler(this.btnThongTinChiTietBenhNhan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlThongTinBenhNhan);
            this.panel2.Controls.Add(this.pnlThemBN);
            this.panel2.Controls.Add(this.lstvDSBN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2515, 1120);
            this.panel2.TabIndex = 19;
            // 
            // pnlThemBN
            // 
            this.pnlThemBN.Controls.Add(this.panel3);
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
            this.pnlThemBN.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.pnlThemBN.Location = new System.Drawing.Point(0, 0);
            this.pnlThemBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlThemBN.Name = "pnlThemBN";
            this.pnlThemBN.Size = new System.Drawing.Size(1474, 1120);
            this.pnlThemBN.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 810);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1474, 310);
            this.panel3.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(323, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 72);
            this.label7.TabIndex = 63;
            this.label7.Text = "Đăng ký tiêm";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(225, 628);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 60);
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
            this.btnThemBenhNhan.Location = new System.Drawing.Point(399, 628);
            this.btnThemBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemBenhNhan.Name = "btnThemBenhNhan";
            this.btnThemBenhNhan.Size = new System.Drawing.Size(317, 60);
            this.btnThemBenhNhan.TabIndex = 61;
            this.btnThemBenhNhan.Text = "Thêm bệnh nhân";
            this.btnThemBenhNhan.UseVisualStyleBackColor = false;
            this.btnThemBenhNhan.Click += new System.EventHandler(this.btnThemBenhNhan_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(24, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 47);
            this.label10.TabIndex = 60;
            this.label10.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 47);
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
            this.dteNgaySinh.Location = new System.Drawing.Point(249, 465);
            this.dteNgaySinh.Margin = new System.Windows.Forms.Padding(156, 12, 156, 12);
            this.dteNgaySinh.Name = "dteNgaySinh";
            this.dteNgaySinh.Size = new System.Drawing.Size(513, 49);
            this.dteNgaySinh.TabIndex = 48;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(251, 530);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(125, 51);
            this.rdoNam.TabIndex = 58;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(371, 530);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(98, 51);
            this.rdoNu.TabIndex = 57;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(187, 385);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(579, 46);
            this.txtDiaChi.TabIndex = 56;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(288, 268);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(476, 54);
            this.txtSoDT.TabIndex = 55;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(205, 152);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(559, 54);
            this.txtHoTen.TabIndex = 54;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 47);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 47);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 47);
            this.label3.TabIndex = 51;
            this.label3.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 532);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 47);
            this.label2.TabIndex = 50;
            this.label2.Text = "Giới tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 47);
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
            this.lstvDSBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvDSBN.Name = "lstvDSBN";
            this.lstvDSBN.Size = new System.Drawing.Size(2512, 1119);
            this.lstvDSBN.TabIndex = 17;
            this.lstvDSBN.UseCompatibleStateImageBehavior = false;
            this.lstvDSBN.View = System.Windows.Forms.View.Details;
            this.lstvDSBN.SelectedIndexChanged += new System.EventHandler(this.btnThongTinChiTietBenhNhan_Click);
            this.lstvDSBN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvDSBN_MouseDoubleClick);
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(368, 505);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 25);
            this.label24.TabIndex = 65;
            this.label24.Text = "Địa chỉ :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1131, 386);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 25);
            this.label23.TabIndex = 66;
            this.label23.Text = "Giới tính :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(368, 275);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 25);
            this.label22.TabIndex = 67;
            this.label22.Text = "Họ tên :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(368, 390);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 25);
            this.label21.TabIndex = 68;
            this.label21.Text = "Số điện thoại :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(975, 275);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 25);
            this.label20.TabIndex = 69;
            this.label20.Text = "Ngày sinh :";
            // 
            // txtHoTeninTTBN
            // 
            this.txtHoTeninTTBN.Location = new System.Drawing.Point(525, 272);
            this.txtHoTeninTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtHoTeninTTBN.Name = "txtHoTeninTTBN";
            this.txtHoTeninTTBN.Size = new System.Drawing.Size(420, 31);
            this.txtHoTeninTTBN.TabIndex = 70;
            // 
            // txtSoDTinTTBN
            // 
            this.txtSoDTinTTBN.Location = new System.Drawing.Point(629, 386);
            this.txtSoDTinTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoDTinTTBN.Name = "txtSoDTinTTBN";
            this.txtSoDTinTTBN.Size = new System.Drawing.Size(441, 31);
            this.txtSoDTinTTBN.TabIndex = 71;
            // 
            // txtDiaChiinTTBN
            // 
            this.txtDiaChiinTTBN.Location = new System.Drawing.Point(504, 502);
            this.txtDiaChiinTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDiaChiinTTBN.Multiline = true;
            this.txtDiaChiinTTBN.Name = "txtDiaChiinTTBN";
            this.txtDiaChiinTTBN.Size = new System.Drawing.Size(1004, 46);
            this.txtDiaChiinTTBN.TabIndex = 72;
            // 
            // rdoNuinTTBN
            // 
            this.rdoNuinTTBN.AutoSize = true;
            this.rdoNuinTTBN.Location = new System.Drawing.Point(1411, 385);
            this.rdoNuinTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoNuinTTBN.Name = "rdoNuinTTBN";
            this.rdoNuinTTBN.Size = new System.Drawing.Size(70, 29);
            this.rdoNuinTTBN.TabIndex = 73;
            this.rdoNuinTTBN.TabStop = true;
            this.rdoNuinTTBN.Text = "Nữ";
            this.rdoNuinTTBN.UseVisualStyleBackColor = true;
            // 
            // rdoNaminTTBN
            // 
            this.rdoNaminTTBN.AutoSize = true;
            this.rdoNaminTTBN.Location = new System.Drawing.Point(1291, 385);
            this.rdoNaminTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rdoNaminTTBN.Name = "rdoNaminTTBN";
            this.rdoNaminTTBN.Size = new System.Drawing.Size(87, 29);
            this.rdoNaminTTBN.TabIndex = 74;
            this.rdoNaminTTBN.TabStop = true;
            this.rdoNaminTTBN.Text = "Nam";
            this.rdoNaminTTBN.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.Navy;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(901, 585);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(315, 60);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(344, 274);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 25);
            this.label19.TabIndex = 75;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(344, 386);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 25);
            this.label18.TabIndex = 76;
            this.label18.Text = "*";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.OldLace;
            this.button4.Location = new System.Drawing.Point(1227, 585);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 60);
            this.button4.TabIndex = 77;
            this.button4.Text = "Xóa bệnh nhân";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnXoaBNinTTBN_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(777, 112);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(564, 72);
            this.label17.TabIndex = 79;
            this.label17.Text = "Thông tin bệnh nhân";
            // 
            // dtpNgaySinhinTTBN
            // 
            this.dtpNgaySinhinTTBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhinTTBN.Location = new System.Drawing.Point(1187, 272);
            this.dtpNgaySinhinTTBN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgaySinhinTTBN.Name = "dtpNgaySinhinTTBN";
            this.dtpNgaySinhinTTBN.Size = new System.Drawing.Size(321, 31);
            this.dtpNgaySinhinTTBN.TabIndex = 80;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 64);
            this.button2.TabIndex = 82;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlThongTinBenhNhan
            // 
            this.pnlThongTinBenhNhan.Controls.Add(this.button2);
            this.pnlThongTinBenhNhan.Controls.Add(this.dtpNgaySinhinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.label17);
            this.pnlThongTinBenhNhan.Controls.Add(this.button4);
            this.pnlThongTinBenhNhan.Controls.Add(this.label18);
            this.pnlThongTinBenhNhan.Controls.Add(this.label19);
            this.pnlThongTinBenhNhan.Controls.Add(this.btnCapNhat);
            this.pnlThongTinBenhNhan.Controls.Add(this.rdoNaminTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.rdoNuinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtDiaChiinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtSoDTinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.txtHoTeninTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.label20);
            this.pnlThongTinBenhNhan.Controls.Add(this.label21);
            this.pnlThongTinBenhNhan.Controls.Add(this.label22);
            this.pnlThongTinBenhNhan.Controls.Add(this.label23);
            this.pnlThongTinBenhNhan.Controls.Add(this.label24);
            this.pnlThongTinBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinBenhNhan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlThongTinBenhNhan.Name = "pnlThongTinBenhNhan";
            this.pnlThongTinBenhNhan.Size = new System.Drawing.Size(2515, 1120);
            this.pnlThongTinBenhNhan.TabIndex = 71;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2515, 1214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel2.ResumeLayout(false);
            this.pnlThemBN.ResumeLayout(false);
            this.pnlThemBN.PerformLayout();
            this.pnlThongTinBenhNhan.ResumeLayout(false);
            this.pnlThongTinBenhNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnXoaBN;
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
        private Button btnKQTiemChung;
        private Panel panel3;
        private Panel pnlThongTinBenhNhan;
        private Button button2;
        private DateTimePicker dtpNgaySinhinTTBN;
        private Label label17;
        private Button button4;
        private Label label18;
        private Label label19;
        private Button btnCapNhat;
        private RadioButton rdoNaminTTBN;
        private RadioButton rdoNuinTTBN;
        private TextBox txtDiaChiinTTBN;
        private TextBox txtSoDTinTTBN;
        private TextBox txtHoTeninTTBN;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
    }
}