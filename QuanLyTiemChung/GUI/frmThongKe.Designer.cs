namespace GUI
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPhieuNhap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartHoaDon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartVCDaTiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVCDaTiem)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPhieuNhap
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPhieuNhap.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPhieuNhap.Legends.Add(legend1);
            this.chartPhieuNhap.Location = new System.Drawing.Point(-10, 21);
            this.chartPhieuNhap.Name = "chartPhieuNhap";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPhieuNhap.Series.Add(series1);
            this.chartPhieuNhap.Size = new System.Drawing.Size(648, 390);
            this.chartPhieuNhap.TabIndex = 0;
            this.chartPhieuNhap.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(231, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê Nhập Hàng";
            // 
            // chartHoaDon
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHoaDon.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHoaDon.Legends.Add(legend2);
            this.chartHoaDon.Location = new System.Drawing.Point(-23, 434);
            this.chartHoaDon.Name = "chartHoaDon";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHoaDon.Series.Add(series2);
            this.chartHoaDon.Size = new System.Drawing.Size(1385, 390);
            this.chartHoaDon.TabIndex = 2;
            this.chartHoaDon.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(516, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống Kê Bán Vaccine";
            // 
            // chartVCDaTiem
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVCDaTiem.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVCDaTiem.Legends.Add(legend3);
            this.chartVCDaTiem.Location = new System.Drawing.Point(622, 38);
            this.chartVCDaTiem.Name = "chartVCDaTiem";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVCDaTiem.Series.Add(series3);
            this.chartVCDaTiem.Size = new System.Drawing.Size(716, 390);
            this.chartVCDaTiem.TabIndex = 4;
            this.chartVCDaTiem.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(828, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thống Kê Vaccine Đã Tiêm";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 896);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartVCDaTiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartPhieuNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVCDaTiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVCDaTiem;
        private System.Windows.Forms.Label label3;
    }
}