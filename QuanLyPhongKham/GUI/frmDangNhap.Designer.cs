namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pctmain = new PictureBox();
            label1 = new Label();
            btnDangNhap = new Button();
            pnlTaiKhoan = new Panel();
            pnlMatkhau = new Panel();
            btnAnpass = new PictureBox();
            pictureBox4 = new PictureBox();
            btnHienpass = new PictureBox();
            txtMatKhau = new TextBox();
            pctHU = new PictureBox();
            labLoiTaiKhoan = new Label();
            lblLoiMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            pictureBox3 = new PictureBox();
            lblsai = new Label();
            timer = new System.Windows.Forms.Timer(components);
            timerSaiTK = new System.Windows.Forms.Timer(components);
            btnThoat = new PictureBox();
            HU = new System.Windows.Forms.Timer(components);
            pnlHuGoc = new Panel();
            ((System.ComponentModel.ISupportInitialize)pctmain).BeginInit();
            pnlMatkhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAnpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHienpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctHU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnThoat).BeginInit();
            pnlHuGoc.SuspendLayout();
            SuspendLayout();
            // 
            // pctmain
            // 
            pctmain.Image = Properties.Resources.dangnhap;
            pctmain.Location = new Point(38, 82);
            pctmain.Margin = new Padding(4);
            pctmain.Name = "pctmain";
            pctmain.Size = new Size(294, 294);
            pctmain.SizeMode = PictureBoxSizeMode.StretchImage;
            pctmain.TabIndex = 21;
            pctmain.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Gotham Rounded", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 20;
            label1.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(0, 237, 250);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("SVN-Oscine", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(391, 307);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(351, 54);
            btnDangNhap.TabIndex = 19;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click_1;
            // 
            // pnlTaiKhoan
            // 
            pnlTaiKhoan.BackColor = Color.FromArgb(224, 224, 224);
            pnlTaiKhoan.Location = new Point(391, 124);
            pnlTaiKhoan.Name = "pnlTaiKhoan";
            pnlTaiKhoan.Size = new Size(351, 54);
            pnlTaiKhoan.TabIndex = 24;
            // 
            // pnlMatkhau
            // 
            pnlMatkhau.BackColor = Color.FromArgb(224, 224, 224);
            pnlMatkhau.Controls.Add(btnAnpass);
            pnlMatkhau.Controls.Add(pictureBox4);
            pnlMatkhau.Controls.Add(btnHienpass);
            pnlMatkhau.Controls.Add(txtMatKhau);
            pnlMatkhau.Location = new Point(391, 217);
            pnlMatkhau.Name = "pnlMatkhau";
            pnlMatkhau.Size = new Size(351, 54);
            pnlMatkhau.TabIndex = 27;
            // 
            // btnAnpass
            // 
            btnAnpass.BackColor = Color.FromArgb(224, 224, 224);
            btnAnpass.ErrorImage = Properties.Resources.login_8717908;
            btnAnpass.Image = (Image)resources.GetObject("btnAnpass.Image");
            btnAnpass.Location = new Point(292, 8);
            btnAnpass.Margin = new Padding(4);
            btnAnpass.Name = "btnAnpass";
            btnAnpass.Size = new Size(36, 34);
            btnAnpass.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAnpass.TabIndex = 30;
            btnAnpass.TabStop = false;
            btnAnpass.Click += btnAnpass_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox4.ErrorImage = Properties.Resources.login_8717908;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 9);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // btnHienpass
            // 
            btnHienpass.BackColor = Color.FromArgb(224, 224, 224);
            btnHienpass.ErrorImage = Properties.Resources.login_8717908;
            btnHienpass.Image = (Image)resources.GetObject("btnHienpass.Image");
            btnHienpass.Location = new Point(294, 10);
            btnHienpass.Margin = new Padding(4);
            btnHienpass.Name = "btnHienpass";
            btnHienpass.Size = new Size(32, 30);
            btnHienpass.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHienpass.TabIndex = 26;
            btnHienpass.TabStop = false;
            btnHienpass.Click += btnHienpass_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(224, 224, 224);
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(68, 12);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(248, 31);
            txtMatKhau.TabIndex = 0;
            // 
            // pctHU
            // 
            pctHU.Image = (Image)resources.GetObject("pctHU.Image");
            pctHU.Location = new Point(236, 67);
            pctHU.Margin = new Padding(4);
            pctHU.Name = "pctHU";
            pctHU.Size = new Size(294, 294);
            pctHU.SizeMode = PictureBoxSizeMode.StretchImage;
            pctHU.TabIndex = 31;
            pctHU.TabStop = false;
            // 
            // labLoiTaiKhoan
            // 
            labLoiTaiKhoan.AutoSize = true;
            labLoiTaiKhoan.ForeColor = Color.Red;
            labLoiTaiKhoan.Location = new Point(391, 95);
            labLoiTaiKhoan.Name = "labLoiTaiKhoan";
            labLoiTaiKhoan.Size = new Size(0, 25);
            labLoiTaiKhoan.TabIndex = 28;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(391, 182);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 25);
            lblLoiMatKhau.TabIndex = 29;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.FromArgb(224, 224, 224);
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(459, 136);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PlaceholderText = "Tài khoản";
            txtTaiKhoan.Size = new Size(250, 31);
            txtTaiKhoan.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(411, 133);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // lblsai
            // 
            lblsai.AutoSize = true;
            lblsai.ForeColor = Color.Red;
            lblsai.Location = new Point(391, 276);
            lblsai.Name = "lblsai";
            lblsai.Size = new Size(0, 25);
            lblsai.TabIndex = 30;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // timerSaiTK
            // 
            timerSaiTK.Interval = 4000;
            timerSaiTK.Tick += timerSaiTK_Tick;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(760, 31);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(27, 28);
            btnThoat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThoat.TabIndex = 23;
            btnThoat.TabStop = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // HU
            // 
            HU.Interval = 3200;
            HU.Tick += HU_Tick;
            // 
            // pnlHuGoc
            // 
            pnlHuGoc.BackColor = Color.White;
            pnlHuGoc.Controls.Add(pctHU);
            pnlHuGoc.Controls.Add(pnlMatkhau);
            pnlHuGoc.Controls.Add(btnDangNhap);
            pnlHuGoc.Controls.Add(label1);
            pnlHuGoc.Controls.Add(lblsai);
            pnlHuGoc.Controls.Add(pctmain);
            pnlHuGoc.Controls.Add(pictureBox3);
            pnlHuGoc.Controls.Add(btnThoat);
            pnlHuGoc.Controls.Add(txtTaiKhoan);
            pnlHuGoc.Controls.Add(pnlTaiKhoan);
            pnlHuGoc.Controls.Add(lblLoiMatKhau);
            pnlHuGoc.Controls.Add(labLoiTaiKhoan);
            pnlHuGoc.Location = new Point(3, 3);
            pnlHuGoc.Name = "pnlHuGoc";
            pnlHuGoc.Size = new Size(822, 410);
            pnlHuGoc.TabIndex = 32;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 415);
            Controls.Add(pnlHuGoc);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            Load += frmDangNhap_Load;
            KeyUp += frmDangNhap_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pctmain).EndInit();
            pnlMatkhau.ResumeLayout(false);
            pnlMatkhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAnpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHienpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctHU).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnThoat).EndInit();
            pnlHuGoc.ResumeLayout(false);
            pnlHuGoc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctmain;
        private Label label1;
        private Button btnDangNhap;
        private Panel pnlTaiKhoan;
        private Panel pnlMatkhau;
        private PictureBox pictureBox4;
        private TextBox txtMatKhau;
        private Label labLoiTaiKhoan;
        private Label lblLoiMatKhau;
        private TextBox txtTaiKhoan;
        private PictureBox pictureBox3;
        private PictureBox btnHienpass;
        private PictureBox btnAnpass;
        private Label lblsai;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerSaiTK;
        private PictureBox btnThoat;
        private PictureBox pctHU;
        private System.Windows.Forms.Timer HU;
        private Panel pnlHuGoc;
    }
}