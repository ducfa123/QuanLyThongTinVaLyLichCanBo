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
    internal class DbQuaTrinhCongTac
    {
        public static void addQuaTrinh(QuaTrinhCongTac quatrinh)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO QuaTrinhCongTac(ThoiGianBatDau,ThoiGianKetThuc,DonVi,ChucVu,MaCanBo)" +
                    "VALUES(@thoigianbatdau,@thoigianketthuc,@donvi,@chucvu,@macanbo)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@thoigianbatdau", MySqlDbType.VarChar).Value = quatrinh.thoigianbatdaucongtac;
                cmd.Parameters.AddWithValue("@thoigianketthuc", MySqlDbType.VarChar).Value = quatrinh.thoigianketthuccongtac;
                cmd.Parameters.AddWithValue("@donvi", MySqlDbType.VarChar).Value = quatrinh.donvicongtac;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = quatrinh.chucvucongtac;
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = quatrinh.macanbo;
            
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

        public static void updateQuaTrinh(QuaTrinhCongTac quatrinh, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE QuaTrinhCongTac SET ThoiGianBatDau = @thoigianbatdau,ThoiGianKetThuc = @thoigianketthuc,DonVi = @donvi " +
                    ",ChucVu = @chucvu WHERE MaQTCT=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@thoigianbatdau", MySqlDbType.VarChar).Value = quatrinh.thoigianbatdaucongtac;
                cmd.Parameters.AddWithValue("@thoigianketthuc", MySqlDbType.VarChar).Value = quatrinh.thoigianketthuccongtac;
                cmd.Parameters.AddWithValue("@donvi", MySqlDbType.VarChar).Value = quatrinh.donvicongtac;
                cmd.Parameters.AddWithValue("@chucvu", MySqlDbType.VarChar).Value = quatrinh.chucvucongtac;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin quá trình công tác thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static void DisplayAndSearchQuaTrinh(int macanbo, DataGridView dgv)
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
