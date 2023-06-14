using DocumentFormat.OpenXml.Wordprocessing;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.Spreadsheet;
using Color = System.Drawing.Color;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class RaiseSalaryForm : Form
    {
        private readonly MainForm _parent;
        private DataTable originalDataTable;

        private DataTable filterDataTable;
        private int currentPageIndex = 0; // Trang hiện tại
        private int pageSize = 7; // Số lượng bản ghi trên mỗi trang
        private int totalRecords; // Số lượng bản ghi tổng cộng
        private int totalPages; // Tính tổng số trang
        private int totalFilteredRecords;
        public RaiseSalaryForm()
        {
            InitializeComponent();
        }

        public RaiseSalaryForm(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void RaiseSalary_Load(object sender, EventArgs e)
        {
        }
        private void setButtonIsChoose(int pageIndex, Color textColor, Color backColor)
        {
            if ((pageIndex + 1).ToString() == firstBtn.Text)
            {
                firstBtn.BackColor = textColor;
                firstBtn.ForeColor = backColor;
            }
            else
            {
                firstBtn.BackColor = backColor;
                firstBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == firstindexBtn.Text)
            {
                firstindexBtn.BackColor = textColor;
                firstindexBtn.ForeColor = backColor;
            }
            else
            {
                firstindexBtn.BackColor = backColor;
                firstindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == secondindexBtn.Text)
            {
                secondindexBtn.BackColor = textColor;
                secondindexBtn.ForeColor = backColor;
            }
            else
            {
                secondindexBtn.BackColor = backColor;
                secondindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == threeindexBtn.Text)
            {
                threeindexBtn.BackColor = textColor;
                threeindexBtn.ForeColor = backColor;
            }
            else
            {
                threeindexBtn.BackColor = backColor;
                threeindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == lastBtn.Text)
            {
                lastBtn.BackColor = textColor;
                lastBtn.ForeColor = backColor;
            }
            else
            {
                lastBtn.BackColor = backColor;
                lastBtn.ForeColor = textColor;
            }
        }

        public void Pagination(int pageIndex)
        {
            Color backColor = Color.FromArgb(100, 99, 103);
            Color textColor = Color.White;
            if (totalPages <= 5)
            {
                threedotafterLB.Visible = false;
                threedotbeforeBtn.Visible = false;
                threeindexBtn.Visible = true;
                secondindexBtn.Visible = true;
                firstindexBtn.Visible = true;
                threeindexBtn.Text = "4";
                secondindexBtn.Text = "3";
                firstindexBtn.Text = "2";
                if (totalPages <= 4)
                {

                    lastBtn.Visible = false;


                    if (totalPages <= 3)
                    {
                        threeindexBtn.Visible = false;
                        if (totalPages <= 2)
                        {
                            secondindexBtn.Visible = false;
                            if (totalPages <= 1)
                            {
                                firstindexBtn.Visible = false;
                            }
                        }
                    }
                }
                if (pageIndex == 0)
                {
                    previousBtn.Enabled = false;
                }
                else
                {
                    previousBtn.Enabled = true;
                }
                if (pageIndex == totalPages - 1) // nếu là trang cuối
                {
                    nextBtn.Enabled = false;
                }
                else
                {
                    nextBtn.Enabled = true;
                }
                setButtonIsChoose(pageIndex, textColor, backColor);
            }
            else
            {
                if (pageIndex >= 0 && pageIndex <= 3) //định dạng các trang đầu
                {
                    if (pageIndex == 0)
                    {
                        previousBtn.Enabled = false;
                    }
                    else
                    {
                        previousBtn.Enabled = true;
                    }
                    nextBtn.Enabled = true;
                    threedotbeforeBtn.Visible = false;
                    threedotafterLB.Visible = true;
                    firstindexBtn.Text = "2";
                    secondindexBtn.Text = "3";
                    threeindexBtn.Text = "4";
                    lastBtn.Text = totalPages.ToString();

                    setButtonIsChoose(pageIndex, textColor, backColor);
                }
                else if (pageIndex >= totalPages - 3) // nếu là trang cuối
                {
                    if (pageIndex == totalPages - 1) // nếu là trang cuối
                    {
                        nextBtn.Enabled = false;
                    }
                    else
                    {
                        nextBtn.Enabled = true;
                    }
                    threedotafterLB.Visible = false;
                    threedotbeforeBtn.Visible = true;
                    previousBtn.Enabled = true;
                    firstindexBtn.Text = (totalPages - 3).ToString();
                    secondindexBtn.Text = (totalPages - 2).ToString();
                    threeindexBtn.Text = (totalPages - 1).ToString();
                    setButtonIsChoose(pageIndex, textColor, backColor);

                }
                else if (pageIndex > 3 && pageIndex < totalPages - 3)  //nếu là trang giữa
                {

                    previousBtn.Enabled = true;
                    nextBtn.Enabled = true;
                    threedotbeforeBtn.Visible = true;
                    threedotafterLB.Visible = true;
                    firstindexBtn.Text = pageIndex.ToString();
                    secondindexBtn.Text = (pageIndex + 1).ToString();
                    threeindexBtn.Text = (pageIndex + 2).ToString();
                    setButtonIsChoose(pageIndex, textColor, backColor);

                }
            }
        }
        public DataTable Display(int pageIndex, DataTable dataTable, int pageSize, out int totalRecords)
        {

            // Số lượng bản ghi tổng cộng
            totalRecords = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            firstBtn.Text = "1";

            lastBtn.Text = totalPages.ToString();
            firstindexBtn.Visible = true;
            secondindexBtn.Visible = true;
            threeindexBtn.Visible = true;
            lastBtn.Visible = true;
            Pagination(pageIndex);

            // Lấy chỉ mục bắt đầu và kết thúc của dữ liệu theo trang
            int startIndex = pageIndex * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);

            // Tạo DataTable mới để chứa dữ liệu của trang hiện tại
            DataTable pageDataTable = dataTable.Clone();

            // Sao chép dữ liệu từ DataTable gốc vào DataTable của trang hiện tại
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(dataTable.Rows[i]);
            }

            //// Gắn DataTable của trang hiện tại làm DataSource của DataGridView
            dtLuong.DataSource = pageDataTable;
            filterDataTable = dataTable;

            return pageDataTable;

        }
        public DataTable Display(int pageIndex, int pageSize, out int totalRecords)
        {
            DbCanBo.DisplayAndSearchCanBo("SELECT MaCanBo,HoTen,NgachCongChuc,BacLuong,FORMAT(HeSo, 'N2') AS FormattedPrice,PhuCapChucVu,PhuCapKhac,TongLuong FROM ThongTinCanBo", dtLuong);
            DataTable dataTable = new DataTable();
            dataTable = dtLuong.DataSource as DataTable;
            totalRecords = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            firstBtn.Text = "1";

            lastBtn.Text = totalPages.ToString();
            Pagination(pageIndex);

            // Lấy chỉ mục bắt đầu và kết thúc của dữ liệu theo trang
            int startIndex = pageIndex * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);

            // Tạo DataTable mới để chứa dữ liệu của trang hiện tại
            DataTable pageDataTable = dataTable.Clone();

            // Sao chép dữ liệu từ DataTable gốc vào DataTable của trang hiện tại
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(dataTable.Rows[i]);
            }

            //// Gắn DataTable của trang hiện tại làm DataSource của DataGridView
            dtLuong.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;
        }
        private void RaiseSalary_Shown(object sender, EventArgs e)
        {
            Display(currentPageIndex, pageSize, out totalRecords);
        }



        private void dtLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                RaiseSalaryDetailForm lsluong = new RaiseSalaryDetailForm(this);
                int.TryParse(dtLuong.Rows[e.RowIndex].Cells[1].Value.ToString(), out lsluong.MaCanBo);
                lsluong.NgachCongChuc = dtLuong.Rows[e.RowIndex].Cells[3].Value.ToString();

                int.TryParse(dtLuong.Rows[e.RowIndex].Cells[4].Value.ToString(), out lsluong.BacLuong);
                _parent.loadForm(lsluong);

            }

        }

        private void dtLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtLuong.Columns[e.ColumnIndex].Name == "Column7" || dtLuong.Columns[e.ColumnIndex].Name == "Column6" || dtLuong.Columns[e.ColumnIndex].Name == "Column5")
            {
                // Kiểm tra giá trị của ô không phải rỗng
                if (e.Value != null)
                {
                    // Định dạng giá trị số và thêm dấu phân cách hàng nghìn
                    decimal tongLuong = decimal.Parse(e.Value.ToString());
                    e.Value = tongLuong.ToString("#,##0");
                    e.FormattingApplied = true;
                }
            }
        }
        public void loadPreviousForm()
        {
            _parent.loadForm(this);
        }
        private void xemBtn_Click(object sender, EventArgs e)
        {
            filterID.Visible = !filterID.Visible;
            filterHoTen.Visible = !filterHoTen.Visible;
            loaingachFilter.Visible = !loaingachFilter.Visible;
            bacluongFilter.Visible = !bacluongFilter.Visible;
            hesoFilter.Visible = !hesoFilter.Visible;
            phucapchuvuFilter.Visible = !phucapchuvuFilter.Visible;
            phucapkhacFilter.Visible = !phucapkhacFilter.Visible;
            tongluongFilter.Visible = !tongluongFilter.Visible;
        }

        private void filterID_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterID.Text;
            dtLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                int searchValue;
                if (int.TryParse(searchText, out searchValue))
                {
                    // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                    DataView dataView = originalDataTable.DefaultView;

                    // Áp dụng bộ lọc tương ứng với ID được nhập vào
                    dataView.RowFilter = "MaCanBo = " + searchValue;

                    // Lấy DataTable tìm được từ DataView
                    DataTable filterDataTable = dataView.ToTable();

                    // Cập nhật dữ liệu và biến totalFilteredRecords
                    dtLuong.DataSource = filterDataTable;
                    totalFilteredRecords = filterDataTable.Rows.Count;
                }
                else
                {
                    // Xử lý trường hợp chuỗi không đúng định dạng số nguyên
                    // Hiển thị thông báo hoặc xử lý theo nhu cầu của bạn
                    MessageBox.Show("Vui lòng nhập số!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtLuong.DataSource = Display(currentPageIndex, originalDataTable, pageSize, out totalRecords);
                totalFilteredRecords = totalRecords;
            }
        }

        private void filterHoTen_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterHoTen.Text;
            dtLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("HoTen LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtLuong.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtLuong.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void loaingachFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = loaingachFilter.SelectedItem.ToString();

            if (selectedValue == "Chọn")
            {
                filterDataTable = originalDataTable; // Lấy lại nguồn dữ liệu ban đầu
            }
            else
            {
                // Áp dụng filter cho dữ liệu ban đầu
                DataView dataView = originalDataTable.DefaultView;
                dataView.RowFilter = "NgachCongChuc = '" + selectedValue + "'";
                filterDataTable = dataView.ToTable();
            }

            totalFilteredRecords = filterDataTable.Rows.Count;

            // Hiển thị dữ liệu theo trang đầu tiên
            Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            // Cập nhật lại tổng số bản ghi đã lọc
        }

        private void bacluongFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sortedDataTable;

            if (bacluongFilter.SelectedIndex == 0)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderByDescending(row => row.Field<int>("BacLuong"))
                    .CopyToDataTable();
            }
            else if (bacluongFilter.SelectedIndex == 1)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderBy(row => row.Field<int>("BacLuong"))
                    .CopyToDataTable();
            }
            else
            {
                return; // Không có sắp xếp được chọn
            }

            dtLuong.DataSource = Display(currentPageIndex, sortedDataTable, pageSize, out totalRecords);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            _parent.loadForm(new RaiseSalaryForm(_parent));
            this.Close();
        }

        private void hesoFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sortedDataTable;

            if (hesoFilter.SelectedIndex == 0)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                .OrderByDescending(row =>
                {
                    double formattedPrice;
                    return double.TryParse(row.Field<string>("FormattedPrice"), out formattedPrice)
                        ? formattedPrice
                        : 0.0;
                })
                .CopyToDataTable();
            }
            else if (hesoFilter.SelectedIndex == 1)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                 .OrderBy(row =>
                 {
                     double formattedPrice;
                     if (double.TryParse(row.Field<string>("FormattedPrice"), out formattedPrice))
                     {
                         return formattedPrice;
                     }
                     else
                     {
                         // Xử lý trường hợp không thể chuyển đổi giá trị sang kiểu double
                         // Trả về một giá trị mặc định hoặc xử lý theo nhu cầu của bạn
                         return 0.0; // Giá trị mặc định là 0.0
                     }
                 })
                .CopyToDataTable();
            }
            else
            {
                return; // Không có sắp xếp được chọn
            }

            dtLuong.DataSource = Display(currentPageIndex, sortedDataTable, pageSize, out totalRecords);
        }

        private void phucapchuvuFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sortedDataTable;

            if (phucapchuvuFilter.SelectedIndex == 0)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderByDescending(row => row.Field<long>("PhuCapChucVu"))
                    .CopyToDataTable();
            }
            else if (phucapchuvuFilter.SelectedIndex == 1)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderBy(row => row.Field<long>("PhuCapChucVu"))
                    .CopyToDataTable();
            }
            else
            {
                return; // Không có sắp xếp được chọn
            }

            dtLuong.DataSource = Display(currentPageIndex, sortedDataTable, pageSize, out totalRecords);
        }

        private void phucapkhacFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sortedDataTable;

            if (phucapkhacFilter.SelectedIndex == 0)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderByDescending(row => row.Field<long>("PhuCapKhac"))
                    .CopyToDataTable();
            }
            else if (phucapkhacFilter.SelectedIndex == 1)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderBy(row => row.Field<long>("PhuCapKhac"))
                    .CopyToDataTable();
            }
            else
            {
                return; // Không có sắp xếp được chọn
            }

            dtLuong.DataSource = Display(currentPageIndex, sortedDataTable, pageSize, out totalRecords);
        }

        private void tongluongFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable sortedDataTable;

            if (tongluongFilter.SelectedIndex == 0)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderByDescending(row => row.Field<long>("TongLuong"))
                    .CopyToDataTable();
            }
            else if (tongluongFilter.SelectedIndex == 1)
            {
                sortedDataTable = originalDataTable.AsEnumerable()
                    .OrderBy(row => row.Field<long>("TongLuong"))
                    .CopyToDataTable();
            }
            else
            {
                return; // Không có sắp xếp được chọn
            }

            dtLuong.DataSource = Display(currentPageIndex, sortedDataTable, pageSize, out totalRecords);
        }
        public void ModifyAndSaveExcelFile(string filePath, string newFilePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            DatabaseManager dbManager = new DatabaseManager();
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];

                // Thay đổi các giá trị trong worksheet
                // Tạo ngày tháng năm
                worksheet.Cells["E4:L4"].Merge = true;
                worksheet.Cells["E4:L4"].Value = "Hà Nội, ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
                worksheet.Cells["E4:L4"].Style.Font.Italic = true;
                worksheet.Cells["E4:L4"].Style.Font.Size = 11;
                worksheet.Cells["E4:L4"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["E4:L4"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                //Tạo tiêu đề
                worksheet.Cells["B6:K6"].Merge = true;
                worksheet.Cells["B6:K6"].Value = "DANH SÁCH TỔNG HỢP QUỸ TIỀN LƯƠNG";
                worksheet.Cells["B6:K6"].Style.Font.Bold = true;
                worksheet.Cells["B6:K6"].Style.Font.Size = 14;
                worksheet.Cells["B6:K6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B6:K6"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Column(7).Width = 15;

                int rowStart = 9;
                int colStart = 3;
                int rowEnd = rowStart + dtLuong.Rows.Count - 1; //11
                int colEnd = colStart + dtLuong.Columns.Count - 2; //10
                                                                   //Tạo bảng và chia header 
                                                                   //header
                ExcelRange header = worksheet.Cells["C8:J8"];
                //chỉnh header của bảng
                header.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                worksheet.Cells["C8"].Value = "STT";
                worksheet.Cells["C8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(3).Width = 5;


                worksheet.Cells["D8"].Value = "Họ và tên";
                worksheet.Cells["D8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(4).Width = 25;

                worksheet.Cells["E8"].Value = "Loại ngạch";
                worksheet.Cells["E8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(5).Width = 20;


                worksheet.Cells["F8"].Value = "Bậc lương";
                worksheet.Cells["F8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(6).Width = 15;

                worksheet.Cells["G8"].Value = "Hệ số";
                worksheet.Cells["G8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(7).Width = 15;

                worksheet.Cells["H8"].Value = "Phụ cấp chức vụ (vnd)";
                worksheet.Column(8).Width = 22;
                worksheet.Cells["H8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["I8"].Value = "Phụ cấp khác (vnd)";
                worksheet.Column(9).Width = 20;
                worksheet.Cells["I8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["J8"].Value = "Tổng lương (vnd)";
                worksheet.Column(10).Width = 20;
                worksheet.Cells["J8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                header.Style.Font.Bold = true;
                header.Style.Font.Name = "Times New Roman";
                header.Style.Font.Size = 12;
                header.Style.Border.BorderAround(ExcelBorderStyle.Medium);

                // Ghi dữ liệu từ DataGridView vào ExcelWorksheet
                for (int i = 0; i < dtLuong.Rows.Count; i++)
                {
                    for (int j = 0; j < dtLuong.Columns.Count - 1; j++)
                    {

                        worksheet.Cells[rowStart + i, colStart + j].Value = dtLuong.Rows[i].Cells[j + 1].Value;
                        worksheet.Cells[rowStart + i, colStart + j].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowStart + i, colStart + j].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[rowStart + i, colStart + j].Style.Font.Name = "Times New Roman";
                        worksheet.Cells[rowStart + i, colStart + j].Style.Font.Size = 11;
                        if (j >= dtLuong.Columns.Count - 4)
                        {
                            worksheet.Cells[rowStart + i, colStart + j].Style.Numberformat.Format = "#,##0";
                        }

                    }
                }

                ////thêm cột STT
                for (int i = 0; i < dtLuong.Rows.Count; i++)
                {
                    worksheet.Cells[rowStart + i, colStart].Value = i + 1;
                }

                //ký tên
                ExcelRange table = worksheet.Cells[rowStart, colStart, rowEnd, colEnd];
                table.Style.Border.BorderAround(ExcelBorderStyle.Medium);


                ExcelRange createTableSign = worksheet.Cells[rowEnd + 2, colStart, rowEnd + 2, colStart + 2];
                ExcelRange adminSignRange = worksheet.Cells[rowEnd + 2, colEnd - 2, rowEnd + 2, colEnd];

                adminSignRange.Merge = true;
                adminSignRange.Value = "LÃNH ĐẠO KÝ";
                adminSignRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                adminSignRange.Style.Font.Bold = createTableSign.Style.Font.Bold = true;
                adminSignRange.Style.Font.Name = createTableSign.Style.Font.Name = "Times New Roman";
                adminSignRange.Style.Font.Size = createTableSign.Style.Font.Size = 11;
                createTableSign.Merge = true;
                createTableSign.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                createTableSign.Value = "Người lập bảng";


                // Lưu file Excel mới
                package.SaveAs(new FileInfo(newFilePath));
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo { FileName = newFilePath, UseShellExecute = true });

            }
        }
        private void xuatexcelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất excel danh sách tổng hợp quỹ lương?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ModifyAndSaveExcelFile("C:\\Users\\WINDOWS 10\\Documents\\template.xlsx", "C:\\Users\\WINDOWS 10\\Documents\\luong - Copy.xlsx");

            }
        }
        private void selectDisplay()
        {
            if (filterHoTen.Text != string.Empty || loaingachFilter.SelectedIndex != -1 || bacluongFilter.SelectedIndex != -1 || hesoFilter.SelectedIndex != -1 || phucapchuvuFilter.SelectedIndex != -1 || phucapkhacFilter.SelectedIndex != -1 || tongluongFilter.SelectedIndex != -1)
            {
                Display(currentPageIndex, filterDataTable, pageSize, out totalFilteredRecords);
                return;
            }
            else
            {

                Display(currentPageIndex, pageSize, out totalRecords);
                return;
            }


        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--; // Giảm số trang hiện tại xuống 1 (nếu có thể)

                selectDisplay();
                // Hiển thị dữ liệu trang mới trong DataGridView

            }
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0; // Gán currentPageIndex bằng 0 để chuyển đến trang đầu
            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void firstindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang

            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void secondindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang

            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void threeindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang
            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages - 1) // chưa phải trang cuối
            {

                currentPageIndex++; // Tăng số trang hiện tại lên 1
                selectDisplay();
                // Hiển thị dữ liệu trang mới trong DataGridView

            }



        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages - 1; // Gán currentPageIndex bằng số trang cuối
            selectDisplay();

            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void filterHoTen_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0;
        }
    }
}
