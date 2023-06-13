using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class QuaTrinhLuong
    {
        public int MaLuong, MaCanBo, PhuCapChucVu, PhuCapKhac, BacLuong;
        public string KieuNangLuong, NgachCongChuc, NguoiThucHien;
        public DateTime NgayHuong;
        public float HeSo;

        public QuaTrinhLuong(int maLuong, int maCanBo, int phuCapChucVu, int phuCapKhac, int bacLuong, string kieuNangLuong, string ngachCongChuc, string nguoiThucHien, DateTime ngayHuong, float heSo)
        {
            MaLuong = maLuong;
            MaCanBo = maCanBo;
            PhuCapChucVu = phuCapChucVu;
            PhuCapKhac = phuCapKhac;
            BacLuong = bacLuong;
            KieuNangLuong = kieuNangLuong;
            NgachCongChuc = ngachCongChuc;
            NguoiThucHien = nguoiThucHien;
            NgayHuong = ngayHuong;
            HeSo = heSo;
        }
        public QuaTrinhLuong( int maCanBo, int phuCapChucVu, int phuCapKhac, int bacLuong, string kieuNangLuong, string ngachCongChuc, string nguoiThucHien, DateTime ngayHuong, float heSo)
        {
            MaCanBo = maCanBo;
            PhuCapChucVu = phuCapChucVu;
            PhuCapKhac = phuCapKhac;
            BacLuong = bacLuong;
            KieuNangLuong = kieuNangLuong;
            NgachCongChuc = ngachCongChuc;
            NguoiThucHien = nguoiThucHien;
            NgayHuong = ngayHuong;
            HeSo = heSo;
        }
    }
}
