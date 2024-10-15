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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVaccine));
            dgvVaccine = new DataGridView();
            tctChinh = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            btnLoadTTLoaiVaccine = new Button();
            btnLoadGopTT = new Button();
            btnLoadTTVC = new Button();
            groupBox2 = new GroupBox();
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
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            tctChinh.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            grbLoaiVC.SuspendLayout();
            grbTTVC.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVaccine
            // 
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaccine.Dock = DockStyle.Bottom;
            dgvVaccine.Location = new Point(3, 537);
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
            tctChinh.Size = new Size(1771, 1048);
            tctChinh.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(grbTTVC);
            tabPage1.Controls.Add(dgvVaccine);
            tabPage1.ImageIndex = 1;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1763, 1010);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kho Vaccine";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(grbLoaiVC);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(746, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 534);
            panel3.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnLoadTTLoaiVaccine);
            groupBox4.Controls.Add(btnLoadGopTT);
            groupBox4.Controls.Add(btnLoadTTVC);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 289);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(504, 245);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Load";
            // 
            // btnLoadTTLoaiVaccine
            // 
            btnLoadTTLoaiVaccine.BackColor = Color.Aquamarine;
            btnLoadTTLoaiVaccine.Image = Properties.Resources.load;
            btnLoadTTLoaiVaccine.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadTTLoaiVaccine.Location = new Point(39, 132);
            btnLoadTTLoaiVaccine.Name = "btnLoadTTLoaiVaccine";
            btnLoadTTLoaiVaccine.Padding = new Padding(15, 5, 15, 5);
            btnLoadTTLoaiVaccine.Size = new Size(293, 59);
            btnLoadTTLoaiVaccine.TabIndex = 25;
            btnLoadTTLoaiVaccine.Text = "Thông Tin Loại Vaccine";
            btnLoadTTLoaiVaccine.TextAlign = ContentAlignment.MiddleRight;
            btnLoadTTLoaiVaccine.UseVisualStyleBackColor = false;
            btnLoadTTLoaiVaccine.Click += btnLoadTTLoaiVaccine_Click;
            // 
            // btnLoadGopTT
            // 
            btnLoadGopTT.BackColor = Color.Aquamarine;
            btnLoadGopTT.Image = Properties.Resources.load;
            btnLoadGopTT.Location = new Point(361, 35);
            btnLoadGopTT.Name = "btnLoadGopTT";
            btnLoadGopTT.Padding = new Padding(15, 5, 15, 5);
            btnLoadGopTT.Size = new Size(118, 171);
            btnLoadGopTT.TabIndex = 26;
            btnLoadGopTT.Text = "Thông Tin Đầy Đủ Vaccine";
            btnLoadGopTT.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLoadGopTT.UseVisualStyleBackColor = false;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 97);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
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
            // 
            // txtSearch
            // 
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
            grbTTVC.Size = new Size(743, 534);
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
            btnSuaTTVC.Location = new Point(516, 426);
            btnSuaTTVC.Name = "btnSuaTTVC";
            btnSuaTTVC.Padding = new Padding(15, 5, 25, 5);
            btnSuaTTVC.Size = new Size(147, 59);
            btnSuaTTVC.TabIndex = 18;
            btnSuaTTVC.Text = "Sửa";
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
            btnXoaTTVC.Location = new Point(297, 426);
            btnXoaTTVC.Name = "btnXoaTTVC";
            btnXoaTTVC.Padding = new Padding(15, 5, 25, 5);
            btnXoaTTVC.Size = new Size(147, 59);
            btnXoaTTVC.TabIndex = 17;
            btnXoaTTVC.Text = "Xoá";
            btnXoaTTVC.TextAlign = ContentAlignment.MiddleRight;
            btnXoaTTVC.UseVisualStyleBackColor = false;
            btnXoaTTVC.Click += btnXoaTTVC_Click;
            // 
            // btnThemTTVC
            // 
            btnThemTTVC.BackColor = Color.Aquamarine;
            btnThemTTVC.Image = Properties.Resources.add2;
            btnThemTTVC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemTTVC.Location = new Point(78, 426);
            btnThemTTVC.Name = "btnThemTTVC";
            btnThemTTVC.Padding = new Padding(15, 5, 15, 5);
            btnThemTTVC.Size = new Size(147, 59);
            btnThemTTVC.TabIndex = 16;
            btnThemTTVC.Text = "Thêm";
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
            tabPage2.ImageIndex = 0;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1763, 1015);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nhập Vaccine";
            tabPage2.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1771, 1048);
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
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grbLoaiVC.ResumeLayout(false);
            grbLoaiVC.PerformLayout();
            grbTTVC.ResumeLayout(false);
            grbTTVC.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private GroupBox groupBox2;
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
        private Button btnLoadGopTT;
        private GroupBox groupBox4;
    }
}