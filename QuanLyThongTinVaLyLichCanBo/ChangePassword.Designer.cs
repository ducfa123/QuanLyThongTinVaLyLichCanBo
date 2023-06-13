namespace QuanLyThongTinVaLyLichCanBo
{
    partial class ChangePassword
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
            btnDoimatkhau = new FontAwesome.Sharp.IconButton();
            matkhaucuLb = new Label();
            maukhaucuIn = new Input();
            label5 = new Label();
            passIn = new Input();
            pass2In = new Input();
            label6 = new Label();
            label4 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnDoimatkhau
            // 
            btnDoimatkhau.BackColor = Color.DimGray;
            btnDoimatkhau.Cursor = Cursors.Hand;
            btnDoimatkhau.FlatAppearance.BorderSize = 0;
            btnDoimatkhau.FlatStyle = FlatStyle.Flat;
            btnDoimatkhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoimatkhau.ForeColor = Color.White;
            btnDoimatkhau.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDoimatkhau.IconColor = Color.White;
            btnDoimatkhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDoimatkhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoimatkhau.Location = new Point(571, 524);
            btnDoimatkhau.Name = "btnDoimatkhau";
            btnDoimatkhau.Size = new Size(200, 53);
            btnDoimatkhau.TabIndex = 58;
            btnDoimatkhau.Text = "Đổi mật khẩu";
            btnDoimatkhau.UseVisualStyleBackColor = false;
            btnDoimatkhau.Click += btnDoimatkhau_Click;
            // 
            // matkhaucuLb
            // 
            matkhaucuLb.AutoSize = true;
            matkhaucuLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaucuLb.ForeColor = Color.Gray;
            matkhaucuLb.Location = new Point(221, 180);
            matkhaucuLb.Name = "matkhaucuLb";
            matkhaucuLb.Size = new Size(135, 28);
            matkhaucuLb.TabIndex = 57;
            matkhaucuLb.Text = "Mật khẩu cũ:";
            // 
            // maukhaucuIn
            // 
            maukhaucuIn.BackColor = SystemColors.Window;
            maukhaucuIn.BorderColor = Color.LightSlateGray;
            maukhaucuIn.BorderFocusColor = Color.HotPink;
            maukhaucuIn.BorderSize = 2;
            maukhaucuIn.ForeColor = Color.DimGray;
            maukhaucuIn.Location = new Point(486, 173);
            maukhaucuIn.Margin = new Padding(5, 4, 5, 4);
            maukhaucuIn.Multiline = false;
            maukhaucuIn.Name = "maukhaucuIn";
            maukhaucuIn.Padding = new Padding(7);
            maukhaucuIn.PasswordChar = true;
            maukhaucuIn.Size = new Size(325, 35);
            maukhaucuIn.TabIndex = 1;
            maukhaucuIn.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(220, 278);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 48;
            label5.Text = "Mật khẩu mới:";
            // 
            // passIn
            // 
            passIn.BackColor = SystemColors.Window;
            passIn.BorderColor = Color.LightSlateGray;
            passIn.BorderFocusColor = Color.HotPink;
            passIn.BorderSize = 2;
            passIn.ForeColor = Color.DimGray;
            passIn.Location = new Point(487, 271);
            passIn.Margin = new Padding(5, 4, 5, 4);
            passIn.Multiline = false;
            passIn.Name = "passIn";
            passIn.Padding = new Padding(7);
            passIn.PasswordChar = true;
            passIn.Size = new Size(325, 35);
            passIn.TabIndex = 2;
            passIn.UnderlinedStyle = true;
            // 
            // pass2In
            // 
            pass2In.BackColor = SystemColors.Window;
            pass2In.BorderColor = Color.LightSlateGray;
            pass2In.BorderFocusColor = Color.HotPink;
            pass2In.BorderSize = 2;
            pass2In.ForeColor = Color.DimGray;
            pass2In.Location = new Point(486, 369);
            pass2In.Margin = new Padding(5, 4, 5, 4);
            pass2In.Multiline = false;
            pass2In.Name = "pass2In";
            pass2In.Padding = new Padding(7);
            pass2In.PasswordChar = true;
            pass2In.Size = new Size(325, 35);
            pass2In.TabIndex = 3;
            pass2In.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(220, 376);
            label6.Name = "label6";
            label6.Size = new Size(235, 28);
            label6.TabIndex = 50;
            label6.Text = "Nhập lại mật khẩu mới:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(45, 4);
            label4.Name = "label4";
            label4.Size = new Size(228, 45);
            label4.TabIndex = 47;
            label4.Text = "Đổi mật khẩu";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Transparent;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Gray;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            iconButton4.IconColor = Color.Gray;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(1, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(45, 45);
            iconButton4.TabIndex = 336;
            iconButton4.Text = "    Thêm";
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1300, 720);
            Controls.Add(iconButton4);
            Controls.Add(btnDoimatkhau);
            Controls.Add(matkhaucuLb);
            Controls.Add(maukhaucuIn);
            Controls.Add(label5);
            Controls.Add(passIn);
            Controls.Add(pass2In);
            Controls.Add(label6);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDoimatkhau;
        private Label matkhaucuLb;
        private Input maukhaucuIn;
        private Label label5;
        private Input passIn;
        private Input pass2In;
        private Label label6;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}