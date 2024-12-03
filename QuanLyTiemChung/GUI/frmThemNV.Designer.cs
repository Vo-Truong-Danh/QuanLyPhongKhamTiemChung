namespace GUI
{
    partial class frmThemNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNV));
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboChuVu = new System.Windows.Forms.ComboBox();
            this.pnlLoai = new System.Windows.Forms.Panel();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLoaiVC = new System.Windows.Forms.Label();
            this.pnlXuatXu = new System.Windows.Forms.Panel();
            this.pnlGia = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlNSX = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.pnlTenVc = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHSD = new System.Windows.Forms.Panel();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSoDT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.pnlLoai.SuspendLayout();
            this.pnlXuatXu.SuspendLayout();
            this.pnlGia.SuspendLayout();
            this.pnlNSX.SuspendLayout();
            this.pnlTenVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.pnlHSD.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoDT)).BeginInit();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // cboChuVu
            // 
            this.cboChuVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChuVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuVu.FormattingEnabled = true;
            this.cboChuVu.Location = new System.Drawing.Point(17, 9);
            this.cboChuVu.Name = "cboChuVu";
            this.cboChuVu.Size = new System.Drawing.Size(339, 33);
            this.cboChuVu.TabIndex = 0;
            // 
            // pnlLoai
            // 
            this.pnlLoai.BackColor = System.Drawing.Color.White;
            this.pnlLoai.Controls.Add(this.txtDiaChi);
            this.pnlLoai.Location = new System.Drawing.Point(54, 268);
            this.pnlLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLoai.Name = "pnlLoai";
            this.pnlLoai.Size = new System.Drawing.Size(377, 55);
            this.pnlLoai.TabIndex = 66;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.OldLace;
            this.btnThemNV.Location = new System.Drawing.Point(502, 493);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(377, 55);
            this.btnThemNV.TabIndex = 65;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(528, 341);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "Xác nhận mật khẩu";
            // 
            // lblLoaiVC
            // 
            this.lblLoaiVC.AutoSize = true;
            this.lblLoaiVC.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoaiVC.Location = new System.Drawing.Point(51, 230);
            this.lblLoaiVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiVC.Name = "lblLoaiVC";
            this.lblLoaiVC.Size = new System.Drawing.Size(71, 25);
            this.lblLoaiVC.TabIndex = 67;
            this.lblLoaiVC.Text = "Địa chỉ";
            // 
            // pnlXuatXu
            // 
            this.pnlXuatXu.BackColor = System.Drawing.Color.White;
            this.pnlXuatXu.Controls.Add(this.txtXacNhanMK);
            this.pnlXuatXu.Location = new System.Drawing.Point(502, 380);
            this.pnlXuatXu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlXuatXu.Name = "pnlXuatXu";
            this.pnlXuatXu.Size = new System.Drawing.Size(377, 55);
            this.pnlXuatXu.TabIndex = 62;
            // 
            // pnlGia
            // 
            this.pnlGia.BackColor = System.Drawing.Color.White;
            this.pnlGia.Controls.Add(this.txtSoDT);
            this.pnlGia.Location = new System.Drawing.Point(54, 382);
            this.pnlGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlGia.Name = "pnlGia";
            this.pnlGia.Size = new System.Drawing.Size(377, 55);
            this.pnlGia.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(51, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Số điện thoại";
            // 
            // pnlNSX
            // 
            this.pnlNSX.BackColor = System.Drawing.Color.White;
            this.pnlNSX.Controls.Add(this.cboChuVu);
            this.pnlNSX.Location = new System.Drawing.Point(505, 149);
            this.pnlNSX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNSX.Name = "pnlNSX";
            this.pnlNSX.Size = new System.Drawing.Size(377, 55);
            this.pnlNSX.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(531, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 36);
            this.label3.TabIndex = 53;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 38);
            this.label2.TabIndex = 52;
            this.label2.Text = "Đăng ký nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Họ Tên";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.BackColor = System.Drawing.Color.White;
            this.txtHoTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoTenNV.Location = new System.Drawing.Point(4, 3);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoTenNV.Multiline = true;
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(352, 49);
            this.txtHoTenNV.TabIndex = 0;
            this.txtHoTenNV.TextChanged += new System.EventHandler(this.txtHoTenNV_TextChanged);
            // 
            // pnlTenVc
            // 
            this.pnlTenVc.BackColor = System.Drawing.Color.White;
            this.pnlTenVc.Controls.Add(this.txtHoTenNV);
            this.pnlTenVc.Location = new System.Drawing.Point(54, 149);
            this.pnlTenVc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTenVc.Name = "pnlTenVc";
            this.pnlTenVc.Size = new System.Drawing.Size(377, 55);
            this.pnlTenVc.TabIndex = 49;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(865, 34);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(19, 18);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 48;
            this.btnThoat.TabStop = false;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoNam.Location = new System.Drawing.Point(43, 11);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(71, 29);
            this.rdoNam.TabIndex = 71;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoNu.Location = new System.Drawing.Point(167, 11);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(55, 29);
            this.rdoNu.TabIndex = 70;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(47, 456);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 69;
            this.label13.Text = "Giới tính :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(506, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 36);
            this.label10.TabIndex = 64;
            this.label10.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(506, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 36);
            this.label5.TabIndex = 55;
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(531, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(506, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 36);
            this.label6.TabIndex = 58;
            this.label6.Text = "*";
            // 
            // pnlHSD
            // 
            this.pnlHSD.BackColor = System.Drawing.Color.White;
            this.pnlHSD.Controls.Add(this.txtMatKhau);
            this.pnlHSD.Location = new System.Drawing.Point(505, 265);
            this.pnlHSD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHSD.Name = "pnlHSD";
            this.pnlHSD.Size = new System.Drawing.Size(377, 55);
            this.pnlHSD.TabIndex = 56;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.Color.White;
            this.txtSoDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoDT.Location = new System.Drawing.Point(4, 3);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoDT.Multiline = true;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(352, 49);
            this.txtSoDT.TabIndex = 2;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(4, 3);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(352, 49);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(7, 2);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(352, 49);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BackColor = System.Drawing.Color.White;
            this.txtXacNhanMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtXacNhanMK.Location = new System.Drawing.Point(2, 2);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXacNhanMK.Multiline = true;
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '*';
            this.txtXacNhanMK.Size = new System.Drawing.Size(352, 49);
            this.txtXacNhanMK.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rdoNam);
            this.panel1.Controls.Add(this.rdoNu);
            this.panel1.Location = new System.Drawing.Point(54, 493);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 55);
            this.panel1.TabIndex = 52;
            // 
            // errHoTen
            // 
            this.errHoTen.ContainerControl = this;
            // 
            // errDiaChi
            // 
            this.errDiaChi.ContainerControl = this;
            // 
            // errSoDT
            // 
            this.errSoDT.ContainerControl = this;
            // 
            // frmThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlLoai);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLoaiVC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlXuatXu);
            this.Controls.Add(this.pnlGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlHSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlNSX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTenVc);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmThemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNV";
            this.Load += new System.EventHandler(this.frmThemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.pnlLoai.ResumeLayout(false);
            this.pnlLoai.PerformLayout();
            this.pnlXuatXu.ResumeLayout(false);
            this.pnlXuatXu.PerformLayout();
            this.pnlGia.ResumeLayout(false);
            this.pnlGia.PerformLayout();
            this.pnlNSX.ResumeLayout(false);
            this.pnlTenVc.ResumeLayout(false);
            this.pnlTenVc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.pnlHSD.ResumeLayout(false);
            this.pnlHSD.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSoDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel pnlLoai;
        private System.Windows.Forms.ComboBox cboChuVu;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLoaiVC;
        private System.Windows.Forms.Panel pnlXuatXu;
        private System.Windows.Forms.Panel pnlGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlNSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTenVc;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.PictureBox btnThoat;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Panel pnlHSD;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errHoTen;
        private System.Windows.Forms.ErrorProvider errDiaChi;
        private System.Windows.Forms.ErrorProvider errSoDT;
    }
}