using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509;
using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class RegisterForm : Form
    {
        private readonly AccountListForm _parent;
        public string username, password, password2, email, phonenumber, type;
        public RegisterForm(AccountListForm parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        public void Clear()
        {
            usernameIn.Text = tencanboIn.Text = passIn.Text = pass2In.Text = mailIn.Text = phoneIn.Text = string.Empty;
        }
        private void usernameIn__TextChanged(object sender, EventArgs e)
        {
        }
        public bool checkUsername(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
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

        private void typeIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w]{3,20}@gmail.com(.vn|)$");
        }
        bool ComparePassword(string p1, string p2)
        {
            return String.Compare(p1, p2) == 0;
        }
        Modify modify = new Modify();

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tencanbo = tencanboIn.Text;
            string username = usernameIn.Text;
            string password = passIn.Text;
            string re_password = pass2In.Text;
            string email = mailIn.Text;
            string phonenumber = phoneIn.Text;
            if (!tencanbo.Equals(tencanbo.ToUpper()))
            {
                MessageBox.Show("Tên Cán Bộ phải được viết hoa!");
                return;
            }

            if (!checkUsername(username))
            {
                MessageBox.Show("Tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường"); return;
                return;
            }

            string errMsg;
            if (!checkPassword(password, re_password, out errMsg))
            {
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email");
                return;
            }


            if (modify.Accounts("Select * from [User] where Email = +'" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí, vui lòng đăng ký Email khác");
                return;

            }
            if (modify.Accounts("Select * from [User] where UserName = +'" + username + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng đăng ký tên tài khoản khác");
                return;

            }
            if (modify.Accounts("Select * from [User] where PhoneNumber = +'" + phonenumber + "'").Count != 0)
            {
                MessageBox.Show("Số điện thoại này đã được đăng kí, vui lòng đăng ký số điện thoại khác");
                return;

            }

            //Insert to table User
            try
            {

                User acc = new User(username, password, phonenumber, email, tencanbo);
                DbAccount.addAccount(acc);
                Clear();

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }
    }
}
