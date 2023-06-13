using MySql.Data.MySqlClient;
using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class RewardDetailForm : Form
    {
        private readonly RewardForm _parent;

        public int macanbo;
        public string HinhThuc, SoQuyetDinh, CoQuanBanHanh, NoiDung;
        public DateTime NgayKy, Nam;
        public int MucKhenThuong, MaKhenThuong;

        public string HinhThucThiDua, SoQuyetDinhThiDua, CoQuanBanHanhThiDua, NoiDungThiDua;
        public DateTime NgayKyThiDua, NamThiDua;
        public int MucKhenThuongThiDua, MaThiDua;

        public string LoaiDanhGia, NoiDungDanhGia;
        public DateTime NamDanhGia;
        public int MaDanhGia;

        public int MaKyLuat, ThoiGianKeoDai;
        public string HinhThucKyLuat, SoQuyetDinhKyLuat, CoQuanBanHanhKyLuat, NoiDungKyLuat;
        public DateTime NamKyLuat;
        public RewardDetailForm(RewardForm parent)
        {

            InitializeComponent();
            _parent = parent;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //DisplayKhenThuong();
        }





        private void label18_Click(object sender, EventArgs e)
        {

        }
        public void DisplayThiDua()
        {

            DataGridViewColumn nam = dtThidua.Columns["dataGridViewTextBoxColumn16"];
            nam.DefaultCellStyle.Format = "yyyy";
            DbThidua.DisplayAndSearchThidua("SELECT MaThiDua , SoQuyetDinh, Nam, HinhThuc, CoQuanBanHanh, NoiDung, MucKhenThuong FROM ThiDua WHERE MaCanBo = @macanbo", macanbo, dtThidua);



        }
        public void DisplayKhenThuong()
        {

            DataGridViewColumn nam = dtKhenthuong.Columns["dataGridViewTextBoxColumn3"];
            nam.DefaultCellStyle.Format = "yyyy";

            DbKhenthuong.DisplayAndSearchKhenThuong("SELECT MaKhenThuong, SoQuyetDinh, Nam, HinhThuc, CoQuanBanHanh, NoiDung, MucKhenThuong FROM KhenThuong WHERE MaCanBo = @macanbo", macanbo, dtKhenthuong);


        }
        public void DisplayKyLuat()
        {
            DataGridViewColumn ngayky = dtKyluat.Columns["dataGridViewTextBoxColumn7"];
            ngayky.DefaultCellStyle.Format = "yyyy";
            DbKyluat.DisplayAndSearchKyluat("SELECT MaKyLuat, HinhThucKyLuat, SoQuyetDinh, Nam, ThoiGianKeoDai, CoQuanBanHanh, NoiDung FROM KyLuat WHERE MaCanBo = @macanbo", macanbo, dtKyluat);
        }
        public void DisplayDanhGia()
        {
            DataGridViewColumn nam = dtDanhgia.Columns["dataGridViewTextBoxColumn12"];
            nam.DefaultCellStyle.Format = "yyyy";
            DbDanhgia.DisplayAndSearchDanhGia("SELECT MaDanhGia, Nam, LoaiDanhGia, NoiDung FROM DanhGia WHERE MaCanBo = @macanbo", macanbo, dtDanhgia);

        }
        public void ClearKhenThuong()
        {
            comboBox1.SelectedIndex = -1;
            MaKhenThuong = 0;
            hinhthucIn.SelectedIndex = -1;
            namIn.Value = ngayKyIn.Value = DateTime.Now;
            soquyetdinhIn.Text = coquanbanhanhIn.Text = noidungIn.Text = muckhenthuongIn.Text = string.Empty;
            HinhThuc = "";
            Nam = DateTime.Now;
            NgayKy = DateTime.Now;
            SoQuyetDinh = "";
            CoQuanBanHanh = "";
            NoiDung = "";
            MucKhenThuong = 0;
        }
        public void ClearThidua()
        {
            comboBox2.SelectedIndex = -1;
            MaThiDua = 0;
            hinhthucthiduaIn.SelectedIndex = -1;
            namtdIn.Value = ngaykytdIn.Value = DateTime.Now;
            soquyetdinhtdIn.Text = coquanbanhanhtdIn.Text = noidungtdIn.Text = muckhenthuongtdIn.Text = string.Empty;
            HinhThucThiDua = "";
            NamThiDua = DateTime.Now;
            NgayKyThiDua = DateTime.Now;
            SoQuyetDinhThiDua = "";
            CoQuanBanHanhThiDua = "";
            NoiDungThiDua = "";
            MucKhenThuongThiDua = 0;
        }
        public void ClearKyLuat()
        {
            pickyearCBB.SelectedIndex = -1;
            hinhthucklIn.SelectedIndex = -1;
            coquanbanhanhklIn.Text = noidungklIn.Text = thoigiankeodaiklIn.Text = soquyetdinhklIn.Text = string.Empty;
            ngaykyklIn.Value = DateTime.Now;

            MaKyLuat = 0;
            HinhThucKyLuat = "";
            SoQuyetDinhKyLuat = "";
            CoQuanBanHanhKyLuat = "";
            ThoiGianKeoDai = 0;
            NoiDungKyLuat = "";
            NamKyLuat = DateTime.Now;



        }
        public void ClearDanhGia()
        {
            comboBox3.SelectedIndex = -1;
            loaidanhgiaIn.SelectedIndex = -1;
            noidungdanhgiaIn.Text = string.Empty;
            namdanhgiaIn.Value = DateTime.Now;

            MaDanhGia = 0;

            LoaiDanhGia = "";
            NoiDungDanhGia = "";
            NamDanhGia = DateTime.Now;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ktPage)
            {
                DisplayKhenThuong();
            }
            else if (tabControl1.SelectedTab == tdPage)
            {
                DisplayThiDua();
            }
            else if (tabControl1.SelectedTab == klPage)
            {
                DisplayKyLuat();
            }
            else if (tabControl1.SelectedTab == dgPage)
            {
                DisplayDanhGia();
            }

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (hinhthucIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hình thức Khen thưởng!");
                    return;
                }
                HinhThuc = hinhthucIn.SelectedItem.ToString();
                Nam = namIn.Value;
                NgayKy = ngayKyIn.Value;
                SoQuyetDinh = soquyetdinhIn.Text;
                CoQuanBanHanh = coquanbanhanhIn.Text;
                NoiDung = noidungIn.Text;
                if (!int.TryParse(muckhenthuongIn.Text, out MucKhenThuong))
                {
                    MessageBox.Show("Mức khen thưởng là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                KhenThuong kt = new KhenThuong(HinhThuc, SoQuyetDinh, CoQuanBanHanh, NoiDung, MucKhenThuong, macanbo, Nam, NgayKy);
                DbKhenthuong.addKhenThuong(kt);
                ClearKhenThuong();
                DisplayKhenThuong();


            }
            catch (Exception)
            {

                throw;
            }


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaKhenThuong == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin khen thưởng muốn sửa!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                HinhThuc = hinhthucIn.SelectedItem.ToString();
                Nam = namIn.Value;
                NgayKy = ngayKyIn.Value;
                SoQuyetDinh = soquyetdinhIn.Text;
                CoQuanBanHanh = coquanbanhanhIn.Text;
                NoiDung = noidungIn.Text;
                int.TryParse(muckhenthuongIn.Text, out MucKhenThuong);

                KhenThuong kt = new KhenThuong(HinhThuc, SoQuyetDinh, CoQuanBanHanh, NoiDung, MucKhenThuong, macanbo, Nam, NgayKy);
                MessageBox.Show(MaKhenThuong.ToString());
                DbKhenthuong.updateKhenThuong(kt, MaKhenThuong);


                ClearKhenThuong();
                DisplayKhenThuong();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ClearKhenThuong();
        }

        private void dtKhenthuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            //edit
            {
                ClearKhenThuong();
                if (dtKhenthuong.Rows.Count > 0 && dtKhenthuong.Columns.Count > 2)
                {
                    int.TryParse(dtKhenthuong.Rows[e.RowIndex].Cells[2].Value.ToString(), out MaKhenThuong);
                    // Tiếp tục xử lý dựa trên giá trị MaKhenThuong
                }
                else
                {
                    // Xử lý khi collection không có đủ phần tử hoặc không có đủ cột
                }
                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT SoQuyetDinh, Nam, HinhThuc,NgayKy, CoQuanBanHanh, NoiDung, MucKhenThuong FROM KhenThuong WHERE MaKhenThuong = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", MaKhenThuong); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader
                    if (reader.Read())
                    {
                        SoQuyetDinh = reader.GetString(0);
                        Nam = reader.GetDateTime(1);
                        HinhThuc = reader.GetString(2);
                        NgayKy = reader.GetDateTime(3);
                        CoQuanBanHanh = reader.GetString(4);
                        NoiDung = reader.GetString(5);
                        MucKhenThuong = (int)(long)reader.GetInt64(6);
                    }
                }
                soquyetdinhIn.Text = SoQuyetDinh;
                namIn.Value = Nam;
                comboBox1.SelectedItem = Nam.Year.ToString();
                ngayKyIn.Value = NgayKy;
                hinhthucIn.Text = HinhThuc;
                coquanbanhanhIn.Text = CoQuanBanHanh;
                noidungIn.Text = NoiDung;
                muckhenthuongIn.Text = MucKhenThuong.ToString();

                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin khen thưởng này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbKhenthuong.DeleteKhenThuong(dtKhenthuong.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayKhenThuong();
                }
                return;
            }

        }

        private void dtKhenthuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtKhenthuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtKhenthuong.Columns[e.ColumnIndex].Name == "Column12")
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


        private void cleardanhgiaBtn_Click(object sender, EventArgs e)
        {
            ClearDanhGia();
        }

        private void suadanhgiaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaDanhGia == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin đánh giá muốn sửa!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                NamDanhGia = namdanhgiaIn.Value;
                LoaiDanhGia = loaidanhgiaIn.SelectedItem.ToString();
                NoiDungDanhGia = noidungdanhgiaIn.Text;


                DanhGia dg = new DanhGia(LoaiDanhGia, NoiDungDanhGia, macanbo, NamDanhGia);
                DbDanhgia.updateDanhgia(dg, MaDanhGia);


                ClearDanhGia();
                DisplayDanhGia();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void themdanhgiaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaidanhgiaIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn loại đánh giá!");
                    return;
                }
                NamDanhGia = namdanhgiaIn.Value;
                LoaiDanhGia = loaidanhgiaIn.SelectedItem.ToString();
                NoiDungDanhGia = noidungdanhgiaIn.Text;


                DanhGia dg = new DanhGia(LoaiDanhGia, NoiDungDanhGia, macanbo, NamDanhGia);
                DbDanhgia.addDanhgia(dg);
                ClearDanhGia();
                DisplayDanhGia();

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void dtThidua_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtThidua.Columns[e.ColumnIndex].Name == "dataGridViewTextBoxColumn21")
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

        private void themtdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (hinhthucthiduaIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hình thức thi đua!");
                    return;
                }
                HinhThucThiDua = hinhthucthiduaIn.SelectedItem.ToString();
                NamThiDua = namtdIn.Value;
                NgayKyThiDua = ngaykytdIn.Value;
                SoQuyetDinhThiDua = soquyetdinhtdIn.Text;
                CoQuanBanHanhThiDua = coquanbanhanhtdIn.Text;
                NoiDungThiDua = noidungtdIn.Text;
                if (!int.TryParse(muckhenthuongtdIn.Text, out MucKhenThuongThiDua))
                {
                    MessageBox.Show("Mức khen thưởng là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Thidua kt = new Thidua(HinhThucThiDua, SoQuyetDinhThiDua, CoQuanBanHanhThiDua, NoiDungThiDua, MucKhenThuongThiDua, macanbo, NamThiDua, NgayKyThiDua);
                DbThidua.addThidua(kt);
                ClearThidua();
                DisplayThiDua();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void suatdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaThiDua == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin thi đua muốn sửa!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                HinhThucThiDua = hinhthucthiduaIn.SelectedItem.ToString();
                NamThiDua = namtdIn.Value;
                NgayKyThiDua = ngaykytdIn.Value;
                SoQuyetDinhThiDua = soquyetdinhtdIn.Text;
                CoQuanBanHanhThiDua = coquanbanhanhtdIn.Text;
                NoiDungThiDua = noidungtdIn.Text;
                int.TryParse(muckhenthuongtdIn.Text, out MucKhenThuongThiDua);

                Thidua kt = new Thidua(HinhThucThiDua, SoQuyetDinhThiDua, CoQuanBanHanhThiDua, NoiDungThiDua, MucKhenThuongThiDua, macanbo, NamThiDua, NgayKyThiDua);
                DbThidua.updateThidua(kt, MaThiDua);
                ClearThidua();
                DisplayThiDua();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cleartdBtn_Click(object sender, EventArgs e)
        {
            ClearThidua();
        }

        private void dtThidua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit
            {
                ClearThidua();
                int.TryParse(dtThidua.Rows[e.RowIndex].Cells[2].Value.ToString(), out MaThiDua);

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT SoQuyetDinh, Nam, HinhThuc,NgayKy, CoQuanBanHanh, NoiDung, MucKhenThuong FROM ThiDua WHERE MaThiDua = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", MaThiDua); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader
                    if (reader.Read())
                    {
                        SoQuyetDinhThiDua = reader.GetString(0);
                        NamThiDua = reader.GetDateTime(1);
                        HinhThucThiDua = reader.GetString(2);
                        NgayKyThiDua = reader.GetDateTime(3);
                        CoQuanBanHanhThiDua = reader.GetString(4);
                        NoiDungThiDua = reader.GetString(5);
                        MucKhenThuongThiDua = (int)(long)reader.GetInt64(6);
                    }
                }
                soquyetdinhtdIn.Text = SoQuyetDinhThiDua;
                namtdIn.Value = NamThiDua;
                comboBox2.SelectedItem = NamThiDua.Year.ToString();
                ngaykytdIn.Value = NgayKyThiDua;
                hinhthucthiduaIn.Text = HinhThucThiDua;
                coquanbanhanhtdIn.Text = CoQuanBanHanhThiDua;
                noidungtdIn.Text = NoiDungThiDua;
                muckhenthuongtdIn.Text = MucKhenThuongThiDua.ToString();

                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin thi đua này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbThidua.DeleteThidua(dtThidua.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayThiDua();
                }
                return;
            }
        }

        private void dtKyluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit
            {
                ClearKyLuat();
                int.TryParse(dtKyluat.Rows[e.RowIndex].Cells[2].Value.ToString(), out MaKyLuat);

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT HinhThucKyLuat, SoQuyetDinh, Nam, ThoiGianKeoDai, CoQuanBanHanh, NoiDung FROM KyLuat WHERE MaKyLuat = @MaKyLuat";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@MaKyLuat", MaKyLuat); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader
                    if (reader.Read())
                    {

                        HinhThucKyLuat = reader.GetString(0);
                        SoQuyetDinhKyLuat = reader.GetString(1);
                        NamKyLuat = reader.GetDateTime(2);
                        ThoiGianKeoDai = reader.GetInt32(3);
                        CoQuanBanHanhKyLuat = reader.GetString(4);
                        NoiDungKyLuat = reader.GetString(5);

                    }
                }
                hinhthucklIn.SelectedItem = HinhThucKyLuat;
                soquyetdinhklIn.Text = SoQuyetDinhKyLuat;
                ngaykyklIn.Value = NamKyLuat;
                pickyearCBB.SelectedItem = NamKyLuat.Year.ToString();
                thoigiankeodaiklIn.Text = ThoiGianKeoDai.ToString();
                coquanbanhanhklIn.Text = CoQuanBanHanhKyLuat;
                noidungklIn.Text = NoiDungKyLuat;

                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin kỷ luật này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbKyluat.DeleteKyluat(dtKyluat.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayKyLuat();
                }
                return;
            }
        }

        private void dtDanhgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            //edit
            {
                ClearDanhGia();
                int.TryParse(dtDanhgia.Rows[e.RowIndex].Cells[2].Value.ToString(), out MaDanhGia);

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT Nam, LoaiDanhGia, NoiDung FROM DanhGia WHERE MaDanhGia = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", MaDanhGia); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader
                    if (reader.Read())
                    {
                        NamDanhGia = reader.GetDateTime(0);
                        LoaiDanhGia = reader.GetString(1);
                        NoiDungDanhGia = reader.GetString(2);

                    }
                }
                namdanhgiaIn.Value = NamDanhGia;
                comboBox3.SelectedItem = NamDanhGia.Year.ToString();
                loaidanhgiaIn.SelectedItem = LoaiDanhGia;
                noidungdanhgiaIn.Text = NoiDungDanhGia;


                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin đánh giá này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbDanhgia.DeleteDanhgia(dtDanhgia.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayDanhGia();
                }
                return;
            }
        }

        private void themklBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (hinhthucklIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn hình thức kỷ luật!");
                    return;
                }
                HinhThucKyLuat = hinhthucklIn.SelectedItem.ToString();
                NamKyLuat = ngaykyklIn.Value;
                SoQuyetDinhKyLuat = soquyetdinhklIn.Text;
                CoQuanBanHanhKyLuat = coquanbanhanhklIn.Text;
                NoiDungKyLuat = noidungklIn.Text;
                if (!int.TryParse(thoigiankeodaiklIn.Text, out ThoiGianKeoDai))
                {
                    MessageBox.Show("Thời gian kéo dài kỷ luật là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Kyluat kt = new Kyluat(HinhThucKyLuat, SoQuyetDinhKyLuat, CoQuanBanHanhKyLuat, NoiDungKyLuat, macanbo, ThoiGianKeoDai, NamKyLuat);
                DbKyluat.addKyluat(kt);
                ClearKyLuat();
                DisplayKyLuat();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void suaklBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaKyLuat == 0)
                {
                    MessageBox.Show("Vui lòng chọn thông tin kỷ luật muốn sửa!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                HinhThucKyLuat = hinhthucklIn.SelectedItem.ToString();
                NamKyLuat = ngaykyklIn.Value;
                SoQuyetDinhKyLuat = soquyetdinhklIn.Text;
                CoQuanBanHanhKyLuat = coquanbanhanhklIn.Text;
                NoiDungKyLuat = noidungklIn.Text;
                int.TryParse(thoigiankeodaiklIn.Text, out ThoiGianKeoDai);


                Kyluat kt = new Kyluat(HinhThucKyLuat, SoQuyetDinhKyLuat, CoQuanBanHanhKyLuat, NoiDungKyLuat, macanbo, ThoiGianKeoDai, NamKyLuat);
                DbKyluat.updateKyluat(kt, MaKyLuat);
                ClearKyLuat();
                DisplayKyLuat();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void clearklBtn_Click(object sender, EventArgs e)
        {
            ClearKyLuat();
        }

        private void dtDanhgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void klPage_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }



        private void pickyearCBB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = string.Empty;
            if (comboBox1.SelectedItem != null)
            {
                selectedYear = pickyearCBB.SelectedItem.ToString();

                // Tiếp tục xử lý dựa trên giá trị selectedYear
            }
            else
            {
                // Xử lý khi không có mục nào được chọn trong combobox
            }
            int year;
            if (int.TryParse(selectedYear, out year))
            {
                // Chuyển đổi thành công, tiếp tục xử lý dựa trên giá trị 'year'
                ngaykyklIn.Value = new DateTime(year, namIn.Value.Month, namIn.Value.Day);
            }
            else
            {
                // Xử lý khi giá trị không hợp lệ
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = string.Empty;
            if (comboBox1.SelectedItem != null)
            {
                selectedYear = comboBox1.SelectedItem.ToString();
                // Tiếp tục xử lý dựa trên giá trị selectedYear
            }
            else
            {
                // Xử lý khi không có mục nào được chọn trong combobox
            }
            int year;
            if (int.TryParse(selectedYear, out year))
            {
                // Chuyển đổi thành công, tiếp tục xử lý dựa trên giá trị 'year'
                namIn.Value = new DateTime(year, namIn.Value.Month, namIn.Value.Day);
            }
            else
            {
                // Xử lý khi giá trị không hợp lệ
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = string.Empty;
            if (comboBox1.SelectedItem != null)
            {
                selectedYear = comboBox2.SelectedItem.ToString();
                // Tiếp tục xử lý dựa trên giá trị selectedYear
            }
            else
            {
                // Xử lý khi không có mục nào được chọn trong combobox
            }
            int year;
            if (int.TryParse(selectedYear, out year))
            {
                // Chuyển đổi thành công, tiếp tục xử lý dựa trên giá trị 'year'
                namtdIn.Value = new DateTime(year, namIn.Value.Month, namIn.Value.Day);
            }
            else
            {
                // Xử lý khi giá trị không hợp lệ
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = string.Empty;
            if (comboBox1.SelectedItem != null)
            {
                selectedYear = comboBox3.SelectedItem.ToString();
                // Tiếp tục xử lý dựa trên giá trị selectedYear
            }
            else
            {
                // Xử lý khi không có mục nào được chọn trong combobox
            }
            int year;
            if (int.TryParse(selectedYear, out year))
            {
                // Chuyển đổi thành công, tiếp tục xử lý dựa trên giá trị 'year'
                namdanhgiaIn.Value = new DateTime(year, namIn.Value.Month, namIn.Value.Day);
            }
            else
            {
                // Xử lý khi giá trị không hợp lệ
            }
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void dgPage_Click(object sender, EventArgs e)
        {

        }
    }
}
