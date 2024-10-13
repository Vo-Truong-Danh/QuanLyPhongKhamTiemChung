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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox1.Location = new Point(8, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(675, 513);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // btnXoaBN
            // 
            btnXoaBN.Font = new Font("Verdana", 10F);
            btnXoaBN.Location = new Point(455, 339);
            btnXoaBN.Margin = new Padding(2);
            btnXoaBN.Name = "btnXoaBN";
            btnXoaBN.Size = new Size(156, 39);
            btnXoaBN.TabIndex = 15;
            btnXoaBN.Text = "Xóa bệnh nhân";
            btnXoaBN.UseVisualStyleBackColor = true;
            btnXoaBN.Click += btnXoaBN_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Verdana", 10F);
            btnCapNhat.Location = new Point(263, 339);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(177, 39);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật thông tin";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLuuBN
            // 
            btnLuuBN.Font = new Font("Verdana", 10F);
            btnLuuBN.Location = new Point(92, 339);
            btnLuuBN.Margin = new Padding(2);
            btnLuuBN.Name = "btnLuuBN";
            btnLuuBN.Size = new Size(156, 39);
            btnLuuBN.TabIndex = 13;
            btnLuuBN.Text = "Lưu bệnh nhân";
            btnLuuBN.UseVisualStyleBackColor = true;
            btnLuuBN.Click += btnLuuBN_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Verdana", 11F);
            dtpNgaySinh.Location = new Point(178, 102);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(395, 30);
            dtpNgaySinh.TabIndex = 12;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Verdana", 11F);
            rdoNu.Location = new Point(271, 164);
            rdoNu.Margin = new Padding(2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(57, 27);
            rdoNu.TabIndex = 11;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Verdana", 11F);
            rdoNam.Location = new Point(178, 164);
            rdoNam.Margin = new Padding(2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(74, 27);
            rdoNam.TabIndex = 10;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Verdana", 11F);
            txtSoDienThoai.Location = new Point(178, 286);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(453, 30);
            txtSoDienThoai.TabIndex = 9;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Verdana", 11F);
            txtDiaChi.Location = new Point(178, 225);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(453, 30);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Verdana", 11F);
            txtHoTen.Location = new Point(178, 40);
            txtHoTen.Margin = new Padding(2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(453, 30);
            txtHoTen.TabIndex = 7;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 289);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 26);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 227);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 26);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 26);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstvDSBN);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 403);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1421, 533);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các bệnh nhân";
            // 
            // lstvDSBN
            // 
            lstvDSBN.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstvDSBN.Dock = DockStyle.Fill;
            lstvDSBN.Font = new Font("Verdana", 10F);
            lstvDSBN.FullRowSelect = true;
            lstvDSBN.Location = new Point(2, 22);
            lstvDSBN.Margin = new Padding(2);
            lstvDSBN.Name = "lstvDSBN";
            lstvDSBN.Size = new Size(1417, 509);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1421, 936);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
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