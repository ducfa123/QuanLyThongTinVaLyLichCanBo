namespace QuanLyThongTinVaLyLichCanBo
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.inputUsername = new QuanLyThongTinVaLyLichCanBo.Input();
            this.inputPass = new QuanLyThongTinVaLyLichCanBo.Input();
            this.createButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hệ thống quản lý lý lịch cán bộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(310, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài khoản:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(310, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(950, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(510, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chưa có tài khoản?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(750, 395);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(116, 20);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Quên mật khẩu?";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(173, 241);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.UseWaitCursor = true;
            // 
            // inputUsername
            // 
            this.inputUsername.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.inputUsername.BackColor = System.Drawing.SystemColors.Window;
            this.inputUsername.BorderColor = System.Drawing.Color.Gray;
            this.inputUsername.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.inputUsername.BorderSize = 2;
            this.inputUsername.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputUsername.ForeColor = System.Drawing.Color.Black;
            this.inputUsername.Location = new System.Drawing.Point(506, 199);
            this.inputUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputUsername.Multiline = false;
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Padding = new System.Windows.Forms.Padding(7);
            this.inputUsername.PasswordChar = false;
            this.inputUsername.Size = new System.Drawing.Size(390, 52);
            this.inputUsername.TabIndex = 1;
            this.inputUsername.UnderlinedStyle = true;
            this.inputUsername._TextChanged += new System.EventHandler(this.input1__TextChanged);
            // 
            // inputPass
            // 
            this.inputPass.BackColor = System.Drawing.SystemColors.Window;
            this.inputPass.BorderColor = System.Drawing.Color.Gray;
            this.inputPass.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.inputPass.BorderSize = 2;
            this.inputPass.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPass.ForeColor = System.Drawing.Color.Black;
            this.inputPass.Location = new System.Drawing.Point(510, 304);
            this.inputPass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputPass.Multiline = false;
            this.inputPass.Name = "inputPass";
            this.inputPass.Padding = new System.Windows.Forms.Padding(7);
            this.inputPass.PasswordChar = true;
            this.inputPass.Size = new System.Drawing.Size(390, 52);
            this.inputPass.TabIndex = 2;
            this.inputPass.UnderlinedStyle = true;
            this.inputPass._TextChanged += new System.EventHandler(this.inputPass__TextChanged);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DimGray;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.createButton.IconColor = System.Drawing.Color.White;
            this.createButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createButton.Location = new System.Drawing.Point(588, 429);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(200, 53);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "Đăng nhập";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 574);
            this.ControlBox = false;
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label5;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Input inputUsername;
        private Input inputPass;
        private FontAwesome.Sharp.IconButton createButton;
    }
}