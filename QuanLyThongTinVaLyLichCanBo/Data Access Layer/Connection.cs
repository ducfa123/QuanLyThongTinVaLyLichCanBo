using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;


namespace QuanLyThongTinVaLyLichCanBo.Class
{
    class Connection
    {
        public static string strCon = @"Data Source=BMD-CNTT56;Initial Catalog=QuanLyLyLichCanBo;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strCon);
        }

        public static string ComputeSha256Hash(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
