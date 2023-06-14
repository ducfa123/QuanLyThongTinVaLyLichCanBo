namespace QuanLyThongTinVaLyLichCanBo
{
    partial class ChartForm
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
            dotuoiChart = new TabControl();
            tabGender = new TabPage();
            xuatPdfBtn1 = new FontAwesome.Sharp.IconButton();
            gioitinhChart = new LiveCharts.WinForms.PieChart();
            label4 = new Label();
            tabAge = new TabPage();
            xuatPdfBtn2 = new FontAwesome.Sharp.IconButton();
            tuoiChart = new LiveCharts.WinForms.CartesianChart();
            label1 = new Label();
            tabHeatlh = new TabPage();
            xuatpdfBtn3 = new FontAwesome.Sharp.IconButton();
            healchart = new LiveCharts.WinForms.CartesianChart();
            label2 = new Label();
            tabDanToc = new TabPage();
            xuatPdf4 = new FontAwesome.Sharp.IconButton();
            dantocChart = new LiveCharts.WinForms.CartesianChart();
            label3 = new Label();
            dotuoiChart.SuspendLayout();
            tabGender.SuspendLayout();
            tabAge.SuspendLayout();
            tabHeatlh.SuspendLayout();
            tabDanToc.SuspendLayout();
            SuspendLayout();
            // 
            // dotuoiChart
            // 
            dotuoiChart.Controls.Add(tabGender);
            dotuoiChart.Controls.Add(tabAge);
            dotuoiChart.Controls.Add(tabHeatlh);
            dotuoiChart.Controls.Add(tabDanToc);
            dotuoiChart.Dock = DockStyle.Fill;
            dotuoiChart.Location = new Point(0, 0);
            dotuoiChart.Name = "dotuoiChart";
            dotuoiChart.SelectedIndex = 0;
            dotuoiChart.Size = new Size(1300, 720);
            dotuoiChart.TabIndex = 0;
            dotuoiChart.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabGender
            // 
            tabGender.Controls.Add(xuatPdfBtn1);
            tabGender.Controls.Add(gioitinhChart);
            tabGender.Controls.Add(label4);
            tabGender.Location = new Point(4, 29);
            tabGender.Name = "tabGender";
            tabGender.Padding = new Padding(3);
            tabGender.Size = new Size(1292, 687);
            tabGender.TabIndex = 0;
            tabGender.Text = "Thống kê theo giới tính";
            tabGender.UseVisualStyleBackColor = true;
            // 
            // xuatPdfBtn1
            // 
            xuatPdfBtn1.AllowDrop = true;
            xuatPdfBtn1.BackColor = Color.DodgerBlue;
            xuatPdfBtn1.Cursor = Cursors.Hand;
            xuatPdfBtn1.FlatAppearance.BorderSize = 0;
            xuatPdfBtn1.FlatStyle = FlatStyle.Flat;
            xuatPdfBtn1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xuatPdfBtn1.ForeColor = Color.White;
            xuatPdfBtn1.IconChar = FontAwesome.Sharp.IconChar.Image;
            xuatPdfBtn1.IconColor = Color.White;
            xuatPdfBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatPdfBtn1.IconSize = 32;
            xuatPdfBtn1.ImageAlign = ContentAlignment.MiddleLeft;
            xuatPdfBtn1.Location = new Point(1013, 15);
            xuatPdfBtn1.Name = "xuatPdfBtn1";
            xuatPdfBtn1.Size = new Size(160, 46);
            xuatPdfBtn1.TabIndex = 308;
            xuatPdfBtn1.Text = "     Xuất hình ảnh";
            xuatPdfBtn1.UseVisualStyleBackColor = false;
            xuatPdfBtn1.Click += xuatPdfBtn1_Click;
            // 
            // gioitinhChart
            // 
            gioitinhChart.Location = new Point(40, 67);
            gioitinhChart.Name = "gioitinhChart";
            gioitinhChart.Size = new Size(1209, 584);
            gioitinhChart.TabIndex = 304;
            gioitinhChart.Text = "pieChart1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(1, 4);
            label4.Name = "label4";
            label4.Size = new Size(153, 45);
            label4.TabIndex = 303;
            label4.Text = "Giới tính";
            // 
            // tabAge
            // 
            tabAge.Controls.Add(xuatPdfBtn2);
            tabAge.Controls.Add(tuoiChart);
            tabAge.Controls.Add(label1);
            tabAge.Location = new Point(4, 29);
            tabAge.Name = "tabAge";
            tabAge.Padding = new Padding(3);
            tabAge.Size = new Size(1292, 687);
            tabAge.TabIndex = 1;
            tabAge.Text = "Thống kê theo độ tuổi";
            tabAge.UseVisualStyleBackColor = true;
            // 
            // xuatPdfBtn2
            // 
            xuatPdfBtn2.AllowDrop = true;
            xuatPdfBtn2.BackColor = Color.DodgerBlue;
            xuatPdfBtn2.Cursor = Cursors.Hand;
            xuatPdfBtn2.FlatAppearance.BorderSize = 0;
            xuatPdfBtn2.FlatStyle = FlatStyle.Flat;
            xuatPdfBtn2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xuatPdfBtn2.ForeColor = Color.White;
            xuatPdfBtn2.IconChar = FontAwesome.Sharp.IconChar.Image;
            xuatPdfBtn2.IconColor = Color.White;
            xuatPdfBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatPdfBtn2.IconSize = 32;
            xuatPdfBtn2.ImageAlign = ContentAlignment.MiddleLeft;
            xuatPdfBtn2.Location = new Point(1013, 15);
            xuatPdfBtn2.Name = "xuatPdfBtn2";
            xuatPdfBtn2.Size = new Size(160, 46);
            xuatPdfBtn2.TabIndex = 308;
            xuatPdfBtn2.Text = "     Xuất hình ảnh";
            xuatPdfBtn2.UseVisualStyleBackColor = false;
            xuatPdfBtn2.Click += xuatPdfBtn2_Click;
            // 
            // tuoiChart
            // 
            tuoiChart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tuoiChart.Location = new Point(40, 67);
            tuoiChart.Name = "tuoiChart";
            tuoiChart.Size = new Size(1209, 584);
            tuoiChart.TabIndex = 305;
            tuoiChart.Text = "cartesianChart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(1, 4);
            label1.Name = "label1";
            label1.Size = new Size(135, 45);
            label1.TabIndex = 304;
            label1.Text = "Độ tuổi";
            // 
            // tabHeatlh
            // 
            tabHeatlh.Controls.Add(xuatpdfBtn3);
            tabHeatlh.Controls.Add(healchart);
            tabHeatlh.Controls.Add(label2);
            tabHeatlh.Location = new Point(4, 29);
            tabHeatlh.Name = "tabHeatlh";
            tabHeatlh.Padding = new Padding(3);
            tabHeatlh.Size = new Size(1292, 687);
            tabHeatlh.TabIndex = 2;
            tabHeatlh.Text = "Thống kê theo sức khỏe";
            tabHeatlh.UseVisualStyleBackColor = true;
            // 
            // xuatpdfBtn3
            // 
            xuatpdfBtn3.AllowDrop = true;
            xuatpdfBtn3.BackColor = Color.DodgerBlue;
            xuatpdfBtn3.Cursor = Cursors.Hand;
            xuatpdfBtn3.FlatAppearance.BorderSize = 0;
            xuatpdfBtn3.FlatStyle = FlatStyle.Flat;
            xuatpdfBtn3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xuatpdfBtn3.ForeColor = Color.White;
            xuatpdfBtn3.IconChar = FontAwesome.Sharp.IconChar.Image;
            xuatpdfBtn3.IconColor = Color.White;
            xuatpdfBtn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatpdfBtn3.IconSize = 32;
            xuatpdfBtn3.ImageAlign = ContentAlignment.MiddleLeft;
            xuatpdfBtn3.Location = new Point(1013, 15);
            xuatpdfBtn3.Name = "xuatpdfBtn3";
            xuatpdfBtn3.Size = new Size(160, 46);
            xuatpdfBtn3.TabIndex = 307;
            xuatpdfBtn3.Text = "     Xuất hình ảnh";
            xuatpdfBtn3.UseVisualStyleBackColor = false;
            xuatpdfBtn3.Click += xuatPDF_Click;
            // 
            // healchart
            // 
            healchart.Location = new Point(40, 67);
            healchart.Name = "healchart";
            healchart.Size = new Size(1209, 584);
            healchart.TabIndex = 306;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(1, 4);
            label2.Name = "label2";
            label2.Size = new Size(162, 45);
            label2.TabIndex = 305;
            label2.Text = "Sức khỏe";
            // 
            // tabDanToc
            // 
            tabDanToc.Controls.Add(xuatPdf4);
            tabDanToc.Controls.Add(dantocChart);
            tabDanToc.Controls.Add(label3);
            tabDanToc.Location = new Point(4, 29);
            tabDanToc.Name = "tabDanToc";
            tabDanToc.Size = new Size(1292, 687);
            tabDanToc.TabIndex = 3;
            tabDanToc.Text = "Thống kê theo dân tộc";
            tabDanToc.UseVisualStyleBackColor = true;
            // 
            // xuatPdf4
            // 
            xuatPdf4.AllowDrop = true;
            xuatPdf4.BackColor = Color.DodgerBlue;
            xuatPdf4.Cursor = Cursors.Hand;
            xuatPdf4.FlatAppearance.BorderSize = 0;
            xuatPdf4.FlatStyle = FlatStyle.Flat;
            xuatPdf4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xuatPdf4.ForeColor = Color.White;
            xuatPdf4.IconChar = FontAwesome.Sharp.IconChar.Image;
            xuatPdf4.IconColor = Color.White;
            xuatPdf4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatPdf4.IconSize = 32;
            xuatPdf4.ImageAlign = ContentAlignment.MiddleLeft;
            xuatPdf4.Location = new Point(1013, 15);
            xuatPdf4.Name = "xuatPdf4";
            xuatPdf4.Size = new Size(160, 46);
            xuatPdf4.TabIndex = 308;
            xuatPdf4.Text = "     Xuất hình ảnh";
            xuatPdf4.UseVisualStyleBackColor = false;
            xuatPdf4.Click += xuatPdf4_Click;
            // 
            // dantocChart
            // 
            dantocChart.Location = new Point(40, 67);
            dantocChart.Name = "dantocChart";
            dantocChart.Size = new Size(1209, 584);
            dantocChart.TabIndex = 306;
            dantocChart.Text = "cartesianChart3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(1, 4);
            label3.Name = "label3";
            label3.Size = new Size(140, 45);
            label3.TabIndex = 305;
            label3.Text = "Dân tộc";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(dotuoiChart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            dotuoiChart.ResumeLayout(false);
            tabGender.ResumeLayout(false);
            tabGender.PerformLayout();
            tabAge.ResumeLayout(false);
            tabAge.PerformLayout();
            tabHeatlh.ResumeLayout(false);
            tabHeatlh.PerformLayout();
            tabDanToc.ResumeLayout(false);
            tabDanToc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl dotuoiChart;
        private TabPage tabGender;
        private TabPage tabAge;
        private TabPage tabHeatlh;
        private TabPage tabDanToc;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private LiveCharts.WinForms.CartesianChart tuoiChart;
        private LiveCharts.WinForms.PieChart gioitinhChart;
        private LiveCharts.WinForms.CartesianChart healchart;
        private LiveCharts.WinForms.CartesianChart dantocChart;
        private FontAwesome.Sharp.IconButton xuatpdfBtn3;
        private FontAwesome.Sharp.IconButton xuatPdfBtn1;
        private FontAwesome.Sharp.IconButton xuatPdfBtn2;
        private FontAwesome.Sharp.IconButton xuatPdf4;
    }
}