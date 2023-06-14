using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        SqlDataReader reader;
        public List<User> Accounts(string query)
        {
            List<User> acc = new List<User>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                cmd = new SqlCommand(query, sqlConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    acc.Add(new User(reader.GetString(1), reader.GetString(2)));
                }
                sqlConnection.Close();
            }
            return acc;
        }

     
    }
}
