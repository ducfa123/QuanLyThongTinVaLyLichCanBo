using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class KhenThuong
    {
        public string HinhThuc, SoQuyetDinh, CoQuanBanHanh, NoiDung;
        public int MaKhenThuong, MucKhenThuong, MaCanBo;
        public DateTime Nam,NgayKy;

        public KhenThuong(string hinhThuc, string soQuyetDinh, string coQuanBanHanh, string noiDung, int mucKhenThuong, int maCanBo, DateTime nam, DateTime ngayKy)
        {
            HinhThuc = hinhThuc;
            SoQuyetDinh = soQuyetDinh;
            CoQuanBanHanh = coQuanBanHanh;
            NoiDung = noiDung;
            MucKhenThuong = mucKhenThuong;
            MaCanBo = maCanBo;
            Nam = nam;
            NgayKy = ngayKy;
        }
        public KhenThuong(string hinhThuc, string soQuyetDinh, string coQuanBanHanh, string noiDung, int mucKhenThuong, DateTime nam, DateTime ngayKy)
        {
            HinhThuc = hinhThuc;
            SoQuyetDinh = soQuyetDinh;
            CoQuanBanHanh = coQuanBanHanh;
            NoiDung = noiDung;
            MucKhenThuong = mucKhenThuong;
            Nam = nam;
            NgayKy = ngayKy;
        }
    }
}
