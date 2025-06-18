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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class FrmLoaiSanPham : Form
    {
        public FrmLoaiSanPham()
        {
            InitializeComponent();
            LoadLoaiSanPham();
           
        }
        BLL_LoaiSanPham bllLoai = new BLL_LoaiSanPham();
        DataTable table_loaisanpham = new DataTable();

        private void LoadLoaiSanPham()
        {
            table_loaisanpham = bllLoai.GetTableLoaiSanPham();
            dataGridView2.DataSource = table_loaisanpham;
            dataGridView2.Columns["MaLoai"].HeaderText = "Mã loại";
            dataGridView2.Columns["MaLoai"].Name = "MaLoai";  // Quan trọng!
            dataGridView2.Columns["TenLoai"].Name = "TenLoai";
            dataGridView2.Columns["GhiChu"].Name = "GhiChu";
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                guna2TextBox8.Text = dataGridView2.Rows[i].Cells["MaLoai"].Value.ToString();
                guna2TextBox7.Text = dataGridView2.Rows[i].Cells["TenLoai"].Value.ToString();
                guna2TextBox6.Text = dataGridView2.Rows[i].Cells["GhiChu"].Value.ToString();
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            bool kq = bllLoai.ThemLoai(guna2TextBox8.Text.Trim(), guna2TextBox7.Text.Trim(), guna2TextBox6.Text.Trim());
            if (kq) MessageBox.Show("Thêm thành công"); else MessageBox.Show("Thất bại");
            LoadLoaiSanPham();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            bool kq = bllLoai.SuaLoai(guna2TextBox8.Text.Trim(), guna2TextBox7.Text.Trim(), guna2TextBox6.Text.Trim());
            if (kq) MessageBox.Show("Sửa thành công"); else MessageBox.Show("Thất bại");
            LoadLoaiSanPham();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            bool kq = bllLoai.XoaLoai(guna2TextBox8.Text.Trim());
            if (kq) MessageBox.Show("Xóa thành công"); else MessageBox.Show("Thất bại");
            LoadLoaiSanPham();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2TextBox8.Clear(); guna2TextBox7.Clear(); guna2TextBox6.Clear();
        }
    }
}
