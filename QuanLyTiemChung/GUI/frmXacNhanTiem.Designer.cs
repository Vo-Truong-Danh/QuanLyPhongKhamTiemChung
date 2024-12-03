namespace GUI
{
    partial class frmXacNhanTiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXacNhanTiem));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.PictureBox();
            this.lblmalt = new System.Windows.Forms.Label();
            this.lblmahd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltenvc = new System.Windows.Forms.Label();
            this.lblMavc = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblmabn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(65, 456);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(379, 44);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Xác Nhận";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SVN-Gotham Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 37);
            this.label2.TabIndex = 69;
            this.label2.Text = "Xác Nhận Tiêm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(60, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "MaLT :";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(465, 28);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(19, 14);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnThoat.TabIndex = 66;
            this.btnThoat.TabStop = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblmalt
            // 
            this.lblmalt.AutoSize = true;
            this.lblmalt.BackColor = System.Drawing.Color.Transparent;
            this.lblmalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmalt.Location = new System.Drawing.Point(144, 123);
            this.lblmalt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmalt.Name = "lblmalt";
            this.lblmalt.Size = new System.Drawing.Size(64, 25);
            this.lblmalt.TabIndex = 75;
            this.lblmalt.Text = "MaLT";
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.BackColor = System.Drawing.Color.Transparent;
            this.lblmahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmahd.Location = new System.Drawing.Point(380, 123);
            this.lblmahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(61, 25);
            this.lblmahd.TabIndex = 79;
            this.lblmahd.Text = "mahd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(296, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Mã HD :";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.BackColor = System.Drawing.Color.Transparent;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblhoten.Location = new System.Drawing.Point(144, 216);
            this.lblhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(61, 25);
            this.lblhoten.TabIndex = 81;
            this.lblhoten.Text = "hoten";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(60, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Họ Tên :";
            // 
            // lbltenvc
            // 
            this.lbltenvc.AutoSize = true;
            this.lbltenvc.BackColor = System.Drawing.Color.Transparent;
            this.lbltenvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltenvc.Location = new System.Drawing.Point(254, 300);
            this.lbltenvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenvc.Name = "lbltenvc";
            this.lbltenvc.Size = new System.Drawing.Size(59, 25);
            this.lbltenvc.TabIndex = 83;
            this.lbltenvc.Text = "tenvc";
            // 
            // lblMavc
            // 
            this.lblMavc.AutoSize = true;
            this.lblMavc.BackColor = System.Drawing.Color.Transparent;
            this.lblMavc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMavc.Location = new System.Drawing.Point(60, 300);
            this.lblMavc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMavc.Name = "lblMavc";
            this.lblMavc.Size = new System.Drawing.Size(59, 25);
            this.lblMavc.TabIndex = 82;
            this.lblMavc.Text = "mavc";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(65, 371);
            this.txtTinhTrang.Multiline = true;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(379, 54);
            this.txtTinhTrang.TabIndex = 84;
            // 
            // lblmabn
            // 
            this.lblmabn.AutoSize = true;
            this.lblmabn.BackColor = System.Drawing.Color.Transparent;
            this.lblmabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmabn.Location = new System.Drawing.Point(144, 166);
            this.lblmabn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmabn.Name = "lblmabn";
            this.lblmabn.Size = new System.Drawing.Size(61, 25);
            this.lblmabn.TabIndex = 77;
            this.lblmabn.Text = "mabn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(61, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Mã BN :";
            // 
            // frmXacNhanTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 562);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lbltenvc);
            this.Controls.Add(this.lblMavc);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblmahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmabn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblmalt);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXacNhanTiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXacNhanTiem";
            this.Load += new System.EventHandler(this.frmXacNhanTiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnThoat;
        private System.Windows.Forms.Label lblmalt;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltenvc;
        private System.Windows.Forms.Label lblMavc;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblmabn;
        private System.Windows.Forms.Label label5;
    }
}