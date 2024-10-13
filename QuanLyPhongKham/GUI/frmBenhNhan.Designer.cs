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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBenhNhan));
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
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errMaSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errHoTen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errDiaChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errSoDienThoai).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 13F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(643, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // btnXoaBN
            // 
            btnXoaBN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXoaBN.Font = new Font("Microsoft Sans Serif", 10F);
            btnXoaBN.Location = new Point(425, 337);
            btnXoaBN.Margin = new Padding(2);
            btnXoaBN.Name = "btnXoaBN";
            btnXoaBN.Size = new Size(125, 39);
            btnXoaBN.TabIndex = 15;
            btnXoaBN.Text = "Xóa bệnh nhân";
            btnXoaBN.UseVisualStyleBackColor = true;
            btnXoaBN.Click += btnXoaBN_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 10F);
            btnCapNhat.Location = new Point(233, 337);
            btnCapNhat.Margin = new Padding(2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(146, 39);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật thông tin";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnLuuBN
            // 
            btnLuuBN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLuuBN.Font = new Font("Microsoft Sans Serif", 10F);
            btnLuuBN.Location = new Point(62, 337);
            btnLuuBN.Margin = new Padding(2);
            btnLuuBN.Name = "btnLuuBN";
            btnLuuBN.Size = new Size(125, 39);
            btnLuuBN.TabIndex = 13;
            btnLuuBN.Text = "Lưu bệnh nhân";
            btnLuuBN.UseVisualStyleBackColor = true;
            btnLuuBN.Click += btnLuuBN_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgaySinh.Font = new Font("Microsoft Sans Serif", 11F);
            dtpNgaySinh.Location = new Point(178, 102);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(364, 28);
            dtpNgaySinh.TabIndex = 12;
            // 
            // rdoNu
            // 
            rdoNu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Microsoft Sans Serif", 11F);
            rdoNu.Location = new Point(271, 147);
            rdoNu.Margin = new Padding(2);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(56, 28);
            rdoNu.TabIndex = 11;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Microsoft Sans Serif", 11F);
            rdoNam.Location = new Point(178, 147);
            rdoNam.Margin = new Padding(2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(71, 28);
            rdoNam.TabIndex = 10;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 11F);
            txtSoDienThoai.Location = new Point(178, 278);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(422, 28);
            txtSoDienThoai.TabIndex = 9;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 11F);
            txtDiaChi.Location = new Point(178, 192);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(422, 68);
            txtDiaChi.TabIndex = 8;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Font = new Font("Microsoft Sans Serif", 11F);
            txtHoTen.Location = new Point(178, 40);
            txtHoTen.Margin = new Padding(2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(422, 28);
            txtHoTen.TabIndex = 7;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(25, 279);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 26);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(25, 213);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 26);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(25, 147);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(25, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(25, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstvDSBN);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Microsoft Sans Serif", 11F);
            groupBox2.Location = new Point(0, 392);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1595, 528);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các bệnh nhân";
            // 
            // lstvDSBN
            // 
            lstvDSBN.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstvDSBN.Dock = DockStyle.Bottom;
            lstvDSBN.Font = new Font("Microsoft Sans Serif", 13F);
            lstvDSBN.FullRowSelect = true;
            lstvDSBN.Location = new Point(2, 23);
            lstvDSBN.Margin = new Padding(2);
            lstvDSBN.Name = "lstvDSBN";
            lstvDSBN.Size = new Size(1591, 503);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Microsoft Sans Serif", 13F);
            groupBox3.Location = new Point(970, 0);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(625, 392);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin tiêm chủng";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox4.Location = new Point(39, 38);
            groupBox4.Margin = new Padding(2, 2, 2, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 2, 2, 2);
            groupBox4.Size = new Size(581, 152);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin Vaccine";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Microsoft Sans Serif", 13F);
            textBox3.Location = new Point(110, 108);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(453, 32);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += txtHoTen_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13F);
            label8.Location = new Point(24, 110);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 26);
            label8.TabIndex = 1;
            label8.Text = "Loại ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Microsoft Sans Serif", 13F);
            textBox2.Location = new Point(110, 71);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(453, 32);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += txtHoTen_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13F);
            label7.Location = new Point(28, 74);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 26);
            label7.TabIndex = 1;
            label7.Text = "Tên";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Microsoft Sans Serif", 13F);
            textBox1.Location = new Point(110, 34);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 32);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += txtHoTen_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.Location = new Point(30, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 26);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Microsoft Sans Serif", 13F);
            textBox4.Location = new Point(211, 203);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(406, 32);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += txtHoTen_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Microsoft Sans Serif", 13F);
            textBox5.Location = new Point(211, 242);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(406, 32);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += txtHoTen_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Font = new Font("Microsoft Sans Serif", 13F);
            textBox7.Location = new Point(211, 318);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(406, 0);
            textBox7.TabIndex = 7;
            textBox7.TextChanged += txtHoTen_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13F);
            label11.Location = new Point(19, 244);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 26);
            label11.TabIndex = 1;
            label11.Text = "Ngày tiêm";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Font = new Font("Microsoft Sans Serif", 13F);
            textBox6.Location = new Point(211, 280);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(406, 32);
            textBox6.TabIndex = 7;
            textBox6.TextChanged += txtHoTen_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13F);
            label10.Location = new Point(19, 206);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(108, 26);
            label10.TabIndex = 1;
            label10.Text = "Trạng thái";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label10_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13F);
            label13.Location = new Point(19, 334);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(201, 26);
            label13.TabIndex = 1;
            label13.Text = "Tình trạng sức khỏe";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13F);
            label12.Location = new Point(19, 282);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 26);
            label12.TabIndex = 1;
            label12.Text = "Ngày hẹn tiêm";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 392);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(643, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1595, 920);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label8;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label13;
        private Label label12;
        private TextBox textBox4;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}