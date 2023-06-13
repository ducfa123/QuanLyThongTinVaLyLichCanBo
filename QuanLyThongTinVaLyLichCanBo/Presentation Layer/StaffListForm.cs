using Microsoft.Office.Core;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class ListCanbo : Form
    {
        private readonly MainForm _parent;
        private DataTable originalDataTable; // Biến tạm để lưu trữ dữ liệu ban đầu
        private DataTable filterDataTable;
        private int currentPageIndex = 0; // Trang hiện tại
        private int pageSize = 7; // Số lượng bản ghi trên mỗi trang
        private int totalRecords; // Số lượng bản ghi tổng cộng
        private int totalPages; // Tính tổng số trang
        private int totalFilteredRecords;
        CanBoInfomation tt;
        public ListCanbo(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            tt = new CanBoInfomation(this);
        }

        private void ListCanbo_Load(object sender, EventArgs e)
        {

        }

        private void dtDanhsachcanbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dtCanbo.DataSource = pageDataTable;
            filterDataTable = dataTable;

            return pageDataTable;

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
        public DataTable Display(int pageIndex, int pageSize, out int totalRecords)
        {
            DbCanBo.DisplayAndSearchCanBo("SELECT MaCanBo,HoTen,GioiTinh,NgaySinh,ChucVu,CoQuanTuyenDung FROM ThongTinCanBo", dtCanbo);
            DataGridViewColumn ngaysinh = dtCanbo.Columns["Column4"];
            ngaysinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            DataTable dataTable = new DataTable();

            dataTable = dtCanbo.DataSource as DataTable;
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
            dtCanbo.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            tt.Clear();
            _parent.loadForm(tt);

        }

        private void dtCanbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListCanbo_Shown(object sender, EventArgs e)
        {
            Display(currentPageIndex, pageSize, out totalRecords);
        }



        private void dtCanbo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit 
            {
                tt.Clear();
                tt.id = (int)dtCanbo.Rows[e.RowIndex].Cells[2].Value;

                using (SqlConnection con = Connection.GetSqlConnection())
                {

                    con.Open();
                    string query = "SELECT HoTen,NgaySinh,AnhDaiDien,imgpath,DanToc,TonGiao,GioiTinh,HoKhauThuongTru,TenGoiKhac,NoiSinh,QueQuan,NoiOHienNay,NgheNghiep,NgayTuyenDung,CoQuanTuyenDung,ChucVu,NgayThangBoNhiemCV,NgachCongChuc,TenNgach,BacLuong,HeSo,PhuCapChucVu,PhuCapKhac,NgayVaoDCSVN,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhat,DanhHieuCaoNhat,KhenThuong,KyLuat,ChieuCao,CanNang,NhomMau,HangThuongBinh,GiaDinhChinhSach,ChungMinhND,NgayCapCMND,MaBHXH FROM ThongTinCanBo WHERE MaCanBo = @macanbo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@macanbo", dtCanbo.Rows[e.RowIndex].Cells[2].Value.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (int.TryParse(dtCanbo.Rows[e.RowIndex].Cells[2].Value.ToString(), out tt.id))
                    {


                    }


                    if (reader.Read())
                    {
                        tt.fullname = reader.GetString(0);
                        if (reader.IsDBNull(1))
                        {
                            tt.dtngaysinh = DateTime.Now;
                        }
                        else
                        {
                            tt.dtngaysinh = reader.GetDateTime(1);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")))
                        {
                            tt.image = (byte[])reader["AnhDaiDien"];
                        }
                        else
                        {
                            tt.image = null;
                        }
                        if (!reader.IsDBNull(3))
                        {
                            tt.imgpath = reader.GetString(3);
                        }
                        else
                        {
                            tt.imgpath = string.Empty;

                        }
                        if (!reader.IsDBNull(4))
                        {
                            tt.dantoc = reader.GetString(4);
                        }
                        else
                        {
                            tt.dantoc = string.Empty;

                        }
                        if (!reader.IsDBNull(5))
                        {
                            tt.tongiao = reader.GetString(5);
                        }
                        else
                        {
                            tt.tongiao = string.Empty;

                        }
                        if (!reader.IsDBNull(6))
                        {
                            tt.gioitinh = reader.GetString(6);
                        }
                        else
                        {
                            tt.gioitinh = string.Empty;
                        }
                        if (!reader.IsDBNull(7))
                        {
                            tt.hokhau = reader.GetString(7);
                        }
                        else
                        {
                            tt.hokhau = string.Empty;
                        }
                        if (!reader.IsDBNull(8))
                        {
                            tt.othername = reader.GetString(8);
                        }
                        else
                        {
                            tt.othername = string.Empty;
                        }
                        if (!reader.IsDBNull(9))
                        {
                            tt.noisinh = reader.GetString(9);
                        }
                        else
                        {
                            tt.noisinh = string.Empty;
                        }
                        if (!reader.IsDBNull(10))
                        {
                            tt.quequan = reader.GetString(10);
                        }
                        else
                        {
                            tt.quequan = string.Empty;
                        }
                        if (!reader.IsDBNull(11))
                        {
                            tt.noio = reader.GetString(11);
                        }
                        else
                        {
                            tt.noio = string.Empty;
                        }
                        if (!reader.IsDBNull(12))
                        {
                            tt.nghenghiep = reader.GetString(12);
                        }
                        else
                        {
                            tt.nghenghiep = string.Empty;
                        }
                        if (!reader.IsDBNull(14))
                        {
                            tt.coquan = reader.GetString(14);
                        }
                        else
                        {
                            tt.coquan = string.Empty;
                        }
                        if (!reader.IsDBNull(15))
                        {
                            tt.chucvu = reader.GetString(15);
                        }
                        else
                        {
                            tt.chucvu = string.Empty;
                        }
                        if (!reader.IsDBNull(13))
                        {
                            tt.dtngaytuyendung = reader.GetDateTime(13);
                        }
                        else
                        {
                            tt.dtngaytuyendung = DateTime.Now;
                        }
                        if (!reader.IsDBNull(16))
                        {
                            tt.dtngaybonhiem = reader.GetDateTime(16);
                        }
                        else
                        {
                            tt.dtngaybonhiem = DateTime.Now;
                        }
                        if (!reader.IsDBNull(17))
                        {
                            tt.nghachcongchuc = reader.GetString(17);
                        }
                        else
                        {
                            tt.nghachcongchuc = string.Empty;
                        }
                        if (!reader.IsDBNull(18))
                        {
                            tt.tenngach = reader.GetString(18);
                        }
                        else
                        {
                            tt.tenngach = string.Empty;
                        }
                        if (!reader.IsDBNull(19))
                        {
                            tt.bacluong = reader.GetInt32(19);
                        }
                        else
                        {
                            tt.bacluong = 0;
                        }
                        if (!reader.IsDBNull(20))
                        {
                            tt.heso = (float)Math.Round(Convert.ToSingle(reader.GetDouble(20)), 2);
                        }
                        else
                        {
                            tt.heso = 0;
                        }
                        if (!reader.IsDBNull(21))
                        {
                            tt.phucapCV = (int)reader.GetInt64(21);
                        }
                        else
                        {
                            tt.phucapCV = 0;
                        }
                        if (!reader.IsDBNull(22))
                        {
                            tt.phucapkhac = (int)reader.GetInt64(22);
                        }
                        else
                        {
                            tt.phucapkhac = 0;
                        }
                        if (!reader.IsDBNull(23))
                        {
                            tt.dtngayvaodang = reader.GetDateTime(23);
                        }
                        else
                        {
                            tt.dtngayvaodang = DateTime.Now;
                        }
                        if (!reader.IsDBNull(24))
                        {
                            tt.dtngaychinhthuc = reader.GetDateTime(24);
                        }
                        else
                        {
                            tt.dtngaychinhthuc = DateTime.Now;
                        }
                        if (!reader.IsDBNull(25))
                        {
                            tt.dtngaynhapngu = reader.GetDateTime(25);
                        }
                        else
                        {
                            tt.dtngaynhapngu = DateTime.Now;
                        }
                        if (!reader.IsDBNull(26))
                        {
                            tt.dtngayxuatngu = reader.GetDateTime(26);
                        }
                        else
                        {
                            tt.dtngayxuatngu = DateTime.Now;
                        }
                        if (!reader.IsDBNull(27))
                        {
                            tt.quanham = reader.GetString(27);
                        }
                        else
                        {
                            tt.quanham = string.Empty;
                        }
                        if (!reader.IsDBNull(28))
                        {
                            tt.danhhieu = reader.GetString(28);
                        }
                        else
                        {
                            tt.danhhieu = string.Empty;
                        }
                        if (!reader.IsDBNull(29))
                        {
                            tt.khenthuong = reader.GetString(29);
                        }
                        else
                        {
                            tt.khenthuong = string.Empty;
                        }
                        if (!reader.IsDBNull(30))
                        {
                            tt.kyluat = reader.GetString(30);
                        }
                        else
                        {
                            tt.kyluat = string.Empty;
                        }
                        if (!reader.IsDBNull(31))
                        {
                            tt.chieucao = reader.GetString(31);
                        }
                        else
                        {
                            tt.chieucao = string.Empty;
                        }
                        if (!reader.IsDBNull(32))
                        {
                            tt.cannang = reader.GetString(32);
                        }
                        else
                        {
                            tt.cannang = string.Empty;
                        }
                        if (!reader.IsDBNull(33))
                        {
                            tt.nhommau = reader.GetString(33);
                        }
                        else
                        {
                            tt.nhommau = string.Empty;
                        }
                        if (!reader.IsDBNull(34))
                        {
                            tt.hangthuongbinh = reader.GetString(34);
                        }
                        else
                        {
                            tt.hangthuongbinh = string.Empty;
                        }
                        if (!reader.IsDBNull(35))
                        {
                            tt.giadinhchinhsach = reader.GetString(35);
                        }
                        else
                        {
                            tt.giadinhchinhsach = string.Empty;
                        }
                        if (!reader.IsDBNull(36))
                        {
                            tt.socmnd = reader.GetString(36);
                        }
                        else
                        {
                            tt.socmnd = string.Empty;
                        }
                        if (!reader.IsDBNull(37))
                        {
                            tt.dtngaycapcmnd = reader.GetDateTime(37);
                        }
                        else
                        {
                            tt.dtngaycapcmnd = DateTime.Now;
                        }
                        if (!reader.IsDBNull(38))
                        {
                            tt.mabhxh = reader.GetString(38);
                        }
                        else
                        {
                            tt.mabhxh = string.Empty;
                        }
                    }
                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        string queryy = "SELECT MaLSBT,DiTu,BatDauDiTu,KetThucDiTu,LyDoDiTu,LamViecChoCheDoCu,CoQuan,DiaDiem,ChucVu,ThoiGianLamViec,QuanHeVoiToChucNuocNgoai,MucDich,TenToChuc,DiaDiemTruSo,CoNguoiNhaONN,QuanHeNguoiNha,NgheNghiep,NoiO FROM LichSuBanThan WHERE MaCanBo = @id";
                        SqlCommand command = new SqlCommand(queryy, conn);
                        command.Parameters.AddWithValue("@id", dtCanbo.Rows[e.RowIndex].Cells[2].Value.ToString()); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                        SqlDataReader readerr = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                        if (reader.Read())
                        {
                            tt.haslsbt = true;
                            //nếu có lsbt
                            tt.maLSBT = reader.GetInt32(0);
                            tt.ditu = reader.GetBoolean(1);
                            tt.batdauditu = reader.GetDateTime(2);
                            tt.ketthucditu = reader.GetDateTime(3);
                            tt.lydoditu = reader.GetString(4);
                            tt.lamviecchochedocu = reader.GetBoolean(5);
                            tt.coquanlsbt = reader.GetString(6);
                            tt.diadiem = reader.GetString(7);
                            tt.chucvulsbt = reader.GetString(8);
                            tt.thoigianlamviec = reader.GetInt32(9);
                            tt.quanhevoitochucnuocngoai = reader.GetBoolean(10);
                            tt.mucdich = reader.GetString(11);
                            tt.tentochuc = reader.GetString(12);
                            tt.diadiemtruso = reader.GetString(13);
                            tt.conguoinhaonn = reader.GetBoolean(14);
                            tt.quanhenguoinha = reader.GetString(15);
                            tt.nghenghieplsbt = reader.GetString(16);
                            tt.noiolsbt = reader.GetString(17);

                        }
                        else
                        {
                            tt.haslsbt = false;
                            //nếu không có lsbt
                        }
                        tt.Update();
                        tt.DisplayLichSu();
                        _parent.loadForm(tt);
                        return;
                    }
                }
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi cán bộ này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbCanBo.DeleteCanBo(dtCanbo.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display(currentPageIndex, pageSize, out totalRecords);
                }
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchIcon_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xemBtn_Click(object sender, EventArgs e)
        {
            filterID.Visible = !filterID.Visible;
            filterHoTen.Visible = !filterHoTen.Visible;
            filterGioiTinh.Visible = !filterGioiTinh.Visible;
            filterNgaySinh.Visible = !filterNgaySinh.Visible;
            filterDonVi.Visible = !filterDonVi.Visible;
            filterChucVu.Visible = !filterChucVu.Visible;

        }

        private void filterID_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterID.Text;
            dtCanbo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                    dtCanbo.DataSource = filterDataTable;
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
                dtCanbo.DataSource = Display(currentPageIndex, originalDataTable, pageSize, out totalRecords);
                totalFilteredRecords = totalRecords;
            }

        }
        public void loadPreviousForm()
        {
            _parent.loadForm(this);

        }
        private void filterHoTen_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterHoTen.Text;
            dtCanbo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                dtCanbo.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtCanbo.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
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

        private void filterNgaySinh_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterNgaySinh.Text.Trim();
            DateTime searchValue;

            if (!string.IsNullOrEmpty(searchText))
            {
                if (DateTime.TryParseExact(searchText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out searchValue))
                {
                    dtCanbo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    string filterExpression = string.Format("CONVERT(NgaySinh, 'System.DateTime') = #{0}#", searchValue.ToString("yyyy-MM-dd"));
                    (dtCanbo.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
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
                (dtCanbo.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void filterChucVu_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterChucVu.Text;
            dtCanbo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                dtCanbo.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtCanbo.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterDonVi_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterDonVi.Text;
            dtCanbo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                dtCanbo.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtCanbo.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            _parent.loadForm(new ListCanbo(_parent));
            this.Close();
        }
        private void selectDisplay()
        {
            if (filterHoTen.Text != string.Empty || filterGioiTinh.SelectedIndex != -1 || filterChucVu.Text != string.Empty || filterDonVi.Text != string.Empty)
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

        private void filterID_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0;

        }
    }
}