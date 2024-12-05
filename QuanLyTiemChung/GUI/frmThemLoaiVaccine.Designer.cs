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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiVaccine));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoMui = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGia = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiVC = new System.Windows.Forms.TextBox();
            this.pnlTenVc = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlGia.SuspendLayout();
            this.pnlTenVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
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
            this.btnLuu.Location = new System.Drawing.Point(65, 322);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(405, 44);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(83, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Số mũi ";
            // 
            // txtSoMui
            // 
            this.txtSoMui.BackColor = System.Drawing.Color.White;
            this.txtSoMui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoMui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoMui.Location = new System.Drawing.Point(21, 12);
            this.txtSoMui.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoMui.Multiline = true;
            this.txtSoMui.Name = "txtSoMui";
            this.txtSoMui.Size = new System.Drawing.Size(370, 30);
            this.txtSoMui.TabIndex = 0;
            this.txtSoMui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoMui_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(62, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 36);
            this.label8.TabIndex = 61;
            this.label8.Text = "*";
            // 
            // pnlGia
            // 
            this.pnlGia.BackColor = System.Drawing.Color.White;
            this.pnlGia.Controls.Add(this.txtSoMui);
            this.pnlGia.Location = new System.Drawing.Point(65, 225);
            this.pnlGia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlGia.Name = "pnlGia";
            this.pnlGia.Size = new System.Drawing.Size(408, 44);
            this.pnlGia.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(59, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 36);
            this.label3.TabIndex = 53;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gotham Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "Thông Tin Loại Vaccine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(80, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên loại Vaccine";
            // 
            // txtTenLoaiVC
            // 
            this.txtTenLoaiVC.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenLoaiVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenLoaiVC.Location = new System.Drawing.Point(21, 12);
            this.txtTenLoaiVC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenLoaiVC.Multiline = true;
            this.txtTenLoaiVC.Name = "txtTenLoaiVC";
            this.txtTenLoaiVC.Size = new System.Drawing.Size(370, 30);
            this.txtTenLoaiVC.TabIndex = 0;
            this.txtTenLoaiVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoaiVC_KeyPress);
            // 
            // pnlTenVc
            // 
            this.pnlTenVc.BackColor = System.Drawing.Color.White;
            this.pnlTenVc.Controls.Add(this.txtTenLoaiVC);
            this.pnlTenVc.Location = new System.Drawing.Point(62, 126);
            this.pnlTenVc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlTenVc.Name = "pnlTenVc";
            this.pnlTenVc.Size = new System.Drawing.Size(408, 44);
            this.pnlTenVc.TabIndex = 49;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(494, 18);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(19, 14);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 48;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmThemLoaiVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(549, 411);
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
            this.Name = "frmThemLoaiVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmThemLoaiVaccine";
            this.Load += new System.EventHandler(this.frmThemLoaiVaccine_Load);
            this.pnlGia.ResumeLayout(false);
            this.pnlGia.PerformLayout();
            this.pnlTenVc.ResumeLayout(false);
            this.pnlTenVc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ErrorProvider error;
    }
}