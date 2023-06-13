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
    internal class KyluatController
    {
        public static void addKyluat(Kyluat kl)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO KyLuat(MaCanBo,HinhThucKyLuat,SoQuyetDinh,Nam,ThoiGianKeoDai,CoQuanBanHanh,NoiDung)" +
                    "VALUES(@MaCanBo,@HinhThucKyLuat,@SoQuyetDinh,@Nam,@ThoiGianKeoDai,@CoQuanBanHanh,@NoiDung)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = kl.MaCanBo;
                cmd.Parameters.AddWithValue("@HinhThucKyLuat", MySqlDbType.VarChar).Value = kl.HinhThucKyLuat;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = kl.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = kl.NgayKy;
                cmd.Parameters.AddWithValue("@ThoiGianKeoDai", MySqlDbType.VarChar).Value = kl.ThoiGianKeoDai;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = kl.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = kl.NoiDung;

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

        public static void updateKyluat(Kyluat kl, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE KyLuat SET HinhThucKyLuat = @HinhThucKyLuat,SoQuyetDinh = @SoQuyetDinh,Nam = @Nam,ThoiGianKeoDai = @ThoiGianKeoDai,CoQuanBanHanh = @CoQuanBanHanh, NoiDung= @NoiDung " +
                    "WHERE MaKyLuat=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@HinhThucKyLuat", MySqlDbType.VarChar).Value = kl.HinhThucKyLuat;
                cmd.Parameters.AddWithValue("@SoQuyetDinh", MySqlDbType.VarChar).Value = kl.SoQuyetDinh;
                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = kl.NgayKy;
                cmd.Parameters.AddWithValue("@ThoiGianKeoDai", MySqlDbType.VarChar).Value = kl.ThoiGianKeoDai;
                cmd.Parameters.AddWithValue("@CoQuanBanHanh", MySqlDbType.VarChar).Value = kl.CoQuanBanHanh;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = kl.NoiDung;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin kỷ luật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteKyluat(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM KyLuat WHERE MaKyLuat=@id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thông tin kỷ luật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchKyluat(string sql, int macanbo, DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                
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
