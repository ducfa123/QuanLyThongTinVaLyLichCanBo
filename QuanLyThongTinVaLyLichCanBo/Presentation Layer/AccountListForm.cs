using DocumentFormat.OpenXml.Spreadsheet;
using QuanLyThongTinVaLyLichCanBo.Class;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class ListAccount : Form
    {
        private readonly MainForm _parent;
        private DataTable originalDataTable; // Biến tạm để lưu trữ dữ liệu ban đầu
        private DataTable filterDataTable;
        private int currentPageIndex = 0; // Trang hiện tại
        private int pageSize = 7; // Số lượng bản ghi trên mỗi trang
        private int totalRecords; // Số lượng bản ghi tổng cộng
        private int totalPages; // Tính tổng số trang
        private int totalFilteredRecords;
        CanBoInfomation tt;

        Register dk;
        ChangePassword cpw;
        public ListAccount(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            dk = new Register(this);
            cpw = new ChangePassword(this);
        }
        private void setButtonIsChoose(int pageIndex, Color textColor, Color backColor)
        {
            if ((pageIndex + 1).ToString() == firstBtn.Text)
            {
                firstBtn.BackColor = textColor;
                firstBtn.ForeColor = backColor;
            }
            else
            {
                firstBtn.BackColor = backColor;
                firstBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == firstindexBtn.Text)
            {
                firstindexBtn.BackColor = textColor;
                firstindexBtn.ForeColor = backColor;
            }
            else
            {
                firstindexBtn.BackColor = backColor;
                firstindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == secondindexBtn.Text)
            {
                secondindexBtn.BackColor = textColor;
                secondindexBtn.ForeColor = backColor;
            }
            else
            {
                secondindexBtn.BackColor = backColor;
                secondindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == threeindexBtn.Text)
            {
                threeindexBtn.BackColor = textColor;
                threeindexBtn.ForeColor = backColor;
            }
            else
            {
                threeindexBtn.BackColor = backColor;
                threeindexBtn.ForeColor = textColor;
            }
            if ((pageIndex + 1).ToString() == lastBtn.Text)
            {
                lastBtn.BackColor = textColor;
                lastBtn.ForeColor = backColor;
            }
            else
            {
                lastBtn.BackColor = backColor;
                lastBtn.ForeColor = textColor;
            }
        }
        public void Pagination(int pageIndex)
        {
            Color backColor = Color.FromArgb(100, 99, 103);
            Color textColor = Color.White;
            if (totalPages <= 5)
            {
                threedotafterLB.Visible = false;
                threedotbeforeBtn.Visible = false;
                threeindexBtn.Visible = true;
                secondindexBtn.Visible = true;
                firstindexBtn.Visible = true;
                threeindexBtn.Text = "4";
                secondindexBtn.Text = "3";
                firstindexBtn.Text = "2";
                if (totalPages <= 4)
                {

                    lastBtn.Visible = false;


                    if (totalPages <= 3)
                    {
                        threeindexBtn.Visible = false;
                        if (totalPages <= 2)
                        {
                            secondindexBtn.Visible = false;
                            if (totalPages <= 1)
                            {
                                firstindexBtn.Visible = false;
                            }
                        }
                    }
                }
                if (pageIndex == 0)
                {
                    previousBtn.Enabled = false;
                }
                else
                {
                    previousBtn.Enabled = true;
                }
                if (pageIndex == totalPages - 1) // nếu là trang cuối
                {
                    nextBtn.Enabled = false;
                }
                else
                {
                    nextBtn.Enabled = true;
                }
                setButtonIsChoose(pageIndex, textColor, backColor);
            }
            else
            {
                if (pageIndex >= 0 && pageIndex <= 3) //định dạng các trang đầu
                {
                    if (pageIndex == 0)
                    {
                        previousBtn.Enabled = false;
                    }
                    else
                    {
                        previousBtn.Enabled = true;
                    }
                    nextBtn.Enabled = true;
                    threedotbeforeBtn.Visible = false;
                    threedotafterLB.Visible = true;
                    firstindexBtn.Text = "2";
                    secondindexBtn.Text = "3";
                    threeindexBtn.Text = "4";
                    lastBtn.Text = totalPages.ToString();

                    setButtonIsChoose(pageIndex, textColor, backColor);
                }
                else if (pageIndex >= totalPages - 3) // nếu là trang cuối
                {
                    if (pageIndex == totalPages - 1) // nếu là trang cuối
                    {
                        nextBtn.Enabled = false;
                    }
                    else
                    {
                        nextBtn.Enabled = true;
                    }
                    threedotafterLB.Visible = false;
                    threedotbeforeBtn.Visible = true;
                    previousBtn.Enabled = true;
                    firstindexBtn.Text = (totalPages - 3).ToString();
                    secondindexBtn.Text = (totalPages - 2).ToString();
                    threeindexBtn.Text = (totalPages - 1).ToString();
                    setButtonIsChoose(pageIndex, textColor, backColor);

                }
                else if (pageIndex > 3 && pageIndex < totalPages - 3)  //nếu là trang giữa
                {

                    previousBtn.Enabled = true;
                    nextBtn.Enabled = true;
                    threedotbeforeBtn.Visible = true;
                    threedotafterLB.Visible = true;
                    firstindexBtn.Text = pageIndex.ToString();
                    secondindexBtn.Text = (pageIndex + 1).ToString();
                    threeindexBtn.Text = (pageIndex + 2).ToString();
                    setButtonIsChoose(pageIndex, textColor, backColor);

                }
            }
        }
        public DataTable Display(int pageIndex, DataTable dataTable, int pageSize, out int totalRecords)
        {
            // Số lượng bản ghi tổng cộng
            totalRecords = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            firstBtn.Text = "1";

            lastBtn.Text = totalPages.ToString();
            firstindexBtn.Visible = true;
            secondindexBtn.Visible = true;
            threeindexBtn.Visible = true;
            lastBtn.Visible = true;
            Pagination(pageIndex);

            // Lấy chỉ mục bắt đầu và kết thúc của dữ liệu theo trang
            int startIndex = pageIndex * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);

            // Tạo DataTable mới để chứa dữ liệu của trang hiện tại
            DataTable pageDataTable = dataTable.Clone();

            // Sao chép dữ liệu từ DataTable gốc vào DataTable của trang hiện tại
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(dataTable.Rows[i]);
            }

            //// Gắn DataTable của trang hiện tại làm DataSource của DataGridView
            dtAccount.DataSource = pageDataTable;
            filterDataTable = dataTable;

            return pageDataTable;
        }
        public DataTable Display(int pageIndex, int pageSize, out int totalRecords)
        {
            DbAccount.DisplayAndSearchAccount("SELECT UserName,Email,PhoneNumber,Role FROM [User] WHERE Role = 'Can Bo'", dtAccount);
            DataTable dataTable = new DataTable();

            dataTable = dtAccount.DataSource as DataTable;
            totalRecords = dataTable.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            firstBtn.Text = "1";

            lastBtn.Text = totalPages.ToString();
            Pagination(pageIndex);

            // Lấy chỉ mục bắt đầu và kết thúc của dữ liệu theo trang
            int startIndex = pageIndex * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);

            // Tạo DataTable mới để chứa dữ liệu của trang hiện tại
            DataTable pageDataTable = dataTable.Clone();

            // Sao chép dữ liệu từ DataTable gốc vào DataTable của trang hiện tại
            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(dataTable.Rows[i]);
            }

            //// Gắn DataTable của trang hiện tại làm DataSource của DataGridView
            dtAccount.DataSource = pageDataTable;
            originalDataTable = dataTable;

            return pageDataTable;
        }
        private void dtCanbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit mật khẩu
            {
                cpw.username = dtAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                cpw.isAdmin = true;
                cpw.AdminDisplay();
                _parent.loadForm(cpw);
                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbAccount.DeleteAcc(dtAccount.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display(currentPageIndex, pageSize, out totalRecords);
                }
                return;
            }
        }

        public void loadPreviousForm()
        {
            _parent.loadForm(this);
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            dk.Clear();
            _parent.loadForm(dk);
        }


        private void ListAccount_Load(object sender, EventArgs e)
        {
            Display(currentPageIndex, pageSize, out totalRecords);
        }

        private void xemBtn_Click(object sender, EventArgs e)
        {
            filterEmail.Visible = !filterEmail.Visible;
            filterPhoneNumber.Visible = !filterPhoneNumber.Visible;
            filterUsername.Visible = !filterUsername.Visible;
            filterRole.Visible = !filterRole.Visible;
        }

        private void filterUsername_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterUsername.Text;
            dtAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("UserName LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtAccount.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtAccount.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterEmail_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterEmail.Text;
            dtAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("Email LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtAccount.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtAccount.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterPhoneNumber.Text;
            dtAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("PhoneNumber LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtAccount.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtAccount.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void filterRole_TextChanged(object sender, EventArgs e)
        {
            string searchText = filterRole.Text;
            dtAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (!string.IsNullOrEmpty(searchText))
            {
                // Tạo DataView từ originalDataTable để thực hiện tìm kiếm
                DataView dataView = originalDataTable.DefaultView;

                // Áp dụng bộ lọc tương ứng với tên được nhập vào
                dataView.RowFilter = string.Format("Role LIKE '%{0}%'", searchText);

                // Lấy DataTable tìm được từ DataView
                filterDataTable = dataView.ToTable();
                totalFilteredRecords = filterDataTable.Rows.Count;
                // Cập nhật dữ liệu và biến totalFilteredRecords
                dtAccount.DataSource = Display(0, filterDataTable, pageSize, out totalFilteredRecords);

            }
            else
            {
                // Khôi phục lại nguồn dữ liệu ban đầu
                dtAccount.DataSource = Display(0, originalDataTable, pageSize, out totalRecords);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            _parent.loadForm(new ListAccount(_parent));
            this.Close();
        }
        private void selectDisplay()
        {
            if (filterUsername.Text != string.Empty || filterEmail.Text != string.Empty || filterPhoneNumber.Text != string.Empty || filterRole.Text != string.Empty)
            {
                Display(currentPageIndex, filterDataTable, pageSize, out totalFilteredRecords);
                return;
            }
            else
            {

                Display(currentPageIndex, pageSize, out totalRecords);
                return;
            }


        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--; // Giảm số trang hiện tại xuống 1 (nếu có thể)

                selectDisplay();
                // Hiển thị dữ liệu trang mới trong DataGridView

            }
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0; // Gán currentPageIndex bằng 0 để chuyển đến trang đầu
            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void firstindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang

            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void secondindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang

            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void threeindexBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int pageNumber = int.Parse(button.Text) - 1; // Lấy số trang từ nội dung text của nút và chuyển đổi thành số nguyên
            currentPageIndex = pageNumber; // Gán currentPageIndex bằng số trang
            selectDisplay();
            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages - 1; // Gán currentPageIndex bằng số trang cuối
            selectDisplay();

            // Hiển thị dữ liệu trang mới trong DataGridView

            // Dùng totalRecords để tính toán và hiển thị phân trang
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages - 1) // chưa phải trang cuối
            {

                currentPageIndex++; // Tăng số trang hiện tại lên 1
                selectDisplay();
                // Hiển thị dữ liệu trang mới trong DataGridView

            }
        }

        private void filterPhoneNumber_SizeChanged(object sender, EventArgs e)
        {

        }

        private void filterPhoneNumber_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0;
        }

        private void filterUsername_Click(object sender, EventArgs e)
        {
            currentPageIndex = 0;

        }
    }
}
