using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class KhenThuong
    {
        public  string HinhThuc { get; set; }
        public string SoQuyetDinh { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string NoiDung { get; set; }
        public int MaKhenThuong { get; set; }
        public int MucKhenThuong { get; set ; }
        public int MaCanBo { get; set; }
        public DateTime Nam { get; set; }
        public DateTime NgayKy { get; set; }

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
