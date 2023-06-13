using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class DatabaseManager
    {
        public static DataTable GetAllCanBo()
        {

            DataTable dataTable = new DataTable();


            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetAllCanBo", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataTable GetThiDuaByYear(int nam)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetThiDuaByYear", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nam", nam);

                connection.Open();


                // Xử lý dữ liệu trả về từ reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

            }
            return dataTable;
        }

        public static DataTable GetKhenThuongByYear(int nam)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {

                SqlCommand command = new SqlCommand("GetKhenThuongByYear", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nam", nam);

                connection.Open();


                // Xử lý dữ liệu trả về từ reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

            }
            return dataTable;
        }

        public static DataTable GetKyLuatByYear(int nam)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetKyLuatByYear", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nam", nam);

                connection.Open();


                // Xử lý dữ liệu trả về từ reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

            }
            return dataTable;
        }

        public static DataTable GetDanhGiaByYear(int nam)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetDanhGiaByYear", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nam", nam);

                connection.Open();


                // Xử lý dữ liệu trả về từ reader
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

            }
            return dataTable;
        }
        public static Dictionary<string, int> GetTop5EthnicitiesWithCountFromDatabase()
        {
            Dictionary<string, int> ethnicityCountList = new Dictionary<string, int>();

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetTop5EthnicitiesWithCount", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("DanToc")) && !reader.IsDBNull(reader.GetOrdinal("SoLuong")))
                    {
                        string ethnicity = reader.GetString(reader.GetOrdinal("DanToc"));
                        int count = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                        ethnicityCountList.Add(ethnicity, count);
                    }
                }

                reader.Close();
            }

            return ethnicityCountList;
        }
        public static List<int> GetWeightListFromDatabase()
        {
            List<int> weightList = new List<int>();

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetWeightList", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("CanNang")))
                    {
                        string weightString = reader.GetString(reader.GetOrdinal("CanNang"));
                        int weight = Convert.ToInt32(weightString);
                        weightList.Add(weight);
                    }
                }

                reader.Close();
            }

            return weightList;
        }

        public static List<int> GetHeightListFromDatabase()
        {
            List<int> heightList = new List<int>();

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetHeightList", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("ChieuCao")))
                    {
                        string heightString = reader.GetString(reader.GetOrdinal("ChieuCao"));
                        int height;
                        if (int.TryParse(heightString, out height))
                        {
                            heightList.Add(height);
                        }
                        else
                        {
                            // Handle parsing error if needed
                        }
                    }
                }

                reader.Close();
            }

            return heightList;
        }

        public static List<int> GetAgeListFromDatabase()
        {
            List<int> ageList = new List<int>();

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand("GetAgeList", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int age = Convert.ToInt32(reader["Age"]);
                    ageList.Add(age);
                }

                reader.Close();
            }

            return ageList;
        }
        public static int GetFemaleCanBo()
        {
            int totalCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CountFemaleOfficers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    totalCount = (int)command.ExecuteScalar();
                }
            }

            return totalCount;
        }
        public static int GetMaleCanBo()
        {
            int totalCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CountMaleOfficers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    totalCount = (int)command.ExecuteScalar();
                }
            }

            return totalCount;
        }

        public static int GetOtherGenderCanBo()
        {
            int totalCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CountOtherGenderOfficers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    totalCount = (int)command.ExecuteScalar();
                }
            }

            return totalCount;
        }
        public static int GetTotalCanBoCount()
        {
            int totalCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetTotalCanBoCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    totalCount = (int)command.ExecuteScalar();
                }
            }

            return totalCount;
        }




        public static int GetDanhGiaCount(string loaiDanhGia, int nam)
        {
            int danhGiaCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetDanhGiaCountByLoaiDanhGia", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@LoaiDanhGia", loaiDanhGia);
                    command.Parameters.AddWithValue("@Nam", nam);

                    danhGiaCount = (int)command.ExecuteScalar();
                }
            }


            return danhGiaCount;
        }

        public static int GetThiDuaCount(string hinhThucThiDua, int nam)
        {
            int thiDuaCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetThiDuaCountByHinhThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@HinhThucThiDua", hinhThucThiDua);
                    command.Parameters.AddWithValue("@Nam", nam);

                    // Đọc giá trị trả về từ procedure
                    thiDuaCount = (int)command.ExecuteScalar();
                }
            }

            return thiDuaCount;
        }

        public static int GetKhenThuongCount(string hinhThucKhenThuong, int nam)
        {
            int khenThuongCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetKhenThuongCountByHinhThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@HinhThucKhenThuong", hinhThucKhenThuong);
                    command.Parameters.AddWithValue("@Nam", nam);

                    // Đọc giá trị trả về từ procedure
                    khenThuongCount = (int)command.ExecuteScalar();
                }
            }

            return khenThuongCount;
        }

        public static int GetKyLuatCount(string hinhThucKyLuat, int nam)
        {
            int kyLuatCount = 0;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetKyLuatCountByHinhThuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@HinhThucKyLuat", hinhThucKyLuat);
                    command.Parameters.AddWithValue("@Nam", nam);

                    // Đọc giá trị trả về từ procedure
                    kyLuatCount = (int)command.ExecuteScalar();
                }
            }

            return kyLuatCount;
        }
    }
}
