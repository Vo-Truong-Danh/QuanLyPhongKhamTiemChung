namespace GUI
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.timerTB_Tab2 = new System.Windows.Forms.Timer(this.components);
            this.tabKhoVaccine = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.pnlTb = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblndtb = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.cntXoaSua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaVaccineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerTB = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tctChinh = new System.Windows.Forms.TabControl();
            this.TimeTab3 = new System.Windows.Forms.Timer(this.components);
            this.tabKhoVaccine.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlThongBao.SuspendLayout();
            this.pnlTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.cntXoaSua.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tctChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTB_Tab2
            // 
            this.timerTB_Tab2.Interval = 4000;
            // 
            // tabKhoVaccine
            // 
            this.tabKhoVaccine.BackColor = System.Drawing.Color.Transparent;
            this.tabKhoVaccine.Controls.Add(this.panel1);
            this.tabKhoVaccine.Controls.Add(this.panel2);
            this.tabKhoVaccine.ImageIndex = 4;
            this.tabKhoVaccine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabKhoVaccine.Location = new System.Drawing.Point(4, 54);
            this.tabKhoVaccine.Name = "tabKhoVaccine";
            this.tabKhoVaccine.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoVaccine.Size = new System.Drawing.Size(1413, 701);
            this.tabKhoVaccine.TabIndex = 0;
            this.tabKhoVaccine.Text = "Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlThongBao);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 625);
            this.panel1.TabIndex = 6;
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongBao.BackColor = System.Drawing.Color.DimGray;
            this.pnlThongBao.Controls.Add(this.pnlTb);
            this.pnlThongBao.Location = new System.Drawing.Point(838, 481);
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
            // lblndtb
            // 
            this.lblndtb.Location = new System.Drawing.Point(97, 22);
            this.lblndtb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblndtb.Name = "lblndtb";
            this.lblndtb.Size = new System.Drawing.Size(434, 54);
            this.lblndtb.TabIndex = 0;
            this.lblndtb.Text = "Thông báo";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 29;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.ContextMenuStrip = this.cntXoaSua;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1407, 625);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // cntXoaSua
            // 
            this.cntXoaSua.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntXoaSua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XoaVaccineToolStripMenuItem,
            this.CapNhatToolStripMenuItem});
            this.cntXoaSua.Name = "contextMenuStrip1";
            this.cntXoaSua.Size = new System.Drawing.Size(159, 52);
            // 
            // XoaVaccineToolStripMenuItem
            // 
            this.XoaVaccineToolStripMenuItem.Name = "XoaVaccineToolStripMenuItem";
            this.XoaVaccineToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.XoaVaccineToolStripMenuItem.Text = "Xoá Vaccine";
            // 
            // CapNhatToolStripMenuItem
            // 
            this.CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            this.CapNhatToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.CapNhatToolStripMenuItem.Text = "Cập nhật";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnCapNhatTrangThai);
            this.panel2.Controls.Add(this.pnlLoc);
            this.panel2.Controls.Add(this.pnlTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 70);
            this.panel2.TabIndex = 5;
            // 
            // btnCapNhatTrangThai
            // 
            this.btnCapNhatTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapNhatTrangThai.Image = global::GUI.Properties.Resources.file_109646911;
            this.btnCapNhatTrangThai.Location = new System.Drawing.Point(657, 6);
            this.btnCapNhatTrangThai.Name = "btnCapNhatTrangThai";
            this.btnCapNhatTrangThai.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.btnCapNhatTrangThai.Size = new System.Drawing.Size(62, 54);
            this.btnCapNhatTrangThai.TabIndex = 30;
            this.btnCapNhatTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatTrangThai.UseVisualStyleBackColor = false;
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
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.White;
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
            this.txtSearch.Location = new System.Drawing.Point(26, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 25);
            this.txtSearch.TabIndex = 26;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vaccination_5106376.png");
            this.imageList1.Images.SetKeyName(1, "khovc.png");
            this.imageList1.Images.SetKeyName(2, "more_6512218.png");
            this.imageList1.Images.SetKeyName(3, "appointment_16951807.png");
            this.imageList1.Images.SetKeyName(4, "id-card-clip-alt_9856425.png");
            // 
            // timerTB
            // 
            this.timerTB.Interval = 4000;
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
            this.tctChinh.Size = new System.Drawing.Size(1421, 759);
            this.tctChinh.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tctChinh.TabIndex = 3;
            // 
            // TimeTab3
            // 
            this.TimeTab3.Interval = 4000;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 759);
            this.Controls.Add(this.tctChinh);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.tabKhoVaccine.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlThongBao.ResumeLayout(false);
            this.pnlTb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.cntXoaSua.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tctChinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTB_Tab2;
        private System.Windows.Forms.TabPage tabKhoVaccine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlThongBao;
        private System.Windows.Forms.Panel pnlTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblndtb;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.ContextMenuStrip cntXoaSua;
        private System.Windows.Forms.ToolStripMenuItem XoaVaccineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapNhatToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerTB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tctChinh;
        private System.Windows.Forms.Timer TimeTab3;
    }
}