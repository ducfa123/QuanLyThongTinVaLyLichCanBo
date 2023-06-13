using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyThongTinVaLyLichCanBo.Class;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using static MetroFramework.Drawing.MetroPaint;
using Color = System.Drawing.Color;
using Connection = QuanLyThongTinVaLyLichCanBo.Class.Connection;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class KhenThuongForm : Form
    {
        private readonly MainForm _parent;
        public int macanbo;
        private DataTable originalDataTable; // Biến tạm để lưu trữ dữ liệu ban đầu
        private DataTable filterDataTable;
        private int currentPageIndex = 0; // Trang hiện tại
        private int pageSize = 7; // Số lượng bản ghi trên mỗi trang
        private int totalRecords; // Số lượng bản ghi tổng cộng
        private int totalPages; // Tính tổng số trang
        private int totalFilteredRecords;
        public KhenThuongForm(MainForm parent)
        {

            InitializeComponent();
            _parent = parent;
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
            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];

            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            if (nam != null)
            {
                nam.DefaultCellStyle.Format = "yyyy";
            }

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
            dtBaocao.DataSource = pageDataTable;
            filterDataTable = dataTable;

            return pageDataTable;

        }
        public DataTable Display(int pageIndex, int pageSize, out int totalRecords)
        {
            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];

            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            if (nam != null)
            {
                nam.DefaultCellStyle.Format = "yyyy";
            }


            DataTable dataTable = DatabaseManager.GetAllCanBo();
            // Số lượng bản ghi tổng cộng
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
            dtBaocao.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;


        }

        public DataTable DisplayThiDua(int pageIndex, int pageSize, out int totalRecords)
        {
            filterHinhThuc.Items.Clear();
            for (int i = 0; i < Constant.danhsachHinhThucThiDua.Length; i++)
            {
                filterHinhThuc.Items.Add(Constant.danhsachHinhThucThiDua[i]);
            }

            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];
            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            nam.DefaultCellStyle.Format = "yyyy";
            DataTable dataTable = DatabaseManager.GetThiDuaByYear(namIn.Value.Year);
            // Số lượng bản ghi tổng cộng
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
            dtBaocao.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;


        }

        public DataTable DisplayKhenThuong(int pageIndex, int pageSize, out int totalRecords)
        {
            filterHinhThuc.Items.Clear();
            for (int i = 0; i < Constant.danhSachHinhThucKhenThuong.Length; i++)
            {
                filterHinhThuc.Items.Add(Constant.danhSachHinhThucKhenThuong[i]);
            }
            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];
            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            if (nam != null)
            {
                nam.DefaultCellStyle.Format = "yyyy";

            }
            DataTable dataTable = DatabaseManager.GetKhenThuongByYear(namIn.Value.Year);
            // Số lượng bản ghi tổng cộng
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
            dtBaocao.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;


        }
        public DataTable DisplayKyLuat(int pageIndex, int pageSize, out int totalRecords)
        {
            filterHinhThuc.Items.Clear();
            for (int i = 0; i < Constant.danhSachHinhThucKyLuat.Length; i++)
            {
                filterHinhThuc.Items.Add(Constant.danhSachHinhThucKyLuat[i]);
            }

            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];
            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            nam.DefaultCellStyle.Format = "yyyy";
            DataTable dataTable = DatabaseManager.GetKyLuatByYear(namIn.Value.Year);
            // Số lượng bản ghi tổng cộng
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
            dtBaocao.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;


        }
        public DataTable DisplayDanhGia(int pageIndex, int pageSize, out int totalRecords)
        {
            filterHinhThuc.Items.Clear();
            for (int i = 0; i < Constant.danhSachLoaiDanhGia.Length; i++)
            {
                filterHinhThuc.Items.Add(Constant.danhSachLoaiDanhGia[i]);
            }
            DataGridViewColumn ngaysinh = dtBaocao.Columns["dataGridViewTextBoxColumn4"];
            DataGridViewColumn nam = dtBaocao.Columns["Nam"];

            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            nam.DefaultCellStyle.Format = "yyyy";
            DataTable dataTable = DatabaseManager.GetDanhGiaByYear(namIn.Value.Year);
            // Số lượng bản ghi tổng cộng
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
            dtBaocao.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;


        }





        private void PopulateYearList()
        {
            int startYear = 2000; // Năm bắt đầu
            int endYear = DateTime.Now.Year; // Năm hiện tại

            for (int year = endYear; year >= startYear; year--)
            {
                pickyearCBB.Items.Add(year.ToString());
            }
        }
        private void KhenThuong_Shown(object sender, EventArgs e)
        {
            DataTable pageDataTable = Display(currentPageIndex, pageSize, out totalRecords);
            Display(currentPageIndex, pageSize, out totalRecords);
            PopulateYearList();
        }


        private void KhenThuong_Load(object sender, EventArgs e)
        {


        }



        private void dtCanbo_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void loadPreviousForm()
        {
            _parent.loadForm(this);
        }

        private void dtCanbo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtBaocao.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                if (dtBaocao.Columns[e.ColumnIndex].Name == "Column7")
                {
                    ChiTietThiDuaKhenThuongKyLuat cttdktkl = new ChiTietThiDuaKhenThuongKyLuat(this);

                    //int.TryParse(ToString(), out cttdktkl.macanbo);
                    if (comboBox1.SelectedIndex == -1 && pickyearCBB.SelectedIndex == -1)
                        int.TryParse(dtBaocao.Rows[e.RowIndex].Cells[4].Value.ToString(), out cttdktkl.macanbo);

                    else
                        int.TryParse(dtBaocao.Rows[e.RowIndex].Cells[1].Value.ToString(), out cttdktkl.macanbo);

                    cttdktkl.DisplayKhenThuong();
                    this.Hide();
                    _parent.loadForm(cttdktkl);
                }
            }
        }


        public void ModifyAndSaveExcelFile(string filePath, string newFilePath, int year)
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
                if (comboBox1.SelectedIndex == 0)
                {
                    worksheet.Cells["B6:K6"].Value = "BÁO CÁO TỔNG HỢP THI ĐUA NĂM " + year;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    worksheet.Cells["B6:K6"].Value = "BÁO CÁO TỔNG HỢP KHEN THƯỞNG NĂM " + year;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    worksheet.Cells["B6:K6"].Value = "BÁO CÁO TỔNG HỢP TÌNH HÌNH KỶ LUẬT CÁN BỘ NĂM " + year;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    worksheet.Cells["B6:K6"].Value = "BÁO CÁO TỔNG HỢP PHÂN LOẠI, ĐÁNH GIÁ CÁN BỘ NĂM " + year;
                }
                worksheet.Cells["B6:K6"].Style.Font.Bold = true;
                worksheet.Cells["B6:K6"].Style.Font.Size = 14;
                worksheet.Cells["B6:K6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B6:K6"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Column(7).Width = 15;

                //Tạo bảng và chia header 


                ExcelRange header = worksheet.Cells["B8:K8"];
                //chỉnh header của bảng
                header.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
                worksheet.Cells["B8"].Value = "STT";
                worksheet.Cells["B8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["C8:G8"].Merge = true;
                if (comboBox1.SelectedIndex == 0)
                {
                    worksheet.Cells["C8:G8"].Value = "Hình thức thi đua";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    worksheet.Cells["C8:G8"].Value = "Hình thức khen thưởng";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    worksheet.Cells["C8:G8"].Value = "Hình thức kỷ luật";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    worksheet.Cells["C8:G8"].Value = "Mức độ hoàn thành chức trách, nhiệm vụ";
                }
                worksheet.Cells["C8:G8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["H8"].Value = "Số lượng";
                worksheet.Cells["H8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Column(8).Width = 10;


                worksheet.Cells["I8"].Value = "Tỷ lệ (%)";
                worksheet.Column(9).Width = 10;
                worksheet.Cells["I8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["J8"].Value = "Tổng số";
                worksheet.Column(10).Width = 10;
                worksheet.Cells["J8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells["K8"].Value = "Ghi chú";
                worksheet.Column(11).Width = 10;
                worksheet.Cells["K8"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                header.Style.Font.Bold = true;
                header.Style.Font.Name = "Times New Roman";
                header.Style.Font.Size = 12;


                //chỉnh content của bảng
                ExcelRange content = worksheet.Cells["B9:K14"];
                content.Style.Font.Name = "Times New Roman";
                content.Style.Font.Size = 11;
                //thêm content vào cột STT và cột mức độ hoàn thành
                if (comboBox1.SelectedIndex == 0)
                {
                    for (int i = 0; i < Constant.danhsachHinhThucThiDua.Length; i++)
                    {
                        worksheet.Cells[9 + i, 2].Value = i + 1;
                        worksheet.Cells[9 + i, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Merge = true;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Value = Constant.danhsachHinhThucThiDua[i];


                        int tmp1 = DatabaseManager.GetThiDuaCount(Constant.danhsachHinhThucThiDua[i], year);
                        int tmp2 = DatabaseManager.GetTotalCanBoCount();
                        float tmp3 = (float)tmp1 / tmp2 * 100;

                        worksheet.Cells[$"H{9 + i}"].Value = tmp1;
                        worksheet.Cells[$"H{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"I{9 + i}"].Value = Math.Round(tmp3, 2);
                        worksheet.Cells[$"I{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    }
                    worksheet.Cells[$"J9:J{8 + Constant.danhsachHinhThucThiDua.Length}"].Value = DatabaseManager.GetTotalCanBoCount();
                    worksheet.Cells[$"J9:J{8 + Constant.danhsachHinhThucThiDua.Length}"].Merge = true;
                    worksheet.Cells[$"J9:J{8 + Constant.danhsachHinhThucThiDua.Length}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[$"J9:J{8 + Constant.danhsachHinhThucThiDua.Length}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    for (int i = 0; i < Constant.danhSachHinhThucKhenThuong.Length; i++)
                    {
                        worksheet.Cells[9 + i, 2].Value = i + 1;
                        worksheet.Cells[9 + i, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Merge = true;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Value = Constant.danhSachHinhThucKhenThuong[i];


                        int tmp1 = DatabaseManager.GetKhenThuongCount(Constant.danhSachHinhThucKhenThuong[i], year);
                        int tmp2 = DatabaseManager.GetTotalCanBoCount();
                        float tmp3 = (float)tmp1 / tmp2 * 100;

                        worksheet.Cells[$"H{9 + i}"].Value = tmp1;
                        worksheet.Cells[$"H{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"I{9 + i}"].Value = Math.Round(tmp3, 2);
                        worksheet.Cells[$"I{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    }
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKhenThuong.Length}"].Value = DatabaseManager.GetTotalCanBoCount();
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKhenThuong.Length}"].Merge = true;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKhenThuong.Length}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKhenThuong.Length}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    for (int i = 0; i < Constant.danhSachHinhThucKyLuat.Length; i++)
                    {
                        worksheet.Cells[9 + i, 2].Value = i + 1;
                        worksheet.Cells[9 + i, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Merge = true;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Value = Constant.danhSachHinhThucKyLuat[i];


                        int tmp1 = DatabaseManager.GetKyLuatCount(Constant.danhSachHinhThucKyLuat[i], year);
                        int tmp2 = DatabaseManager.GetTotalCanBoCount();
                        float tmp3 = (float)tmp1 / tmp2 * 100;

                        worksheet.Cells[$"H{9 + i}"].Value = tmp1;
                        worksheet.Cells[$"H{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"I{9 + i}"].Value = Math.Round(tmp3, 2);
                        worksheet.Cells[$"I{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    }
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKyLuat.Length}"].Value = DatabaseManager.GetTotalCanBoCount();
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKyLuat.Length}"].Merge = true;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKyLuat.Length}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachHinhThucKyLuat.Length}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    for (int i = 0; i < Constant.danhSachLoaiDanhGia.Length; i++)
                    {
                        worksheet.Cells[9 + i, 2].Value = i + 1;
                        worksheet.Cells[9 + i, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Merge = true;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"C{9 + i}:G{9 + i}"].Value = Constant.danhSachLoaiDanhGia[i];


                        int tmp1 = DatabaseManager.GetDanhGiaCount(Constant.danhSachLoaiDanhGia[i], year);
                        int tmp2 = DatabaseManager.GetTotalCanBoCount();
                        float tmp3 = (float)tmp1 / tmp2 * 100;

                        worksheet.Cells[$"H{9 + i}"].Value = tmp1;
                        worksheet.Cells[$"H{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[$"I{9 + i}"].Value = Math.Round(tmp3, 2);
                        worksheet.Cells[$"I{9 + i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    }
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachLoaiDanhGia.Length}"].Value = DatabaseManager.GetTotalCanBoCount();
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachLoaiDanhGia.Length}"].Merge = true;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachLoaiDanhGia.Length}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[$"J9:J{8 + Constant.danhSachLoaiDanhGia.Length}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                }

                //ký tên
                ExcelRange adminSignRange = null;
                ExcelRange createTableSign = null;
                ExcelRange table = null;
                if (comboBox1.SelectedIndex == 0)
                {
                    adminSignRange = worksheet.Cells[$"I{9 + Constant.danhsachHinhThucThiDua.Length + 1}:K{9 + Constant.danhsachHinhThucThiDua.Length + 1}"];
                    createTableSign = worksheet.Cells[$"B{9 + Constant.danhsachHinhThucThiDua.Length + 1}:D{9 + Constant.danhsachHinhThucThiDua.Length + 1}"];
                    table = worksheet.Cells[$"B8:K{8 + Constant.danhsachHinhThucThiDua.Length}"];

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    adminSignRange = worksheet.Cells[$"I{9 + Constant.danhSachHinhThucKhenThuong.Length + 1}:K{9 + Constant.danhSachHinhThucKhenThuong.Length + 1}"];
                    createTableSign = worksheet.Cells[$"B{9 + Constant.danhSachHinhThucKhenThuong.Length + 1}:D{9 + Constant.danhSachHinhThucKhenThuong.Length + 1}"];
                    table = worksheet.Cells[$"B8:K{8 + Constant.danhSachHinhThucKhenThuong.Length}"];

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    adminSignRange = worksheet.Cells[$"I{9 + Constant.danhSachHinhThucKyLuat.Length + 1}:K{9 + Constant.danhSachHinhThucKyLuat.Length + 1}"];
                    createTableSign = worksheet.Cells[$"B{9 + Constant.danhSachHinhThucKyLuat.Length + 1}:D{9 + Constant.danhSachHinhThucKyLuat.Length + 1}"];
                    table = worksheet.Cells[$"B8:K{8 + Constant.danhSachHinhThucKyLuat.Length}"];

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    adminSignRange = worksheet.Cells[$"I{9 + Constant.danhSachLoaiDanhGia.Length + 1}:K{9 + Constant.danhSachLoaiDanhGia.Length + 1}"];
                    createTableSign = worksheet.Cells[$"B{9 + Constant.danhSachLoaiDanhGia.Length + 1}:D{9 + Constant.danhSachLoaiDanhGia.Length + 1}"];
                    table = worksheet.Cells[$"B8:K{8 + Constant.danhSachLoaiDanhGia.Length}"];

                }

                if (adminSignRange != null && createTableSign != null && table != null)
                {
                    table.Style.Border.BorderAround(ExcelBorderStyle.Medium);
                    adminSignRange.Merge = true;
                    adminSignRange.Value = "LÃNH ĐẠO KÝ";
                    adminSignRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    adminSignRange.Style.Font.Bold = createTableSign.Style.Font.Bold = true;
                    adminSignRange.Style.Font.Name = createTableSign.Style.Font.Name = "Times New Roman";
                    adminSignRange.Style.Font.Size = createTableSign.Style.Font.Size = 11;
                    createTableSign.Merge = true;
                    createTableSign.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    createTableSign.Value = "Người lập bảng";

                }
                // Lưu file Excel mới
                package.SaveAs(new FileInfo(newFilePath));
                MessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo { FileName = newFilePath, UseShellExecute = true });

            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || pickyearCBB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo hoặc năm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xuất excel " + comboBox1.SelectedItem.ToString() + " " + namIn.Value.Year, "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    ModifyAndSaveExcelFile("C:\\Users\\WINDOWS 10\\Documents\\template.xlsx", "C:\\Users\\WINDOWS 10\\Documents\\thidua - Copy.xlsx", namIn.Value.Year);
                    return;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    ModifyAndSaveExcelFile("C:\\Users\\WINDOWS 10\\Documents\\template.xlsx", "C:\\Users\\WINDOWS 10\\Documents\\khenthuong - Copy.xlsx", namIn.Value.Year);
                    return;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    ModifyAndSaveExcelFile("C:\\Users\\WINDOWS 10\\Documents\\template.xlsx", "C:\\Users\\WINDOWS 10\\Documents\\kyluat - Copy.xlsx", namIn.Value.Year);
                    return;

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    ModifyAndSaveExcelFile("C:\\Users\\WINDOWS 10\\Documents\\template.xlsx", "C:\\Users\\WINDOWS 10\\Documents\\danhgia - Copy.xlsx", namIn.Value.Year);
                    return;

                }

            }
        }

        private void xemBtn_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == -1 || pickyearCBB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo hoặc năm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            filterHinhThuc.Visible = true;
            filterHinhThuc.Text = "Chọn";
            filterNoiDung.Visible = true;
            filterNoiDung.Text = string.Empty;
            if (comboBox1.SelectedIndex == 0)
            {
                currentPageIndex = 0;
                DisplayThiDua(currentPageIndex, pageSize, out totalRecords);
                return;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                currentPageIndex = 0;
                DisplayKhenThuong(currentPageIndex, pageSize, out totalRecords);
                return;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                currentPageIndex = 0;
                DisplayKyLuat(currentPageIndex, pageSize, out totalRecords);
                return;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                currentPageIndex = 0;
                DisplayDanhGia(currentPageIndex, pageSize, out totalRecords);
                return;

            }
        }

        private void pickyearCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = pickyearCBB.SelectedItem.ToString();
            namIn.Value = new DateTime(int.Parse(selectedYear), namIn.Value.Month, namIn.Value.Day);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterHoTen.Text;
            dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                dtBaocao.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtBaocao.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterID_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterID.Text;
            dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                    dtBaocao.DataSource = filterDataTable;
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
                dtBaocao.DataSource = Display(currentPageIndex, originalDataTable, pageSize, out totalRecords);
                totalFilteredRecords = totalRecords;
            }
        }

        private void filterNgaySinh_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterNgaySinh.Text.Trim();
            DateTime searchValue;

            if (!string.IsNullOrEmpty(searchText))
            {
                if (DateTime.TryParseExact(searchText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchValue))
                {
                    dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string filterExpression = string.Format("CONVERT(NgaySinh, 'System.DateTime') = #{0}#", searchValue.ToString("yyyy-MM-dd"));
                    (dtBaocao.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
                }
                else
                {
                    // Xử lý trường hợp chuỗi không đúng định dạng
                    // Hiển thị thông báo hoặc xử lý theo nhu cầu của bạn

                }
            }
            else
            {
                // Trả về dữ liệu ban đầu
                (dtBaocao.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void filterGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = filterGioiTinh.SelectedItem.ToString();

            if (selectedValue == "Chọn")
            {
                filterDataTable = originalDataTable; // Lấy lại nguồn dữ liệu ban đầu
            }
            else
            {
                // Áp dụng filter cho dữ liệu ban đầu
                DataView dataView = originalDataTable.DefaultView;
                dataView.RowFilter = "GioiTinh = '" + selectedValue + "'";
                filterDataTable = dataView.ToTable();
            }

            totalFilteredRecords = filterDataTable.Rows.Count;

            // Hiển thị dữ liệu theo trang đầu tiên
            Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            // Cập nhật lại tổng số bản ghi đã lọc
        }

        private void filterChucVu_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterChucVu.Text;
            dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("ChucVu LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtBaocao.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtBaocao.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterDonVi_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterDonVi.Text;
            dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("CoQuanTuyenDung LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtBaocao.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtBaocao.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }


        private void filterHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = filterHinhThuc.SelectedItem.ToString();

            if (selectedValue == "Chọn")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    filterDataTable = DatabaseManager.GetThiDuaByYear(namIn.Value.Year); // Lấy lại nguồn dữ liệu ban đầu

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    filterDataTable = DatabaseManager.GetKhenThuongByYear(namIn.Value.Year);

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    filterDataTable = DatabaseManager.GetKyLuatByYear(namIn.Value.Year);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    filterDataTable = DatabaseManager.GetDanhGiaByYear(namIn.Value.Year);
                }
            }
            else
            {
                // Áp dụng filter cho dữ liệu ban đầu
                DataView dataView = originalDataTable.DefaultView;
                dataView.RowFilter = "HinhThuc = '" + selectedValue + "'";
                filterDataTable = dataView.ToTable();
            }

            totalFilteredRecords = filterDataTable.Rows.Count;

            // Hiển thị dữ liệu theo trang đầu tiên
            Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            // Cập nhật lại tổng số bản ghi đã lọc


        }

        private void filterNoiDung_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterNoiDung.Text;
            dtBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("NoiDung LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtBaocao.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtBaocao.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _parent.loadForm(new KhenThuongForm(_parent));
            this.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            filterID.Visible = !filterID.Visible;
            filterHoTen.Visible = !filterHoTen.Visible;
            filterNgaySinh.Visible = !filterNgaySinh.Visible;
            filterGioiTinh.Visible = !filterGioiTinh.Visible;
            filterDonVi.Visible = !filterDonVi.Visible;
            filterChucVu.Visible = !filterChucVu.Visible;
        }




        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0; // Gán currentPageIndex bằng 0 để chuyển đến trang đầu
            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
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
        private void selectDisplay()
        {
            if (filterGioiTinh.SelectedIndex != -1 || filterHoTen.Text != string.Empty || filterChucVu.Text != string.Empty || filterDonVi.Text != string.Empty || filterHinhThuc.SelectedIndex != -1)
            {
                Display(currentPageIndex, filterDataTable, pageSize, out totalFilteredRecords);
                return;
            }
            if (comboBox1.SelectedIndex == -1 || pickyearCBB.SelectedIndex == -1)
            {
                Display(currentPageIndex, pageSize, out totalRecords);
                return;

            }
            else if (comboBox1.SelectedIndex == 0)
            {
                DisplayThiDua(currentPageIndex, pageSize, out totalRecords);
                return;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DisplayKhenThuong(currentPageIndex, pageSize, out totalRecords);
                return;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                DisplayKyLuat(currentPageIndex, pageSize, out totalRecords);
                return;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                DisplayDanhGia(currentPageIndex, pageSize, out totalRecords);
                return;
            }
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

        private void filterDonVi_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0;

        }
    }
}
