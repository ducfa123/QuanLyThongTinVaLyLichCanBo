namespace QuanLyThongTinVaLyLichCanBo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarpanel = new Panel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            createAccButton = new FontAwesome.Sharp.IconButton();
            createButton = new FontAwesome.Sharp.IconButton();
            nangluongBtn = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            headerpanel = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            contentpanel = new Panel();
            label1 = new Label();
            sidebarpanel.SuspendLayout();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentpanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarpanel
            // 
            sidebarpanel.BackColor = Color.DimGray;
            sidebarpanel.Controls.Add(iconButton6);
            sidebarpanel.Controls.Add(createAccButton);
            sidebarpanel.Controls.Add(createButton);
            sidebarpanel.Controls.Add(nangluongBtn);
            sidebarpanel.Controls.Add(iconButton5);
            sidebarpanel.Controls.Add(iconButton3);
            sidebarpanel.Dock = DockStyle.Left;
            sidebarpanel.Location = new Point(0, 80);
            sidebarpanel.Name = "sidebarpanel";
            sidebarpanel.Size = new Size(200, 720);
            sidebarpanel.TabIndex = 0;
            sidebarpanel.Paint += sidebarpanel_Paint;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.DimGray;
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            iconButton6.IconColor = SystemColors.Window;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(-1, 421);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(234, 70);
            iconButton6.TabIndex = 5;
            iconButton6.Text = "Thống kê";
            iconButton6.UseVisualStyleBackColor = false;
            iconButton6.Click += iconButton6_Click;
            // 
            // createAccButton
            // 
            createAccButton.BackColor = Color.DimGray;
            createAccButton.Cursor = Cursors.Hand;
            createAccButton.FlatAppearance.BorderSize = 0;
            createAccButton.FlatStyle = FlatStyle.Flat;
            createAccButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            createAccButton.ForeColor = Color.White;
            createAccButton.IconChar = FontAwesome.Sharp.IconChar.List;
            createAccButton.IconColor = Color.White;
            createAccButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createAccButton.ImageAlign = ContentAlignment.MiddleLeft;
            createAccButton.Location = new Point(3, 136);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(244, 70);
            createAccButton.TabIndex = 1;
            createAccButton.Text = "Quản lý hồ sơ";
            createAccButton.UseVisualStyleBackColor = false;
            createAccButton.Click += iconButton1_Click_1;
            // 
            // createButton
            // 
            createButton.BackColor = Color.DimGray;
            createButton.Cursor = Cursors.Hand;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = Color.White;
            createButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            createButton.IconColor = Color.White;
            createButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createButton.ImageAlign = ContentAlignment.MiddleLeft;
            createButton.Location = new Point(-1, 41);
            createButton.Name = "createButton";
            createButton.Size = new Size(206, 72);
            createButton.TabIndex = 0;
            createButton.Text = "Quản lý tài khoản";
            createButton.TextAlign = ContentAlignment.MiddleRight;
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += iconButton1_Click;
            // 
            // nangluongBtn
            // 
            nangluongBtn.BackColor = Color.DimGray;
            nangluongBtn.Cursor = Cursors.Hand;
            nangluongBtn.FlatAppearance.BorderSize = 0;
            nangluongBtn.FlatStyle = FlatStyle.Flat;
            nangluongBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nangluongBtn.ForeColor = Color.White;
            nangluongBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            nangluongBtn.IconColor = Color.White;
            nangluongBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nangluongBtn.ImageAlign = ContentAlignment.MiddleLeft;
            nangluongBtn.Location = new Point(-1, 231);
            nangluongBtn.Name = "nangluongBtn";
            nangluongBtn.Size = new Size(248, 70);
            nangluongBtn.TabIndex = 3;
            nangluongBtn.Text = "Quản lý lương";
            nangluongBtn.UseVisualStyleBackColor = false;
            nangluongBtn.Click += nangluongBtn_Click;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.DimGray;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 326);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(205, 89);
            iconButton5.TabIndex = 4;
            iconButton5.Text = "       Báo cáo khen thưởng, kỷ luật, đánh giá";
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.DimGray;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(-3, 516);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(236, 70);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Đăng xuất";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Gray;
            headerpanel.Controls.Add(pictureBox1);
            headerpanel.Controls.Add(label2);
            headerpanel.Controls.Add(iconButton7);
            headerpanel.Dock = DockStyle.Top;
            headerpanel.ForeColor = Color.Transparent;
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1500, 80);
            headerpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(562, 12);
            label2.Name = "label2";
            label2.Size = new Size(350, 45);
            label2.TabIndex = 1;
            label2.Text = "Quản lý lý lịch cán bộ";
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.Gray;
            iconButton7.Cursor = Cursors.Hand;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton7.IconColor = Color.Transparent;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(1459, 0);
            iconButton7.Margin = new Padding(0);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(40, 40);
            iconButton7.TabIndex = 1;
            iconButton7.Text = "X";
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Click += iconButton7_Click;
            // 
            // contentpanel
            // 
            contentpanel.BackColor = SystemColors.Control;
            contentpanel.Controls.Add(label1);
            contentpanel.Dock = DockStyle.Fill;
            contentpanel.Location = new Point(200, 80);
            contentpanel.Name = "contentpanel";
            contentpanel.Size = new Size(1300, 720);
            contentpanel.TabIndex = 2;
            contentpanel.Paint += contentpanel_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 179);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CausesValidation = false;
            ClientSize = new Size(1500, 800);
            ControlBox = false;
            Controls.Add(contentpanel);
            Controls.Add(sidebarpanel);
            Controls.Add(headerpanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosed += MainForm_FormClosed;
            Load += Mainform_Load;
            sidebarpanel.ResumeLayout(false);
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentpanel.ResumeLayout(false);
            contentpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarpanel;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton createButton;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton nangluongBtn;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel headerpanel;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel contentpanel;
        private Label label1;
        private FontAwesome.Sharp.IconButton createAccButton;
    }
}