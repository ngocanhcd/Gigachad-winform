using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Tắt toàn bộ ứng dụng
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.ShowDialog(); // Mở và chặn form cha cho tới khi đóng
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog(); // Mở và chặn form cha cho tới khi đóng
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.ShowDialog();
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheLuuDong frmTheLuuDong = new FrmTheLuuDong();
            frmTheLuuDong.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForgetPassword frmForgetPassword = new FrmForgetPassword();
            frmForgetPassword.ShowDialog();
        }

        private void tKDoanhThuTheoSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeSanPham frmThongKeSanPham = new FrmThongKeSanPham();
            frmThongKeSanPham.ShowDialog();
        }

        private void tKDoanhThuTheoNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKeTheoNhanVien frmThongKeTheoNhanVien = new FrmThongKeTheoNhanVien();
            frmThongKeTheoNhanVien.ShowDialog();
        }
    }
}
