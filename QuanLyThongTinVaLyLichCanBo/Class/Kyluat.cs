using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class Kyluat
    {
        public string HinhThucKyLuat, SoQuyetDinh, CoQuanBanHanh, NoiDung;
        public int MaKyLuat,MaCanBo, ThoiGianKeoDai;
        public DateTime NgayKy;

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
