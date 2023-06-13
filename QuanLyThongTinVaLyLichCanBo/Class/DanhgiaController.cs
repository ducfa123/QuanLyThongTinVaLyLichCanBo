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
    internal class DanhgiaController
    {
        public static void addDanhgia(DanhGia dg)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO DanhGia(MaCanBo,Nam,LoaiDanhGia,NoiDung)" +
                    "VALUES(@MaCanBo,@Nam,@LoaiDanhGia,@NoiDung)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = dg.MaCanBo;
                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = dg.Nam;
                cmd.Parameters.AddWithValue("@LoaiDanhGia", MySqlDbType.VarChar).Value = dg.LoaiDanhGia;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = dg.NoiDung;
            
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

        public static void updateDanhgia(DanhGia dg, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE DanhGia SET Nam = @Nam,LoaiDanhGia = @LoaiDanhGia,NoiDung = @NoiDung " +
                    "WHERE MaDanhGia=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nam", MySqlDbType.VarChar).Value = dg.Nam;
                cmd.Parameters.AddWithValue("@LoaiDanhGia", MySqlDbType.VarChar).Value = dg.LoaiDanhGia;
                cmd.Parameters.AddWithValue("@NoiDung", MySqlDbType.VarChar).Value = dg.NoiDung;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin đánh giá thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteDanhgia(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM DanhGia WHERE MaDanhGia=@id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thông tin đánh giá thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchDanhGia(string sql, int macanbo, DataGridView dgv)
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
