using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class LichSuBanThan
    {
        public string lydoditu, coquan, diadiem, chucvu, mucdich, tentochuc, diadiemtruso, quanhenguoinha, nghenghiep, noio;
        public DateTime batdauditu, ketthucditu;
        public bool ditu, lamviecchochedocu, quanhevoitochucnuocngoai, conguoinhaonn;
        public int thoigianlamviec,macanbo, maLSBT;

        public LichSuBanThan(string lydoditu, string coquan, string diadiem, string chucvu, int thoigianlamviec, string mucdich, string tentochuc, string diadiemtruso, string quanhenguoinha, string nghenghiep, string noio, DateTime batdauditu, DateTime ketthucditu, bool ditu, bool lamviecchochedocu, bool quanhevoitochucnuocngoai, bool conguoinhaonn, int macanbo, int maLSBT)
        {
            this.lydoditu = lydoditu;
            this.coquan = coquan;
            this.diadiem = diadiem;
            this.chucvu = chucvu;
            this.thoigianlamviec = thoigianlamviec;
            this.mucdich = mucdich;
            this.tentochuc = tentochuc;
            this.diadiemtruso = diadiemtruso;
            this.quanhenguoinha = quanhenguoinha;
            this.nghenghiep = nghenghiep;
            this.noio = noio;
            this.batdauditu = batdauditu;
            this.ketthucditu = ketthucditu;
            this.ditu = ditu;
            this.lamviecchochedocu = lamviecchochedocu;
            this.quanhevoitochucnuocngoai = quanhevoitochucnuocngoai;
            this.conguoinhaonn = conguoinhaonn;
            this.macanbo = macanbo;
            this.maLSBT = maLSBT;
        } 
        public LichSuBanThan(string lydoditu, string coquan, string diadiem, string chucvu, int thoigianlamviec, string mucdich, string tentochuc, string diadiemtruso, string quanhenguoinha, string nghenghiep, string noio, DateTime batdauditu, DateTime ketthucditu, bool ditu, bool lamviecchochedocu, bool quanhevoitochucnuocngoai, bool conguoinhaonn, int macanbo)
        {
            this.lydoditu = lydoditu;
            this.coquan = coquan;
            this.diadiem = diadiem;
            this.chucvu = chucvu;
            this.thoigianlamviec = thoigianlamviec;
            this.mucdich = mucdich;
            this.tentochuc = tentochuc;
            this.diadiemtruso = diadiemtruso;
            this.quanhenguoinha = quanhenguoinha;
            this.nghenghiep = nghenghiep;
            this.noio = noio;
            this.batdauditu = batdauditu;
            this.ketthucditu = ketthucditu;
            this.ditu = ditu;
            this.lamviecchochedocu = lamviecchochedocu;
            this.quanhevoitochucnuocngoai = quanhevoitochucnuocngoai;
            this.conguoinhaonn = conguoinhaonn;
            this.macanbo = macanbo;
        }
    }
}
