using MySql.Data.MySqlClient;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class.Control
{
    internal class DbDaoTaoBoiDuongChuyenMon
    {
        public static void addDaoTao(DaoTaoBoiDuongChuyenMon daotao)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
              
                //thêm tài khoản liên kết với mã cán bộ vừa rồi
                string query = "INSERT INTO DaoTaoBoiDuongChuyenMon(MaCanBo,TenTruong,ChuyenNghanhDaoTao,ThoiGianBatDauDaoTao,ThoiGianKetThucDaoTao,HinhThucDaoTao,VanBang)" + 
                    "VALUES(@macanbo,@tentruong,@chuyennghanhdaotao,@thoigianbatdaudaotao,@thoigianketthucdaotao,@hinhthucdaotao,@vanbang)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@macanbo", MySqlDbType.VarChar).Value = daotao.MaCanBo;
                cmd.Parameters.AddWithValue("@tentruong", MySqlDbType.VarChar).Value = daotao.TenTruong;
                cmd.Parameters.AddWithValue("@chuyennghanhdaotao", MySqlDbType.VarChar).Value = daotao.ChuyenNghanhDaoTao;
                cmd.Parameters.AddWithValue("@thoigianbatdaudaotao", MySqlDbType.VarChar).Value = daotao.ThoiGianBatDauDaoTao;
                cmd.Parameters.AddWithValue("@thoigianketthucdaotao", MySqlDbType.VarChar).Value = daotao.ThoiGianKetThucDaoTao;
                cmd.Parameters.AddWithValue("@hinhthucdaotao", MySqlDbType.VarChar).Value = daotao.HinhThucDaoTao;
                cmd.Parameters.AddWithValue("@vanbang", MySqlDbType.VarChar).Value = daotao.VanBang;
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

        public static void updateDaotao(DaoTaoBoiDuongChuyenMon daotao, int id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string query = "UPDATE DaoTaoBoiDuongChuyenMon SET TenTruong = @tentruong,ChuyenNghanhDaoTao = @chuyennghanhdaotao,ThoiGianBatDauDaoTao = @thoigianbatdaudaotao " +
                    ",ThoiGianKetThucDaoTao = @thoigianketthucdaotao,HinhThucDaoTao = @hinhthucdaotao,VanBang = @vanbang WHERE MaDaoTao=@id";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@tentruong", MySqlDbType.VarChar).Value = daotao.TenTruong;
                cmd.Parameters.AddWithValue("@chuyennghanhdaotao", MySqlDbType.VarChar).Value = daotao.ChuyenNghanhDaoTao;
                cmd.Parameters.AddWithValue("@thoigianbatdaudaotao", MySqlDbType.VarChar).Value = daotao.ThoiGianBatDauDaoTao;
                cmd.Parameters.AddWithValue("@thoigianketthucdaotao", MySqlDbType.VarChar).Value = daotao.ThoiGianKetThucDaoTao;
                cmd.Parameters.AddWithValue("@hinhthucdaotao", MySqlDbType.VarChar).Value = daotao.HinhThucDaoTao;
                cmd.Parameters.AddWithValue("@vanbang", MySqlDbType.VarChar).Value = daotao.VanBang;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thông tin quá trình đào tạo thành công thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DeleteDaotao(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "DELETE FROM DaoTaoBoiDuongChuyenMon WHERE MaDaoTao = @id";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", MySqlDbType.VarChar).Value = id;
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa quá trình đào tạo thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        public static void DisplayAndSearchDaoTao(int macanbo,DataGridView dgv)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                string sql = "SELECT MaDaoTao,TenTruong,ChuyenNghanhDaoTao,ThoiGianBatDauDaoTao,ThoiGianKetThucDaoTao" +
                ",HinhThucDaoTao,VanBang FROM DaoTaoBoiDuongChuyenMon WHERE MaCanBo = @macanbo";
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
