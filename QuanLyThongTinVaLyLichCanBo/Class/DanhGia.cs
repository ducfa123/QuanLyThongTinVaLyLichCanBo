using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class DanhGia
    {
        public string LoaiDanhGia, NoiDung;
        public int MaDanhGia, MaCanBo;
        public DateTime Nam;

        public DanhGia(string loaiDanhGia, string noiDung, int maCanBo, DateTime nam)
        {
            LoaiDanhGia = loaiDanhGia;
            NoiDung = noiDung;
            MaCanBo = maCanBo;
            Nam = nam;
        }
        public DanhGia(string loaiDanhGia, string noiDung, DateTime nam)
        {
            LoaiDanhGia = loaiDanhGia;
            NoiDung = noiDung;
            Nam = nam;
        }
    }
}
