using System.Drawing;
using System.Windows.Forms;
namespace GUI
{
    partial class frmThemLoaiVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiVaccine));
            btnLuu = new Button();
            label9 = new Label();
            txtSoMui = new TextBox();
            label8 = new Label();
            pnlGia = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenLoaiVC = new TextBox();
            pnlTenVc = new Panel();
            btnThoat = new PictureBox();
            pnlGia.SuspendLayout();
            pnlTenVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnThoat).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DarkSlateGray;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.OldLace;
            btnLuu.Location = new Point(65, 402);
            btnLuu.Margin = new Padding(0);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(405, 55);
            btnLuu.TabIndex = 65;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(83, 242);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 60;
            label9.Text = "Số mũi ";
            // 
            // txtSoMui
            // 
            txtSoMui.BackColor = Color.White;
            txtSoMui.BorderStyle = BorderStyle.None;
            txtSoMui.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoMui.Location = new Point(21, 15);
            txtSoMui.Margin = new Padding(0);
            txtSoMui.Multiline = true;
            txtSoMui.Name = "txtSoMui";
            //txtSoMui.PlaceholderText = "Nhập vào số mủi cần tiêm";
            txtSoMui.Size = new Size(370, 37);
            txtSoMui.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(62, 240);
            label8.Name = "label8";
            label8.Size = new Size(27, 36);
            label8.TabIndex = 61;
            label8.Text = "*";
            // 
            // pnlGia
            // 
            pnlGia.BackColor = Color.White;
            pnlGia.Controls.Add(txtSoMui);
            pnlGia.Location = new Point(65, 281);
            pnlGia.Margin = new Padding(4, 3, 4, 3);
            pnlGia.Name = "pnlGia";
            pnlGia.Size = new Size(408, 55);
            pnlGia.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(59, 116);
            label3.Name = "label3";
            label3.Size = new Size(27, 36);
            label3.TabIndex = 53;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Gotham Rounded", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(436, 37);
            label2.TabIndex = 52;
            label2.Text = "Thông Tin Loại Vaccine";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(80, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 50;
            label1.Text = "Tên loại Vaccine";
            // 
            // txtTenLoaiVC
            // 
            txtTenLoaiVC.BackColor = Color.White;
            txtTenLoaiVC.BorderStyle = BorderStyle.None;
            txtTenLoaiVC.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenLoaiVC.Location = new Point(21, 15);
            txtTenLoaiVC.Margin = new Padding(4, 3, 4, 3);
            txtTenLoaiVC.Multiline = true;
            txtTenLoaiVC.Name = "txtTenLoaiVC";
            //txtTenLoaiVC.PlaceholderText = "Nhập vào tên loại Vaccine ";
            txtTenLoaiVC.Size = new Size(370, 37);
            txtTenLoaiVC.TabIndex = 0;
            // 
            // pnlTenVc
            // 
            pnlTenVc.BackColor = Color.White;
            pnlTenVc.Controls.Add(txtTenLoaiVC);
            pnlTenVc.Location = new Point(62, 157);
            pnlTenVc.Margin = new Padding(4, 3, 4, 3);
            pnlTenVc.Name = "pnlTenVc";
            pnlTenVc.Size = new Size(408, 55);
            pnlTenVc.TabIndex = 49;
            // 
            // btnThoat
            // 
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(494, 22);
            btnThoat.Margin = new Padding(5, 4, 5, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(19, 18);
            btnThoat.SizeMode = PictureBoxSizeMode.StretchImage;
            btnThoat.TabIndex = 48;
            btnThoat.TabStop = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThemLoaiVaccine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(549, 514);
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
            Name = "frmThemLoaiVaccine";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmThemLoaiVaccine";
            Load += frmThemLoaiVaccine_Load;
            pnlGia.ResumeLayout(false);
            pnlGia.PerformLayout();
            pnlTenVc.ResumeLayout(false);
            pnlTenVc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnThoat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private Label label9;
        private TextBox txtSoMui;
        private Label label8;
        private Panel pnlGia;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenLoaiVC;
        private Panel pnlTenVc;
        private PictureBox btnThoat;
    }
}