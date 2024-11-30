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
            this.btnThongTinChiTietBenhNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlThemBN = new System.Windows.Forms.Panel();
            this.pnlThongTinBenhNhan = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaBNinTTBN = new System.Windows.Forms.Button();
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
            this.dtpNgaySinhinTTBN = new System.Windows.Forms.DateTimePicker();
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
            // btnXoaBN
            // 
            this.btnXoaBN.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoaBN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaBN.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoaBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBN.Location = new System.Drawing.Point(251, 16);
            this.btnXoaBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaBN.Name = "btnXoaBN";
            this.btnXoaBN.Size = new System.Drawing.Size(152, 39);
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
            this.btnCapNhat.Location = new System.Drawing.Point(676, 468);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(236, 47);
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
            this.btnLuuBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLuuBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuuBN.Image = global::GUI.Properties.Resources.add2;
            this.btnLuuBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuBN.Location = new System.Drawing.Point(20, 16);
            this.btnLuuBN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuBN.Name = "btnLuuBN";
            this.btnLuuBN.Size = new System.Drawing.Size(174, 39);
            this.btnLuuBN.TabIndex = 13;
            this.btnLuuBN.Text = "Đăng kí khám bệnh";
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
            this.txtTimKiem.Location = new System.Drawing.Point(1077, 17);
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
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.timkiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(910, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 39);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 75);
            this.panel1.TabIndex = 18;
            // 
            // btnKQTiemChung
            // 
            this.btnKQTiemChung.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKQTiemChung.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnKQTiemChung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKQTiemChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKQTiemChung.ForeColor = System.Drawing.Color.Azure;
            this.btnKQTiemChung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKQTiemChung.Location = new System.Drawing.Point(664, 16);
            this.btnKQTiemChung.Margin = new System.Windows.Forms.Padding(2);
            this.btnKQTiemChung.Name = "btnKQTiemChung";
            this.btnKQTiemChung.Size = new System.Drawing.Size(189, 39);
            this.btnKQTiemChung.TabIndex = 18;
            this.btnKQTiemChung.Text = "In kết quả tiêm chủng";
            this.btnKQTiemChung.UseVisualStyleBackColor = false;
            this.btnKQTiemChung.Click += new System.EventHandler(this.btnKQTiemChung_Click);
            // 
            // btnThongTinChiTietBenhNhan
            // 
            this.btnThongTinChiTietBenhNhan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThongTinChiTietBenhNhan.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnThongTinChiTietBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChiTietBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThongTinChiTietBenhNhan.ForeColor = System.Drawing.Color.Azure;
            this.btnThongTinChiTietBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinChiTietBenhNhan.Location = new System.Drawing.Point(460, 16);
            this.btnThongTinChiTietBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinChiTietBenhNhan.Name = "btnThongTinChiTietBenhNhan";
            this.btnThongTinChiTietBenhNhan.Size = new System.Drawing.Size(147, 39);
            this.btnThongTinChiTietBenhNhan.TabIndex = 14;
            this.btnThongTinChiTietBenhNhan.Text = "Thông tin chi tiết";
            this.btnThongTinChiTietBenhNhan.UseVisualStyleBackColor = false;
            this.btnThongTinChiTietBenhNhan.Click += new System.EventHandler(this.btnThongTinChiTietBenhNhan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlThemBN);
            this.panel2.Controls.Add(this.lstvDSBN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1476, 613);
            this.panel2.TabIndex = 19;
            // 
            // pnlThemBN
            // 
            this.pnlThemBN.Controls.Add(this.pnlThongTinBenhNhan);
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
            this.pnlThemBN.Size = new System.Drawing.Size(1476, 613);
            this.pnlThemBN.TabIndex = 49;
            // 
            // pnlThongTinBenhNhan
            // 
            this.pnlThongTinBenhNhan.Controls.Add(this.dtpNgaySinhinTTBN);
            this.pnlThongTinBenhNhan.Controls.Add(this.label8);
            this.pnlThongTinBenhNhan.Controls.Add(this.button1);
            this.pnlThongTinBenhNhan.Controls.Add(this.btnXoaBNinTTBN);
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
            this.pnlThongTinBenhNhan.Size = new System.Drawing.Size(1476, 613);
            this.pnlThongTinBenhNhan.TabIndex = 64;          
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
            this.button1.Location = new System.Drawing.Point(565, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 78;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnXoaBNinTTBN
            // 
            this.btnXoaBNinTTBN.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaBNinTTBN.FlatAppearance.BorderSize = 0;
            this.btnXoaBNinTTBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBNinTTBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnXoaBNinTTBN.ForeColor = System.Drawing.Color.OldLace;
            this.btnXoaBNinTTBN.Location = new System.Drawing.Point(920, 468);
            this.btnXoaBNinTTBN.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaBNinTTBN.Name = "btnXoaBNinTTBN";
            this.btnXoaBNinTTBN.Size = new System.Drawing.Size(212, 47);
            this.btnXoaBNinTTBN.TabIndex = 77;
            this.btnXoaBNinTTBN.Text = "Xóa bệnh nhân";
            this.btnXoaBNinTTBN.UseVisualStyleBackColor = false;
            this.btnXoaBNinTTBN.Click += new System.EventHandler(this.btnXoaBNinTTBN_Click);
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
            this.txtSoDTinTTBN.Size = new System.Drawing.Size(333, 42);
            this.txtSoDTinTTBN.TabIndex = 71;
            this.txtSoDTinTTBN.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtHoTeninTTBN
            // 
            this.txtHoTeninTTBN.Location = new System.Drawing.Point(394, 217);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(538, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 54);
            this.label7.TabIndex = 63;
            this.label7.Text = "Thêm bệnh nhân mới";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(910, 426);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 47);
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
            this.btnThemBenhNhan.Location = new System.Drawing.Point(1016, 426);
            this.btnThemBenhNhan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemBenhNhan.Name = "btnThemBenhNhan";
            this.btnThemBenhNhan.Size = new System.Drawing.Size(238, 47);
            this.btnThemBenhNhan.TabIndex = 61;
            this.btnThemBenhNhan.Text = "Thêm bệnh nhân";
            this.btnThemBenhNhan.UseVisualStyleBackColor = false;
            this.btnThemBenhNhan.Click += new System.EventHandler(this.btnThemBenhNhan_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(216, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 36);
            this.label10.TabIndex = 60;
            this.label10.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(216, 166);
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
            this.dteNgaySinh.Location = new System.Drawing.Point(839, 166);
            this.dteNgaySinh.Margin = new System.Windows.Forms.Padding(117, 10, 117, 10);
            this.dteNgaySinh.Name = "dteNgaySinh";
            this.dteNgaySinh.Size = new System.Drawing.Size(414, 39);
            this.dteNgaySinh.TabIndex = 48;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(926, 255);
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
            this.rdoNu.Location = new System.Drawing.Point(1016, 255);
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
            this.txtDiaChi.Location = new System.Drawing.Point(337, 350);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(917, 38);
            this.txtDiaChi.TabIndex = 56;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(405, 257);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(333, 42);
            this.txtSoDT.TabIndex = 55;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(352, 165);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(316, 42);
            this.txtHoTen.TabIndex = 54;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 50;
            this.label2.Text = "Giới tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 351);
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
            this.lstvDSBN.Size = new System.Drawing.Size(1476, 614);
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
            this.columnHeader5.Width = 300;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 300;
            // 
            // dtpNgaySinhinTTBN
            // 
            this.dtpNgaySinhinTTBN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhinTTBN.Location = new System.Drawing.Point(890, 217);
            this.dtpNgaySinhinTTBN.Name = "dtpNgaySinhinTTBN";
            this.dtpNgaySinhinTTBN.Size = new System.Drawing.Size(242, 42);
            this.dtpNgaySinhinTTBN.TabIndex = 80;
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1476, 688);
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
            this.panel2.ResumeLayout(false);
            this.pnlThemBN.ResumeLayout(false);
            this.pnlThemBN.PerformLayout();
            this.pnlThongTinBenhNhan.ResumeLayout(false);
            this.pnlThongTinBenhNhan.PerformLayout();
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
        private Button btnXoaBNinTTBN;
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
    }
}