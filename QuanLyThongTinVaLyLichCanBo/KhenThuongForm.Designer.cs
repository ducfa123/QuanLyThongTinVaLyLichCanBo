namespace QuanLyThongTinVaLyLichCanBo
{
    partial class KhenThuongForm
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            dtBaocao = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Nam = new DataGridViewTextBoxColumn();
            HinhThuc = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            createButton = new FontAwesome.Sharp.IconButton();
            xemBtn = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            namIn = new DateTimePicker();
            pickyearCBB = new ComboBox();
            filterHoTen = new TextBox();
            filterID = new TextBox();
            filterNgaySinh = new TextBox();
            filterGioiTinh = new ComboBox();
            filterChucVu = new TextBox();
            filterDonVi = new TextBox();
            filterHinhThuc = new ComboBox();
            filterNoiDung = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            filterBtn = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)dtBaocao).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MaCanBo";
            Column1.FillWeight = 42.77939F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 54;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTen";
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle13;
            Column2.FillWeight = 153.2F;
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 191;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NgaySinh";
            Column3.FillWeight = 109.6898F;
            Column3.HeaderText = "Ngày sinh";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 138;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "GioiTinh";
            Column9.FillWeight = 102.0286F;
            Column9.HeaderText = "Giới tính";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 128;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "CoQuanTuyenDung";
            Column4.FillWeight = 59.61891F;
            Column4.HeaderText = "Đơn vị";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 74;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ChucVu";
            Column5.FillWeight = 108.1708F;
            Column5.HeaderText = "Chức Vụ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 136;
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
            label4.Size = new Size(142, 45);
            label4.TabIndex = 6;
            label4.Text = "Báo cáo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // dtBaocao
            // 
            dtBaocao.AllowUserToAddRows = false;
            dtBaocao.AllowUserToDeleteRows = false;
            dtBaocao.AllowUserToResizeColumns = false;
            dtBaocao.AllowUserToResizeRows = false;
            dtBaocao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtBaocao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtBaocao.BackgroundColor = Color.White;
            dtBaocao.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dtBaocao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dtBaocao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtBaocao.Columns.AddRange(new DataGridViewColumn[] { Column8, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, Column6, Nam, HinhThuc, NoiDung, Column7 });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dtBaocao.DefaultCellStyle = dataGridViewCellStyle17;
            dtBaocao.GridColor = Color.White;
            dtBaocao.Location = new Point(63, 229);
            dtBaocao.MultiSelect = false;
            dtBaocao.Name = "dtBaocao";
            dtBaocao.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dtBaocao.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dtBaocao.RowHeadersVisible = false;
            dtBaocao.RowHeadersWidth = 51;
            dtBaocao.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtBaocao.RowTemplate.Height = 29;
            dtBaocao.ShowEditingIcon = false;
            dtBaocao.Size = new Size(1187, 424);
            dtBaocao.TabIndex = 5;
            dtBaocao.CellClick += dtCanbo_CellClick;
            dtBaocao.CellContentClick += dtCanbo_CellContentClick_1;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MaCanBo";
            Column8.FillWeight = 56.09867F;
            Column8.HeaderText = "ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn2.FillWeight = 113.178169F;
            dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NgaySinh";
            dataGridViewTextBoxColumn4.FillWeight = 113.178169F;
            dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "GioiTinh";
            dataGridViewTextBoxColumn3.FillWeight = 113.178169F;
            dataGridViewTextBoxColumn3.HeaderText = "Giới tính";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "ChucVu";
            dataGridViewTextBoxColumn5.FillWeight = 113.178169F;
            dataGridViewTextBoxColumn5.HeaderText = "Chức vụ";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CoQuanTuyenDung";
            Column6.FillWeight = 113.178169F;
            Column6.HeaderText = "Đơn vị";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Nam
            // 
            Nam.DataPropertyName = "Nam";
            Nam.FillWeight = 104.625839F;
            Nam.HeaderText = "Năm";
            Nam.MinimumWidth = 6;
            Nam.Name = "Nam";
            Nam.ReadOnly = true;
            // 
            // HinhThuc
            // 
            HinhThuc.DataPropertyName = "HinhThuc";
            HinhThuc.FillWeight = 104.625839F;
            HinhThuc.HeaderText = "Hình thức";
            HinhThuc.MinimumWidth = 6;
            HinhThuc.Name = "HinhThuc";
            HinhThuc.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.FillWeight = 104.625839F;
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            Column7.DefaultCellStyle = dataGridViewCellStyle16;
            Column7.FillWeight = 113.178169F;
            Column7.FlatStyle = FlatStyle.Flat;
            Column7.HeaderText = "";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Cập nhật";
            Column7.UseColumnTextForButtonValue = true;
            // 
            // createButton
            // 
            createButton.AllowDrop = true;
            createButton.BackColor = Color.Green;
            createButton.Cursor = Cursors.Hand;
            createButton.FlatAppearance.BorderSize = 0;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.ForeColor = Color.White;
            createButton.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            createButton.IconColor = Color.White;
            createButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createButton.IconSize = 32;
            createButton.ImageAlign = ContentAlignment.MiddleLeft;
            createButton.Location = new Point(1036, 102);
            createButton.Name = "createButton";
            createButton.Size = new Size(160, 46);
            createButton.TabIndex = 11;
            createButton.Text = "     Xuất báo cáo";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
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
            xemBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            xemBtn.IconColor = Color.White;
            xemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xemBtn.IconSize = 32;
            xemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            xemBtn.Location = new Point(923, 101);
            xemBtn.Name = "xemBtn";
            xemBtn.Size = new Size(102, 46);
            xemBtn.TabIndex = 12;
            xemBtn.Text = "     Xem";
            xemBtn.UseVisualStyleBackColor = false;
            xemBtn.Click += xemBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(572, 114);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 271;
            label3.Text = "Năm:";
            label3.Click += label3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightGray;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Danh sách cán bộ đạt danh hiệu thi đua", "Danh sách cán bộ được khen thưởng", "Danh sách cán bộ bị kỷ luật", "Danh sách đánh giá cán bô" });
            comboBox1.Location = new Point(199, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 39);
            comboBox1.TabIndex = 274;
            comboBox1.Text = "Chọn";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 114);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 273;
            label2.Text = "Tên báo cáo:";
            // 
            // namIn
            // 
            namIn.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            namIn.CalendarMonthBackground = Color.LightGray;
            namIn.Cursor = Cursors.Hand;
            namIn.CustomFormat = "yyyy";
            namIn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            namIn.Format = DateTimePickerFormat.Custom;
            namIn.Location = new Point(641, 55);
            namIn.Name = "namIn";
            namIn.Size = new Size(221, 39);
            namIn.TabIndex = 275;
            namIn.Visible = false;
            // 
            // pickyearCBB
            // 
            pickyearCBB.BackColor = Color.LightGray;
            pickyearCBB.FlatStyle = FlatStyle.Flat;
            pickyearCBB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pickyearCBB.ForeColor = Color.Black;
            pickyearCBB.FormattingEnabled = true;
            pickyearCBB.Location = new Point(640, 103);
            pickyearCBB.Name = "pickyearCBB";
            pickyearCBB.Size = new Size(193, 39);
            pickyearCBB.TabIndex = 276;
            pickyearCBB.Text = "Chọn";
            pickyearCBB.SelectedIndexChanged += pickyearCBB_SelectedIndexChanged;
            // 
            // filterHoTen
            // 
            filterHoTen.Location = new Point(131, 189);
            filterHoTen.Name = "filterHoTen";
            filterHoTen.PlaceholderText = "Họ Tên";
            filterHoTen.Size = new Size(121, 27);
            filterHoTen.TabIndex = 277;
            filterHoTen.Visible = false;
            filterHoTen.Click += filterDonVi_Click;
            filterHoTen.TextChanged += textBox1_TextChanged;
            // 
            // filterID
            // 
            filterID.Location = new Point(63, 189);
            filterID.Name = "filterID";
            filterID.PlaceholderText = "ID";
            filterID.Size = new Size(62, 27);
            filterID.TabIndex = 278;
            filterID.Visible = false;
            filterID.TextChanged += filterID_TextChanged;
            // 
            // filterNgaySinh
            // 
            filterNgaySinh.Location = new Point(258, 189);
            filterNgaySinh.Name = "filterNgaySinh";
            filterNgaySinh.PlaceholderText = "DD/MM/YYYY";
            filterNgaySinh.Size = new Size(121, 27);
            filterNgaySinh.TabIndex = 279;
            filterNgaySinh.Visible = false;
            filterNgaySinh.Click += filterDonVi_Click;
            filterNgaySinh.TextChanged += filterNgaySinh_TextChanged;
            // 
            // filterGioiTinh
            // 
            filterGioiTinh.BackColor = Color.LightGray;
            filterGioiTinh.FlatStyle = FlatStyle.Flat;
            filterGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterGioiTinh.ForeColor = Color.Black;
            filterGioiTinh.FormattingEnabled = true;
            filterGioiTinh.Items.AddRange(new object[] { "Chọn", "Nam", "Nữ", "Khác" });
            filterGioiTinh.Location = new Point(394, 188);
            filterGioiTinh.Name = "filterGioiTinh";
            filterGioiTinh.Size = new Size(109, 28);
            filterGioiTinh.TabIndex = 280;
            filterGioiTinh.Text = "Giới tính";
            filterGioiTinh.Visible = false;
            filterGioiTinh.SelectedIndexChanged += filterGioiTinh_SelectedIndexChanged;
            // 
            // filterChucVu
            // 
            filterChucVu.Location = new Point(513, 188);
            filterChucVu.Name = "filterChucVu";
            filterChucVu.PlaceholderText = "Chức vụ";
            filterChucVu.Size = new Size(121, 27);
            filterChucVu.TabIndex = 281;
            filterChucVu.Visible = false;
            filterChucVu.Click += filterDonVi_Click;
            filterChucVu.TextChanged += filterChucVu_TextChanged;
            // 
            // filterDonVi
            // 
            filterDonVi.Location = new Point(640, 188);
            filterDonVi.Name = "filterDonVi";
            filterDonVi.PlaceholderText = "Đơn vị";
            filterDonVi.Size = new Size(121, 27);
            filterDonVi.TabIndex = 282;
            filterDonVi.Visible = false;
            filterDonVi.Click += filterDonVi_Click;
            filterDonVi.TextChanged += filterDonVi_TextChanged;
            // 
            // filterHinhThuc
            // 
            filterHinhThuc.BackColor = Color.LightGray;
            filterHinhThuc.FlatStyle = FlatStyle.Flat;
            filterHinhThuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterHinhThuc.ForeColor = Color.Black;
            filterHinhThuc.FormattingEnabled = true;
            filterHinhThuc.Items.AddRange(new object[] { "Giấy khen của đơn vị", "Giấy khen của Bộ", "Bằng khen của UBND tỉnh", "Bằng khen của Bộ", "Bằng khen của Thủ tướng CP", "Huân chương lao động hạng nhất", "Huân chương lao động hạng nhì", "Huân chương lao động hạng ba" });
            filterHinhThuc.Location = new Point(893, 187);
            filterHinhThuc.Name = "filterHinhThuc";
            filterHinhThuc.Size = new Size(109, 28);
            filterHinhThuc.TabIndex = 284;
            filterHinhThuc.Text = "Chọn";
            filterHinhThuc.Visible = false;
            filterHinhThuc.SelectedIndexChanged += filterHinhThuc_SelectedIndexChanged;
            // 
            // filterNoiDung
            // 
            filterNoiDung.Location = new Point(1008, 187);
            filterNoiDung.Name = "filterNoiDung";
            filterNoiDung.PlaceholderText = "Nội dung";
            filterNoiDung.Size = new Size(106, 27);
            filterNoiDung.TabIndex = 285;
            filterNoiDung.Visible = false;
            filterNoiDung.Click += filterDonVi_Click;
            filterNoiDung.TextChanged += filterNoiDung_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.AllowDrop = true;
            iconButton1.BackColor = Color.LightGreen;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(1202, 102);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(46, 46);
            iconButton1.TabIndex = 286;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // filterBtn
            // 
            filterBtn.AllowDrop = true;
            filterBtn.BackColor = Color.DarkCyan;
            filterBtn.Cursor = Cursors.Hand;
            filterBtn.FlatAppearance.BorderSize = 0;
            filterBtn.FlatStyle = FlatStyle.Flat;
            filterBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterBtn.ForeColor = Color.White;
            filterBtn.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filterBtn.IconColor = Color.White;
            filterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filterBtn.IconSize = 32;
            filterBtn.ImageAlign = ContentAlignment.MiddleLeft;
            filterBtn.Location = new Point(1148, 170);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(102, 46);
            filterBtn.TabIndex = 311;
            filterBtn.Text = "     Lọc";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
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
            flowLayoutPanel1.TabIndex = 321;
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
            previousBtn.TabIndex = 313;
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
            firstBtn.TabIndex = 316;
            firstBtn.Text = "1";
            firstBtn.UseVisualStyleBackColor = false;
            firstBtn.Click += filterBtn_Click;
            // 
            // threedotbeforeBtn
            // 
            threedotbeforeBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            threedotbeforeBtn.ForeColor = Color.White;
            threedotbeforeBtn.Location = new Point(75, 0);
            threedotbeforeBtn.Name = "threedotbeforeBtn";
            threedotbeforeBtn.Size = new Size(23, 27);
            threedotbeforeBtn.TabIndex = 321;
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
            firstindexBtn.TabIndex = 322;
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
            secondindexBtn.TabIndex = 323;
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
            threeindexBtn.TabIndex = 324;
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
            threedotafterLB.TabIndex = 325;
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
            lastBtn.TabIndex = 326;
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
            nextBtn.TabIndex = 327;
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // KhenThuongForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 99, 103);
            ClientSize = new Size(1300, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(filterBtn);
            Controls.Add(iconButton1);
            Controls.Add(filterNoiDung);
            Controls.Add(filterHinhThuc);
            Controls.Add(filterDonVi);
            Controls.Add(filterChucVu);
            Controls.Add(filterGioiTinh);
            Controls.Add(filterNgaySinh);
            Controls.Add(filterID);
            Controls.Add(filterHoTen);
            Controls.Add(pickyearCBB);
            Controls.Add(namIn);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(xemBtn);
            Controls.Add(createButton);
            Controls.Add(panel1);
            Controls.Add(dtBaocao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhenThuongForm";
            Text = "s";
            Load += KhenThuong_Load;
            Shown += KhenThuong_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtBaocao).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private DataGridView dtBaocao;
        private FontAwesome.Sharp.IconButton createButton;
        private FontAwesome.Sharp.IconButton xemBtn;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker namIn;
        private ComboBox pickyearCBB;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn HinhThuc;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewButtonColumn Column7;
        private TextBox filterHoTen;
        private TextBox filterID;
        private TextBox filterNgaySinh;
        private ComboBox filterGioiTinh;
        private TextBox filterChucVu;
        private TextBox filterNoiDung;
        private ComboBox filterHinhThuc;
        private TextBox filterDonVi;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton filterBtn;
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