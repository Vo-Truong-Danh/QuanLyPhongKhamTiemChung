using System.Drawing;
using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGia = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.pnlTenVc = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlGia.SuspendLayout();
            this.pnlTenVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.OldLace;
            this.btnLuu.Location = new System.Drawing.Point(56, 442);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(405, 44);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(71, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(18, 13);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(370, 58);
            this.txtDiaChi.TabIndex = 0;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(50, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 36);
            this.label8.TabIndex = 73;
            this.label8.Text = "*";
            // 
            // pnlGia
            // 
            this.pnlGia.BackColor = System.Drawing.Color.White;
            this.pnlGia.Controls.Add(this.txtDiaChi);
            this.pnlGia.Location = new System.Drawing.Point(53, 225);
            this.pnlGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlGia.Name = "pnlGia";
            this.pnlGia.Size = new System.Drawing.Size(408, 82);
            this.pnlGia.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 36);
            this.label3.TabIndex = 70;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gotham Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 37);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(68, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BackColor = System.Drawing.Color.White;
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNCC.Location = new System.Drawing.Point(18, 13);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNCC.Multiline = true;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(370, 30);
            this.txtTenNCC.TabIndex = 0;
            this.txtTenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNCC_KeyPress);
            // 
            // pnlTenVc
            // 
            this.pnlTenVc.BackColor = System.Drawing.Color.White;
            this.pnlTenVc.Controls.Add(this.txtTenNCC);
            this.pnlTenVc.Location = new System.Drawing.Point(50, 126);
            this.pnlTenVc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTenVc.Name = "pnlTenVc";
            this.pnlTenVc.Size = new System.Drawing.Size(408, 44);
            this.pnlTenVc.TabIndex = 67;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(482, 18);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(19, 14);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 66;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(74, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 79;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(53, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 36);
            this.label5.TabIndex = 80;
            this.label5.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Location = new System.Drawing.Point(56, 354);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 44);
            this.panel1.TabIndex = 78;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BackColor = System.Drawing.Color.White;
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(18, 13);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoDienThoai.Multiline = true;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(370, 30);
            this.txtSoDienThoai.TabIndex = 0;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(526, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTenVc);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNCC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNCC_Load);
            this.pnlGia.ResumeLayout(false);
            this.pnlGia.PerformLayout();
            this.pnlTenVc.ResumeLayout(false);
            this.pnlTenVc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ErrorProvider error;
    }
}