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
            groupBox1 = new GroupBox();
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            tctChinh.SuspendLayout();
            tabPage1.SuspendLayout();
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
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVaccine.Size = new Size(1086, 470);
            dgvVaccine.TabIndex = 0;
            // 
            // tctChinh
            // 
            tctChinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tctChinh.Controls.Add(tabPage1);
            tctChinh.Controls.Add(tabPage2);
            tctChinh.ImageList = imageList1;
            tctChinh.Location = new Point(0, 0);
            tctChinh.Name = "tctChinh";
            tctChinh.SelectedIndex = 0;
            tctChinh.Size = new Size(1100, 1048);
            tctChinh.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dgvVaccine);
            tabPage1.ImageIndex = 1;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1092, 1010);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kho Vaccine";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(dtpHSD);
            panel2.ForeColor = Color.Red;
            panel2.Location = new Point(300, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 40);
            panel2.TabIndex = 15;
            // 
            // dtpHSD
            // 
            dtpHSD.CalendarForeColor = Color.MediumSpringGreen;
            dtpHSD.CalendarMonthBackground = Color.MediumSpringGreen;
            dtpHSD.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            dtpHSD.Location = new Point(3, 4);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(398, 34);
            dtpHSD.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSpringGreen;
            panel1.Controls.Add(dtpNSX);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(297, 199);
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
            label7.Location = new Point(62, 372);
            label7.Name = "label7";
            label7.Size = new Size(45, 27);
            label7.TabIndex = 13;
            label7.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label5.Location = new Point(48, 290);
            label5.Name = "label5";
            label5.Size = new Size(143, 27);
            label5.TabIndex = 11;
            label5.Text = "Hạn Sử Dụng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.Location = new Point(48, 208);
            label4.Name = "label4";
            label4.Size = new Size(161, 27);
            label4.TabIndex = 10;
            label4.Text = "Ngày Sản Xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.Location = new Point(48, 126);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 9;
            label3.Text = "Tên Vaccine";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(137, 27);
            label1.TabIndex = 7;
            label1.Text = "Loại Vaccine";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtGia.Location = new Point(297, 369);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(404, 34);
            txtGia.TabIndex = 6;
            // 
            // txtTenVaccine
            // 
            txtTenVaccine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            txtTenVaccine.Location = new Point(297, 120);
            txtTenVaccine.Name = "txtTenVaccine";
            txtTenVaccine.Size = new Size(404, 34);
            txtTenVaccine.TabIndex = 2;
            // 
            // cboLoaiVaccine
            // 
            cboLoaiVaccine.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            cboLoaiVaccine.FormattingEnabled = true;
            cboLoaiVaccine.Location = new Point(297, 40);
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
            tabPage2.Size = new Size(1092, 1015);
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
            // button1
            // 
            button1.Location = new Point(52, 451);
            button1.Name = "button1";
            button1.Size = new Size(173, 54);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmQLVaccine
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 1048);
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
    }
}