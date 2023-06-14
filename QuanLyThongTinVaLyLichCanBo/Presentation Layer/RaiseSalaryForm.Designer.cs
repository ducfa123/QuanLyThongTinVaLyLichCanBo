namespace QuanLyThongTinVaLyLichCanBo
{
    partial class RaiseSalaryForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            dtLuong = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            refreshBtn = new FontAwesome.Sharp.IconButton();
            phucapkhacFilter = new ComboBox();
            filterID = new TextBox();
            filterHoTen = new TextBox();
            xemBtn = new FontAwesome.Sharp.IconButton();
            xuatexcelBtn = new FontAwesome.Sharp.IconButton();
            tongluongFilter = new ComboBox();
            loaingachFilter = new ComboBox();
            bacluongFilter = new ComboBox();
            hesoFilter = new ComboBox();
            phucapchuvuFilter = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dtLuong).BeginInit();
            flowLayoutPanel1.SuspendLayout();
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
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 20);
            label4.Name = "label4";
            label4.Size = new Size(249, 45);
            label4.TabIndex = 6;
            label4.Text = "Quản lý lương ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dtLuong
            // 
            dtLuong.AllowUserToAddRows = false;
            dtLuong.AllowUserToDeleteRows = false;
            dtLuong.AllowUserToResizeColumns = false;
            dtLuong.AllowUserToResizeRows = false;
            dtLuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtLuong.BackgroundColor = Color.White;
            dtLuong.BorderStyle = BorderStyle.None;
            dtLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtLuong.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column9, Column4, Column5, Column6, Column7, Column8 });
            dtLuong.GridColor = Color.White;
            dtLuong.Location = new Point(63, 229);
            dtLuong.MultiSelect = false;
            dtLuong.Name = "dtLuong";
            dtLuong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtLuong.RowHeadersVisible = false;
            dtLuong.RowHeadersWidth = 51;
            dtLuong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtLuong.RowTemplate.Height = 29;
            dtLuong.ShowEditingIcon = false;
            dtLuong.Size = new Size(1187, 424);
            dtLuong.TabIndex = 5;
            dtLuong.CellClick += dtLuong_CellClick;
            dtLuong.CellContentClick += dtLuong_CellContentClick;
            dtLuong.CellFormatting += dtLuong_CellFormatting;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaCanBo";
            Column1.FillWeight = 42.77939F;
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
            Column2.FillWeight = 153.2F;
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NgachCongChuc";
            Column3.FillWeight = 109.6898F;
            Column3.HeaderText = "Loại nghạch";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "BacLuong";
            Column9.FillWeight = 102.0286F;
            Column9.HeaderText = "Bậc lương";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "FormattedPrice";
            Column4.FillWeight = 59.61891F;
            Column4.HeaderText = "Hệ số";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PhuCapChucVu";
            Column5.FillWeight = 108.1708F;
            Column5.HeaderText = "Phụ cấp chức vụ (vnd)";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "PhuCapKhac";
            Column6.FillWeight = 108.1708F;
            Column6.HeaderText = "Phụ cấp khác (vnd)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TongLuong";
            Column7.FillWeight = 99.99685F;
            Column7.HeaderText = "Tổng lương (vnd)";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(117, 159, 188);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(117, 159, 188);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Column8.DefaultCellStyle = dataGridViewCellStyle2;
            Column8.FillWeight = 108.1708F;
            Column8.FlatStyle = FlatStyle.Flat;
            Column8.HeaderText = "";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "Xem";
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
            refreshBtn.Location = new Point(1200, 92);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(46, 46);
            refreshBtn.TabIndex = 301;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // phucapkhacFilter
            // 
            phucapkhacFilter.BackColor = Color.LightGray;
            phucapkhacFilter.FlatStyle = FlatStyle.Flat;
            phucapkhacFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phucapkhacFilter.ForeColor = Color.Black;
            phucapkhacFilter.FormattingEnabled = true;
            phucapkhacFilter.Items.AddRange(new object[] { "Từ cao đến thấp", "Từ thấp đến cao" });
            phucapkhacFilter.Location = new Point(835, 188);
            phucapkhacFilter.Name = "phucapkhacFilter";
            phucapkhacFilter.Size = new Size(109, 28);
            phucapkhacFilter.TabIndex = 299;
            phucapkhacFilter.Text = "Chọn";
            phucapkhacFilter.Visible = false;
            phucapkhacFilter.SelectedIndexChanged += phucapkhacFilter_SelectedIndexChanged;
            // 
            // filterID
            // 
            filterID.Location = new Point(63, 189);
            filterID.Name = "filterID";
            filterID.PlaceholderText = "ID";
            filterID.Size = new Size(55, 27);
            filterID.TabIndex = 294;
            filterID.Visible = false;
            filterID.TextChanged += filterID_TextChanged;
            // 
            // filterHoTen
            // 
            filterHoTen.Location = new Point(124, 189);
            filterHoTen.Name = "filterHoTen";
            filterHoTen.PlaceholderText = "Họ Tên";
            filterHoTen.Size = new Size(170, 27);
            filterHoTen.TabIndex = 293;
            filterHoTen.Visible = false;
            filterHoTen.Click += filterHoTen_Click;
            filterHoTen.TextChanged += filterHoTen_TextChanged;
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
            xemBtn.Location = new Point(916, 92);
            xemBtn.Name = "xemBtn";
            xemBtn.Size = new Size(102, 46);
            xemBtn.TabIndex = 288;
            xemBtn.Text = "     Lọc";
            xemBtn.UseVisualStyleBackColor = false;
            xemBtn.Click += xemBtn_Click;
            // 
            // xuatexcelBtn
            // 
            xuatexcelBtn.AllowDrop = true;
            xuatexcelBtn.BackColor = Color.Green;
            xuatexcelBtn.Cursor = Cursors.Hand;
            xuatexcelBtn.FlatAppearance.BorderSize = 0;
            xuatexcelBtn.FlatStyle = FlatStyle.Flat;
            xuatexcelBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xuatexcelBtn.ForeColor = Color.White;
            xuatexcelBtn.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            xuatexcelBtn.IconColor = Color.White;
            xuatexcelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatexcelBtn.IconSize = 32;
            xuatexcelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatexcelBtn.Location = new Point(1034, 92);
            xuatexcelBtn.Name = "xuatexcelBtn";
            xuatexcelBtn.Size = new Size(160, 46);
            xuatexcelBtn.TabIndex = 287;
            xuatexcelBtn.Text = "     Xuất báo cáo";
            xuatexcelBtn.UseVisualStyleBackColor = false;
            xuatexcelBtn.Click += xuatexcelBtn_Click;
            // 
            // tongluongFilter
            // 
            tongluongFilter.BackColor = Color.LightGray;
            tongluongFilter.FlatStyle = FlatStyle.Flat;
            tongluongFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tongluongFilter.ForeColor = Color.Black;
            tongluongFilter.FormattingEnabled = true;
            tongluongFilter.Items.AddRange(new object[] { "Từ cao đến thấp", "Từ thấp đến cao" });
            tongluongFilter.Location = new Point(979, 188);
            tongluongFilter.Name = "tongluongFilter";
            tongluongFilter.Size = new Size(109, 28);
            tongluongFilter.TabIndex = 302;
            tongluongFilter.Text = "Chọn";
            tongluongFilter.Visible = false;
            tongluongFilter.SelectedIndexChanged += tongluongFilter_SelectedIndexChanged;
            // 
            // loaingachFilter
            // 
            loaingachFilter.BackColor = Color.LightGray;
            loaingachFilter.FlatStyle = FlatStyle.Flat;
            loaingachFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loaingachFilter.ForeColor = Color.Black;
            loaingachFilter.FormattingEnabled = true;
            loaingachFilter.Items.AddRange(new object[] { "Công chức A3 (A3.1)", "Công chức A3 (A3.2)", "Công chức A2 (A2.1)", "Công chức A2 (A2.2)", "Công chức A1", "Công chức A0", "Công chức B", "Công chức C", "Viên chức A3", "Viên chức A2", "Viên chức A1", "Viên chức A0", "Viên chức B" });
            loaingachFilter.Location = new Point(331, 189);
            loaingachFilter.Name = "loaingachFilter";
            loaingachFilter.Size = new Size(139, 28);
            loaingachFilter.TabIndex = 305;
            loaingachFilter.Text = "Chọn";
            loaingachFilter.Visible = false;
            loaingachFilter.SelectedIndexChanged += loaingachFilter_SelectedIndexChanged;
            // 
            // bacluongFilter
            // 
            bacluongFilter.BackColor = Color.LightGray;
            bacluongFilter.FlatStyle = FlatStyle.Flat;
            bacluongFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bacluongFilter.ForeColor = Color.Black;
            bacluongFilter.FormattingEnabled = true;
            bacluongFilter.Items.AddRange(new object[] { "Từ cao đến thấp", "Từ thấp đến cao" });
            bacluongFilter.Location = new Point(476, 188);
            bacluongFilter.Name = "bacluongFilter";
            bacluongFilter.Size = new Size(109, 28);
            bacluongFilter.TabIndex = 306;
            bacluongFilter.Text = "Chọn";
            bacluongFilter.Visible = false;
            bacluongFilter.SelectedIndexChanged += bacluongFilter_SelectedIndexChanged;
            // 
            // hesoFilter
            // 
            hesoFilter.BackColor = Color.LightGray;
            hesoFilter.FlatStyle = FlatStyle.Flat;
            hesoFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hesoFilter.ForeColor = Color.Black;
            hesoFilter.FormattingEnabled = true;
            hesoFilter.Items.AddRange(new object[] { "Từ cao đến thấp", "Từ thấp đến cao" });
            hesoFilter.Location = new Point(610, 188);
            hesoFilter.Name = "hesoFilter";
            hesoFilter.Size = new Size(72, 28);
            hesoFilter.TabIndex = 307;
            hesoFilter.Text = "Chọn";
            hesoFilter.Visible = false;
            hesoFilter.SelectedIndexChanged += hesoFilter_SelectedIndexChanged;
            // 
            // phucapchuvuFilter
            // 
            phucapchuvuFilter.BackColor = Color.LightGray;
            phucapchuvuFilter.FlatStyle = FlatStyle.Flat;
            phucapchuvuFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phucapchuvuFilter.ForeColor = Color.Black;
            phucapchuvuFilter.FormattingEnabled = true;
            phucapchuvuFilter.Items.AddRange(new object[] { "Từ cao đến thấp", "Từ thấp đến cao" });
            phucapchuvuFilter.Location = new Point(697, 188);
            phucapchuvuFilter.Name = "phucapchuvuFilter";
            phucapchuvuFilter.Size = new Size(109, 28);
            phucapchuvuFilter.TabIndex = 308;
            phucapchuvuFilter.Text = "Chọn";
            phucapchuvuFilter.Visible = false;
            phucapchuvuFilter.SelectedIndexChanged += phucapchuvuFilter_SelectedIndexChanged;
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
            flowLayoutPanel1.TabIndex = 339;
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
            // RaiseSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 99, 103);
            ClientSize = new Size(1300, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(phucapchuvuFilter);
            Controls.Add(hesoFilter);
            Controls.Add(bacluongFilter);
            Controls.Add(loaingachFilter);
            Controls.Add(tongluongFilter);
            Controls.Add(refreshBtn);
            Controls.Add(phucapkhacFilter);
            Controls.Add(filterID);
            Controls.Add(filterHoTen);
            Controls.Add(xemBtn);
            Controls.Add(xuatexcelBtn);
            Controls.Add(panel1);
            Controls.Add(dtLuong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RaiseSalary";
            Text = "RaiseSalary";
            Load += RaiseSalary_Load;
            Shown += RaiseSalary_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtLuong).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private DataGridView dtLuong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
        private FontAwesome.Sharp.IconButton refreshBtn;
        private ComboBox phucapkhacFilter;


        private ComboBox filterHinhThuc;
        private TextBox filterID;
        private TextBox filterHoTen;
        private ComboBox comboBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton xemBtn;
        private FontAwesome.Sharp.IconButton xuatexcelBtn;
        private ComboBox tongluongFilter;


        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox loaingachFilter;
        private ComboBox bacluongFilter;
        private ComboBox hesoFilter;
        private ComboBox phucapchuvuFilter;
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