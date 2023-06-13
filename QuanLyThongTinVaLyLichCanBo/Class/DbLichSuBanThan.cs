using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class.Control
{
    internal class DbLichSuBanThan
    {
        public static void addLichSu(LichSuBanThan lichsu)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO LichSuBanThan(DiTu,BatDauDiTu,KetThucDiTu,LyDoDiTu,LamViecChoCheDoCu, CoQuan,DiaDiem,ChucVu,ThoiGianLamViec,QuanHeVoiToChucNuocNgoai,MucDich,TenToChuc,DiaDiemTruSo,CoNguoiNhaONN,QuanHeNguoiNha,NgheNghiep,NoiO,MaCanBo)" +
                    "VALUES(@ditu,@batdauditu,@ketthucditu,@lydoditu,@lamviecchochedocu,@coquan,@diadiem,@chucvu,@thoigianlamviec,@quanhevoitochucnuocngoai,@mucdich,@tentochuc,@diadiemtruso,@conguoinhaonn,@quanhenguoinha,@nghenghiep,@noio,@macanbo)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ditu", MySqlDbType.VarChar).Value = lichsu.ditu;
                cmd.Parameters.AddWithValue("@batdauditu", MySqlDbType.VarChar).Value = lichsu.batdauditu;
                cmd.Parameters.AddWithValue("@ketthucditu", MySqlDbType.VarChar).Value = lichsu.ketthucditu;
                cmd.Parameters.AddWithValue("@lydoditu", MySqlDbType.VarChar).Value = lichsu.lydoditu;
                cmd.Parameters.AddWithValue("@lamviecchochedocu", MySqlDbType.VarChar).Value = lichsu.lamviecchochedocu;
                cmd.Parameters.AddWithValue("@coquan", MySqlDbType.VarChar).Value = lichsu.coquan;
                cmd.Parameters.AddWithValue("@diadiem", MySqlDbType.VarChar).Value = lichsu.diadiem;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = lichsu.chucvu;
                cmd.Parameters.AddWithValue("@thoigianlamviec", MySqlDbType.VarChar).Value = lichsu.thoigianlamviec;
                cmd.Parameters.AddWithValue("@quanhevoitochucnuocngoai", MySqlDbType.VarChar).Value = lichsu.quanhevoitochucnuocngoai;
                cmd.Parameters.AddWithValue("@mucdich", MySqlDbType.VarChar).Value = lichsu.mucdich;
                cmd.Parameters.AddWithValue("@tentochuc", MySqlDbType.VarChar).Value = lichsu.tentochuc;
                cmd.Parameters.AddWithValue("@diadiemtruso", MySqlDbType.VarChar).Value = lichsu.diadiemtruso;
                cmd.Parameters.AddWithValue("@conguoinhaonn", MySqlDbType.VarChar).Value = lichsu.conguoinhaonn;
                cmd.Parameters.AddWithValue("@quanhenguoinha", MySqlDbType.VarChar).Value = lichsu.quanhenguoinha;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = lichsu.nghenghiep;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = lichsu.noio;
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = lichsu.macanbo;

                try
                {

                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
            }
        }

        public static void updateLichSu(LichSuBanThan lichsu, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE LichSuBanThan SET DiTu = @ditu,BatDauDiTu = @batdauditu,KetThucDiTu = @ketthucditu,LyDoDiTu = @lydoditu,LamViecChoCheDoCu = @lamviecchochedocu, CoQuan = @coquan,DiaDiem = @diadiem,ChucVu = @chucvu,ThoiGianLamViec = @thoigianlamviec" +
                    ",QuanHeVoiToChucNuocNgoai = @quanhevoitochucnuocngoai,MucDich = @mucdich,TenToChuc = @tentochuc," +
                    "DiaDiemTruSo = @diadiemtruso,CoNguoiNhaONN = @conguoinhaonn,QuanHeNguoiNha = @quanhenguoinha," +
                    "NgheNghiep = @nghenghiep,NoiO = @noio WHERE MaLSBT=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ditu", MySqlDbType.VarChar).Value = lichsu.ditu;
                cmd.Parameters.AddWithValue("@batdauditu", MySqlDbType.VarChar).Value = lichsu.batdauditu;
                cmd.Parameters.AddWithValue("@ketthucditu", MySqlDbType.VarChar).Value = lichsu.ketthucditu;
                cmd.Parameters.AddWithValue("@lydoditu", MySqlDbType.VarChar).Value = lichsu.lydoditu;
                cmd.Parameters.AddWithValue("@lamviecchochedocu", MySqlDbType.VarChar).Value = lichsu.lamviecchochedocu;
                cmd.Parameters.AddWithValue("@coquan", MySqlDbType.VarChar).Value = lichsu.coquan;
                cmd.Parameters.AddWithValue("@diadiem", MySqlDbType.VarChar).Value = lichsu.diadiem;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = lichsu.chucvu;
                cmd.Parameters.AddWithValue("@thoigianlamviec", MySqlDbType.VarChar).Value = lichsu.thoigianlamviec;
                cmd.Parameters.AddWithValue("@quanhevoitochucnuocngoai", MySqlDbType.VarChar).Value = lichsu.quanhevoitochucnuocngoai;
                cmd.Parameters.AddWithValue("@mucdich", MySqlDbType.VarChar).Value = lichsu.mucdich;
                cmd.Parameters.AddWithValue("@tentochuc", MySqlDbType.VarChar).Value = lichsu.tentochuc;
                cmd.Parameters.AddWithValue("@diadiemtruso", MySqlDbType.VarChar).Value = lichsu.diadiemtruso;
                cmd.Parameters.AddWithValue("@conguoinhaonn", MySqlDbType.VarChar).Value = lichsu.conguoinhaonn;
                cmd.Parameters.AddWithValue("@quanhenguoinha", MySqlDbType.VarChar).Value = lichsu.quanhenguoinha;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = lichsu.nghenghiep;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = lichsu.noio;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteQuaTrinh(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM QuaTrinhCongTac WHERE MaQTCT = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa quá trình công tác thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchLichSu(int macanbo, DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "SELECT MaQTCT,ThoiGianBatDau,ThoiGianKetThuc,DonVi,ChucVu" +
                " FROM QuaTrinhCongTac WHERE MaCanBo = @macanbo";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = macanbo;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl;
                sqlConnection.Close();
            }
        }
    }
}
