using System.Drawing;
using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLVaccine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tctChinh = new System.Windows.Forms.TabControl();
            this.tabKhoVaccine = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlThongBao = new System.Windows.Forms.Panel();
            this.pnlTb = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblndtb = new System.Windows.Forms.Label();
            this.dgvVaccine = new System.Windows.Forms.DataGridView();
            this.cntXoaSua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.XoaVaccineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlLocXuatXu = new System.Windows.Forms.Panel();
            this.lblXuatXu = new System.Windows.Forms.Label();
            this.cboXuatXu = new System.Windows.Forms.ComboBox();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.lblMaloaivctmp = new System.Windows.Forms.Label();
            this.cboLoaiVC = new System.Windows.Forms.ComboBox();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThemVC = new System.Windows.Forms.Button();
            this.tabNhapVC = new System.Windows.Forms.TabPage();
            this.pnl2_VungThemNVC = new System.Windows.Forms.Panel();
            this.pnl_2_TaoPhieuNhap = new System.Windows.Forms.Panel();
            this.pnl2_PN = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dthsd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtnsx = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInPhieuNhap = new System.Windows.Forms.Button();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.pnlTongTien = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl2_ngaynhap = new System.Windows.Forms.Panel();
            this.dteNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl2_ncc = new System.Windows.Forms.Panel();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl2_maphieu = new System.Windows.Forms.Panel();
            this.txtMaPhieuN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb2_ShowVCDuocChon = new System.Windows.Forms.GroupBox();
            this.dtgDanhSachVCduocChon = new System.Windows.Forms.DataGridView();
            this.grbDSVC = new System.Windows.Forms.GroupBox();
            this.pnlThongBaoTab2 = new System.Windows.Forms.Panel();
            this.pnlThongBaotab2s = new System.Windows.Forms.Panel();
            this.txtndthongbaotab2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtgCTPN = new System.Windows.Forms.DataGridView();
            this.tabPageThem = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlTb3 = new System.Windows.Forms.Panel();
            this.pnlTb3s = new System.Windows.Forms.Panel();
            this.lblndTab3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSaveNCC = new System.Windows.Forms.Button();
            this.btnCapNhatNCC = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LuuLoaiVaccine = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiVaccine = new System.Windows.Forms.Button();
            this.btnXoaLoaiVC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemLoaiVC = new System.Windows.Forms.Button();
            this.dgvLoaiVC = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerTB = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerTB_Tab2 = new System.Windows.Forms.Timer(this.components);
            this.TimeTab3 = new System.Windows.Forms.Timer(this.components);
            this.grb2_ChiTietPhieuNhap = new System.Windows.Forms.GroupBox();
            this.pnl2tenvaccine = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTenVCCTPN = new System.Windows.Forms.TextBox();
            this.pnl2dongia = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGiaCTPN = new System.Windows.Forms.TextBox();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.btnXoaCTPN = new System.Windows.Forms.Button();
            this.btnCapNhatCTPN = new System.Windows.Forms.Button();
            this.pnlThanhTien = new System.Windows.Forms.Panel();
            this.dsd = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSoLuong = new System.Windows.Forms.Panel();
            this.txtSoLuongCTPN = new System.Windows.Forms.Label();
            this.txtSolUong = new System.Windows.Forms.TextBox();
            this.tctChinh.SuspendLayout();
            this.tabKhoVaccine.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlThongBao.SuspendLayout();
            this.pnlTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).BeginInit();
            this.cntXoaSua.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLocXuatXu.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabNhapVC.SuspendLayout();
            this.pnl2_VungThemNVC.SuspendLayout();
            this.pnl_2_TaoPhieuNhap.SuspendLayout();
            this.pnl2_PN.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTongTien.SuspendLayout();
            this.pnl2_ngaynhap.SuspendLayout();
            this.pnl2_ncc.SuspendLayout();
            this.pnl2_maphieu.SuspendLayout();
            this.grb2_ShowVCDuocChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachVCduocChon)).BeginInit();
            this.grbDSVC.SuspendLayout();
            this.pnlThongBaoTab2.SuspendLayout();
            this.pnlThongBaotab2s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTPN)).BeginInit();
            this.tabPageThem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlTb3.SuspendLayout();
            this.pnlTb3s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVC)).BeginInit();
            this.grb2_ChiTietPhieuNhap.SuspendLayout();
            this.pnl2tenvaccine.SuspendLayout();
            this.pnl2dongia.SuspendLayout();
            this.pnlThanhTien.SuspendLayout();
            this.pnlSoLuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctChinh
            // 
            this.tctChinh.Controls.Add(this.tabKhoVaccine);
            this.tctChinh.Controls.Add(this.tabNhapVC);
            this.tctChinh.Controls.Add(this.tabPageThem);
            this.tctChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctChinh.ImageList = this.imageList1;
            this.tctChinh.ItemSize = new System.Drawing.Size(135, 50);
            this.tctChinh.Location = new System.Drawing.Point(0, 0);
            this.tctChinh.Margin = new System.Windows.Forms.Padding(0);
            this.tctChinh.Name = "tctChinh";
            this.tctChinh.Padding = new System.Drawing.Point(25, 5);
            this.tctChinh.SelectedIndex = 0;
            this.tctChinh.Size = new System.Drawing.Size(1898, 1055);
            this.tctChinh.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tctChinh.TabIndex = 1;
            // 
            // tabKhoVaccine
            // 
            this.tabKhoVaccine.BackColor = System.Drawing.Color.Transparent;
            this.tabKhoVaccine.Controls.Add(this.panel1);
            this.tabKhoVaccine.Controls.Add(this.panel2);
            this.tabKhoVaccine.ImageIndex = 1;
            this.tabKhoVaccine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabKhoVaccine.Location = new System.Drawing.Point(4, 54);
            this.tabKhoVaccine.Name = "tabKhoVaccine";
            this.tabKhoVaccine.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhoVaccine.Size = new System.Drawing.Size(1890, 997);
            this.tabKhoVaccine.TabIndex = 0;
            this.tabKhoVaccine.Text = "Kho Vaccine";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlThongBao);
            this.panel1.Controls.Add(this.dgvVaccine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1884, 921);
            this.panel1.TabIndex = 6;
            // 
            // pnlThongBao
            // 
            this.pnlThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThongBao.BackColor = System.Drawing.Color.DimGray;
            this.pnlThongBao.Controls.Add(this.pnlTb);
            this.pnlThongBao.Location = new System.Drawing.Point(1308, 792);
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
            // dgvVaccine
            // 
            this.dgvVaccine.AllowUserToAddRows = false;
            this.dgvVaccine.AllowUserToDeleteRows = false;
            this.dgvVaccine.AllowUserToResizeColumns = false;
            this.dgvVaccine.AllowUserToResizeRows = false;
            this.dgvVaccine.BackgroundColor = System.Drawing.Color.White;
            this.dgvVaccine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVaccine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVaccine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVaccine.ColumnHeadersHeight = 29;
            this.dgvVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVaccine.ContextMenuStrip = this.cntXoaSua;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVaccine.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVaccine.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvVaccine.EnableHeadersVisualStyles = false;
            this.dgvVaccine.Location = new System.Drawing.Point(0, 0);
            this.dgvVaccine.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVaccine.MultiSelect = false;
            this.dgvVaccine.Name = "dgvVaccine";
            this.dgvVaccine.ReadOnly = true;
            this.dgvVaccine.RowHeadersVisible = false;
            this.dgvVaccine.RowHeadersWidth = 51;
            this.dgvVaccine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaccine.Size = new System.Drawing.Size(1884, 921);
            this.dgvVaccine.TabIndex = 0;
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
            this.XoaVaccineToolStripMenuItem.Click += new System.EventHandler(this.XoaVaccineToolStripMenuItem_Click);
            // 
            // CapNhatToolStripMenuItem
            // 
            this.CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            this.CapNhatToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.CapNhatToolStripMenuItem.Text = "Cập nhật";
            this.CapNhatToolStripMenuItem.Click += new System.EventHandler(this.CapNhatToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.pnlLocXuatXu);
            this.panel2.Controls.Add(this.pnlLoc);
            this.panel2.Controls.Add(this.pnlTimKiem);
            this.panel2.Controls.Add(this.btnThemVC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1884, 70);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Image = global::GUI.Properties.Resources.cancel_83449661;
            this.button2.Location = new System.Drawing.Point(1155, 8);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.button2.Size = new System.Drawing.Size(62, 54);
            this.button2.TabIndex = 31;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::GUI.Properties.Resources.file_109646911;
            this.button1.Location = new System.Drawing.Point(1077, 8);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.button1.Size = new System.Drawing.Size(62, 54);
            this.button1.TabIndex = 30;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(102)))));
            this.btnLuu.Image = global::GUI.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1233, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.btnLuu.Size = new System.Drawing.Size(118, 54);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlLocXuatXu
            // 
            this.pnlLocXuatXu.BackColor = System.Drawing.Color.White;
            this.pnlLocXuatXu.Controls.Add(this.lblXuatXu);
            this.pnlLocXuatXu.Controls.Add(this.cboXuatXu);
            this.pnlLocXuatXu.Location = new System.Drawing.Point(291, 8);
            this.pnlLocXuatXu.Name = "pnlLocXuatXu";
            this.pnlLocXuatXu.Size = new System.Drawing.Size(227, 54);
            this.pnlLocXuatXu.TabIndex = 28;
            // 
            // lblXuatXu
            // 
            this.lblXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatXu.Location = new System.Drawing.Point(25, 14);
            this.lblXuatXu.Name = "lblXuatXu";
            this.lblXuatXu.Size = new System.Drawing.Size(155, 32);
            this.lblXuatXu.TabIndex = 1;
            this.lblXuatXu.Text = "Xuất xứ Vaccine   ";
            // 
            // cboXuatXu
            // 
            this.cboXuatXu.BackColor = System.Drawing.Color.White;
            this.cboXuatXu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXuatXu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboXuatXu.FormattingEnabled = true;
            this.cboXuatXu.Items.AddRange(new object[] {
            "Nhóm Vaccine"});
            this.cboXuatXu.Location = new System.Drawing.Point(24, 12);
            this.cboXuatXu.Name = "cboXuatXu";
            this.cboXuatXu.Size = new System.Drawing.Size(183, 33);
            this.cboXuatXu.TabIndex = 0;
            this.cboXuatXu.SelectedIndexChanged += new System.EventHandler(this.cboXuatXu_SelectedIndexChanged);
            this.cboXuatXu.SelectionChangeCommitted += new System.EventHandler(this.cboXuatXu_SelectionChangeCommitted);
            // 
            // pnlLoc
            // 
            this.pnlLoc.BackColor = System.Drawing.Color.White;
            this.pnlLoc.Controls.Add(this.lblMaloaivctmp);
            this.pnlLoc.Controls.Add(this.cboLoaiVC);
            this.pnlLoc.Location = new System.Drawing.Point(16, 8);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(257, 54);
            this.pnlLoc.TabIndex = 27;
            // 
            // lblMaloaivctmp
            // 
            this.lblMaloaivctmp.AutoSize = true;
            this.lblMaloaivctmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaloaivctmp.Location = new System.Drawing.Point(23, 4);
            this.lblMaloaivctmp.Name = "lblMaloaivctmp";
            this.lblMaloaivctmp.Padding = new System.Windows.Forms.Padding(10);
            this.lblMaloaivctmp.Size = new System.Drawing.Size(193, 45);
            this.lblMaloaivctmp.TabIndex = 1;
            this.lblMaloaivctmp.Text = "Mã Loại Vaccine   ";
            // 
            // cboLoaiVC
            // 
            this.cboLoaiVC.BackColor = System.Drawing.Color.White;
            this.cboLoaiVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboLoaiVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboLoaiVC.FormattingEnabled = true;
            this.cboLoaiVC.Items.AddRange(new object[] {
            "Nhóm Vaccine"});
            this.cboLoaiVC.Location = new System.Drawing.Point(23, 9);
            this.cboLoaiVC.Name = "cboLoaiVC";
            this.cboLoaiVC.Size = new System.Drawing.Size(218, 33);
            this.cboLoaiVC.TabIndex = 0;
            this.cboLoaiVC.SelectedIndexChanged += new System.EventHandler(this.cboLoaiVC_SelectedIndexChanged);
            this.cboLoaiVC.SelectionChangeCommitted += new System.EventHandler(this.cboLoaiVC_SelectionChangeCommitted);
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.Controls.Add(this.txtSearch);
            this.pnlTimKiem.Controls.Add(this.pictureBox2);
            this.pnlTimKiem.Controls.Add(this.btnSearch);
            this.pnlTimKiem.Location = new System.Drawing.Point(524, 8);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(344, 54);
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
            // btnThemVC
            // 
            this.btnThemVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemVC.Image = global::GUI.Properties.Resources.vaccine_3021063;
            this.btnThemVC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVC.Location = new System.Drawing.Point(888, 8);
            this.btnThemVC.Name = "btnThemVC";
            this.btnThemVC.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.btnThemVC.Size = new System.Drawing.Size(183, 54);
            this.btnThemVC.TabIndex = 25;
            this.btnThemVC.Text = "Vaccine mới";
            this.btnThemVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVC.UseVisualStyleBackColor = false;
            this.btnThemVC.Click += new System.EventHandler(this.btnThemVC_Click);
            // 
            // tabNhapVC
            // 
            this.tabNhapVC.Controls.Add(this.pnl2_VungThemNVC);
            this.tabNhapVC.Controls.Add(this.grbDSVC);
            this.tabNhapVC.ImageIndex = 0;
            this.tabNhapVC.Location = new System.Drawing.Point(4, 54);
            this.tabNhapVC.Name = "tabNhapVC";
            this.tabNhapVC.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapVC.Size = new System.Drawing.Size(1890, 997);
            this.tabNhapVC.TabIndex = 2;
            this.tabNhapVC.Text = "Nhập Vaccine";
            this.tabNhapVC.UseVisualStyleBackColor = true;
            // 
            // pnl2_VungThemNVC
            // 
            this.pnl2_VungThemNVC.Controls.Add(this.pnl_2_TaoPhieuNhap);
            this.pnl2_VungThemNVC.Controls.Add(this.grb2_ShowVCDuocChon);
            this.pnl2_VungThemNVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2_VungThemNVC.Location = new System.Drawing.Point(3, 3);
            this.pnl2_VungThemNVC.Name = "pnl2_VungThemNVC";
            this.pnl2_VungThemNVC.Size = new System.Drawing.Size(1301, 991);
            this.pnl2_VungThemNVC.TabIndex = 1;
            // 
            // pnl_2_TaoPhieuNhap
            // 
            this.pnl_2_TaoPhieuNhap.Controls.Add(this.grb2_ChiTietPhieuNhap);
            this.pnl_2_TaoPhieuNhap.Controls.Add(this.pnl2_PN);
            this.pnl_2_TaoPhieuNhap.Controls.Add(this.panel3);
            this.pnl_2_TaoPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_2_TaoPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnl_2_TaoPhieuNhap.Name = "pnl_2_TaoPhieuNhap";
            this.pnl_2_TaoPhieuNhap.Size = new System.Drawing.Size(1301, 571);
            this.pnl_2_TaoPhieuNhap.TabIndex = 4;
            // 
            // pnl2_PN
            // 
            this.pnl2_PN.Controls.Add(this.pnlTongTien);
            this.pnl2_PN.Controls.Add(this.pnl2_ngaynhap);
            this.pnl2_PN.Controls.Add(this.pnl2_ncc);
            this.pnl2_PN.Controls.Add(this.pnl2_maphieu);
            this.pnl2_PN.Location = new System.Drawing.Point(5, 88);
            this.pnl2_PN.Name = "pnl2_PN";
            this.pnl2_PN.Padding = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.pnl2_PN.Size = new System.Drawing.Size(414, 451);
            this.pnl2_PN.TabIndex = 10;
            this.pnl2_PN.TabStop = false;
            this.pnl2_PN.Text = "Phiếu Nhập";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dthsd);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(27, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 42);
            this.panel6.TabIndex = 4;
            // 
            // dthsd
            // 
            this.dthsd.Location = new System.Drawing.Point(135, 10);
            this.dthsd.Margin = new System.Windows.Forms.Padding(0);
            this.dthsd.Name = "dthsd";
            this.dthsd.Size = new System.Drawing.Size(246, 30);
            this.dthsd.TabIndex = 2;
            this.dthsd.ValueChanged += new System.EventHandler(this.dthsd_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "HSD";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dtnsx);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(27, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 42);
            this.panel5.TabIndex = 4;
            // 
            // dtnsx
            // 
            this.dtnsx.Location = new System.Drawing.Point(135, 11);
            this.dtnsx.Margin = new System.Windows.Forms.Padding(0);
            this.dtnsx.Name = "dtnsx";
            this.dtnsx.Size = new System.Drawing.Size(246, 30);
            this.dtnsx.TabIndex = 2;
            this.dtnsx.ValueChanged += new System.EventHandler(this.dtnsx_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "NSX";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInPhieuNhap);
            this.panel3.Controls.Add(this.btnLuuPhieuNhap);
            this.panel3.Controls.Add(this.btnTaoPhieuNhap);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 79);
            this.panel3.TabIndex = 9;
            // 
            // btnInPhieuNhap
            // 
            this.btnInPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInPhieuNhap.Image = global::GUI.Properties.Resources._in;
            this.btnInPhieuNhap.Location = new System.Drawing.Point(275, 15);
            this.btnInPhieuNhap.Name = "btnInPhieuNhap";
            this.btnInPhieuNhap.Size = new System.Drawing.Size(70, 46);
            this.btnInPhieuNhap.TabIndex = 5;
            this.btnInPhieuNhap.Text = "In";
            this.toolTip.SetToolTip(this.btnInPhieuNhap, "Nhấn vào để lưu phiếu nhập vào cơ sở dử liệu");
            this.btnInPhieuNhap.UseVisualStyleBackColor = false;
            this.btnInPhieuNhap.Visible = false;
            this.btnInPhieuNhap.Click += new System.EventHandler(this.btnInPhieuNhap_Click);
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLuuPhieuNhap.Image = global::GUI.Properties.Resources.save;
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(191, 15);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(78, 46);
            this.btnLuuPhieuNhap.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnLuuPhieuNhap, "Nhấn vào để lưu phiếu nhập vào cơ sở dử liệu");
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            this.btnLuuPhieuNhap.Visible = false;
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(5, 15);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(180, 46);
            this.btnTaoPhieuNhap.TabIndex = 1;
            this.btnTaoPhieuNhap.Text = "Tạo Phiếu Nhập";
            this.toolTip.SetToolTip(this.btnTaoPhieuNhap, "Nhấn vào để tạo phiếu nhập kho Vacine");
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // pnlTongTien
            // 
            this.pnlTongTien.BackColor = System.Drawing.Color.White;
            this.pnlTongTien.Controls.Add(this.label3);
            this.pnlTongTien.Controls.Add(this.txtTongTien);
            this.pnlTongTien.Controls.Add(this.label2);
            this.pnlTongTien.Location = new System.Drawing.Point(28, 201);
            this.pnlTongTien.Name = "pnlTongTien";
            this.pnlTongTien.Size = new System.Drawing.Size(360, 50);
            this.pnlTongTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Location = new System.Drawing.Point(154, 13);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(189, 33);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền";
            // 
            // pnl2_ngaynhap
            // 
            this.pnl2_ngaynhap.BackColor = System.Drawing.Color.White;
            this.pnl2_ngaynhap.Controls.Add(this.dteNgayNhap);
            this.pnl2_ngaynhap.Controls.Add(this.label5);
            this.pnl2_ngaynhap.Location = new System.Drawing.Point(28, 144);
            this.pnl2_ngaynhap.Name = "pnl2_ngaynhap";
            this.pnl2_ngaynhap.Size = new System.Drawing.Size(360, 50);
            this.pnl2_ngaynhap.TabIndex = 3;
            // 
            // dteNgayNhap
            // 
            this.dteNgayNhap.Location = new System.Drawing.Point(144, 10);
            this.dteNgayNhap.Margin = new System.Windows.Forms.Padding(0);
            this.dteNgayNhap.Name = "dteNgayNhap";
            this.dteNgayNhap.Size = new System.Drawing.Size(199, 30);
            this.dteNgayNhap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Nhập";
            // 
            // pnl2_ncc
            // 
            this.pnl2_ncc.BackColor = System.Drawing.Color.White;
            this.pnl2_ncc.Controls.Add(this.cboNCC);
            this.pnl2_ncc.Controls.Add(this.label4);
            this.pnl2_ncc.Location = new System.Drawing.Point(28, 88);
            this.pnl2_ncc.Name = "pnl2_ncc";
            this.pnl2_ncc.Size = new System.Drawing.Size(360, 50);
            this.pnl2_ncc.TabIndex = 2;
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.SystemColors.Window;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(163, 8);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(180, 33);
            this.cboNCC.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà Cung Cấp";
            // 
            // pnl2_maphieu
            // 
            this.pnl2_maphieu.BackColor = System.Drawing.Color.White;
            this.pnl2_maphieu.Controls.Add(this.txtMaPhieuN);
            this.pnl2_maphieu.Controls.Add(this.label1);
            this.pnl2_maphieu.Location = new System.Drawing.Point(28, 32);
            this.pnl2_maphieu.Name = "pnl2_maphieu";
            this.pnl2_maphieu.Size = new System.Drawing.Size(360, 50);
            this.pnl2_maphieu.TabIndex = 0;
            // 
            // txtMaPhieuN
            // 
            this.txtMaPhieuN.BackColor = System.Drawing.Color.White;
            this.txtMaPhieuN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPhieuN.Location = new System.Drawing.Point(144, 10);
            this.txtMaPhieuN.Multiline = true;
            this.txtMaPhieuN.Name = "txtMaPhieuN";
            this.txtMaPhieuN.ReadOnly = true;
            this.txtMaPhieuN.Size = new System.Drawing.Size(199, 33);
            this.txtMaPhieuN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu";
            // 
            // grb2_ShowVCDuocChon
            // 
            this.grb2_ShowVCDuocChon.Controls.Add(this.dtgDanhSachVCduocChon);
            this.grb2_ShowVCDuocChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grb2_ShowVCDuocChon.Location = new System.Drawing.Point(0, 571);
            this.grb2_ShowVCDuocChon.Name = "grb2_ShowVCDuocChon";
            this.grb2_ShowVCDuocChon.Padding = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.grb2_ShowVCDuocChon.Size = new System.Drawing.Size(1301, 420);
            this.grb2_ShowVCDuocChon.TabIndex = 0;
            this.grb2_ShowVCDuocChon.TabStop = false;
            this.grb2_ShowVCDuocChon.Text = "Danh sách sản phẩm muốn nhập";
            // 
            // dtgDanhSachVCduocChon
            // 
            this.dtgDanhSachVCduocChon.AllowUserToAddRows = false;
            this.dtgDanhSachVCduocChon.AllowUserToDeleteRows = false;
            this.dtgDanhSachVCduocChon.AllowUserToResizeColumns = false;
            this.dtgDanhSachVCduocChon.AllowUserToResizeRows = false;
            this.dtgDanhSachVCduocChon.BackgroundColor = System.Drawing.Color.White;
            this.dtgDanhSachVCduocChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDanhSachVCduocChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDanhSachVCduocChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDanhSachVCduocChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgDanhSachVCduocChon.ColumnHeadersHeight = 29;
            this.dtgDanhSachVCduocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDanhSachVCduocChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDanhSachVCduocChon.EnableHeadersVisualStyles = false;
            this.dtgDanhSachVCduocChon.Location = new System.Drawing.Point(3, 36);
            this.dtgDanhSachVCduocChon.MultiSelect = false;
            this.dtgDanhSachVCduocChon.Name = "dtgDanhSachVCduocChon";
            this.dtgDanhSachVCduocChon.RowHeadersVisible = false;
            this.dtgDanhSachVCduocChon.RowHeadersWidth = 51;
            this.dtgDanhSachVCduocChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDanhSachVCduocChon.Size = new System.Drawing.Size(1295, 381);
            this.dtgDanhSachVCduocChon.TabIndex = 0;
            this.dtgDanhSachVCduocChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachVCduocChon_CellClick);
            this.dtgDanhSachVCduocChon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachVCduocChon_CellValueChanged);
            // 
            // grbDSVC
            // 
            this.grbDSVC.Controls.Add(this.pnlThongBaoTab2);
            this.grbDSVC.Controls.Add(this.dtgCTPN);
            this.grbDSVC.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbDSVC.Location = new System.Drawing.Point(1304, 3);
            this.grbDSVC.Name = "grbDSVC";
            this.grbDSVC.Padding = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.grbDSVC.Size = new System.Drawing.Size(583, 991);
            this.grbDSVC.TabIndex = 0;
            this.grbDSVC.TabStop = false;
            this.grbDSVC.Text = "Danh sách các loại Vaccine";
            // 
            // pnlThongBaoTab2
            // 
            this.pnlThongBaoTab2.BackColor = System.Drawing.Color.Black;
            this.pnlThongBaoTab2.Controls.Add(this.pnlThongBaotab2s);
            this.pnlThongBaoTab2.Location = new System.Drawing.Point(6, 715);
            this.pnlThongBaoTab2.Name = "pnlThongBaoTab2";
            this.pnlThongBaoTab2.Size = new System.Drawing.Size(555, 72);
            this.pnlThongBaoTab2.TabIndex = 1;
            this.pnlThongBaoTab2.Visible = false;
            // 
            // pnlThongBaotab2s
            // 
            this.pnlThongBaotab2s.BackColor = System.Drawing.Color.White;
            this.pnlThongBaotab2s.Controls.Add(this.txtndthongbaotab2);
            this.pnlThongBaotab2s.Controls.Add(this.pictureBox3);
            this.pnlThongBaotab2s.Location = new System.Drawing.Point(2, 2);
            this.pnlThongBaotab2s.Name = "pnlThongBaotab2s";
            this.pnlThongBaotab2s.Size = new System.Drawing.Size(550, 68);
            this.pnlThongBaotab2s.TabIndex = 2;
            // 
            // txtndthongbaotab2
            // 
            this.txtndthongbaotab2.AutoSize = true;
            this.txtndthongbaotab2.Location = new System.Drawing.Point(98, 22);
            this.txtndthongbaotab2.Name = "txtndthongbaotab2";
            this.txtndthongbaotab2.Size = new System.Drawing.Size(107, 25);
            this.txtndthongbaotab2.TabIndex = 1;
            this.txtndthongbaotab2.Text = "Thông báo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.notification_16903647;
            this.pictureBox3.Location = new System.Drawing.Point(26, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // dtgCTPN
            // 
            this.dtgCTPN.AllowUserToAddRows = false;
            this.dtgCTPN.AllowUserToDeleteRows = false;
            this.dtgCTPN.AllowUserToResizeColumns = false;
            this.dtgCTPN.AllowUserToResizeRows = false;
            this.dtgCTPN.BackgroundColor = System.Drawing.Color.White;
            this.dtgCTPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCTPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCTPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCTPN.ColumnHeadersHeight = 60;
            this.dtgCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCTPN.EnableHeadersVisualStyles = false;
            this.dtgCTPN.Location = new System.Drawing.Point(3, 36);
            this.dtgCTPN.MultiSelect = false;
            this.dtgCTPN.Name = "dtgCTPN";
            this.dtgCTPN.ReadOnly = true;
            this.dtgCTPN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgCTPN.RowHeadersVisible = false;
            this.dtgCTPN.RowHeadersWidth = 60;
            this.dtgCTPN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCTPN.Size = new System.Drawing.Size(577, 952);
            this.dtgCTPN.TabIndex = 0;
            this.dtgCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCTPN_CellClick);
            this.dtgCTPN.Click += new System.EventHandler(this.dtgCTPN_Click);
            // 
            // tabPageThem
            // 
            this.tabPageThem.Controls.Add(this.groupBox2);
            this.tabPageThem.Controls.Add(this.groupBox1);
            this.tabPageThem.ImageIndex = 2;
            this.tabPageThem.Location = new System.Drawing.Point(4, 54);
            this.tabPageThem.Name = "tabPageThem";
            this.tabPageThem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThem.Size = new System.Drawing.Size(1890, 997);
            this.tabPageThem.TabIndex = 3;
            this.tabPageThem.Text = "Thêm";
            this.toolTip.SetToolTip(this.tabPageThem, "Nhấp vào để quản lý loại vaccine với nhà cung cấp");
            this.tabPageThem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlTb3);
            this.groupBox2.Controls.Add(this.btnSaveNCC);
            this.groupBox2.Controls.Add(this.btnCapNhatNCC);
            this.groupBox2.Controls.Add(this.dgvNCC);
            this.groupBox2.Controls.Add(this.btnXoaNCC);
            this.groupBox2.Controls.Add(this.btnThemNCC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(600, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1287, 991);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pnlTb3
            // 
            this.pnlTb3.BackColor = System.Drawing.Color.DimGray;
            this.pnlTb3.Controls.Add(this.pnlTb3s);
            this.pnlTb3.Location = new System.Drawing.Point(290, 687);
            this.pnlTb3.Name = "pnlTb3";
            this.pnlTb3.Size = new System.Drawing.Size(555, 91);
            this.pnlTb3.TabIndex = 11;
            this.pnlTb3.Visible = false;
            // 
            // pnlTb3s
            // 
            this.pnlTb3s.BackColor = System.Drawing.Color.White;
            this.pnlTb3s.Controls.Add(this.lblndTab3);
            this.pnlTb3s.Controls.Add(this.pictureBox4);
            this.pnlTb3s.Location = new System.Drawing.Point(2, 2);
            this.pnlTb3s.Name = "pnlTb3s";
            this.pnlTb3s.Size = new System.Drawing.Size(550, 87);
            this.pnlTb3s.TabIndex = 12;
            // 
            // lblndTab3
            // 
            this.lblndTab3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblndTab3.Location = new System.Drawing.Point(83, 16);
            this.lblndTab3.Multiline = true;
            this.lblndTab3.Name = "lblndTab3";
            this.lblndTab3.Size = new System.Drawing.Size(445, 55);
            this.lblndTab3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources.notification_16903647;
            this.pictureBox4.Location = new System.Drawing.Point(15, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnSaveNCC
            // 
            this.btnSaveNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveNCC.Image = global::GUI.Properties.Resources.save;
            this.btnSaveNCC.Location = new System.Drawing.Point(471, 29);
            this.btnSaveNCC.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveNCC.Name = "btnSaveNCC";
            this.btnSaveNCC.Size = new System.Drawing.Size(55, 50);
            this.btnSaveNCC.TabIndex = 10;
            this.btnSaveNCC.UseVisualStyleBackColor = false;
            this.btnSaveNCC.Click += new System.EventHandler(this.btnSaveNCC_Click);
            // 
            // btnCapNhatNCC
            // 
            this.btnCapNhatNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapNhatNCC.Image = global::GUI.Properties.Resources.file_109646911;
            this.btnCapNhatNCC.Location = new System.Drawing.Point(407, 29);
            this.btnCapNhatNCC.Name = "btnCapNhatNCC";
            this.btnCapNhatNCC.Size = new System.Drawing.Size(55, 50);
            this.btnCapNhatNCC.TabIndex = 9;
            this.btnCapNhatNCC.UseVisualStyleBackColor = false;
            this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.AllowUserToResizeColumns = false;
            this.dgvNCC.AllowUserToResizeRows = false;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvNCC.ColumnHeadersHeight = 29;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.Location = new System.Drawing.Point(3, 286);
            this.dgvNCC.MultiSelect = false;
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(1281, 702);
            this.dgvNCC.TabIndex = 1;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaNCC.Image = global::GUI.Properties.Resources.cancel_83449661;
            this.btnXoaNCC.Location = new System.Drawing.Point(343, 29);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(55, 50);
            this.btnXoaNCC.TabIndex = 8;
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemNCC.Image = global::GUI.Properties.Resources.them2;
            this.btnThemNCC.Location = new System.Drawing.Point(279, 29);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(55, 50);
            this.btnThemNCC.TabIndex = 6;
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LuuLoaiVaccine);
            this.groupBox1.Controls.Add(this.btnCapNhatLoaiVaccine);
            this.groupBox1.Controls.Add(this.btnXoaLoaiVC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnThemLoaiVC);
            this.groupBox1.Controls.Add(this.dgvLoaiVC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 991);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LuuLoaiVaccine
            // 
            this.LuuLoaiVaccine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LuuLoaiVaccine.Image = global::GUI.Properties.Resources.save;
            this.LuuLoaiVaccine.Location = new System.Drawing.Point(431, 29);
            this.LuuLoaiVaccine.Margin = new System.Windows.Forms.Padding(0);
            this.LuuLoaiVaccine.Name = "LuuLoaiVaccine";
            this.LuuLoaiVaccine.Size = new System.Drawing.Size(55, 50);
            this.LuuLoaiVaccine.TabIndex = 5;
            this.LuuLoaiVaccine.UseVisualStyleBackColor = false;
            this.LuuLoaiVaccine.Click += new System.EventHandler(this.LuuLoaiVaccine_Click);
            // 
            // btnCapNhatLoaiVaccine
            // 
            this.btnCapNhatLoaiVaccine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapNhatLoaiVaccine.Image = global::GUI.Properties.Resources.file_109646911;
            this.btnCapNhatLoaiVaccine.Location = new System.Drawing.Point(373, 29);
            this.btnCapNhatLoaiVaccine.Name = "btnCapNhatLoaiVaccine";
            this.btnCapNhatLoaiVaccine.Size = new System.Drawing.Size(55, 50);
            this.btnCapNhatLoaiVaccine.TabIndex = 4;
            this.btnCapNhatLoaiVaccine.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiVaccine.Click += new System.EventHandler(this.btnCapNhatLoaiVaccine_Click);
            // 
            // btnXoaLoaiVC
            // 
            this.btnXoaLoaiVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaLoaiVC.Image = global::GUI.Properties.Resources.cancel_83449661;
            this.btnXoaLoaiVC.Location = new System.Drawing.Point(312, 29);
            this.btnXoaLoaiVC.Name = "btnXoaLoaiVC";
            this.btnXoaLoaiVC.Size = new System.Drawing.Size(55, 50);
            this.btnXoaLoaiVC.TabIndex = 3;
            this.btnXoaLoaiVC.UseVisualStyleBackColor = false;
            this.btnXoaLoaiVC.Click += new System.EventHandler(this.btnXoaLoaiVC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quản Lý Loại Vaccine";
            // 
            // btnThemLoaiVC
            // 
            this.btnThemLoaiVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemLoaiVC.Image = global::GUI.Properties.Resources.them2;
            this.btnThemLoaiVC.Location = new System.Drawing.Point(251, 29);
            this.btnThemLoaiVC.Name = "btnThemLoaiVC";
            this.btnThemLoaiVC.Size = new System.Drawing.Size(55, 50);
            this.btnThemLoaiVC.TabIndex = 1;
            this.btnThemLoaiVC.UseVisualStyleBackColor = false;
            this.btnThemLoaiVC.Click += new System.EventHandler(this.btnThemLoaiVC_Click);
            // 
            // dgvLoaiVC
            // 
            this.dgvLoaiVC.AllowUserToAddRows = false;
            this.dgvLoaiVC.AllowUserToDeleteRows = false;
            this.dgvLoaiVC.AllowUserToResizeColumns = false;
            this.dgvLoaiVC.AllowUserToResizeRows = false;
            this.dgvLoaiVC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvLoaiVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiVC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiVC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLoaiVC.ColumnHeadersHeight = 29;
            this.dgvLoaiVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoaiVC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiVC.EnableHeadersVisualStyles = false;
            this.dgvLoaiVC.Location = new System.Drawing.Point(3, 286);
            this.dgvLoaiVC.MultiSelect = false;
            this.dgvLoaiVC.Name = "dgvLoaiVC";
            this.dgvLoaiVC.ReadOnly = true;
            this.dgvLoaiVC.RowHeadersVisible = false;
            this.dgvLoaiVC.RowHeadersWidth = 51;
            this.dgvLoaiVC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiVC.Size = new System.Drawing.Size(591, 702);
            this.dgvLoaiVC.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vaccination_5106376.png");
            this.imageList1.Images.SetKeyName(1, "khovc.png");
            this.imageList1.Images.SetKeyName(2, "more_6512218.png");
            // 
            // timerTB
            // 
            this.timerTB.Interval = 4000;
            this.timerTB.Tick += new System.EventHandler(this.timerTB_Tick);
            // 
            // timerTB_Tab2
            // 
            this.timerTB_Tab2.Interval = 4000;
            this.timerTB_Tab2.Tick += new System.EventHandler(this.timerTB_Tab2_Tick);
            // 
            // TimeTab3
            // 
            this.TimeTab3.Interval = 4000;
            this.TimeTab3.Tick += new System.EventHandler(this.TimeTab3_Tick);
            // 
            // grb2_ChiTietPhieuNhap
            // 
            this.grb2_ChiTietPhieuNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.panel6);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.pnlSoLuong);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.panel5);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.pnlThanhTien);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.btnCapNhatCTPN);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.btnXoaCTPN);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.btnThemCTPN);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.pnl2dongia);
            this.grb2_ChiTietPhieuNhap.Controls.Add(this.pnl2tenvaccine);
            this.grb2_ChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb2_ChiTietPhieuNhap.Location = new System.Drawing.Point(871, 0);
            this.grb2_ChiTietPhieuNhap.Name = "grb2_ChiTietPhieuNhap";
            this.grb2_ChiTietPhieuNhap.Size = new System.Drawing.Size(430, 571);
            this.grb2_ChiTietPhieuNhap.TabIndex = 2;
            this.grb2_ChiTietPhieuNhap.TabStop = false;
            this.grb2_ChiTietPhieuNhap.Text = "Chi tiết Vaccine";
            this.grb2_ChiTietPhieuNhap.Leave += new System.EventHandler(this.grb2_ChiTietPhieuNhap_Leave);
            // 
            // pnl2tenvaccine
            // 
            this.pnl2tenvaccine.BackColor = System.Drawing.Color.White;
            this.pnl2tenvaccine.Controls.Add(this.txtTenVCCTPN);
            this.pnl2tenvaccine.Controls.Add(this.label16);
            this.pnl2tenvaccine.Location = new System.Drawing.Point(27, 29);
            this.pnl2tenvaccine.Name = "pnl2tenvaccine";
            this.pnl2tenvaccine.Size = new System.Drawing.Size(390, 42);
            this.pnl2tenvaccine.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tên Vaccine";
            // 
            // txtTenVCCTPN
            // 
            this.txtTenVCCTPN.BackColor = System.Drawing.Color.White;
            this.txtTenVCCTPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenVCCTPN.Location = new System.Drawing.Point(144, 11);
            this.txtTenVCCTPN.Multiline = true;
            this.txtTenVCCTPN.Name = "txtTenVCCTPN";
            this.txtTenVCCTPN.ReadOnly = true;
            this.txtTenVCCTPN.Size = new System.Drawing.Size(246, 35);
            this.txtTenVCCTPN.TabIndex = 1;
            // 
            // pnl2dongia
            // 
            this.pnl2dongia.BackColor = System.Drawing.Color.White;
            this.pnl2dongia.Controls.Add(this.txtDonGiaCTPN);
            this.pnl2dongia.Controls.Add(this.label7);
            this.pnl2dongia.Location = new System.Drawing.Point(27, 127);
            this.pnl2dongia.Name = "pnl2dongia";
            this.pnl2dongia.Size = new System.Drawing.Size(390, 42);
            this.pnl2dongia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá";
            // 
            // txtDonGiaCTPN
            // 
            this.txtDonGiaCTPN.BackColor = System.Drawing.Color.White;
            this.txtDonGiaCTPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGiaCTPN.Location = new System.Drawing.Point(144, 12);
            this.txtDonGiaCTPN.Multiline = true;
            this.txtDonGiaCTPN.Name = "txtDonGiaCTPN";
            this.txtDonGiaCTPN.ReadOnly = true;
            this.txtDonGiaCTPN.Size = new System.Drawing.Size(246, 35);
            this.txtDonGiaCTPN.TabIndex = 2;
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemCTPN.Enabled = false;
            this.btnThemCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPN.Image = global::GUI.Properties.Resources.them2;
            this.btnThemCTPN.Location = new System.Drawing.Point(46, 318);
            this.btnThemCTPN.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(55, 55);
            this.btnThemCTPN.TabIndex = 4;
            this.btnThemCTPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnThemCTPN, "Thêm vào danh sách đơn hàng");
            this.btnThemCTPN.UseVisualStyleBackColor = false;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // btnXoaCTPN
            // 
            this.btnXoaCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTPN.Image = global::GUI.Properties.Resources.xoa;
            this.btnXoaCTPN.Location = new System.Drawing.Point(196, 318);
            this.btnXoaCTPN.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaCTPN.Name = "btnXoaCTPN";
            this.btnXoaCTPN.Size = new System.Drawing.Size(55, 55);
            this.btnXoaCTPN.TabIndex = 7;
            this.btnXoaCTPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnXoaCTPN, "Cập nhật vào danh sách đơn hàng");
            this.btnXoaCTPN.UseVisualStyleBackColor = false;
            this.btnXoaCTPN.Click += new System.EventHandler(this.btnXoaCTPN_Click);
            // 
            // btnCapNhatCTPN
            // 
            this.btnCapNhatCTPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCapNhatCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatCTPN.Image = global::GUI.Properties.Resources.file_109646911;
            this.btnCapNhatCTPN.Location = new System.Drawing.Point(353, 318);
            this.btnCapNhatCTPN.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapNhatCTPN.Name = "btnCapNhatCTPN";
            this.btnCapNhatCTPN.Size = new System.Drawing.Size(55, 55);
            this.btnCapNhatCTPN.TabIndex = 8;
            this.btnCapNhatCTPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnCapNhatCTPN, "Sửa lại thông tin trong danh sách đơn hàng");
            this.btnCapNhatCTPN.UseVisualStyleBackColor = false;
            this.btnCapNhatCTPN.Click += new System.EventHandler(this.btnCapNhatCTPN_Click);
            // 
            // pnlThanhTien
            // 
            this.pnlThanhTien.BackColor = System.Drawing.Color.White;
            this.pnlThanhTien.Controls.Add(this.label6);
            this.pnlThanhTien.Controls.Add(this.txtThanhTien);
            this.pnlThanhTien.Controls.Add(this.dsd);
            this.pnlThanhTien.Location = new System.Drawing.Point(27, 273);
            this.pnlThanhTien.Name = "pnlThanhTien";
            this.pnlThanhTien.Size = new System.Drawing.Size(390, 42);
            this.pnlThanhTien.TabIndex = 7;
            // 
            // dsd
            // 
            this.dsd.AutoSize = true;
            this.dsd.Location = new System.Drawing.Point(14, 9);
            this.dsd.Name = "dsd";
            this.dsd.Size = new System.Drawing.Size(105, 25);
            this.dsd.TabIndex = 0;
            this.dsd.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.White;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhTien.Location = new System.Drawing.Point(119, 11);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(246, 35);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "VNĐ";
            // 
            // pnlSoLuong
            // 
            this.pnlSoLuong.BackColor = System.Drawing.Color.White;
            this.pnlSoLuong.Controls.Add(this.txtSolUong);
            this.pnlSoLuong.Controls.Add(this.txtSoLuongCTPN);
            this.pnlSoLuong.Location = new System.Drawing.Point(27, 78);
            this.pnlSoLuong.Name = "pnlSoLuong";
            this.pnlSoLuong.Size = new System.Drawing.Size(390, 42);
            this.pnlSoLuong.TabIndex = 5;
            // 
            // txtSoLuongCTPN
            // 
            this.txtSoLuongCTPN.AutoSize = true;
            this.txtSoLuongCTPN.Location = new System.Drawing.Point(14, 9);
            this.txtSoLuongCTPN.Name = "txtSoLuongCTPN";
            this.txtSoLuongCTPN.Size = new System.Drawing.Size(97, 25);
            this.txtSoLuongCTPN.TabIndex = 0;
            this.txtSoLuongCTPN.Text = "Số Lượng";
            // 
            // txtSolUong
            // 
            this.txtSolUong.BackColor = System.Drawing.Color.White;
            this.txtSolUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolUong.Location = new System.Drawing.Point(144, 11);
            this.txtSolUong.Multiline = true;
            this.txtSolUong.Name = "txtSolUong";
            this.txtSolUong.Size = new System.Drawing.Size(246, 35);
            this.txtSolUong.TabIndex = 1;
            this.txtSolUong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSolUong_KeyPress);
            // 
            // frmQLVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1055);
            this.Controls.Add(this.tctChinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLVaccine";
            this.Text = "Quản Lý Vaccine";
            this.Load += new System.EventHandler(this.frmQLVaccine_Load);
            this.tctChinh.ResumeLayout(false);
            this.tabKhoVaccine.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlThongBao.ResumeLayout(false);
            this.pnlTb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccine)).EndInit();
            this.cntXoaSua.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlLocXuatXu.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabNhapVC.ResumeLayout(false);
            this.pnl2_VungThemNVC.ResumeLayout(false);
            this.pnl_2_TaoPhieuNhap.ResumeLayout(false);
            this.pnl2_PN.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlTongTien.ResumeLayout(false);
            this.pnlTongTien.PerformLayout();
            this.pnl2_ngaynhap.ResumeLayout(false);
            this.pnl2_ngaynhap.PerformLayout();
            this.pnl2_ncc.ResumeLayout(false);
            this.pnl2_ncc.PerformLayout();
            this.pnl2_maphieu.ResumeLayout(false);
            this.pnl2_maphieu.PerformLayout();
            this.grb2_ShowVCDuocChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachVCduocChon)).EndInit();
            this.grbDSVC.ResumeLayout(false);
            this.pnlThongBaoTab2.ResumeLayout(false);
            this.pnlThongBaotab2s.ResumeLayout(false);
            this.pnlThongBaotab2s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTPN)).EndInit();
            this.tabPageThem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlTb3.ResumeLayout(false);
            this.pnlTb3s.ResumeLayout(false);
            this.pnlTb3s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiVC)).EndInit();
            this.grb2_ChiTietPhieuNhap.ResumeLayout(false);
            this.pnl2tenvaccine.ResumeLayout(false);
            this.pnl2tenvaccine.PerformLayout();
            this.pnl2dongia.ResumeLayout(false);
            this.pnl2dongia.PerformLayout();
            this.pnlThanhTien.ResumeLayout(false);
            this.pnlThanhTien.PerformLayout();
            this.pnlSoLuong.ResumeLayout(false);
            this.pnlSoLuong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tctChinh;
        private TabPage tabKhoVaccine;
        private ImageList imageList1;
        private Button btnSearch;
        private Button btnThemVC;
        private Panel pnlTimKiem;
        private ComboBox cboLoaiVC;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private Panel pnlLoc;
        private Panel panel1;
        private DataGridView dgvVaccine;
        private Label lblMaloaivctmp;
        private Label lblXuatXu;
        private Panel pnlLocXuatXu;
        private ComboBox cboXuatXu;
        private Button btnLuu;
        private ContextMenuStrip cntXoaSua;
        private ToolStripMenuItem CapNhatToolStripMenuItem;
        private ToolStripMenuItem XoaVaccineToolStripMenuItem;
        private Panel pnlThongBao;
        private Panel pnlTb;
        private PictureBox pictureBox1;
        private Label lblndtb;
        private System.Windows.Forms.Timer timerTB;
        private TabPage tabNhapVC;
        private Panel pnl2_VungThemNVC;
        private GroupBox grbDSVC;
        private GroupBox grb2_ShowVCDuocChon;
        private DataGridView dtgDanhSachVCduocChon;
        private DataGridView dtgCTPN;
        private Panel pnl_2_TaoPhieuNhap;
        private Panel pnl2_ncc;
        private ComboBox cboNCC;
        private Label label4;
        private Panel pnl2_ngaynhap;
        private DateTimePicker dteNgayNhap;
        private Label label5;
        private Button btnTaoPhieuNhap;
        private ToolTip toolTip;
        private Button btnLuuPhieuNhap;
        private Panel panel3;
        private GroupBox pnl2_PN;
        private Panel pnl2_maphieu;
        private TextBox txtMaPhieuN;
        private Label label1;
        private Panel pnlTongTien;
        private TextBox txtTongTien;
        private Label label2;
        private Label label3;
        private Panel pnlThongBaotab2s;
        private Panel pnlThongBaoTab2;
        private PictureBox pictureBox3;
        private Label txtndthongbaotab2;
        private System.Windows.Forms.Timer timerTB_Tab2;
        private TabPage tabPageThem;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dgvLoaiVC;
        private DataGridView dgvNCC;
        private Button btnThemLoaiVC;
        private Button btnCapNhatLoaiVaccine;
        private Button btnXoaLoaiVC;
        private Label label8;
        private Button LuuLoaiVaccine;
        private Button btnSaveNCC;
        private Button btnCapNhatNCC;
        private Button btnXoaNCC;
        private Button btnThemNCC;
        private Label label9;
        private Panel pnlTb3;
        private Panel pnlTb3s;
        private PictureBox pictureBox4;
        private TextBox lblndTab3;
        private System.Windows.Forms.Timer TimeTab3;
        private Button btnInPhieuNhap;
        private Button button1;
        private Button button2;
        private Panel panel6;
        private DateTimePicker dthsd;
        private Label label11;
        private Panel panel5;
        private DateTimePicker dtnsx;
        private Label label10;
        private GroupBox grb2_ChiTietPhieuNhap;
        private Panel pnlSoLuong;
        private TextBox txtSolUong;
        private Label txtSoLuongCTPN;
        private Panel pnlThanhTien;
        private Label label6;
        private TextBox txtThanhTien;
        private Label dsd;
        private Button btnCapNhatCTPN;
        private Button btnXoaCTPN;
        private Button btnThemCTPN;
        private Panel pnl2dongia;
        private TextBox txtDonGiaCTPN;
        private Label label7;
        private Panel pnl2tenvaccine;
        private TextBox txtTenVCCTPN;
        private Label label16;
    }
}