using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static BLL_PolyCafe.BLL_NhanVien;

namespace GUI_PolyCafe
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        BLL_NhanVien bll_nhanvien = new BLL_NhanVien();

        DataTable table_nhanvien = new DataTable();


        private void LoadNhanVien()
        {
            table_nhanvien = bll_nhanvien.GetTableNhanVien();
            dataGridView1.DataSource = table_nhanvien;           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim();
            string tenNV = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string matKhau = textBox4.Text.Trim();
            string xacNhanMatKhau = textBox5.Text.Trim();
            bool vaiTro = radioButton1.Checked; // true nếu là quản lý, false nếu là nhân viên



            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            BLL_NhanVien bll = new BLL_NhanVien();
            var ketQua = bll.ThemNhanVienV2(maNV, tenNV, email, matKhau, vaiTro);

            switch (ketQua)
            {
                case ThemNhanVienResult.ThanhCong:
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadNhanVien();
                    break;

                case ThemNhanVienResult.MaTrung:
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    break;

                case ThemNhanVienResult.EmailTrung:
                    MessageBox.Show("Email đã được sử dụng!");
                    break;

                default:
                    MessageBox.Show("Thêm thất bại. Vui lòng thử lại!");
                    break;
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string maNhanVien = textBox1.Text.Trim();
            string hoTen = textBox2.Text.Trim();
            string email = textBox3.Text.Trim();
            string matKhau = textBox4.Text.Trim();
            string xacNhan = textBox5.Text.Trim();
            bool vaiTro = radioButton1.Checked;

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
                return;
            }

            if (matKhau != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            BLL_NhanVien bll = new BLL_NhanVien();
            bool ketQua = bll.SuaNhanVien(maNhanVien, hoTen, email, matKhau, vaiTro);

            if (ketQua)
            {
                MessageBox.Show("Sửa nhân viên thành công!");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa thất bại.");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string maNhanVien = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                BLL_NhanVien bll = new BLL_NhanVien();
                bool ketQua = bll.XoaNhanVien(maNhanVien);

                if (ketQua)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            textBox1.Focus(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["MaNhanVien"].Value?.ToString();
                textBox2.Text = row.Cells["HoTen"].Value?.ToString();
                textBox3.Text = row.Cells["Email"].Value?.ToString();
                textBox4.Text = row.Cells["MatKhau"].Value?.ToString();
                textBox5.Text = row.Cells["MatKhau"].Value?.ToString();
                textBox1.Enabled = false; // Không cho phép sửa mã nhân viên
                textBox2.Enabled = true; // Cho phép sửa tên nhân viên
                textBox3.Enabled = false; // Cho phép sửa email

                bool isQuanLy = false;
                bool.TryParse(row.Cells["VaiTro"].Value?.ToString(), out isQuanLy);
                radioButton1.Checked = isQuanLy;
                radioButton2.Checked = !isQuanLy;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
