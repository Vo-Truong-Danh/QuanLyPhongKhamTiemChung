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
            button7 = new Button();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            label8 = new Label();
            txtTenLoaiVC = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tabPage1.Controls.Add(groupBox1);
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
            panel3.Controls.Add(groupBox3);
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
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 97);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.Control;
            button7.Image = Properties.Resources.timkiem;
            button7.Location = new Point(419, 33);
            button7.Name = "button7";
            button7.Size = new Size(61, 43);
            button7.TabIndex = 25;
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            textBox1.Location = new Point(66, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 34);
            textBox1.TabIndex = 24;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtTenLoaiVC);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 192);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại Vaccine";
            // 
            // button6
            // 
            button6.BackColor = Color.PaleTurquoise;
            button6.ForeColor = Color.Navy;
            button6.Image = Properties.Resources.cut;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(333, 105);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 5, 25, 5);
            button6.Size = new Size(147, 59);
            button6.TabIndex = 21;
            button6.Text = "Sửa";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Salmon;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.xoa;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(176, 105);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 5, 25, 5);
            button5.Size = new Size(147, 59);
            button5.TabIndex = 21;
            button5.Text = "Xoá";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Image = Properties.Resources.add2;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(19, 105);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 5, 15, 5);
            button4.Size = new Size(147, 59);
            button4.TabIndex = 21;
            button4.Text = "Thêm";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTenVaccine);
            groupBox1.Controls.Add(cboLoaiVaccine);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 534);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm Thông Tin Vaccine";
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.ForeColor = Color.Navy;
            button3.Image = Properties.Resources.cut;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(516, 426);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 5, 25, 5);
            button3.Size = new Size(147, 59);
            button3.TabIndex = 18;
            button3.Text = "Sửa";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.xoa;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(297, 426);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 5, 25, 5);
            button2.Size = new Size(147, 59);
            button2.TabIndex = 17;
            button2.Text = "Xoá";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Image = Properties.Resources.add2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(78, 426);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 5, 15, 5);
            button1.Size = new Size(147, 59);
            button1.TabIndex = 16;
            button1.Text = "Thêm";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
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
            dtpHSD.Location = new Point(3, 2);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
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
        private Button button1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private Panel panel3;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtTenLoaiVC;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private Button button7;
        private Button btnLoadTTVC;
        private Button btnLoadTTLoaiVaccine;
        private Button btnLoadGopTT;
        private GroupBox groupBox4;
    }
}