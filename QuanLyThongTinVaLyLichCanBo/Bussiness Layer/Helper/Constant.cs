using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class Constant
    {
        public static string tenCoQuan = "Cục Công Nghệ Thông Tin";
        public static string tenDonVi = "Phòng Kỹ Thuật";
        public static string[] danhSachHinhThucKhenThuong = {
            "Giấy khen của đơn vị",
            "Giấy khen của Bộ",
            "Bằng khen của UBND tỉnh",
            "Bằng khen của Bộ",
            "Bằng khen của Thủ tướng CP",
            "Huân chương lao động hạng nhất",
            "Huân chương lao động hạng nhì",
            "Huân chương lao động hạng ba" };
        public static string[] danhsachHinhThucThiDua = {  
            "Chiến sĩ tiên tiến", "Chiến sĩ thi đua cấp cơ sở", 
            "Chiến sĩ thi đua cấp tỉnh", 
            "Chiến sĩ thi đua cấp Bộ", 
            "Chiến sĩ thi đua toàn quốc" };

        public static string[] danhSachHinhThucKyLuat = {
            "Khiển trách",
            "Cảnh cáo",
            "Hạ bậc lương",
            "Giáng chức",
            "Buộc thôi việc",
            "Thi hành án + Hạ bậc lương"
        };


        public static string[] danhSachLoaiDanhGia = {
             "Hoàn thành xuất sắc nhiệm vụ",
            "Hoàn thành tốt nhiệm vụ",
            "Hoàn thành nhiệm vụ",
            "Không hoàn thành nhiệm vụ",
            "Hoàn thành nhiệm vụ nhưng còn hạn chế về năng lực",
            "Chưa đủ điều kiện đánh giá"
        };

        public static string filePathExcelTemplate = "C:\\Users\\WINDOWS 10\\Documents\\template.xlsx";
        public static string filePathExcelThiDua = "C:\\Users\\WINDOWS 10\\Documents\\thidua - Copy.xlsx";
        public static string filePathExcelKhenThuong = "C:\\Users\\WINDOWS 10\\Documents\\khenthuong - Copy.xlsx";
        public static string filePathExcelKyLuat = "C:\\Users\\WINDOWS 10\\Documents\\kyluat - Copy.xlsx";
        public static string filePathExcelDanhGia = "C:\\Users\\WINDOWS 10\\Documents\\danhgia - Copy.xlsx";
        public static string filePathPNG = "C:\\Users\\WINDOWS 10\\Documents\\chart.png";
    }
}
