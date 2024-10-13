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
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.FlatStyle = FlatStyle.Popup;
            btnDangNhap.Font = new Font("Verdana", 15F);
            btnDangNhap.Location = new Point(349, 286);
            btnDangNhap.Margin = new Padding(2);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(205, 49);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Verdana", 14F);
            txtMatKhau.Location = new Point(263, 215);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(394, 36);
            txtMatKhau.TabIndex = 11;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Verdana", 14F);
            txtTaiKhoan.Location = new Point(263, 150);
            txtTaiKhoan.Margin = new Padding(2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(394, 36);
            txtTaiKhoan.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14F);
            label3.Location = new Point(118, 218);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 29);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14F);
            label2.Location = new Point(118, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 8;
            label2.Text = "Tài khoản";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 12F);
            button1.Location = new Point(458, 414);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 12;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 10);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 513);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtTaiKhoan);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnDangNhap);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtMatKhau);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(837, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản trị";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 20F);
            label4.Location = new Point(126, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(643, 41);
            label4.TabIndex = 14;
            label4.Text = "TÀI KHOẢN QUẢN TRỊ NGƯỜI DÙNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F);
            label1.Location = new Point(268, 423);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 13;
            label1.Text = "Chưa có tài khoản ?";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(837, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Người dùng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 532);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label3;
        private Label label2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label1;
    }
}