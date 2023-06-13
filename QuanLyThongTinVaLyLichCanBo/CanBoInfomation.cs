using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data.SqlClient;
using System.Globalization;
using Google.Protobuf.WellKnownTypes;
using QuanLyThongTinVaLyLichCanBo.Class.Control;
using QuanLyThongTinVaLyLichCanBo.Class.Model;
using QuanLyThongTinVaLyLichCanBo.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using K4os.Compression.LZ4.Internal;
using System.Net.NetworkInformation;
using System.Windows.Documents;

namespace QuanLyThongTinVaLyLichCanBo
{
    public partial class CanBoInfomation : Form
    {
        private readonly ListCanbo _parent;
        public byte[] image;
        public string imgpath, fullname, dantoc, tongiao, gioitinh, hokhau, othername, noisinh, quequan, noio, nghenghiep, coquan, chucvu, quanham, danhhieu, khenthuong, kyluat, chieucao, nghachcongchuc, tenngach, cannang, nhommau, hangthuongbinh, giadinhchinhsach, socmnd, mabhxh;
        public DateTime dtngaytuyendung, dtngaysinh, dtngaybonhiem, dtngayvaodang, dtngaychinhthuc, dtngaynhapngu, dtngayxuatngu, dtngaycapcmnd;
        public int phucapCV, phucapkhac, bacluong, id, madaotao, maquatrinh, maquanhe;
        public float heso;

        public string moiquanhe, hotenquanhe, quequanquanhe, noioquanhe, donviquanhe, nghenghiepquanhe;
        public DateTime namsinhquanhe;
        public string tentruong, chuyennghanhdaotao, hinhthucdaotao, vanbang;
        public DateTime batdaudaotao, ketthucdaotao;

        public string donvicongtac, chucvucongtac;
        public DateTime batdaucongtac, ketthuccongtac;

        public string lydoditu, coquanlsbt, diadiem, chucvulsbt, mucdich, tentochuc, diadiemtruso, quanhenguoinha, nghenghieplsbt, noiolsbt;
        public DateTime batdauditu, ketthucditu;
        public bool ditu, lamviecchochedocu, quanhevoitochucnuocngoai, conguoinhaonn, haslsbt;
        public int thoigianlamviec, maLSBT;



        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (nguoinhaonuocngoaiCB.CheckState == CheckState.Checked)
            {
                quanhenguoinhaIn.Enabled = true;
                nghenghiepnguoinhaIn.Enabled = true;
                noionguoinhaIn.Enabled = true;

            }
            else
            {
                quanhenguoinhaIn.Enabled = false;
                nghenghiepnguoinhaIn.Enabled = false;
                noionguoinhaIn.Enabled = false;
            }
        }

        private void ketthucdaotaoIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void diadiemIn__TextChanged(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void tenngachIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thoigianIn__TextChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (quanhevoitochucnuocngoaiCB.CheckState == CheckState.Checked)
            {
                tentochucIn.Enabled = true;
                mucdichIn.Enabled = true;
                diadiemtrusoIn.Enabled = true;
            }
            else
            {
                tentochucIn.Enabled = false;
                mucdichIn.Enabled = false;
                diadiemtrusoIn.Enabled = false;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lamviecchedocuCB.CheckState == CheckState.Checked)
            {
                cqIn.Enabled = true;
                diadiemIn.Enabled = true;
                cvIn.Enabled = true;
                thoigianIn.Enabled = true;
            }
            else
            {
                cqIn.Enabled = false;
                diadiemIn.Enabled = false;
                cvIn.Enabled = false;
                thoigianIn.Enabled = false;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ketthucIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ketthucLB_Click(object sender, EventArgs e)
        {

        }

        private void batdauIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void batdauLB_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            if (madaotao == 0)
            {
                MessageBox.Show("Chọn quá trình đào tạo muốn sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string tentruong = tentruongIn.Text;
                DateTime batdaudaotao = batdaudaotaoIn.Value;
                DateTime ketthucdaotao = ketthucdaotaoIn.Value;
                string chuyennghanhdaotao = chuyennnghanhdaotaoIn.Text;
                string hinhthucdaotao = hinhthucdaotaoIn.Text;
                string vanbang = vanbangIn.Text;

                if (tentruong == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên trường!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (chuyennghanhdaotao == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập chuyên nghành đào tạo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (hinhthucdaotao == string.Empty)
                {

                    MessageBox.Show("Vui lòng nhập hình thức đào tạo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (vanbang == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập văn bằng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DaoTaoBoiDuongChuyenMon dt = new DaoTaoBoiDuongChuyenMon(tentruong, chuyennghanhdaotao, hinhthucdaotao, vanbang, batdaudaotao, ketthucdaotao, id);
                DbDaoTaoBoiDuongChuyenMon.updateDaotao(dt, madaotao);
                DisplayDaoTao();
                ClearDaotao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearDaotao();
        }
        public void ClearQuatrinh()
        {
            maquatrinh = 0;
            donvicongtacIn.Text = chucvucongtacIn.Text = string.Empty;
            batdauCongTacIn.Value = DateTime.Now;
            ketthuccongtacIn.Value = DateTime.Now;
        }

        private void themquatrinhBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string donvi = donvicongtacIn.Text;
                DateTime batdaudaotao = batdauCongTacIn.Value;
                DateTime ketthucdaotao = ketthuccongtacIn.Value;
                string chucvu = chucvucongtacIn.Text;


                if (donvi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đơn vị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (chucvu == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập chức vụ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                QuaTrinhCongTac qt = new QuaTrinhCongTac(batdaudaotao, ketthucdaotao, donvi, chucvu, id);
                DbQuaTrinhCongTac.addQuaTrinh(qt);
                DisplayQuaTrinh();
                ClearDaotao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void suaquatrinhBtn_Click(object sender, EventArgs e)
        {
            if (maquatrinh == 0)
            {
                MessageBox.Show("Chọn quá trình công tác muốn sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string donvi = donvicongtacIn.Text;
                DateTime thoigianbatdau = batdauCongTacIn.Value;
                DateTime thoigianketthuc = ketthuccongtacIn.Value;
                string chucvu = chucvucongtacIn.Text;

                if (donvi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đơn vị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (chucvu == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập chức vụ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                QuaTrinhCongTac qt = new QuaTrinhCongTac(thoigianbatdau, thoigianketthuc, donvi, chucvu, id);
                DbQuaTrinhCongTac.updateQuaTrinh(qt, maquatrinh);
                DisplayQuaTrinh();
                ClearQuatrinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtQuanHe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ClearQuanhe()
        {
            maquanhe = 0;
            moiquanheIn.SelectedIndex = -1;
            hotenquanheIn.Text = quequanquanheIn.Text = nghenghiepquanheIn.Text = donviquanheIn.Text = noioquanheIn.Text = string.Empty;
            namsinhquanheIn.Value = DateTime.Now;
        }
        public void DisplayQuanhe()
        {
            DataGridViewColumn batdau = dtQuanHe.Columns["dataGridViewTextBoxColumn8"];
            batdau.DefaultCellStyle.Format = "yyyy";

            DbQuanHeGiaDinh.DisplayAndSearchQuanHe(id, dtQuanHe);
        }
        private void themquanheBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string moiquanhe = moiquanheIn.SelectedItem.ToString();
                string hoten = hotenquanheIn.Text;
                DateTime namsinh = namsinhquanheIn.Value;
                string quequan = quequanquanheIn.Text;
                string nghenghiep = nghenghiepquanheIn.Text;
                string donvi = donviquanheIn.Text;
                string noio = noioquanheIn.Text;

                if (moiquanhe == null)
                {
                    MessageBox.Show("Vui lòng nhập mối quan hệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (hoten == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (quequan == string.Empty)
                {

                    MessageBox.Show("Vui lòng nhập quê quán!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (nghenghiep == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập nghiệp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (donvi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đơn vị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (noio == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập nơi ở!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                QuanHeGiaDinh qh = new QuanHeGiaDinh(id, moiquanhe, hoten, quequan, nghenghiep, donvi, noio, namsinh);
                DbQuanHeGiaDinh.addQuanHe(qh);
                DisplayQuanhe();
                ClearQuanhe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void suaquanheBtn_Click(object sender, EventArgs e)
        {
            if (maquanhe == 0)
            {
                MessageBox.Show("Chọn quan hệ gia đình muốn sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string moiquanhe = moiquanheIn.SelectedItem.ToString();
                string hoten = hotenquanheIn.Text;
                DateTime namsinh = namsinhquanheIn.Value;
                string quequan = quequanquanheIn.Text;
                string nghenghiep = nghenghiepquanheIn.Text;
                string donvi = donviquanheIn.Text;
                string noio = noioquanheIn.Text;


                if (moiquanhe == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mối quan hệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (hoten == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (quequan == string.Empty)
                {

                    MessageBox.Show("Vui lòng nhập quê quán!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (nghenghiep == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập nghiệp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (donvi == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đơn vị!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (noio == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập nơi ở!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                QuanHeGiaDinh qh = new QuanHeGiaDinh(id, moiquanhe, hoten, quequan, nghenghiep, donvi, noio, namsinh);
                DbQuanHeGiaDinh.updateQuanHe(qh, maquanhe);
                DisplayQuanhe();
                ClearQuanhe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtQuanHe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit 
            {
                ClearQuanhe();

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();

                    string query = "SELECT MoiQuanHe,HoVaTen,NamSinh,QueQuan,NgheNghiep,DonViCongTac,NoiO FROM QuanHeGiaDinh WHERE MaQHGD = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", dtQuanHe.Rows[e.RowIndex].Cells[2].Value.ToString()); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                    if (reader.Read())
                    {
                        maquanhe = (int)dtQuanHe.Rows[e.RowIndex].Cells[2].Value;
                        moiquanhe = reader.GetString(0);
                        hotenquanhe = reader.GetString(1);
                        namsinhquanhe = reader.GetDateTime(2);
                        quequanquanhe = reader.GetString(3);
                        nghenghiepquanhe = reader.GetString(4);
                        donviquanhe = reader.GetString(5);
                        noioquanhe = reader.GetString(6);

                    }
                }
                moiquanheIn.SelectedItem = moiquanhe;
                hotenquanheIn.Text = hotenquanhe;
                namsinhquanheIn.Value = namsinhquanhe;
                quequanquanheIn.Text = quequanquanhe;
                nghenghiepquanheIn.Text = nghenghiepquanhe;
                donviquanheIn.Text = donviquanhe;
                noioquanheIn.Text = noioquanhe;
                maquanhe = (int)dtQuanHe.Rows[e.RowIndex].Cells[2].Value;
                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi quá trình công tác này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbQuanHeGiaDinh.DeleteQuanHe(dtQuanHe.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayQuanhe();
                }
                return;
            }
        }

        private void resetquanheBtn_Click(object sender, EventArgs e)
        {
            ClearQuanhe();
        }

        private void dtQuaTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit 
            {
                ClearQuatrinh();

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT ThoiGianBatDau,ThoiGianKetThuc,DonVi,ChucVu FROM QuaTrinhCongTac WHERE MaQTCT = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", dtQuaTrinh.Rows[e.RowIndex].Cells[2].Value.ToString()); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                    if (reader.Read())
                    {
                        maquatrinh = (int)dtQuaTrinh.Rows[e.RowIndex].Cells[2].Value;
                        batdaucongtac = reader.GetDateTime(0);
                        ketthuccongtac = reader.GetDateTime(1);
                        donvicongtac = reader.GetString(2);
                        chucvucongtac = reader.GetString(3);

                    }
                }
                batdauCongTacIn.Value = batdaucongtac;
                ketthuccongtacIn.Value = ketthuccongtac;
                donvicongtacIn.Text = donvicongtac;
                chucvucongtacIn.Text = chucvucongtac;
                maquatrinh = (int)dtQuaTrinh.Rows[e.RowIndex].Cells[2].Value;
                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi quá trình công tác này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbQuaTrinhCongTac.DeleteQuaTrinh(dtDaotao.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayDaoTao();
                }
                return;
            }
        }

        private void resetquatrinhBtn_Click(object sender, EventArgs e)
        {
            ClearQuatrinh();
        }

        private void reasonLB40_Click(object sender, EventArgs e)
        {

        }

        public void ClearDaotao()
        {
            madaotao = 0;
            tentruongIn.Text = chuyennnghanhdaotaoIn.Text = hinhthucdaotaoIn.Text = vanbangIn.Text = string.Empty;
            batdaudaotaoIn.Value = DateTime.Now;
            ketthucdaotaoIn.Value = DateTime.Now;
        }
        private void themBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tentruong = tentruongIn.Text;
                DateTime batdaudaotao = batdaudaotaoIn.Value;
                DateTime ketthucdaotao = ketthucdaotaoIn.Value;
                string chuyennghanhdaotao = chuyennnghanhdaotaoIn.Text;
                string hinhthucdaotao = hinhthucdaotaoIn.Text;
                string vanbang = vanbangIn.Text;

                if (tentruong == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên trường!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (chuyennghanhdaotao == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập chuyên nghành đào tạo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (hinhthucdaotao == string.Empty)
                {

                    MessageBox.Show("Vui lòng nhập hình thức đào tạo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (vanbang == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập văn bằng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DaoTaoBoiDuongChuyenMon dt = new DaoTaoBoiDuongChuyenMon(tentruong, chuyennghanhdaotao, hinhthucdaotao, vanbang, batdaudaotao, ketthucdaotao, id);
                DbDaoTaoBoiDuongChuyenMon.addDaoTao(dt);
                DisplayDaoTao();
                ClearDaotao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtDaotao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            //edit 
            {
                ClearDaotao();

                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    string query = "SELECT TenTruong,ChuyenNghanhDaoTao,ThoiGianBatDauDaoTao,ThoiGianKetThucDaoTao,HinhThucDaoTao,VanBang FROM DaoTaoBoiDuongChuyenMon WHERE MaDaoTao = @id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id", dtDaotao.Rows[e.RowIndex].Cells[2].Value.ToString()); // Thiết lập tham số để truyền giá trị vào câu truy vấn
                    SqlDataReader reader = command.ExecuteReader(); // Thực hiện truy vấn và trả về SqlDataReader

                    if (reader.Read())
                    {
                        madaotao = (int)dtDaotao.Rows[e.RowIndex].Cells[2].Value;
                        tentruong = reader.GetString(0);
                        chuyennghanhdaotao = reader.GetString(1);
                        batdaudaotao = reader.GetDateTime(2);
                        ketthucdaotao = reader.GetDateTime(3);
                        hinhthucdaotao = reader.GetString(4);
                        vanbang = reader.GetString(5);
                    }
                }
                tentruongIn.Text = tentruong;
                chuyennnghanhdaotaoIn.Text = chuyennghanhdaotao;
                batdaudaotaoIn.Value = batdaudaotao;
                ketthucdaotaoIn.Value = ketthucdaotao;
                hinhthucdaotaoIn.Text = hinhthucdaotao;
                vanbangIn.Text = vanbang;
                return;
            }
            if (e.ColumnIndex == 1)
            //delete
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi cán bộ này?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbDaoTaoBoiDuongChuyenMon.DeleteDaotao(dtDaotao.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayDaoTao();
                }
                return;
            }
        }

        private void dtDaotao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lydoIn__TextChanged(object sender, EventArgs e)
        {

        }

        private void prisonCB_CheckedChanged(object sender, EventArgs e)
        {
            if (prisonCB.CheckState == CheckState.Checked)
            {
                lydoIn.Enabled = true;
                batdauIn.Enabled = true;
                ketthucIn.Enabled = true;
            }
            else
            {
                lydoIn.Enabled = false;
                batdauIn.Enabled = false;
                ketthucIn.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void qtctPage_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void qhgdPage_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void socmndIn__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void ngachcongchucIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenngachIn.Items.Clear();
            bacluongIn.Items.Clear();
            tenngachIn.Text = string.Empty;
            bacluongIn.Text = string.Empty;
            switch (loaingachIn.SelectedItem.ToString())
            {
                case "Công chức A3 (A3.1)":
                    tenngachIn.Items.Add("Chuyên viên cao cấp");
                    tenngachIn.Items.Add("Thanh tra viên cao cấp");
                    tenngachIn.Items.Add("Kiểm tra viên cao cấp thuế");
                    tenngachIn.Items.Add("Kiểm tra viên cao cấp hải quan");
                    tenngachIn.Items.Add("Kiểm soát viên cao cấp ngân hàng");
                    tenngachIn.Items.Add("Kiểm toán viên cao cấp");
                    tenngachIn.Items.Add("Chấp hành viên cao cấp");
                    tenngachIn.Items.Add("Thẩm tra viên cao cấp");
                    tenngachIn.Items.Add("Kiểm soát viên cao cấp thị trường");
                    bacluongIn.Items.Add("1");
                    bacluongIn.Items.Add("2");
                    bacluongIn.Items.Add("3");
                    bacluongIn.Items.Add("4");
                    bacluongIn.Items.Add("5");
                    bacluongIn.Items.Add("6");

                    break;
                case "Công chức A3 (A3.2)":
                    tenngachIn.Items.Add("Kế toán viên cao cấp");
                    bacluongIn.Items.Add("1");
                    bacluongIn.Items.Add("2");
                    bacluongIn.Items.Add("3");
                    bacluongIn.Items.Add("4");
                    bacluongIn.Items.Add("5");
                    bacluongIn.Items.Add("6");
                    break;
                case "Công chức A2 (A2.1)":
                    tenngachIn.Items.Add("Chuyên viên chính");
                    tenngachIn.Items.Add("Chấp hành viên trung cấp");
                    tenngachIn.Items.Add("Thanh tra viên chính");
                    tenngachIn.Items.Add("Thẩm tra viên chính");
                    tenngachIn.Items.Add("Kiểm tra viên chính thuế");
                    tenngachIn.Items.Add("Kiểm soát viên chính thị trường");
                    tenngachIn.Items.Add("Kiểm tra viên chính hải quan");
                    tenngachIn.Items.Add("Kiểm lâm viên chính");
                    tenngachIn.Items.Add("Kỹ thuật viên bảo quản chính");
                    tenngachIn.Items.Add("Kiểm ngư viên chính");
                    tenngachIn.Items.Add("Kiểm soát viên chính ngân hàng");
                    tenngachIn.Items.Add("Thuyền viên kiểm ngư chính");
                    tenngachIn.Items.Add("Kiểm toán viên chính");
                    tenngachIn.Items.Add("Văn thư viên chính");

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
                    tenngachIn.Items.Add("Kế toán viên chính");
                    tenngachIn.Items.Add("Kiểm dịch viên chính động vật");
                    tenngachIn.Items.Add("Kiểm dịch viên chính thực vật");
                    tenngachIn.Items.Add("Kiểm soát viên chính đê điều");
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
                    tenngachIn.Items.Add("Chuyên viên");
                    tenngachIn.Items.Add("Kiểm toán viên");
                    tenngachIn.Items.Add("Kiểm soát viên đê điều");
                    tenngachIn.Items.Add("Thanh tra viên");
                    tenngachIn.Items.Add("Chấp hành viên sơ cấp (THADS)");
                    tenngachIn.Items.Add("Kiểm lâm viên");
                    tenngachIn.Items.Add("Kế toán viên");
                    tenngachIn.Items.Add("Thẩm tra viên (THADS)");
                    tenngachIn.Items.Add("Kiểm ngư viên");
                    tenngachIn.Items.Add("Kiểm tra viên thuế");
                    tenngachIn.Items.Add("Thư ký thi hành án (dân sự)");
                    tenngachIn.Items.Add("Thuyền viên kiểm ngư");
                    tenngachIn.Items.Add("Kiểm tra viên hải quan");
                    tenngachIn.Items.Add("Kiểm soát viên thị trường");
                    tenngachIn.Items.Add("Văn thư viên");
                    tenngachIn.Items.Add("Kỹ thuật viên bảo quản");
                    tenngachIn.Items.Add("Kiểm dịch viên động vật");
                    tenngachIn.Items.Add("Kiểm soát viên ngân hàng");
                    tenngachIn.Items.Add("Kiểm dịch viên thực vật");
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
                    tenngachIn.Items.Add("Cán sự");
                    tenngachIn.Items.Add("Kế toán viên trung cấp");
                    tenngachIn.Items.Add("Kiểm tra viên trung cấp thuế");
                    tenngachIn.Items.Add("Kiểm tra viên trung cấp hải quan");
                    tenngachIn.Items.Add("Kiểm soát viên trung cấp thị trường");
                    tenngachIn.Items.Add("Kỹ thuật viên bảo quản trung cấp");
                    tenngachIn.Items.Add("Thủ kho bảo quản");
                    tenngachIn.Items.Add("Thủ kho, thủ quỹ ngân hàng");

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
                    tenngachIn.Items.Add("Nhân viên (bảo vệ, lái xe, phục vụ, lễ tân, kỹ thuật…)");
                    tenngachIn.Items.Add("Kiểm lâm viên trung cấp");
                    tenngachIn.Items.Add("Nhân viên thuế");
                    tenngachIn.Items.Add("Kiểm ngư viên trung cấp");
                    tenngachIn.Items.Add("Nhân viên hải quan");
                    tenngachIn.Items.Add("Thuyền viên kiểm ngư trung cấp");
                    tenngachIn.Items.Add("Nhân viên tiền tệ kho quỹ ngân hàng");
                    tenngachIn.Items.Add("Văn thư viên trung cấp");
                    tenngachIn.Items.Add("Thư ký trung cấp thi hành án");
                    tenngachIn.Items.Add("Thủ quỹ cơ quan, đơn vị");
                    tenngachIn.Items.Add("Kỹ thuật viên kiểm dịch động vật");
                    tenngachIn.Items.Add("Kỹ thuật viên kiểm dịch thực vật");
                    tenngachIn.Items.Add("Kiểm soát viên trung cấp đê điều");


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
                    tenngachIn.Items.Add("Nhân viên bảo vệ kho dự trữ");

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
                    tenngachIn.Items.Add("Giảng viên cao cấp hạng I");
                    tenngachIn.Items.Add("Giảng viên cao đẳng sư phạm cao cấp hạng I");
                    tenngachIn.Items.Add("Giảng viên giáo dục nghề nghiệp cao cấp (hạng I)");
                    tenngachIn.Items.Add("Giáo viên giáo dục nghề nghiệp hạng I");
                    tenngachIn.Items.Add("Bác sĩ cao cấp (hạng I)");
                    tenngachIn.Items.Add("Bác sĩ y học dự phòng cao cấp (hạng I)");
                    tenngachIn.Items.Add("Dược sĩ cao cấp (hạng I)");
                    tenngachIn.Items.Add("Y tế công cộng cao cấp (hạng I)");
                    tenngachIn.Items.Add("Đạo diễn nghệ thuật hạng I");
                    tenngachIn.Items.Add("Diễn viên hạng I");
                    tenngachIn.Items.Add("Di sản viên hạng I");
                    tenngachIn.Items.Add("Huấn luyện viên cao cấp (Hạng I)");
                    tenngachIn.Items.Add("Nghiên cứu viên cao cấp (Hạng I)");
                    tenngachIn.Items.Add("Kỹ sư cao cấp (Hạng I)");
                    tenngachIn.Items.Add("Âm thanh viên hạng I");
                    tenngachIn.Items.Add("Phát thanh viên hạng I");
                    tenngachIn.Items.Add("Kỹ thuật dựng phim hạng I");
                    tenngachIn.Items.Add("Quay phim hạng I");
                    tenngachIn.Items.Add("Biên tập viên hạng I");
                    tenngachIn.Items.Add("Phóng viên hạng I");
                    tenngachIn.Items.Add("Biên dịch viên hạng I");
                    tenngachIn.Items.Add("Đạo diễn truyền hình hạng I");
                    tenngachIn.Items.Add("Kiến trúc sư Hạng I");
                    tenngachIn.Items.Add("Thẩm kế viên hạng I");
                    tenngachIn.Items.Add("Họa sĩ hạng I");
                    tenngachIn.Items.Add("Công nghệ thông tin hạng I");
                    tenngachIn.Items.Add("An toàn thông tin hạng I");
                    tenngachIn.Items.Add("Thư viện viên hạng I");
                    tenngachIn.Items.Add("Trợ giúp viên pháp lý hạng I");

                    bacluongIn.Items.Add("1");
                    bacluongIn.Items.Add("2");
                    bacluongIn.Items.Add("3");
                    bacluongIn.Items.Add("4");
                    bacluongIn.Items.Add("5");
                    bacluongIn.Items.Add("6");


                    break;
                case "Viên chức A2":
                    tenngachIn.Items.Add("Giảng viên chính (hạng II)");
                    tenngachIn.Items.Add("Giáo viên dự bị đại học hạng I");
                    tenngachIn.Items.Add("Giáo viên dự bị đại học hạng II");
                    tenngachIn.Items.Add("Giảng viên cao đẳng sư phạm cao cấp (hạng II)");
                    tenngachIn.Items.Add("Giảng viên giáo dục nghề nghiệp chính (hạng II)");
                    tenngachIn.Items.Add("Giáo viên giáo dục nghề nghiệp hạng II");
                    tenngachIn.Items.Add("Giáo viên trung học phổ thông (hạng I)");
                    tenngachIn.Items.Add("Giáo viên trung học phổ thông (hạng II)");
                    tenngachIn.Items.Add("Giáo viên trung học cơ sở hạng I");
                    tenngachIn.Items.Add("Giáo viên trung học cơ sở hạng II");
                    tenngachIn.Items.Add("Giáo viên tiểu học hạng I");
                    tenngachIn.Items.Add("Giáo viên tiểu học hạng II");
                    tenngachIn.Items.Add("Giáo viên mầm non hạng I");
                    tenngachIn.Items.Add("Bác sĩ chính (hạng II)");
                    tenngachIn.Items.Add("Bác sĩ y học dự phòng chính (hạng II)");
                    tenngachIn.Items.Add("Dược sĩ chính (hạng II)");
                    tenngachIn.Items.Add("Điều dưỡng hạng II");
                    tenngachIn.Items.Add("Hộ sinh hạng II");
                    tenngachIn.Items.Add("Kỹ thuật y hạng II");
                    tenngachIn.Items.Add("Y tế công cộng chính(hạng II)");
                    tenngachIn.Items.Add("Dinh dưỡng hạng II");
                    tenngachIn.Items.Add("Dân số viên hạng II ");
                    tenngachIn.Items.Add("Kiểm định viên chính kỹ thuật an toàn lao động(hạng II)");
                    tenngachIn.Items.Add("Công tác xã hội viên chính(hạng II)");
                    tenngachIn.Items.Add("Đạo diễn nghệ thuật hạng II");
                    tenngachIn.Items.Add("Diễn viên hạng II");
                    tenngachIn.Items.Add("Di sản viên hạng II");
                    tenngachIn.Items.Add("Huấn luyện viên chính(hạng II");
                    tenngachIn.Items.Add("Nghiên cứu viên chính(Hạng II)");
                    tenngachIn.Items.Add("Kỹ sư chính(Hạng II)");
                    tenngachIn.Items.Add("Âm thanh viên hạng II");
                    tenngachIn.Items.Add("Phát thanh viên hạng II");
                    tenngachIn.Items.Add("Kỹ thuật dựng phim hạng II");
                    tenngachIn.Items.Add("Quay phim hạng II");
                    tenngachIn.Items.Add("Biên tập viên hạng II");
                    tenngachIn.Items.Add("Phóng viên hạng II");
                    tenngachIn.Items.Add("Biên dịch viên hạng II");
                    tenngachIn.Items.Add("Đạo diễn truyền hình hạng II");
                    tenngachIn.Items.Add("Kiến trúc sư Hạng II");
                    tenngachIn.Items.Add("Thẩm kế viên hạng II");
                    tenngachIn.Items.Add("Họa sĩ hạng II");
                    tenngachIn.Items.Add("Chẩn đoán viên bệnh động vật hạng II");
                    tenngachIn.Items.Add("Kiểm tra viên vệ sinh thú y hạng II");
                    tenngachIn.Items.Add("Kiểm nghiệm viên thuốc thú y hạng II");
                    tenngachIn.Items.Add("Kiểm nghiệm viên chăn nuôi hạng II");
                    tenngachIn.Items.Add("Bảo vệ viên bảo vệ thực vật hạng II");
                    tenngachIn.Items.Add("Giám định viên thuốc bảo vệ thực vật hạng II");
                    tenngachIn.Items.Add("Kiểm nghiệm viên cây trồng hạng II");
                    tenngachIn.Items.Add("Kiểm nghiệm viên thủy sản hạng II");
                    tenngachIn.Items.Add("Khuyến nông viên chính(hạng II)");
                    tenngachIn.Items.Add("Quản lý bảo vệ rừng viên chính(hạng II)");
                    tenngachIn.Items.Add("Dự báo viên khí tượng thủy văn hạng II");
                    tenngachIn.Items.Add("Phương pháp viên hạng II");
                    tenngachIn.Items.Add("Hướng dẫn viên văn hóa hạng II");
                    tenngachIn.Items.Add("Lưu trữ viên chính(hạng II)");
                    tenngachIn.Items.Add("Thư viện viên hạng II");
                    tenngachIn.Items.Add("Quan trắc viên tài nguyên môi trường hạng II");
                    tenngachIn.Items.Add("Công nghệ thông tin hạng II");
                    tenngachIn.Items.Add("An toàn thông tin hạng II");
                    tenngachIn.Items.Add("Trợ giúp viên pháp lý hạng II");
                    tenngachIn.Items.Add("Địa chính viên hạng II");
                    tenngachIn.Items.Add("Điều tra viên tài nguyên môi trường hạng II");
                    tenngachIn.Items.Add("Kiểm soát viên khí tượng thủy văn hạng II");
                    tenngachIn.Items.Add("Đo đạc bản đồ viên hạng II");

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
                    tenngachIn.Items.Add("Giảng viên (hạng III)");
                    tenngachIn.Items.Add("Trợ giảng (Hạng III)");
                    tenngachIn.Items.Add("Giáo viên dự bị đại học hạng II");
                    tenngachIn.Items.Add("Giảng viên cao đẳng sư phạm cao cấp(hạng III)");
                    tenngachIn.Items.Add("Giảng viên giáo dục nghề nghiệp lý thuyết(hạng III)");
                    tenngachIn.Items.Add("Giáo viên giáo dục nghề nghiệp lý thuyết hạng III");
                    tenngachIn.Items.Add("Giáo viên trung học phổ thông hạng III");
                    tenngachIn.Items.Add("Giáo viên trung học cơ sở hạng III");
                    tenngachIn.Items.Add("Giáo viên tiểu học hạng III");
                    tenngachIn.Items.Add("Giáo viên mầm non hạng II");
                    tenngachIn.Items.Add("Bác sĩ(hạng III)");
                    tenngachIn.Items.Add("Bác sĩ y học dự phòng(hạng III)");
                    tenngachIn.Items.Add("Dược sĩ(hạng III)");
                    tenngachIn.Items.Add("Điều dưỡng hạng III");
                    tenngachIn.Items.Add("Hộ sinh hạng III");
                    tenngachIn.Items.Add("Kỹ thuật y hạng III");
                    tenngachIn.Items.Add("Dinh dưỡng hạng III");
                    tenngachIn.Items.Add("Y tế công cộng(hạng III)");
                    tenngachIn.Items.Add("Dân số viên hạng III");
                    tenngachIn.Items.Add("Kiểm định viên kỹ thuật an toàn lao động(hạng III)");
                    tenngachIn.Items.Add("Công tác xã hội viên(hạng III)");
                    tenngachIn.Items.Add("Đạo diễn nghệ thuật hạng III");
                    tenngachIn.Items.Add("Diễn viên hạng III");
                    tenngachIn.Items.Add("Di sản viên hạng III");
                    tenngachIn.Items.Add("Huấn luyện viên(hạng III)");
                    tenngachIn.Items.Add("Nghiên cứu viên(Hạng III)");
                    tenngachIn.Items.Add("Kỹ sư(Hạng III)");
                    tenngachIn.Items.Add("Âm thanh viên hạng III");
                    tenngachIn.Items.Add("Phát thanh viên hạng II");
                    tenngachIn.Items.Add("Kỹ thuật dựng phim hạng III");
                    tenngachIn.Items.Add("Quay phim hạng III");
                    tenngachIn.Items.Add("Biên tập viên hạng III");
                    tenngachIn.Items.Add("Phóng viên hạng III");
                    tenngachIn.Items.Add("Biên dịch viên hạng III");
                    tenngachIn.Items.Add("Đạo diễn truyền hình hạng III");
                    tenngachIn.Items.Add("Kiến trúc sư Hạng III");
                    tenngachIn.Items.Add("Thẩm kế viên hạng III");
                    tenngachIn.Items.Add("Họa sĩ hạng III");
                    tenngachIn.Items.Add("Chẩn đoán viên bệnh động vật hạng III");
                    tenngachIn.Items.Add("Kiểm tra viên vệ sinh thú y hạng III");
                    tenngachIn.Items.Add("Kiểm nghiệm viên thuốc thú y hạng III");
                    tenngachIn.Items.Add("Kiểm nghiệm viên chăn nuôi hạng III");
                    tenngachIn.Items.Add("Kiểm nghiệm viên thủy sản hạng III");
                    tenngachIn.Items.Add("Khuyến nông viên(hạng III)");
                    tenngachIn.Items.Add("Quản lý bảo vệ rừng viên(hạng III)");
                    tenngachIn.Items.Add("Bảo vệ viên bảo vệ thực vật hạng III");
                    tenngachIn.Items.Add("Giám định viên thuốc bảo vệ thực vật hạng III");
                    tenngachIn.Items.Add("Kiểm nghiệm viên cây trồng hạng III");
                    tenngachIn.Items.Add("Dự báo viên khí tượng thủy văn hạng III");
                    tenngachIn.Items.Add("Phương pháp viên hạng III");
                    tenngachIn.Items.Add("Hướng dẫn viên văn hóa hạng III");
                    tenngachIn.Items.Add("Lưu trữ viên(hạng II)");
                    tenngachIn.Items.Add("Thư viện viên hạng III");
                    tenngachIn.Items.Add("Quan trắc viên tài nguyên môi trường hạng III");
                    tenngachIn.Items.Add("Công nghệ thông tin hạng III");
                    tenngachIn.Items.Add("An toàn thông tin hạng III");
                    tenngachIn.Items.Add("Trợ giúp viên pháp lý hạng III");
                    tenngachIn.Items.Add("Địa chính viên hạng III");
                    tenngachIn.Items.Add("Điều tra viên tài nguyên môi trường hạng III");
                    tenngachIn.Items.Add("Kiểm soát viên khí tượng thủy văn hạng III");
                    tenngachIn.Items.Add("Đo đạc bản đồ viên hạng III");

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
                    tenngachIn.Items.Add("Đo đạc bản đồ viên hạng III");
                    tenngachIn.Items.Add("Giảng viên giáo dục nghề nghiệp thực hành(hạng III)");
                    tenngachIn.Items.Add("Giáo viên giáo dục nghề nghiệp thực hành hạng III");
                    tenngachIn.Items.Add("Giáo viên mầm non hạng III");
                    tenngachIn.Items.Add("Dinh dưỡng hạng IV");
                    tenngachIn.Items.Add("Điều dưỡng hạng IV");
                    tenngachIn.Items.Add("Hộ sinh hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật y hạng IV");
                    tenngachIn.Items.Add("Dược hạng IV");
                    tenngachIn.Items.Add("Dân số viên hạng IV");

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
                    tenngachIn.Items.Add("Giáo viên giáo dục nghề nghiệp hạng IV");
                    tenngachIn.Items.Add("Nhân viên hỗ trợ giáo dục người khuyết tật(hạng IV)");
                    tenngachIn.Items.Add("Y sĩ hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật viên kiểm định kỹ thuật an toàn lao động(hạng IV)");
                    tenngachIn.Items.Add("Nhân viên công tác xã hội(hạng IV)");
                    tenngachIn.Items.Add("Đạo diễn nghệ thuật hạng IV");
                    tenngachIn.Items.Add("Diễn viên hạng IV");
                    tenngachIn.Items.Add("Di sản viên hạng IV");
                    tenngachIn.Items.Add("Hướng dẫn viên(hạng IV");
                    tenngachIn.Items.Add("Trợ lý nghiên cứu(hạng IV)");
                    tenngachIn.Items.Add("Kỹ thuật viên(hạng IV)");
                    tenngachIn.Items.Add("Âm thanh viên hạng IV");
                    tenngachIn.Items.Add("Phát thanh viên hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật dựng phim hạng IV");
                    tenngachIn.Items.Add("Quay phim hạng IV");
                    tenngachIn.Items.Add("Thẩm kế viên hạng IV");
                    tenngachIn.Items.Add("Họa sĩ hạng IV");
                    tenngachIn.Items.Add("Chẩn đoán viên bệnh động vật hạng IV");
                    tenngachIn.Items.Add("Kiểm tra viên vệ sinh thú y hạng IV");
                    tenngachIn.Items.Add("Kiểm nghiệm viên thuốc thú y hạng IV");
                    tenngachIn.Items.Add("Kiểm nghiệm viên chăn nuôi hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật viên kiểm nghiệm thủy sản hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật viên khuyến nông(hạng IV)");
                    tenngachIn.Items.Add("Kỹ thuật viên quản lý bảo vệ rừng(hạng IV)");
                    tenngachIn.Items.Add("Kỹ thuật viên bảo vệ thực vật hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật viên giám định thuốc bảo vệ thực vật hạng IV");
                    tenngachIn.Items.Add("Kỹ thuật viên kiểm nghiệm cây trồng hạng IV");
                    tenngachIn.Items.Add("Dự báo viên khí tượng thủy văn hạng IV");
                    tenngachIn.Items.Add("Phương pháp viên hạng IV");
                    tenngachIn.Items.Add("Hướng dẫn viên văn hóa hạng IV");
                    tenngachIn.Items.Add("Lưu trữ viên trung cấp(hạng IV)");
                    tenngachIn.Items.Add("Thư viện viên hạng IV");
                    tenngachIn.Items.Add("Quan trắc viên tài nguyên môi trường hạng III");
                    tenngachIn.Items.Add("Y công");
                    tenngachIn.Items.Add("Hộ lý");
                    tenngachIn.Items.Add("Nhân viên nhà xác");
                    tenngachIn.Items.Add("Dược tá");
                    tenngachIn.Items.Add("Công nghệ thông tin hạng IV");
                    tenngachIn.Items.Add("An toàn thông tin hạng IV");
                    tenngachIn.Items.Add("Địa chính viên hạng IV");
                    tenngachIn.Items.Add("Điều tra viên tài nguyên môi trường hạng IV");
                    tenngachIn.Items.Add("Kiểm soát viên khí tượng thủy văn hạng IV");
                    tenngachIn.Items.Add("Đo đạc bản đồ viên hạng IV");

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

        private void bacluongIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaingachIn.SelectedItem.ToString() == "Công chức A3 (A3.1)")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "6.2";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.56";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.92";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "7.28";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.64";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "8.00";
            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức A3 (A3.2)")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "5.75";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.11";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.47";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "6.83";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.19";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "7.55";
            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức A2 (A2.1)")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "4.4";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "4.74";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "5.08";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "5.42";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "5.76";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "6.1";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "6.44";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.78";

            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức A2 (A2.2)")
            {
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.00";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.34";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.68";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "5.02";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "5.36";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "5.70";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.04";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.38";

            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức A1")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.34";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.67";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "3.00";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.33";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.66";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.99";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "4.32";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.65";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.98";
            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức A0")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.1";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.41";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.72";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.03";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.34";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.65";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.96";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.27";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.58";
                if (bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "4.89";
            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức B")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.86";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.06";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.26";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.46";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.66";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.86";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.06";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "3.26";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.46";
                if (bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.66";
                if (bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.86";
                if (bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "4.06";

            }
            if (loaingachIn.SelectedItem.ToString() == "Công chức C")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.65";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "1.83";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.01";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.19";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.37";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.55";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "2.73";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "2.91";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.09";
                if (bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.27";
                if (bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.45";
                if (bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "3.63";
            }
            if (loaingachIn.SelectedItem.ToString() == "Viên chức A3")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "6.2";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "6.56";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "6.92";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "7.28";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "7.64";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "8.00";

            }
            if (loaingachIn.SelectedItem.ToString() == "Viên chức A2")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "4.4";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "4.74";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "5.08";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "5.42";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "5.76";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "6.1";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "6.44";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "6.78";

            }
            if (loaingachIn.SelectedItem.ToString() == "Viên chức A1")
            {

                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.34";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.67";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "3";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.33";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.66";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.99";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "4.32";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.65";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.98";

            }
            if (loaingachIn.SelectedItem.ToString() == "Viên chức A0")
            {

                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "2.1";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.41";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.72";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "3.03";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "3.34";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "3.65";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.96";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "4.27";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "4.58";
                if (bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "4.89";

            }
            if (loaingachIn.SelectedItem.ToString() == "Viên chức B")
            {
                if (bacluongIn.SelectedItem.ToString() == "1") hesoIn.Text = "1.86";
                if (bacluongIn.SelectedItem.ToString() == "2") hesoIn.Text = "2.06";
                if (bacluongIn.SelectedItem.ToString() == "3") hesoIn.Text = "2.26";
                if (bacluongIn.SelectedItem.ToString() == "4") hesoIn.Text = "2.46";
                if (bacluongIn.SelectedItem.ToString() == "5") hesoIn.Text = "2.66";
                if (bacluongIn.SelectedItem.ToString() == "6") hesoIn.Text = "2.86";
                if (bacluongIn.SelectedItem.ToString() == "7") hesoIn.Text = "3.06";
                if (bacluongIn.SelectedItem.ToString() == "8") hesoIn.Text = "3.26";
                if (bacluongIn.SelectedItem.ToString() == "9") hesoIn.Text = "3.46";
                if (bacluongIn.SelectedItem.ToString() == "10") hesoIn.Text = "3.66";
                if (bacluongIn.SelectedItem.ToString() == "11") hesoIn.Text = "3.86";
                if (bacluongIn.SelectedItem.ToString() == "12") hesoIn.Text = "4.06";
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void hesoIn__TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        public void DisplayDaoTao()
        {
            DataGridViewColumn batdau = dtDaotao.Columns["Column7"];
            batdau.DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridViewColumn kethuc = dtDaotao.Columns["Column8"];
            kethuc.DefaultCellStyle.Format = "dd/MM/yyyy";

            DbDaoTaoBoiDuongChuyenMon.DisplayAndSearchDaoTao(id, dtDaotao);
        }
        public void DisplayQuaTrinh()
        {
            DataGridViewColumn batdau = dtQuaTrinh.Columns["dataGridViewTextBoxColumn4"];
            batdau.DefaultCellStyle.Format = "dd/MM/yyyy";
            DataGridViewColumn kethuc = dtQuaTrinh.Columns["dataGridViewTextBoxColumn5"];
            kethuc.DefaultCellStyle.Format = "dd/MM/yyyy";

            DbQuaTrinhCongTac.DisplayAndSearchQuaTrinh(id, dtQuaTrinh);
        }
        public void DisplayLichSu()
        {
            if (ditu)
            {
                prisonCB.CheckState = CheckState.Checked;
                lydoIn.Text = lydoditu;
                batdauIn.Value = batdauditu;
                ketthucIn.Value = ketthucditu;
            }
            else
            {
                prisonCB.CheckState = CheckState.Unchecked;
                lydoIn.Text = string.Empty;
                batdauIn.Value = DateTime.Now;
                ketthucIn.Value = DateTime.Now;
            }
            if (lamviecchochedocu)
            {
                lamviecchedocuCB.CheckState = CheckState.Checked;
                cqIn.Text = coquanlsbt;
                cvIn.Text = chucvulsbt;
                diadiemIn.Text = diadiem;
                thoigianIn.Text = thoigianlamviec.ToString();
            }
            else
            {
                lamviecchedocuCB.CheckState = CheckState.Unchecked;
                cqIn.Text = cvIn.Text = diadiemIn.Text = string.Empty;
                thoigianIn.Text = "0";
            }
            if (quanhevoitochucnuocngoai)
            {
                quanhevoitochucnuocngoaiCB.CheckState = CheckState.Checked;
                mucdichIn.Text = mucdich;
                tentochucIn.Text = tentochuc;
                diadiemtrusoIn.Text = diadiemtruso;
            }
            else
            {
                quanhevoitochucnuocngoaiCB.CheckState = CheckState.Unchecked;
                mucdichIn.Text = tentochucIn.Text = diadiemtrusoIn.Text = string.Empty;
            }
            if (conguoinhaonn)
            {
                nguoinhaonuocngoaiCB.CheckState = CheckState.Checked;
                quanhenguoinhaIn.Text = quanhenguoinha;
                nghenghiepnguoinhaIn.Text = nghenghieplsbt;
                noionguoinhaIn.Text = noiolsbt;
            }
            else
            {
                nguoinhaonuocngoaiCB.CheckState = CheckState.Unchecked;
                quanhenguoinhaIn.Text = nghenghiepnguoinhaIn.Text = noionguoinhaIn.Text = noiolsbt = string.Empty;
            }
            return;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ttcbPage)
            {

            }
            else if (tabControl1.SelectedTab == dtcmnvPage)
            {
                DisplayDaoTao();
            }
            else if (tabControl1.SelectedTab == lsbtPage)
            {
                DisplayLichSu();
            }
            else if (tabControl1.SelectedTab == qtctPage)
            {
                DisplayQuaTrinh();
            }
            else if (tabControl1.SelectedTab == qhgdPage)
            {
                DisplayQuanhe();
            }
        }

        private void ttcbPage_Click(object sender, EventArgs e)
        {

        }

        private void input2__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }




        public void Update()
        {
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
                pictureBox1.ImageLocation = imgpath;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.IconChar = FontAwesome.Sharp.IconChar.Camera;
                pictureBox1.IconColor = Color.Gray;
                pictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            label4.Text = "Cập nhật cán bộ";
            btnDangky.Text = "Cập nhật";
            fullnameInput.Text = fullname;

            othernameIn.Text = othername;
            dantocIn.Text = dantoc;
            tongiaoIn.Text = tongiao;
            gioitinhIn.SelectedItem = gioitinh;
            loaingachIn.SelectedItem = nghachcongchuc;
            tenngachIn.SelectedItem = tenngach;
            bacluongIn.SelectedItem = bacluong.ToString();
            hesoIn.Text = heso.ToString();
            hokhauIn.Text = hokhau;
            noisinhIn.Text = noisinh;
            queIn.Text = quequan;
            noioIn.Text = noio;
            nghenghiepIn.Text = nghenghiep;
            coquanIn.Text = coquan;
            chucvuIn.Text = chucvu;
            bacluongIn.SelectedItem = bacluong;
            hesoIn.Text = heso.ToString();
            phuccapCVIn.Text = phucapCV.ToString();
            phucapKhacIn.Text = phucapkhac.ToString();
            quanhamIn.Text = quanham;
            danhhieuIn.Text = danhhieu;
            khenthuongIn.Text = danhhieu;
            kyluatIn.Text = kyluat;
            chieucaoIn.Text = chieucao;
            cannangIn.Text = cannang;
            nhommauIn.Text = nhommau;
            hangthuongbinhIn.Text = hangthuongbinh;
            giadinhchinhsachIn.Text = giadinhchinhsach;
            socmndIn.Text = socmnd;
            mabhxhIn.Text = mabhxh;
            ngaytuyendungIn.Value = dtngaytuyendung;
            ngaybonhiemIn.Value = dtngaybonhiem;
            ngaysinhIn.Value = dtngaysinh;
            ngayvaodangIn.Value = dtngayvaodang;
            ngaychinhthucIn.Value = dtngaychinhthuc;
            ngaynhapnguIn.Value = dtngaynhapngu;
            ngayxuatnguIn.Value = dtngayxuatngu;
            ngaycapCMNDIn.Value = dtngaycapcmnd;
        }
        public CanBoInfomation()
        {
            InitializeComponent();
        }
        public CanBoInfomation(ListCanbo parent)
        {
            InitializeComponent();
            _parent = parent;
        }



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = opnfd.FileName;
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private byte[] convert()
        {
            FileStream fs = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return data;
        }

        public void Clear()
        {

            fullnameInput.Text = othernameIn.Text = dantocIn.Text = tongiaoIn.Text = hokhauIn.Text = noisinhIn.Text = queIn.Text = noioIn.Text = nghenghiepIn.Text = coquanIn.Text = chucvuIn.Text = phuccapCVIn.Text = phucapKhacIn.Text = quanhamIn.Text = danhhieuIn.Text = khenthuongIn.Text = kyluatIn.Text = chieucaoIn.Text = cannangIn.Text = nhommauIn.Text = hangthuongbinhIn.Text = giadinhchinhsachIn.Text = socmndIn.Text = mabhxhIn.Text = string.Empty;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //check các điều kiện
                float nb;
                int number;
                //int bacluong = Convert.ToInt32(bacluongIn.SelectedItem.ToString());
                //int phucapCV = Convert.ToInt32(phuccapCVIn.Text);
                //int phucapkhac = Convert.ToInt32(phucapKhacIn.Text);
                int bacluong = 0;
                int phucapCV = 0;
                int phucapkhac = 0;
                //float heso = (float)Math.Round(float.Parse(hesoIn.Text), 2);
                float heso = 0;
                if (!float.TryParse(hesoIn.Text, out heso))
                {
                    MessageBox.Show("Hệ số là số, yêu cầu bạn nhập lại!");
                    return;

                }

                if (!int.TryParse(phucapKhacIn.Text, out phucapkhac))
                {
                    MessageBox.Show("Phụ cấp khác là số, yêu cầu bạn nhập lại!");
                    return;

                }


                if (!int.TryParse(phuccapCVIn.Text, out phucapCV))
                {
                    MessageBox.Show("Phụ cấp chức vụ là số, yêu cầu bạn nhập lại!");
                    return;

                }
                if (bacluongIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Yêu cầu bạn chọn bậc lương");
                    return;

                }
                if (!int.TryParse(bacluongIn.SelectedItem.ToString(), out bacluong))
                {
                    MessageBox.Show("Bậc lương là số, yêu cầu bạn chọn lại!");
                    return;
                }
                if (loaingachIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Yêu cầu bạn chọn nghạch công chức");
                    return;

                }
                if (gioitinhIn.SelectedIndex == -1)
                {
                    MessageBox.Show("Yêu cầu bạn chọn giới tính");
                    return;

                }
                byte[] image = convert();
                string imgpath = pictureBox1.ImageLocation.ToString();
                string fullname = fullnameInput.Text;
                string othername = othernameIn.Text;
                string dantoc = dantocIn.Text;
                string tongiao = tongiaoIn.Text;
                string gioitinh = gioitinhIn.SelectedItem.ToString();
                string hokhau = hokhauIn.Text;
                string noisinh = noisinhIn.Text;
                string quequan = queIn.Text;
                string noio = noioIn.Text;
                string nghenghiep = nghenghiepIn.Text;
                string coquan = coquanIn.Text;
                string chucvu = chucvuIn.Text;

                string quanham = quanhamIn.Text;
                string danhhieu = danhhieuIn.Text;
                string khenthuong = khenthuongIn.Text;
                string kyluat = kyluatIn.Text;
                string nghachcongchuc = loaingachIn.SelectedItem.ToString();
                string tenngach = tenngachIn.SelectedItem.ToString();
                string chieucao = chieucaoIn.Text;
                string cannang = cannangIn.Text;
                string nhommau = nhommauIn.Text;
                string hangthuongbinh = hangthuongbinhIn.Text;
                string giadinhchinhsach = giadinhchinhsachIn.Text;
                string socmnd = socmndIn.Text;
                string mabhxh = mabhxhIn.Text;
                DateTime dtngaytuyendung = ngaytuyendungIn.Value;
                DateTime dtngaybonhiem = ngaybonhiemIn.Value;
                DateTime dtngaysinh = ngaysinhIn.Value;
                DateTime dtngayvaodang = ngayvaodangIn.Value;
                DateTime dtngaychinhthuc = ngaychinhthucIn.Value;
                DateTime dtngaynhapngu = ngaynhapnguIn.Value;
                DateTime dtngayxuatngu = ngayxuatnguIn.Value;
                DateTime dtngaycapcmnd = ngaycapCMNDIn.Value;

                bool lamviecchochedocu = lamviecchedocuCB.Checked;

                string coquanlsbt;
                string diadiemlsbt;
                string chucvulsbt;
                int thoigianlamviec;

                if (!lamviecchochedocu)
                {
                    coquanlsbt = "Không";
                    diadiemlsbt = "Không";
                    chucvulsbt = "Không";
                    thoigianlamviec = 0;
                }
                else
                {
                    coquanlsbt = cqIn.Text;
                    diadiemlsbt = diadiemIn.Text;
                    chucvulsbt = cvIn.Text;
                    if (!int.TryParse(thoigianIn.Text, out thoigianlamviec))
                    {
                        MessageBox.Show("Thời gian làm việc là số, yêu cầu bạn nhập lại!");
                        return;
                    }

                }


                bool ditu = prisonCB.Checked;
                string lydoditu;
                DateTime batdauditu;
                DateTime ketthucditu;
                if (!ditu)
                {
                    lydoditu = "Không";
                    batdauditu = DateTime.Now;
                    ketthucditu = DateTime.Now;
                }
                else
                {
                    lydoditu = lydoIn.Text;
                    batdauditu = batdauIn.Value;
                    ketthucditu = ketthucIn.Value;
                }
                bool quanhevoitochucnuocngoai = quanhevoitochucnuocngoaiCB.Checked;
                string mucdichqh;
                string tentochuc;
                string diadiemtruso;
                if (!quanhevoitochucnuocngoai)
                {
                    mucdichqh = "Không";
                    tentochuc = "Không";
                    diadiemtruso = "Không";
                }
                else
                {
                    mucdichqh = mucdichIn.Text;
                    tentochuc = tentochucIn.Text;
                    diadiemtruso = diadiemIn.Text;
                }

                bool conguoinhaonn = nguoinhaonuocngoaiCB.Checked;
                string quanhenuocngoai;
                string nghenghiepnguoinha;
                string noionguoinha;
                if (!conguoinhaonn)
                {
                    quanhenuocngoai = "Không";
                    nghenghiepnguoinha = "Không";
                    noionguoinha = "Không";
                }
                else
                {
                    quanhenuocngoai = quanhenguoinhaIn.Text;
                    nghenghiepnguoinha = nghenghiepnguoinhaIn.Text;
                    noionguoinha = noionguoinhaIn.Text;
                }



                if (btnDangky.Text == "Cập nhật")
                {
                    CanBo cb = new CanBo(fullname, dtngaysinh, image, imgpath, dantoc, tongiao, gioitinh, hokhau, othername, noisinh, quequan, noio, nghenghiep, dtngaytuyendung, coquan, chucvu, dtngaybonhiem, nghachcongchuc, tenngach, bacluong, heso, phucapCV, phucapkhac, dtngayvaodang, dtngaychinhthuc, dtngaynhapngu, dtngayxuatngu, dtngaycapcmnd, quanham, danhhieu, khenthuong, kyluat, chieucao, cannang, nhommau, hangthuongbinh, giadinhchinhsach, socmnd, mabhxh);
                    LichSuBanThan lsbt = new LichSuBanThan(lydoditu, coquanlsbt, diadiemlsbt, chucvulsbt, thoigianlamviec, mucdichqh, tentochuc, diadiemtruso, quanhenuocngoai, nghenghiepnguoinha, noionguoinha, batdauditu, ketthucditu, ditu, lamviecchochedocu, quanhevoitochucnuocngoai, conguoinhaonn, id);

                    if (!haslsbt)
                    {
                        DbLichSuBanThan.addLichSu(lsbt);
                    }
                    else
                    {
                        DbLichSuBanThan.updateLichSu(lsbt, maLSBT);
                        DisplayLichSu();
                    }
                    DbCanBo.updateCanBo(cb, id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dtQuaTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.loadPreviousForm();
        }
    }
}
