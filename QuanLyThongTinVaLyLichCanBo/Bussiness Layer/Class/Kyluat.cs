using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class Kyluat
    {
        public string HinhThucKyLuat { get; set; }
        public string SoQuyetDinh { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string NoiDung { get; set; }
        public int MaKyLuat { get; set; }
        public int MaCanBo { get; set; }
        public int ThoiGianKeoDai { get; set; }
        public DateTime NgayKy { get; set; }

        public Kyluat(string hinhThucKyLuat, string soQuyetDinh, string coQuanBanHanh, string noiDung, int maCanBo, int thoiGianKeoDai, DateTime ngayKy)
        {
            HinhThucKyLuat = hinhThucKyLuat;
            SoQuyetDinh = soQuyetDinh;
            CoQuanBanHanh = coQuanBanHanh;
            NoiDung = noiDung;
            MaCanBo = maCanBo;
            ThoiGianKeoDai = thoiGianKeoDai;
            NgayKy = ngayKy;
        }
        public Kyluat(string hinhThucKyLuat, string soQuyetDinh, string coQuanBanHanh, string noiDung, int thoiGianKeoDai, DateTime ngayKy)
        {
            HinhThucKyLuat = hinhThucKyLuat;
            SoQuyetDinh = soQuyetDinh;
            CoQuanBanHanh = coQuanBanHanh;
            NoiDung = noiDung;
            ThoiGianKeoDai = thoiGianKeoDai;
            NgayKy = ngayKy;
        }
    }
}
