using System.Drawing;
using System.Windows.Forms;
namespace GUI
{
    partial class frm_ThemVaccine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemVaccine));
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.pnlTenVc = new System.Windows.Forms.Panel();
            this.txtTenVC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dteNSX = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNSX = new System.Windows.Forms.Panel();
            this.pnlHSD = new System.Windows.Forms.Panel();
            this.dteHSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGia = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlXuatXu = new System.Windows.Forms.Panel();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlLoai = new System.Windows.Forms.Panel();
            this.cboLoaiVC = new System.Windows.Forms.ComboBox();
            this.lblLoaiVC = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.pnlTenVc.SuspendLayout();
            this.pnlNSX.SuspendLayout();
            this.pnlHSD.SuspendLayout();
            this.pnlGia.SuspendLayout();
            this.pnlXuatXu.SuspendLayout();
            this.pnlLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(903, 39);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(19, 18);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 25;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlTenVc
            // 
            this.pnlTenVc.BackColor = System.Drawing.Color.White;
            this.pnlTenVc.Controls.Add(this.txtTenVC);
            this.pnlTenVc.Location = new System.Drawing.Point(49, 154);
            this.pnlTenVc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTenVc.Name = "pnlTenVc";
            this.pnlTenVc.Size = new System.Drawing.Size(377, 55);
            this.pnlTenVc.TabIndex = 28;
            // 
            // txtTenVC
            // 
            this.txtTenVC.BackColor = System.Drawing.Color.White;
            this.txtTenVC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenVC.Location = new System.Drawing.Point(21, 15);
            this.txtTenVC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenVC.Multiline = true;
            this.txtTenVC.Name = "txtTenVC";
            this.txtTenVC.Size = new System.Drawing.Size(339, 37);
            this.txtTenVC.TabIndex = 0;
            this.txtTenVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenVC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(67, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên Vaccine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gotham Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Thông Tin Vaccine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // dteNSX
            // 
            this.dteNSX.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNSX.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteNSX.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteNSX.Location = new System.Drawing.Point(33, 9);
            this.dteNSX.Margin = new System.Windows.Forms.Padding(130, 13, 130, 13);
            this.dteNSX.Name = "dteNSX";
            this.dteNSX.Size = new System.Drawing.Size(312, 34);
            this.dteNSX.TabIndex = 0;
            this.dteNSX.ValueChanged += new System.EventHandler(this.dteNSX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(548, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(527, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 36);
            this.label5.TabIndex = 34;
            this.label5.Text = "*";
            // 
            // pnlNSX
            // 
            this.pnlNSX.BackColor = System.Drawing.Color.White;
            this.pnlNSX.Controls.Add(this.dteNSX);
            this.pnlNSX.Location = new System.Drawing.Point(530, 154);
            this.pnlNSX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNSX.Name = "pnlNSX";
            this.pnlNSX.Size = new System.Drawing.Size(377, 55);
            this.pnlNSX.TabIndex = 29;
            // 
            // pnlHSD
            // 
            this.pnlHSD.BackColor = System.Drawing.Color.White;
            this.pnlHSD.Controls.Add(this.dteHSD);
            this.pnlHSD.Location = new System.Drawing.Point(530, 270);
            this.pnlHSD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHSD.Name = "pnlHSD";
            this.pnlHSD.Size = new System.Drawing.Size(377, 55);
            this.pnlHSD.TabIndex = 35;
            // 
            // dteHSD
            // 
            this.dteHSD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteHSD.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteHSD.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dteHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteHSD.Location = new System.Drawing.Point(33, 9);
            this.dteHSD.Margin = new System.Windows.Forms.Padding(130, 13, 130, 13);
            this.dteHSD.Name = "dteHSD";
            this.dteHSD.Size = new System.Drawing.Size(312, 34);
            this.dteHSD.TabIndex = 0;
            this.dteHSD.ValueChanged += new System.EventHandler(this.dteHSD_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(527, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(548, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Hạn Sử Dụng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(49, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 36);
            this.label8.TabIndex = 40;
            this.label8.Text = "*";
            // 
            // pnlGia
            // 
            this.pnlGia.BackColor = System.Drawing.Color.White;
            this.pnlGia.Controls.Add(this.txtGia);
            this.pnlGia.Location = new System.Drawing.Point(52, 385);
            this.pnlGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlGia.Name = "pnlGia";
            this.pnlGia.Size = new System.Drawing.Size(377, 55);
            this.pnlGia.TabIndex = 38;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGia.Location = new System.Drawing.Point(21, 15);
            this.txtGia.Margin = new System.Windows.Forms.Padding(0);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(339, 37);
            this.txtGia.TabIndex = 0;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(70, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Giá Vacine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(524, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 36);
            this.label10.TabIndex = 43;
            this.label10.Text = "*";
            // 
            // pnlXuatXu
            // 
            this.pnlXuatXu.BackColor = System.Drawing.Color.White;
            this.pnlXuatXu.Controls.Add(this.txtXuatXu);
            this.pnlXuatXu.Location = new System.Drawing.Point(527, 385);
            this.pnlXuatXu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlXuatXu.Name = "pnlXuatXu";
            this.pnlXuatXu.Size = new System.Drawing.Size(377, 55);
            this.pnlXuatXu.TabIndex = 41;
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.BackColor = System.Drawing.Color.White;
            this.txtXuatXu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtXuatXu.Location = new System.Drawing.Point(21, 15);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXuatXu.Multiline = true;
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(339, 37);
            this.txtXuatXu.TabIndex = 0;
            this.txtXuatXu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXuatXu_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(545, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Xuất xứ";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.OldLace;
            this.btnLuu.Location = new System.Drawing.Point(290, 483);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(377, 55);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu Thông Tin";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(49, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 36);
            this.label12.TabIndex = 47;
            this.label12.Text = "*";
            // 
            // pnlLoai
            // 
            this.pnlLoai.BackColor = System.Drawing.Color.White;
            this.pnlLoai.Controls.Add(this.cboLoaiVC);
            this.pnlLoai.Location = new System.Drawing.Point(52, 274);
            this.pnlLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLoai.Name = "pnlLoai";
            this.pnlLoai.Size = new System.Drawing.Size(377, 55);
            this.pnlLoai.TabIndex = 45;
            // 
            // cboLoaiVC
            // 
            this.cboLoaiVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiVC.FormattingEnabled = true;
            this.cboLoaiVC.Location = new System.Drawing.Point(20, 11);
            this.cboLoaiVC.Name = "cboLoaiVC";
            this.cboLoaiVC.Size = new System.Drawing.Size(339, 33);
            this.cboLoaiVC.TabIndex = 0;
            // 
            // lblLoaiVC
            // 
            this.lblLoaiVC.AutoSize = true;
            this.lblLoaiVC.BackColor = System.Drawing.Color.Transparent;
            this.lblLoaiVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoaiVC.Location = new System.Drawing.Point(70, 235);
            this.lblLoaiVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiVC.Name = "lblLoaiVC";
            this.lblLoaiVC.Size = new System.Drawing.Size(115, 25);
            this.lblLoaiVC.TabIndex = 46;
            this.lblLoaiVC.Text = "Loại Vacine";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frm_ThemVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 586);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnlLoai);
            this.Controls.Add(this.lblLoaiVC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlXuatXu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.pnlTenVc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_ThemVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThemVaccine";
            this.Load += new System.EventHandler(this.frm_ThemVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.pnlTenVc.ResumeLayout(false);
            this.pnlTenVc.PerformLayout();
            this.pnlNSX.ResumeLayout(false);
            this.pnlHSD.ResumeLayout(false);
            this.pnlGia.ResumeLayout(false);
            this.pnlGia.PerformLayout();
            this.pnlXuatXu.ResumeLayout(false);
            this.pnlXuatXu.PerformLayout();
            this.pnlLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnThoat;
        private Panel pnlTenVc;
        private TextBox txtTenVC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dteNSX;
        private Panel pnlNSX;
        private Panel pnlHSD;
        private DateTimePicker dteHSD;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel pnlGia;
        private TextBox txtGia;
        private Label label9;
        private Label label10;
        private Panel pnlXuatXu;
        private TextBox txtXuatXu;
        private Label label11;
        private Button btnLuu;
        private Label label12;
        private Panel pnlLoai;
        private ComboBox cboLoaiVC;
        private Label lblLoaiVC;
        private ErrorProvider error;
    }
}