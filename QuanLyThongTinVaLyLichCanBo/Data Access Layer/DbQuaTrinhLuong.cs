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
    internal class DbQuaTrinhLuong
    {
        public static void addQuaTrinh(QuaTrinhLuong quatrinh)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO QuaTrinhLuong(KieuNangLuong,NgayHuong,NgachCongChuc,HeSo,BacLuong,PhuCapChucVu,PhuCapKhac,MaCanBo,NguoiThucHien) " +
                    "VALUES(@KieuNangLuong,@NgayHuong,@NgachCongChuc,@HeSo,@BacLuong,@PhuCapChucVu,@PhuCapKhac,@MaCanBo,@NguoiThucHien)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@KieuNangLuong", MySqlDbType.VarChar).Value = quatrinh.KieuNangLuong;
                cmd.Parameters.AddWithValue("@NgayHuong", MySqlDbType.VarChar).Value = quatrinh.NgayHuong;
                cmd.Parameters.AddWithValue("@NgachCongChuc", MySqlDbType.VarChar).Value = quatrinh.NgachCongChuc;
                cmd.Parameters.AddWithValue("@HeSo", MySqlDbType.VarChar).Value = quatrinh.HeSo;
                cmd.Parameters.AddWithValue("@BacLuong", MySqlDbType.VarChar).Value = quatrinh.BacLuong;
                cmd.Parameters.AddWithValue("@PhuCapChucVu", MySqlDbType.VarChar).Value = quatrinh.PhuCapChucVu;
                cmd.Parameters.AddWithValue("@PhuCapKhac", MySqlDbType.VarChar).Value = quatrinh.PhuCapKhac;
                cmd.Parameters.AddWithValue("@NguoiThucHien", MySqlDbType.VarChar).Value = quatrinh.NguoiThucHien ;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = quatrinh.MaCanBo;

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

        public static void updateQuaTrinh(QuaTrinhLuong quatrinh, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE QuaTrinhLuong SET KieuNangLuong = @KieuNangLuong,NgayHuong = @NgayHuong ,NgachCongChuc = @NgachCongChuc ," +
                    "HeSo = @HeSo,BacLuong = @BacLuong,PhuCapChucVu = @PhuCapChucVu,PhuCapKhac = @PhuCapKhac,MaCanBo =  @MaCanBo WHERE MaLuong = @MaLuong";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@KieuNangLuong", MySqlDbType.VarChar).Value = quatrinh.KieuNangLuong;
                cmd.Parameters.AddWithValue("@NgayHuong", MySqlDbType.VarChar).Value = quatrinh.NgayHuong;
                cmd.Parameters.AddWithValue("@NgachCongChuc", MySqlDbType.VarChar).Value = quatrinh.NgachCongChuc;
                cmd.Parameters.AddWithValue("@HeSo", MySqlDbType.VarChar).Value = quatrinh.HeSo;
                cmd.Parameters.AddWithValue("@BacLuong", MySqlDbType.VarChar).Value = quatrinh.BacLuong;
                cmd.Parameters.AddWithValue("@PhuCapChucVu", MySqlDbType.VarChar).Value = quatrinh.PhuCapChucVu;
                cmd.Parameters.AddWithValue("@PhuCapKhac", MySqlDbType.VarChar).Value = quatrinh.PhuCapKhac;
                cmd.Parameters.AddWithValue("@MaCanBo", MySqlDbType.VarChar).Value = quatrinh.MaCanBo;
                cmd.Parameters.AddWithValue("@MaLuong", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin quá trình lương của cán bộ thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql = "DELETE FROM QuaTrinhLuong WHERE MaLuong = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa quá trình lương thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string sql = "SELECT MaLuong,KieuNangLuong,NgayHuong,NgachCongChuc,BacLuong,FORMAT(HeSo, 'N2') AS FormattedPrice,PhuCapChucVu,PhuCapKhac" +
                " FROM QuaTrinhLuong WHERE MaCanBo = @macanbo";
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
