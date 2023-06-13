using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThongTinVaLyLichCanBo.Class.Model;

namespace QuanLyThongTinVaLyLichCanBo.Class.Control
{
    internal class DbAccount
    {
        public static void addAccount(Account acc)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                //thêm 1 cán bộ mới vào db
                string query1 = "INSERT INTO ThongTinCanBo (HoTen) OUTPUT INSERTED.MaCanBo VALUES (@tencanbo)";
                SqlCommand cmd1 = new SqlCommand(query1, sqlConnection);
                cmd1.Parameters.AddWithValue("@tencanbo", MySqlDbType.VarChar).Value = acc.tencanbo;
                int macanbo = Convert.ToInt32(cmd1.ExecuteScalar());

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO [User](UserName,Password,Email,PhoneNumber,Role,MaCanBo)" + "VALUES(@username,@password,@email,@phonenumber,@role,@macanbo)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", MySqlDbType.VarChar).Value = acc.username;
                cmd.Parameters.AddWithValue("@password", MySqlDbType.VarChar).Value = Connection.ComputeSha256Hash(acc.password);
                cmd.Parameters.AddWithValue("@email", MySqlDbType.VarChar).Value = acc.email;
                cmd.Parameters.AddWithValue("@phonenumber", MySqlDbType.VarChar).Value = acc.phonenumber;
                cmd.Parameters.AddWithValue("@role", "Can Bo");
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = macanbo;
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

        public static void ChangePassword(string password, string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE [User] SET Password = @password WHERE UserName=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@password", MySqlDbType.VarChar).Value = Connection.ComputeSha256Hash(password);  
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteAcc(string username)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM [User] WHERE UserName = @username";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", MySqlDbType.VarChar).Value = username;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa tài khoản thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchAccount(string query, DataGridView dgv)
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
