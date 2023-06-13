using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class QuanHeGiaDinh
    {
        public int macanbo,maquanhe;
        public string moiquanhe, hovaten, quequan, nghenghiep, donvicongtac, noio;
        public DateTime namsinh;

        
        public QuanHeGiaDinh(int macanbo, string moiquanhe, string hovaten, string quequan, string nghenghiep, string donvicongtac, string noio, DateTime namsinh)
        {
            this.macanbo = macanbo;
            this.moiquanhe = moiquanhe;
            this.hovaten = hovaten;
            this.quequan = quequan;
            this.nghenghiep = nghenghiep;
            this.donvicongtac = donvicongtac;
            this.noio = noio;
            this.namsinh = namsinh;
        }
    }
}
