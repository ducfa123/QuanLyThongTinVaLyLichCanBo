namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class MainForm : Form
    {
        public bool isThoat = true;
        public MainForm()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.contentpanel.Controls.Count > 0)
            {
                this.contentpanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.contentpanel.Controls.Add(f);
                this.contentpanel.Tag = f;
                f.Show();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void openChildForm()
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void sidebarpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadForm(new AccountListForm(this));
        }


        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            loadForm(new AccountListForm(this));

        }

        private void contentpanel_Paint_1(object sender, PaintEventArgs e)
        {
        }
        public event EventHandler Logout;
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            loadForm(new StaffListForm(this));
        }

        private void nangluongBtn_Click(object sender, EventArgs e)
        {
            loadForm(new RaiseSalaryForm(this));
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            RewardForm kt = new RewardForm(this);
            loadForm(new RewardForm(this));
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            loadForm(new ChartForm());
        }
    }
}