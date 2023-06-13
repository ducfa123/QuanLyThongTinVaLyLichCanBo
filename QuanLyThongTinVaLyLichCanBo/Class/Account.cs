using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class.Model
{
    internal class Account
    {
        public string username;
        public string password;
        public string phonenumber;
        public string email;
        public string tencanbo;
        public Account()
        {


        }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account(string username, string password, string phonenumber, string email)
        {
            Username = username;
            Password = password;
            this.phonenumber = phonenumber;
            this.email = email;
        }
        public Account(string username, string password, string phonenumber, string email, string tencanbo)
        {
            Username = username;
            Password = password;
            this.phonenumber = phonenumber;
            this.email = email;
            this.tencanbo = tencanbo;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
