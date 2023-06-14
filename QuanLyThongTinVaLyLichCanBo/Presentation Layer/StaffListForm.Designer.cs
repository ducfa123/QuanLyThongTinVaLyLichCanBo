namespace QuanLyThongTinVaLyLichCanBo
{
    partial class StaffListForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            dtCanbo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewButtonColumn();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            xemBtn = new FontAwesome.Sharp.IconButton();
            filterDonVi = new TextBox();
            filterChucVu = new TextBox();
            filterGioiTinh = new ComboBox();
            filterNgaySinh = new TextBox();
            filterID = new TextBox();
            filterHoTen = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)dtCanbo).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 82);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 20);
            label4.Name = "label4";
            label4.Size = new Size(292, 45);
            label4.TabIndex = 6;
            label4.Text = "Danh sách cán bộ";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // dtCanbo
            // 
            dtCanbo.AllowUserToAddRows = false;
            dtCanbo.AllowUserToDeleteRows = false;
            dtCanbo.AllowUserToResizeColumns = false;
            dtCanbo.AllowUserToResizeRows = false;
            dtCanbo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtCanbo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCanbo.BackgroundColor = Color.White;
            dtCanbo.BorderStyle = BorderStyle.None;
            dtCanbo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCanbo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dtCanbo.GridColor = Color.White;
            dtCanbo.Location = new Point(63, 229);
            dtCanbo.MultiSelect = false;
            dtCanbo.Name = "dtCanbo";
            dtCanbo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtCanbo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtCanbo.RowHeadersVisible = false;
            dtCanbo.RowHeadersWidth = 51;
            dtCanbo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtCanbo.RowTemplate.Height = 29;
            dtCanbo.ShowEditingIcon = false;
            dtCanbo.Size = new Size(1187, 424);
            dtCanbo.TabIndex = 0;
            dtCanbo.CellClick += dtCanbo_CellClick;
            dtCanbo.CellContentClick += dtCanbo_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaCanBo";
            Column1.FillWeight = 42.78074F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTen";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.FillWeight = 108.1742F;
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "GioiTinh";
            Column3.FillWeight = 108.1742F;
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "NgaySinh";
            Column4.FillWeight = 108.1742F;
            Column4.HeaderText = "Ngày sinh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ChucVu";
            Column5.FillWeight = 108.1742F;
            Column5.HeaderText = "Chức vụ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CoQuanTuyenDung";
            Column6.FillWeight = 108.1742F;
            Column6.HeaderText = "Đơn vị";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Column7.DefaultCellStyle = dataGridViewCellStyle2;
            Column7.FillWeight = 108.1742F;
            Column7.FlatStyle = FlatStyle.Flat;
            Column7.HeaderText = "";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Sửa";
            Column7.UseColumnTextForButtonValue = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Red;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Column8.DefaultCellStyle = dataGridViewCellStyle3;
            Column8.FillWeight = 108.1742F;
            Column8.FlatStyle = FlatStyle.Flat;
            Column8.HeaderText = "";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "Xóa";
            Column8.UseColumnTextForButtonValue = true;
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
            refreshBtn.Location = new Point(1204, 101);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(46, 46);
            refreshBtn.TabIndex = 314;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
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
            xemBtn.Location = new Point(1063, 101);
            xemBtn.Name = "xemBtn";
            xemBtn.Size = new Size(102, 46);
            xemBtn.TabIndex = 310;
            xemBtn.Text = "     Lọc";
            xemBtn.UseVisualStyleBackColor = false;
            xemBtn.Click += xemBtn_Click;
            // 
            // filterDonVi
            // 
            filterDonVi.Location = new Point(775, 188);
            filterDonVi.Name = "filterDonVi";
            filterDonVi.PlaceholderText = "Đơn vị";
            filterDonVi.Size = new Size(121, 27);
            filterDonVi.TabIndex = 320;
            filterDonVi.Visible = false;
            filterDonVi.Click += filterID_Click;
            filterDonVi.TextChanged += filterDonVi_TextChanged;
            // 
            // filterChucVu
            // 
            filterChucVu.Location = new Point(617, 188);
            filterChucVu.Name = "filterChucVu";
            filterChucVu.PlaceholderText = "Chức vụ";
            filterChucVu.Size = new Size(121, 27);
            filterChucVu.TabIndex = 319;
            filterChucVu.Visible = false;
            filterChucVu.Click += filterID_Click;
            filterChucVu.TextChanged += filterChucVu_TextChanged;
            // 
            // filterGioiTinh
            // 
            filterGioiTinh.BackColor = Color.LightGray;
            filterGioiTinh.FlatStyle = FlatStyle.Flat;
            filterGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterGioiTinh.ForeColor = Color.Black;
            filterGioiTinh.FormattingEnabled = true;
            filterGioiTinh.Items.AddRange(new object[] { "Chọn", "Nam", "Nữ", "Khác" });
            filterGioiTinh.Location = new Point(295, 188);
            filterGioiTinh.Name = "filterGioiTinh";
            filterGioiTinh.Size = new Size(135, 28);
            filterGioiTinh.TabIndex = 318;
            filterGioiTinh.Text = "Giới tính";
            filterGioiTinh.Visible = false;
            filterGioiTinh.SelectedIndexChanged += filterGioiTinh_SelectedIndexChanged;
            filterGioiTinh.Click += filterID_Click;
            // 
            // filterNgaySinh
            // 
            filterNgaySinh.Location = new Point(456, 188);
            filterNgaySinh.Name = "filterNgaySinh";
            filterNgaySinh.PlaceholderText = "DD/MM/YYYY";
            filterNgaySinh.Size = new Size(121, 27);
            filterNgaySinh.TabIndex = 317;
            filterNgaySinh.Visible = false;
            filterNgaySinh.Click += filterID_Click;
            filterNgaySinh.TextChanged += filterNgaySinh_TextChanged;
            // 
            // filterID
            // 
            filterID.Location = new Point(63, 189);
            filterID.Name = "filterID";
            filterID.PlaceholderText = "ID";
            filterID.Size = new Size(62, 27);
            filterID.TabIndex = 316;
            filterID.Visible = false;
            filterID.TextChanged += filterID_TextChanged;
            // 
            // filterHoTen
            // 
            filterHoTen.Location = new Point(131, 189);
            filterHoTen.Name = "filterHoTen";
            filterHoTen.PlaceholderText = "Họ Tên";
            filterHoTen.Size = new Size(121, 27);
            filterHoTen.TabIndex = 315;
            filterHoTen.Visible = false;
            filterHoTen.Click += filterID_Click;
            filterHoTen.TextChanged += filterHoTen_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(previousBtn);
            flowLayoutPanel2.Controls.Add(firstBtn);
            flowLayoutPanel2.Controls.Add(threedotbeforeBtn);
            flowLayoutPanel2.Controls.Add(firstindexBtn);
            flowLayoutPanel2.Controls.Add(secondindexBtn);
            flowLayoutPanel2.Controls.Add(threeindexBtn);
            flowLayoutPanel2.Controls.Add(threedotafterLB);
            flowLayoutPanel2.Controls.Add(lastBtn);
            flowLayoutPanel2.Controls.Add(nextBtn);
            flowLayoutPanel2.Location = new Point(967, 665);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(321, 36);
            flowLayoutPanel2.TabIndex = 339;
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
            previousBtn.TabIndex = 331;
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
            firstBtn.TabIndex = 334;
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
            threedotbeforeBtn.TabIndex = 339;
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
            firstindexBtn.TabIndex = 340;
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
            secondindexBtn.TabIndex = 341;
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
            threeindexBtn.TabIndex = 342;
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
            threedotafterLB.TabIndex = 343;
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
            lastBtn.TabIndex = 344;
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
            nextBtn.TabIndex = 345;
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // ListCanbo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 99, 103);
            ClientSize = new Size(1300, 720);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(filterDonVi);
            Controls.Add(filterChucVu);
            Controls.Add(filterGioiTinh);
            Controls.Add(filterNgaySinh);
            Controls.Add(filterID);
            Controls.Add(filterHoTen);
            Controls.Add(refreshBtn);
            Controls.Add(xemBtn);
            Controls.Add(dtCanbo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCanbo";
            Text = "Form1";
            Load += ListCanbo_Load;
            Shown += ListCanbo_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtCanbo).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label4;
        private DataGridView dtCanbo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column8;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private FontAwesome.Sharp.IconButton xemBtn;
        private TextBox filterDonVi;
        private TextBox filterChucVu;
        private ComboBox filterGioiTinh;
        private TextBox filterNgaySinh;
        private TextBox filterID;
        private TextBox filterHoTen;
        private FlowLayoutPanel flowLayoutPanel2;
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