using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class.Model
{
    internal class CanBo
    {
        public CanBo(string hoTen, DateTime ngaySinh, byte[] anhDaiDien, string imgPath, string danToc, string tonGiao, string gioiTinh, string hoKhauThuongTru, string tenGoiKhac, string noiSinh, string queQuan, string noiOHienNay, string ngheNghiep, DateTime ngayTuyenDung, string coQuanTuyenDung, string chucVu, DateTime ngayThangBoNhiemCV, string nghachCongChuc,string tenngach, int bacLuong, float heSo, int phuCapChucVu, int phuCapKhac, DateTime ngayVaoDCSVN, DateTime ngayChinhThuc, DateTime ngayNhapNgu, DateTime ngayXuatNgu, DateTime ngayCapCMND, string quanHamCaoNhat, string danhHieuCaoNhat, string khenThuong, string kyLuat, string chieuCao, string canNang, string nhomMau, string hangThuongBinh, string giaDinhChinhSach, string chungMinhND, string maBHXH)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            AnhDaiDien = anhDaiDien;
            imgpath = imgPath;
            DanToc = danToc;
            TonGiao = tonGiao;
            GioiTinh = gioiTinh;
            HoKhauThuongTru = hoKhauThuongTru;
            TenGoiKhac = tenGoiKhac;
            NoiSinh = noiSinh;
            QueQuan = queQuan;
            NoiOHienNay = noiOHienNay;
            NgheNghiep = ngheNghiep;
            NgayTuyenDung = ngayTuyenDung;
            CoQuanTuyenDung = coQuanTuyenDung;
            ChucVu = chucVu;
            NgayThangBoNhiemCV = ngayThangBoNhiemCV;
            ngachcongchuc = nghachCongChuc;
            TenNgach = tenngach;
            bacluong = bacLuong;
            heso = heSo;
            PhuCapChucVu = phuCapChucVu;
            PhuCapKhac = phuCapKhac;
            NgayVaoDCSVN = ngayVaoDCSVN;
            NgayChinhThuc = ngayChinhThuc;
            NgayNhapNgu = ngayNhapNgu;
            NgayXuatNgu = ngayXuatNgu;
            NgayCapCMND = ngayCapCMND;
            QuanHamCaoNhat = quanHamCaoNhat;
            DanhHieuCaoNhat = danhHieuCaoNhat;
            KhenThuong = khenThuong;
            KyLuat = kyLuat;
            ChieuCao = chieuCao;
            CanNang = canNang;
            NhomMau = nhomMau;
            HangThuongBinh = hangThuongBinh;
            GiaDinhChinhSach = giaDinhChinhSach;
            ChungMinhND = chungMinhND;
            MaBHXH = maBHXH;
        }
        public CanBo(string hoTen, DateTime ngaySinh, byte[] anhDaiDien, string imgPath, string danToc, string tonGiao, string gioiTinh, string hoKhauThuongTru, string tenGoiKhac, string noiSinh, string queQuan, string noiOHienNay, string ngheNghiep, DateTime ngayTuyenDung, string coQuanTuyenDung, string chucVu, DateTime ngayThangBoNhiemCV, int phuCapChucVu, int phuCapKhac, DateTime ngayVaoDCSVN, DateTime ngayChinhThuc, DateTime ngayNhapNgu, DateTime ngayXuatNgu, DateTime ngayCapCMND, string quanHamCaoNhat, string danhHieuCaoNhat, string khenThuong, string kyLuat, string chieuCao, string canNang, string nhomMau, string hangThuongBinh, string giaDinhChinhSach, string chungMinhND, string maBHXH, string userName)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            AnhDaiDien = anhDaiDien;
            imgpath = imgPath;
            DanToc = danToc;
            TonGiao = tonGiao;
            GioiTinh = gioiTinh;
            HoKhauThuongTru = hoKhauThuongTru;
            TenGoiKhac = tenGoiKhac;
            NoiSinh = noiSinh;
            QueQuan = queQuan;
            NoiOHienNay = noiOHienNay;
            NgheNghiep = ngheNghiep;
            NgayTuyenDung = ngayTuyenDung;
            CoQuanTuyenDung = coQuanTuyenDung;
            ChucVu = chucVu;
            NgayThangBoNhiemCV = ngayThangBoNhiemCV;
            PhuCapChucVu = phuCapChucVu;
            PhuCapKhac = phuCapKhac;
            NgayVaoDCSVN = ngayVaoDCSVN;
            NgayChinhThuc = ngayChinhThuc;
            NgayNhapNgu = ngayNhapNgu;
            NgayXuatNgu = ngayXuatNgu;
            NgayCapCMND = ngayCapCMND;
            QuanHamCaoNhat = quanHamCaoNhat;
            DanhHieuCaoNhat = danhHieuCaoNhat;
            KhenThuong = khenThuong;
            KyLuat = kyLuat;
            ChieuCao = chieuCao;
            CanNang = canNang;
            NhomMau = nhomMau;
            HangThuongBinh = hangThuongBinh;
            GiaDinhChinhSach = giaDinhChinhSach;
            ChungMinhND = chungMinhND;
            MaBHXH = maBHXH;
            username = userName;
        }

        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte[] AnhDaiDien { get; set; }

        public string username { get; set; }
        public string imgpath { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string GioiTinh { get; set; }

        public string HoKhauThuongTru { get; set; }
        public string TenGoiKhac { get; set; }
        public string NoiSinh { get; set; }

        public string QueQuan { get; set; }
        public string NoiOHienNay { get; set; }
        public string NgheNghiep { get; set; }
        public DateTime NgayTuyenDung { get; set; }
        public string CoQuanTuyenDung { get; set; }
        public string ChucVu { get; set; }

        public DateTime NgayThangBoNhiemCV { get; set; }
        public string ngachcongchuc { get; set; }
        public string TenNgach { get; set; }
        public int bacluong { get; set; }
        public float heso { get; set; }
        public int PhuCapChucVu { get; set; }
        public int PhuCapKhac { get; set; }
        public DateTime NgayVaoDCSVN { get; set; }
        public DateTime NgayChinhThuc { get; set; }
        public DateTime NgayNhapNgu { get; set; }
        public DateTime NgayXuatNgu { get; set; }
        public DateTime NgayCapCMND { get; set; }
        public string QuanHamCaoNhat { get; set; }
        public string DanhHieuCaoNhat { get; set; }
        public string KhenThuong { get; set; }
        public string KyLuat { get; set; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string NhomMau { get; set; }
        public string HangThuongBinh { get; set; }
        public string GiaDinhChinhSach { get; set; }
        public string ChungMinhND { get; set; }
        public string MaBHXH { get; set; }

    }
}
