namespace QuanLyThongTinVaLyLichCanBo
{
    partial class ListAccount
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            dtAccount = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewButtonColumn();
            createButton = new FontAwesome.Sharp.IconButton();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            filterUsername = new TextBox();
            xemBtn = new FontAwesome.Sharp.IconButton();
            filterEmail = new TextBox();
            filterPhoneNumber = new TextBox();
            filterRole = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            previousBtn = new FontAwesome.Sharp.IconButton();
            firstBtn = new FontAwesome.Sharp.IconButton();
            threedotbeforeBtn = new Label();
            firstindexBtn = new FontAwesome.Sharp.IconButton();
            secondindexBtn = new FontAwesome.Sharp.IconButton();
            threeindexBtn = new FontAwesome.Sharp.IconButton();
            threedotafterLB = new Label();
            lastBtn = new FontAwesome.Sharp.IconButton();
            nextBtn = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtAccount).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 20);
            label4.Name = "label4";
            label4.Size = new Size(334, 45);
            label4.TabIndex = 6;
            label4.Text = "Danh sách tài khoản";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 82);
            panel1.TabIndex = 6;
            // 
            // dtAccount
            // 
            dtAccount.AllowUserToAddRows = false;
            dtAccount.AllowUserToDeleteRows = false;
            dtAccount.AllowUserToResizeColumns = false;
            dtAccount.AllowUserToResizeRows = false;
            dtAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtAccount.BackgroundColor = Color.White;
            dtAccount.BorderStyle = BorderStyle.None;
            dtAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtAccount.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Role, Column2, Column8 });
            dtAccount.GridColor = Color.White;
            dtAccount.Location = new Point(63, 229);
            dtAccount.MultiSelect = false;
            dtAccount.Name = "dtAccount";
            dtAccount.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dtAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dtAccount.RowHeadersVisible = false;
            dtAccount.RowHeadersWidth = 51;
            dtAccount.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtAccount.RowTemplate.Height = 29;
            dtAccount.ShowEditingIcon = false;
            dtAccount.Size = new Size(1187, 424);
            dtAccount.TabIndex = 5;
            dtAccount.CellContentClick += dtCanbo_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UserName";
            Column1.FillWeight = 109.8429F;
            Column1.HeaderText = "UserName";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Email";
            Column3.FillWeight = 114.9689F;
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhoneNumber";
            Column4.FillWeight = 114.9689F;
            Column4.HeaderText = "PhoneNumber";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Role
            // 
            Role.DataPropertyName = "Role";
            Role.FillWeight = 117.311F;
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle7;
            Column2.FillWeight = 67.7032F;
            Column2.FlatStyle = FlatStyle.Flat;
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Text = "Đổi mật khẩu";
            Column2.UseColumnTextForButtonValue = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Red;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            Column8.DefaultCellStyle = dataGridViewCellStyle8;
            Column8.FillWeight = 62.84969F;
            Column8.FlatStyle = FlatStyle.Flat;
            Column8.HeaderText = "";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "Xóa";
            Column8.UseColumnTextForButtonValue = true;
            // 
            // createButton
            // 
            createButton.BackColor = Color.White;
            createButton.Cursor = Cursors.Hand;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = Color.FromArgb(100, 99, 103);
            createButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            createButton.IconColor = Color.FromArgb(100, 99, 103);
            createButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createButton.IconSize = 32;
            createButton.ImageAlign = ContentAlignment.MiddleLeft;
            createButton.Location = new Point(1000, 101);
            createButton.Name = "createButton";
            createButton.Size = new Size(172, 46);
            createButton.TabIndex = 10;
            createButton.Text = "Thêm tài khoản";
            createButton.TextAlign = ContentAlignment.MiddleRight;
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.AllowDrop = true;
            refreshBtn.BackColor = Color.LightGreen;
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.FlatAppearance.BorderSize = 0;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            refreshBtn.IconColor = Color.White;
            refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            refreshBtn.IconSize = 32;
            refreshBtn.Location = new Point(1200, 101);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(46, 46);
            refreshBtn.TabIndex = 314;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // filterUsername
            // 
            filterUsername.Location = new Point(63, 189);
            filterUsername.Name = "filterUsername";
            filterUsername.PlaceholderText = "UserName";
            filterUsername.Size = new Size(170, 27);
            filterUsername.TabIndex = 311;
            filterUsername.Visible = false;
            filterUsername.Click += filterUsername_Click;
            filterUsername.TextChanged += filterUsername_TextChanged;
            // 
            // xemBtn
            // 
            xemBtn.AllowDrop = true;
            xemBtn.BackColor = Color.DarkCyan;
            xemBtn.Cursor = Cursors.Hand;
            xemBtn.FlatAppearance.BorderSize = 0;
            xemBtn.FlatStyle = FlatStyle.Flat;
            xemBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xemBtn.ForeColor = Color.White;
            xemBtn.IconChar = FontAwesome.Sharp.IconChar.Filter;
            xemBtn.IconColor = Color.White;
            xemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xemBtn.IconSize = 32;
            xemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            xemBtn.Location = new Point(868, 101);
            xemBtn.Name = "xemBtn";
            xemBtn.Size = new Size(102, 46);
            xemBtn.TabIndex = 310;
            xemBtn.Text = "     Lọc";
            xemBtn.UseVisualStyleBackColor = false;
            xemBtn.Click += xemBtn_Click;
            // 
            // filterEmail
            // 
            filterEmail.Location = new Point(294, 189);
            filterEmail.Name = "filterEmail";
            filterEmail.PlaceholderText = "Email";
            filterEmail.Size = new Size(170, 27);
            filterEmail.TabIndex = 315;
            filterEmail.Visible = false;
            filterEmail.Click += filterPhoneNumber_Click;
            filterEmail.TextChanged += filterEmail_TextChanged;
            // 
            // filterPhoneNumber
            // 
            filterPhoneNumber.Location = new Point(521, 189);
            filterPhoneNumber.Name = "filterPhoneNumber";
            filterPhoneNumber.PlaceholderText = "PhoneNumber";
            filterPhoneNumber.Size = new Size(170, 27);
            filterPhoneNumber.TabIndex = 316;
            filterPhoneNumber.Visible = false;
            filterPhoneNumber.Click += filterPhoneNumber_Click;
            filterPhoneNumber.SizeChanged += filterPhoneNumber_SizeChanged;
            filterPhoneNumber.TextChanged += filterPhoneNumber_TextChanged;
            // 
            // filterRole
            // 
            filterRole.Location = new Point(754, 189);
            filterRole.Name = "filterRole";
            filterRole.PlaceholderText = "Role";
            filterRole.Size = new Size(170, 27);
            filterRole.TabIndex = 317;
            filterRole.Visible = false;
            filterRole.Click += filterPhoneNumber_Click;
            filterRole.TextChanged += filterRole_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(previousBtn);
            flowLayoutPanel1.Controls.Add(firstBtn);
            flowLayoutPanel1.Controls.Add(threedotbeforeBtn);
            flowLayoutPanel1.Controls.Add(firstindexBtn);
            flowLayoutPanel1.Controls.Add(secondindexBtn);
            flowLayoutPanel1.Controls.Add(threeindexBtn);
            flowLayoutPanel1.Controls.Add(threedotafterLB);
            flowLayoutPanel1.Controls.Add(lastBtn);
            flowLayoutPanel1.Controls.Add(nextBtn);
            flowLayoutPanel1.Location = new Point(967, 665);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(321, 36);
            flowLayoutPanel1.TabIndex = 330;
            // 
            // previousBtn
            // 
            previousBtn.AllowDrop = true;
            previousBtn.AutoSize = true;
            previousBtn.BackColor = Color.FromArgb(100, 99, 103);
            previousBtn.Cursor = Cursors.Hand;
            previousBtn.FlatAppearance.BorderSize = 0;
            previousBtn.FlatStyle = FlatStyle.Flat;
            previousBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            previousBtn.ForeColor = Color.White;
            previousBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            previousBtn.IconColor = Color.White;
            previousBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            previousBtn.IconSize = 24;
            previousBtn.ImageAlign = ContentAlignment.MiddleLeft;
            previousBtn.Location = new Point(3, 3);
            previousBtn.Name = "previousBtn";
            previousBtn.Size = new Size(30, 30);
            previousBtn.TabIndex = 322;
            previousBtn.UseVisualStyleBackColor = false;
            previousBtn.Click += previousBtn_Click;
            // 
            // firstBtn
            // 
            firstBtn.AllowDrop = true;
            firstBtn.AutoSize = true;
            firstBtn.BackColor = Color.FromArgb(100, 99, 103);
            firstBtn.Cursor = Cursors.Hand;
            firstBtn.FlatAppearance.BorderSize = 0;
            firstBtn.FlatStyle = FlatStyle.Flat;
            firstBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstBtn.ForeColor = Color.White;
            firstBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            firstBtn.IconColor = Color.White;
            firstBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            firstBtn.IconSize = 24;
            firstBtn.Location = new Point(39, 3);
            firstBtn.Name = "firstBtn";
            firstBtn.Size = new Size(30, 30);
            firstBtn.TabIndex = 325;
            firstBtn.Text = "1";
            firstBtn.UseVisualStyleBackColor = false;
            firstBtn.Click += firstBtn_Click;
            // 
            // threedotbeforeBtn
            // 
            threedotbeforeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            threedotbeforeBtn.ForeColor = Color.White;
            threedotbeforeBtn.Location = new Point(75, 0);
            threedotbeforeBtn.Name = "threedotbeforeBtn";
            threedotbeforeBtn.Size = new Size(23, 27);
            threedotbeforeBtn.TabIndex = 330;
            threedotbeforeBtn.Text = "...";
            threedotbeforeBtn.TextAlign = ContentAlignment.BottomCenter;
            threedotbeforeBtn.Visible = false;
            // 
            // firstindexBtn
            // 
            firstindexBtn.AllowDrop = true;
            firstindexBtn.AutoSize = true;
            firstindexBtn.BackColor = Color.FromArgb(100, 99, 103);
            firstindexBtn.Cursor = Cursors.Hand;
            firstindexBtn.FlatAppearance.BorderSize = 0;
            firstindexBtn.FlatStyle = FlatStyle.Flat;
            firstindexBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstindexBtn.ForeColor = Color.White;
            firstindexBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            firstindexBtn.IconColor = Color.White;
            firstindexBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            firstindexBtn.IconSize = 24;
            firstindexBtn.Location = new Point(104, 3);
            firstindexBtn.Name = "firstindexBtn";
            firstindexBtn.Size = new Size(30, 30);
            firstindexBtn.TabIndex = 331;
            firstindexBtn.Text = "2";
            firstindexBtn.TextAlign = ContentAlignment.MiddleRight;
            firstindexBtn.UseVisualStyleBackColor = false;
            firstindexBtn.Click += firstindexBtn_Click;
            // 
            // secondindexBtn
            // 
            secondindexBtn.AllowDrop = true;
            secondindexBtn.AutoSize = true;
            secondindexBtn.BackColor = Color.FromArgb(100, 99, 103);
            secondindexBtn.Cursor = Cursors.Hand;
            secondindexBtn.FlatAppearance.BorderSize = 0;
            secondindexBtn.FlatStyle = FlatStyle.Flat;
            secondindexBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            secondindexBtn.ForeColor = Color.White;
            secondindexBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            secondindexBtn.IconColor = Color.White;
            secondindexBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            secondindexBtn.IconSize = 24;
            secondindexBtn.Location = new Point(140, 3);
            secondindexBtn.Name = "secondindexBtn";
            secondindexBtn.Size = new Size(36, 30);
            secondindexBtn.TabIndex = 332;
            secondindexBtn.Text = "3";
            secondindexBtn.UseVisualStyleBackColor = false;
            secondindexBtn.Click += secondindexBtn_Click;
            // 
            // threeindexBtn
            // 
            threeindexBtn.AllowDrop = true;
            threeindexBtn.AutoSize = true;
            threeindexBtn.BackColor = Color.FromArgb(100, 99, 103);
            threeindexBtn.Cursor = Cursors.Hand;
            threeindexBtn.FlatAppearance.BorderSize = 0;
            threeindexBtn.FlatStyle = FlatStyle.Flat;
            threeindexBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            threeindexBtn.ForeColor = Color.White;
            threeindexBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            threeindexBtn.IconColor = Color.White;
            threeindexBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            threeindexBtn.IconSize = 24;
            threeindexBtn.Location = new Point(182, 3);
            threeindexBtn.Name = "threeindexBtn";
            threeindexBtn.Size = new Size(30, 30);
            threeindexBtn.TabIndex = 333;
            threeindexBtn.Text = "4";
            threeindexBtn.UseVisualStyleBackColor = false;
            threeindexBtn.Click += threeindexBtn_Click;
            // 
            // threedotafterLB
            // 
            threedotafterLB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            threedotafterLB.ForeColor = Color.White;
            threedotafterLB.Location = new Point(218, 0);
            threedotafterLB.Name = "threedotafterLB";
            threedotafterLB.Size = new Size(23, 27);
            threedotafterLB.TabIndex = 334;
            threedotafterLB.Text = "...";
            threedotafterLB.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lastBtn
            // 
            lastBtn.AllowDrop = true;
            lastBtn.AutoSize = true;
            lastBtn.BackColor = Color.FromArgb(100, 99, 103);
            lastBtn.Cursor = Cursors.Hand;
            lastBtn.FlatAppearance.BorderSize = 0;
            lastBtn.FlatStyle = FlatStyle.Flat;
            lastBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastBtn.ForeColor = Color.White;
            lastBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            lastBtn.IconColor = Color.White;
            lastBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lastBtn.IconSize = 24;
            lastBtn.Location = new Point(247, 3);
            lastBtn.Name = "lastBtn";
            lastBtn.Size = new Size(30, 30);
            lastBtn.TabIndex = 335;
            lastBtn.UseVisualStyleBackColor = false;
            lastBtn.Click += lastBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.AllowDrop = true;
            nextBtn.AutoSize = true;
            nextBtn.BackColor = Color.FromArgb(100, 99, 103);
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.FlatAppearance.BorderSize = 0;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            nextBtn.IconColor = Color.White;
            nextBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nextBtn.IconSize = 24;
            nextBtn.ImageAlign = ContentAlignment.MiddleLeft;
            nextBtn.Location = new Point(283, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(30, 30);
            nextBtn.TabIndex = 336;
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // ListAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 99, 103);
            ClientSize = new Size(1300, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(filterRole);
            Controls.Add(filterPhoneNumber);
            Controls.Add(filterEmail);
            Controls.Add(refreshBtn);
            Controls.Add(filterUsername);
            Controls.Add(xemBtn);
            Controls.Add(createButton);
            Controls.Add(dtAccount);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListAccount";
            Text = "Form1";
            Load += ListAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtAccount).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label4;
        private Panel panel1;
        private DataGridView dtAccount;
        private FontAwesome.Sharp.IconButton createButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewButtonColumn Column2;
        private DataGridViewButtonColumn Column8;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private TextBox filterUsername;
        private FontAwesome.Sharp.IconButton xemBtn;
        private TextBox filterEmail;
        private TextBox filterPhoneNumber;
        private TextBox filterRole;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton previousBtn;
        private FontAwesome.Sharp.IconButton firstBtn;
        private Label threedotbeforeBtn;
        private FontAwesome.Sharp.IconButton firstindexBtn;
        private FontAwesome.Sharp.IconButton secondindexBtn;
        private FontAwesome.Sharp.IconButton threeindexBtn;
        private Label threedotafterLB;
        private FontAwesome.Sharp.IconButton lastBtn;
        private FontAwesome.Sharp.IconButton nextBtn;
    }
}