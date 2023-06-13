using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using QuanLyThongTinVaLyLichCanBo.Class.Model;

namespace QuanLyThongTinVaLyLichCanBo.Class.Control
{
    internal class DbCanBo
    {

        public static void addCanBo(CanBo cb)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "INSERT INTO ThongTinCanBo(HoTen,NgaySinh,AnhDaiDien,imgpath,DanToc,TonGiao,GioiTinh,HoKhauThuongTru,TenGoiKhac,NoiSinh,QueQuan,NoiOHienNay,NgheNghiep,NgayTuyenDung,CoQuanTuyenDung,ChucVu,NgayThangBoNhiemCV,PhuCapChucVu,PhuCapKhac,NgayVaoDCSVN,NgayChinhThuc,NgayNhapNgu,NgayXuatNgu,QuanHamCaoNhat,DanhHieuCaoNhat,KhenThuong,KyLuat,ChieuCao,CanNang,NhomMau,HangThuongBinh,GiaDinhChinhSach,ChungMinhND,NgayCapCMND,MaBHXH)" + "VALUES(@fullname,@ngaysinh,@anhdaidien,@imgpath,@dantoc,@tongiao,@gioitinh,@hokhau,@othername,@noisinh,@quequan,@noio,@nghenghiep,@ngaytuyendung,@coquan,@chucvu,@ngaybonhiem,@phucapCV,@phucapkhac,@ngayvaodang,@ngaychinhthuc,@ngaynhapngu,@ngayxuatngu,@quanham,@danhhieu,@khenthuong,@kyluat,@chieucao,@cannang,@nhommau,@hangthuongbinh,@giadinhchinhsach,@socmnd,@ngaycapcmnd,@mabhxh)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fullname", MySqlDbType.VarChar).Value = cb.HoTen;
                cmd.Parameters.AddWithValue("@ngaysinh", MySqlDbType.VarChar).Value = cb.NgaySinh;
                cmd.Parameters.AddWithValue("@anhdaidien", MySqlDbType.VarChar).Value = cb.AnhDaiDien;
                cmd.Parameters.AddWithValue("@imgpath", MySqlDbType.VarChar).Value = cb.imgpath;
                cmd.Parameters.AddWithValue("@dantoc", MySqlDbType.VarChar).Value = cb.DanToc;
                cmd.Parameters.AddWithValue("@tongiao", MySqlDbType.VarChar).Value = cb.TonGiao;
                cmd.Parameters.AddWithValue("@gioitinh", MySqlDbType.VarChar).Value = cb.GioiTinh;
                cmd.Parameters.AddWithValue("@hokhau", MySqlDbType.VarChar).Value = cb.HoKhauThuongTru;
                cmd.Parameters.AddWithValue("@othername", MySqlDbType.VarChar).Value = cb.TenGoiKhac;
                cmd.Parameters.AddWithValue("@noisinh", MySqlDbType.VarChar).Value = cb.NoiSinh;
                cmd.Parameters.AddWithValue("@quequan", MySqlDbType.VarChar).Value = cb.QueQuan;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = cb.NoiOHienNay;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = cb.NgheNghiep;
                cmd.Parameters.AddWithValue("@ngaytuyendung", MySqlDbType.VarChar).Value = cb.NgayTuyenDung;
                cmd.Parameters.AddWithValue("@coquan", MySqlDbType.VarChar).Value = cb.CoQuanTuyenDung;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = cb.ChucVu;
                cmd.Parameters.AddWithValue("@ngaybonhiem", MySqlDbType.VarChar).Value = cb.NgayThangBoNhiemCV;
                cmd.Parameters.AddWithValue("@phucapCV", MySqlDbType.VarChar).Value = cb.PhuCapChucVu;
                cmd.Parameters.AddWithValue("@phucapkhac", MySqlDbType.VarChar).Value = cb.PhuCapKhac;
                cmd.Parameters.AddWithValue("@ngayvaodang", MySqlDbType.VarChar).Value = cb.NgayVaoDCSVN;
                cmd.Parameters.AddWithValue("@ngaychinhthuc", MySqlDbType.VarChar).Value = cb.NgayChinhThuc;
                cmd.Parameters.AddWithValue("@ngaynhapngu", MySqlDbType.VarChar).Value = cb.NgayNhapNgu;
                cmd.Parameters.AddWithValue("@ngayxuatngu", MySqlDbType.VarChar).Value = cb.NgayXuatNgu;
                cmd.Parameters.AddWithValue("@quanham", MySqlDbType.VarChar).Value = cb.QuanHamCaoNhat;
                cmd.Parameters.AddWithValue("@danhhieu", MySqlDbType.VarChar).Value = cb.DanhHieuCaoNhat;
                cmd.Parameters.AddWithValue("@khenthuong", MySqlDbType.VarChar).Value = cb.KhenThuong;
                cmd.Parameters.AddWithValue("@kyluat", MySqlDbType.VarChar).Value = cb.KyLuat;
                cmd.Parameters.AddWithValue("@chieucao", MySqlDbType.VarChar).Value = cb.ChieuCao;
                cmd.Parameters.AddWithValue("@cannang", MySqlDbType.VarChar).Value = cb.CanNang;
                cmd.Parameters.AddWithValue("@nhommau", MySqlDbType.VarChar).Value = cb.NhomMau;
                cmd.Parameters.AddWithValue("@hangthuongbinh", MySqlDbType.VarChar).Value = cb.HangThuongBinh;
                cmd.Parameters.AddWithValue("@giadinhchinhsach", MySqlDbType.VarChar).Value = cb.GiaDinhChinhSach;
                cmd.Parameters.AddWithValue("@socmnd", MySqlDbType.VarChar).Value = cb.ChungMinhND;
                cmd.Parameters.AddWithValue("@ngaycapcmnd", MySqlDbType.VarChar).Value = cb.NgayCapCMND;
                cmd.Parameters.AddWithValue("@mabhxh", MySqlDbType.VarChar).Value = cb.MaBHXH;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }
        public static void updateCanBo(CanBo cb, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE ThongTinCanBo SET HoTen = @fullname,NgaySinh = @ngaysinh,AnhDaiDien = @anhdaidien,imgpath = @imgpath,DanToc = @dantoc,TonGiao = @tongiao,GioiTinh = @gioitinh,HoKhauThuongTru = @hokhau,TenGoiKhac = @othername,NoiSinh = @noisinh,QueQuan = @quequan,NoiOHienNay = @noio,NgheNghiep = @nghenghiep,NgayTuyenDung = @ngaytuyendung,CoQuanTuyenDung = @coquan,ChucVu = @chucvu,NgayThangBoNhiemCV = @ngaybonhiem,NgachCongChuc = @ngachcongchuc,TenNgach = @tenngach,BacLuong = @bacluong,HeSo = @heso,PhuCapChucVu = @phucapCV,PhuCapKhac = @phucapkhac,NgayVaoDCSVN = @ngayvaodang,NgayChinhThuc = @ngaychinhthuc,NgayNhapNgu = @ngaynhapngu,NgayXuatNgu = @ngayxuatngu,QuanHamCaoNhat = @quanham,DanhHieuCaoNhat = @danhhieu,KhenThuong = @khenthuong,KyLuat = @kyluat,ChieuCao = @chieucao,CanNang = @cannang,NhomMau = @nhommau,HangThuongBinh = @hangthuongbinh,GiaDinhChinhSach = @giadinhchinhsach,ChungMinhND = @socmnd,NgayCapCMND = @ngaycapcmnd,MaBHXH = @mabhxh WHERE MaCanBo = @canboId";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fullname", MySqlDbType.VarChar).Value = cb.HoTen;
                cmd.Parameters.AddWithValue("@ngaysinh", MySqlDbType.VarChar).Value = cb.NgaySinh;
                cmd.Parameters.AddWithValue("@anhdaidien", MySqlDbType.VarChar).Value = cb.AnhDaiDien; ;
                cmd.Parameters.AddWithValue("@imgpath", MySqlDbType.VarChar).Value = cb.imgpath; ;
                cmd.Parameters.AddWithValue("@dantoc", MySqlDbType.VarChar).Value = cb.DanToc;
                cmd.Parameters.AddWithValue("@tongiao", MySqlDbType.VarChar).Value = cb.TonGiao;
                cmd.Parameters.AddWithValue("@gioitinh", MySqlDbType.VarChar).Value = cb.GioiTinh;
                cmd.Parameters.AddWithValue("@hokhau", MySqlDbType.VarChar).Value = cb.HoKhauThuongTru;
                cmd.Parameters.AddWithValue("@othername", MySqlDbType.VarChar).Value = cb.TenGoiKhac;
                cmd.Parameters.AddWithValue("@noisinh", MySqlDbType.VarChar).Value = cb.NoiSinh;
                cmd.Parameters.AddWithValue("@quequan", MySqlDbType.VarChar).Value = cb.QueQuan;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = cb.NoiOHienNay;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = cb.NgheNghiep;
                cmd.Parameters.AddWithValue("@ngaytuyendung", MySqlDbType.VarChar).Value = cb.NgayTuyenDung;
                cmd.Parameters.AddWithValue("@coquan", MySqlDbType.VarChar).Value = cb.CoQuanTuyenDung;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = cb.ChucVu;
                cmd.Parameters.AddWithValue("@ngaybonhiem", MySqlDbType.VarChar).Value = cb.NgayThangBoNhiemCV;
                cmd.Parameters.AddWithValue("@ngachcongchuc", MySqlDbType.VarChar).Value = cb.ngachcongchuc;
                cmd.Parameters.AddWithValue("@tenngach", MySqlDbType.VarChar).Value = cb.TenNgach;
                cmd.Parameters.AddWithValue("@bacluong", MySqlDbType.VarChar).Value = cb.bacluong;
                cmd.Parameters.AddWithValue("@heso", MySqlDbType.VarChar).Value = cb.heso;
                cmd.Parameters.AddWithValue("@phucapCV", MySqlDbType.VarChar).Value = cb.PhuCapChucVu;
                cmd.Parameters.AddWithValue("@phucapkhac", MySqlDbType.VarChar).Value = cb.PhuCapKhac;
                cmd.Parameters.AddWithValue("@ngayvaodang", MySqlDbType.VarChar).Value = cb.NgayVaoDCSVN;
                cmd.Parameters.AddWithValue("@ngaychinhthuc", MySqlDbType.VarChar).Value = cb.NgayChinhThuc;
                cmd.Parameters.AddWithValue("@ngaynhapngu", MySqlDbType.VarChar).Value = cb.NgayNhapNgu;
                cmd.Parameters.AddWithValue("@ngayxuatngu", MySqlDbType.VarChar).Value = cb.NgayXuatNgu;
                cmd.Parameters.AddWithValue("@quanham", MySqlDbType.VarChar).Value = cb.QuanHamCaoNhat;
                cmd.Parameters.AddWithValue("@danhhieu", MySqlDbType.VarChar).Value = cb.DanhHieuCaoNhat;
                cmd.Parameters.AddWithValue("@khenthuong", MySqlDbType.VarChar).Value = cb.KhenThuong;
                cmd.Parameters.AddWithValue("@kyluat", MySqlDbType.VarChar).Value = cb.KyLuat;
                cmd.Parameters.AddWithValue("@chieucao", MySqlDbType.VarChar).Value = cb.ChieuCao;
                cmd.Parameters.AddWithValue("@cannang", MySqlDbType.VarChar).Value = cb.CanNang;
                cmd.Parameters.AddWithValue("@nhommau", MySqlDbType.VarChar).Value = cb.NhomMau;
                cmd.Parameters.AddWithValue("@hangthuongbinh", MySqlDbType.VarChar).Value = cb.HangThuongBinh;
                cmd.Parameters.AddWithValue("@giadinhchinhsach", MySqlDbType.VarChar).Value = cb.GiaDinhChinhSach;
                cmd.Parameters.AddWithValue("@socmnd", MySqlDbType.VarChar).Value = cb.ChungMinhND;
                cmd.Parameters.AddWithValue("@ngaycapcmnd", MySqlDbType.VarChar).Value = cb.NgayCapCMND;
                cmd.Parameters.AddWithValue("@mabhxh", MySqlDbType.VarChar).Value = cb.MaBHXH;
                cmd.Parameters.AddWithValue("@canboId", MySqlDbType.VarChar).Value = id;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }
       
        public static void DeleteCanBo(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM ThongTinCanBo WHERE MaCanBo = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchCanBo(string query, DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = query;
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                sqlConnection.Close();
            }
        }


    }
}
