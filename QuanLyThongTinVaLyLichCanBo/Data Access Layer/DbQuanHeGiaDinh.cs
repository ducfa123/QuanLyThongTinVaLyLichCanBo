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
    internal class DbQuanHeGiaDinh
    {
        public static void addQuanHe(QuanHeGiaDinh qh)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO QuanHeGiaDinh(MaCanBo,MoiQuanHe,HoVaTen,NamSinh,QueQuan,NgheNghiep,DonViCongTac,NoiO)" +
                    "VALUES(@macanbo,@moiquanhe,@hovaten,@namsinh,@quequan,@nghenghiep,@donvicongtac,@noio)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = qh.macanbo;
                cmd.Parameters.AddWithValue("@moiquanhe", MySqlDbType.VarChar).Value = qh.moiquanhe;
                cmd.Parameters.AddWithValue("@hovaten", MySqlDbType.VarChar).Value = qh.hovaten;
                cmd.Parameters.AddWithValue("@namsinh", MySqlDbType.VarChar).Value = qh.namsinh;
                cmd.Parameters.AddWithValue("@quequan", MySqlDbType.VarChar).Value = qh.quequan;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = qh.nghenghiep;
                cmd.Parameters.AddWithValue("@donvicongtac", MySqlDbType.VarChar).Value = qh.donvicongtac;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = qh.noio;

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

        public static void updateQuanHe(QuanHeGiaDinh qh, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE QuanHeGiaDinh SET MoiQuanHe = @moiquanhe,HoVaTen = @hovaten,NamSinh = @namsinh " +
                    ",QueQuan = @quequan,NgheNghiep=@nghenghiep,DonViCongTac=@donvicongtac,NoiO= @noio WHERE MaQHGD=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@moiquanhe", MySqlDbType.VarChar).Value = qh.moiquanhe;
                cmd.Parameters.AddWithValue("@hovaten", MySqlDbType.VarChar).Value = qh.hovaten;
                cmd.Parameters.AddWithValue("@namsinh", MySqlDbType.VarChar).Value = qh.namsinh;
                cmd.Parameters.AddWithValue("@quequan", MySqlDbType.VarChar).Value = qh.quequan;
                cmd.Parameters.AddWithValue("@nghenghiep", MySqlDbType.VarChar).Value = qh.nghenghiep;
                cmd.Parameters.AddWithValue("@donvicongtac", MySqlDbType.VarChar).Value = qh.donvicongtac;
                cmd.Parameters.AddWithValue("@noio", MySqlDbType.VarChar).Value = qh.noio;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin quan hệ gia đình thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteQuanHe(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM QuanHeGiaDinh WHERE MaQHGD=@id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa quan hệ gia đình thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchQuanHe(int macanbo, DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "SELECT MaQHGD,MoiQuanHe,HoVaTen,NamSinh,QueQuan,NgheNghiep,DonViCongTac,NoiO" +
                " FROM QuanHeGiaDinh WHERE MaCanBo = @macanbo";
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
