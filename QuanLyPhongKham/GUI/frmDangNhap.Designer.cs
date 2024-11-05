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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnDangNhap = new Button();
            chbShowpass = new CheckBox();
            btnThoat = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            txtTaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            txtMatKhau = new TextBox();
            labLoiTaiKhoan = new Label();
            lblLoiMatKhau = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnThoat).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dangnhap;
            pictureBox2.Location = new Point(57, 62);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(294, 294);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Gotham Rounded", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(468, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 20;
            label1.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Aquamarine;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.Font = new Font("SVN-Oscine", 14.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(410, 261);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(333, 54);
            btnDangNhap.TabIndex = 19;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click_1;
            // 
            // chbShowpass
            // 
            chbShowpass.AutoSize = true;
            chbShowpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbShowpass.ForeColor = SystemColors.ControlDarkDark;
            chbShowpass.Location = new Point(410, 336);
            chbShowpass.Name = "chbShowpass";
            chbShowpass.Size = new Size(169, 27);
            chbShowpass.TabIndex = 22;
            chbShowpass.Text = "Hiển thị mật khẩu";
            chbShowpass.UseVisualStyleBackColor = true;
            chbShowpass.CheckedChanged += chbShowpass_CheckedChanged;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(809, 13);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(25, 28);
            btnThoat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThoat.TabIndex = 23;
            btnThoat.TabStop = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(410, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 44);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtTaiKhoan);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 44);
            panel2.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 3);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(57, 6);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(271, 31);
            txtTaiKhoan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(57, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 31);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(txtMatKhau);
            panel3.Location = new Point(410, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 44);
            panel3.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = Properties.Resources.login_8717908;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 3);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(57, 6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(271, 31);
            txtMatKhau.TabIndex = 0;
            // 
            // labLoiTaiKhoan
            // 
            labLoiTaiKhoan.AutoSize = true;
            labLoiTaiKhoan.ForeColor = Color.Red;
            labLoiTaiKhoan.Location = new Point(410, 82);
            labLoiTaiKhoan.Name = "labLoiTaiKhoan";
            labLoiTaiKhoan.Size = new Size(0, 25);
            labLoiTaiKhoan.TabIndex = 28;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(410, 157);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 25);
            lblLoiMatKhau.TabIndex = 29;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 418);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(labLoiTaiKhoan);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(chbShowpass);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnThoat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Button btnDangNhap;
        private CheckBox chbShowpass;
        private PictureBox btnThoat;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private TextBox txtTaiKhoan;
        private Panel panel3;
        private PictureBox pictureBox4;
        private TextBox txtMatKhau;
        private Label labLoiTaiKhoan;
        private Label lblLoiMatKhau;
    }
}