using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BLL_PolyCafe;
using Guna.UI2.WinForms;

namespace GUI_PolyCafe
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        private void FrmProduct_Load_1(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLoaiSanPham();
            LoadLoaiToComboBox();
        }

        BLL_SanPham bllSP = new BLL_SanPham();
        DataTable table_sanpham = new DataTable();

        private void LoadSanPham()
        {
            table_sanpham = bllSP.GetTableSanPham();
            dataGridView1.DataSource = table_sanpham;
        }
        BLL_LoaiSanPham bllLoai = new BLL_LoaiSanPham();
        DataTable table_loaisanpham = new DataTable();
        private void LoadLoaiSanPham()
        {

        }

        private void LoadLoaiToComboBox()
        {
            DataTable dt = bllLoai.GetTableLoaiSanPham();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool kq = bllSP.ThemSanPham(guna2TextBox1.Text.Trim(), guna2TextBox2.Text.Trim(),
                decimal.Parse(guna2TextBox3.Text.Trim()), comboBox1.SelectedValue.ToString(),
                guna2RadioButton1.Checked, guna2PictureBox1.ImageLocation ?? "");

            if (kq) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thất bại");
            LoadSanPham();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bool kq = bllSP.SuaSanPham(guna2TextBox1.Text.Trim(), guna2TextBox2.Text.Trim(),
                decimal.Parse(guna2TextBox3.Text.Trim()), comboBox1.SelectedValue.ToString(),
                guna2RadioButton1.Checked, guna2PictureBox1.ImageLocation ?? "");

            if (kq) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Thất bại");
            LoadSanPham();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool kq = bllSP.XoaSanPham(guna2TextBox1.Text.Trim());
                if (kq) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Thất bại");
                LoadSanPham();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear(); guna2TextBox2.Clear(); guna2TextBox3.Clear(); guna2PictureBox1.ImageLocation = null;
            comboBox1.SelectedIndex = 0; guna2RadioButton1.Checked = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                guna2TextBox1.Text = dataGridView1.Rows[i].Cells["MaSanPham"].Value.ToString();
                guna2TextBox2.Text = dataGridView1.Rows[i].Cells["TenSanPham"].Value.ToString();
                guna2TextBox3.Text = dataGridView1.Rows[i].Cells["DonGia"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells["TenLoai"].Value.ToString();
                guna2RadioButton1.Checked = dataGridView1.Rows[i].Cells["TrangThai"].Value.ToString() == "1";
                guna2PictureBox1.ImageLocation = "images/" + dataGridView1.Rows[i].Cells["HinhAnh"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
             
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
