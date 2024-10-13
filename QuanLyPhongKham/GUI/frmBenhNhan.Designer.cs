namespace GUI
{
    partial class frmBenhNhan
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnXoaBN = new Button();
            btnCapNhat = new Button();
            btnLuuBN = new Button();
            dtpNgaySinh = new DateTimePicker();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lstvDSBN = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            errMaSo = new ErrorProvider(components);
            errHoTen = new ErrorProvider(components);
            errDiaChi = new ErrorProvider(components);
            errSoDienThoai = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errMaSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDiaChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSoDienThoai).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaBN);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnLuuBN);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Verdana", 13F);
            groupBox1.Location = new Point(10, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 510);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // btnXoaBN
            // 
            btnXoaBN.Font = new Font("Verdana", 10F);
            btnXoaBN.Location = new Point(569, 424);
            btnXoaBN.Name = "btnXoaBN";
            btnXoaBN.Size = new Size(195, 49);
            btnXoaBN.TabIndex = 15;
            btnXoaBN.Text = "Xóa bệnh nhân";
            btnXoaBN.UseVisualStyleBackColor = true;
            btnXoaBN.Click += btnXoaBN_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Verdana", 10F);
            btnCapNhat.Location = new Point(329, 424);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(221, 49);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật thông tin";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLuuBN
            // 
            btnLuuBN.Font = new Font("Verdana", 10F);
            btnLuuBN.Location = new Point(115, 424);
            btnLuuBN.Name = "btnLuuBN";
            btnLuuBN.Size = new Size(195, 49);
            btnLuuBN.TabIndex = 13;
            btnLuuBN.Text = "Lưu bệnh nhân";
            btnLuuBN.UseVisualStyleBackColor = true;
            btnLuuBN.Click += btnLuuBN_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Verdana", 11F);
            dtpNgaySinh.Location = new Point(222, 127);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(493, 34);
            dtpNgaySinh.TabIndex = 12;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Verdana", 11F);
            rdoNu.Location = new Point(339, 205);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(68, 30);
            rdoNu.TabIndex = 11;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Verdana", 11F);
            rdoNam.Location = new Point(222, 205);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(87, 30);
            rdoNam.TabIndex = 10;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Verdana", 11F);
            txtSoDienThoai.Location = new Point(222, 358);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(565, 34);
            txtSoDienThoai.TabIndex = 9;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Verdana", 11F);
            txtDiaChi.Location = new Point(222, 281);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(565, 34);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Verdana", 11F);
            txtHoTen.Location = new Point(222, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(565, 34);
            txtHoTen.TabIndex = 7;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 361);
            label6.Name = "label6";
            label6.Size = new Size(185, 32);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 284);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 207);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 130);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 53);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstvDSBN);
            groupBox2.Location = new Point(10, 530);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1654, 457);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các bệnh nhân";
            // 
            // lstvDSBN
            // 
            lstvDSBN.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstvDSBN.Font = new Font("Verdana", 10F);
            lstvDSBN.FullRowSelect = true;
            lstvDSBN.Location = new Point(21, 43);
            lstvDSBN.Name = "lstvDSBN";
            lstvDSBN.Size = new Size(1622, 413);
            lstvDSBN.TabIndex = 16;
            lstvDSBN.UseCompatibleStateImageBehavior = false;
            lstvDSBN.View = View.Details;
            lstvDSBN.SelectedIndexChanged += lstvDSBN_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã số";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giới tính";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Địa chỉ";
            columnHeader5.Width = 550;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số điện thoại";
            columnHeader6.Width = 400;
            // 
            // errMaSo
            // 
            errMaSo.ContainerControl = this;
            // 
            // errHoTen
            // 
            errHoTen.ContainerControl = this;
            // 
            // errDiaChi
            // 
            errDiaChi.ContainerControl = this;
            // 
            // errSoDienThoai
            // 
            errSoDienThoai.ContainerControl = this;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1685, 998);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khám bệnh";
            FormClosing += frmBenhNhan_FormClosing;
            Load += frmBenhNhan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errMaSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).EndInit();
            ((System.ComponentModel.ISupportInitialize)errDiaChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errSoDienThoai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXoaBN;
        private Button btnCapNhat;
        private Button btnLuuBN;
        private GroupBox groupBox2;
        private ListView lstvDSBN;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ErrorProvider errMaSo;
        private ErrorProvider errHoTen;
        private ErrorProvider errDiaChi;
        private ErrorProvider errSoDienThoai;
    }
}