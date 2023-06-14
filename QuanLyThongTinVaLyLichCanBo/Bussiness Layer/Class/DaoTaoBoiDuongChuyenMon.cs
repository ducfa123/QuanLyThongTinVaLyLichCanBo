using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class DaoTaoBoiDuongChuyenMon
    {

        public DaoTaoBoiDuongChuyenMon(string tenTruong, string chuyenNghanhDaoTao, string hinhThucDaoTao, string vanBang, DateTime thoiGianBatDauDaoTao, DateTime thoiGianKetThucDaoTao, int maCanBo)
        {
            TenTruong = tenTruong;
            ChuyenNghanhDaoTao = chuyenNghanhDaoTao;
            HinhThucDaoTao = hinhThucDaoTao;
            VanBang = vanBang;
            ThoiGianBatDauDaoTao = thoiGianBatDauDaoTao;
            ThoiGianKetThucDaoTao = thoiGianKetThucDaoTao;
            MaCanBo = maCanBo;
        }

        public string TenTruong { get; set; }
        public string ChuyenNghanhDaoTao { get; set; }
        public string HinhThucDaoTao { get; set; }
        public string VanBang { get; set; }
        public DateTime ThoiGianBatDauDaoTao { get; set; }
        public DateTime ThoiGianKetThucDaoTao { get; set; }

        public int MaCanBo { get; set; }    



    }
}
