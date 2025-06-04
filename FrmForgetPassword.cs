using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PolyCafe;
using BLL_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FrmForgetPassword : Form
    {
        public FrmForgetPassword()
        {
            InitializeComponent();
        }
        BLL_NhanVien bllNhanVien = new BLL_NhanVien(); // đúng lớp


        public FrmForgetPassword(string maNV, string hoTen)
        {
            InitializeComponent();
            
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmForgetPassword_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtMaNhanVien.Text = AuthUtil.user.MaNhanVien;
                txtTenNhanVien.Text = AuthUtil.user.HoTen;
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (!txtMaKhauMoi.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AuthUtil.user.MatKhau = txtMaKhauMoi.Text;
                    bllNhanVien.Update(AuthUtil.user);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void chkHienThiMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = chkHienThiMatKhauCu.Checked ? '\0' : '*';
        }

        private void chkHienThiMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhauMoi.PasswordChar = chkHienThiMatKhauMoi.Checked ? '\0' : '*';

        }

        private void chkHienThiXacNhanMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMatKhau.PasswordChar = chkHienThiXacNhanMatKhau.Checked ? '\0' : '*';

        }
    }
}
