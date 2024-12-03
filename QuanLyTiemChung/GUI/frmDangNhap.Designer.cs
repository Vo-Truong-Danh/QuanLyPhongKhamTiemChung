using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pctmain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.pnlMatkhau = new System.Windows.Forms.Panel();
            this.btnAnpass = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnHienpass = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.pctHU = new System.Windows.Forms.PictureBox();
            this.labLoiTaiKhoan = new System.Windows.Forms.Label();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblsai = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerSaiTK = new System.Windows.Forms.Timer(this.components);
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.HU = new System.Windows.Forms.Timer(this.components);
            this.pnlHuGoc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctmain)).BeginInit();
            this.pnlMatkhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHienpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.pnlHuGoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctmain
            // 
            this.pctmain.Image = global::GUI.Properties.Resources.dangnhap;
            this.pctmain.Location = new System.Drawing.Point(38, 82);
            this.pctmain.Margin = new System.Windows.Forms.Padding(4);
            this.pctmain.Name = "pctmain";
            this.pctmain.Size = new System.Drawing.Size(294, 294);
            this.pctmain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctmain.TabIndex = 21;
            this.pctmain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(391, 307);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(351, 54);
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTaiKhoan.Location = new System.Drawing.Point(391, 124);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(351, 54);
            this.pnlTaiKhoan.TabIndex = 24;
            // 
            // pnlMatkhau
            // 
            this.pnlMatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMatkhau.Controls.Add(this.btnAnpass);
            this.pnlMatkhau.Controls.Add(this.pictureBox4);
            this.pnlMatkhau.Controls.Add(this.btnHienpass);
            this.pnlMatkhau.Controls.Add(this.txtMatKhau);
            this.pnlMatkhau.Location = new System.Drawing.Point(391, 217);
            this.pnlMatkhau.Name = "pnlMatkhau";
            this.pnlMatkhau.Size = new System.Drawing.Size(351, 54);
            this.pnlMatkhau.TabIndex = 27;
            // 
            // btnAnpass
            // 
            this.btnAnpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnpass.ErrorImage = global::GUI.Properties.Resources.login_8717908;
            this.btnAnpass.Image = ((System.Drawing.Image)(resources.GetObject("btnAnpass.Image")));
            this.btnAnpass.Location = new System.Drawing.Point(291, 7);
            this.btnAnpass.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnpass.Name = "btnAnpass";
            this.btnAnpass.Size = new System.Drawing.Size(36, 34);
            this.btnAnpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnpass.TabIndex = 30;
            this.btnAnpass.TabStop = false;
            this.btnAnpass.Click += new System.EventHandler(this.btnAnpass_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.ErrorImage = global::GUI.Properties.Resources.login_8717908;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // btnHienpass
            // 
            this.btnHienpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHienpass.ErrorImage = global::GUI.Properties.Resources.login_8717908;
            this.btnHienpass.Image = ((System.Drawing.Image)(resources.GetObject("btnHienpass.Image")));
            this.btnHienpass.Location = new System.Drawing.Point(294, 10);
            this.btnHienpass.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienpass.Name = "btnHienpass";
            this.btnHienpass.Size = new System.Drawing.Size(32, 30);
            this.btnHienpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHienpass.TabIndex = 26;
            this.btnHienpass.TabStop = false;
            this.btnHienpass.Click += new System.EventHandler(this.btnHienpass_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(68, 12);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(248, 31);
            this.txtMatKhau.TabIndex = 0;
            // 
            // pctHU
            // 
            this.pctHU.Image = ((System.Drawing.Image)(resources.GetObject("pctHU.Image")));
            this.pctHU.Location = new System.Drawing.Point(246, 31);
            this.pctHU.Margin = new System.Windows.Forms.Padding(4);
            this.pctHU.Name = "pctHU";
            this.pctHU.Size = new System.Drawing.Size(356, 345);
            this.pctHU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHU.TabIndex = 31;
            this.pctHU.TabStop = false;
            // 
            // labLoiTaiKhoan
            // 
            this.labLoiTaiKhoan.AutoSize = true;
            this.labLoiTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.labLoiTaiKhoan.Location = new System.Drawing.Point(391, 95);
            this.labLoiTaiKhoan.Name = "labLoiTaiKhoan";
            this.labLoiTaiKhoan.Size = new System.Drawing.Size(0, 25);
            this.labLoiTaiKhoan.TabIndex = 28;
            // 
            // lblLoiMatKhau
            // 
            this.lblLoiMatKhau.AutoSize = true;
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhau.Location = new System.Drawing.Point(391, 182);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(0, 25);
            this.lblLoiMatKhau.TabIndex = 29;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(459, 136);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(250, 31);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(411, 133);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // lblsai
            // 
            this.lblsai.AutoSize = true;
            this.lblsai.ForeColor = System.Drawing.Color.Red;
            this.lblsai.Location = new System.Drawing.Point(391, 276);
            this.lblsai.Name = "lblsai";
            this.lblsai.Size = new System.Drawing.Size(0, 25);
            this.lblsai.TabIndex = 30;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerSaiTK
            // 
            this.timerSaiTK.Interval = 4000;
            this.timerSaiTK.Tick += new System.EventHandler(this.timerSaiTK_Tick);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(760, 31);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(27, 28);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 23;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // HU
            // 
            this.HU.Interval = 3200;
            this.HU.Tick += new System.EventHandler(this.HU_Tick);
            // 
            // pnlHuGoc
            // 
            this.pnlHuGoc.BackColor = System.Drawing.Color.White;
            this.pnlHuGoc.Controls.Add(this.pnlMatkhau);
            this.pnlHuGoc.Controls.Add(this.btnDangNhap);
            this.pnlHuGoc.Controls.Add(this.label1);
            this.pnlHuGoc.Controls.Add(this.lblsai);
            this.pnlHuGoc.Controls.Add(this.pctHU);
            this.pnlHuGoc.Controls.Add(this.pictureBox3);
            this.pnlHuGoc.Controls.Add(this.btnThoat);
            this.pnlHuGoc.Controls.Add(this.txtTaiKhoan);
            this.pnlHuGoc.Controls.Add(this.pnlTaiKhoan);
            this.pnlHuGoc.Controls.Add(this.lblLoiMatKhau);
            this.pnlHuGoc.Controls.Add(this.labLoiTaiKhoan);
            this.pnlHuGoc.Controls.Add(this.pctmain);
            this.pnlHuGoc.Location = new System.Drawing.Point(3, 3);
            this.pnlHuGoc.Name = "pnlHuGoc";
            this.pnlHuGoc.Size = new System.Drawing.Size(822, 410);
            this.pnlHuGoc.TabIndex = 32;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 415);
            this.Controls.Add(this.pnlHuGoc);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctmain)).EndInit();
            this.pnlMatkhau.ResumeLayout(false);
            this.pnlMatkhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHienpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.pnlHuGoc.ResumeLayout(false);
            this.pnlHuGoc.PerformLayout();
            this.ResumeLayout(false);

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