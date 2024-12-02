using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            PhieuNhapBLL pnbll = new PhieuNhapBLL();

            chartPhieuNhap.DataSource = pnbll.ThongKe();
            chartPhieuNhap.Series.Clear();
            var series = chartPhieuNhap.Series.Add("Tổng Tiền");
            foreach (Series t in chartPhieuNhap.Series)
            {
                t.IsValueShownAsLabel = true;
                // Tùy chỉnh định dạng nhãn nếu cần
                t.LabelFormat = "{C}"; // Hoặc "{N0}"
            }
            series.XValueMember = "ThangNam"; // Gán cột "ThangNam" làm trục X
            series.YValueMembers = "TongTien"; // Gán cột "TongTien" làm giá trị Y
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Hiển thị dạng cột

            chartPhieuNhap.DataBind(); // Ràng buộc dữ liệu


            chartHoaDon.DataSource = pnbll.ThongKeHD();
            chartHoaDon.Series.Clear(); chartHoaDon.ChartAreas[0].AxisX.Interval = 1;
            chartHoaDon.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartHoaDon.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8f);
            var seriess = chartHoaDon.Series.Add("Tổng Tiền");
            foreach (Series t in chartHoaDon.Series)
            {
                t.IsValueShownAsLabel = true;
                // Tùy chỉnh định dạng nhãn nếu cần
                t.LabelFormat = "{C}"; // Hoặc "{N0}"
            }
            seriess.XValueMember = "ThangNam"; // Gán cột "ThangNam" làm trục X
            seriess.YValueMembers = "TongTien"; // Gán cột "TongTien" làm giá trị Y
            seriess.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Hiển thị dạng cột

            chartHoaDon.DataBind(); // Ràng buộc dữ liệu


            VaccineBLL vcbll = new VaccineBLL();
            chartVCDaTiem.DataSource = vcbll.ThongKeVCDaTiem();
            chartVCDaTiem.Series.Clear();

            // Tạo Series MỚI cho chartVCDaTiem, không sử dụng seriesss của chartHoaDon
            Series seriesVaccine = chartVCDaTiem.Series.Add("Số lượng Vaccine đã tiêm");


            // Cấu hình cho chartVCDaTiem
            chartVCDaTiem.ChartAreas[0].AxisX.Interval = 1;
            chartVCDaTiem.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartVCDaTiem.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8f);

            // Gán cột từ DataTable cho seriesVaccine
            seriesVaccine.XValueMember = "TenLoai"; // Tên Vaccine trên trục X
            seriesVaccine.YValueMembers = "SoLuong"; // Số lượng đã tiêm trên trục Y
            seriesVaccine.ChartType = SeriesChartType.Column;
            seriesVaccine.IsValueShownAsLabel = true;
            seriesVaccine.LabelFormat = "{N0}"; // Định dạng số lượng (không có tiền tệ)



            chartVCDaTiem.DataBind();

        }
    }
}
