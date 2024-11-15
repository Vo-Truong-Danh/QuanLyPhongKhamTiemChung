namespace GUI
{
    partial class frmNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            btnLuu = new Button();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label8 = new Label();
            pnlGia = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenNCC = new TextBox();
            pnlTenVc = new Panel();
            btnThoat = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtSoDienThoai = new TextBox();
            pnlGia.SuspendLayout();
            pnlTenVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnThoat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DarkSlateGray;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.OldLace;
            btnLuu.Location = new Point(56, 552);
            btnLuu.Margin = new Padding(0);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(405, 55);
            btnLuu.TabIndex = 74;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(71, 242);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 72;
            label9.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.White;
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F);
            txtDiaChi.Location = new Point(18, 16);
            txtDiaChi.Margin = new Padding(0);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Nhập vào địa chỉ của Nhà Cung Cấp";
            txtDiaChi.Size = new Size(370, 73);
            txtDiaChi.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(50, 240);
            label8.Name = "label8";
            label8.Size = new Size(27, 36);
            label8.TabIndex = 73;
            label8.Text = "*";
            // 
            // pnlGia
            // 
            pnlGia.BackColor = Color.White;
            pnlGia.Controls.Add(txtDiaChi);
            pnlGia.Location = new Point(53, 281);
            pnlGia.Margin = new Padding(4, 3, 4, 3);
            pnlGia.Name = "pnlGia";
            pnlGia.Size = new Size(408, 103);
            pnlGia.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(47, 116);
            label3.Name = "label3";
            label3.Size = new Size(27, 36);
            label3.TabIndex = 70;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Gotham Rounded", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 69;
            label2.Text = "Nhà Cung Cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(68, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 68;
            label1.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            txtTenNCC.BackColor = Color.White;
            txtTenNCC.BorderStyle = BorderStyle.None;
            txtTenNCC.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenNCC.Location = new Point(18, 16);
            txtTenNCC.Margin = new Padding(4, 3, 4, 3);
            txtTenNCC.Multiline = true;
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderText = "Nhập vào tên Nhà Cung Cấp";
            txtTenNCC.Size = new Size(370, 37);
            txtTenNCC.TabIndex = 0;
            // 
            // pnlTenVc
            // 
            pnlTenVc.BackColor = Color.White;
            pnlTenVc.Controls.Add(txtTenNCC);
            pnlTenVc.Location = new Point(50, 157);
            pnlTenVc.Margin = new Padding(4, 3, 4, 3);
            pnlTenVc.Name = "pnlTenVc";
            pnlTenVc.Size = new Size(408, 55);
            pnlTenVc.TabIndex = 67;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(482, 22);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(19, 18);
            btnThoat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThoat.TabIndex = 66;
            btnThoat.TabStop = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(74, 404);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 79;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(53, 402);
            label5.Name = "label5";
            label5.Size = new Size(27, 36);
            label5.TabIndex = 80;
            label5.Text = "*";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Location = new Point(56, 443);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 55);
            panel1.TabIndex = 78;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BackColor = Color.White;
            txtSoDienThoai.BorderStyle = BorderStyle.None;
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(18, 16);
            txtSoDienThoai.Margin = new Padding(0);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "Nhập vào số điện thoại của Nhà Cung Cấp";
            txtSoDienThoai.Size = new Size(370, 37);
            txtSoDienThoai.TabIndex = 0;
            // 
            // frmNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(526, 652);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnLuu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pnlGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlTenVc);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNCC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNCC";
            TopMost = true;
            Load += frmNCC_Load;
            pnlGia.ResumeLayout(false);
            pnlGia.PerformLayout();
            pnlTenVc.ResumeLayout(false);
            pnlTenVc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnThoat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label8;
        private Panel pnlGia;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenNCC;
        private Panel pnlTenVc;
        private PictureBox btnThoat;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox txtSoDienThoai;
    }
}