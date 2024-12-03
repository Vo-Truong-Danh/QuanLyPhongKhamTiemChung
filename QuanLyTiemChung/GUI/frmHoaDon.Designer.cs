namespace GUI
{
    partial class frmHoaDon
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
            this.dtpFilterNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.ccbFilterNhanVien = new System.Windows.Forms.ComboBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstvDSHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTTHD = new System.Windows.Forms.Panel();
            this.txtTTBN = new System.Windows.Forms.TextBox();
            this.txtTTNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTTTT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstvTTVC = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.pnlTTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFilterNgayLap
            // 
            this.dtpFilterNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterNgayLap.Location = new System.Drawing.Point(309, 73);
            this.dtpFilterNgayLap.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFilterNgayLap.Name = "dtpFilterNgayLap";
            this.dtpFilterNgayLap.Size = new System.Drawing.Size(131, 31);
            this.dtpFilterNgayLap.TabIndex = 114;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.IndianRed;
            this.btnFilter.Location = new System.Drawing.Point(447, 71);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(105, 38);
            this.btnFilter.TabIndex = 113;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Transparent;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Location = new System.Drawing.Point(571, 28);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 80);
            this.btnDong.TabIndex = 112;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // ccbFilterNhanVien
            // 
            this.ccbFilterNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ccbFilterNhanVien.FormattingEnabled = true;
            this.ccbFilterNhanVien.Location = new System.Drawing.Point(168, 71);
            this.ccbFilterNhanVien.Margin = new System.Windows.Forms.Padding(5);
            this.ccbFilterNhanVien.Name = "ccbFilterNhanVien";
            this.ccbFilterNhanVien.Size = new System.Drawing.Size(127, 40);
            this.ccbFilterNhanVien.TabIndex = 111;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.Transparent;
            this.btnInHD.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInHD.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(957, 30);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(0);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(249, 80);
            this.btnInHD.TabIndex = 110;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 109;
            this.label3.Text = "Lọc theo:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.IndianRed;
            this.btnTimKiem.Location = new System.Drawing.Point(447, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 38);
            this.btnTimKiem.TabIndex = 108;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(166, 28);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(273, 36);
            this.txtTimKiem.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 106;
            this.label2.Text = "Nội dung :";
            // 
            // lstvDSHD
            // 
            this.lstvDSHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstvDSHD.FullRowSelect = true;
            this.lstvDSHD.HideSelection = false;
            this.lstvDSHD.Location = new System.Drawing.Point(36, 130);
            this.lstvDSHD.Name = "lstvDSHD";
            this.lstvDSHD.Size = new System.Drawing.Size(1170, 1069);
            this.lstvDSHD.TabIndex = 127;
            this.lstvDSHD.UseCompatibleStateImageBehavior = false;
            this.lstvDSHD.View = System.Windows.Forms.View.Details;
            this.lstvDSHD.ItemActivate += new System.EventHandler(this.lstvDSHD_ItemActivate);
            this.lstvDSHD.SelectedIndexChanged += new System.EventHandler(this.lstvDSHD_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "mã hóa đơn";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "mã bệnh nhân";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "mã nhân viên";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ngày lập ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "tổng tiền";
            this.columnHeader5.Width = 190;
            // 
            // pnlTTHD
            // 
            this.pnlTTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTTHD.Controls.Add(this.txtTTBN);
            this.pnlTTHD.Controls.Add(this.txtTTNV);
            this.pnlTTHD.Controls.Add(this.label12);
            this.pnlTTHD.Controls.Add(this.lblTTTT);
            this.pnlTTHD.Controls.Add(this.label5);
            this.pnlTTHD.Controls.Add(this.lblNgayLap);
            this.pnlTTHD.Controls.Add(this.label4);
            this.pnlTTHD.Controls.Add(this.lblMaHD);
            this.pnlTTHD.Controls.Add(this.label9);
            this.pnlTTHD.Controls.Add(this.label10);
            this.pnlTTHD.Controls.Add(this.lstvTTVC);
            this.pnlTTHD.Controls.Add(this.label8);
            this.pnlTTHD.Controls.Add(this.label11);
            this.pnlTTHD.Controls.Add(this.label14);
            this.pnlTTHD.Location = new System.Drawing.Point(1217, 130);
            this.pnlTTHD.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTTHD.Name = "pnlTTHD";
            this.pnlTTHD.Size = new System.Drawing.Size(640, 744);
            this.pnlTTHD.TabIndex = 130;
            // 
            // txtTTBN
            // 
            this.txtTTBN.Location = new System.Drawing.Point(228, 209);
            this.txtTTBN.Multiline = true;
            this.txtTTBN.Name = "txtTTBN";
            this.txtTTBN.Size = new System.Drawing.Size(355, 33);
            this.txtTTBN.TabIndex = 120;
            // 
            // txtTTNV
            // 
            this.txtTTNV.Location = new System.Drawing.Point(228, 158);
            this.txtTTNV.Multiline = true;
            this.txtTTNV.Name = "txtTTNV";
            this.txtTTNV.Size = new System.Drawing.Size(355, 33);
            this.txtTTNV.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(522, 533);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 30);
            this.label12.TabIndex = 115;
            this.label12.Text = "VNĐ";
            // 
            // lblTTTT
            // 
            this.lblTTTT.AutoSize = true;
            this.lblTTTT.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTTTT.Location = new System.Drawing.Point(386, 519);
            this.lblTTTT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTTTT.Name = "lblTTTT";
            this.lblTTTT.Size = new System.Drawing.Size(38, 45);
            this.lblTTTT.TabIndex = 114;
            this.lblTTTT.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 30);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tổng tiền:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(29, 42);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(217, 25);
            this.lblNgayLap.TabIndex = 105;
            this.lblNgayLap.Text = "Ngày lập: 12/12/2024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 37);
            this.label4.TabIndex = 112;
            this.label4.Text = "Danh mục Vaxcin";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(29, 17);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(216, 25);
            this.lblMaHD.TabIndex = 104;
            this.lblMaHD.Text = "Mã hóa đơn:   HD001";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(51, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 36);
            this.label9.TabIndex = 110;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(72, 208);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 30);
            this.label10.TabIndex = 109;
            this.label10.Text = "Bệnh nhân :";
            // 
            // lstvTTVC
            // 
            this.lstvTTVC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstvTTVC.FullRowSelect = true;
            this.lstvTTVC.HideSelection = false;
            this.lstvTTVC.Location = new System.Drawing.Point(51, 302);
            this.lstvTTVC.Margin = new System.Windows.Forms.Padding(5);
            this.lstvTTVC.Name = "lstvTTVC";
            this.lstvTTVC.Size = new System.Drawing.Size(532, 129);
            this.lstvTTVC.TabIndex = 96;
            this.lstvTTVC.UseCompatibleStateImageBehavior = false;
            this.lstvTTVC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã hóa đơn";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã vaccine";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Đơn giá";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ngày tiêm";
            this.columnHeader11.Width = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(447, 65);
            this.label8.TabIndex = 95;
            this.label8.Text = "Thông tin hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(51, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 36);
            this.label11.TabIndex = 92;
            this.label11.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(72, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 30);
            this.label14.TabIndex = 84;
            this.label14.Text = "Nhân viên :";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaHD.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaHD.ForeColor = System.Drawing.Color.Crimson;
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(690, 29);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(249, 80);
            this.btnXoaHD.TabIndex = 119;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 1214);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.pnlTTHD);
            this.Controls.Add(this.lstvDSHD);
            this.Controls.Add(this.dtpFilterNgayLap);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.ccbFilterNhanVien);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Name = "frmHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.pnlTTHD.ResumeLayout(false);
            this.pnlTTHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFilterNgayLap;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox ccbFilterNhanVien;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstvDSHD;
        private System.Windows.Forms.Panel pnlTTHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTTTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lstvTTVC;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.TextBox txtTTBN;
        private System.Windows.Forms.TextBox txtTTNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}