using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThongTinVaLyLichCanBo.Class.Model
{
    internal class User
    {
        protected string username;
        public string Username { get => username; set => username = value; }
        protected string password; 
        public string Password{ get => password; set => password = value; }
        protected string phonenumber; 
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        protected string email; 
        public string Email { get => email; set => email = value; }
        protected string tencanbo;
        public string Tencanbo { get => tencanbo; set => tencanbo = value; }
        public User()
        {


        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(string username, string password, string phonenumber, string email)
        {
            this.username = username;
            this.password = password;
            this.phonenumber = phonenumber;
            this.email = email;
        }
        public User(string username, string password, string phonenumber, string email, string tencanbo)
        {
            this.username = username;
            this.password = password;
            this.phonenumber = phonenumber;
            this.email = email;
            this.tencanbo = tencanbo;
        }

    }
}
