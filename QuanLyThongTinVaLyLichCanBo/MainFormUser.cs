using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using QuanLyThongTinVaLyLichCanBo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class MainFormUser : Form
    {
        public int macanbo;
        public bool isThoat = true;
        public ChangePassword npw;

        public MainFormUser()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.contentpanel.Controls.Count > 0)
            {
                this.contentpanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.contentpanel.Controls.Add(f);
                this.contentpanel.Tag = f;
                f.Show();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CanBoInfomation cbi = new CanBoInfomation();
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                string query = "SELECT HoTen,NgaySinh,AnhDaiDien,imgpath,DanToc,TonGiao,GioiTinh,HoKhauThuongTru,TenGoiKhac,NoiSinh,QueQuan,NoiOHienNay,NgheNghiep,NgayTuyenDung,CoQuanTuyenDung,ChucVu,NgayThangBoNhiemCV,NgachCongChuc,TenNgach,BacLuong,HeSo,PhuCapChucVu,PhuCapKhac,NgayVaoDCSVN,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhat,DanhHieuCaoNhat,KhenThuong,KyLuat,ChieuCao,CanNang,NhomMau,HangThuongBinh,GiaDinhChinhSach,ChungMinhND,NgayCapCMND,MaBHXH FROM ThongTinCanBo WHERE MaCanBo = @macanbo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@macanbo", macanbo);
                SqlDataReader reader = cmd.ExecuteReader();
                cbi.id = macanbo;
                if (reader.Read())
                {
                    cbi.fullname = reader.GetString(0);
                    if (reader.IsDBNull(1))
                    {
                        cbi.dtngaysinh = DateTime.Now;
                    }
                    else
                    {
                        cbi.dtngaysinh = reader.GetDateTime(1);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")))
                    {
                        cbi.image = (byte[])reader["AnhDaiDien"];
                    }
                    else
                    {
                        cbi.image = null;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        cbi.imgpath = reader.GetString(3);
                    }
                    else
                    {
                        cbi.imgpath = string.Empty;

                    }
                    if (!reader.IsDBNull(4))
                    {
                        cbi.dantoc = reader.GetString(4);
                    }
                    else
                    {
                        cbi.dantoc = string.Empty;

                    }
                    if (!reader.IsDBNull(5))
                    {
                        cbi.tongiao = reader.GetString(5);
                    }
                    else
                    {
                        cbi.tongiao = string.Empty;

                    }
                    if (!reader.IsDBNull(6))
                    {
                        cbi.gioitinh = reader.GetString(6);
                    }
                    else
                    {
                        cbi.gioitinh = string.Empty;
                    }
                    if (!reader.IsDBNull(7))
                    {
                        cbi.hokhau = reader.GetString(7);
                    }
                    else
                    {
                        cbi.hokhau = string.Empty;
                    }
                    if (!reader.IsDBNull(8))
                    {
                        cbi.othername = reader.GetString(8);
                    }
                    else
                    {
                        cbi.othername = string.Empty;
                    }
                    if (!reader.IsDBNull(9))
                    {
                        cbi.noisinh = reader.GetString(9);
                    }
                    else
                    {
                        cbi.noisinh = string.Empty;
                    }
                    if (!reader.IsDBNull(10))
                    {
                        cbi.quequan = reader.GetString(10);
                    }
                    else
                    {
                        cbi.quequan = string.Empty;
                    }
                    if (!reader.IsDBNull(11))
                    {
                        cbi.noio = reader.GetString(11);
                    }
                    else
                    {
                        cbi.noio = string.Empty;
                    }
                    if (!reader.IsDBNull(12))
                    {
                        cbi.nghenghiep = reader.GetString(12);
                    }
                    else
                    {
                        cbi.nghenghiep = string.Empty;
                    }
                    if (!reader.IsDBNull(14))
                    {
                        cbi.coquan = reader.GetString(14);
                    }
                    else
                    {
                        cbi.coquan = string.Empty;
                    }
                    if (!reader.IsDBNull(15))
                    {
                        cbi.chucvu = reader.GetString(15);
                    }
                    else
                    {
                        cbi.chucvu = string.Empty;
                    }
                    if (!reader.IsDBNull(13))
                    {
                        cbi.dtngaytuyendung = reader.GetDateTime(13);
                    }
                    else
                    {
                        cbi.dtngaytuyendung = DateTime.Now;
                    }
                    if (!reader.IsDBNull(16))
                    {
                        cbi.dtngaybonhiem = reader.GetDateTime(16);
                    }
                    else
                    {
                        cbi.dtngaybonhiem = DateTime.Now;
                    }
                    if (!reader.IsDBNull(17))
                    {
                        cbi.nghachcongchuc = reader.GetString(17);
                    }
                    else
                    {
                        cbi.nghachcongchuc = string.Empty;
                    }
                    if (!reader.IsDBNull(18))
                    {
                        cbi.tenngach = reader.GetString(18);
                    }
                    else
                    {
                        cbi.tenngach = string.Empty;
                    }
                    if (!reader.IsDBNull(19))
                    {
                        cbi.bacluong = reader.GetInt32(19);
                    }
                    else
                    {
                        cbi.bacluong = 0;
                    }
                    if (!reader.IsDBNull(20))
                    {
                        cbi.heso = (float)Math.Round(Convert.ToSingle(reader.GetDouble(20)), 2);
                    }
                    else
                    {
                        cbi.heso = 0;
                    }
                    if (!reader.IsDBNull(21))
                    {
                        cbi.phucapCV = (int)reader.GetInt64(21);
                    }
                    else
                    {
                        cbi.phucapCV = 0;
                    }
                    if (!reader.IsDBNull(22))
                    {
                        cbi.phucapkhac = (int)reader.GetInt64(22);
                    }
                    else
                    {
                        cbi.phucapkhac = 0;
                    }
                    if (!reader.IsDBNull(23))
                    {
                        cbi.dtngayvaodang = reader.GetDateTime(23);
                    }
                    else
                    {
                        cbi.dtngayvaodang = DateTime.Now;
                    }
                    if (!reader.IsDBNull(24))
                    {
                        cbi.dtngaychinhthuc = reader.GetDateTime(24);
                    }
                    else
                    {
                        cbi.dtngaychinhthuc = DateTime.Now;
                    }
                    if (!reader.IsDBNull(25))
                    {
                        cbi.dtngaynhapngu = reader.GetDateTime(25);
                    }
                    else
                    {
                        cbi.dtngaynhapngu = DateTime.Now;
                    }
                    if (!reader.IsDBNull(26))
                    {
                        cbi.dtngayxuatngu = reader.GetDateTime(26);
                    }
                    else
                    {
                        cbi.dtngayxuatngu = DateTime.Now;
                    }
                    if (!reader.IsDBNull(27))
                    {
                        cbi.quanham = reader.GetString(27);
                    }
                    else
                    {
                        cbi.quanham = string.Empty;
                    }
                    if (!reader.IsDBNull(28))
                    {
                        cbi.danhhieu = reader.GetString(28);
                    }
                    else
                    {
                        cbi.danhhieu = string.Empty;
                    }
                    if (!reader.IsDBNull(29))
                    {
                        cbi.khenthuong = reader.GetString(29);
                    }
                    else
                    {
                        cbi.khenthuong = string.Empty;
                    }
                    if (!reader.IsDBNull(30))
                    {
                        cbi.kyluat = reader.GetString(30);
                    }
                    else
                    {
                        cbi.kyluat = string.Empty;
                    }
                    if (!reader.IsDBNull(31))
                    {
                        cbi.chieucao = reader.GetString(31);
                    }
                    else
                    {
                        cbi.chieucao = string.Empty;
                    }
                    if (!reader.IsDBNull(32))
                    {
                        cbi.cannang = reader.GetString(32);
                    }
                    else
                    {
                        cbi.cannang = string.Empty;
                    }
                    if (!reader.IsDBNull(33))
                    {
                        cbi.nhommau = reader.GetString(33);
                    }
                    else
                    {
                        cbi.nhommau = string.Empty;
                    }
                    if (!reader.IsDBNull(34))
                    {
                        cbi.hangthuongbinh = reader.GetString(34);
                    }
                    else
                    {
                        cbi.hangthuongbinh = string.Empty;
                    }
                    if (!reader.IsDBNull(35))
                    {
                        cbi.giadinhchinhsach = reader.GetString(35);
                    }
                    else
                    {
                        cbi.giadinhchinhsach = string.Empty;
                    }
                    if (!reader.IsDBNull(36))
                    {
                        cbi.socmnd = reader.GetString(36);
                    }
                    else
                    {
                        cbi.socmnd = string.Empty;
                    }
                    if (!reader.IsDBNull(37))
                    {
                        cbi.dtngaycapcmnd = reader.GetDateTime(37);
                    }
                    else
                    {
                        cbi.dtngaycapcmnd = DateTime.Now;
                    }
                    if (!reader.IsDBNull(38))
                    {
                        cbi.mabhxh = reader.GetString(38);
                    }
                    else
                    {
                        cbi.mabhxh = string.Empty;
                    }


                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        string queryy = "SELECT MaLSBT,DiTu,BatDauDiTu,KetThucDiTu,LyDoDiTu,LamViecChoCheDoCu,CoQuan,DiaDiem,ChucVu,ThoiGianLamViec,QuanHeVoiToChucNuocNgoai,MucDich,TenToChuc,DiaDiemTruSo,CoNguoiNhaONN,QuanHeNguoiNha,NgheNghiep,NoiO FROM LichSuBanThan WHERE MaCanBo = @id";
                        SqlCommand command = new SqlCommand(queryy, conn);
                        command.Parameters.AddWithValue("@id", macanbo); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                        SqlDataReader readerr = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                        if (reader.Read())
                        {
                            cbi.haslsbt = true;
                            //nếu có lsbt
                            cbi.maLSBT = reader.GetInt32(0);
                            cbi.ditu = reader.GetBoolean(1);
                            cbi.batdauditu = reader.GetDateTime(2);
                            cbi.ketthucditu = reader.GetDateTime(3);
                            cbi.lydoditu = reader.GetString(4);
                            cbi.lamviecchochedocu = reader.GetBoolean(5);
                            cbi.coquanlsbt = reader.GetString(6);
                            cbi.diadiem = reader.GetString(7);
                            cbi.chucvulsbt = reader.GetString(8);
                            cbi.thoigianlamviec = reader.GetInt32(9);
                            cbi.quanhevoitochucnuocngoai = reader.GetBoolean(10);
                            cbi.mucdich = reader.GetString(11);
                            cbi.tentochuc = reader.GetString(12);
                            cbi.diadiemtruso = reader.GetString(13);
                            cbi.conguoinhaonn = reader.GetBoolean(14);
                            cbi.quanhenguoinha = reader.GetString(15);
                            cbi.nghenghieplsbt = reader.GetString(16);
                            cbi.noiolsbt = reader.GetString(17);

                        }
                        else
                        {
                            cbi.haslsbt = false;
                            //nếu không có lsbt
                        }
                    }
                  
                    cbi.Update();
                    cbi.DisplayLichSu();
                    loadForm(cbi);
                }
            }
        }



        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }
        public event EventHandler Logout;

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void sidebarpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
             npw = new ChangePassword(this);
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                string query = "SELECT Username FROM [User] WHERE MaCanBo = @id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@id",macanbo); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                if (reader.Read())
                {
                    npw.username = reader.GetString(0);
                    npw.isAdmin = false;
                }
            }
            
            loadForm(npw);
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFormUser_Load(object sender, EventArgs e)
        {
            CanBoInfomation cbi = new CanBoInfomation();
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                string query = "SELECT HoTen,NgaySinh,AnhDaiDien,imgpath,DanToc,TonGiao,GioiTinh,HoKhauThuongTru,TenGoiKhac,NoiSinh,QueQuan,NoiOHienNay,NgheNghiep,NgayTuyenDung,CoQuanTuyenDung,ChucVu,NgayThangBoNhiemCV,NgachCongChuc,TenNgach,BacLuong,HeSo,PhuCapChucVu,PhuCapKhac,NgayVaoDCSVN,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhat,DanhHieuCaoNhat,KhenThuong,KyLuat,ChieuCao,CanNang,NhomMau,HangThuongBinh,GiaDinhChinhSach,ChungMinhND,NgayCapCMND,MaBHXH FROM ThongTinCanBo WHERE MaCanBo = @macanbo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@macanbo", macanbo);
                SqlDataReader reader = cmd.ExecuteReader();
                cbi.id = macanbo;
                if (reader.Read())
                {
                    cbi.fullname = reader.GetString(0);
                    if (reader.IsDBNull(1))
                    {
                        cbi.dtngaysinh = DateTime.Now;
                    }
                    else
                    {
                        cbi.dtngaysinh = reader.GetDateTime(1);
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("AnhDaiDien")))
                    {
                        cbi.image = (byte[])reader["AnhDaiDien"];
                    }
                    else
                    {
                        cbi.image = null;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        cbi.imgpath = reader.GetString(3);
                    }
                    else
                    {
                        cbi.imgpath = string.Empty;

                    }
                    if (!reader.IsDBNull(4))
                    {
                        cbi.dantoc = reader.GetString(4);
                    }
                    else
                    {
                        cbi.dantoc = string.Empty;

                    }
                    if (!reader.IsDBNull(5))
                    {
                        cbi.tongiao = reader.GetString(5);
                    }
                    else
                    {
                        cbi.tongiao = string.Empty;

                    }
                    if (!reader.IsDBNull(6))
                    {
                        cbi.gioitinh = reader.GetString(6);
                    }
                    else
                    {
                        cbi.gioitinh = string.Empty;
                    }
                    if (!reader.IsDBNull(7))
                    {
                        cbi.hokhau = reader.GetString(7);
                    }
                    else
                    {
                        cbi.hokhau = string.Empty;
                    }
                    if (!reader.IsDBNull(8))
                    {
                        cbi.othername = reader.GetString(8);
                    }
                    else
                    {
                        cbi.othername = string.Empty;
                    }
                    if (!reader.IsDBNull(9))
                    {
                        cbi.noisinh = reader.GetString(9);
                    }
                    else
                    {
                        cbi.noisinh = string.Empty;
                    }
                    if (!reader.IsDBNull(10))
                    {
                        cbi.quequan = reader.GetString(10);
                    }
                    else
                    {
                        cbi.quequan = string.Empty;
                    }
                    if (!reader.IsDBNull(11))
                    {
                        cbi.noio = reader.GetString(11);
                    }
                    else
                    {
                        cbi.noio = string.Empty;
                    }
                    if (!reader.IsDBNull(12))
                    {
                        cbi.nghenghiep = reader.GetString(12);
                    }
                    else
                    {
                        cbi.nghenghiep = string.Empty;
                    }
                    if (!reader.IsDBNull(14))
                    {
                        cbi.coquan = reader.GetString(14);
                    }
                    else
                    {
                        cbi.coquan = string.Empty;
                    }
                    if (!reader.IsDBNull(15))
                    {
                        cbi.chucvu = reader.GetString(15);
                    }
                    else
                    {
                        cbi.chucvu = string.Empty;
                    }
                    if (!reader.IsDBNull(13))
                    {
                        cbi.dtngaytuyendung = reader.GetDateTime(13);
                    }
                    else
                    {
                        cbi.dtngaytuyendung = DateTime.Now;
                    }
                    if (!reader.IsDBNull(16))
                    {
                        cbi.dtngaybonhiem = reader.GetDateTime(16);
                    }
                    else
                    {
                        cbi.dtngaybonhiem = DateTime.Now;
                    }
                    if (!reader.IsDBNull(17))
                    {
                        cbi.nghachcongchuc = reader.GetString(17);
                    }
                    else
                    {
                        cbi.nghachcongchuc = string.Empty;
                    }
                    if (!reader.IsDBNull(18))
                    {
                        cbi.tenngach = reader.GetString(18);
                    }
                    else
                    {
                        cbi.tenngach = string.Empty;
                    }
                    if (!reader.IsDBNull(19))
                    {
                        cbi.bacluong = reader.GetInt32(19);
                    }
                    else
                    {
                        cbi.bacluong = 0;
                    }
                    if (!reader.IsDBNull(20))
                    {
                        cbi.heso = (float)Math.Round(Convert.ToSingle(reader.GetDouble(20)), 2);
                    }
                    else
                    {
                        cbi.heso = 0;
                    }
                    if (!reader.IsDBNull(21))
                    {
                        cbi.phucapCV = (int)reader.GetInt64(21);
                    }
                    else
                    {
                        cbi.phucapCV = 0;
                    }
                    if (!reader.IsDBNull(22))
                    {
                        cbi.phucapkhac = (int)reader.GetInt64(22);
                    }
                    else
                    {
                        cbi.phucapkhac = 0;
                    }
                    if (!reader.IsDBNull(23))
                    {
                        cbi.dtngayvaodang = reader.GetDateTime(23);
                    }
                    else
                    {
                        cbi.dtngayvaodang = DateTime.Now;
                    }
                    if (!reader.IsDBNull(24))
                    {
                        cbi.dtngaychinhthuc = reader.GetDateTime(24);
                    }
                    else
                    {
                        cbi.dtngaychinhthuc = DateTime.Now;
                    }
                    if (!reader.IsDBNull(25))
                    {
                        cbi.dtngaynhapngu = reader.GetDateTime(25);
                    }
                    else
                    {
                        cbi.dtngaynhapngu = DateTime.Now;
                    }
                    if (!reader.IsDBNull(26))
                    {
                        cbi.dtngayxuatngu = reader.GetDateTime(26);
                    }
                    else
                    {
                        cbi.dtngayxuatngu = DateTime.Now;
                    }
                    if (!reader.IsDBNull(27))
                    {
                        cbi.quanham = reader.GetString(27);
                    }
                    else
                    {
                        cbi.quanham = string.Empty;
                    }
                    if (!reader.IsDBNull(28))
                    {
                        cbi.danhhieu = reader.GetString(28);
                    }
                    else
                    {
                        cbi.danhhieu = string.Empty;
                    }
                    if (!reader.IsDBNull(29))
                    {
                        cbi.khenthuong = reader.GetString(29);
                    }
                    else
                    {
                        cbi.khenthuong = string.Empty;
                    }
                    if (!reader.IsDBNull(30))
                    {
                        cbi.kyluat = reader.GetString(30);
                    }
                    else
                    {
                        cbi.kyluat = string.Empty;
                    }
                    if (!reader.IsDBNull(31))
                    {
                        cbi.chieucao = reader.GetString(31);
                    }
                    else
                    {
                        cbi.chieucao = string.Empty;
                    }
                    if (!reader.IsDBNull(32))
                    {
                        cbi.cannang = reader.GetString(32);
                    }
                    else
                    {
                        cbi.cannang = string.Empty;
                    }
                    if (!reader.IsDBNull(33))
                    {
                        cbi.nhommau = reader.GetString(33);
                    }
                    else
                    {
                        cbi.nhommau = string.Empty;
                    }
                    if (!reader.IsDBNull(34))
                    {
                        cbi.hangthuongbinh = reader.GetString(34);
                    }
                    else
                    {
                        cbi.hangthuongbinh = string.Empty;
                    }
                    if (!reader.IsDBNull(35))
                    {
                        cbi.giadinhchinhsach = reader.GetString(35);
                    }
                    else
                    {
                        cbi.giadinhchinhsach = string.Empty;
                    }
                    if (!reader.IsDBNull(36))
                    {
                        cbi.socmnd = reader.GetString(36);
                    }
                    else
                    {
                        cbi.socmnd = string.Empty;
                    }
                    if (!reader.IsDBNull(37))
                    {
                        cbi.dtngaycapcmnd = reader.GetDateTime(37);
                    }
                    else
                    {
                        cbi.dtngaycapcmnd = DateTime.Now;
                    }
                    if (!reader.IsDBNull(38))
                    {
                        cbi.mabhxh = reader.GetString(38);
                    }
                    else
                    {
                        cbi.mabhxh = string.Empty;
                    }


                    using (SqlConnection conn = Connection.GetSqlConnection())
                    {
                        conn.Open();

                        string queryy = "SELECT MaLSBT,DiTu,BatDauDiTu,KetThucDiTu,LyDoDiTu,LamViecChoCheDoCu,CoQuan,DiaDiem,ChucVu,ThoiGianLamViec,QuanHeVoiToChucNuocNgoai,MucDich,TenToChuc,DiaDiemTruSo,CoNguoiNhaONN,QuanHeNguoiNha,NgheNghiep,NoiO FROM LichSuBanThan WHERE MaCanBo = @id";
                        SqlCommand command = new SqlCommand(queryy, conn);
                        command.Parameters.AddWithValue("@id", macanbo); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                        SqlDataReader readerr = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                        if (reader.Read())
                        {
                            cbi.haslsbt = true;
                            //nếu có lsbt
                            cbi.maLSBT = reader.GetInt32(0);
                            cbi.ditu = reader.GetBoolean(1);
                            cbi.batdauditu = reader.GetDateTime(2);
                            cbi.ketthucditu = reader.GetDateTime(3);
                            cbi.lydoditu = reader.GetString(4);
                            cbi.lamviecchochedocu = reader.GetBoolean(5);
                            cbi.coquanlsbt = reader.GetString(6);
                            cbi.diadiem = reader.GetString(7);
                            cbi.chucvulsbt = reader.GetString(8);
                            cbi.thoigianlamviec = reader.GetInt32(9);
                            cbi.quanhevoitochucnuocngoai = reader.GetBoolean(10);
                            cbi.mucdich = reader.GetString(11);
                            cbi.tentochuc = reader.GetString(12);
                            cbi.diadiemtruso = reader.GetString(13);
                            cbi.conguoinhaonn = reader.GetBoolean(14);
                            cbi.quanhenguoinha = reader.GetString(15);
                            cbi.nghenghieplsbt = reader.GetString(16);
                            cbi.noiolsbt = reader.GetString(17);

                        }
                        else
                        {
                            cbi.haslsbt = false;
                            //nếu không có lsbt
                        }
                    }

                    cbi.Update();
                    cbi.DisplayLichSu();
                    loadForm(cbi);
                }
            }
        }
    }
}
