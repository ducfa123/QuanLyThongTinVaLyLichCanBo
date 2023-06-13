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

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class ListQTLuong : Form
    {
        private readonly RaiseSalary _parent;
        public int MaLuong, MaCanBo, PhuCapChucVu, PhuCapKhac, BacLuong;
        public string KieuNangLuong, NgachCongChuc, NguoiThucHien;
        public DateTime NgayHuong;
        public float HeSo;

        private void ListQTLuong_Shown(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            DbQuaTrinhLuong.DisplayAndSearchQuaTrinh(MaCanBo, dtLuong);
            DataGridViewColumn ngayhuong = dtLuong.Columns["Column3"];
            ngayhuong.DefaultCellStyle.Format = "dd/MM/yyyy";
            loainghachIn.SelectedItem = NgachCongChuc;
            bacluongIn.SelectedItem = BacLuong.ToString();
        }

        private void themquatrinhBtn_Click(object sender, EventArgs e)
        {
            if (kieunangluongIn.SelectedIndex == -1 || loainghachIn.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ngạch công chức và kiểu nâng lương!");
                return;
            }
            KieuNangLuong = kieunangluongIn.SelectedItem.ToString();
            NgachCongChuc = loainghachIn.SelectedItem.ToString();
            NgayHuong = ngayhuongIn.Value;
            int.TryParse(bacluongIn.Text, out BacLuong);
            float.TryParse(hesoIn.Text, out HeSo);

            if (!int.TryParse(phucapchucvuIn.Text, out PhuCapChucVu))
            {
                if (phucapchucvuIn.Text == string.Empty)
                {
                    PhuCapChucVu = 0;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập phụ cấp chức vụ là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
            if (!int.TryParse(phucapkhacIn.Text, out PhuCapKhac))
            {
                if (phucapkhacIn.Text == string.Empty)
                {
                    PhuCapKhac = 0;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập phụ cấp khác là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            Math.Round(HeSo, 2);

            try
            {

                QuaTrinhLuong luong = new QuaTrinhLuong(MaCanBo, PhuCapChucVu, PhuCapKhac, BacLuong, KieuNangLuong, NgachCongChuc, "Admin", NgayHuong, HeSo);
                DbQuaTrinhLuong.addQuaTrinh(luong);
                Display();
                Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void suaquatrinhBtn_Click(object sender, EventArgs e)
        {
            KieuNangLuong = kieunangluongIn.Text;
            NgachCongChuc = loainghachIn.Text;
            NgayHuong = ngayhuongIn.Value;
            int.TryParse(bacluongIn.Text, out BacLuong);
            float.TryParse(hesoIn.Text, out HeSo);

            if (!int.TryParse(phucapchucvuIn.Text, out PhuCapChucVu))
            {
                if (phucapchucvuIn.Text == string.Empty)
                {
                    PhuCapChucVu = 0;
                    return;
                }

                MessageBox.Show("Vui lòng nhập phụ cấp chức vụ là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(phucapkhacIn.Text, out PhuCapKhac))
            {
                if (phucapkhacIn.Text == string.Empty)
                {
                    PhuCapKhac = 0;
                    return;
                }
                MessageBox.Show("Vui lòng nhập phụ cấp khác là số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Math.Round(HeSo, 2);
            try
            {

                QuaTrinhLuong luong = new QuaTrinhLuong(MaCanBo, PhuCapChucVu, PhuCapKhac, BacLuong, KieuNangLuong, NgachCongChuc, "Admin", NgayHuong, HeSo);
                DbQuaTrinhLuong.updateQuaTrinh(luong, MaLuong);
                Display();
                Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ListQTLuong(RaiseSalary parent)
        {
            InitializeComponent();
            _parent = parent;
        }   

        public void Update()
        {
            kieunangluongIn.SelectedItem = KieuNangLuong;
            loainghachIn.SelectedItem = NgachCongChuc;
            bacluongIn.SelectedItem = BacLuong.ToString();
            ngayhuongIn.Value = NgayHuong;
            hesoIn.Text = HeSo.ToString();
            phucapchucvuIn.Text = PhuCapChucVu.ToString();
            phucapkhacIn.Text = PhuCapKhac.ToString();
        }
        public void Clear()
        {
            kieunangluongIn.SelectedIndex = loainghachIn.SelectedIndex = -1;
            ngayhuongIn.Value = DateTime.Now;
            hesoIn.Text = phucapchucvuIn.Text = phucapkhacIn.Text = string.Empty;
        }

        private void dtLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null && e.Value is double)
            {
                double coefficient = (double)e.Value;
                e.Value = coefficient.ToString("N2");
                e.FormattingApplied = true;
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void loainghachIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            bacluongIn.Items.Clear();
            bacluongIn.Text = string.Empty;
            if (loainghachIn != null && loainghachIn.SelectedItem != null)
            {
                string selectedItem = loainghachIn.SelectedItem.ToString();

                switch (selectedItem)
                {
                    case "Công chức A3 (A3.1)":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");

                        break;
                    case "Công chức A3 (A3.2)":
                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        break;
                    case "Công chức A2 (A2.1)":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        break;
                    case "Công chức A2 (A2.2)":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        break;
                    case "Công chức A1":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");

                        break;
                    case "Công chức A0":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");
                        bacluongIn.Items.Add("10");

                        break;
                    case "Công chức B":


                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");
                        bacluongIn.Items.Add("10");
                        bacluongIn.Items.Add("11");
                        bacluongIn.Items.Add("12");
                        break;
                    case "Công chức C":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");
                        bacluongIn.Items.Add("10");
                        bacluongIn.Items.Add("11");
                        bacluongIn.Items.Add("12");
                        break;
                    case "Viên chức A3":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");


                        break;
                    case "Viên chức A2":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");

                        break;
                    case "Viên chức A1":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");

                        break;
                    case "Viên chức A0":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");
                        bacluongIn.Items.Add("10");

                        break;
                    case "Viên chức B":

                        bacluongIn.Items.Add("1");
                        bacluongIn.Items.Add("2");
                        bacluongIn.Items.Add("3");
                        bacluongIn.Items.Add("4");
                        bacluongIn.Items.Add("5");
                        bacluongIn.Items.Add("6");
                        bacluongIn.Items.Add("7");
                        bacluongIn.Items.Add("8");
                        bacluongIn.Items.Add("9");
                        bacluongIn.Items.Add("10");
                        bacluongIn.Items.Add("11");
                        bacluongIn.Items.Add("12");
                        break;
                    default:
                        break;
                }
            }
        }

        private void dtLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bacluongIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loainghachIn.SelectedItem.ToString() == "Công chức A3 (A3.1)")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1")
                    hesoIn.Text = "6.2";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.56";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.92";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "7.28";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.64";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "8.00";
            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức A3 (A3.2)")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "5.75";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.11";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.47";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "6.83";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.19";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "7.55";
            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức A2 (A2.1)")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "4.4";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "4.74";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "5.08";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "5.42";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "5.76";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "6.1";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "6.44";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.78";

            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức A2 (A2.2)")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "4.00";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "4.34";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "4.68";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "5.02";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "5.36";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "5.70";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "6.04";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.38";

            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức A1")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.34";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.67";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "3.00";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.33";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.99";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "4.32";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.65";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.98";
            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức A0")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.1";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.41";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.72";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.03";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.34";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.65";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.96";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.27";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.58";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "4.89";
            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức B")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.06";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.26";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.46";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.06";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "3.26";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.46";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "4.06";

            }
            if (loainghachIn.SelectedItem.ToString() == "Công chức C")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.65";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "1.83";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.01";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.19";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.37";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.55";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "2.73";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "2.91";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.09";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.27";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.45";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "3.63";
            }
            if (loainghachIn.SelectedItem.ToString() == "Viên chức A3")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "6.2";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.56";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.92";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "7.28";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.64";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "8.00";

            }
            if (loainghachIn.SelectedItem.ToString() == "Viên chức A2")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "4.4";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "4.74";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "5.08";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "5.42";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "5.76";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "6.1";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "6.44";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.78";
            }
            if (loainghachIn.SelectedItem.ToString() == "Viên chức A1")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.34";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.67";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "3";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.33";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.99";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "4.32";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.65";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.98";
            }
            if (loainghachIn.SelectedItem.ToString() == "Viên chức A0")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.1";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.41";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.72";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.03";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.34";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.65";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.96";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.27";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.58";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "4.89";

            }
            if (loainghachIn.SelectedItem.ToString() == "Viên chức B")
            {
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.06";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.26";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.46";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.06";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "3.26";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.46";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.66";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.86";
                if (bacluongIn != null && bacluongIn.SelectedItem != null && bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "4.06";
            }
        }



        private void resetquatrinhBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit 
            {
                Clear();
                int.TryParse(dtLuong.Rows[e.RowIndex].Cells[2].Value.ToString(), out MaLuong);
                using (SqlConnection con = Connection.GetSqlConnection())
                {

                    con.Open();
                    string query = "SELECT KieuNangLuong,NgayHuong,NgachCongChuc,BacLuong,HeSo,PhuCapChucVu,PhuCapKhac FROM QuaTrinhLuong WHERE MaLuong = @MaLuong";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaLuong", dtLuong.Rows[e.RowIndex].Cells[2].Value.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        KieuNangLuong = reader.GetString(0);
                        NgayHuong = reader.GetDateTime(1);
                        NgachCongChuc = reader.GetString(2);
                        BacLuong = reader.GetInt32(3);
                        HeSo = (float)reader.GetDouble(4);
                        PhuCapChucVu = (int)(long)reader.GetInt64(5);
                        PhuCapKhac = (int)(long)reader.GetInt64(6);
                    }

                }
                Update();
            }

            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi quá trình này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbQuaTrinhLuong.DeleteQuaTrinh(dtLuong.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }
    }
}