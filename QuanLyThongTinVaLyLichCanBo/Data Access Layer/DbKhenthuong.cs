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
    internal class DbKhenthuong
    {
        public static void addKhenThuong(KhenThuong kt)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO KhenThuong(MaCanBo,Nam,HinhThuc,NgayKy,SoQuyetDinh,CoQuanBanHanh,NoiDung,MucKhenThuong)" +
                    "VALUES(@MaCanBo,@Nam,@HinhThuc,@NgayKy,@SoQuyetDinh,@CoQuanBanHanh,@NoiDung,@MucKhenThuong)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = kt.MaCanBo;
                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = kt.Nam;
                cmd.Parameters.AddWithValue("@HinhThuc", MySqlDbType.VarChar).Value = kt.HinhThuc;
                cmd.Parameters.AddWithValue("@NgayKy", MySqlDbType.VarChar).Value = kt.NgayKy;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = kt.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = kt.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = kt.NoiDung;
                cmd.Parameters.AddWithValue("@MucKhenThuong", MySqlDbType.VarChar).Value = kt.MucKhenThuong;

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

        public static void updateKhenThuong(KhenThuong kt, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE KhenThuong SET Nam = @Nam,HinhThuc = @HinhThuc,NgayKy = @NgayKy,SoQuyetDinh = @SoQuyetDinh,CoQuanBanHanh = @CoQuanBanHanh, NoiDung= @NoiDung,MucKhenThuong = @MucKhenThuong " +
                    "WHERE MaKhenThuong=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = kt.Nam;
                cmd.Parameters.AddWithValue("@HinhThuc", MySqlDbType.VarChar).Value = kt.HinhThuc;
                cmd.Parameters.AddWithValue("@NgayKy", MySqlDbType.VarChar).Value = kt.NgayKy;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = kt.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = kt.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = kt.NoiDung;
                cmd.Parameters.AddWithValue("@MucKhenThuong", MySqlDbType.VarChar).Value = kt.MucKhenThuong;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin khen thưởng thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteKhenThuong(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM KhenThuong WHERE MaKhenThuong=@id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thông tin khen thưởng thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchKhenThuong( string sql, int macanbo, DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                //string sql = "select madanhgia,nam,loaidanhgia,noidung" +
                //" from thidua where macanbo = @macanbo";
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
