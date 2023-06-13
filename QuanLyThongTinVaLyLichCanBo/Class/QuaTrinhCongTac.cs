using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class QuaTrinhCongTac
    {
        public QuaTrinhCongTac(DateTime thoigianbatdaucongtac, DateTime thoigianketthuccongtac, string donvicongtac, string chucvucongtac, int macanbo)
        {
            this.thoigianbatdaucongtac = thoigianbatdaucongtac;
            this.thoigianketthuccongtac = thoigianketthuccongtac;
            this.donvicongtac = donvicongtac;
            this.chucvucongtac = chucvucongtac;
            this.macanbo = macanbo;
        }

        public DateTime thoigianbatdaucongtac { get; set; } 
        public DateTime thoigianketthuccongtac { get; set; }
        public string donvicongtac { get; set; }    
        public string chucvucongtac { get; set; }  
        
        public int macanbo { get; set; }
    }
}
