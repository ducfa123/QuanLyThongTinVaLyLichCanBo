using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThongTinVaLyLichCanBo.Class;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using LiveCharts.Configurations;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using OxyPlot;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class ChartForm : Form
    {


        private DatabaseManager dbManager = new DatabaseManager();
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            DisplayGender();
            DisplayAge();
            DisplayHealth();
            DisplayDanToc();
        }

        public void DisplayHealth()
        {
            List<int> heights = DatabaseManager.GetHeightListFromDatabase();
            List<int> weights = DatabaseManager.GetWeightListFromDatabase();

            // Sắp xếp chiều cao và cân nặng theo chiều tăng dần của chiều cao
            var sortedData = heights.Zip(weights, (h, w) => new { Height = h, Weight = w })
                                   .OrderBy(data => data.Height)
                                   .ToList();

            // Tạo series cho đường thẳng
            LineSeries lineSeries = new LineSeries
            {
                Title = "Đường thẳng",
                Values = new ChartValues<ScatterPoint>(),
                PointGeometry = null, // Vô hiệu hóa hiển thị điểm trên đường thẳng
                Stroke = System.Windows.Media.Brushes.Blue,
                StrokeThickness = 2
            };

            // Tạo series cho các điểm
            ScatterSeries scatterSeries = new ScatterSeries
            {
                Title = "Điểm",
                Values = new ChartValues<ScatterPoint>(),
                PointGeometry = DefaultGeometries.Circle,
                Stroke = System.Windows.Media.Brushes.Red,
                Fill = System.Windows.Media.Brushes.Transparent,
                StrokeThickness = 2
            };

            foreach (var data in sortedData)
            {
                double height = data.Height;
                double weight = data.Weight;

                lineSeries.Values.Add(new ScatterPoint(height, weight));
                scatterSeries.Values.Add(new ScatterPoint(height, weight));
            }

            // Tạo SeriesCollection và thêm series vào đó
            SeriesCollection seriesCollection = new SeriesCollection
            {
                lineSeries,
                scatterSeries
            };
            // Cấu hình CartesianChart
            healchart.Series = seriesCollection;
            healchart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Chiều cao",
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12,
            });
            healchart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Cân nặng",
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12,
            });

        }
        public Dictionary<string, int> CalculateAgeStatistics(List<int> ages)
        {
            // Khởi tạo Dictionary để lưu trữ kết quả thống kê
            var statistics = new Dictionary<string, int>();

            // Tính toán thống kê tuổi
            foreach (int age in ages)
            {
                string ageRange = GetAgeRange(age); // Hàm để xác định phạm vi tuổi dựa trên giá trị tuổi

                if (statistics.ContainsKey(ageRange))
                {
                    statistics[ageRange]++; // Tăng số lượng cán bộ trong phạm vi tuổi đã có
                }
                else
                {
                    statistics[ageRange] = 1; // Thêm một phạm vi tuổi mới vào thống kê
                }
            }

            return statistics;
        }

        private string GetAgeRange(int age)
        {
            // Xác định phạm vi tuổi dựa trên giá trị tuổi
            if (age >= 18 && age <= 25)
            {
                return "18-25";
            }
            else if (age >= 26 && age <= 35)
            {
                return "26-35";
            }
            else if (age >= 36 && age <= 45)
            {
                return "36-45";
            }
            else if (age >= 46 && age <= 55)
            {
                return "46-55";
            }
            else
            {
                return "56+";
            }
        }
        public class CustomKeyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                // Xử lý so sánh theo thứ tự yêu cầu
                if (x == "18-25" && y != "18-25")
                    return -1;
                if (y == "18-25" && x != "18-25")
                    return 1;
                if (x == "26-35" && y != "26-35")
                    return -1;
                if (y == "26-35" && x != "26-35")
                    return 1;
                if (x == "36-45" && y != "36-45")
                    return -1;
                if (y == "36-45" && x != "36-45")
                    return 1;
                if (x == "46-55" && y != "46-55")
                    return -1;
                if (y == "46-55" && x != "46-55")
                    return 1;
                if (x == "56+" && y != "56+")
                    return -1;
                if (y == "56+" && x != "56+")
                    return 1;

                // Mặc định, so sánh theo thứ tự từ điển
                return x.CompareTo(y);
            }
        }
        public void DisplayAge()
        {
            List<int> ages = DatabaseManager.GetAgeListFromDatabase();
            Dictionary<string, int> statistics = CalculateAgeStatistics(ages);
            Dictionary<string, int> sortedStatistics = statistics.OrderBy(pair => pair.Key, new CustomKeyComparer()).ToDictionary(pair => pair.Key, pair => pair.Value);

            int maxValue = statistics.Values.Max() + 3; // Tìm giá trị lớn nhất trong danh sách
            List<int> yLabels = Enumerable.Range(0, maxValue + 1).ToList();

            tuoiChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Cán bộ",
                    Values =  new ChartValues<int>(sortedStatistics.Values),
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(20, 186, 26))

                }
            };

            tuoiChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Nhóm Tuổi",
                Labels = sortedStatistics.Keys.ToArray(),
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12
            });


            tuoiChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số Lượng Cán Bộ",
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12,
                MaxValue = maxValue, // Thiết lập giá trị tối đa của trục Y, có thể thêm một giá trị dự phòng (ví dụ: +10) để đảm bảo trục Y hiển thị đủ khoảng trị giá trị
                Labels = yLabels.Select(label => label.ToString()).ToList(), // Chuyển danh sách số nguyên thành danh sách các chuỗi để hiển thị trên trục Y
                MinValue = 0,

            });


        }
        public void DisplayGender()
        {
            var seriesCollection = new SeriesCollection();

            double femalePercent = (double)DatabaseManager.GetFemaleCanBo() / DatabaseManager.GetTotalCanBoCount() * 100;
            double malePercent = (double)DatabaseManager.GetMaleCanBo() / DatabaseManager.GetTotalCanBoCount() * 100;
            double otherPercent = (double)DatabaseManager.GetOtherGenderCanBo() / DatabaseManager.GetTotalCanBoCount() * 100;
            string[] sliceLabels = { "Nam", "Nữ", "Khác" };

            // Add the PieSeries to the SeriesCollection
            seriesCollection.Add(new LiveCharts.Wpf.PieSeries
            {
                Title = sliceLabels[0],
                Values = new ChartValues<double> { Math.Round(malePercent, 2) },
                DataLabels = true
            });

            seriesCollection.Add(new LiveCharts.Wpf.PieSeries
            {
                Title = sliceLabels[1],
                Values = new ChartValues<double> { Math.Round(femalePercent, 2) },
                DataLabels = true
            });

            seriesCollection.Add(new LiveCharts.Wpf.PieSeries
            {
                Title = sliceLabels[2],
                Values = new ChartValues<double> { Math.Round(otherPercent, 2) },
                DataLabels = true
            });
            gioitinhChart.Series = seriesCollection;
            gioitinhChart.LegendLocation = LegendLocation.Right;

        }

        public void DisplayDanToc()
        {

            Dictionary<string, int> ethnicityCounts = DatabaseManager.GetTop5EthnicitiesWithCountFromDatabase();
            List<string> ethnicities = ethnicityCounts.Keys.ToList();

            // Kiểm tra xem từ điển có chứa giá trị "Other" hay không
            if (ethnicityCounts.ContainsKey("Other"))
            {
                // Lấy giá trị của "Other"
                int otherValue = ethnicityCounts["Other"];

                // Xóa khóa "Other" từ từ điển
                ethnicityCounts.Remove("Other");

                // Thêm lại khóa "Other" và giá trị tương ứng vào cuối danh sách
                ethnicities.Remove("Other");
                ethnicities.Add("Other");

                // Cập nhật giá trị "Other" trong từ điển
                ethnicityCounts.Add("Other", otherValue);
            }
            // Tạo danh sách các dân tộc
            if (ethnicities.Contains("Other"))
            {
                // Thay thế giá trị "Other" thành "Khác"
                int index = ethnicities.IndexOf("Other");
                ethnicities[index] = "Khác";
            }
            int maxValue = ethnicityCounts.Values.Max() + 3; // Tìm giá trị lớn nhất trong danh sách
            // Tạo SeriesCollection và ColumnSeries
            SeriesCollection seriesCollection = new SeriesCollection();
            ColumnSeries columnSeries = new ColumnSeries
            {
                Title = "Dân tộc",
                Values = new ChartValues<int>(ethnicityCounts.Values),
            };

            // Thêm ColumnSeries vào SeriesCollection
            seriesCollection.Add(columnSeries);

            // Cấu hình CartesianChart
            dantocChart.Series = seriesCollection;
            dantocChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Dân tộc",
                Labels = ethnicities,
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12,
            });
            dantocChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString(),
                MaxValue = maxValue,
                MinValue = 0,
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                FontSize = 12,
            });
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void xuatPDF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất hình ảnh biểu đồ này? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var oldWidth = healchart.Width;
                var oldHeight = healchart.Height;
                // Thiết lập kích thước và vùng chụp hình
                var chartWidth = 1600;
                var chartHeight = 720;
                var imageRect = new Rectangle(0, 0, chartWidth, chartHeight);

                // Tạo hình ảnh bitmap
                var bitmap = new Bitmap(chartWidth, chartHeight);
                var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ biểu đồ lên hình ảnh
                healchart.Size = new Size(chartWidth, chartHeight);
                healchart.Update();
                healchart.DrawToBitmap(bitmap, imageRect);
                // Lưu hình ảnh vào file
                bitmap.Save(Constant.filePathPNG, ImageFormat.Png);
                healchart.Size = new Size(oldWidth, oldHeight);
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void xuatPdfBtn1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất hình ảnh biểu đồ này? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var oldWidth = gioitinhChart.Width;
                var oldHeight = gioitinhChart.Height;
                // Thiết lập kích thước và vùng chụp hình
                var chartWidth = 1600;
                var chartHeight = 720;
                var imageRect = new Rectangle(0, 0, chartWidth, chartHeight);

                // Tạo hình ảnh bitmap
                var bitmap = new Bitmap(chartWidth, chartHeight);
                var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ biểu đồ lên hình ảnh
                gioitinhChart.Size = new Size(chartWidth, chartHeight);
                gioitinhChart.Update();
                gioitinhChart.DrawToBitmap(bitmap, imageRect);
                // Lưu hình ảnh vào file
                bitmap.Save(Constant.filePathPNG, ImageFormat.Png);
                gioitinhChart.Size = new Size(oldWidth, oldHeight);
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private void xuatPdfBtn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất hình ảnh  biểu đồ này? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var oldWidth = tuoiChart.Width;
                var oldHeight = tuoiChart.Height;
                // Thiết lập kích thước và vùng chụp hình
                var chartWidth = 1600;
                var chartHeight = 720;
                var imageRect = new Rectangle(0, 0, chartWidth, chartHeight);

                // Tạo hình ảnh bitmap
                var bitmap = new Bitmap(chartWidth, chartHeight);
                var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ biểu đồ lên hình ảnh
                tuoiChart.Size = new Size(chartWidth, chartHeight);
                tuoiChart.Update();
                tuoiChart.DrawToBitmap(bitmap, imageRect);
                // Lưu hình ảnh vào file
                bitmap.Save(Constant.filePathPNG, ImageFormat.Png);
                tuoiChart.Size = new Size(oldWidth, oldHeight);
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void xuatPdf4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất hình ảnh biểu đồ này? ", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var oldWidth = dantocChart.Width;
                var oldHeight = dantocChart.Height;
                // Thiết lập kích thước và vùng chụp hình
                var chartWidth = 1600;
                var chartHeight = 720;
                var imageRect = new Rectangle(0, 0, chartWidth, chartHeight);

                // Tạo hình ảnh bitmap
                var bitmap = new Bitmap(chartWidth, chartHeight);
                var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Vẽ biểu đồ lên hình ảnh
                dantocChart.Size = new Size(chartWidth, chartHeight);
                dantocChart.Update();
                dantocChart.DrawToBitmap(bitmap, imageRect);
                // Lưu hình ảnh vào file
                bitmap.Save(Constant.filePathPNG, ImageFormat.Png);
                dantocChart.Size = new Size(oldWidth, oldHeight);
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
