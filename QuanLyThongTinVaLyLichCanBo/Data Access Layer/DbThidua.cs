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
    internal class ThiduaController
    {
        public static void addThidua(Thidua td)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO ThiDua(MaCanBo,Nam,HinhThuc,NgayKy,SoQuyetDinh,CoQuanBanHanh,NoiDung,MucKhenThuong)" +
                    "VALUES(@MaCanBo,@Nam,@HinhThuc,@NgayKy,@SoQuyetDinh,@CoQuanBanHanh,@NoiDung,@MucKhenThuong)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = td.MaCanBo;
                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = td.Nam;
                cmd.Parameters.AddWithValue("@HinhThuc", MySqlDbType.VarChar).Value = td.HinhThuc;
                cmd.Parameters.AddWithValue("@NgayKy", MySqlDbType.VarChar).Value = td.NgayKy;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = td.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = td.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = td.NoiDung;
                cmd.Parameters.AddWithValue("@MucKhenThuong", MySqlDbType.VarChar).Value = td.MucKhenThuong;

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

        public static void updateThidua(Thidua td, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE ThiDua SET Nam = @Nam,HinhThuc = @HinhThuc,NgayKy = @NgayKy,SoQuyetDinh = @SoQuyetDinh,CoQuanBanHanh = @CoQuanBanHanh, NoiDung= @NoiDung,MucKhenThuong = @MucKhenThuong " +
                    "WHERE MaThiDua=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = td.Nam;
                cmd.Parameters.AddWithValue("@HinhThuc", MySqlDbType.VarChar).Value = td.HinhThuc;
                cmd.Parameters.AddWithValue("@NgayKy", MySqlDbType.VarChar).Value = td.NgayKy;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = td.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = td.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = td.NoiDung;
                cmd.Parameters.AddWithValue("@MucKhenThuong", MySqlDbType.VarChar).Value = td.MucKhenThuong;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin thi đua thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteThidua(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM ThiDua WHERE MaThiDua=@id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thông tin thi đua thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchThidua(string sql, int macanbo, DataGridView dgv)
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
