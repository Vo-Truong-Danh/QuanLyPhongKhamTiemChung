namespace GUI
{
    partial class frm_ThemVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemVaccine));
            btnThoat = new PictureBox();
            pnlTenVc = new Panel();
            txtTenVC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dteNSX = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            pnlNSX = new Panel();
            pnlHSD = new Panel();
            dteHSD = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pnlGia = new Panel();
            txtGia = new TextBox();
            label9 = new Label();
            label10 = new Label();
            pnlXuatXu = new Panel();
            txtXuatXu = new TextBox();
            label11 = new Label();
            btnLuu = new Button();
            label12 = new Label();
            pnlLoai = new Panel();
            cboLoaiVC = new ComboBox();
            lblLoaiVC = new Label();
            error = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)btnThoat).BeginInit();
            pnlTenVc.SuspendLayout();
            pnlNSX.SuspendLayout();
            pnlHSD.SuspendLayout();
            pnlGia.SuspendLayout();
            pnlXuatXu.SuspendLayout();
            pnlLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(903, 39);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(19, 18);
            btnThoat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThoat.TabIndex = 25;
            btnThoat.TabStop = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pnlTenVc
            // 
            pnlTenVc.BackColor = Color.White;
            pnlTenVc.Controls.Add(txtTenVC);
            pnlTenVc.Location = new Point(49, 154);
            pnlTenVc.Margin = new Padding(4, 3, 4, 3);
            pnlTenVc.Name = "pnlTenVc";
            pnlTenVc.Size = new Size(377, 55);
            pnlTenVc.TabIndex = 28;
            // 
            // txtTenVC
            // 
            txtTenVC.BackColor = Color.White;
            txtTenVC.BorderStyle = BorderStyle.None;
            txtTenVC.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenVC.Location = new Point(21, 15);
            txtTenVC.Margin = new Padding(4, 3, 4, 3);
            txtTenVC.Multiline = true;
            txtTenVC.Name = "txtTenVC";
            txtTenVC.PlaceholderText = "Nhập tên loại Vaccine bạn muốn thêm";
            txtTenVC.Size = new Size(339, 37);
            txtTenVC.TabIndex = 0;
            txtTenVC.KeyPress += txtTenVC_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(67, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 29;
            label1.Text = "Tên Vaccine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Gotham Rounded", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(349, 37);
            label2.TabIndex = 30;
            label2.Text = "Thông Tin Vaccine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(46, 113);
            label3.Name = "label3";
            label3.Size = new Size(27, 36);
            label3.TabIndex = 31;
            label3.Text = "*";
            // 
            // dteNSX
            // 
            dteNSX.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteNSX.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dteNSX.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dteNSX.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteNSX.Location = new Point(33, 9);
            dteNSX.Margin = new Padding(130, 13, 130, 13);
            dteNSX.Name = "dteNSX";
            dteNSX.Size = new Size(312, 34);
            dteNSX.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(548, 113);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 33;
            label4.Text = "Ngày Sản Xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(527, 111);
            label5.Name = "label5";
            label5.Size = new Size(27, 36);
            label5.TabIndex = 34;
            label5.Text = "*";
            // 
            // pnlNSX
            // 
            pnlNSX.BackColor = Color.White;
            pnlNSX.Controls.Add(dteNSX);
            pnlNSX.Location = new Point(530, 154);
            pnlNSX.Margin = new Padding(4, 3, 4, 3);
            pnlNSX.Name = "pnlNSX";
            pnlNSX.Size = new Size(377, 55);
            pnlNSX.TabIndex = 29;
            // 
            // pnlHSD
            // 
            pnlHSD.BackColor = Color.White;
            pnlHSD.Controls.Add(dteHSD);
            pnlHSD.Location = new Point(530, 270);
            pnlHSD.Margin = new Padding(4, 3, 4, 3);
            pnlHSD.Name = "pnlHSD";
            pnlHSD.Size = new Size(377, 55);
            pnlHSD.TabIndex = 35;
            // 
            // dteHSD
            // 
            dteHSD.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteHSD.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dteHSD.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dteHSD.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dteHSD.Location = new Point(33, 9);
            dteHSD.Margin = new Padding(130, 13, 130, 13);
            dteHSD.Name = "dteHSD";
            dteHSD.Size = new Size(312, 34);
            dteHSD.TabIndex = 0;
            dteHSD.Value = new DateTime(2026, 12, 24, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(527, 231);
            label6.Name = "label6";
            label6.Size = new Size(27, 36);
            label6.TabIndex = 37;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(548, 233);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 36;
            label7.Text = "Hạn Sử Dụng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(49, 344);
            label8.Name = "label8";
            label8.Size = new Size(27, 36);
            label8.TabIndex = 40;
            label8.Text = "*";
            // 
            // pnlGia
            // 
            pnlGia.BackColor = Color.White;
            pnlGia.Controls.Add(txtGia);
            pnlGia.Location = new Point(52, 385);
            pnlGia.Margin = new Padding(4, 3, 4, 3);
            pnlGia.Name = "pnlGia";
            pnlGia.Size = new Size(377, 55);
            pnlGia.TabIndex = 38;
            // 
            // txtGia
            // 
            txtGia.BackColor = Color.White;
            txtGia.BorderStyle = BorderStyle.None;
            txtGia.Font = new Font("Microsoft Sans Serif", 12F);
            txtGia.Location = new Point(21, 15);
            txtGia.Margin = new Padding(0);
            txtGia.Multiline = true;
            txtGia.Name = "txtGia";
            txtGia.PlaceholderText = "Nhập giá loại Vaccine bạn muốn thêm";
            txtGia.Size = new Size(339, 37);
            txtGia.TabIndex = 0;
            txtGia.KeyPress += txtGia_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(70, 346);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 39;
            label9.Text = "Giá Vacine";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(524, 344);
            label10.Name = "label10";
            label10.Size = new Size(27, 36);
            label10.TabIndex = 43;
            label10.Text = "*";
            // 
            // pnlXuatXu
            // 
            pnlXuatXu.BackColor = Color.White;
            pnlXuatXu.Controls.Add(txtXuatXu);
            pnlXuatXu.Location = new Point(527, 385);
            pnlXuatXu.Margin = new Padding(4, 3, 4, 3);
            pnlXuatXu.Name = "pnlXuatXu";
            pnlXuatXu.Size = new Size(377, 55);
            pnlXuatXu.TabIndex = 41;
            // 
            // txtXuatXu
            // 
            txtXuatXu.BackColor = Color.White;
            txtXuatXu.BorderStyle = BorderStyle.None;
            txtXuatXu.Font = new Font("Microsoft Sans Serif", 12F);
            txtXuatXu.Location = new Point(21, 15);
            txtXuatXu.Margin = new Padding(4, 3, 4, 3);
            txtXuatXu.Multiline = true;
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.PlaceholderText = "Nhập nguồn gốc của Vaccine vào đây";
            txtXuatXu.Size = new Size(339, 37);
            txtXuatXu.TabIndex = 0;
            txtXuatXu.KeyPress += txtXuatXu_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(545, 346);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 25);
            label11.TabIndex = 42;
            label11.Text = "Xuất xứ";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DarkSlateGray;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.OldLace;
            btnLuu.Location = new Point(290, 483);
            btnLuu.Margin = new Padding(0);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(377, 55);
            btnLuu.TabIndex = 44;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnDangNhap_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(49, 233);
            label12.Name = "label12";
            label12.Size = new Size(27, 36);
            label12.TabIndex = 47;
            label12.Text = "*";
            // 
            // pnlLoai
            // 
            pnlLoai.BackColor = Color.White;
            pnlLoai.Controls.Add(cboLoaiVC);
            pnlLoai.Location = new Point(52, 274);
            pnlLoai.Margin = new Padding(4, 3, 4, 3);
            pnlLoai.Name = "pnlLoai";
            pnlLoai.Size = new Size(377, 55);
            pnlLoai.TabIndex = 45;
            // 
            // cboLoaiVC
            // 
            cboLoaiVC.FlatStyle = FlatStyle.Flat;
            cboLoaiVC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiVC.FormattingEnabled = true;
            cboLoaiVC.Location = new Point(20, 11);
            cboLoaiVC.Name = "cboLoaiVC";
            cboLoaiVC.Size = new Size(339, 33);
            cboLoaiVC.TabIndex = 0;
            // 
            // lblLoaiVC
            // 
            lblLoaiVC.AutoSize = true;
            lblLoaiVC.BackColor = Color.Transparent;
            lblLoaiVC.Font = new Font("Microsoft Sans Serif", 12F);
            lblLoaiVC.Location = new Point(70, 235);
            lblLoaiVC.Margin = new Padding(4, 0, 4, 0);
            lblLoaiVC.Name = "lblLoaiVC";
            lblLoaiVC.Size = new Size(115, 25);
            lblLoaiVC.TabIndex = 46;
            lblLoaiVC.Text = "Loại Vacine";
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // frm_ThemVaccine
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(960, 586);
            Controls.Add(label12);
            Controls.Add(pnlLoai);
            Controls.Add(lblLoaiVC);
            Controls.Add(btnLuu);
            Controls.Add(label10);
            Controls.Add(pnlXuatXu);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(pnlGia);
            Controls.Add(label9);
            Controls.Add(pnlHSD);
            Controls.Add(label6);
            Controls.Add(pnlNSX);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlTenVc);
            Controls.Add(btnThoat);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 10.8F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_ThemVaccine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_ThemVaccine";
            Load += frm_ThemVaccine_Load;
            ((System.ComponentModel.ISupportInitialize)btnThoat).EndInit();
            pnlTenVc.ResumeLayout(false);
            pnlTenVc.PerformLayout();
            pnlNSX.ResumeLayout(false);
            pnlHSD.ResumeLayout(false);
            pnlGia.ResumeLayout(false);
            pnlGia.PerformLayout();
            pnlXuatXu.ResumeLayout(false);
            pnlXuatXu.PerformLayout();
            pnlLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnThoat;
        private Panel pnlTenVc;
        private TextBox txtTenVC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dteNSX;
        private Panel pnlNSX;
        private Panel pnlHSD;
        private DateTimePicker dteHSD;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel pnlGia;
        private TextBox txtGia;
        private Label label9;
        private Label label10;
        private Panel pnlXuatXu;
        private TextBox txtXuatXu;
        private Label label11;
        private Button btnLuu;
        private Label label12;
        private Panel pnlLoai;
        private ComboBox cboLoaiVC;
        private Label lblLoaiVC;
        private ErrorProvider error;
    }
}