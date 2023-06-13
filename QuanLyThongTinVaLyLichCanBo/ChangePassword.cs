using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class ChangePassword : Form
    {
        private readonly ListAccount _parent;
        private readonly MainFormUser _parent_2;
        public string password, username;
        public bool isAdmin;

        public ChangePassword(ListAccount parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public ChangePassword(MainFormUser parent)
        {
            InitializeComponent();
            _parent_2 = parent;
        }

        public void AdminDisplay()
        {

            matkhaucuLb.Visible = false;
            maukhaucuIn.Visible = false;
        }
        public void AdminChangePassword()
        {
            string new_password = passIn.Text;
            string re_new_password = pass2In.Text;
            string errMsg;
            if (!checkPassword(new_password, re_new_password, out errMsg))
            {
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DbAccount.ChangePassword(new_password, username);
            AdminClear();
        }
        public void AdminClear()
        {
            passIn.Text = pass2In.Text = string.Empty;

        }
        public void UserClear()
        {
            passIn.Text = pass2In.Text = string.Empty;
            maukhaucuIn.Text = string.Empty;
        }
        public void UserChangePassWord()
        {
            using (SqlConnection connection = new SqlConnection(Connection.strCon))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Password FROM [User] WHERE Username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader.GetString(0);
                            string computedHash = Connection.ComputeSha256Hash(maukhaucuIn.Text);
                            if (hashedPassword == computedHash)
                            {
                                string new_password = passIn.Text;
                                string re_new_password = pass2In.Text;
                                string errMsg;
                                if (!checkPassword(new_password, re_new_password, out errMsg))
                                {
                                    MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                DbAccount.ChangePassword(new_password, username);
                                UserClear();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu cũ không đúng!");
                            }
                        }

                    }
                }
            }
        }
        bool ComparePassword(string p1, string p2)
        {
            return String.Compare(p1, p2) == 0;
        }
        public bool checkPassword(string password, string re_password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Mật khẩu không nên để trống";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (!ComparePassword(password, re_password))
            {
                ErrorMessage = "Mật khẩu không trùng";
                return false;
            }
            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ cái viết thường";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ cái viết hoa";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu không được nhỏ hơn hoặc lớn hơn 12 ký tự";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một giá trị số";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu nên chứa ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                AdminChangePassword();
            }
            else
            {
                UserChangePassWord();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }
    }
}
