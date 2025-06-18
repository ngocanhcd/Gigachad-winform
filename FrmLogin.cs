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
using BLL_PolyCafe;
using DTO_PolyCafe;
using UTIL_PolyCafe;


namespace GUI_PolyCafe
{
    public partial class FrmLogin : Form
    {
        BLL_NhanVien bllNhanVien = new BLL_NhanVien(); // đúng lớp
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tài khoản quản trị đặc biệt
            //if (username == "admin" && password == "123")
            //{
            //    NhanVien admin = new NhanVien()
            //    {
            //        MaNhanVien = "AD001",
            //        Email = "admin",
            //        MatKhau = "123",
            //        HoTen = "Quản trị viên",
            //        TrangThai = true
            //    };
            //    AuthUtil.user = admin;
            //    this.Hide(); // Ẩn login
            //    FrmMenu frmMenu = new FrmMenu();
            //    frmMenu.Show(); // Dùng Show thay vì ShowDialog
            //    this.Close(); // Đóng luôn login sau khi mở form chính
            //}

            // Tài khoản người dùng thường
            NhanVien nhanvien = bllNhanVien.SelectByUsername(username);
            if (nhanvien == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!nhanvien.MatKhau.Equals(password))
            {
                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhanvien.TrangThai)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                AuthUtil.user = nhanvien;
                this.Hide(); // Ẩn login
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show(); // Dùng Show thay vì ShowDialog
                this.Close(); // Đóng luôn login sau khi mở form chính
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit(); // Tắt toàn bộ ứng dụng
            //}
            Application.Exit(); // Tắt toàn bộ ứng dụng
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkShowPass.Checked ? '\0' : '●';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtMatKhau.PasswordChar = '●'; // Ẩn mật khẩu khi form mở
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit(); // Tắt toàn bộ ứng dụng
            //}

            Application.Exit(); // Tắt toàn bộ ứng dụng
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2HtmlLabel1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmForgetPassword frmDMK = new FrmForgetPassword();
            frmDMK.ShowDialog();
        }

        private void guna2HtmlLabel1_MouseHover(object sender, EventArgs e)
        {
            
    
        }

        private void guna2HtmlLabel1_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_MouseEnter_1(object sender, EventArgs e)
        {

        }
    }
}
