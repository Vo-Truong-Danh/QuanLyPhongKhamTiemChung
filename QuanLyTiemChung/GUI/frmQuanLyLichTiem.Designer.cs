namespace GUI
{
    partial class frmQuanLyLichTiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLichTiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TimeTab3 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerTB = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.pnlTb = new System.Windows.Forms.Panel();
            this.lblndtb = new System.Windows.Forms.Label();
            this.dgvLichTiem = new System.Windows.Forms.DataGridView();
            this.cntXoaSua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CapNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabKhoVaccine = new System.Windows.Forms.TabPage();
            this.tctChinh = new System.Windows.Forms.TabControl();
            this.timerTB_Tab2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInLichSuTiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlThongBao.SuspendLayout();
            this.pnlTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTiem)).BeginInit();
            this.cntXoaSua.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            this.tabKhoVaccine.SuspendLayout();
            this.tctChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeTab3
            // 
            this.TimeTab3.Interval = 4000;
            // 
            // timerTB
            // 
            this.timerTB.Interval = 4000;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vaccination_5106376.png");
            this.imageList1.Images.SetKeyName(1, "khovc.png");
            this.imageList1.Images.SetKeyName(2, "more_6512218.png");
            this.imageList1.Images.SetKeyName(3, "appointment_16951807.png");
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.White;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đã tiêm",
            "Chưa tiêm"});
            this.cboTrangThai.Location = new System.Drawing.Point(23, 9);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(218, 33);
            this.cboTrangThai.TabIndex = 0;
            this.cboTrangThai.SelectionChangeCommitted += new System.EventHandler(this.cboTrangThai_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlThongBao);
            this.panel1.Controls.Add(this.dgvLichTiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 577);
            this.panel1.TabIndex = 6;
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongBao.BackColor = System.Drawing.Color.DimGray;
            this.pnlThongBao.Controls.Add(this.pnlTb);
            this.pnlThongBao.Location = new System.Drawing.Point(857, 433);
            this.pnlThongBao.Name = "pnlThongBao";
            this.pnlThongBao.Size = new System.Drawing.Size(555, 102);
            this.pnlThongBao.TabIndex = 2;
            this.pnlThongBao.Visible = false;
            // 
            // pnlTb
            // 
            this.pnlTb.BackColor = System.Drawing.Color.White;
            this.pnlTb.Controls.Add(this.pictureBox1);
            this.pnlTb.Controls.Add(this.lblndtb);
            this.pnlTb.Location = new System.Drawing.Point(2, 2);
            this.pnlTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTb.Name = "pnlTb";
            this.pnlTb.Size = new System.Drawing.Size(550, 98);
            this.pnlTb.TabIndex = 30;
            // 
            // lblndtb
            // 
            this.lblndtb.Location = new System.Drawing.Point(97, 22);
            this.lblndtb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblndtb.Name = "lblndtb";
            this.lblndtb.Size = new System.Drawing.Size(434, 54);
            this.lblndtb.TabIndex = 0;
            this.lblndtb.Text = "Thông báo";
            // 
            // dgvLichTiem
            // 
            this.dgvLichTiem.AllowUserToAddRows = false;
            this.dgvLichTiem.AllowUserToDeleteRows = false;
            this.dgvLichTiem.AllowUserToResizeColumns = false;
            this.dgvLichTiem.AllowUserToResizeRows = false;
            this.dgvLichTiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichTiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichTiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichTiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichTiem.ColumnHeadersHeight = 29;
            this.dgvLichTiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichTiem.ContextMenuStrip = this.cntXoaSua;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichTiem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichTiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichTiem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvLichTiem.EnableHeadersVisualStyles = false;
            this.dgvLichTiem.Location = new System.Drawing.Point(0, 0);
            this.dgvLichTiem.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLichTiem.MultiSelect = false;
            this.dgvLichTiem.Name = "dgvLichTiem";
            this.dgvLichTiem.ReadOnly = true;
            this.dgvLichTiem.RowHeadersVisible = false;
            this.dgvLichTiem.RowHeadersWidth = 51;
            this.dgvLichTiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichTiem.Size = new System.Drawing.Size(1426, 577);
            this.dgvLichTiem.TabIndex = 0;
            this.dgvLichTiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTiem_CellClick);
            // 
            // cntXoaSua
            // 
            this.cntXoaSua.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntXoaSua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapNhatToolStripMenuItem});
            this.cntXoaSua.Name = "contextMenuStrip1";
            this.cntXoaSua.Size = new System.Drawing.Size(179, 28);
            // 
            // CapNhatToolStripMenuItem
            // 
            this.CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            this.CapNhatToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.CapNhatToolStripMenuItem.Text = "Xác Nhận Tiêm";
            this.CapNhatToolStripMenuItem.Click += new System.EventHandler(this.CapNhatToolStripMenuItem_Click);
            // 
            // pnlLoc
            // 
            this.pnlLoc.BackColor = System.Drawing.Color.White;
            this.pnlLoc.Controls.Add(this.cboTrangThai);
            this.pnlLoc.Location = new System.Drawing.Point(16, 8);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(257, 52);
            this.pnlLoc.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnInLichSuTiem);
            this.panel2.Controls.Add(this.btnCapNhatTrangThai);
            this.panel2.Controls.Add(this.pnlLoc);
            this.panel2.Controls.Add(this.pnlTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 70);
            this.panel2.TabIndex = 5;
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.Controls.Add(this.txtSearch);
            this.pnlTimKiem.Controls.Add(this.pictureBox2);
            this.pnlTimKiem.Controls.Add(this.btnSearch);
            this.pnlTimKiem.Location = new System.Drawing.Point(292, 7);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(344, 52);
            this.pnlTimKiem.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(26, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 25);
            this.txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(286, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 33);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabKhoVaccine
            // 
            this.tabKhoVaccine.BackColor = System.Drawing.Color.Transparent;
            this.tabKhoVaccine.Controls.Add(this.panel1);
            this.tabKhoVaccine.Controls.Add(this.panel2);
            this.tabKhoVaccine.ImageIndex = 3;
            this.tabKhoVaccine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabKhoVaccine.Location = new System.Drawing.Point(4, 54);
            this.tabKhoVaccine.Name = "tabKhoVaccine";
            this.tabKhoVaccine.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoVaccine.Size = new System.Drawing.Size(1432, 653);
            this.tabKhoVaccine.TabIndex = 0;
            this.tabKhoVaccine.Text = "Lịch Tiêm";
            // 
            // tctChinh
            // 
            this.tctChinh.Controls.Add(this.tabKhoVaccine);
            this.tctChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctChinh.ImageList = this.imageList1;
            this.tctChinh.ItemSize = new System.Drawing.Size(135, 50);
            this.tctChinh.Location = new System.Drawing.Point(0, 0);
            this.tctChinh.Margin = new System.Windows.Forms.Padding(0);
            this.tctChinh.Name = "tctChinh";
            this.tctChinh.Padding = new System.Drawing.Point(25, 5);
            this.tctChinh.SelectedIndex = 0;
            this.tctChinh.Size = new System.Drawing.Size(1440, 711);
            this.tctChinh.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tctChinh.TabIndex = 2;
            // 
            // timerTB_Tab2
            // 
            this.timerTB_Tab2.Interval = 4000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.notification_16903647;
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapNhatTrangThai.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatTrangThai.Image")));
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(657, 6);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(62, 54);
            this.btnCapNhatTrangThai.TabIndex = 30;
            this.btnCapNhatTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = false;
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnInLichSuTiem
            // 
            this.btnInLichSuTiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInLichSuTiem.Image = ((System.Drawing.Image)(resources.GetObject("btnInLichSuTiem.Image")));
            this.btnInLichSuTiem.Location = new System.Drawing.Point(725, 7);
            this.btnInLichSuTiem.Name = "btnInLichSuTiem";
            this.btnInLichSuTiem.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.btnInLichSuTiem.Size = new System.Drawing.Size(62, 54);
            this.btnInLichSuTiem.TabIndex = 31;
            this.btnInLichSuTiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInLichSuTiem.UseVisualStyleBackColor = false;
            this.btnInLichSuTiem.Click += new System.EventHandler(this.btnInLichSuTiem_Click);
            // 
            // frmQuanLyLichTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 711);
            this.Controls.Add(this.tctChinh);
            this.Name = "frmQuanLyLichTiem";
            this.Text = "frmQuanLyLichTiem";
            this.Load += new System.EventHandler(this.frmQuanLyLichTiem_Load);
            this.panel1.ResumeLayout(false);
            this.pnlThongBao.ResumeLayout(false);
            this.pnlTb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTiem)).EndInit();
            this.cntXoaSua.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.tabKhoVaccine.ResumeLayout(false);
            this.tctChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer TimeTab3;
        private System.Windows.Forms.Timer timerTB;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlThongBao;
        private System.Windows.Forms.Panel pnlTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblndtb;
        private System.Windows.Forms.DataGridView dgvLichTiem;
        private System.Windows.Forms.ContextMenuStrip cntXoaSua;
        private System.Windows.Forms.ToolStripMenuItem CapNhatToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabKhoVaccine;
        private System.Windows.Forms.TabControl tctChinh;
        private System.Windows.Forms.Timer timerTB_Tab2;
        private System.Windows.Forms.Button btnInLichSuTiem;
    }
}