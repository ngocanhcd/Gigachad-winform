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
    public partial class FrmTheLuuDong : Form
    {
        BLL_TheLuuDong bll = new BLL_TheLuuDong();

        public FrmTheLuuDong()
        {
            InitializeComponent();
            Load += FrmTheLuuDong_Load;
        }

        private void LoadData()
        {
            dgvTheLuuDong.DataSource = bll.GetTableThe();
            dgvTheLuuDong.Columns["MaThe"].HeaderText = "Mã thẻ";
            dgvTheLuuDong.Columns["ChuSoHuu"].HeaderText = "Chủ sở hữu";
            dgvTheLuuDong.Columns["TrangThai"].HeaderText = "Trạng thái";
            txtMaThe.Text = GenerateNextMaThe();
        }

        private string GenerateNextMaThe()
        {
            DataTable dt = bll.GetTableThe();
            int max = 0;
            foreach (DataRow row in dt.Rows)
            {
                string ma = row["MaThe"].ToString();
                if (ma.StartsWith("T") && int.TryParse(ma.Substring(1), out int so))
                {
                    if (so > max) max = so;
                }
            }
            return $"T{(max + 1).ToString("D3")}";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();
            bool trangThai = chkHoatDong.Checked;

            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng nhập Chủ sở hữu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            DataTable dt = bll.GetTableThe();
            bool maTheDaTonTai = dt.AsEnumerable().Any(row => row["MaThe"].ToString() == maThe);
            if (maTheDaTonTai)
            {
                MessageBox.Show("Mã thẻ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            bool kq = bll.ThemThe(maThe, chuSoHuu, trangThai);
            MessageBox.Show(kq ? "Thêm thẻ thành công" : "Mã thẻ đã tồn tại");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();
            bool trangThai = chkHoatDong.Checked;

            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng nhập Chủ sở hữu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool kq = bll.SuaThe(maThe, chuSoHuu, trangThai);
            MessageBox.Show(kq ? "Sửa thẻ thành công" : "Sửa thất bại");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaThe.Text.Trim();
            string chuSoHuu = txtChuSoHuu.Text.Trim();

            bool kq = bll.XoaThe(ma);

            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng nhập Chủ sở hữu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(kq ? "Xóa thẻ thành công" : "Xóa thất bại");
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaThe.Text = GenerateNextMaThe();
            txtChuSoHuu.Clear();
            chkHoatDong.Checked = false;
        }

        private void txtMaThe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChuSoHuu_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaThe.ReadOnly = true;
        }

        private void dgvTheLuuDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaThe.Text = dgvTheLuuDong.Rows[i].Cells["MaThe"].Value.ToString();
                txtChuSoHuu.Text = dgvTheLuuDong.Rows[i].Cells["ChuSoHuu"].Value.ToString();
                chkHoatDong.Checked = dgvTheLuuDong.Rows[i].Cells["TrangThai"].ToString() == "1";
            }
        }
    }
}
