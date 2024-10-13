namespace GUI
{
    partial class frmDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            chkbHienThiMK = new CheckBox();
            btnDangKi = new Button();
            label4 = new Label();
            txtHoTen = new TextBox();
            label5 = new Label();
            txtNhapLaiMK = new TextBox();
            errMK = new ErrorProvider(components);
            errNhapLaiMK = new ErrorProvider(components);
            errHoTen = new ErrorProvider(components);
            errTaiKhoan = new ErrorProvider(components);
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)errMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errNhapLaiMK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F);
            label1.Location = new Point(154, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(490, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ NGƯỜI QUẢN TRỊ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14F);
            label2.Location = new Point(48, 203);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14F);
            label3.Location = new Point(48, 268);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 29);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Verdana", 14F);
            txtTaiKhoan.Location = new Point(277, 200);
            txtTaiKhoan.Margin = new Padding(2, 2, 2, 2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(438, 36);
            txtTaiKhoan.TabIndex = 3;
            txtTaiKhoan.TextChanged += txtTaiKhoan_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Verdana", 14F);
            txtMatKhau.Location = new Point(277, 265);
            txtMatKhau.Margin = new Padding(2, 2, 2, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(438, 36);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // chkbHienThiMK
            // 
            chkbHienThiMK.AutoSize = true;
            chkbHienThiMK.Font = new Font("Arial", 10F);
            chkbHienThiMK.Location = new Point(277, 383);
            chkbHienThiMK.Margin = new Padding(2, 2, 2, 2);
            chkbHienThiMK.Name = "chkbHienThiMK";
            chkbHienThiMK.Size = new Size(157, 23);
            chkbHienThiMK.TabIndex = 5;
            chkbHienThiMK.Text = "Hiển thị mật khẩu";
            chkbHienThiMK.UseVisualStyleBackColor = true;
            chkbHienThiMK.CheckedChanged += chkbHienThiMK_CheckedChanged;
            // 
            // btnDangKi
            // 
            btnDangKi.FlatStyle = FlatStyle.Popup;
            btnDangKi.Font = new Font("Verdana", 15F);
            btnDangKi.Location = new Point(294, 426);
            btnDangKi.Margin = new Padding(2, 2, 2, 2);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(128, 49);
            btnDangKi.TabIndex = 6;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14F);
            label4.Location = new Point(48, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 29);
            label4.TabIndex = 1;
            label4.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Verdana", 14F);
            txtHoTen.Location = new Point(277, 135);
            txtHoTen.Margin = new Padding(2, 2, 2, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(438, 36);
            txtHoTen.TabIndex = 3;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14F);
            label5.Location = new Point(48, 333);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(229, 29);
            label5.TabIndex = 2;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMK
            // 
            txtNhapLaiMK.Font = new Font("Verdana", 14F);
            txtNhapLaiMK.Location = new Point(277, 330);
            txtNhapLaiMK.Margin = new Padding(2, 2, 2, 2);
            txtNhapLaiMK.Name = "txtNhapLaiMK";
            txtNhapLaiMK.PasswordChar = '*';
            txtNhapLaiMK.Size = new Size(438, 36);
            txtNhapLaiMK.TabIndex = 4;
            txtNhapLaiMK.Click += txtNhapLaiMK_Click;
            txtNhapLaiMK.TextChanged += txtNhapLaiMK_TextChanged;
            // 
            // errMK
            // 
            errMK.ContainerControl = this;
            // 
            // errNhapLaiMK
            // 
            errNhapLaiMK.ContainerControl = this;
            // 
            // errHoTen
            // 
            errHoTen.ContainerControl = this;
            // 
            // errTaiKhoan
            // 
            errTaiKhoan.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 109);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 7;
            label6.Text = "VD: Nguyễn Văn A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 178);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 7;
            label7.Text = "VD : taurusss1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(277, 242);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(448, 20);
            label8.TabIndex = 7;
            label8.Text = "Dài từ 10 ký tự bao gồm chữ hoa, chữ thường, ký tự đặc biệc và số";
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 507);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnDangKi);
            Controls.Add(chkbHienThiMK);
            Controls.Add(txtNhapLaiMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtHoTen);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmDangKy";
            Text = "Đăng ký tài khoản người dùng";
            ((System.ComponentModel.ISupportInitialize)errMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errNhapLaiMK).EndInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox chkbHienThiMK;
        private Button btnDangKi;
        private Label label4;
        private TextBox txtHoTen;
        private Label label5;
        private TextBox txtNhapLaiMK;
        private ErrorProvider errMK;
        private ErrorProvider errNhapLaiMK;
        private ErrorProvider errHoTen;
        private ErrorProvider errTaiKhoan;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
