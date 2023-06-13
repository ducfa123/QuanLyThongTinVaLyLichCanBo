using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QuanLyThongTinVaLyLichCanBo.Class;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class LoginForm : Form
    {
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
               
           
        }

        private void input1__TextChanged(object sender, EventArgs e)
        {

        }

        
        Modify modify = new Modify();
        private void createButton_Click(object sender, EventArgs e)
        {
             username = inputUsername.Text;
            string password = inputPass.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else

                using (SqlConnection connection = new SqlConnection(Connection.strCon))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Password,Role,MaCanBo FROM [User] WHERE Username = @username", connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {   
                                string Role = reader.GetString(1);
                                string hashedPassword = reader.GetString(0);
                                string computedHash = Connection.ComputeSha256Hash(password);
                                if (hashedPassword == computedHash)
                                {
                                    // Do something to navigate to your application's main form
                                    if(Role == "Admin")
                                    {
                                        MainForm mf = new MainForm();
                                        mf.Show();
                                        this.Hide();
                                        mf.Logout += Mf_Logout;
                                    }
                                    else if (Role == "Can Bo")
                                    {
                                        MainUserForm mfu = new MainUserForm();
                                        mfu.macanbo =  reader.GetInt32(2);
                                        mfu.Show();
                                        this.Hide();
                                        mfu.Logout+= Mfu_Logout;     
                                    }
                                   
                                }
                                else
                                {
                                    MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ.");
                            }
                        }
                    }
                    }
                }

        private void Mfu_Logout(object? sender, EventArgs e)
        {
            (sender as MainUserForm).isThoat = false;
            (sender as MainUserForm).Close();
            this.Show();
        }
        private void Mf_Logout(object? sender, EventArgs e)
        {
            (sender as MainForm).isThoat = false;
            (sender as MainForm).Close();
            this.Show();
        }

        private void inputPass__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
