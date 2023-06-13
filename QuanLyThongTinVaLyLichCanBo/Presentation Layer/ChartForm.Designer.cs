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
            tabControl1 = new TabControl();
            tabGender = new TabPage();
            pieChart1 = new LiveCharts.WinForms.PieChart();
            label4 = new Label();
            tabAge = new TabPage();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            label1 = new Label();
            tabHeatlh = new TabPage();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            label2 = new Label();
            tabDanToc = new TabPage();
            label3 = new Label();
            cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            tabControl1.SuspendLayout();
            tabGender.SuspendLayout();
            tabAge.SuspendLayout();
            tabHeatlh.SuspendLayout();
            tabDanToc.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGender);
            tabControl1.Controls.Add(tabAge);
            tabControl1.Controls.Add(tabHeatlh);
            tabControl1.Controls.Add(tabDanToc);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1300, 720);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabGender
            // 
            tabGender.Controls.Add(pieChart1);
            tabGender.Controls.Add(label4);
            tabGender.Location = new Point(4, 29);
            tabGender.Name = "tabGender";
            tabGender.Padding = new Padding(3);
            tabGender.Size = new Size(1292, 687);
            tabGender.TabIndex = 0;
            tabGender.Text = "Thống kê theo giới tính";
            tabGender.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            pieChart1.Location = new Point(40, 67);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(1209, 584);
            pieChart1.TabIndex = 304;
            pieChart1.Text = "pieChart1";
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
            tabAge.Controls.Add(cartesianChart1);
            tabAge.Controls.Add(label1);
            tabAge.Location = new Point(4, 29);
            tabAge.Name = "tabAge";
            tabAge.Padding = new Padding(3);
            tabAge.Size = new Size(1292, 687);
            tabAge.TabIndex = 1;
            tabAge.Text = "Thống kê theo độ tuổi";
            tabAge.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cartesianChart1.Location = new Point(40, 67);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1209, 584);
            cartesianChart1.TabIndex = 305;
            cartesianChart1.Text = "cartesianChart1";
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
            tabHeatlh.Controls.Add(cartesianChart2);
            tabHeatlh.Controls.Add(label2);
            tabHeatlh.Location = new Point(4, 29);
            tabHeatlh.Name = "tabHeatlh";
            tabHeatlh.Padding = new Padding(3);
            tabHeatlh.Size = new Size(1292, 687);
            tabHeatlh.TabIndex = 2;
            tabHeatlh.Text = "Thống kê theo sức khỏe";
            tabHeatlh.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(40, 67);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(1209, 584);
            cartesianChart2.TabIndex = 306;
            cartesianChart2.Text = "cartesianChart2";
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
            tabDanToc.Controls.Add(cartesianChart3);
            tabDanToc.Controls.Add(label3);
            tabDanToc.Location = new Point(4, 29);
            tabDanToc.Name = "tabDanToc";
            tabDanToc.Size = new Size(1292, 687);
            tabDanToc.TabIndex = 3;
            tabDanToc.Text = "Thống kê theo dân tộc";
            tabDanToc.UseVisualStyleBackColor = true;
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
            // cartesianChart3
            // 
            cartesianChart3.Location = new Point(40, 67);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(1209, 584);
            cartesianChart3.TabIndex = 306;
            cartesianChart3.Text = "cartesianChart3";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChartForm";
            Text = "ChartForm";
            Load += ChartForm_Load;
            tabControl1.ResumeLayout(false);
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

        private TabControl tabControl1;
        private TabPage tabGender;
        private TabPage tabAge;
        private TabPage tabHeatlh;
        private TabPage tabDanToc;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
    }
}