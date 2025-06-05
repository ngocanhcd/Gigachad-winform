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

namespace GUI_PolyCafe
{
    public partial class FrmTicket : Form
    {
        BLL_ChiTietPhieu bll = new BLL_ChiTietPhieu();
        BLL_SanPham bllSP = new BLL_SanPham();
        BLL_PhieuBanHang bllPBH = new BLL_PhieuBanHang();
        public FrmTicket()
        {
            InitializeComponent();
            Load += FrmTicket_Load;
        }

        private void LoadData()
        {
            guna2DataGridView2.DataSource = bll.GetTableChiTietPhieu();
            dgvThonTinPhieu.DataSource = bllPBH.GetTablePhieu();

            comboBox1.DataSource = bllPBH.GetTablePhieu();
            comboBox1.DisplayMember = "MaPhieu";
            comboBox1.ValueMember = "MaPhieu";

            comboBox2.DataSource = bllSP.GetTableSanPham();
            comboBox2.DisplayMember = "TenSanPham";
            comboBox2.ValueMember = "MaSanPham";

            // Đổi tên cột nếu tồn tại
            if (guna2DataGridView2.Columns["Id"] != null)
                guna2DataGridView2.Columns["Id"].HeaderText = "ID";
            if (guna2DataGridView2.Columns["MaPhieu"] != null)
                guna2DataGridView2.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
            if (guna2DataGridView2.Columns["MaSanPham"] != null)
                guna2DataGridView2.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            if (guna2DataGridView2.Columns["TenSanPham"] != null)
                guna2DataGridView2.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            if (guna2DataGridView2.Columns["SoLuong"] != null)
                guna2DataGridView2.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (guna2DataGridView2.Columns["DonGia"] != null)
                guna2DataGridView2.Columns["DonGia"].HeaderText = "Đơn Giá";

            if (dgvThonTinPhieu.Columns["MaPhieu"] != null)
                dgvThonTinPhieu.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            if (dgvThonTinPhieu.Columns["MaThe"] != null)
                dgvThonTinPhieu.Columns["MaThe"].HeaderText = "Mã thẻ";
            if (dgvThonTinPhieu.Columns["MaNhanVien"] != null)
                dgvThonTinPhieu.Columns["MaNhanVien"].HeaderText = "Nhân viên";
            if (dgvThonTinPhieu.Columns["NgayTao"] != null)
                dgvThonTinPhieu.Columns["NgayTao"].HeaderText = "Ngày tạo";
            if (dgvThonTinPhieu.Columns["TrangThai"] != null)
                dgvThonTinPhieu.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                DataTable dt = bllSP.GetTableSanPham();
                var row = dt.Select($"MaSanPham = '{comboBox2.SelectedValue}'").FirstOrDefault();
                if (row != null)
                    textBox11.Text = row["DonGia"].ToString();
            }
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            bool kq = bll.ThemChiTiet(comboBox1.Text, comboBox2.SelectedValue.ToString(),
                int.Parse(textBox10.Text), decimal.Parse(textBox11.Text));
            if (kq) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thất bại");
            LoadData();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.CurrentRow != null)
            {
                int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["Id"].Value);
                bool kq = bll.SuaChiTiet(id, comboBox1.Text, comboBox2.SelectedValue.ToString(),
                    int.Parse(textBox10.Text), decimal.Parse(textBox11.Text));
                if (kq) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Thất bại");
                LoadData();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView2.CurrentRow != null)
            {
                int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["Id"].Value);
                bool kq = bll.XoaChiTiet(id);
                if (kq) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Thất bại");
                LoadData();
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                comboBox1.Text = guna2DataGridView2.Rows[i].Cells["MaPhieu"].Value.ToString();
                comboBox2.SelectedValue = guna2DataGridView2.Rows[i].Cells["MaSanPham"].Value.ToString();
                textBox10.Text = guna2DataGridView2.Rows[i].Cells["SoLuong"].Value.ToString();
                textBox11.Text = guna2DataGridView2.Rows[i].Cells["DonGia"].Value.ToString();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = txtMaThe.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            DateTime ngayTao = dtpNgayTao.Value;
            bool trangThai = rdoDaThanhToan.Checked;

            bool kq = bllPBH.ThemPhieu(maPhieu, maThe, maNV, ngayTao, trangThai);
            MessageBox.Show(kq ? "Thêm phiếu thành công" : "Thêm thất bại");
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = txtMaThe.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            DateTime ngayTao = dtpNgayTao.Value;
            bool trangThai = rdoDaThanhToan.Checked;

            bool kq = bllPBH.SuaPhieu(maPhieu, maThe, maNV, ngayTao, trangThai);
            MessageBox.Show(kq ? "Sửa phiếu thành công" : "Sửa thất bại");
            LoadData();
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            bool kq = bllPBH.XoaPhieu(maPhieu);
            MessageBox.Show(kq ? "Xóa phiếu thành công" : "Xóa thất bại");
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtMaThe.Clear();
            txtMaNV.Clear();
            dtpNgayTao.Value = DateTime.Now;
            rdoChoXacNhan.Checked = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            bool kq = bllPBH.CapNhatTrangThaiThanhToan(maPhieu);
            MessageBox.Show(kq ? "Thanh toán thành công!" : "Không thể thanh toán");
            LoadData();
        }

        private void dgvThonTinPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThonTinPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaPhieu.Text = dgvThonTinPhieu.Rows[i].Cells["MaPhieu"].Value.ToString();
                txtMaThe.Text = dgvThonTinPhieu.Rows[i].Cells["MaThe"].Value.ToString();
                txtMaNV.Text = dgvThonTinPhieu.Rows[i].Cells["MaNhanVien"].Value.ToString();
                dtpNgayTao.Value = Convert.ToDateTime(dgvThonTinPhieu.Rows[i].Cells["NgayTao"].Value);
                bool daThanhToan = Convert.ToBoolean(dgvThonTinPhieu.Rows[i].Cells["TrangThai"].Value);
                if (daThanhToan)
                    rdoDaThanhToan.Checked = true;
                else
                    rdoChoXacNhan.Checked = true;
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
