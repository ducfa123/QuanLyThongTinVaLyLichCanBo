﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class DanhGia
    {
        public string LoaiDanhGia { get; set; }
        public string  NoiDung { get; set; }
        public int MaDanhGia { get; set; }
        public int MaCanBo { get; set; }
        public DateTime Nam { get; set; }

       
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
