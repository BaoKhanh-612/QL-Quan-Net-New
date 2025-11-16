using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm thư viện Charting
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Li_Tiem_Net.Admin // (Namespace của bạn)
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            // Gắn sự kiện Click cho nút btnXemThongKe
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
        }

        // === SỰ KIỆN CLICK NÚT XEM THỐNG KÊ ===
        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc.");
                return;
            }

            try
            {
                // Tải dữ liệu lên 2 biểu đồ
                // (Sử dụng đúng tên biến designer của bạn)
                LoadPieChart(tuNgay, denNgay);
                LoadLineChart(tuNgay, denNgay);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message);
            }
        }

        // === HÀM TẢI BIỂU ĐỒ TRÒN (TỶ TRỌNG THEO LOẠI) ===
        private void LoadPieChart(DateTime tuNgay, DateTime denNgay)
        {
            // (Dùng đúng tên chartGiaoDich)
            chartGiaoDich.Series.Clear();
            chartGiaoDich.Titles.Clear();
            chartGiaoDich.Legends.Clear();

            // <-- THAY ĐỔI: Tiêu đề mới
            chartGiaoDich.Titles.Add("Tỷ trọng doanh thu theo Loại (Đồ ăn, Đồ uống, Gói chơi)");

            // Truy vấn CSDL
            using (databaseDataContext db = new databaseDataContext())
            {
                var data = db.LichSuMuaHangs
                    // Chỉ lọc theo ngày
                    .Where(ls => ls.NgayMua >= tuNgay && ls.NgayMua <= denNgay)
                    // <-- THAY ĐỔI: Nhóm theo "Loai" thay vì "TenSanPham"
                    .GroupBy(ls => ls.Loai)
                    .Select(g => new
                    {
                        TenLoai = g.Key, // <-- THAY ĐỔI: Tên biến mới cho rõ nghĩa
                        TongDoanhThu = g.Sum(ls => (ls.GiaTien ?? 0M) * (ls.SoLuong ?? 0))
                    })
                    .ToList();

                if (!data.Any())
                {
                    chartGiaoDich.Titles.Add("Không có dữ liệu trong khoảng thời gian này.");
                    return;
                }

                Series series = new Series("DoanhThuTheoLoai") // <-- THAY ĐỔI
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true
                };

                // <-- THAY ĐỔI: Thêm dữ liệu theo "TenLoai"
                foreach (var item in data)
                {
                    DataPoint dataPoint = new DataPoint(0, (double)(item.TongDoanhThu));
                    dataPoint.LegendText = item.TenLoai; // Hiển thị tên Loại ở chú thích
                    dataPoint.Label = $"{item.TenLoai}\n({(item.TongDoanhThu):N0} VNĐ)"; // Hiển thị trên miếng bánh
                    series.Points.Add(dataPoint);
                }

                chartGiaoDich.Series.Add(series);
                chartGiaoDich.Legends.Add(new Legend());
            }
        }

        // === HÀM TẢI BIỂU ĐỒ ĐƯỜNG (TỔNG DOANH THU THEO NGÀY) ===
        private void LoadLineChart(DateTime tuNgay, DateTime denNgay)
        {
            // (Dùng đúng tên chartDoanhThu)
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.ChartAreas.Clear();

            // <-- THAY ĐỔI: Tiêu đề mới
            chartDoanhThu.Titles.Add("Tổng doanh thu theo ngày (Tất cả)");

            // Cấu hình khu vực biểu đồ (trục X, Y)
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartArea.AxisX.LabelStyle.Format = "dd/MM";
            chartArea.AxisX.MajorGrid.Enabled = false;

            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisY.LabelStyle.Format = "N0";

            chartDoanhThu.ChartAreas.Add(chartArea);

            // Truy vấn CSDL
            using (databaseDataContext db = new databaseDataContext())
            {
                var data = db.LichSuMuaHangs
                    // <-- THAY ĐỔI: Bỏ lọc "DoAn", "DoUong"
                    .Where(ls => ls.NgayMua >= tuNgay && ls.NgayMua <= denNgay)
                    .GroupBy(ls => ls.NgayMua.Value.Date) // Nhóm theo ngày
                    .Select(g => new
                    {
                        Ngay = g.Key,
                        TongDoanhThu = g.Sum(ls => (ls.GiaTien ?? 0M) * (ls.SoLuong ?? 0))
                    })
                    .OrderBy(d => d.Ngay) // Sắp xếp
                    .ToList();

                if (!data.Any())
                {
                    chartDoanhThu.Titles.Add("Không có dữ liệu trong khoảng thời gian này.");
                    return;
                }

                // Tạo Series mới
                Series series = new Series("DoanhThuNgay")
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 3,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    XValueType = ChartValueType.DateTime
                };

                // Thêm dữ liệu vào Series
                foreach (var item in data)
                {
                    series.Points.AddXY(item.Ngay, (double)(item.TongDoanhThu));
                }

                chartDoanhThu.Series.Add(series);
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}